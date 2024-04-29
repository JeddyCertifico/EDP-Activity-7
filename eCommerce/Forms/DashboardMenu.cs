using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using eCommerce.Forms;

namespace eCommerce
{
    public partial class DashboardMenu : Form
    {
        int id;

        public DashboardMenu(int id)
        {
            InitializeComponent();
            this.id = id;
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            formTitle.Text = "DASHBOARD";
            this.panel1.Controls.Clear();
            Dashboard dashboard = new Dashboard()
            {
                Dock = DockStyle.Fill,
                TopLevel = false,
                TopMost = true
            };
            dashboard.FormBorderStyle = FormBorderStyle.None;
            this.panel1.Controls.Add(dashboard);
            dashboard.Show();
        }

        private void iconButton9_Click(object sender, EventArgs e)
        {
            About about = new About();
            about.ShowDialog();
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            formTitle.Text = "ORDER";
            this.panel1.Controls.Clear();
            Order order = new Order()
            {
                Dock = DockStyle.Fill,
                TopLevel = false,
                TopMost = true
            };
            order.FormBorderStyle = FormBorderStyle.None;
            this.panel1.Controls.Add(order);
            order.Show();
        }

        private void btnlogout_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }

        private void DashboardMenu_Load(object sender, EventArgs e)
        {
            formTitle.Text = "DASHBOARD";
            this.panel1.Controls.Clear();
            Dashboard dashboard = new Dashboard()
            {
                Dock = DockStyle.Fill,
                TopLevel = false,
                TopMost = true
            };
            dashboard.FormBorderStyle = FormBorderStyle.None;
            this.panel1.Controls.Add(dashboard);
            dashboard.Show();
        }

        private void btnCustomer_Click(object sender, EventArgs e)
        {
            formTitle.Text = "CUSTOMERS";
            this.panel1.Controls.Clear();
            Customers customers = new Customers()
            {
                Dock = DockStyle.Fill,
                TopLevel = false,
                TopMost = true
            };
            customers.FormBorderStyle = FormBorderStyle.None;
            this.panel1.Controls.Add(customers);
            customers.Show();
        }

        private void btnUpdateProfile_Click(object sender, EventArgs e)
        {
            UpdateProfile updateProfile = new UpdateProfile(id);
            updateProfile.ShowDialog();
        }

        private void btnProduct_Click(object sender, EventArgs e)
        {
            formTitle.Text = "PRODUCTS";
            this.panel1.Controls.Clear();
            Product product = new Product()
            {
                Dock = DockStyle.Fill,
                TopLevel = false,
                TopMost = true
            };
            product.FormBorderStyle = FormBorderStyle.None;
            this.panel1.Controls.Add(product);
            product.Show();
        }
    }
}
