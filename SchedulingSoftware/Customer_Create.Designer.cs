
namespace SchedulingSoftware
{
    partial class Customer_Create
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
            this.label_name = new System.Windows.Forms.Label();
            this.textBox_name = new System.Windows.Forms.TextBox();
            this.textBox_phone = new System.Windows.Forms.TextBox();
            this.label_phone = new System.Windows.Forms.Label();
            this.label_city = new System.Windows.Forms.Label();
            this.textBox_city = new System.Windows.Forms.TextBox();
            this.label_address = new System.Windows.Forms.Label();
            this.textBox_address = new System.Windows.Forms.TextBox();
            this.textBox_address2 = new System.Windows.Forms.TextBox();
            this.label_address2 = new System.Windows.Forms.Label();
            this.label_country = new System.Windows.Forms.Label();
            this.textBox_country = new System.Windows.Forms.TextBox();
            this.textBox_postalCode = new System.Windows.Forms.TextBox();
            this.label_postalCode = new System.Windows.Forms.Label();
            this.button_create = new System.Windows.Forms.Button();
            this.button_cancel = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label_title
            // 
            this.label_title.AutoSize = true;
            this.label_title.ForeColor = System.Drawing.Color.White;
            this.label_title.Location = new System.Drawing.Point(337, 44);
            this.label_title.Name = "label_title";
            this.label_title.Size = new System.Drawing.Size(110, 13);
            this.label_title.TabIndex = 0;
            this.label_title.Text = "Create New Customer";
            this.label_title.Click += new System.EventHandler(this.label_title_Click);
            // 
            // label_name
            // 
            this.label_name.AutoSize = true;
            this.label_name.Location = new System.Drawing.Point(121, 150);
            this.label_name.Name = "label_name";
            this.label_name.Size = new System.Drawing.Size(35, 13);
            this.label_name.TabIndex = 1;
            this.label_name.Text = "Name";
            // 
            // textBox_name
            // 
            this.textBox_name.BackColor = System.Drawing.Color.Red;
            this.textBox_name.Location = new System.Drawing.Point(191, 150);
            this.textBox_name.Name = "textBox_name";
            this.textBox_name.Size = new System.Drawing.Size(200, 20);
            this.textBox_name.TabIndex = 2;
            this.textBox_name.TextChanged += new System.EventHandler(this.FormValidator);
            // 
            // textBox_phone
            // 
            this.textBox_phone.BackColor = System.Drawing.Color.Red;
            this.textBox_phone.Location = new System.Drawing.Point(191, 200);
            this.textBox_phone.Name = "textBox_phone";
            this.textBox_phone.Size = new System.Drawing.Size(200, 20);
            this.textBox_phone.TabIndex = 3;
            this.textBox_phone.TextChanged += new System.EventHandler(this.FormValidator);
            // 
            // label_phone
            // 
            this.label_phone.AutoSize = true;
            this.label_phone.Location = new System.Drawing.Point(121, 200);
            this.label_phone.Name = "label_phone";
            this.label_phone.Size = new System.Drawing.Size(38, 13);
            this.label_phone.TabIndex = 4;
            this.label_phone.Text = "Phone";
            // 
            // label_city
            // 
            this.label_city.AutoSize = true;
            this.label_city.Location = new System.Drawing.Point(121, 250);
            this.label_city.Name = "label_city";
            this.label_city.Size = new System.Drawing.Size(24, 13);
            this.label_city.TabIndex = 5;
            this.label_city.Text = "City";
            // 
            // textBox_city
            // 
            this.textBox_city.BackColor = System.Drawing.Color.Red;
            this.textBox_city.Location = new System.Drawing.Point(191, 250);
            this.textBox_city.Name = "textBox_city";
            this.textBox_city.Size = new System.Drawing.Size(200, 20);
            this.textBox_city.TabIndex = 6;
            this.textBox_city.TextChanged += new System.EventHandler(this.FormValidator);
            // 
            // label_address
            // 
            this.label_address.AutoSize = true;
            this.label_address.Location = new System.Drawing.Point(438, 150);
            this.label_address.Name = "label_address";
            this.label_address.Size = new System.Drawing.Size(45, 13);
            this.label_address.TabIndex = 7;
            this.label_address.Text = "Address";
            // 
            // textBox_address
            // 
            this.textBox_address.BackColor = System.Drawing.Color.Red;
            this.textBox_address.Location = new System.Drawing.Point(508, 150);
            this.textBox_address.Name = "textBox_address";
            this.textBox_address.Size = new System.Drawing.Size(200, 20);
            this.textBox_address.TabIndex = 8;
            this.textBox_address.TextChanged += new System.EventHandler(this.FormValidator);
            // 
            // textBox_address2
            // 
            this.textBox_address2.BackColor = System.Drawing.Color.Red;
            this.textBox_address2.Location = new System.Drawing.Point(508, 200);
            this.textBox_address2.Name = "textBox_address2";
            this.textBox_address2.Size = new System.Drawing.Size(200, 20);
            this.textBox_address2.TabIndex = 9;
            this.textBox_address2.TextChanged += new System.EventHandler(this.FormValidator);
            // 
            // label_address2
            // 
            this.label_address2.AutoSize = true;
            this.label_address2.Location = new System.Drawing.Point(438, 200);
            this.label_address2.Name = "label_address2";
            this.label_address2.Size = new System.Drawing.Size(54, 13);
            this.label_address2.TabIndex = 10;
            this.label_address2.Text = "Address 2";
            this.label_address2.Click += new System.EventHandler(this.label1_Click);
            // 
            // label_country
            // 
            this.label_country.AutoSize = true;
            this.label_country.Location = new System.Drawing.Point(438, 250);
            this.label_country.Name = "label_country";
            this.label_country.Size = new System.Drawing.Size(43, 13);
            this.label_country.TabIndex = 11;
            this.label_country.Text = "Country";
            // 
            // textBox_country
            // 
            this.textBox_country.BackColor = System.Drawing.Color.Red;
            this.textBox_country.Location = new System.Drawing.Point(508, 250);
            this.textBox_country.Name = "textBox_country";
            this.textBox_country.Size = new System.Drawing.Size(200, 20);
            this.textBox_country.TabIndex = 12;
            this.textBox_country.TextChanged += new System.EventHandler(this.FormValidator);
            // 
            // textBox_postalCode
            // 
            this.textBox_postalCode.BackColor = System.Drawing.Color.Red;
            this.textBox_postalCode.Location = new System.Drawing.Point(508, 300);
            this.textBox_postalCode.Name = "textBox_postalCode";
            this.textBox_postalCode.Size = new System.Drawing.Size(200, 20);
            this.textBox_postalCode.TabIndex = 13;
            this.textBox_postalCode.TextChanged += new System.EventHandler(this.FormValidator);
            // 
            // label_postalCode
            // 
            this.label_postalCode.AutoSize = true;
            this.label_postalCode.Location = new System.Drawing.Point(438, 300);
            this.label_postalCode.Name = "label_postalCode";
            this.label_postalCode.Size = new System.Drawing.Size(64, 13);
            this.label_postalCode.TabIndex = 14;
            this.label_postalCode.Text = "Postal Code";
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
            this.button_create.TabIndex = 15;
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
            this.button_cancel.TabIndex = 16;
            this.button_cancel.Text = "Cancel";
            this.button_cancel.UseVisualStyleBackColor = false;
            this.button_cancel.Click += new System.EventHandler(this.button_cancel_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel1.Controls.Add(this.label_title);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(784, 100);
            this.panel1.TabIndex = 17;
            // 
            // Customer_Create
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button_cancel);
            this.Controls.Add(this.button_create);
            this.Controls.Add(this.label_postalCode);
            this.Controls.Add(this.textBox_postalCode);
            this.Controls.Add(this.textBox_country);
            this.Controls.Add(this.label_country);
            this.Controls.Add(this.label_address2);
            this.Controls.Add(this.textBox_address2);
            this.Controls.Add(this.textBox_address);
            this.Controls.Add(this.label_address);
            this.Controls.Add(this.textBox_city);
            this.Controls.Add(this.label_city);
            this.Controls.Add(this.label_phone);
            this.Controls.Add(this.textBox_phone);
            this.Controls.Add(this.textBox_name);
            this.Controls.Add(this.label_name);
            this.Name = "Customer_Create";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Customer_Create";
            this.Load += new System.EventHandler(this.Customer_Create_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_title;
        private System.Windows.Forms.Label label_name;
        private System.Windows.Forms.TextBox textBox_name;
        private System.Windows.Forms.TextBox textBox_phone;
        private System.Windows.Forms.Label label_phone;
        private System.Windows.Forms.Label label_city;
        private System.Windows.Forms.TextBox textBox_city;
        private System.Windows.Forms.Label label_address;
        private System.Windows.Forms.TextBox textBox_address;
        private System.Windows.Forms.TextBox textBox_address2;
        private System.Windows.Forms.Label label_address2;
        private System.Windows.Forms.Label label_country;
        private System.Windows.Forms.TextBox textBox_country;
        private System.Windows.Forms.TextBox textBox_postalCode;
        private System.Windows.Forms.Label label_postalCode;
        private System.Windows.Forms.Button button_create;
        private System.Windows.Forms.Button button_cancel;
        private System.Windows.Forms.Panel panel1;
    }
}