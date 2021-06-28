using System;
using System.Windows.Forms;

using System.Data.SqlClient;
using COVIDVACCSYSTEM.COVIDVACCDBContext;
using Microsoft.Data.SqlClient;


namespace COVIDVACCSYSTEM.View
{
    public partial class VaccinationProcess : Form
    {
        public VaccinationProcess()
        {
            InitializeComponent();
        }


        private void InsertButton_Click(object sender, EventArgs e)
        {
            TimeSpan arriveTime = ArriveTimePicker.Value.TimeOfDay;
            TimeSpan vaccinationTime = VaccinationTimePicker.Value.TimeOfDay;

            COVIDVACCDBContext.VaccinationProcess oneProcess = new COVIDVACCDBContext.VaccinationProcess()
            {
                ProcessDate = ArriveDatePicker.Value,
                ProcessTime = arriveTime,
                VaccinationTime = vaccinationTime,
                /*VaccinationAppId = ,
                SideEffectsId = ,
                SideEffects = ,
                Employeexprocesses = ,*/
            };

        }
    }
}