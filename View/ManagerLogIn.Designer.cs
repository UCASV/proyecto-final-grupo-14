using System.ComponentModel;

namespace COVIDVACCSYSTEM.View
{
    partial class ManagerLogIn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManagerLogIn));
            this.UsernameTB = new System.Windows.Forms.TextBox();
            this.PasswordTB = new System.Windows.Forms.TextBox();
            this.UsernameLbl = new System.Windows.Forms.Label();
            this.PasswordLbl = new System.Windows.Forms.Label();
            this.LogInButton = new System.Windows.Forms.Button();
            this.CabinIdLbl = new System.Windows.Forms.Label();
            this.CabinCB = new System.Windows.Forms.ComboBox();
            this.EmployeeIdLbl = new System.Windows.Forms.Label();
            this.EmployeeIdTB = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // UsernameTB
            // 
            this.UsernameTB.Location = new System.Drawing.Point(430, 484);
            this.UsernameTB.Margin = new System.Windows.Forms.Padding(4);
            this.UsernameTB.Name = "UsernameTB";
            this.UsernameTB.Size = new System.Drawing.Size(206, 32);
            this.UsernameTB.TabIndex = 0;
            // 
            // PasswordTB
            // 
            this.PasswordTB.Location = new System.Drawing.Point(430, 524);
            this.PasswordTB.Margin = new System.Windows.Forms.Padding(4);
            this.PasswordTB.Name = "PasswordTB";
            this.PasswordTB.PasswordChar = '*';
            this.PasswordTB.Size = new System.Drawing.Size(206, 32);
            this.PasswordTB.TabIndex = 1;
            this.PasswordTB.UseSystemPasswordChar = true;
            // 
            // UsernameLbl
            // 
            this.UsernameLbl.Location = new System.Drawing.Point(319, 484);
            this.UsernameLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.UsernameLbl.Name = "UsernameLbl";
            this.UsernameLbl.Size = new System.Drawing.Size(80, 30);
            this.UsernameLbl.TabIndex = 2;
            this.UsernameLbl.Text = "Usuario";
            this.UsernameLbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // PasswordLbl
            // 
            this.PasswordLbl.Location = new System.Drawing.Point(319, 524);
            this.PasswordLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.PasswordLbl.Name = "PasswordLbl";
            this.PasswordLbl.Size = new System.Drawing.Size(80, 30);
            this.PasswordLbl.TabIndex = 3;
            this.PasswordLbl.Text = "Clave";
            this.PasswordLbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LogInButton
            // 
            this.LogInButton.Location = new System.Drawing.Point(419, 588);
            this.LogInButton.Margin = new System.Windows.Forms.Padding(4);
            this.LogInButton.Name = "LogInButton";
            this.LogInButton.Size = new System.Drawing.Size(105, 37);
            this.LogInButton.TabIndex = 4;
            this.LogInButton.Text = "Ingresar";
            this.LogInButton.UseVisualStyleBackColor = true;
            this.LogInButton.Click += new System.EventHandler(this.LogInButton_Click);
            // 
            // CabinIdLbl
            // 
            this.CabinIdLbl.Location = new System.Drawing.Point(296, 445);
            this.CabinIdLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.CabinIdLbl.Name = "CabinIdLbl";
            this.CabinIdLbl.Size = new System.Drawing.Size(103, 32);
            this.CabinIdLbl.TabIndex = 6;
            this.CabinIdLbl.Text = "Cabina";
            this.CabinIdLbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // CabinCB
            // 
            this.CabinCB.FormattingEnabled = true;
            this.CabinCB.Location = new System.Drawing.Point(430, 445);
            this.CabinCB.Name = "CabinCB";
            this.CabinCB.Size = new System.Drawing.Size(94, 31);
            this.CabinCB.TabIndex = 7;
            // 
            // EmployeeIdLbl
            // 
            this.EmployeeIdLbl.BackColor = System.Drawing.Color.Transparent;
            this.EmployeeIdLbl.Location = new System.Drawing.Point(531, 444);
            this.EmployeeIdLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.EmployeeIdLbl.Name = "EmployeeIdLbl";
            this.EmployeeIdLbl.Size = new System.Drawing.Size(46, 30);
            this.EmployeeIdLbl.TabIndex = 10;
            this.EmployeeIdLbl.Text = "ID";
            this.EmployeeIdLbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // EmployeeIdTB
            // 
            this.EmployeeIdTB.Location = new System.Drawing.Point(585, 444);
            this.EmployeeIdTB.Margin = new System.Windows.Forms.Padding(4);
            this.EmployeeIdTB.Name = "EmployeeIdTB";
            this.EmployeeIdTB.Size = new System.Drawing.Size(51, 32);
            this.EmployeeIdTB.TabIndex = 9;
            // 
            // ManagerLogIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (218)))), ((int) (((byte) (218)))), ((int) (((byte) (218)))));
            this.BackgroundImage = ((System.Drawing.Image) (resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(948, 662);
            this.Controls.Add(this.EmployeeIdLbl);
            this.Controls.Add(this.EmployeeIdTB);
            this.Controls.Add(this.CabinCB);
            this.Controls.Add(this.CabinIdLbl);
            this.Controls.Add(this.LogInButton);
            this.Controls.Add(this.PasswordLbl);
            this.Controls.Add(this.UsernameLbl);
            this.Controls.Add(this.PasswordTB);
            this.Controls.Add(this.UsernameTB);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon) (resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "ManagerLogIn";
            this.Opacity = 0.9D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema Nacional de Vacunación COVID 19 - INICIE SESION";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label EmployeeIdLbl;
        private System.Windows.Forms.TextBox EmployeeIdTB;

        

        private System.Windows.Forms.ComboBox CabinCB;

        private System.Windows.Forms.Label CabinIdLbl;
        private System.Windows.Forms.Button LogInButton;

        private System.Windows.Forms.Label UsernameLbl;
        private System.Windows.Forms.Label PasswordLbl;

        private System.Windows.Forms.TextBox UsernameTB;
        private System.Windows.Forms.TextBox PasswordTB;

        #endregion
    }
}