using System;
using System.Windows.Forms;
using System.Data;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms.VisualStyles;
using COVIDVACCSYSTEM.COVIDVACCDBContext;
using COVIDVACCSYSTEM.ViewModels.Services;


namespace COVIDVACCSYSTEM.View
{
    public partial class CitizenRegistration : Form
    {
        private CitizenServices citizen;
        private StateServices state;
        private InstitutionServices inst;
        private ChronicIlnessServices chronic;
        private AilmentServices ailm;
        private CitizenPhoneNumberServices phonenum;
        private CityServices cityy;
        public CitizenRegistration()
        {
            InitializeComponent();
            citizen = new CitizenServices();
            state = new StateServices();
            inst = new InstitutionServices();
            chronic = new ChronicIlnessServices();
            ailm = new AilmentServices();
            phonenum = new CitizenPhoneNumberServices();
            cityy = new CityServices();
        }


        private void RegisterButton_Click(object sender, EventArgs e)
        {

            bool verify = DuiTB.Text.Length == 8;
            

            if (verify)
            {
                var _context = new COVIDVACCDBContext.COVIDVACCDBContext();

                City citychosen = new City();
                citychosen.Id = ((City) CityCB.SelectedItem).Id;
                City dbcity = _context.Set<City>().SingleOrDefault(c => c.Id == citychosen.Id);

                Institution instchosen = new Institution();
                instchosen.Id = ((Institution) InstitutionCB.SelectedItem).Id;
                Institution dbinst = _context.Set<Institution>().SingleOrDefault(i => i.Id == instchosen.Id);

               
                var newCitizen = new Citizen
                {
                    FirstName = FirstNameTB.Text,
                    LastName = LastNameTB.Text,
                    Dui = DuiTB.Text,
                    Email = EmailTB.Text,
                    City = dbcity,
                    Birthday = BirthdayDTP.Value,
                    Institution = dbinst
                   
                };

                _context.Add(newCitizen);
                
                CitizenPhoneNumber phone = new CitizenPhoneNumber
                {
                    PhoneNumber = PhoneNumberTB.Text,
                    Citizen = newCitizen
                };

                _context.Add(phone);
                
                foreach (ChronicIllness illness in ailmentLB.Items)
                {
                    verify =  ((ChronicIllness) ailmentLB.SelectedItem).Id == illness.Id;
                      
                   //solo jala uno
                    if (verify)
                    {
                        ChronicIllness chro = new ChronicIllness();
                        chro.Id = ((ChronicIllness) ailmentLB.SelectedItem).Id;
                        ChronicIllness dbChronic = _context.Set<ChronicIllness>().SingleOrDefault(c => c.Id == chro.Id);

                        Ailment ailments = new Ailment
                        {
                            Citizen = newCitizen,
                            //IllnessId = illness.Id
                        };
                        
                        ailments.Illness = dbChronic;

                        _context.Add(ailments);
                    }
       
                }
              
                _context.SaveChanges();

                MessageBox.Show("Ciudadano creado exitosamente", "Ciudadano creado", MessageBoxButtons.OK);
            }
            else
                MessageBox.Show("Usuario no puede ser registrado ya que no es pertenece a un grupo de prioridad o DUI ingresado erroneamente",
                    "REGISTRO DE USUARIO INVALIDO", MessageBoxButtons.OK);
        }

        private void CitizenRegistration_Load(object sender, EventArgs e)
        {
            DepartmentCB.DataSource = state.GetAll();
            DepartmentCB.DisplayMember = "StateName";
            DepartmentCB.ValueMember = "Id";
            //CityCB.Enabled = false;

            CityCB.DataSource = cityy.GetAll();
            CityCB.DisplayMember = "CityName";
            CityCB.ValueMember = "Id";
            
            InstitutionCB.DataSource = inst.GetAll();
            InstitutionCB.DisplayMember = "InstitutionName";
            InstitutionCB.ValueMember = "Id";

            ailmentLB.DataSource = chronic.GetAll();
            ailmentLB.DisplayMember = "Illness";
            ailmentLB.ValueMember = "Id";
            
            

        }

        private void DepartmentCB_SelectionChangeCommitted(object sender, EventArgs e)
        {
            //CityCB.Enabled = false;
            //CityCB.DataSource = null;

            /*if (DepartmentCB.SelectedValue.ToString() != "0")
            {
                string line = string.Format("SELECT CITY.id, CITY.city_name FROM CITY WHERE CITY.state_id = {0} ",
                    DepartmentCB.SelectedValue);
                CityCB.DataSource = this.GetData(line);
                CityCB.DisplayMember = "CityName";
                CityCB.ValueMember = "Id";
                CityCB.Enabled = true;
            }*/
        }
    }
}


