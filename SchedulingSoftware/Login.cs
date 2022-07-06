using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Globalization;
using System.Windows.Forms;

namespace SchedulingSoftware
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            checkLanguage();
        }

        private void checkLanguage() {
            if (CultureInfo.CurrentCulture.TwoLetterISOLanguageName != "en")
            {
                label_title.Text = "Formulario de acceso";
                label_username.Text = "nombre de usuario";
                label_password.Text = "contraseña";
                button_submit.Text = "Enviar";
                label_error.Text = "El nombre de usuario y la contraseña no coincidían.";
            }
        }

        private void writeToFileLoginSuccess() {
            try {
                LoginRecordSuccess loginRecordSuccess = new LoginRecordSuccess();
                loginRecordSuccess.CreateDate = DateTime.Now.ToUniversalTime().ToString("yyyy-MM-dd HH:mm:ss tt");
                loginRecordSuccess.CreatedBy = textbox_username.Text;
                
                if (File.Exists("loginTracking.txt")) {
                    File.AppendAllText("loginTracking.txt", loginRecordSuccess.logToFile());
                } else {
                    File.WriteAllText("loginTracking.txt", loginRecordSuccess.logToFile());
                }
            } catch (Exception e) {
                MessageBox.Show(e.Message);
            }
        }

        private void writeToFileLoginFailure() {
            try
            {
                LoginRecordFailure loginRecordFailure = new LoginRecordFailure();
                loginRecordFailure.CreateDate = DateTime.Now.ToUniversalTime().ToString("yyyy-MM-dd HH:mm:ss tt");
                loginRecordFailure.CreatedBy = textbox_username.Text;
                if (File.Exists("loginTracking.txt"))
                {
                    File.AppendAllText("loginTracking.txt", loginRecordFailure.logToFile());
                }
                else
                {
                    File.WriteAllText("loginTracking.txt", loginRecordFailure.logToFile());
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UserTableReference userRef = new UserTableReference();
            DatabaseHandler db = new DatabaseHandler();
            User currentUser = new User();
            string username = textbox_username.Text;
            string password = textbox_password.Text;

            try {
                string query = $"SELECT * FROM user WHERE userName='{username}' AND password='{password}';";
                MySqlConnection connection = new MySqlConnection(db.ConnectionString);
                connection.Open();
                MySqlCommand command = new MySqlCommand(query, connection);
                MySqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    reader.Read();
                    currentUser.UserID = Int32.Parse(reader.GetValue(userRef.UserID).ToString());
                    currentUser.UserName = reader.GetValue(userRef.UserName).ToString();
                    currentUser.Password = reader.GetValue(userRef.Password).ToString();
                    currentUser.Active = Int32.Parse(reader.GetValue(userRef.Active).ToString());
                    currentUser.CreateDate = reader.GetValue(userRef.CreateDate).ToString();
                    currentUser.CreatedBy = reader.GetValue(userRef.CreatedBy).ToString();
                    currentUser.LastUpdate = reader.GetValue(userRef.LastUpdate).ToString();
                    currentUser.LastUpdateBy = reader.GetValue(userRef.LastUpdateBy).ToString();

                    reader.Close();
                    connection.Close();
                    writeToFileLoginSuccess();
                    DataTrackingService.CurrentUser = currentUser;
                    Dashboard dashboard = new Dashboard();
                    dashboard.Show();
                    this.Hide();
                }
                else {
                    label_error.Visible = true;
                    writeToFileLoginFailure();
                    reader.Close();
                    connection.Close();
                }
                
            }
            catch (Exception error) {
                MessageBox.Show(error.Message);
            }


        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void validateUsername() {
            if (textbox_username.Text == "")
            {
                textbox_username.BackColor = Color.Red;
            }
            else {
                textbox_username.BackColor = Color.White;
            }
        }

        private void validatePassword() {
            if (textbox_password.Text == "")
            {
                textbox_password.BackColor = Color.Red;
            }
            else {
                textbox_password.BackColor = Color.White;
            }
        }
        private void enableSubmitButton()
        {
            if (textbox_username.Text != "" && textbox_password.Text != "")
            {
                button_submit.Enabled = true;
            }
            else
            {
                button_submit.Enabled = false;
            }
        }
        private void FormValidation(object sender, EventArgs e) {
            validateUsername();
            validatePassword();
            enableSubmitButton();
        }

    }
}
