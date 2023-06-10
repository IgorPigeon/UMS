using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using UASIP.General;
using UASIP.Servises;

namespace UASIP.Forms
{
    public partial class RoleView : Template
    {
        public RoleView()
        {
            InitializeComponent();
            RoleViewGrid.DataSource = roleService.UpdateData().ToList();
            RoleViewGrid.Columns[0].Visible = false;
        }

        private readonly RoleService roleService = new RoleService();

        private void RoleView_Load(object sender, EventArgs e) {  }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e) {  }

        // Close                Done
        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Main main = new Main();
            main.ShowDialog();
        }

        private void RoleViewGrid_CellContentClick(object sender, DataGridViewCellEventArgs e) {  }

        private void label1_Click(object sender, EventArgs e) {  }

        private void textBox1_TextChanged(object sender, EventArgs e) {  }

        // Search               Done
        private void button1_Click(object sender, EventArgs e)
        {
            if(IsFormValid())
            {
                IEnumerable<RoleObject> roleList = roleService.SearchRole(RoleSearchingBox.Text.Trim());
                if(roleList != null)
                {
                    RoleViewGrid.DataSource = roleList;
                }
                else
                {
                    MessageBox.Show("No such role!", "No Record", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        // Refresh              Done
        private void refreshToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RoleViewGrid.DataSource = roleService.UpdateData().ToList();
            RoleViewGrid.Columns[0].Visible = false;
            RoleSearchingBox.Clear();
            RoleSearchingBox.Focus();
        }

        // New role             Done
        private void newRoleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Roles rform = new Roles();
            rform.ShowDialog();
            RoleViewGrid.DataSource = roleService.UpdateData().ToList();
            RoleViewGrid.Columns[0].Visible = false;
        }

        // Selection            Done
        private void RoleViewGrid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if(RoleViewGrid.Rows.Count > 0)
            {
                int roleId = Convert.ToInt32(RoleViewGrid.SelectedRows[0].Cells[0].Value);

                Roles roles = new Roles();
                roles.RoleID = roleId;
                roles.IsUpdated = true;
                roles.ShowDialog();

                RoleViewGrid.DataSource = roleService.UpdateData().ToList();
                RoleViewGrid.Columns[0].Visible = false;
            }
        }

        private bool IsFormValid()
        {
            if (RoleSearchingBox.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Role name is required!", "Validation error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                RoleSearchingBox.Focus();
                return false;
            }

            return true;
        }
    }
}
