
namespace SchedulingSoftware
{
    partial class CustomerRecords
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button_create_customer = new System.Windows.Forms.Button();
            this.button_view_customer_details = new System.Windows.Forms.Button();
            this.button_edit_customer = new System.Windows.Forms.Button();
            this.button_delete_customer = new System.Windows.Forms.Button();
            this.button_exit = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.button_search = new System.Windows.Forms.Button();
            this.textBox_search = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(345, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Customer Records";
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
            this.dataGridView1.Size = new System.Drawing.Size(684, 200);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // button_create_customer
            // 
            this.button_create_customer.BackColor = System.Drawing.Color.MidnightBlue;
            this.button_create_customer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_create_customer.ForeColor = System.Drawing.Color.White;
            this.button_create_customer.Location = new System.Drawing.Point(23, 370);
            this.button_create_customer.Name = "button_create_customer";
            this.button_create_customer.Size = new System.Drawing.Size(150, 40);
            this.button_create_customer.TabIndex = 2;
            this.button_create_customer.Text = "Create Customer";
            this.button_create_customer.UseVisualStyleBackColor = false;
            this.button_create_customer.Click += new System.EventHandler(this.button_create_customer_Click);
            // 
            // button_view_customer_details
            // 
            this.button_view_customer_details.BackColor = System.Drawing.Color.MidnightBlue;
            this.button_view_customer_details.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_view_customer_details.Enabled = false;
            this.button_view_customer_details.ForeColor = System.Drawing.Color.White;
            this.button_view_customer_details.Location = new System.Drawing.Point(219, 370);
            this.button_view_customer_details.Name = "button_view_customer_details";
            this.button_view_customer_details.Size = new System.Drawing.Size(150, 40);
            this.button_view_customer_details.TabIndex = 3;
            this.button_view_customer_details.Text = "Customer Details";
            this.button_view_customer_details.UseVisualStyleBackColor = false;
            this.button_view_customer_details.Click += new System.EventHandler(this.button_view_customer_details_Click);
            // 
            // button_edit_customer
            // 
            this.button_edit_customer.BackColor = System.Drawing.Color.MidnightBlue;
            this.button_edit_customer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_edit_customer.Enabled = false;
            this.button_edit_customer.ForeColor = System.Drawing.Color.White;
            this.button_edit_customer.Location = new System.Drawing.Point(415, 370);
            this.button_edit_customer.Name = "button_edit_customer";
            this.button_edit_customer.Size = new System.Drawing.Size(150, 40);
            this.button_edit_customer.TabIndex = 4;
            this.button_edit_customer.Text = "Edit Customer";
            this.button_edit_customer.UseVisualStyleBackColor = false;
            this.button_edit_customer.Click += new System.EventHandler(this.button_edit_customer_Click);
            // 
            // button_delete_customer
            // 
            this.button_delete_customer.BackColor = System.Drawing.Color.MidnightBlue;
            this.button_delete_customer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_delete_customer.Enabled = false;
            this.button_delete_customer.ForeColor = System.Drawing.Color.White;
            this.button_delete_customer.Location = new System.Drawing.Point(611, 370);
            this.button_delete_customer.Name = "button_delete_customer";
            this.button_delete_customer.Size = new System.Drawing.Size(150, 40);
            this.button_delete_customer.TabIndex = 5;
            this.button_delete_customer.Text = "Delete Customer";
            this.button_delete_customer.UseVisualStyleBackColor = false;
            this.button_delete_customer.Click += new System.EventHandler(this.button_delete_customer_Click);
            // 
            // button_exit
            // 
            this.button_exit.BackColor = System.Drawing.Color.MidnightBlue;
            this.button_exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_exit.ForeColor = System.Drawing.Color.White;
            this.button_exit.Location = new System.Drawing.Point(342, 450);
            this.button_exit.Name = "button_exit";
            this.button_exit.Size = new System.Drawing.Size(100, 25);
            this.button_exit.TabIndex = 6;
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
            this.panel1.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(162, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Select a Customer to view or edit";
            // 
            // button_search
            // 
            this.button_search.BackColor = System.Drawing.Color.MidnightBlue;
            this.button_search.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_search.ForeColor = System.Drawing.Color.White;
            this.button_search.Location = new System.Drawing.Point(428, 124);
            this.button_search.Name = "button_search";
            this.button_search.Size = new System.Drawing.Size(100, 25);
            this.button_search.TabIndex = 9;
            this.button_search.Text = "Find Customer";
            this.button_search.UseVisualStyleBackColor = false;
            this.button_search.Click += new System.EventHandler(this.button_search_Click);
            // 
            // textBox_search
            // 
            this.textBox_search.Location = new System.Drawing.Point(534, 127);
            this.textBox_search.Name = "textBox_search";
            this.textBox_search.Size = new System.Drawing.Size(200, 20);
            this.textBox_search.TabIndex = 10;
            this.textBox_search.TextChanged += new System.EventHandler(this.search);
            // 
            // CustomerRecords
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.textBox_search);
            this.Controls.Add(this.button_search);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button_exit);
            this.Controls.Add(this.button_delete_customer);
            this.Controls.Add(this.button_edit_customer);
            this.Controls.Add(this.button_view_customer_details);
            this.Controls.Add(this.button_create_customer);
            this.Controls.Add(this.dataGridView1);
            this.Name = "CustomerRecords";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CustomerRecords";
            this.Load += new System.EventHandler(this.CustomerRecords_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button_create_customer;
        private System.Windows.Forms.Button button_view_customer_details;
        private System.Windows.Forms.Button button_edit_customer;
        private System.Windows.Forms.Button button_delete_customer;
        private System.Windows.Forms.Button button_exit;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button_search;
        private System.Windows.Forms.TextBox textBox_search;
    }
}