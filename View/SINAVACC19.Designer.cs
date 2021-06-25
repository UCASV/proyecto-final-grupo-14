using System.ComponentModel;
using System.Drawing;

namespace COVIDVACCSYSTEM.View
{
    partial class SINAVACC19
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SINAVACC19));
            this.SINAVACC19TC = new System.Windows.Forms.TabControl();
            this.CabinsPage = new System.Windows.Forms.TabPage();
            this.EmployeesPage = new System.Windows.Forms.TabPage();
            this.SINAVACC19TC.SuspendLayout();
            this.SuspendLayout();
            // 
            // SINAVACC19TC
            // 
            this.SINAVACC19TC.Controls.Add(this.CabinsPage);
            this.SINAVACC19TC.Controls.Add(this.EmployeesPage);
            this.SINAVACC19TC.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SINAVACC19TC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SINAVACC19TC.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.SINAVACC19TC.ForeColor = System.Drawing.Color.SlateGray;
            this.SINAVACC19TC.ItemSize = new System.Drawing.Size(100, 30);
            this.SINAVACC19TC.Location = new System.Drawing.Point(0, 0);
            this.SINAVACC19TC.Margin = new System.Windows.Forms.Padding(6);
            this.SINAVACC19TC.Name = "SINAVACC19TC";
            this.SINAVACC19TC.Padding = new System.Drawing.Point(5, 5);
            this.SINAVACC19TC.SelectedIndex = 0;
            this.SINAVACC19TC.Size = new System.Drawing.Size(936, 650);
            this.SINAVACC19TC.TabIndex = 0;
            // 
            // CabinsPage
            // 
            this.CabinsPage.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (218)))), ((int) (((byte) (218)))), ((int) (((byte) (218)))));
            this.CabinsPage.BackgroundImage = ((System.Drawing.Image) (resources.GetObject("CabinsPage.BackgroundImage")));
            this.CabinsPage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.CabinsPage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CabinsPage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CabinsPage.Font = new System.Drawing.Font("Bahnschrift", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.CabinsPage.ForeColor = System.Drawing.Color.SlateGray;
            this.CabinsPage.Location = new System.Drawing.Point(4, 34);
            this.CabinsPage.Name = "CabinsPage";
            this.CabinsPage.Padding = new System.Windows.Forms.Padding(3);
            this.CabinsPage.Size = new System.Drawing.Size(928, 612);
            this.CabinsPage.TabIndex = 0;
            this.CabinsPage.Text = "Cabinas";
            // 
            // EmployeesPage
            // 
            this.EmployeesPage.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (218)))), ((int) (((byte) (218)))), ((int) (((byte) (218)))));
            this.EmployeesPage.BackgroundImage = ((System.Drawing.Image) (resources.GetObject("EmployeesPage.BackgroundImage")));
            this.EmployeesPage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.EmployeesPage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.EmployeesPage.Font = new System.Drawing.Font("Bahnschrift", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.EmployeesPage.ForeColor = System.Drawing.Color.FromArgb(((int) (((byte) (218)))), ((int) (((byte) (218)))), ((int) (((byte) (218)))));
            this.EmployeesPage.Location = new System.Drawing.Point(4, 34);
            this.EmployeesPage.Name = "EmployeesPage";
            this.EmployeesPage.Padding = new System.Windows.Forms.Padding(3);
            this.EmployeesPage.Size = new System.Drawing.Size(928, 612);
            this.EmployeesPage.TabIndex = 1;
            this.EmployeesPage.Text = "Empleados";
            // 
            // SINAVACC19
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (218)))), ((int) (((byte) (218)))), ((int) (((byte) (218)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(936, 650);
            this.Controls.Add(this.SINAVACC19TC);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.Color.SlateGray;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SINAVACC19";
            this.Text = "SINAVACC19";
            this.SINAVACC19TC.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.TabControl SINAVACC19TC;
        private System.Windows.Forms.TabPage CabinsPage;
        private System.Windows.Forms.TabPage EmployeesPage;

        #endregion
    }
}