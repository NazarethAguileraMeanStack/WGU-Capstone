
namespace SchedulingSoftware
{
    partial class Login
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
            this.button_submit = new System.Windows.Forms.Button();
            this.textbox_password = new System.Windows.Forms.TextBox();
            this.textbox_username = new System.Windows.Forms.TextBox();
            this.label_username = new System.Windows.Forms.Label();
            this.label_password = new System.Windows.Forms.Label();
            this.label_error = new System.Windows.Forms.Label();
            this.label_title = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_submit
            // 
            this.button_submit.BackColor = System.Drawing.Color.MidnightBlue;
            this.button_submit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_submit.Enabled = false;
            this.button_submit.ForeColor = System.Drawing.Color.White;
            this.button_submit.Location = new System.Drawing.Point(342, 450);
            this.button_submit.Name = "button_submit";
            this.button_submit.Size = new System.Drawing.Size(100, 25);
            this.button_submit.TabIndex = 0;
            this.button_submit.Text = "Submit";
            this.button_submit.UseVisualStyleBackColor = false;
            this.button_submit.Click += new System.EventHandler(this.button1_Click);
            // 
            // textbox_password
            // 
            this.textbox_password.BackColor = System.Drawing.Color.Red;
            this.textbox_password.Location = new System.Drawing.Point(328, 300);
            this.textbox_password.Name = "textbox_password";
            this.textbox_password.Size = new System.Drawing.Size(200, 20);
            this.textbox_password.TabIndex = 1;
            this.textbox_password.TextChanged += new System.EventHandler(this.FormValidation);
            // 
            // textbox_username
            // 
            this.textbox_username.BackColor = System.Drawing.Color.Red;
            this.textbox_username.Location = new System.Drawing.Point(328, 250);
            this.textbox_username.Name = "textbox_username";
            this.textbox_username.Size = new System.Drawing.Size(200, 20);
            this.textbox_username.TabIndex = 2;
            this.textbox_username.TextChanged += new System.EventHandler(this.FormValidation);
            // 
            // label_username
            // 
            this.label_username.AutoSize = true;
            this.label_username.ForeColor = System.Drawing.Color.Black;
            this.label_username.Location = new System.Drawing.Point(258, 250);
            this.label_username.Name = "label_username";
            this.label_username.Size = new System.Drawing.Size(53, 13);
            this.label_username.TabIndex = 3;
            this.label_username.Text = "username";
            // 
            // label_password
            // 
            this.label_password.AutoSize = true;
            this.label_password.Location = new System.Drawing.Point(258, 300);
            this.label_password.Name = "label_password";
            this.label_password.Size = new System.Drawing.Size(52, 13);
            this.label_password.TabIndex = 4;
            this.label_password.Text = "password";
            // 
            // label_error
            // 
            this.label_error.AutoSize = true;
            this.label_error.ForeColor = System.Drawing.Color.Red;
            this.label_error.Location = new System.Drawing.Point(275, 150);
            this.label_error.Name = "label_error";
            this.label_error.Size = new System.Drawing.Size(234, 13);
            this.label_error.TabIndex = 5;
            this.label_error.Text = "The username and/or password does not match";
            this.label_error.Visible = false;
            // 
            // label_title
            // 
            this.label_title.AutoSize = true;
            this.label_title.ForeColor = System.Drawing.Color.White;
            this.label_title.Location = new System.Drawing.Point(350, 44);
            this.label_title.Name = "label_title";
            this.label_title.Size = new System.Drawing.Size(84, 13);
            this.label_title.TabIndex = 6;
            this.label_title.Text = "User Login Form";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel1.Controls.Add(this.label_title);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(784, 100);
            this.panel1.TabIndex = 7;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.label_username);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.textbox_username);
            this.Controls.Add(this.label_error);
            this.Controls.Add(this.label_password);
            this.Controls.Add(this.textbox_password);
            this.Controls.Add(this.button_submit);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_submit;
        private System.Windows.Forms.TextBox textbox_password;
        private System.Windows.Forms.TextBox textbox_username;
        private System.Windows.Forms.Label label_username;
        private System.Windows.Forms.Label label_password;
        private System.Windows.Forms.Label label_error;
        private System.Windows.Forms.Label label_title;
        private System.Windows.Forms.Panel panel1;
    }
}