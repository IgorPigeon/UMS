using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using UASIP.General;
using UASIP.Servises;

namespace UASIP.Forms
{
    public partial class UserView : Template
    {
        public UserView()
        {
            InitializeComponent();
            UserViewGrid.DataSource = userService.UpdateData().ToList();
            UserViewGrid.Columns[1].Visible = false;
            UserViewGrid.Columns[2].Visible = false;
        }

        private readonly UserService userService = new UserService();

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Main main = new Main();
            main.ShowDialog();
        }

        private void newRoleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            User user = new User();
            user.ShowDialog();
            UserViewGrid.DataSource = userService.UpdateData().ToList();
            UserViewGrid.Columns[1].Visible = false;
            UserViewGrid.Columns[2].Visible = false;


        }

        private void SearchButton_Click(object sender, EventArgs e)
        {

            if (IsFormValid())
            {
                IEnumerable<UserObject> userList = userService.SearchUser(UserSearchingBox.Text.Trim());
                if (userList != null)
                {
                    UserViewGrid.DataSource = userList;
                }
                else
                {
                    MessageBox.Show("No such user!", "No Record", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void refreshToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UserViewGrid.DataSource = userService.UpdateData();
            UserViewGrid.Columns[1].Visible = false;
            UserViewGrid.Columns[2].Visible = false;
            UserSearchingBox.Clear();
            UserSearchingBox.Focus();
        }

        // Open                 Done
        private void UserViewGrid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (UserViewGrid.Rows.Count > 0)
            {
                string userName = UserViewGrid.SelectedRows[0].Cells[0].Value.ToString();

                User users = new User();
                users.UserName = userName;
                users.IsUpdated = true;
                users.ShowDialog();

                UserViewGrid.DataSource = userService.UpdateData().ToList();
                UserViewGrid.Columns[1].Visible = false;
                UserViewGrid.Columns[2].Visible = false;
            }
        }

        private void UserSearchingBox_TextChanged(object sender, EventArgs e) {  }

        private void UserViewGrid_CellContentClick(object sender, DataGridViewCellEventArgs e) {  }

        private bool IsFormValid()
        {
            if (UserSearchingBox.Text.Trim() == string.Empty)
            {
                MessageBox.Show("User name is required!", "Validation error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                UserSearchingBox.Focus();
                return false;
            }

            return true;
        }

        private void UserView_Load(object sender, EventArgs e)
        {

        }
    }
}
