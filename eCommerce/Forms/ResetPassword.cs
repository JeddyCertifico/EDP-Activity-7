using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eCommerce
{
    public partial class ResetPassword : Form
    {
        public ResetPassword()
        {
            InitializeComponent();
            CenterPanel(panel2, panel1);
            CenterPanel(pnProfileContainer, panel8);
            rstUsernameEmaill.GotFocus += new EventHandler(rstUsernameEmaill_Enter);
            rstUsernameEmaill.LostFocus += new EventHandler(rstUsernameEmaill_Leave);
            rstNewPassword.GotFocus += new EventHandler(rstNewPassword_Enter);
            rstNewPassword.LostFocus += new EventHandler(rstNewPassword_Leave);
            rstConfirmPassword.GotFocus += new EventHandler(rstConfirmPassword_Enter);
            rstConfirmPassword.LostFocus += new EventHandler(rstConfirmPassword_Leave);

            panel1.Resize += panel1_Resize;
            CenterPanelHorizontal(panel24, panel25);
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

        private void rstUsernameEmaill_Enter(object sender, EventArgs e)
        {
            if (rstUsernameEmaill.Text == "Username or email")
            {
                rstUsernameEmaill.Text = "";
                rstUsernameEmaill.ForeColor = Color.FromArgb(44, 62, 80);
            }
        }

        private void rstUsernameEmaill_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(rstUsernameEmaill.Text))
            {
                rstUsernameEmaill.Text = "Username or email";
                rstUsernameEmaill.ForeColor = SystemColors.GrayText;
            }
        }

        private void rstNewPassword_Enter(object sender, EventArgs e)
        {
            if (rstNewPassword.Text == "New Password")
            {
                rstNewPassword.Text = "";
                rstNewPassword.ForeColor = Color.FromArgb(44, 62, 80);
                rstNewPassword.PasswordChar = '*';
            }
        }

        private void rstNewPassword_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(rstNewPassword.Text))
            {
                rstNewPassword.Text = "New Password";
                rstNewPassword.ForeColor = SystemColors.GrayText;
                rstNewPassword.PasswordChar = '\0';
            }
        }

        private void rstConfirmPassword_Enter(object sender, EventArgs e)
        {
            if (rstConfirmPassword.Text == "Confirm Password")
            {
                rstConfirmPassword.Text = "";
                rstConfirmPassword.ForeColor = Color.FromArgb(44, 62, 80);
                rstConfirmPassword.PasswordChar = '*';
            }
        }

        private void rstConfirmPassword_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(rstConfirmPassword.Text))
            {
                rstConfirmPassword.Text = "Confirm Password";
                rstConfirmPassword.ForeColor = SystemColors.GrayText;
                rstConfirmPassword.PasswordChar = '\0';
            }
        }

        private void btnreset_Click(object sender, EventArgs e)
        {
            DbHelper dbHelper = new DbHelper();

            string usernameEmail = this.rstUsernameEmaill.Text;
            string newPassword = this.rstNewPassword.Text;
            string confirmPassword = this.rstConfirmPassword.Text;

            if (
                usernameEmail == "Username or email"
                || newPassword == "New Password"
                || confirmPassword == "Confirm Password"
            )
            {
                MessageBox.Show(
                    "Please enter your username or email and new password.",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
                return;
            }

            if (newPassword != confirmPassword)
            {
                MessageBox.Show(
                    "Password does not match.",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
                return;
            }

            string query =
                "SELECT * FROM _user WHERE (username = @usernameEmail OR email = @usernameEmail) AND user_type_id = 1";

            Dictionary<string, object> parameters = new Dictionary<string, object>
            {
                { "@usernameEmail", usernameEmail }
            };

            Object result = dbHelper.ExecuteScalar(query, parameters);

            if (result == null)
            {
                MessageBox.Show(
                    "Username or email does not exist.",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
                return;
            }

            query =
                "UPDATE _user SET password = @newPassword WHERE (username = @usernameEmail OR email = @usernameEmail) AND user_type_id = 1";

            parameters = new Dictionary<string, object>
            {
                { "@newPassword", newPassword },
                { "@usernameEmail", usernameEmail }
            };

            dbHelper.Update(query, parameters);

            MessageBox.Show(
                "Password reset successful.",
                "Success",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );

            Login loginForm = new Login();
            loginForm.Show();
            this.Hide();
        }

        private void ResetPassword_FormClosing(object sender, FormClosingEventArgs e)
        {
            Login loginForm = new Login();
            loginForm.Show();
            this.Hide();
        }
    }
}
