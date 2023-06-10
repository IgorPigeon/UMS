using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UASIP.Servises;

namespace UASIP.Forms
{
    public partial class EntryView : Template
    {
        EntryService entryService = new EntryService();

        public EntryView()
        {
            InitializeComponent();
            EntryViewGrid.DataSource = entryService.UpdateData().ToList();
            EntryViewGrid.Columns[0].Visible = false;
        }

        private void EntryView_Load(object sender, EventArgs e)
        {

        }

        private void refreshToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EntryViewGrid.DataSource = entryService.UpdateData().ToList();
            EntryViewGrid.Columns[0].Visible = false;
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Main main = new Main();
            main.ShowDialog();
        }
    }
}
