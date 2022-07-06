
namespace SchedulingSoftware
{
    partial class CalendarViews
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
            this.label1 = new System.Windows.Forms.Label();
            this.button_view_all_appointments = new System.Windows.Forms.Button();
            this.button_view_week_appointments = new System.Windows.Forms.Button();
            this.button_month_appointment = new System.Windows.Forms.Button();
            this.button_exit = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(352, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Calendar Views";
            // 
            // button_view_all_appointments
            // 
            this.button_view_all_appointments.BackColor = System.Drawing.Color.MidnightBlue;
            this.button_view_all_appointments.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_view_all_appointments.ForeColor = System.Drawing.Color.White;
            this.button_view_all_appointments.Location = new System.Drawing.Point(56, 270);
            this.button_view_all_appointments.Name = "button_view_all_appointments";
            this.button_view_all_appointments.Size = new System.Drawing.Size(150, 40);
            this.button_view_all_appointments.TabIndex = 1;
            this.button_view_all_appointments.Text = "All Appointments";
            this.button_view_all_appointments.UseVisualStyleBackColor = false;
            this.button_view_all_appointments.Click += new System.EventHandler(this.button_view_all_appointments_Click);
            // 
            // button_view_week_appointments
            // 
            this.button_view_week_appointments.BackColor = System.Drawing.Color.MidnightBlue;
            this.button_view_week_appointments.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_view_week_appointments.ForeColor = System.Drawing.Color.White;
            this.button_view_week_appointments.Location = new System.Drawing.Point(316, 270);
            this.button_view_week_appointments.Name = "button_view_week_appointments";
            this.button_view_week_appointments.Size = new System.Drawing.Size(150, 40);
            this.button_view_week_appointments.TabIndex = 2;
            this.button_view_week_appointments.Text = "Current Week Appointments";
            this.button_view_week_appointments.UseVisualStyleBackColor = false;
            this.button_view_week_appointments.Click += new System.EventHandler(this.button_view_week_appointments_Click);
            // 
            // button_month_appointment
            // 
            this.button_month_appointment.BackColor = System.Drawing.Color.MidnightBlue;
            this.button_month_appointment.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_month_appointment.ForeColor = System.Drawing.Color.White;
            this.button_month_appointment.Location = new System.Drawing.Point(577, 270);
            this.button_month_appointment.Name = "button_month_appointment";
            this.button_month_appointment.Size = new System.Drawing.Size(150, 40);
            this.button_month_appointment.TabIndex = 3;
            this.button_month_appointment.Text = "Current Month Appointments";
            this.button_month_appointment.UseVisualStyleBackColor = false;
            this.button_month_appointment.Click += new System.EventHandler(this.button_month_appointment_Click);
            // 
            // button_exit
            // 
            this.button_exit.BackColor = System.Drawing.Color.MidnightBlue;
            this.button_exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_exit.ForeColor = System.Drawing.Color.White;
            this.button_exit.Location = new System.Drawing.Point(342, 450);
            this.button_exit.Name = "button_exit";
            this.button_exit.Size = new System.Drawing.Size(100, 25);
            this.button_exit.TabIndex = 4;
            this.button_exit.Text = "Exit";
            this.button_exit.UseVisualStyleBackColor = false;
            this.button_exit.Click += new System.EventHandler(this.button_exit_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(784, 100);
            this.panel1.TabIndex = 5;
            // 
            // CalendarViews
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button_exit);
            this.Controls.Add(this.button_month_appointment);
            this.Controls.Add(this.button_view_week_appointments);
            this.Controls.Add(this.button_view_all_appointments);
            this.Name = "CalendarViews";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CalendarViews";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_view_all_appointments;
        private System.Windows.Forms.Button button_view_week_appointments;
        private System.Windows.Forms.Button button_month_appointment;
        private System.Windows.Forms.Button button_exit;
        private System.Windows.Forms.Panel panel1;
    }
}