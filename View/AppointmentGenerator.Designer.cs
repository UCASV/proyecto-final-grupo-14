using System.ComponentModel;

namespace COVIDVACCSYSTEM.View
{
    partial class AppointmentGenerator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AppointmentGenerator));
            this.GenerateButton = new System.Windows.Forms.Button();
            this.TitleLbl = new System.Windows.Forms.Label();
            this.DUILbl = new System.Windows.Forms.Label();
            this.DUITB = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // GenerateButton
            // 
            this.GenerateButton.BackColor = System.Drawing.Color.SlateGray;
            this.GenerateButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GenerateButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.GenerateButton.ForeColor = System.Drawing.Color.FromArgb(((int) (((byte) (218)))), ((int) (((byte) (218)))), ((int) (((byte) (218)))));
            this.GenerateButton.Location = new System.Drawing.Point(355, 401);
            this.GenerateButton.Name = "GenerateButton";
            this.GenerateButton.Size = new System.Drawing.Size(207, 70);
            this.GenerateButton.TabIndex = 0;
            this.GenerateButton.Text = "GENERAR CITA";
            this.GenerateButton.UseVisualStyleBackColor = false;
            this.GenerateButton.Click += new System.EventHandler(this.GenerateButton_Click);
            // 
            // TitleLbl
            // 
            this.TitleLbl.BackColor = System.Drawing.Color.Transparent;
            this.TitleLbl.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.TitleLbl.ForeColor = System.Drawing.Color.SlateGray;
            this.TitleLbl.Location = new System.Drawing.Point(263, 95);
            this.TitleLbl.Name = "TitleLbl";
            this.TitleLbl.Size = new System.Drawing.Size(390, 71);
            this.TitleLbl.TabIndex = 1;
            this.TitleLbl.Text = "GENERAR NUEVA CITA";
            this.TitleLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DUILbl
            // 
            this.DUILbl.BackColor = System.Drawing.Color.Transparent;
            this.DUILbl.Font = new System.Drawing.Font("Bahnschrift", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.DUILbl.ForeColor = System.Drawing.Color.SlateGray;
            this.DUILbl.Location = new System.Drawing.Point(285, 249);
            this.DUILbl.Name = "DUILbl";
            this.DUILbl.Size = new System.Drawing.Size(349, 75);
            this.DUILbl.TabIndex = 2;
            this.DUILbl.Text = "INGRESE NUMERO DE DUI \r\n(sin guiones, ni espacios)";
            this.DUILbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DUITB
            // 
            this.DUITB.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.DUITB.Location = new System.Drawing.Point(320, 341);
            this.DUITB.Name = "DUITB";
            this.DUITB.Size = new System.Drawing.Size(277, 32);
            this.DUITB.TabIndex = 3;
            // 
            // AppointmentGenerator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (218)))), ((int) (((byte) (218)))), ((int) (((byte) (218)))));
            this.BackgroundImage = ((System.Drawing.Image) (resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(964, 697);
            this.Controls.Add(this.DUITB);
            this.Controls.Add(this.DUILbl);
            this.Controls.Add(this.TitleLbl);
            this.Controls.Add(this.GenerateButton);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon) (resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AppointmentGenerator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.TextBox DUITB;

        private System.Windows.Forms.Label DUILbl;

        private System.Windows.Forms.Label TitleLbl;

        private System.Windows.Forms.Button GenerateButton;

        #endregion
    }
}