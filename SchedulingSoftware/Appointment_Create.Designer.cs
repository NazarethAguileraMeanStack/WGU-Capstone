
namespace SchedulingSoftware
{
    partial class Appointment_Create
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
            this.label_title = new System.Windows.Forms.Label();
            this.label_type = new System.Windows.Forms.Label();
            this.textBox_type = new System.Windows.Forms.TextBox();
            this.label_user_id = new System.Windows.Forms.Label();
            this.textBox_user_id = new System.Windows.Forms.TextBox();
            this.textBox_customer_id = new System.Windows.Forms.TextBox();
            this.label_customer_id = new System.Windows.Forms.Label();
            this.label_start_time = new System.Windows.Forms.Label();
            this.label_end_time = new System.Windows.Forms.Label();
            this.button_create = new System.Windows.Forms.Button();
            this.button_cancel = new System.Windows.Forms.Button();
            this.dateTimePicker_startDate = new System.Windows.Forms.DateTimePicker();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dateTimePicker_endDate = new System.Windows.Forms.DateTimePicker();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.label_select_user = new System.Windows.Forms.Label();
            this.label_select_customer = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label_title
            // 
            this.label_title.AutoSize = true;
            this.label_title.ForeColor = System.Drawing.Color.White;
            this.label_title.Location = new System.Drawing.Point(342, 44);
            this.label_title.Name = "label_title";
            this.label_title.Size = new System.Drawing.Size(100, 13);
            this.label_title.TabIndex = 0;
            this.label_title.Text = "Create Appointment";
            // 
            // label_type
            // 
            this.label_type.AutoSize = true;
            this.label_type.Location = new System.Drawing.Point(442, 370);
            this.label_type.Name = "label_type";
            this.label_type.Size = new System.Drawing.Size(31, 13);
            this.label_type.TabIndex = 7;
            this.label_type.Text = "Type";
            // 
            // textBox_type
            // 
            this.textBox_type.BackColor = System.Drawing.Color.Red;
            this.textBox_type.Location = new System.Drawing.Point(492, 370);
            this.textBox_type.Name = "textBox_type";
            this.textBox_type.Size = new System.Drawing.Size(100, 20);
            this.textBox_type.TabIndex = 8;
            this.textBox_type.TextChanged += new System.EventHandler(this.validAppointmentType);
            // 
            // label_user_id
            // 
            this.label_user_id.AutoSize = true;
            this.label_user_id.Location = new System.Drawing.Point(193, 127);
            this.label_user_id.Name = "label_user_id";
            this.label_user_id.Size = new System.Drawing.Size(43, 13);
            this.label_user_id.TabIndex = 9;
            this.label_user_id.Text = "User ID";
            // 
            // textBox_user_id
            // 
            this.textBox_user_id.Enabled = false;
            this.textBox_user_id.Location = new System.Drawing.Point(242, 124);
            this.textBox_user_id.Name = "textBox_user_id";
            this.textBox_user_id.Size = new System.Drawing.Size(100, 20);
            this.textBox_user_id.TabIndex = 10;
            // 
            // textBox_customer_id
            // 
            this.textBox_customer_id.Enabled = false;
            this.textBox_customer_id.Location = new System.Drawing.Point(634, 124);
            this.textBox_customer_id.Name = "textBox_customer_id";
            this.textBox_customer_id.Size = new System.Drawing.Size(100, 20);
            this.textBox_customer_id.TabIndex = 11;
            // 
            // label_customer_id
            // 
            this.label_customer_id.AutoSize = true;
            this.label_customer_id.Location = new System.Drawing.Point(563, 127);
            this.label_customer_id.Name = "label_customer_id";
            this.label_customer_id.Size = new System.Drawing.Size(65, 13);
            this.label_customer_id.TabIndex = 12;
            this.label_customer_id.Text = "Customer ID";
            // 
            // label_start_time
            // 
            this.label_start_time.AutoSize = true;
            this.label_start_time.Location = new System.Drawing.Point(50, 370);
            this.label_start_time.Name = "label_start_time";
            this.label_start_time.Size = new System.Drawing.Size(29, 13);
            this.label_start_time.TabIndex = 15;
            this.label_start_time.Text = "Start";
            // 
            // label_end_time
            // 
            this.label_end_time.AutoSize = true;
            this.label_end_time.Location = new System.Drawing.Point(50, 410);
            this.label_end_time.Name = "label_end_time";
            this.label_end_time.Size = new System.Drawing.Size(26, 13);
            this.label_end_time.TabIndex = 17;
            this.label_end_time.Text = "End";
            // 
            // button_create
            // 
            this.button_create.BackColor = System.Drawing.Color.MidnightBlue;
            this.button_create.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_create.Enabled = false;
            this.button_create.ForeColor = System.Drawing.Color.White;
            this.button_create.Location = new System.Drawing.Point(242, 450);
            this.button_create.Name = "button_create";
            this.button_create.Size = new System.Drawing.Size(100, 25);
            this.button_create.TabIndex = 19;
            this.button_create.Text = "Create";
            this.button_create.UseVisualStyleBackColor = false;
            this.button_create.Click += new System.EventHandler(this.button_create_Click);
            // 
            // button_cancel
            // 
            this.button_cancel.BackColor = System.Drawing.Color.MidnightBlue;
            this.button_cancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_cancel.ForeColor = System.Drawing.Color.White;
            this.button_cancel.Location = new System.Drawing.Point(442, 450);
            this.button_cancel.Name = "button_cancel";
            this.button_cancel.Size = new System.Drawing.Size(100, 25);
            this.button_cancel.TabIndex = 20;
            this.button_cancel.Text = "Cancel";
            this.button_cancel.UseVisualStyleBackColor = false;
            this.button_cancel.Click += new System.EventHandler(this.button_cancel_Click);
            // 
            // dateTimePicker_startDate
            // 
            this.dateTimePicker_startDate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dateTimePicker_startDate.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            this.dateTimePicker_startDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker_startDate.Location = new System.Drawing.Point(100, 370);
            this.dateTimePicker_startDate.Name = "dateTimePicker_startDate";
            this.dateTimePicker_startDate.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker_startDate.TabIndex = 21;
            this.dateTimePicker_startDate.Value = new System.DateTime(2022, 5, 12, 12, 0, 0, 0);
            this.dateTimePicker_startDate.ValueChanged += new System.EventHandler(this.dateTimePicker_startDate_ValueChanged);
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
            this.dataGridView1.TabIndex = 23;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.updateSelectedCustomer);
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
            this.dateTimePicker_endDate.TabIndex = 24;
            this.dateTimePicker_endDate.Value = new System.DateTime(2022, 5, 12, 12, 30, 0, 0);
            this.dateTimePicker_endDate.ValueChanged += new System.EventHandler(this.dateTimePicker_endDate_ValueChanged);
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
            this.dataGridView2.TabIndex = 25;
            this.dataGridView2.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.updateSelectedUser);
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // label_select_user
            // 
            this.label_select_user.AutoSize = true;
            this.label_select_user.Location = new System.Drawing.Point(47, 134);
            this.label_select_user.Name = "label_select_user";
            this.label_select_user.Size = new System.Drawing.Size(71, 13);
            this.label_select_user.TabIndex = 26;
            this.label_select_user.Text = "Select a User";
            // 
            // label_select_customer
            // 
            this.label_select_customer.AutoSize = true;
            this.label_select_customer.Location = new System.Drawing.Point(439, 134);
            this.label_select_customer.Name = "label_select_customer";
            this.label_select_customer.Size = new System.Drawing.Size(93, 13);
            this.label_select_customer.TabIndex = 27;
            this.label_select_customer.Text = "Select a Customer";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel1.Controls.Add(this.label_title);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(784, 100);
            this.panel1.TabIndex = 28;
            // 
            // Appointment_Create
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
            this.Controls.Add(this.button_create);
            this.Controls.Add(this.label_end_time);
            this.Controls.Add(this.label_start_time);
            this.Controls.Add(this.label_customer_id);
            this.Controls.Add(this.textBox_customer_id);
            this.Controls.Add(this.textBox_user_id);
            this.Controls.Add(this.label_user_id);
            this.Controls.Add(this.textBox_type);
            this.Controls.Add(this.label_type);
            this.Name = "Appointment_Create";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Appointment_Create";
            this.Load += new System.EventHandler(this.Appointment_Create_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_title;
        private System.Windows.Forms.Label label_type;
        private System.Windows.Forms.TextBox textBox_type;
        private System.Windows.Forms.Label label_user_id;
        private System.Windows.Forms.TextBox textBox_user_id;
        private System.Windows.Forms.TextBox textBox_customer_id;
        private System.Windows.Forms.Label label_customer_id;
        private System.Windows.Forms.Label label_start_time;
        private System.Windows.Forms.Label label_end_time;
        private System.Windows.Forms.Button button_create;
        private System.Windows.Forms.Button button_cancel;
        private System.Windows.Forms.DateTimePicker dateTimePicker_startDate;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DateTimePicker dateTimePicker_endDate;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label label_select_user;
        private System.Windows.Forms.Label label_select_customer;
        private System.Windows.Forms.Panel panel1;
    }
}