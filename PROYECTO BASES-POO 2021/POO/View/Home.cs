using System;
using System.Timers;
using System.Windows.Forms;

namespace COVIDVACCSYSTEM.View
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }
        
        private void Home_Load(object sender, EventArgs e)
        {
            Timer.Enabled = true; 
        }
        

        private void Timer_Elapsed(object sender, ElapsedEventArgs e)
        {
            TimeLbl.Text = DateTime.Now.ToString("hh:mm:ss");
            DateLbl.Text = DateTime.Now.ToLongDateString();
        }

        
    }
}