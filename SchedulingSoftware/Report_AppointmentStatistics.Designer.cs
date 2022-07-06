
namespace SchedulingSoftware
{
    partial class Report_AppointmentStatistics
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.label_monday = new System.Windows.Forms.Label();
            this.label_tuesday = new System.Windows.Forms.Label();
            this.label_sunday = new System.Windows.Forms.Label();
            this.label_wednesday = new System.Windows.Forms.Label();
            this.label_thursday = new System.Windows.Forms.Label();
            this.label_friday = new System.Windows.Forms.Label();
            this.label_saturday = new System.Windows.Forms.Label();
            this.label_select = new System.Windows.Forms.Label();
            this.button_exit = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dataGridView1.Location = new System.Drawing.Point(50, 150);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(292, 200);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.loadUserSchedule);
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Enabled = false;
            this.dataGridView2.Location = new System.Drawing.Point(110, 505);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(583, 33);
            this.dataGridView2.TabIndex = 1;
            this.dataGridView2.Visible = false;
            // 
            // label_monday
            // 
            this.label_monday.AutoSize = true;
            this.label_monday.Location = new System.Drawing.Point(442, 180);
            this.label_monday.Name = "label_monday";
            this.label_monday.Size = new System.Drawing.Size(45, 13);
            this.label_monday.TabIndex = 2;
            this.label_monday.Text = "Monday";
            // 
            // label_tuesday
            // 
            this.label_tuesday.AutoSize = true;
            this.label_tuesday.Location = new System.Drawing.Point(442, 210);
            this.label_tuesday.Name = "label_tuesday";
            this.label_tuesday.Size = new System.Drawing.Size(48, 13);
            this.label_tuesday.TabIndex = 3;
            this.label_tuesday.Text = "Tuesday";
            // 
            // label_sunday
            // 
            this.label_sunday.AutoSize = true;
            this.label_sunday.Location = new System.Drawing.Point(442, 150);
            this.label_sunday.Name = "label_sunday";
            this.label_sunday.Size = new System.Drawing.Size(43, 13);
            this.label_sunday.TabIndex = 4;
            this.label_sunday.Text = "Sunday";
            // 
            // label_wednesday
            // 
            this.label_wednesday.AutoSize = true;
            this.label_wednesday.Location = new System.Drawing.Point(442, 240);
            this.label_wednesday.Name = "label_wednesday";
            this.label_wednesday.Size = new System.Drawing.Size(64, 13);
            this.label_wednesday.TabIndex = 5;
            this.label_wednesday.Text = "Wednesday";
            // 
            // label_thursday
            // 
            this.label_thursday.AutoSize = true;
            this.label_thursday.Location = new System.Drawing.Point(442, 270);
            this.label_thursday.Name = "label_thursday";
            this.label_thursday.Size = new System.Drawing.Size(51, 13);
            this.label_thursday.TabIndex = 6;
            this.label_thursday.Text = "Thursday";
            // 
            // label_friday
            // 
            this.label_friday.AutoSize = true;
            this.label_friday.Location = new System.Drawing.Point(442, 300);
            this.label_friday.Name = "label_friday";
            this.label_friday.Size = new System.Drawing.Size(35, 13);
            this.label_friday.TabIndex = 7;
            this.label_friday.Text = "Friday";
            // 
            // label_saturday
            // 
            this.label_saturday.AutoSize = true;
            this.label_saturday.Location = new System.Drawing.Point(442, 330);
            this.label_saturday.Name = "label_saturday";
            this.label_saturday.Size = new System.Drawing.Size(49, 13);
            this.label_saturday.TabIndex = 8;
            this.label_saturday.Text = "Saturday";
            // 
            // label_select
            // 
            this.label_select.AutoSize = true;
            this.label_select.Location = new System.Drawing.Point(47, 134);
            this.label_select.Name = "label_select";
            this.label_select.Size = new System.Drawing.Size(71, 13);
            this.label_select.TabIndex = 9;
            this.label_select.Text = "Select a User";
            // 
            // button_exit
            // 
            this.button_exit.BackColor = System.Drawing.Color.MidnightBlue;
            this.button_exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_exit.ForeColor = System.Drawing.Color.White;
            this.button_exit.Location = new System.Drawing.Point(342, 450);
            this.button_exit.Name = "button_exit";
            this.button_exit.Size = new System.Drawing.Size(100, 25);
            this.button_exit.TabIndex = 10;
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
            this.panel1.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(337, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Appointment Statistics";
            // 
            // Report_AppointmentStatistics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button_exit);
            this.Controls.Add(this.label_select);
            this.Controls.Add(this.label_saturday);
            this.Controls.Add(this.label_friday);
            this.Controls.Add(this.label_thursday);
            this.Controls.Add(this.label_wednesday);
            this.Controls.Add(this.label_sunday);
            this.Controls.Add(this.label_tuesday);
            this.Controls.Add(this.label_monday);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Report_AppointmentStatistics";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Report_AppointmentStatistics";
            this.Load += new System.EventHandler(this.Report_AppointmentStatistics_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label label_monday;
        private System.Windows.Forms.Label label_tuesday;
        private System.Windows.Forms.Label label_sunday;
        private System.Windows.Forms.Label label_wednesday;
        private System.Windows.Forms.Label label_thursday;
        private System.Windows.Forms.Label label_friday;
        private System.Windows.Forms.Label label_saturday;
        private System.Windows.Forms.Label label_select;
        private System.Windows.Forms.Button button_exit;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
    }
}