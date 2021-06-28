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

            bool verify = DuiTB.Text.Length == 9;
            bool cases = BirthdayDTP.Value >= DateTime.Today.AddYears(-60) || InstitutionCB.SelectedIndex == 2 ||
                         InstitutionCB.SelectedIndex == 3 || InstitutionCB.SelectedIndex == 4;
            bool case5 = BirthdayDTP.Value >= DateTime.Today.AddYears(-18) && ailmentLB.SelectedItems.Count >= 1;
            var _context = new COVIDVACCDBContext.COVIDVACCDBContext();

            var listCitizens = _context.Citizens.ToList();
            var result = listCitizens.Where(c => c.Dui.Equals(DuiTB.Text)).ToList();

            if (result.Count == 0)
            {
                if (verify) 
                {
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
                    
                    
                    foreach (var ailmentLbSelectedItem in ailmentLB.SelectedItems)
                    {
                       
                            ChronicIllness chro = new ChronicIllness();
                            chro.Id = ((ChronicIllness) ailmentLbSelectedItem).Id;
                            ChronicIllness dbChronic = _context.Set<ChronicIllness>().SingleOrDefault(c => c.Id == chro.Id);

                            Ailment ailments = new Ailment
                            {
                                Citizen = newCitizen,
                                
                            };
                            
                            ailments.Illness = dbChronic;

                            _context.Add(ailments);
                        
                    }
                   
                  
                    _context.SaveChanges();

                    MessageBox.Show("Ciudadano creado exitosamente", "Ciudadano creado", MessageBoxButtons.OK);
                }
                else
                    MessageBox.Show("Usuario no puede ser registrado ya que no es pertenece a un grupo de prioridad o DUI ingresado erroneamente",
                        "REGISTRO DE USUARIO INVALIDO", MessageBoxButtons.OK);
            }
            else
                MessageBox.Show("El ciudadano ya ha sido registrado en la pltaforma con anterioridad", "ERROR", MessageBoxButtons.OK);
            

           
        }

        private void CitizenRegistration_Load(object sender, EventArgs e)
        {
            DepartmentCB.DataSource = state.GetAll();
            DepartmentCB.DisplayMember = "StateName";
            DepartmentCB.ValueMember = "Id";
            

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

      
    }
}


