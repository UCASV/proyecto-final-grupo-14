#nullable enable
using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace COVIDVACCSYSTEM.View
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        
        private void MainWindow_Load(object sender, EventArgs e)
        {
            HomeButton_Click(null, e);
        }
        
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private static extern void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private static extern void SendMessage(IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void OpenForm(object openForm)
        {
            if (this.ContainerPanel.Controls.Count > 0)
            {
                this.ContainerPanel.Controls.RemoveAt(0);
            }
                
            Form op = openForm as Form ?? throw new InvalidOperationException();
            op.TopLevel = false;
            op.Dock = DockStyle.Fill;
            this.ContainerPanel.Controls.Add(op);
            this.ControlPanel.Tag = op;
            op.Show();
        }
        
        private void HomeButton_Click(object? sender, EventArgs e)
        {
            OpenForm(new Home());
        }
        
        private void NewCitizenButton_Click(object sender, EventArgs e)
        {
            OpenForm(new CitizenRegistration());
        }

        private void NewAppointmentButton_Click(object sender, EventArgs e)
        {
            OpenForm(new AppointmentGenerator());
        }

        private void AppointmentTrackingButton_Click(object sender, EventArgs e)
        {
             OpenForm(new AppointmentTracking());
        }

        private void NewVaccProcessButton_Click(object sender, EventArgs e)
        {
            OpenForm(new VaccinationProcess());
        }
        
        private void StatisticsButton_Click(object? sender, EventArgs e)
        {
            OpenForm(new Statistics());
        }
        
        private void SINAVACCPB_Click(object sender, EventArgs e)
        {
            OpenForm(new SINAVACC19());
        }
        
        private void CloseButtonPB_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MinimizeButtonPB_Click(object? sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void MoveButtonPB_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }


       
    }
}