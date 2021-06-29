using System;
using System.Data;
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

                string cmd = "SELECT username, userpassword FROM LOGIN_INFO, EMPLOYEE WHERE LOGIN_INFO.employee_id = '" + EmployeeIdTB.Text + "' AND username = '" + UsernameTB.Text + "' AND userpassword = '" + PasswordTB.Text + "'";

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
            }
            catch (Exception loginException)
            {
                MessageBox.Show("Error al iniciar sesión. Contacte con el departamento de informática",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
            finally
            {
                _sqlConnection.Close();
            }
            
        }

        private void LoginRecordSaver()
        {
            try
            {
                _sqlConnection.Open();
                _sqlCommand = new SqlCommand("NewLoginRecord", _sqlConnection);
                _sqlCommand.CommandType = CommandType.StoredProcedure;
                SqlParameter employeeParameter = new SqlParameter("@employee_id", SqlDbType.Int);
                _sqlCommand.Parameters.Add(employeeParameter).Value = Int32.Parse(EmployeeIdTB.Text);
                SqlParameter cabinParameter = new SqlParameter("@cabin_id", SqlDbType.Int);
                _sqlCommand.Parameters.Add(cabinParameter).Value = Int32.Parse(CabinTB.Text);
                SqlParameter timeParameter = new SqlParameter("@login_time", SqlDbType.DateTime);
                _sqlCommand.Parameters.Add(timeParameter).Value = DateTime.Now;
                _sqlCommand.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                MessageBox.Show("Error al iniciar sesión. Contacte con el departamento de informática",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                _sqlConnection.Close();
            } 
        }
        
        private void LogInButton_Click(object sender, EventArgs e)
        {
            ManagerLogin();
            LoginRecordSaver();
        }
        

      
    }
}