using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using UASIP.General;
using UASIP.Servises;

namespace UASIP.Forms
{
    public partial class User : Template
    {
        public User()
        {
            InitializeComponent();
        }

        public string UserName { get; set; }
        public bool IsUpdated { get; set; }

        private readonly UserService userService = new UserService();
        private readonly RoleService roleService = new RoleService();

        private void User_Load(object sender, EventArgs e)
        {
            DataLoadingToComboBox();

            if (this.IsUpdated)
            {
                UserObject userObject = userService.LoadUser(UserName);

                UserNameBox.Text = userObject.UserName;
                UserPassBox.Text = userObject.UserPass;
                UserComboBox.SelectedValue = userObject.RoleID;
                ActiveCheckBox.Checked = userObject.IsActive;
                DescUserBox.Text = userObject.Description;
                DateTimePicker.Value = userObject.DateBirth;
                SaveButton.Text = "Update";
                DeleteButton.Enabled = true;
            }
        }

        private void DataLoadingToComboBox() // Here
        {
            UserComboBox.DataSource = roleService.UpdateData().ToList();
            UserComboBox.DisplayMember = "RoleName";
            UserComboBox.ValueMember = "RoleID";                
        }

        private void label2_Click(object sender, EventArgs e)
        {  }

        private void RoleDescBox_TextChanged(object sender, EventArgs e)
        {  }

        private void RoleNameBox_TextChanged(object sender, EventArgs e)
        {  }

        private void label1_Click(object sender, EventArgs e)
        {  }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {  }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {  }

        private void checkBox1_CheckedChanged(object sender, EventArgs e) {  }

        private void RoleComboBox_SelectedIndexChanged(object sender, EventArgs e) {  }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (IsFormValid())
            {
                string userName = UserNameBox.Text.Trim();
                string userPass = UserPassBox.Text.Trim();
                int roleID = (int)UserComboBox.SelectedValue; // Here
                bool isActive = ActiveCheckBox.Checked;
                string description = DescUserBox.Text.Trim();
                DateTime birthTime = DateTimePicker.Value;
                string messageBox = userService.SaveUser(this.UserName, IsUpdated, userPass, roleID, isActive, userName, description, birthTime);
                
                if (messageBox == "Such user is already exist!")
                {
                    MessageBox.Show(messageBox, "Validation error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show(messageBox, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
            }
        }

        private void label4_Click(object sender, EventArgs e) {  }

        private void DateTimePicker_ValueChanged(object sender, EventArgs e) {  }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (this.IsUpdated)
            {
                DialogResult delRes = MessageBox.Show("Are you really want to delete?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (delRes == DialogResult.Yes)
                {
                    string messageBox = userService.DeleteUser(this.UserName);

                    MessageBox.Show(messageBox, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
            }
        }

        private void DescUserBox_TextChanged(object sender, EventArgs e) {  }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e) {
            this.Close();
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
            else if (UserComboBox.SelectedIndex == -1)
            {
                MessageBox.Show("You forgot to select the role!", "Validation error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                UserNameBox.Focus();
                return false;
            }

            return true;
        }
        private void ResetForm()
        {
            UserNameBox.Clear();
            UserPassBox.Clear();
            UserComboBox.SelectedIndex = -1;
            ActiveCheckBox.Checked = true;
            DescUserBox.Clear();
            UserNameBox.Focus();

            if (IsUpdated)
            {
                this.IsUpdated = false;
                SaveButton.Text = "Save";
                DeleteButton.Enabled = false;
                this.UserName = null;
            }
        }
    }
}
