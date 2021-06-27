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
            this.VaccinatorLbl = new System.Windows.Forms.Label();
            this.AssistantLbl = new System.Windows.Forms.Label();
            this.VaccinationTimeLbl = new System.Windows.Forms.Label();
            this.SideEffectsLbl = new System.Windows.Forms.Label();
            this.PainCheck = new System.Windows.Forms.CheckBox();
            this.SensibilityCheck = new System.Windows.Forms.CheckBox();
            this.RednessCheck = new System.Windows.Forms.CheckBox();
            this.FatigueCheck = new System.Windows.Forms.CheckBox();
            this.HeadacheCheck = new System.Windows.Forms.CheckBox();
            this.FeverCheck = new System.Windows.Forms.CheckBox();
            this.MyalgiaCheck = new System.Windows.Forms.CheckBox();
            this.ArthralgiaCheck = new System.Windows.Forms.CheckBox();
            this.AnaphylaxisCheck = new System.Windows.Forms.CheckBox();
            this.AppointmentLbl = new System.Windows.Forms.Label();
            this.VaccinatorCB = new System.Windows.Forms.ComboBox();
            this.VaccinationTimePicker = new System.Windows.Forms.DateTimePicker();
            this.AssistantCB = new System.Windows.Forms.ComboBox();
            this.AppointmentTB = new System.Windows.Forms.TextBox();
            this.InsertButton = new System.Windows.Forms.Button();
            this.ArriveTimePicker = new System.Windows.Forms.DateTimePicker();
            this.ArriveDatePicker = new System.Windows.Forms.DateTimePicker();
            this.SymptomTimePicker = new System.Windows.Forms.DateTimePicker();
            this.AddSymptomButton = new System.Windows.Forms.Button();
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
            this.ArriveDateTimeLbl.Location = new System.Drawing.Point(76, 189);
            this.ArriveDateTimeLbl.Name = "ArriveDateTimeLbl";
            this.ArriveDateTimeLbl.Size = new System.Drawing.Size(266, 50);
            this.ArriveDateTimeLbl.TabIndex = 1;
            this.ArriveDateTimeLbl.Text = "Fecha y hora de llegada";
            // 
            // VaccinatorLbl
            // 
            this.VaccinatorLbl.BackColor = System.Drawing.Color.Transparent;
            this.VaccinatorLbl.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.VaccinatorLbl.ForeColor = System.Drawing.Color.SlateGray;
            this.VaccinatorLbl.Location = new System.Drawing.Point(76, 262);
            this.VaccinatorLbl.Name = "VaccinatorLbl";
            this.VaccinatorLbl.Size = new System.Drawing.Size(160, 40);
            this.VaccinatorLbl.TabIndex = 2;
            this.VaccinatorLbl.Text = "Vacunador";
            // 
            // AssistantLbl
            // 
            this.AssistantLbl.BackColor = System.Drawing.Color.Transparent;
            this.AssistantLbl.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.AssistantLbl.ForeColor = System.Drawing.Color.SlateGray;
            this.AssistantLbl.Location = new System.Drawing.Point(76, 337);
            this.AssistantLbl.Name = "AssistantLbl";
            this.AssistantLbl.Size = new System.Drawing.Size(207, 40);
            this.AssistantLbl.TabIndex = 3;
            this.AssistantLbl.Text = "Asistente de Salud";
            // 
            // VaccinationTimeLbl
            // 
            this.VaccinationTimeLbl.BackColor = System.Drawing.Color.Transparent;
            this.VaccinationTimeLbl.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.VaccinationTimeLbl.ForeColor = System.Drawing.Color.SlateGray;
            this.VaccinationTimeLbl.Location = new System.Drawing.Point(447, 262);
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
            this.SideEffectsLbl.Location = new System.Drawing.Point(76, 402);
            this.SideEffectsLbl.Name = "SideEffectsLbl";
            this.SideEffectsLbl.Size = new System.Drawing.Size(207, 40);
            this.SideEffectsLbl.TabIndex = 5;
            this.SideEffectsLbl.Text = "Efectos Secundarios";
            // 
            // PainCheck
            // 
            this.PainCheck.BackColor = System.Drawing.Color.SlateGray;
            this.PainCheck.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.PainCheck.ForeColor = System.Drawing.Color.FromArgb(((int) (((byte) (218)))), ((int) (((byte) (218)))), ((int) (((byte) (218)))));
            this.PainCheck.Location = new System.Drawing.Point(136, 445);
            this.PainCheck.Name = "PainCheck";
            this.PainCheck.Size = new System.Drawing.Size(117, 32);
            this.PainCheck.TabIndex = 6;
            this.PainCheck.Text = "DOLOR";
            this.PainCheck.UseVisualStyleBackColor = false;
            // 
            // SensibilityCheck
            // 
            this.SensibilityCheck.BackColor = System.Drawing.Color.SlateGray;
            this.SensibilityCheck.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.SensibilityCheck.ForeColor = System.Drawing.Color.FromArgb(((int) (((byte) (218)))), ((int) (((byte) (218)))), ((int) (((byte) (218)))));
            this.SensibilityCheck.Location = new System.Drawing.Point(136, 483);
            this.SensibilityCheck.Name = "SensibilityCheck";
            this.SensibilityCheck.Size = new System.Drawing.Size(117, 32);
            this.SensibilityCheck.TabIndex = 7;
            this.SensibilityCheck.Text = "SENSIBILIDAD";
            this.SensibilityCheck.UseVisualStyleBackColor = false;
            // 
            // RednessCheck
            // 
            this.RednessCheck.BackColor = System.Drawing.Color.SlateGray;
            this.RednessCheck.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.RednessCheck.ForeColor = System.Drawing.Color.FromArgb(((int) (((byte) (218)))), ((int) (((byte) (218)))), ((int) (((byte) (218)))));
            this.RednessCheck.Location = new System.Drawing.Point(136, 521);
            this.RednessCheck.Name = "RednessCheck";
            this.RednessCheck.Size = new System.Drawing.Size(117, 32);
            this.RednessCheck.TabIndex = 8;
            this.RednessCheck.Text = "ENROJECIMIENTO";
            this.RednessCheck.UseVisualStyleBackColor = false;
            // 
            // FatigueCheck
            // 
            this.FatigueCheck.BackColor = System.Drawing.Color.SlateGray;
            this.FatigueCheck.ForeColor = System.Drawing.Color.FromArgb(((int) (((byte) (218)))), ((int) (((byte) (218)))), ((int) (((byte) (218)))));
            this.FatigueCheck.Location = new System.Drawing.Point(298, 445);
            this.FatigueCheck.Name = "FatigueCheck";
            this.FatigueCheck.Size = new System.Drawing.Size(117, 32);
            this.FatigueCheck.TabIndex = 9;
            this.FatigueCheck.Text = "FATIGA";
            this.FatigueCheck.UseVisualStyleBackColor = false;
            // 
            // HeadacheCheck
            // 
            this.HeadacheCheck.BackColor = System.Drawing.Color.SlateGray;
            this.HeadacheCheck.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.HeadacheCheck.ForeColor = System.Drawing.Color.FromArgb(((int) (((byte) (218)))), ((int) (((byte) (218)))), ((int) (((byte) (218)))));
            this.HeadacheCheck.Location = new System.Drawing.Point(298, 484);
            this.HeadacheCheck.Name = "HeadacheCheck";
            this.HeadacheCheck.Size = new System.Drawing.Size(117, 32);
            this.HeadacheCheck.TabIndex = 10;
            this.HeadacheCheck.Text = "DOLOR DE CABEZA";
            this.HeadacheCheck.UseVisualStyleBackColor = false;
            // 
            // FeverCheck
            // 
            this.FeverCheck.BackColor = System.Drawing.Color.SlateGray;
            this.FeverCheck.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.FeverCheck.ForeColor = System.Drawing.Color.FromArgb(((int) (((byte) (218)))), ((int) (((byte) (218)))), ((int) (((byte) (218)))));
            this.FeverCheck.Location = new System.Drawing.Point(298, 522);
            this.FeverCheck.Name = "FeverCheck";
            this.FeverCheck.Size = new System.Drawing.Size(117, 32);
            this.FeverCheck.TabIndex = 11;
            this.FeverCheck.Text = "FIEBRE";
            this.FeverCheck.UseVisualStyleBackColor = false;
            // 
            // MyalgiaCheck
            // 
            this.MyalgiaCheck.BackColor = System.Drawing.Color.SlateGray;
            this.MyalgiaCheck.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.MyalgiaCheck.ForeColor = System.Drawing.Color.FromArgb(((int) (((byte) (218)))), ((int) (((byte) (218)))), ((int) (((byte) (218)))));
            this.MyalgiaCheck.Location = new System.Drawing.Point(458, 445);
            this.MyalgiaCheck.Name = "MyalgiaCheck";
            this.MyalgiaCheck.Size = new System.Drawing.Size(117, 32);
            this.MyalgiaCheck.TabIndex = 12;
            this.MyalgiaCheck.Text = "MIALGIA";
            this.MyalgiaCheck.UseVisualStyleBackColor = false;
            // 
            // ArthralgiaCheck
            // 
            this.ArthralgiaCheck.BackColor = System.Drawing.Color.SlateGray;
            this.ArthralgiaCheck.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.ArthralgiaCheck.ForeColor = System.Drawing.Color.FromArgb(((int) (((byte) (218)))), ((int) (((byte) (218)))), ((int) (((byte) (218)))));
            this.ArthralgiaCheck.Location = new System.Drawing.Point(458, 483);
            this.ArthralgiaCheck.Name = "ArthralgiaCheck";
            this.ArthralgiaCheck.Size = new System.Drawing.Size(117, 32);
            this.ArthralgiaCheck.TabIndex = 13;
            this.ArthralgiaCheck.Text = "ARTRALGIA";
            this.ArthralgiaCheck.UseVisualStyleBackColor = false;
            // 
            // AnaphylaxisCheck
            // 
            this.AnaphylaxisCheck.BackColor = System.Drawing.Color.SlateGray;
            this.AnaphylaxisCheck.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.AnaphylaxisCheck.ForeColor = System.Drawing.Color.FromArgb(((int) (((byte) (218)))), ((int) (((byte) (218)))), ((int) (((byte) (218)))));
            this.AnaphylaxisCheck.Location = new System.Drawing.Point(458, 522);
            this.AnaphylaxisCheck.Name = "AnaphylaxisCheck";
            this.AnaphylaxisCheck.Size = new System.Drawing.Size(117, 32);
            this.AnaphylaxisCheck.TabIndex = 14;
            this.AnaphylaxisCheck.Text = "ANAFILAXIA";
            this.AnaphylaxisCheck.UseVisualStyleBackColor = false;
            // 
            // AppointmentLbl
            // 
            this.AppointmentLbl.BackColor = System.Drawing.Color.Transparent;
            this.AppointmentLbl.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.AppointmentLbl.ForeColor = System.Drawing.Color.SlateGray;
            this.AppointmentLbl.Location = new System.Drawing.Point(76, 117);
            this.AppointmentLbl.Name = "AppointmentLbl";
            this.AppointmentLbl.Size = new System.Drawing.Size(98, 40);
            this.AppointmentLbl.TabIndex = 15;
            this.AppointmentLbl.Text = "CITA ID";
            this.AppointmentLbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // VaccinatorCB
            // 
            this.VaccinatorCB.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.VaccinatorCB.FormattingEnabled = true;
            this.VaccinatorCB.Location = new System.Drawing.Point(205, 262);
            this.VaccinatorCB.Name = "VaccinatorCB";
            this.VaccinatorCB.Size = new System.Drawing.Size(220, 31);
            this.VaccinatorCB.TabIndex = 16;
            // 
            // VaccinationTimePicker
            // 
            this.VaccinationTimePicker.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.VaccinationTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.VaccinationTimePicker.Location = new System.Drawing.Point(673, 262);
            this.VaccinationTimePicker.Name = "VaccinationTimePicker";
            this.VaccinationTimePicker.Size = new System.Drawing.Size(167, 32);
            this.VaccinationTimePicker.TabIndex = 17;
            // 
            // AssistantCB
            // 
            this.AssistantCB.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.AssistantCB.FormattingEnabled = true;
            this.AssistantCB.Location = new System.Drawing.Point(285, 334);
            this.AssistantCB.Name = "AssistantCB";
            this.AssistantCB.Size = new System.Drawing.Size(271, 31);
            this.AssistantCB.TabIndex = 18;
            // 
            // AppointmentTB
            // 
            this.AppointmentTB.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.AppointmentTB.Location = new System.Drawing.Point(180, 123);
            this.AppointmentTB.Name = "AppointmentTB";
            this.AppointmentTB.Size = new System.Drawing.Size(264, 32);
            this.AppointmentTB.TabIndex = 32;
            // 
            // InsertButton
            // 
            this.InsertButton.BackColor = System.Drawing.Color.SlateGray;
            this.InsertButton.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.InsertButton.ForeColor = System.Drawing.Color.FromArgb(((int) (((byte) (218)))), ((int) (((byte) (218)))), ((int) (((byte) (218)))));
            this.InsertButton.Location = new System.Drawing.Point(338, 612);
            this.InsertButton.Name = "InsertButton";
            this.InsertButton.Size = new System.Drawing.Size(237, 47);
            this.InsertButton.TabIndex = 33;
            this.InsertButton.Text = "INGRESAR";
            this.InsertButton.UseVisualStyleBackColor = false;
            // 
            // ArriveTimePicker
            // 
            this.ArriveTimePicker.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.ArriveTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.ArriveTimePicker.Location = new System.Drawing.Point(673, 182);
            this.ArriveTimePicker.Name = "ArriveTimePicker";
            this.ArriveTimePicker.Size = new System.Drawing.Size(167, 32);
            this.ArriveTimePicker.TabIndex = 34;
            // 
            // ArriveDatePicker
            // 
            this.ArriveDatePicker.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.ArriveDatePicker.Location = new System.Drawing.Point(359, 182);
            this.ArriveDatePicker.Name = "ArriveDatePicker";
            this.ArriveDatePicker.Size = new System.Drawing.Size(291, 32);
            this.ArriveDatePicker.TabIndex = 35;
            // 
            // SymptomTimePicker
            // 
            this.SymptomTimePicker.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.SymptomTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.SymptomTimePicker.Location = new System.Drawing.Point(653, 447);
            this.SymptomTimePicker.Name = "SymptomTimePicker";
            this.SymptomTimePicker.Size = new System.Drawing.Size(167, 32);
            this.SymptomTimePicker.TabIndex = 36;
            // 
            // AddSymptomButton
            // 
            this.AddSymptomButton.BackColor = System.Drawing.Color.SlateGray;
            this.AddSymptomButton.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.AddSymptomButton.ForeColor = System.Drawing.Color.FromArgb(((int) (((byte) (218)))), ((int) (((byte) (218)))), ((int) (((byte) (218)))));
            this.AddSymptomButton.Location = new System.Drawing.Point(673, 500);
            this.AddSymptomButton.Name = "AddSymptomButton";
            this.AddSymptomButton.Size = new System.Drawing.Size(127, 40);
            this.AddSymptomButton.TabIndex = 37;
            this.AddSymptomButton.Text = "AÑADIR";
            this.AddSymptomButton.UseVisualStyleBackColor = false;
            // 
            // VaccinationProcess
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (218)))), ((int) (((byte) (218)))), ((int) (((byte) (218)))));
            this.BackgroundImage = ((System.Drawing.Image) (resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(954, 697);
            this.Controls.Add(this.AddSymptomButton);
            this.Controls.Add(this.SymptomTimePicker);
            this.Controls.Add(this.ArriveDatePicker);
            this.Controls.Add(this.ArriveTimePicker);
            this.Controls.Add(this.InsertButton);
            this.Controls.Add(this.AppointmentTB);
            this.Controls.Add(this.AssistantCB);
            this.Controls.Add(this.VaccinationTimePicker);
            this.Controls.Add(this.VaccinatorCB);
            this.Controls.Add(this.AppointmentLbl);
            this.Controls.Add(this.AnaphylaxisCheck);
            this.Controls.Add(this.ArthralgiaCheck);
            this.Controls.Add(this.MyalgiaCheck);
            this.Controls.Add(this.FeverCheck);
            this.Controls.Add(this.HeadacheCheck);
            this.Controls.Add(this.FatigueCheck);
            this.Controls.Add(this.RednessCheck);
            this.Controls.Add(this.SensibilityCheck);
            this.Controls.Add(this.PainCheck);
            this.Controls.Add(this.SideEffectsLbl);
            this.Controls.Add(this.VaccinationTimeLbl);
            this.Controls.Add(this.AssistantLbl);
            this.Controls.Add(this.VaccinatorLbl);
            this.Controls.Add(this.ArriveDateTimeLbl);
            this.Controls.Add(this.VaccProcessLbl);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "VaccinationProcess";
            this.Text = "VaccinationProcess";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.DateTimePicker SymptomTimePicker;
        private System.Windows.Forms.Button AddSymptomButton;

        private System.Windows.Forms.DateTimePicker ArriveTimePicker;
        private System.Windows.Forms.DateTimePicker ArriveDatePicker;

        private System.Windows.Forms.Button InsertButton;

        private System.Windows.Forms.TextBox AppointmentTB;
        

        private System.Windows.Forms.ComboBox AssistantCB;
        

        private System.Windows.Forms.DateTimePicker VaccinationTimePicker;

        private System.Windows.Forms.ComboBox VaccinatorCB;

        private System.Windows.Forms.CheckBox PainCheck;
        private System.Windows.Forms.CheckBox SensibilityCheck;
        private System.Windows.Forms.CheckBox RednessCheck;
        private System.Windows.Forms.CheckBox FatigueCheck;
        private System.Windows.Forms.CheckBox HeadacheCheck;
        private System.Windows.Forms.CheckBox FeverCheck;
        private System.Windows.Forms.CheckBox MyalgiaCheck;
        private System.Windows.Forms.CheckBox ArthralgiaCheck;
        private System.Windows.Forms.CheckBox AnaphylaxisCheck;
        private System.Windows.Forms.Label AppointmentLbl;

        private System.Windows.Forms.Label SideEffectsLbl;

        private System.Windows.Forms.Label AssistantLbl;
        private System.Windows.Forms.Label VaccinationTimeLbl;

        private System.Windows.Forms.Label VaccinatorLbl;

        private System.Windows.Forms.Label ArriveDateTimeLbl;

        private System.Windows.Forms.Label VaccProcessLbl;

        #endregion
    }
}