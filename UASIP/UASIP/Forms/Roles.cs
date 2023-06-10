using System;
using System.Windows.Forms;
using UASIP.General;
using UASIP.Servises;

namespace UASIP.Forms
{
    public partial class Roles : Template
    {
        public Roles()
        {
            InitializeComponent();
        }

        public int RoleID { get; set; }
        public bool IsUpdated { get; set; }

        private readonly RoleService roleService = new RoleService();
        private void label1_Click(object sender, EventArgs e) { }

        private void label2_Click(object sender, EventArgs e) { }

        // Close                Done
        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Save                 Done
        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (IsFormValid())
            {
                int roleID = this.RoleID;
                string roleName = RoleNameBox.Text.Trim();
                string description = RoleDescBox.Text.Trim();
                string messageBox = roleService.SaveRole(this.RoleID, this.IsUpdated, roleID, roleName, description);

                if (messageBox == "Such role is already exist!")
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

        private void Roles_Load(object sender, EventArgs e)
        {
            if (this.IsUpdated)
            {
                RoleObject roleObject = roleService.LoadRole(RoleID);
                RoleNameBox.Text = roleObject.RoleName;
                RoleDescBox.Text = roleObject.Description;
                SaveButton.Text = "Update";
                DeleteButton.Enabled = true;
            }
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (this.IsUpdated)
            {
                DialogResult delRes = MessageBox.Show("Are you really want to delete?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (delRes == DialogResult.Yes)
                {
                    string messageBox = roleService.DeleteRole(this.RoleID);

                    MessageBox.Show(messageBox, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
            }
        }

        private void ResetForm()
        {
            RoleNameBox.Clear();
            RoleDescBox.Clear();

            RoleNameBox.Focus();

            if (this.IsUpdated)
            {
                this.RoleID = 0;
                this.IsUpdated = false;
                SaveButton.Text = "Save";
                DeleteButton.Enabled = true;
            }
        }

        private bool IsFormValid()
        {
            if (RoleNameBox.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Role name is required!", "Validation error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                RoleNameBox.Focus();
                return false;
            }

            return true;
        }

        private void RoleNameBox_TextChanged(object sender, EventArgs e) { }

        private void RoleDescBox_TextChanged(object sender, EventArgs e) { }
    }
}