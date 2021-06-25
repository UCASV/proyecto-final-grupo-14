﻿using System.ComponentModel;

namespace COVIDVACCSYSTEM.View
{
    partial class CitizenRegistration
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CitizenRegistration));
            this.FirstNameLbl = new System.Windows.Forms.Label();
            this.LastNameLbl = new System.Windows.Forms.Label();
            this.BirthdayLbl = new System.Windows.Forms.Label();
            this.AddressLbl = new System.Windows.Forms.Label();
            this.PhoneNumberLbl = new System.Windows.Forms.Label();
            this.EmailLbl = new System.Windows.Forms.Label();
            this.IllnessLbl = new System.Windows.Forms.Label();
            this.InstitutionLbl = new System.Windows.Forms.Label();
            this.FirstNameTB = new System.Windows.Forms.TextBox();
            this.LastNameTB = new System.Windows.Forms.TextBox();
            this.BirthdayDTP = new System.Windows.Forms.DateTimePicker();
            this.DepartmentCB = new System.Windows.Forms.ComboBox();
            this.CityCB = new System.Windows.Forms.ComboBox();
            this.EmailTB = new System.Windows.Forms.TextBox();
            this.PhoneNumberTB = new System.Windows.Forms.TextBox();
            this.IllnessLB = new System.Windows.Forms.ListBox();
            this.InstitutionCB = new System.Windows.Forms.ComboBox();
            this.TitleLbl = new System.Windows.Forms.Label();
            this.InstitutionTB = new System.Windows.Forms.TextBox();
            this.RegisterButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // FirstNameLbl
            // 
            this.FirstNameLbl.BackColor = System.Drawing.Color.Transparent;
            this.FirstNameLbl.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.FirstNameLbl.ForeColor = System.Drawing.Color.SlateGray;
            this.FirstNameLbl.Location = new System.Drawing.Point(224, 99);
            this.FirstNameLbl.Name = "FirstNameLbl";
            this.FirstNameLbl.Size = new System.Drawing.Size(150, 39);
            this.FirstNameLbl.TabIndex = 0;
            this.FirstNameLbl.Text = "Nombre";
            this.FirstNameLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LastNameLbl
            // 
            this.LastNameLbl.BackColor = System.Drawing.Color.Transparent;
            this.LastNameLbl.Font = new System.Drawing.Font("Century Gothic", 10.2F);
            this.LastNameLbl.ForeColor = System.Drawing.Color.SlateGray;
            this.LastNameLbl.Location = new System.Drawing.Point(582, 99);
            this.LastNameLbl.Name = "LastNameLbl";
            this.LastNameLbl.Size = new System.Drawing.Size(150, 39);
            this.LastNameLbl.TabIndex = 1;
            this.LastNameLbl.Text = "Apellido";
            this.LastNameLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BirthdayLbl
            // 
            this.BirthdayLbl.BackColor = System.Drawing.Color.Transparent;
            this.BirthdayLbl.Font = new System.Drawing.Font("Century Gothic", 10.2F);
            this.BirthdayLbl.ForeColor = System.Drawing.Color.SlateGray;
            this.BirthdayLbl.Location = new System.Drawing.Point(248, 189);
            this.BirthdayLbl.Name = "BirthdayLbl";
            this.BirthdayLbl.Size = new System.Drawing.Size(198, 50);
            this.BirthdayLbl.TabIndex = 2;
            this.BirthdayLbl.Text = "Fecha de Nacimiento";
            this.BirthdayLbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // AddressLbl
            // 
            this.AddressLbl.BackColor = System.Drawing.Color.Transparent;
            this.AddressLbl.Font = new System.Drawing.Font("Century Gothic", 10.2F);
            this.AddressLbl.ForeColor = System.Drawing.Color.SlateGray;
            this.AddressLbl.Location = new System.Drawing.Point(247, 275);
            this.AddressLbl.Name = "AddressLbl";
            this.AddressLbl.Size = new System.Drawing.Size(150, 39);
            this.AddressLbl.TabIndex = 3;
            this.AddressLbl.Text = "Lugar de Origen";
            this.AddressLbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // PhoneNumberLbl
            // 
            this.PhoneNumberLbl.BackColor = System.Drawing.Color.Transparent;
            this.PhoneNumberLbl.Font = new System.Drawing.Font("Century Gothic", 10.2F);
            this.PhoneNumberLbl.ForeColor = System.Drawing.Color.SlateGray;
            this.PhoneNumberLbl.Location = new System.Drawing.Point(248, 420);
            this.PhoneNumberLbl.Name = "PhoneNumberLbl";
            this.PhoneNumberLbl.Size = new System.Drawing.Size(150, 39);
            this.PhoneNumberLbl.TabIndex = 4;
            this.PhoneNumberLbl.Text = "Teléfono";
            this.PhoneNumberLbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // EmailLbl
            // 
            this.EmailLbl.BackColor = System.Drawing.Color.Transparent;
            this.EmailLbl.Font = new System.Drawing.Font("Century Gothic", 10.2F);
            this.EmailLbl.ForeColor = System.Drawing.Color.SlateGray;
            this.EmailLbl.Location = new System.Drawing.Point(247, 361);
            this.EmailLbl.Name = "EmailLbl";
            this.EmailLbl.Size = new System.Drawing.Size(199, 39);
            this.EmailLbl.TabIndex = 5;
            this.EmailLbl.Text = "Correo Electrónico";
            this.EmailLbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // IllnessLbl
            // 
            this.IllnessLbl.BackColor = System.Drawing.Color.Transparent;
            this.IllnessLbl.Font = new System.Drawing.Font("Century Gothic", 10.2F);
            this.IllnessLbl.ForeColor = System.Drawing.Color.SlateGray;
            this.IllnessLbl.Location = new System.Drawing.Point(248, 558);
            this.IllnessLbl.Name = "IllnessLbl";
            this.IllnessLbl.Size = new System.Drawing.Size(201, 49);
            this.IllnessLbl.TabIndex = 6;
            this.IllnessLbl.Text = "Enfermedades Crónicas";
            this.IllnessLbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // InstitutionLbl
            // 
            this.InstitutionLbl.BackColor = System.Drawing.Color.Transparent;
            this.InstitutionLbl.Font = new System.Drawing.Font("Century Gothic", 10.2F);
            this.InstitutionLbl.ForeColor = System.Drawing.Color.SlateGray;
            this.InstitutionLbl.Location = new System.Drawing.Point(248, 485);
            this.InstitutionLbl.Name = "InstitutionLbl";
            this.InstitutionLbl.Size = new System.Drawing.Size(150, 39);
            this.InstitutionLbl.TabIndex = 7;
            this.InstitutionLbl.Text = "Institución";
            this.InstitutionLbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // FirstNameTB
            // 
            this.FirstNameTB.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.FirstNameTB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.FirstNameTB.Font = new System.Drawing.Font("Century Gothic", 10.2F);
            this.FirstNameTB.Location = new System.Drawing.Point(181, 141);
            this.FirstNameTB.Name = "FirstNameTB";
            this.FirstNameTB.Size = new System.Drawing.Size(252, 28);
            this.FirstNameTB.TabIndex = 8;
            this.FirstNameTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // LastNameTB
            // 
            this.LastNameTB.Font = new System.Drawing.Font("Century Gothic", 10.2F);
            this.LastNameTB.Location = new System.Drawing.Point(529, 140);
            this.LastNameTB.Name = "LastNameTB";
            this.LastNameTB.Size = new System.Drawing.Size(250, 28);
            this.LastNameTB.TabIndex = 9;
            // 
            // BirthdayDTP
            // 
            this.BirthdayDTP.AllowDrop = true;
            this.BirthdayDTP.CustomFormat = "dd/mm/yy";
            this.BirthdayDTP.Font = new System.Drawing.Font("Century Gothic", 10.2F);
            this.BirthdayDTP.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.BirthdayDTP.Location = new System.Drawing.Point(465, 198);
            this.BirthdayDTP.MaxDate = new System.DateTime(2021, 12, 25, 23, 59, 59, 0);
            this.BirthdayDTP.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.BirthdayDTP.Name = "BirthdayDTP";
            this.BirthdayDTP.Size = new System.Drawing.Size(250, 28);
            this.BirthdayDTP.TabIndex = 10;
            // 
            // DepartmentCB
            // 
            this.DepartmentCB.Font = new System.Drawing.Font("Century Gothic", 10.2F);
            this.DepartmentCB.FormattingEnabled = true;
            this.DepartmentCB.Location = new System.Drawing.Point(465, 275);
            this.DepartmentCB.Name = "DepartmentCB";
            this.DepartmentCB.Size = new System.Drawing.Size(250, 29);
            this.DepartmentCB.TabIndex = 11;
            this.DepartmentCB.Text = "Departamento";
            // 
            // CityCB
            // 
            this.CityCB.Font = new System.Drawing.Font("Century Gothic", 10.2F);
            this.CityCB.FormattingEnabled = true;
            this.CityCB.Location = new System.Drawing.Point(465, 305);
            this.CityCB.Name = "CityCB";
            this.CityCB.Size = new System.Drawing.Size(250, 29);
            this.CityCB.TabIndex = 12;
            this.CityCB.Text = "Municipio";
            // 
            // EmailTB
            // 
            this.EmailTB.Font = new System.Drawing.Font("Century Gothic", 10.2F);
            this.EmailTB.Location = new System.Drawing.Point(465, 371);
            this.EmailTB.Name = "EmailTB";
            this.EmailTB.Size = new System.Drawing.Size(250, 28);
            this.EmailTB.TabIndex = 13;
            // 
            // PhoneNumberTB
            // 
            this.PhoneNumberTB.Font = new System.Drawing.Font("Century Gothic", 10.2F);
            this.PhoneNumberTB.Location = new System.Drawing.Point(465, 430);
            this.PhoneNumberTB.Name = "PhoneNumberTB";
            this.PhoneNumberTB.Size = new System.Drawing.Size(250, 28);
            this.PhoneNumberTB.TabIndex = 14;
            // 
            // IllnessLB
            // 
            this.IllnessLB.Font = new System.Drawing.Font("Century Gothic", 10.2F);
            this.IllnessLB.FormattingEnabled = true;
            this.IllnessLB.ItemHeight = 21;
            this.IllnessLB.Location = new System.Drawing.Point(467, 569);
            this.IllnessLB.MultiColumn = true;
            this.IllnessLB.Name = "IllnessLB";
            this.IllnessLB.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.IllnessLB.Size = new System.Drawing.Size(248, 25);
            this.IllnessLB.Sorted = true;
            this.IllnessLB.TabIndex = 15;
            // 
            // InstitutionCB
            // 
            this.InstitutionCB.Font = new System.Drawing.Font("Century Gothic", 10.2F);
            this.InstitutionCB.FormattingEnabled = true;
            this.InstitutionCB.Location = new System.Drawing.Point(467, 485);
            this.InstitutionCB.Name = "InstitutionCB";
            this.InstitutionCB.Size = new System.Drawing.Size(248, 29);
            this.InstitutionCB.TabIndex = 16;
            // 
            // TitleLbl
            // 
            this.TitleLbl.BackColor = System.Drawing.Color.Transparent;
            this.TitleLbl.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 24F, System.Drawing.FontStyle.Bold);
            this.TitleLbl.ForeColor = System.Drawing.Color.SlateGray;
            this.TitleLbl.Location = new System.Drawing.Point(271, 27);
            this.TitleLbl.Name = "TitleLbl";
            this.TitleLbl.Size = new System.Drawing.Size(419, 55);
            this.TitleLbl.TabIndex = 17;
            this.TitleLbl.Text = "Registro de Ciudadano";
            this.TitleLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // InstitutionTB
            // 
            this.InstitutionTB.Font = new System.Drawing.Font("Century Gothic", 10.2F);
            this.InstitutionTB.Location = new System.Drawing.Point(467, 515);
            this.InstitutionTB.Name = "InstitutionTB";
            this.InstitutionTB.Size = new System.Drawing.Size(248, 28);
            this.InstitutionTB.TabIndex = 18;
            // 
            // RegisterButton
            // 
            this.RegisterButton.BackColor = System.Drawing.Color.SlateGray;
            this.RegisterButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RegisterButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RegisterButton.Font = new System.Drawing.Font("Bahnschrift", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.RegisterButton.ForeColor = System.Drawing.Color.FromArgb(((int) (((byte) (218)))), ((int) (((byte) (218)))), ((int) (((byte) (218)))));
            this.RegisterButton.Location = new System.Drawing.Point(393, 630);
            this.RegisterButton.Name = "RegisterButton";
            this.RegisterButton.Size = new System.Drawing.Size(165, 37);
            this.RegisterButton.TabIndex = 19;
            this.RegisterButton.Text = "Registrar";
            this.RegisterButton.UseVisualStyleBackColor = false;
            // 
            // CitizenRegistration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (218)))), ((int) (((byte) (218)))), ((int) (((byte) (218)))));
            this.BackgroundImage = ((System.Drawing.Image) (resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(964, 697);
            this.Controls.Add(this.RegisterButton);
            this.Controls.Add(this.InstitutionTB);
            this.Controls.Add(this.TitleLbl);
            this.Controls.Add(this.InstitutionCB);
            this.Controls.Add(this.IllnessLB);
            this.Controls.Add(this.PhoneNumberTB);
            this.Controls.Add(this.EmailTB);
            this.Controls.Add(this.CityCB);
            this.Controls.Add(this.DepartmentCB);
            this.Controls.Add(this.BirthdayDTP);
            this.Controls.Add(this.LastNameTB);
            this.Controls.Add(this.FirstNameTB);
            this.Controls.Add(this.InstitutionLbl);
            this.Controls.Add(this.IllnessLbl);
            this.Controls.Add(this.EmailLbl);
            this.Controls.Add(this.PhoneNumberLbl);
            this.Controls.Add(this.AddressLbl);
            this.Controls.Add(this.BirthdayLbl);
            this.Controls.Add(this.LastNameLbl);
            this.Controls.Add(this.FirstNameLbl);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CitizenRegistration";
            
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Button RegisterButton;

        private System.Windows.Forms.TextBox InstitutionTB;

        private System.Windows.Forms.Label TitleLbl;

        private System.Windows.Forms.ComboBox InstitutionCB;

        private System.Windows.Forms.ListBox IllnessLB;


        private System.Windows.Forms.TextBox EmailTB;
        private System.Windows.Forms.TextBox PhoneNumberTB;

        private System.Windows.Forms.ComboBox DepartmentCB;
        private System.Windows.Forms.ComboBox CityCB;

        private System.Windows.Forms.DateTimePicker BirthdayDTP;

        private System.Windows.Forms.TextBox FirstNameTB;
        private System.Windows.Forms.TextBox LastNameTB;

        private System.Windows.Forms.Label IllnessLbl;
        private System.Windows.Forms.Label InstitutionLbl;

        private System.Windows.Forms.Label EmailLbl;

        private System.Windows.Forms.Label FirstNameLbl;
        private System.Windows.Forms.Label LastNameLbl;
        private System.Windows.Forms.Label BirthdayLbl;
        private System.Windows.Forms.Label AddressLbl;
        private System.Windows.Forms.Label PhoneNumberLbl;

        #endregion
    }
}