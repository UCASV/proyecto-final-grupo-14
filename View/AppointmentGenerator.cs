using System;
using System.Linq;
using System.Windows.Forms;
using System.Threading.Tasks;
using System.Windows.Forms.VisualStyles;
using COVIDVACCSYSTEM.COVIDVACCDBContext;
using COVIDVACCSYSTEM.ViewModels.Services;


namespace COVIDVACCSYSTEM.View
{
    public partial class AppointmentGenerator : Form
    {

        private VaccinationAppointmentServices VaccApp;

        public AppointmentGenerator()
        {
            InitializeComponent();
           VaccApp = new VaccinationAppointmentServices();
        }
          

        private void GenerateButton_Click(object sender, EventArgs e)
        {
            var db = new COVIDVACCDBContext.COVIDVACCDBContext();
            var listUsers = db.VaccinationAppointments
                .ToList();

            var result = listUsers.Where(
                u => u.CitizenId.Equals(DUITB.Text)
            ).ToList();

            
            if (result.Count == 0)
            {

                DateTime finish = new DateTime(2021, 10, 1);
                Random gen = new Random();

                int range = (finish - DateTime.Today).Days;
                DateTime DateVaccine = DateTime.Today.AddDays(gen.Next(range));
                
                Random random = new Random();
                TimeSpan start = TimeSpan.FromHours(7);
                TimeSpan end = TimeSpan.FromHours(11);
                int maxMinutes = (int)((end - start).TotalMinutes);
                
                   int minutes = random.Next(maxMinutes);
                   TimeSpan time = start.Add(TimeSpan.FromMinutes(minutes));
                   
               
                   Random rnd = new Random();
                   int cabinid = rnd.Next(1, 42);
                
              
                

               VaccinationAppointment newapp = new VaccinationAppointment
                {
                    
                  AppDate = DateVaccine,
                  AppTime = time,
                  CabinId = cabinid,
                  CitizenId = DUITB.Text,
                  

                };
               VaccApp.Create(newapp);


            }
            else
            {
                MessageBox.Show("Ya tiene una cita vigente", "Vacunacion",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            
            
      

          }
      }
  }