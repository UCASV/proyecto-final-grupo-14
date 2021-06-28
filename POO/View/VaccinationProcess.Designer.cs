using System.ComponentModel;
using System.Windows.Forms;

namespace COVIDVACCSYSTEM.View
{
    partial class VaccinationProcess
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VaccinationProcess));
            this.VaccProcessLbl = new System.Windows.Forms.Label();
            this.ArriveDateTimeLbl = new System.Windows.Forms.Label();
            this.VaccinationTimeLbl = new System.Windows.Forms.Label();
            this.SideEffectsLbl = new System.Windows.Forms.Label();
            this.AppointmentLbl = new System.Windows.Forms.Label();
            this.VaccinationTimePicker = new System.Windows.Forms.DateTimePicker();
            this.AppointmentTB = new System.Windows.Forms.TextBox();
            this.InsertButton = new System.Windows.Forms.Button();
            this.ArriveTimePicker = new System.Windows.Forms.DateTimePicker();
            this.ArriveDatePicker = new System.Windows.Forms.DateTimePicker();
            this.sideEffectsLB = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // VaccProcessLbl
            // 
            this.VaccProcessLbl.BackColor = System.Drawing.Color.Transparent;
            this.VaccProcessLbl.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 24F, System.Drawing.FontStyle.Bold);
            this.VaccProcessLbl.ForeColor = System.Drawing.Color.SlateGray;
            this.VaccProcessLbl.Location = new System.Drawing.Point(264, 9);
            this.VaccProcessLbl.Name = "VaccProcessLbl";
            this.VaccProcessLbl.Size = new System.Drawing.Size(438, 85);
            this.VaccProcessLbl.TabIndex = 0;
            this.VaccProcessLbl.Text = "PROCESO DE VACUNACIÓN";
            this.VaccProcessLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ArriveDateTimeLbl
            // 
            this.ArriveDateTimeLbl.BackColor = System.Drawing.Color.Transparent;
            this.ArriveDateTimeLbl.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.ArriveDateTimeLbl.ForeColor = System.Drawing.Color.SlateGray;
            this.ArriveDateTimeLbl.Location = new System.Drawing.Point(85, 250);
            this.ArriveDateTimeLbl.Name = "ArriveDateTimeLbl";
            this.ArriveDateTimeLbl.Size = new System.Drawing.Size(266, 50);
            this.ArriveDateTimeLbl.TabIndex = 1;
            this.ArriveDateTimeLbl.Text = "Fecha y hora de llegada";
            // 
            // VaccinationTimeLbl
            // 
            this.VaccinationTimeLbl.BackColor = System.Drawing.Color.Transparent;
            this.VaccinationTimeLbl.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.VaccinationTimeLbl.ForeColor = System.Drawing.Color.SlateGray;
            this.VaccinationTimeLbl.Location = new System.Drawing.Point(85, 315);
            this.VaccinationTimeLbl.Name = "VaccinationTimeLbl";
            this.VaccinationTimeLbl.Size = new System.Drawing.Size(220, 40);
            this.VaccinationTimeLbl.TabIndex = 4;
            this.VaccinationTimeLbl.Text = "Hora de Vacunación";
            // 
            // SideEffectsLbl
            // 
            this.SideEffectsLbl.BackColor = System.Drawing.Color.Transparent;
            this.SideEffectsLbl.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.SideEffectsLbl.ForeColor = System.Drawing.Color.SlateGray;
            this.SideEffectsLbl.Location = new System.Drawing.Point(85, 378);
            this.SideEffectsLbl.Name = "SideEffectsLbl";
            this.SideEffectsLbl.Size = new System.Drawing.Size(207, 40);
            this.SideEffectsLbl.TabIndex = 5;
            this.SideEffectsLbl.Text = "Efectos Secundarios";
            // 
            // AppointmentLbl
            // 
            this.AppointmentLbl.BackColor = System.Drawing.Color.Transparent;
            this.AppointmentLbl.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.AppointmentLbl.ForeColor = System.Drawing.Color.SlateGray;
            this.AppointmentLbl.Location = new System.Drawing.Point(428, 124);
            this.AppointmentLbl.Name = "AppointmentLbl";
            this.AppointmentLbl.Size = new System.Drawing.Size(98, 40);
            this.AppointmentLbl.TabIndex = 15;
            this.AppointmentLbl.Text = "CITA ID";
            this.AppointmentLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // VaccinationTimePicker
            // 
            this.VaccinationTimePicker.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.VaccinationTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.VaccinationTimePicker.Location = new System.Drawing.Point(368, 308);
            this.VaccinationTimePicker.Name = "VaccinationTimePicker";
            this.VaccinationTimePicker.Size = new System.Drawing.Size(167, 32);
            this.VaccinationTimePicker.TabIndex = 17;
            // 
            // AppointmentTB
            // 
            this.AppointmentTB.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.AppointmentTB.Location = new System.Drawing.Point(347, 176);
            this.AppointmentTB.Name = "AppointmentTB";
            this.AppointmentTB.Size = new System.Drawing.Size(264, 32);
            this.AppointmentTB.TabIndex = 32;
            // 
            // InsertButton
            // 
            this.InsertButton.BackColor = System.Drawing.Color.SlateGray;
            this.InsertButton.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.InsertButton.ForeColor = System.Drawing.Color.FromArgb(((int) (((byte) (218)))), ((int) (((byte) (218)))), ((int) (((byte) (218)))));
            this.InsertButton.Location = new System.Drawing.Point(347, 588);
            this.InsertButton.Name = "InsertButton";
            this.InsertButton.Size = new System.Drawing.Size(237, 47);
            this.InsertButton.TabIndex = 33;
            this.InsertButton.Text = "INGRESAR";
            this.InsertButton.UseVisualStyleBackColor = false;
            this.InsertButton.Click += new System.EventHandler(this.InsertButton_Click);
            // 
            // ArriveTimePicker
            // 
            this.ArriveTimePicker.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.ArriveTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.ArriveTimePicker.Location = new System.Drawing.Point(682, 243);
            this.ArriveTimePicker.Name = "ArriveTimePicker";
            this.ArriveTimePicker.Size = new System.Drawing.Size(167, 32);
            this.ArriveTimePicker.TabIndex = 34;
            // 
            // ArriveDatePicker
            // 
            this.ArriveDatePicker.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.ArriveDatePicker.Location = new System.Drawing.Point(368, 243);
            this.ArriveDatePicker.Name = "ArriveDatePicker";
            this.ArriveDatePicker.Size = new System.Drawing.Size(291, 32);
            this.ArriveDatePicker.TabIndex = 35;
            // 
            // sideEffectsLB
            // 
            this.sideEffectsLB.Anchor = ((System.Windows.Forms.AnchorStyles) ((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.sideEffectsLB.ColumnWidth = 250;
            this.sideEffectsLB.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.sideEffectsLB.FormattingEnabled = true;
            this.sideEffectsLB.ItemHeight = 21;
            this.sideEffectsLB.Location = new System.Drawing.Point(211, 421);
            this.sideEffectsLB.Name = "sideEffectsLB";
            this.sideEffectsLB.ScrollAlwaysVisible = true;
            this.sideEffectsLB.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.sideEffectsLB.Size = new System.Drawing.Size(467, 109);
            this.sideEffectsLB.TabIndex = 38;
            // 
            // VaccinationProcess
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (218)))), ((int) (((byte) (218)))), ((int) (((byte) (218)))));
            this.BackgroundImage = ((System.Drawing.Image) (resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(954, 697);
            this.Controls.Add(this.sideEffectsLB);
            this.Controls.Add(this.ArriveDatePicker);
            this.Controls.Add(this.ArriveTimePicker);
            this.Controls.Add(this.InsertButton);
            this.Controls.Add(this.AppointmentTB);
            this.Controls.Add(this.VaccinationTimePicker);
            this.Controls.Add(this.AppointmentLbl);
            this.Controls.Add(this.SideEffectsLbl);
            this.Controls.Add(this.VaccinationTimeLbl);
            this.Controls.Add(this.ArriveDateTimeLbl);
            this.Controls.Add(this.VaccProcessLbl);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "VaccinationProcess";
            this.Text = "VaccinationProcess";
            this.Load += new System.EventHandler(this.VaccinationProcess_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.ListBox sideEffectsLB;


        private System.Windows.Forms.DateTimePicker ArriveTimePicker;
        private System.Windows.Forms.DateTimePicker ArriveDatePicker;

        private System.Windows.Forms.Button InsertButton;

        private System.Windows.Forms.TextBox AppointmentTB;
        

   
        

        private System.Windows.Forms.DateTimePicker VaccinationTimePicker;

     

        
        private System.Windows.Forms.Label AppointmentLbl;

        private System.Windows.Forms.Label SideEffectsLbl;

    
        private System.Windows.Forms.Label VaccinationTimeLbl;



        private System.Windows.Forms.Label ArriveDateTimeLbl;

        private System.Windows.Forms.Label VaccProcessLbl;

        #endregion
    }
}