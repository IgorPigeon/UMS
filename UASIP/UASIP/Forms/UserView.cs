using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using UASIP.General;
using UASIP.Servises;

namespace UASIP.Forms
{
    public partial class UserView : Template
    {
        int pageNum = 1;

        public UserView()
        {
            InitializeComponent();
            ToDataGrid(pageNum);
        }

        public void ToDataGrid(int pageNum)
        {
            List<UserObject> list = userService.UpdateData().ToList();
            int take;
            if (pageNum > list.Count / 10)
            {
                take = list.Count % 10;
            }
            else
            {
                take = 10;
            }

            UserViewGrid.DataSource = list.Skip(pageNum * 10 - 10).Take(take).ToList();
            Arrows(pageNum, list);
            PageNum.Text = "Page: " + pageNum.ToString();
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
            pageNum = 1;
            ToDataGrid(pageNum);
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {

            if (IsFormValid())
            {
                IEnumerable<UserObject> userList = userService.SearchUser(UserSearchingBox.Text.Trim());
                if (userList != null)
                {
                    pageNum = 1;
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
            pageNum = 1;
            ToDataGrid(pageNum);
            UserSearchingBox.Clear();
            UserSearchingBox.Focus();
        }

        private void UserViewGrid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (UserViewGrid.Rows.Count > 0)
            {
                string userName = UserViewGrid.SelectedRows[0].Cells[0].Value.ToString();

                User users = new User();
                users.UserName = userName;
                users.IsUpdated = true;
                users.ShowDialog();

                ToDataGrid(pageNum);
            }
        }

        private void UserSearchingBox_TextChanged(object sender, EventArgs e) { }

        private void UserViewGrid_CellContentClick(object sender, DataGridViewCellEventArgs e) { }

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

        private void UserView_Load(object sender, EventArgs e) { }

        private void UserView_Load_1(object sender, EventArgs e) { }

        private void label4_Click(object sender, EventArgs e) { }

        private void button1_Click(object sender, EventArgs e)
        {
            pageNum += 1;
            ToDataGrid(pageNum);
        }

        private void PrRageButton_Click(object sender, EventArgs e)
        {
            pageNum -= 1;
            ToDataGrid(pageNum);
        }

        public void Arrows(int pageNum, List<UserObject> list)
        {
            if (pageNum == 1)
            {
                PrRageButton.Enabled = false;
                if (pageNum > list.Count / 10)
                {
                    NxPageButton.Enabled = false;
                }
                else
                {
                    NxPageButton.Enabled = true;
                }
            }
            else
            {
                PrRageButton.Enabled = true;
                if (pageNum > list.Count / 10)
                {
                    NxPageButton.Enabled = false;
                }
                else
                {
                    NxPageButton.Enabled = true;
                }
            }
        }

        private void PageNum_Click(object sender, EventArgs e) { }
    }
}