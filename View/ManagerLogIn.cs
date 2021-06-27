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

        private void ManagerLogin()
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
                   MessageBox.Show("Datos de inicio de sesión incorrectos. Intentelo de nuevo", 
                       "INICIO DE SESIÓN INVÁLIDO", MessageBoxButtons.OK, MessageBoxIcon.Error);
               }
               
               _sqlConnection.Close();

            }
            catch (Exception loginException)
            { 
                MessageBox.Show(loginException.ToString());
                throw;
            }
            
        }

        private void NewLoginRecord()
        {
            _sqlConnection.Open();
            var recordQuery = "INSERT INTO LOGIN_RECORD (employee_id, cabin_id, login_time) VALUES (@employee_id, @cabin_id, @login_time)";
            _sqlCommand.Parameters.Add("@employee_id", SqlDbType.Int);
            _sqlCommand.Parameters["employee_id"].Value = Int32.Parse(EmployeeIdTB.Text);
            _sqlCommand.Parameters.Add("@cabin_id", SqlDbType.Int);
            _sqlCommand.Parameters["cabin_id"].Value = Int32.Parse(CabinTB.Text);
            _sqlCommand.Parameters.Add("@login_time", SqlDbType.DateTime);
            _sqlCommand.Parameters["login_time"].Value = DateTime.Now;
            _sqlCommand = new SqlCommand(recordQuery, _sqlConnection);
            _sqlCommand.ExecuteNonQuery();
            _sqlReader = _sqlCommand.ExecuteReader();
            

            if (_sqlReader.HasRows)
            {
                MessageBox.Show($"Bienvenid@", "REGISTRO DE INICIO DE SESION", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                _sqlConnection.Close();
            }
            else
            {
                MessageBox.Show("Error al registrar inicio de sesión", "REGISTRO DE INICIO DE SESION", MessageBoxButtons.OK, 
                    MessageBoxIcon.Error);    
            }
        }
        
        private void LogInButton_Click(object sender, EventArgs e)
        {
            ManagerLogin();
            NewLoginRecord();
        }

      
    }
}