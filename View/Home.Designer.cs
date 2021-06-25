using System.ComponentModel;

namespace COVIDVACCSYSTEM.View
{
    partial class Home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.Timer = new System.Timers.Timer();
            this.DateLbl = new System.Windows.Forms.Label();
            this.TimeLbl = new System.Windows.Forms.Label();
            this.WelcomeLbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize) (this.Timer)).BeginInit();
            this.SuspendLayout();
            // 
            // Timer
            // 
            this.Timer.Enabled = true;
            this.Timer.SynchronizingObject = this;
            this.Timer.Elapsed += new System.Timers.ElapsedEventHandler(this.Timer_Elapsed);
            // 
            // DateLbl
            // 
            this.DateLbl.BackColor = System.Drawing.Color.Transparent;
            this.DateLbl.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.DateLbl.ForeColor = System.Drawing.Color.SlateGray;
            this.DateLbl.Location = new System.Drawing.Point(64, 266);
            this.DateLbl.Name = "DateLbl";
            this.DateLbl.Size = new System.Drawing.Size(841, 87);
            this.DateLbl.TabIndex = 0;
            this.DateLbl.Text = "DateLbl";
            this.DateLbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // TimeLbl
            // 
            this.TimeLbl.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.TimeLbl.ForeColor = System.Drawing.Color.SlateGray;
            this.TimeLbl.Location = new System.Drawing.Point(64, 158);
            this.TimeLbl.Name = "TimeLbl";
            this.TimeLbl.Size = new System.Drawing.Size(487, 108);
            this.TimeLbl.TabIndex = 1;
            this.TimeLbl.Text = "TimeLbl";
            this.TimeLbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // WelcomeLbl
            // 
            this.WelcomeLbl.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.WelcomeLbl.ForeColor = System.Drawing.Color.SlateGray;
            this.WelcomeLbl.Location = new System.Drawing.Point(64, 53);
            this.WelcomeLbl.Name = "WelcomeLbl";
            this.WelcomeLbl.Size = new System.Drawing.Size(210, 64);
            this.WelcomeLbl.TabIndex = 2;
            this.WelcomeLbl.Text = "Bienvenid@";
            this.WelcomeLbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (218)))), ((int) (((byte) (218)))), ((int) (((byte) (218)))));
            this.BackgroundImage = ((System.Drawing.Image) (resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(954, 697);
            this.Controls.Add(this.WelcomeLbl);
            this.Controls.Add(this.TimeLbl);
            this.Controls.Add(this.DateLbl);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Home";
            this.Text = "Home";
            this.Load += new System.EventHandler(this.Home_Load);
            ((System.ComponentModel.ISupportInitialize) (this.Timer)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Label WelcomeLbl;

        private System.Windows.Forms.Label TimeLbl;

        private System.Timers.Timer Timer;
        private System.Windows.Forms.Label DateLbl;

        #endregion
    }
}