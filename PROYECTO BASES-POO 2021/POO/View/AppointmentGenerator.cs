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
            var listVacc = db.VaccinationAppointments
                .ToList();
            var listCitizen = db.Citizens
                .ToList();

            var result = listVacc.Where(
                u => u.CitizenId.Equals(DUITB.Text)
            ).ToList();

            var resultCit = listCitizen.Where(
                u => u.Dui.Equals(DUITB.Text)
            ).ToList();

            if (resultCit.Count == 0)
            {
                MessageBox.Show("El dui ingresado, no existe", "Vacunacion",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {

                if (result.Count == 0)
                {

                    DateTime finish = new DateTime(2021, 10, 1);
                    Random gen = new Random();

                    int range = (finish - DateTime.Today).Days;
                    DateTime DateVaccine = DateTime.Today.AddDays(gen.Next(range));
                    DateTime newDateVaccine = DateVaccine.AddDays(42);

                    Random random = new Random();
                    TimeSpan start = TimeSpan.FromHours(7);
                    TimeSpan end = TimeSpan.FromHours(11);
                    int maxMinutes = (int) ((end - start).TotalMinutes);

                    int minutes = random.Next(maxMinutes);
                    TimeSpan time = start.Add(TimeSpan.FromMinutes(minutes));

<<<<<<< HEAD:PROYECTO BASES-POO 2021/Programación Orientada a Objetos/View/AppointmentGenerator.cs
                   VaccinationAppointment Firstapp = new VaccinationAppointment
                {
=======

                    Random rnd = new Random();
                    int cabinid = rnd.Next(1, 42);


>>>>>>> 926cc24f155738f3e565e63fb34e7c10e36e738c:POO/View/AppointmentGenerator.cs


                    VaccinationAppointment Firstapp = new VaccinationAppointment
                    {

<<<<<<< HEAD:PROYECTO BASES-POO 2021/Programación Orientada a Objetos/View/AppointmentGenerator.cs
                };
               VaccApp.Create(Firstapp);
               
               VaccinationAppointment Secondapp = new VaccinationAppointment
               {
=======
                        AppDate = DateVaccine,
                        AppTime = time,
                        CabinId = cabinid,
                        CitizenId = DUITB.Text,
>>>>>>> 926cc24f155738f3e565e63fb34e7c10e36e738c:POO/View/AppointmentGenerator.cs


                    };
                    VaccApp.Create(Firstapp);
                    VaccinationAppointment Secondapp = new VaccinationAppointment
                    {

                        AppDate = newDateVaccine,
                        AppTime = time,
                        CabinId = cabinid,
                        CitizenId = DUITB.Text,

                    };
                    VaccApp.Create(Secondapp);

                    MessageBox.Show(
                        "Cita para primera y segunda dosis creada con éxito. Ve a Seguimiento de Cita para más información.",
                        "CITA",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

<<<<<<< HEAD:PROYECTO BASES-POO 2021/Programación Orientada a Objetos/View/AppointmentGenerator.cs
        }
      }
  } 
=======
                }
                else
                {
                    MessageBox.Show("Ya tiene una cita vigente", "Vacunacion",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
        }


    }
} 
>>>>>>> 926cc24f155738f3e565e63fb34e7c10e36e738c:POO/View/AppointmentGenerator.cs

