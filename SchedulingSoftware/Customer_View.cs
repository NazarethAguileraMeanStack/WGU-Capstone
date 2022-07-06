using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchedulingSoftware
{
    public partial class Customer_View : Form
    {
        public Customer_View()
        {
            InitializeComponent();
        }

        private void button_cancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void Customer_View_Load(object sender, EventArgs e)
        {
            textBox_name.Text = DataTrackingService.CurrentCustomer.CustomerName;
            textBox_phone.Text = DataTrackingService.CurrentCustomer.Phone;
            textBox_city.Text = DataTrackingService.CurrentCustomer.City;
            textBox_address.Text = DataTrackingService.CurrentCustomer.Address;
            textBox_address2.Text = DataTrackingService.CurrentCustomer.Address2;
            textBox_country.Text = DataTrackingService.CurrentCustomer.Country;
            textBox_postalCode.Text = DataTrackingService.CurrentCustomer.PostalCode;
        }
    }
}
