using System.ComponentModel;

namespace COVIDVACCSYSTEM.View
{
    partial class AppointmentTracking
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AppointmentTracking));
            this.TitleLbl = new System.Windows.Forms.Label();
            this.DUILbl = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.CitizenDGV = new System.Windows.Forms.DataGridView();
            this.AppointmentsDGV = new System.Windows.Forms.DataGridView();
            this.AppointmentLbl = new System.Windows.Forms.Label();
            this.CitizenLbl = new System.Windows.Forms.Label();
            this.EnterButton = new System.Windows.Forms.Button();
            this.PrintButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize) (this.CitizenDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.AppointmentsDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // TitleLbl
            // 
            this.TitleLbl.BackColor = System.Drawing.Color.Transparent;
            this.TitleLbl.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 24F, System.Drawing.FontStyle.Bold);
            this.TitleLbl.ForeColor = System.Drawing.Color.SlateGray;
            this.TitleLbl.Location = new System.Drawing.Point(239, 23);
            this.TitleLbl.Name = "TitleLbl";
            this.TitleLbl.Size = new System.Drawing.Size(467, 62);
            this.TitleLbl.TabIndex = 0;
            this.TitleLbl.Text = "SEGUIMIENTO DE CITAS";
            this.TitleLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DUILbl
            // 
            this.DUILbl.BackColor = System.Drawing.Color.Transparent;
            this.DUILbl.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.DUILbl.ForeColor = System.Drawing.Color.SlateGray;
            this.DUILbl.Location = new System.Drawing.Point(86, 121);
            this.DUILbl.Name = "DUILbl";
            this.DUILbl.Size = new System.Drawing.Size(289, 44);
            this.DUILbl.TabIndex = 1;
            this.DUILbl.Text = "Ingrese DUI";
            this.DUILbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.textBox1.Location = new System.Drawing.Point(381, 129);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(287, 32);
            this.textBox1.TabIndex = 2;
            // 
            // CitizenDGV
            // 
            this.CitizenDGV.AllowUserToAddRows = false;
            this.CitizenDGV.AllowUserToDeleteRows = false;
            this.CitizenDGV.BackgroundColor = System.Drawing.Color.SlateGray;
            this.CitizenDGV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CitizenDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CitizenDGV.GridColor = System.Drawing.Color.FromArgb(((int) (((byte) (218)))), ((int) (((byte) (218)))), ((int) (((byte) (218)))));
            this.CitizenDGV.Location = new System.Drawing.Point(87, 322);
            this.CitizenDGV.Name = "CitizenDGV";
            this.CitizenDGV.ReadOnly = true;
            this.CitizenDGV.RowTemplate.Height = 24;
            this.CitizenDGV.Size = new System.Drawing.Size(800, 90);
            this.CitizenDGV.TabIndex = 3;
            // 
            // AppointmentsDGV
            // 
            this.AppointmentsDGV.AllowUserToAddRows = false;
            this.AppointmentsDGV.AllowUserToDeleteRows = false;
            this.AppointmentsDGV.BackgroundColor = System.Drawing.Color.SlateGray;
            this.AppointmentsDGV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.AppointmentsDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AppointmentsDGV.GridColor = System.Drawing.Color.FromArgb(((int) (((byte) (218)))), ((int) (((byte) (218)))), ((int) (((byte) (218)))));
            this.AppointmentsDGV.Location = new System.Drawing.Point(87, 482);
            this.AppointmentsDGV.Name = "AppointmentsDGV";
            this.AppointmentsDGV.ReadOnly = true;
            this.AppointmentsDGV.RowTemplate.Height = 24;
            this.AppointmentsDGV.Size = new System.Drawing.Size(800, 90);
            this.AppointmentsDGV.TabIndex = 4;
            // 
            // AppointmentLbl
            // 
            this.AppointmentLbl.BackColor = System.Drawing.Color.Transparent;
            this.AppointmentLbl.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.AppointmentLbl.ForeColor = System.Drawing.Color.SlateGray;
            this.AppointmentLbl.Location = new System.Drawing.Point(87, 435);
            this.AppointmentLbl.Name = "AppointmentLbl";
            this.AppointmentLbl.Size = new System.Drawing.Size(289, 44);
            this.AppointmentLbl.TabIndex = 5;
            this.AppointmentLbl.Text = "CITAS";
            this.AppointmentLbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // CitizenLbl
            // 
            this.CitizenLbl.BackColor = System.Drawing.Color.Transparent;
            this.CitizenLbl.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.CitizenLbl.ForeColor = System.Drawing.Color.SlateGray;
            this.CitizenLbl.Location = new System.Drawing.Point(87, 275);
            this.CitizenLbl.Name = "CitizenLbl";
            this.CitizenLbl.Size = new System.Drawing.Size(289, 44);
            this.CitizenLbl.TabIndex = 6;
            this.CitizenLbl.Text = "DATOS DEL CIUDADANO";
            this.CitizenLbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // EnterButton
            // 
            this.EnterButton.BackColor = System.Drawing.Color.SlateGray;
            this.EnterButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.EnterButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EnterButton.Font = new System.Drawing.Font("Bahnschrift", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.EnterButton.ForeColor = System.Drawing.Color.FromArgb(((int) (((byte) (218)))), ((int) (((byte) (218)))), ((int) (((byte) (218)))));
            this.EnterButton.Location = new System.Drawing.Point(435, 176);
            this.EnterButton.Name = "EnterButton";
            this.EnterButton.Size = new System.Drawing.Size(145, 39);
            this.EnterButton.TabIndex = 7;
            this.EnterButton.Text = "Ingresar";
            this.EnterButton.UseVisualStyleBackColor = false;
            // 
            // PrintButton
            // 
            this.PrintButton.BackColor = System.Drawing.Color.SlateGray;
            this.PrintButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PrintButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PrintButton.Font = new System.Drawing.Font("Bahnschrift", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.PrintButton.ForeColor = System.Drawing.Color.FromArgb(((int) (((byte) (218)))), ((int) (((byte) (218)))), ((int) (((byte) (218)))));
            this.PrintButton.Location = new System.Drawing.Point(742, 617);
            this.PrintButton.Name = "PrintButton";
            this.PrintButton.Size = new System.Drawing.Size(145, 39);
            this.PrintButton.TabIndex = 8;
            this.PrintButton.Text = "Imprimir";
            this.PrintButton.UseVisualStyleBackColor = false;
            // 
            // AppointmentTracking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (218)))), ((int) (((byte) (218)))), ((int) (((byte) (218)))));
            this.BackgroundImage = ((System.Drawing.Image) (resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(964, 697);
            this.Controls.Add(this.PrintButton);
            this.Controls.Add(this.EnterButton);
            this.Controls.Add(this.CitizenLbl);
            this.Controls.Add(this.AppointmentLbl);
            this.Controls.Add(this.AppointmentsDGV);
            this.Controls.Add(this.CitizenDGV);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.DUILbl);
            this.Controls.Add(this.TitleLbl);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AppointmentTracking";
            this.Text = "AppointmentTracking";
            ((System.ComponentModel.ISupportInitialize) (this.CitizenDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.AppointmentsDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Button PrintButton;

        private System.Windows.Forms.Button EnterButton;

        private System.Windows.Forms.Label AppointmentLbl;
        private System.Windows.Forms.Label CitizenLbl;

        private System.Windows.Forms.DataGridView AppointmentsDGV;

        private System.Windows.Forms.DataGridView CitizenDGV;

        private System.Windows.Forms.Label DUILbl;
        private System.Windows.Forms.TextBox textBox1;

        private System.Windows.Forms.Label TitleLbl;

        #endregion
    }
}