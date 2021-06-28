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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AppointmentTracking));
            this.TitleLbl = new System.Windows.Forms.Label();
            this.DUILbl = new System.Windows.Forms.Label();
            this.DUITB = new System.Windows.Forms.TextBox();
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
            // DUITB
            // 
            this.DUITB.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.DUITB.Location = new System.Drawing.Point(381, 129);
            this.DUITB.Name = "DUITB";
            this.DUITB.Size = new System.Drawing.Size(287, 32);
            this.DUITB.TabIndex = 2;
            // 
            // CitizenDGV
            // 
            this.CitizenDGV.AllowUserToAddRows = false;
            this.CitizenDGV.AllowUserToDeleteRows = false;
            this.CitizenDGV.AllowUserToResizeColumns = false;
            this.CitizenDGV.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.SlateGray;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int) (((byte) (218)))), ((int) (((byte) (218)))), ((int) (((byte) (218)))));
            dataGridViewCellStyle1.NullValue = "No proporcionado";
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.LightSlateGray;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int) (((byte) (218)))), ((int) (((byte) (218)))), ((int) (((byte) (218)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.CitizenDGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.CitizenDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.CitizenDGV.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.CitizenDGV.BackgroundColor = System.Drawing.Color.Snow;
            this.CitizenDGV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CitizenDGV.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.CitizenDGV.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.CitizenDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CitizenDGV.GridColor = System.Drawing.Color.SlateGray;
            this.CitizenDGV.Location = new System.Drawing.Point(87, 322);
            this.CitizenDGV.Name = "CitizenDGV";
            this.CitizenDGV.ReadOnly = true;
            this.CitizenDGV.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.CitizenDGV.RowTemplate.Height = 24;
            this.CitizenDGV.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.CitizenDGV.Size = new System.Drawing.Size(800, 90);
            this.CitizenDGV.TabIndex = 3;
            // 
            // AppointmentsDGV
            // 
            this.AppointmentsDGV.AllowUserToAddRows = false;
            this.AppointmentsDGV.AllowUserToDeleteRows = false;
            this.AppointmentsDGV.AllowUserToResizeColumns = false;
            this.AppointmentsDGV.AllowUserToResizeRows = false;
            this.AppointmentsDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.AppointmentsDGV.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.AppointmentsDGV.BackgroundColor = System.Drawing.Color.Snow;
            this.AppointmentsDGV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.AppointmentsDGV.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.AppointmentsDGV.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.AppointmentsDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AppointmentsDGV.GridColor = System.Drawing.Color.SlateGray;
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
            this.EnterButton.Click += new System.EventHandler(this.EnterButton_Click);
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
            this.PrintButton.Click += new System.EventHandler(this.PrintButton_Click);
            // 
            // AppointmentTracking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
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
            this.Controls.Add(this.DUITB);
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
        private System.Windows.Forms.TextBox DUITB;

        private System.Windows.Forms.Label TitleLbl;

        #endregion
    }
}