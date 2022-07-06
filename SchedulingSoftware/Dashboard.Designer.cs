
namespace SchedulingSoftware
{
    partial class Dashboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            this.label_welcome_user = new System.Windows.Forms.Label();
            this.button_calendar = new System.Windows.Forms.Button();
            this.button_customer = new System.Windows.Forms.Button();
            this.button_appointments = new System.Windows.Forms.Button();
            this.button_reports = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label_alert = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label_welcome_user
            // 
            this.label_welcome_user.AutoSize = true;
            this.label_welcome_user.ForeColor = System.Drawing.Color.White;
            this.label_welcome_user.Location = new System.Drawing.Point(50, 44);
            this.label_welcome_user.Name = "label_welcome_user";
            this.label_welcome_user.Size = new System.Drawing.Size(52, 13);
            this.label_welcome_user.TabIndex = 0;
            this.label_welcome_user.Text = "Welcome";
            // 
            // button_calendar
            // 
            this.button_calendar.BackColor = System.Drawing.Color.MidnightBlue;
            this.button_calendar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_calendar.ForeColor = System.Drawing.Color.White;
            this.button_calendar.Location = new System.Drawing.Point(23, 270);
            this.button_calendar.Name = "button_calendar";
            this.button_calendar.Size = new System.Drawing.Size(150, 40);
            this.button_calendar.TabIndex = 1;
            this.button_calendar.Text = "calendar";
            this.button_calendar.UseVisualStyleBackColor = false;
            this.button_calendar.Click += new System.EventHandler(this.button_calendar_Click);
            // 
            // button_customer
            // 
            this.button_customer.BackColor = System.Drawing.Color.MidnightBlue;
            this.button_customer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_customer.ForeColor = System.Drawing.Color.White;
            this.button_customer.Location = new System.Drawing.Point(219, 270);
            this.button_customer.Name = "button_customer";
            this.button_customer.Size = new System.Drawing.Size(150, 40);
            this.button_customer.TabIndex = 2;
            this.button_customer.Text = "Customers";
            this.button_customer.UseVisualStyleBackColor = false;
            this.button_customer.Click += new System.EventHandler(this.button_customer_Click);
            // 
            // button_appointments
            // 
            this.button_appointments.BackColor = System.Drawing.Color.MidnightBlue;
            this.button_appointments.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_appointments.ForeColor = System.Drawing.Color.White;
            this.button_appointments.Location = new System.Drawing.Point(415, 270);
            this.button_appointments.Name = "button_appointments";
            this.button_appointments.Size = new System.Drawing.Size(150, 40);
            this.button_appointments.TabIndex = 3;
            this.button_appointments.Text = "Appointments";
            this.button_appointments.UseVisualStyleBackColor = false;
            this.button_appointments.Click += new System.EventHandler(this.button_appointments_Click);
            // 
            // button_reports
            // 
            this.button_reports.BackColor = System.Drawing.Color.MidnightBlue;
            this.button_reports.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_reports.ForeColor = System.Drawing.Color.White;
            this.button_reports.Location = new System.Drawing.Point(611, 270);
            this.button_reports.Name = "button_reports";
            this.button_reports.Size = new System.Drawing.Size(150, 40);
            this.button_reports.TabIndex = 4;
            this.button_reports.Text = "Reports";
            this.button_reports.UseVisualStyleBackColor = false;
            this.button_reports.Click += new System.EventHandler(this.button_reports_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Enabled = false;
            this.dataGridView1.Location = new System.Drawing.Point(214, 448);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(338, 87);
            this.dataGridView1.TabIndex = 5;
            this.dataGridView1.Visible = false;
            // 
            // label_alert
            // 
            this.label_alert.AutoSize = true;
            this.label_alert.ForeColor = System.Drawing.Color.Black;
            this.label_alert.Location = new System.Drawing.Point(150, 144);
            this.label_alert.Name = "label_alert";
            this.label_alert.Size = new System.Drawing.Size(48, 13);
            this.label_alert.TabIndex = 6;
            this.label_alert.Text = "Alert text";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel1.Controls.Add(this.label_welcome_user);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(784, 100);
            this.panel1.TabIndex = 7;
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label_alert);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button_reports);
            this.Controls.Add(this.button_appointments);
            this.Controls.Add(this.button_customer);
            this.Controls.Add(this.button_calendar);
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.closeDashboard);
            this.Load += new System.EventHandler(this.Dashboard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_welcome_user;
        private System.Windows.Forms.Button button_calendar;
        private System.Windows.Forms.Button button_customer;
        private System.Windows.Forms.Button button_appointments;
        private System.Windows.Forms.Button button_reports;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label_alert;
        private System.Windows.Forms.Panel panel1;
    }
}