using System;
using System.Windows.Forms;
using UASIP.Servises;

namespace UASIP.Forms
{
    public partial class Login : Template
    {
        public Login()
        {
            InitializeComponent();
        }

        UserService userService = new UserService();
        EntryService entryService = new EntryService();

        private void Login_Load(object sender, EventArgs e) { }

        // Login
        private void LoginButton_Click(object sender, EventArgs e)
        {
            if (IsFormValid())
            {
                string userName = UserNameBox.Text.Trim();
                string userPass = UserPassBox.Text.Trim();

                if (userService.LoginCheck(userName, userPass))
                {
                    MessageBox.Show("to the Fight Club.", "Wellcome", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    entryService.SaveEntry(userName);
                    this.Hide();
                    Main main = new Main();
                    main.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Hi!", "Oopsie...", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    MessageBox.Show("Wait a minute...", "Oopsie chapter 2", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    MessageBox.Show("Who are u?", "Oopsie again", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private bool IsFormValid()
        {
            if (UserNameBox.Text.Trim() == string.Empty)
            {
                MessageBox.Show("User name is required!", "Validation error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                UserNameBox.Focus();
                return false;
            }
            else if (UserPassBox.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Password is required!", "Validation error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                UserNameBox.Focus();
                return false;
            }

            return true;
        }
    }
}