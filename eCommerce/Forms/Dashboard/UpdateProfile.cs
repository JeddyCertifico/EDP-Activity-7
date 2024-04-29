using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace eCommerce.Forms
{
    public partial class UpdateProfile : Form
    {
        int id;
        string username;
        string email;
        string address;

        public UpdateProfile(int id)
        {
            InitializeComponent();
            CenterPanel(panel2, panel1);
            CenterPanel(pnProfileContainer, panel8);
            CenterPanelHorizontal(panel22, panel21);

            this.id = id;

            init();
        }

        private void CenterPanel(Panel panel, Panel parentPanel)
        {
            int centerX = parentPanel.Width / 2;
            int centerY = parentPanel.Height / 2;

            int newX = centerX - (panel.Width / 2);
            int newY = centerY - (panel.Height / 2);

            panel.Location = new Point(newX, newY);
        }

        private void CenterPanelHorizontal(Panel panel, Panel parentPanel)
        {
            panel.Location = new Point((parentPanel.Width - panel.Width) / 2, panel.Location.Y);
        }

        private void panel1_Resize(object sender, EventArgs e)
        {
            CenterPanel(panel2, panel1);
        }

        private void init()
        {
            DbHelper dbHelper = new DbHelper();

            string query = "SELECT username, email, address FROM _user WHERE user_id = @id";
            Dictionary<string, object> parameters = new Dictionary<string, object>
            {
                { "@id", id }
            };

            using (MySqlDataReader data = dbHelper.ExecuteReader(query, parameters))
            {
                if (data.Read())
                {
                    username = data["username"].ToString();
                    email = data["email"].ToString();
                    address = data["address"].ToString();
                }
            }

            txtUsername.Text = username;
            txtEmail.Text = email;
            txtAddress.Text = address;

            if (string.IsNullOrEmpty(address))
            {
                txtAddress.Text = "Address";
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            DbHelper dbHelper = new DbHelper();

            username = txtUsername.Text;
            email = txtEmail.Text;
            address = txtAddress.Text;

            if (
                string.IsNullOrEmpty(username)
                || string.IsNullOrEmpty(email)
                || string.IsNullOrEmpty(address)
                || address == "Address"
                || email == "Email"
                || username == "Username"
            )
            {
                MessageBox.Show(
                    "Please fill in all fields",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
                return;
            }

            string query =
                "UPDATE _user SET username = @username, email = @email, address = @address WHERE user_id = @id";
            Dictionary<string, object> parameters = new Dictionary<string, object>
            {
                { "@username", username },
                { "@email", email },
                { "@address", address },
                { "@id", id }
            };

            dbHelper.Update(query, parameters);
            MessageBox.Show(
                "Profile updated successfully",
                "Success",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );

            this.Close();
        }

        private void txtUsername_Enter(object sender, EventArgs e)
        {
            if (txtUsername.Text == "Username")
            {
                txtUsername.Text = "";
                txtUsername.ForeColor = Color.FromArgb(44, 62, 80);
            }
        }

        private void txtUsername_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUsername.Text))
            {
                txtUsername.Text = "Username";
                txtUsername.ForeColor = SystemColors.GrayText;
            }
        }

        private void txtEmail_Enter(object sender, EventArgs e)
        {
            if (txtEmail.Text == "Email")
            {
                txtEmail.Text = "";
                txtEmail.ForeColor = Color.FromArgb(44, 62, 80);
            }
        }

        private void txtEmail_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                txtEmail.Text = "Email";
                txtEmail.ForeColor = SystemColors.GrayText;
            }
        }

        private void txtAddress_Enter(object sender, EventArgs e)
        {
            if (txtAddress.Text == "Address")
            {
                txtAddress.Text = "";
                txtAddress.ForeColor = Color.FromArgb(44, 62, 80);
            }
        }

        private void txtAddress_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtAddress.Text))
            {
                txtAddress.Text = "Address";
                txtAddress.ForeColor = SystemColors.GrayText;
            }
        }
    }
}
