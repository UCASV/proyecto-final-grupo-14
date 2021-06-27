using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace COVIDVACCSYSTEM.View
{
    public partial class AppointmentTracking : Form
    {
        public AppointmentTracking()
        {
            
            InitializeComponent();
        }
        
        SqlConnection _sqlConnection = new(@"Server=localhost\SQLEXPRESS;Database=COVIDVACCDB;Trusted_Connection=True;");
        private SqlCommand _sqlCommand = new SqlCommand();
        
        private SqlDataReader _sqlReader;

        private void EnterButton_Click(object sender, EventArgs e)
        {
            try
            {
                _sqlConnection.Open();
                string searchCitizen = "SELECT dui AS DUI, first_name AS 'NOMBRES', last_name AS 'APELLIDOS', birthday AS 'FECHA DE NACIMIENTO', email AS 'CORREO ELECTRONICO', city_id AS 'CIUDAD DE ORIGEN', institution_id AS 'INSTITUCION' FROM CITIZEN WHERE dui = '"+DUITB.Text+"'";
                string searchAppointment = "SELECT id AS 'ID DE CITA', app_date AS 'FECHA', app_time AS 'HORA', cabin_id AS 'CABINA' FROM VACCINATION_APPOINTMENT WHERE citizen_id = '"+DUITB.Text+"'";
                SqlDataAdapter sqlAdapter1 = new SqlDataAdapter(searchCitizen, _sqlConnection);
                SqlDataAdapter sqlAdapter2 = new SqlDataAdapter(searchAppointment, _sqlConnection);
                DataTable citizenTable = new DataTable();
                DataTable appointmentTable = new DataTable();
                sqlAdapter1.Fill(citizenTable);
                sqlAdapter2.Fill(appointmentTable);
                CitizenDGV.DataSource = citizenTable;
                AppointmentsDGV.DataSource = appointmentTable;
                _sqlCommand = new SqlCommand(searchCitizen, _sqlConnection);
                _sqlCommand = new SqlCommand(searchAppointment, _sqlConnection);
                _sqlReader = _sqlCommand.ExecuteReader();
                _sqlConnection.Close();

            }
            catch (Exception exception)
            {
                MessageBox.Show("Error");
                throw;
            }
        }
    }
}