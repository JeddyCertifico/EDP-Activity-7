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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            CenterPanel(panel2, panel1);
            CenterPanel(pnProfileContainer, panel8);
            username.GotFocus += new EventHandler(username_Enter);
            username.LostFocus += new EventHandler(username_Leave);
            password.GotFocus += new EventHandler(password_Enter);
            password.LostFocus += new EventHandler(password_Leave);

            panel1.Resize += panel1_Resize;
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

        private void username_Enter(object sender, EventArgs e)
        {
            if (username.Text == "Username")
            {
                username.Text = "";
                username.ForeColor = Color.FromArgb(44, 62, 80);
            }
        }

        private void username_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(username.Text))
            {
                username.Text = "Username";
                username.ForeColor = SystemColors.GrayText;
            }
        }

        private void password_Enter(object sender, EventArgs e)
        {
            if (password.Text == "Password")
            {
                password.Text = "";
                password.ForeColor = Color.FromArgb(44, 62, 80);
                password.PasswordChar = '*';
            }
        }

        private void password_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(password.Text))
            {
                password.Text = "Password";
                password.ForeColor = SystemColors.GrayText;
                password.PasswordChar = '\0';
            }
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            DbHelper dbHelper = new DbHelper();

            string username = this.username.Text;
            string password = this.password.Text;

            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show(
                    "Please enter your username and password.",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
                return;
            }

            string query =
                "SELECT user_id FROM _user WHERE username = @username AND password = @password AND user_type_id = 1";

            Dictionary<string, object> parameters = new Dictionary<string, object>
            {
                { "@username", username },
                { "@password", password }
            };

            Object result = dbHelper.ExecuteScalar(query, parameters);

            if (result == null)
            {
                MessageBox.Show(
                    "Invalid username or password.",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
                return;
            }

            int userId = Convert.ToInt32(result);
            DashboardMenu dashboardMenu = new DashboardMenu(userId);
            dashboardMenu.Show();
            this.Hide();
        }

        private void forgotPassword_Click(object sender, EventArgs e)
        {
            ResetPassword ResetPasswordForm = new ResetPassword();
            ResetPasswordForm.Show();
            this.Hide();
        }

        private void forgotPassword_MouseHover(object sender, EventArgs e)
        {
            Font currentFont = forgotPassword.Font;
            Font newFont = new Font(currentFont, FontStyle.Underline);
            forgotPassword.Font = newFont;
        }

        private void forgotPassword_MouseLeave(object sender, EventArgs e)
        {
            Font currentFont = forgotPassword.Font;
            Font newFont = new Font(currentFont, FontStyle.Regular);
            forgotPassword.Font = newFont;
        }
    }
}
