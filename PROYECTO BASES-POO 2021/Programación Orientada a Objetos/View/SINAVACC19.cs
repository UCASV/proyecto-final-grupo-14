using System;
using System.Data;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace COVIDVACCSYSTEM.POO.View
{
    public partial class Sinavacc19 : Form
    {
        public Sinavacc19()
        {
            InitializeComponent();
        }
        
        private void SINAVACC19_Load(object sender, EventArgs e)
        {
            CabinDgv();
            EmployeeDgv();
        }
        
        private readonly SqlConnection _sqlConnection = new(@"Server=localhost\SQLEXPRESS;Database=COVIDVACCDB;Trusted_Connection=True;");
        private SqlCommand _sqlCommand = new SqlCommand();
        
        private void CabinDgv()
        {
            _sqlConnection.Open();
            string showCabin = "SELECT CABIN.id AS 'CABINA ID', email AS 'Correo Electronico', city_name AS 'CIUDAD', state_name AS 'DEPARTAMENTO' FROM CABIN, CITY, STATE WHERE CABIN.city_id = CITY.id AND CITY.state_id = STATE.id";
            SqlDataAdapter sqlAdapter = new SqlDataAdapter(showCabin, _sqlConnection);
            DataTable cabinTable = new DataTable();
            sqlAdapter.Fill(cabinTable);
            dataGridView1.DataSource = cabinTable;
            dataGridView1.DataSource = cabinTable;
            _sqlCommand = new SqlCommand(showCabin, _sqlConnection);
            SqlDataReader sqlReader = _sqlCommand.ExecuteReader();
            _sqlConnection.Close();
        }
        private void EmployeeDgv()
        {
            _sqlConnection.Open();
            string showEmployee = "SELECT EMPLOYEE.id AS 'EMPLEADO ID', first_name AS 'Nombre', last_name AS 'Apellido', institutional_mail AS 'Correo institucional', EMPLOYEE_TYPE.employee_type AS 'Cargo', CITY.city_name AS 'Ciudad', STATE.state_name AS 'Departamento' FROM EMPLOYEE, CITY, EMPLOYEE_TYPE, STATE WHERE  EMPLOYEE.employee_type_id = EMPLOYEE_TYPE.id AND EMPLOYEE.city_id = CITY.id AND CITY.state_id = STATE.id";
            SqlDataAdapter sqlAdapter = new SqlDataAdapter(showEmployee, _sqlConnection);
            DataTable employeeTable = new DataTable();
            sqlAdapter.Fill(employeeTable);
            dataGridView2.DataSource = employeeTable;
            dataGridView2.DataSource = employeeTable;
            _sqlCommand = new SqlCommand(showEmployee, _sqlConnection);
            SqlDataReader sqlReader = _sqlCommand.ExecuteReader();
            _sqlConnection.Close();
        }

        
    }
}