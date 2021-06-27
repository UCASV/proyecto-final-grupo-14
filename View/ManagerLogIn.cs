using System;
using System.Data;
using System.Globalization;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace COVIDVACCSYSTEM.View
{
    public partial class ManagerLogIn : Form
    {
        public ManagerLogIn()
        {
            InitializeComponent();
        }
        
        SqlConnection _sqlConnection = new(@"Server=localhost\SQLEXPRESS;Database=COVIDVACCDB;Trusted_Connection=True;");
        private SqlCommand _sqlCommand = new SqlCommand();
        private SqlDataReader _sqlReader;

        private void ManagerLogin(string user, string password)
        {
            try
            {
               _sqlConnection.Open();
               
               string cmd = "SELECT username, userpassword FROM LOGIN_INFO WHERE username = '"+UsernameTB.Text+"' AND userpassword = '"+PasswordTB.Text+"'";

               _sqlCommand = new SqlCommand(cmd, _sqlConnection);
               _sqlReader = _sqlCommand.ExecuteReader();

               if (_sqlReader.HasRows)
               {
                   Form mainWindow = new MainWindow();
                   this.Hide();
                   mainWindow.Show();
                   
               }
               else
               {
                   MessageBox.Show("Datos de inicio de sesión incorrectos. Intentelo de nuevo", "INICIO DE SESIÓN INVÁLIDO", MessageBoxButtons.OK, MessageBoxIcon.Error);
               }
               
               _sqlConnection.Close();

            }
            catch (Exception loginException)
            { 
                MessageBox.Show(loginException.ToString());
                throw;
            }
            
        }

        public void NewLoginRecord(int employeeid, int cabinid)
        {
            string loginTime = DateTime.Now.ToString(CultureInfo.CurrentCulture);
            
            string recordQuery = "INSERT INTO LOGIN_RECORD (employee_id, cabin_id, login_time) VALUES (employee_id, cabin_id, login_time)";
            _sqlCommand.Parameters.Add("employee_id", SqlDbType.Int);
            _sqlCommand.Parameters["employee_id"].Value = employeeid;
            _sqlCommand.Parameters.Add("@cabin_id", SqlDbType.Int);
            _sqlCommand.Parameters["cabin_id"].Value = cabinid;
            _sqlCommand.Parameters.Add("@login_time", SqlDbType.VarChar);
            _sqlCommand.Parameters["login_time"].Value = loginTime;
            _sqlCommand = new SqlCommand(recordQuery, _sqlConnection);
            
            try
            {
                _sqlConnection.Open();
                _sqlCommand.ExecuteNonQuery();
                
                MessageBox.Show($"Bienvenid@", "REGISTRO DE INICIO DE SESION", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (SqlException e)
            {
                MessageBox.Show(e.ToString(), "REGISTRO DE INICIO DE SESION", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                _sqlConnection.Close();
            }
        }
        
        private void LogInButton_Click(object sender, EventArgs e)
        {
            ManagerLogin(UsernameTB.Text, PasswordTB.Text);
            NewLoginRecord(Int32.Parse(EmployeeIdTB.Text), Int32.Parse(CabinCB.SelectedText));
        }
    }
}