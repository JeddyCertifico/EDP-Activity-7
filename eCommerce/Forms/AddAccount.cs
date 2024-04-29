using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eCommerce.Forms
{
    public partial class AddAccount : Form
    {
        public AddAccount()
        {
            InitializeComponent();
            CenterPanel(panel2, panel1);
            CenterPanel(pnProfileContainer, panel8);
            CenterPanelHorizontal(panel22, panel21);
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

        private void btnAdd_Click(object sender, EventArgs e)
        {
            DbHelper dbhelper = new DbHelper();
            string username = txtUsername.Text;
            string email = txtEmail.Text;
            string address = txtAddress.Text;

            if (
                string.IsNullOrWhiteSpace(username)
                || string.IsNullOrWhiteSpace(email)
                || string.IsNullOrWhiteSpace(address)
                || username == "Username"
                || email == "Email"
                || address == "Address"
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

            string query = "SELECT * FROM _user WHERE username = @username OR email = @email";
            Dictionary<string, object> parameters = new Dictionary<string, object>
            {
                { "@username", username },
                { "@email", email }
            };

            DataTable datatable = dbhelper.Read(query, parameters);
            if (datatable.Rows.Count > 0)
            {
                MessageBox.Show(
                    "Username or email already exists",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
                return;
            }

            query =
                "INSERT INTO _user (username, email, address, user_type_id) VALUES (@username, @email, @address, 2)";

            parameters = new Dictionary<string, object>
            {
                { "@username", username },
                { "@email", email },
                { "@address", address }
            };

            dbhelper.Create(query, parameters);
            MessageBox.Show(
                "Account added successfully",
                "Success",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );

            this.DialogResult = DialogResult.OK;
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
