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
        
        SqlConnection _sqlConnection = new(@"Server=localhost\SQLEXPRESS;Database=COVIDVACCDB;Trusted_Connection=True;");
        private SqlCommand _sqlCommand = new SqlCommand();
        
        private SqlDataReader _sqlReader;

        private void EnterButton_Click(object sender, EventArgs e)
        {
            try
            {
                _sqlConnection.Open();
                string searchCitizen = "SELECT CITIZEN.dui AS DUI, first_name AS 'NOMBRES', last_name AS 'APELLIDOS', birthday AS 'FECHA DE NACIMIENTO', email AS 'CORREO ELECTRONICO', CITY.city_name AS 'CIUDAD DE ORIGEN', INSTITUTION.institution_name AS 'INSTITUCION' FROM CITIZEN, CITY, INSTITUTION WHERE dui = '"+DUITB.Text+"' AND CITIZEN.city_id = CITY.id AND CITIZEN.institution_id = INSTITUTION.id";
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



