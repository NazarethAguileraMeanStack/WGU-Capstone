
namespace SchedulingSoftware
{
    partial class Appointment_Edit
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
            this.label_select_customer = new System.Windows.Forms.Label();
            this.label_select_user = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.dateTimePicker_endDate = new System.Windows.Forms.DateTimePicker();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dateTimePicker_startDate = new System.Windows.Forms.DateTimePicker();
            this.button_cancel = new System.Windows.Forms.Button();
            this.button_save = new System.Windows.Forms.Button();
            this.label_end_time = new System.Windows.Forms.Label();
            this.label_start_time = new System.Windows.Forms.Label();
            this.label_customer_id = new System.Windows.Forms.Label();
            this.textBox_customer_id = new System.Windows.Forms.TextBox();
            this.textBox_user_id = new System.Windows.Forms.TextBox();
            this.label_user_id = new System.Windows.Forms.Label();
            this.textBox_type = new System.Windows.Forms.TextBox();
            this.label_type = new System.Windows.Forms.Label();
            this.label_title = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label_select_customer
            // 
            this.label_select_customer.AutoSize = true;
            this.label_select_customer.Location = new System.Drawing.Point(439, 134);
            this.label_select_customer.Name = "label_select_customer";
            this.label_select_customer.Size = new System.Drawing.Size(93, 13);
            this.label_select_customer.TabIndex = 44;
            this.label_select_customer.Text = "Select a Customer";
            // 
            // label_select_user
            // 
            this.label_select_user.AutoSize = true;
            this.label_select_user.Location = new System.Drawing.Point(47, 134);
            this.label_select_user.Name = "label_select_user";
            this.label_select_user.Size = new System.Drawing.Size(71, 13);
            this.label_select_user.TabIndex = 43;
            this.label_select_user.Text = "Select a User";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dataGridView2.Location = new System.Drawing.Point(50, 150);
            this.dataGridView2.MultiSelect = false;
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView2.Size = new System.Drawing.Size(292, 200);
            this.dataGridView2.TabIndex = 42;
            this.dataGridView2.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.updateSelectedUser);
            // 
            // dateTimePicker_endDate
            // 
            this.dateTimePicker_endDate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dateTimePicker_endDate.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            this.dateTimePicker_endDate.Enabled = false;
            this.dateTimePicker_endDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker_endDate.Location = new System.Drawing.Point(100, 410);
            this.dateTimePicker_endDate.Name = "dateTimePicker_endDate";
            this.dateTimePicker_endDate.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker_endDate.TabIndex = 41;
            this.dateTimePicker_endDate.Value = new System.DateTime(2022, 5, 12, 12, 0, 0, 0);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dataGridView1.Location = new System.Drawing.Point(442, 150);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(292, 200);
            this.dataGridView1.TabIndex = 40;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.updateSelectedCustomer);
            // 
            // dateTimePicker_startDate
            // 
            this.dateTimePicker_startDate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dateTimePicker_startDate.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            this.dateTimePicker_startDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker_startDate.Location = new System.Drawing.Point(100, 370);
            this.dateTimePicker_startDate.Name = "dateTimePicker_startDate";
            this.dateTimePicker_startDate.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker_startDate.TabIndex = 39;
            this.dateTimePicker_startDate.Value = new System.DateTime(2022, 5, 12, 12, 0, 0, 0);
            this.dateTimePicker_startDate.ValueChanged += new System.EventHandler(this.dateTimePicker_startDate_ValueChanged);
            // 
            // button_cancel
            // 
            this.button_cancel.BackColor = System.Drawing.Color.MidnightBlue;
            this.button_cancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_cancel.ForeColor = System.Drawing.Color.White;
            this.button_cancel.Location = new System.Drawing.Point(442, 450);
            this.button_cancel.Name = "button_cancel";
            this.button_cancel.Size = new System.Drawing.Size(100, 25);
            this.button_cancel.TabIndex = 38;
            this.button_cancel.Text = "Cancel";
            this.button_cancel.UseVisualStyleBackColor = false;
            this.button_cancel.Click += new System.EventHandler(this.button_cancel_Click_1);
            // 
            // button_save
            // 
            this.button_save.BackColor = System.Drawing.Color.MidnightBlue;
            this.button_save.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_save.Enabled = false;
            this.button_save.ForeColor = System.Drawing.Color.White;
            this.button_save.Location = new System.Drawing.Point(242, 450);
            this.button_save.Name = "button_save";
            this.button_save.Size = new System.Drawing.Size(100, 25);
            this.button_save.TabIndex = 37;
            this.button_save.Text = "Save";
            this.button_save.UseVisualStyleBackColor = false;
            this.button_save.Click += new System.EventHandler(this.button_save_Click_1);
            // 
            // label_end_time
            // 
            this.label_end_time.AutoSize = true;
            this.label_end_time.Location = new System.Drawing.Point(50, 410);
            this.label_end_time.Name = "label_end_time";
            this.label_end_time.Size = new System.Drawing.Size(26, 13);
            this.label_end_time.TabIndex = 36;
            this.label_end_time.Text = "End";
            // 
            // label_start_time
            // 
            this.label_start_time.AutoSize = true;
            this.label_start_time.Location = new System.Drawing.Point(50, 370);
            this.label_start_time.Name = "label_start_time";
            this.label_start_time.Size = new System.Drawing.Size(29, 13);
            this.label_start_time.TabIndex = 35;
            this.label_start_time.Text = "Start";
            // 
            // label_customer_id
            // 
            this.label_customer_id.AutoSize = true;
            this.label_customer_id.Location = new System.Drawing.Point(563, 127);
            this.label_customer_id.Name = "label_customer_id";
            this.label_customer_id.Size = new System.Drawing.Size(65, 13);
            this.label_customer_id.TabIndex = 34;
            this.label_customer_id.Text = "Customer ID";
            // 
            // textBox_customer_id
            // 
            this.textBox_customer_id.Enabled = false;
            this.textBox_customer_id.Location = new System.Drawing.Point(634, 124);
            this.textBox_customer_id.Name = "textBox_customer_id";
            this.textBox_customer_id.Size = new System.Drawing.Size(100, 20);
            this.textBox_customer_id.TabIndex = 33;
            // 
            // textBox_user_id
            // 
            this.textBox_user_id.Enabled = false;
            this.textBox_user_id.Location = new System.Drawing.Point(242, 124);
            this.textBox_user_id.Name = "textBox_user_id";
            this.textBox_user_id.Size = new System.Drawing.Size(100, 20);
            this.textBox_user_id.TabIndex = 32;
            // 
            // label_user_id
            // 
            this.label_user_id.AutoSize = true;
            this.label_user_id.Location = new System.Drawing.Point(193, 127);
            this.label_user_id.Name = "label_user_id";
            this.label_user_id.Size = new System.Drawing.Size(43, 13);
            this.label_user_id.TabIndex = 31;
            this.label_user_id.Text = "User ID";
            // 
            // textBox_type
            // 
            this.textBox_type.BackColor = System.Drawing.Color.White;
            this.textBox_type.Location = new System.Drawing.Point(492, 370);
            this.textBox_type.Name = "textBox_type";
            this.textBox_type.Size = new System.Drawing.Size(100, 20);
            this.textBox_type.TabIndex = 30;
            this.textBox_type.TextChanged += new System.EventHandler(this.textBox_type_TextChanged);
            // 
            // label_type
            // 
            this.label_type.AutoSize = true;
            this.label_type.Location = new System.Drawing.Point(442, 370);
            this.label_type.Name = "label_type";
            this.label_type.Size = new System.Drawing.Size(31, 13);
            this.label_type.TabIndex = 29;
            this.label_type.Text = "Type";
            // 
            // label_title
            // 
            this.label_title.AutoSize = true;
            this.label_title.ForeColor = System.Drawing.Color.White;
            this.label_title.Location = new System.Drawing.Point(349, 44);
            this.label_title.Name = "label_title";
            this.label_title.Size = new System.Drawing.Size(87, 13);
            this.label_title.TabIndex = 28;
            this.label_title.Text = "Edit Appointment";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel1.Controls.Add(this.label_title);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(784, 100);
            this.panel1.TabIndex = 45;
            // 
            // Appointment_Edit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label_select_customer);
            this.Controls.Add(this.label_select_user);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dateTimePicker_endDate);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.dateTimePicker_startDate);
            this.Controls.Add(this.button_cancel);
            this.Controls.Add(this.button_save);
            this.Controls.Add(this.label_end_time);
            this.Controls.Add(this.label_start_time);
            this.Controls.Add(this.label_customer_id);
            this.Controls.Add(this.textBox_customer_id);
            this.Controls.Add(this.textBox_user_id);
            this.Controls.Add(this.label_user_id);
            this.Controls.Add(this.textBox_type);
            this.Controls.Add(this.label_type);
            this.Name = "Appointment_Edit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Appointment_Edit";
            this.Load += new System.EventHandler(this.Appointment_Edit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_select_customer;
        private System.Windows.Forms.Label label_select_user;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DateTimePicker dateTimePicker_endDate;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DateTimePicker dateTimePicker_startDate;
        private System.Windows.Forms.Button button_cancel;
        private System.Windows.Forms.Button button_save;
        private System.Windows.Forms.Label label_end_time;
        private System.Windows.Forms.Label label_start_time;
        private System.Windows.Forms.Label label_customer_id;
        private System.Windows.Forms.TextBox textBox_customer_id;
        private System.Windows.Forms.TextBox textBox_user_id;
        private System.Windows.Forms.Label label_user_id;
        private System.Windows.Forms.TextBox textBox_type;
        private System.Windows.Forms.Label label_type;
        private System.Windows.Forms.Label label_title;
        private System.Windows.Forms.Panel panel1;
    }
}