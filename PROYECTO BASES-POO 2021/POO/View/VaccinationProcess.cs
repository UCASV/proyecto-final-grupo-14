using System;
using System.Windows.Forms;

using System.Data.SqlClient;
using System.Linq;
using COVIDVACCSYSTEM.COVIDVACCDBContext;
using COVIDVACCSYSTEM.ViewModels.Services;
using Microsoft.Data.SqlClient;


namespace COVIDVACCSYSTEM.View
{
    public partial class VaccinationProcess : Form
    {
        private SymptomServices symp;
        public VaccinationProcess()
        {
            InitializeComponent();
            symp = new SymptomServices();
        }

        private void InsertButton_Click(object sender, EventArgs e)
        {
            TimeSpan arriveTime = ArriveTimePicker.Value.TimeOfDay;
            TimeSpan vaccinationTime = VaccinationTimePicker.Value.TimeOfDay;
            
            var _context = new COVIDVACCDBContext.COVIDVACCDBContext();
            var _apptid = _context.VaccinationAppointments.ToList();
            var result = _apptid.Where(v => v.Id.Equals(Int32.Parse(AppointmentTB.Text))).ToList();

            if (result.Count == 1)
            {
                VaccinationAppointment vaccappt = new VaccinationAppointment();
                vaccappt.Id = Int32.Parse(AppointmentTB.Text);
                VaccinationAppointment dbVacc =
                    _context.Set<VaccinationAppointment>().SingleOrDefault(v => v.Id == vaccappt.Id);

                COVIDVACCDBContext.VaccinationProcess oneProcess = new COVIDVACCDBContext.VaccinationProcess()
                {
                    ProcessDate = ArriveDatePicker.Value,
                    ProcessTime = arriveTime,
                    VaccTime = vaccinationTime,
                    VaccApp = dbVacc,

                };

                _context.Add(oneProcess);
                _context.SaveChanges();

                foreach (var selectedItem in sideEffectsLB.SelectedItems)
                {
                    Symptom side = new Symptom();
                    side.Id = ((Symptom) selectedItem).Id;
                    Symptom dbside = _context.Set<Symptom>().SingleOrDefault(s => s.Id == side.Id);

                    SideEffect newSymptom = new SideEffect
                    {
                        SymptomTime = DateTime.Now.TimeOfDay,
                        Symptom = dbside,
                        VaccProcessNavigation = oneProcess
                    };

                    _context.Add(newSymptom);

                }

                _context.SaveChanges();

                MessageBox.Show("La dosis fue llevada a cabo", "DOSIS", MessageBoxButtons.OK);

            }
            else
                MessageBox.Show("El ID introducido de la cita no existe, deber generar una nueva cita", "ERROR",
                    MessageBoxButtons.OK);
        }

       

        private void VaccinationProcess_Load(object sender, EventArgs e)
        {
            sideEffectsLB.DataSource = symp.GetAll();
            sideEffectsLB.DisplayMember = "Symptom1";
            sideEffectsLB.ValueMember = "Id";
        }

      
    }
}