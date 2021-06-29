using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Reflection;
using iTextSharp.text.pdf;
using iTextSharp.text;
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
        
        private SqlConnection _sqlConnection = new(@"Server=localhost\SQLEXPRESS;Database=COVIDVACCDB;Trusted_Connection=True;");
        private SqlCommand _sqlCommand = new SqlCommand();
        private SqlDataReader _sqlReader;

        private void EnterButton_Click(object sender, EventArgs e)
        {
            try
            {
                _sqlConnection.Open();

                string searchCitizen = "SELECT CITIZEN.dui AS DUI, first_name AS 'NOMBRES', last_name AS 'APELLIDOS', birthday AS 'FECHA DE NACIMIENTO', email AS 'CORREO ELECTRONICO', CITY.city_name AS 'CIUDAD DE ORIGEN', INSTITUTION.institution_name AS 'INSTITUCION' FROM CITIZEN, CITY, INSTITUTION WHERE dui = '"+DUITB.Text+"' AND CITIZEN.city_id = CITY.id AND CITIZEN.institution_id = INSTITUTION.id";
                string searchAppointment = "SELECT id AS 'ID DE CITA', app_date AS 'FECHA', app_time AS 'HORA', cabin_id AS 'CABINA' FROM VACCINATION_APPOINTMENT WHERE citizen_id = '"+DUITB.Text+"'";
                string searchVaccProcc = "SELECT VACCINATION_PROCESS.id AS 'PROCESO ID', VACCINATION_APPOINTMENT.id AS 'CITA ID', dui AS 'DUI', process_time AS 'HORA DE LLEGADA', vacc_time AS 'HORA DE VACUNACION' FROM CITIZEN, VACCINATION_APPOINTMENT, VACCINATION_PROCESS WHERE CITIZEN.dui = VACCINATION_APPOINTMENT.citizen_id AND VACCINATION_APPOINTMENT.id = VACCINATION_PROCESS.vacc_app_id AND dui = '"+DUITB.Text+"'";
                string searchSideEffects = "SELECT vacc_process AS 'PROCESO ID', SYMPTOM.symptom AS 'SÍNTOMA', DATEDIFF(HOUR, vacc_time, symptom_time) AS 'MINUTOS' FROM VACCINATION_PROCESS, SIDE_EFFECTS, SYMPTOM, VACCINATION_APPOINTMENT, CITIZEN WHERE SYMPTOM.id = SIDE_EFFECTS.symptom_id AND VACCINATION_PROCESS.id = SIDE_EFFECTS.vacc_process AND VACCINATION_PROCESS.vacc_app_id = VACCINATION_APPOINTMENT.id AND VACCINATION_APPOINTMENT.citizen_id = CITIZEN.dui AND citizen_id = '"+DUITB.Text+"'";
                SqlDataAdapter sqlAdapter1 = new SqlDataAdapter(searchCitizen, _sqlConnection);
                SqlDataAdapter sqlAdapter2 = new SqlDataAdapter(searchAppointment, _sqlConnection);
                SqlDataAdapter sqlAdapter3 = new SqlDataAdapter(searchVaccProcc, _sqlConnection);
                SqlDataAdapter sqlAdapter4 = new SqlDataAdapter(searchSideEffects, _sqlConnection);
                DataTable citizenTable = new DataTable();
                DataTable appointmentTable = new DataTable();
                DataTable proccTable = new DataTable();
                DataTable symptomTable = new DataTable();
                sqlAdapter1.Fill(citizenTable);
                sqlAdapter2.Fill(appointmentTable);
                sqlAdapter3.Fill(proccTable);
                sqlAdapter4.Fill(symptomTable);
                CitizenDGV.DataSource = citizenTable;
                AppointmentsDGV.DataSource = appointmentTable;
                dataGridView1.DataSource = proccTable;
                dataGridView2.DataSource = symptomTable;
                _sqlCommand = new SqlCommand(searchCitizen, _sqlConnection);
                _sqlCommand = new SqlCommand(searchAppointment, _sqlConnection);
                _sqlCommand = new SqlCommand(searchVaccProcc, _sqlConnection);
                _sqlCommand = new SqlCommand(searchSideEffects, _sqlConnection);
                _sqlReader = _sqlCommand.ExecuteReader();
                _sqlConnection.Close();

            }
            catch (Exception exception)
            {
                MessageBox.Show("No se pueden mostrar los datos", "Oops", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }


        private void PrintButton_Click(object sender, EventArgs e)
        {
          PdfPTable pdfTable = new PdfPTable(CitizenDGV.ColumnCount);
            pdfTable.DefaultCell.Padding = 3;
            pdfTable.WidthPercentage = 80;
            pdfTable.HorizontalAlignment = Element.ALIGN_CENTER;
            pdfTable.DefaultCell.BorderWidth = 1;
            pdfTable.SpacingAfter = 12.5f;
 
            
            foreach (DataGridViewColumn column in CitizenDGV.Columns)
            {
                PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText));
                
                pdfTable.AddCell(cell);
            }
 

            foreach (DataGridViewRow row in CitizenDGV.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    pdfTable.AddCell(cell.Value.ToString());
                }
            }
 

            PdfPTable pdfTable2 = new PdfPTable(AppointmentsDGV.ColumnCount);
            pdfTable2.DefaultCell.Padding = 3;
            pdfTable2.WidthPercentage = 50;
            pdfTable2.HorizontalAlignment = Element.ALIGN_CENTER;
            pdfTable2.DefaultCell.BorderWidth = 1;

            foreach (DataGridViewColumn column in AppointmentsDGV.Columns)
            {
                PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText));
                
                pdfTable2.AddCell(cell);
            }

            foreach (DataGridViewRow row in AppointmentsDGV.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    pdfTable2.AddCell(cell.Value.ToString());
                }
            }

            string folderPath = "C:\\PDFs\\";
            string citizenId = DUITB.Text;

            if (!Directory.Exists(folderPath))
            {
                Directory.CreateDirectory(folderPath);
            }

            using (FileStream stream = new FileStream(folderPath + citizenId +".pdf", FileMode.Create))

            {
                Document pdfDoc = new Document(PageSize.A2, 10f, 10f, 10f, 0f);
                PdfWriter.GetInstance(pdfDoc, stream);
                pdfDoc.Open();
                pdfDoc.Add(pdfTable);
                pdfDoc.Add(pdfTable2);
                pdfDoc.Close();
                stream.Close();
            }

            MessageBox.Show("El archivo se encuentra ubicado en carpeta PDFs en disco local", "GUARDADO",
                MessageBoxButtons.OK);


            }

        }
    }



