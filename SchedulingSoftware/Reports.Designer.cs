
namespace SchedulingSoftware
{
    partial class Reports
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
            this.button_appointment_types = new System.Windows.Forms.Button();
            this.button_consultant_schedule = new System.Windows.Forms.Button();
            this.button_appointment_statistics = new System.Windows.Forms.Button();
            this.button_exit = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(357, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "View Reports";
            // 
            // button_appointment_types
            // 
            this.button_appointment_types.BackColor = System.Drawing.Color.MidnightBlue;
            this.button_appointment_types.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_appointment_types.ForeColor = System.Drawing.Color.White;
            this.button_appointment_types.Location = new System.Drawing.Point(56, 270);
            this.button_appointment_types.Name = "button_appointment_types";
            this.button_appointment_types.Size = new System.Drawing.Size(150, 40);
            this.button_appointment_types.TabIndex = 1;
            this.button_appointment_types.Text = "Appointment Types";
            this.button_appointment_types.UseVisualStyleBackColor = false;
            this.button_appointment_types.Click += new System.EventHandler(this.button_appointment_types_Click);
            // 
            // button_consultant_schedule
            // 
            this.button_consultant_schedule.BackColor = System.Drawing.Color.MidnightBlue;
            this.button_consultant_schedule.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_consultant_schedule.ForeColor = System.Drawing.Color.White;
            this.button_consultant_schedule.Location = new System.Drawing.Point(316, 270);
            this.button_consultant_schedule.Name = "button_consultant_schedule";
            this.button_consultant_schedule.Size = new System.Drawing.Size(150, 40);
            this.button_consultant_schedule.TabIndex = 2;
            this.button_consultant_schedule.Text = "Consultant Schedule";
            this.button_consultant_schedule.UseVisualStyleBackColor = false;
            this.button_consultant_schedule.Click += new System.EventHandler(this.button_consultant_schedule_Click);
            // 
            // button_appointment_statistics
            // 
            this.button_appointment_statistics.BackColor = System.Drawing.Color.MidnightBlue;
            this.button_appointment_statistics.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_appointment_statistics.ForeColor = System.Drawing.Color.White;
            this.button_appointment_statistics.Location = new System.Drawing.Point(577, 270);
            this.button_appointment_statistics.Name = "button_appointment_statistics";
            this.button_appointment_statistics.Size = new System.Drawing.Size(150, 40);
            this.button_appointment_statistics.TabIndex = 3;
            this.button_appointment_statistics.Text = "Appointment Statistics";
            this.button_appointment_statistics.UseVisualStyleBackColor = false;
            this.button_appointment_statistics.Click += new System.EventHandler(this.button_appointment_statistics_Click);
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
            // Reports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button_exit);
            this.Controls.Add(this.button_appointment_statistics);
            this.Controls.Add(this.button_consultant_schedule);
            this.Controls.Add(this.button_appointment_types);
            this.Name = "Reports";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reports";
            this.Load += new System.EventHandler(this.Reports_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_appointment_types;
        private System.Windows.Forms.Button button_consultant_schedule;
        private System.Windows.Forms.Button button_appointment_statistics;
        private System.Windows.Forms.Button button_exit;
        private System.Windows.Forms.Panel panel1;
    }
}