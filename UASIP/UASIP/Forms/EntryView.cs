using System;
using System.Collections.Generic;
using System.Linq;
using UASIP.General;
using UASIP.Servises;

namespace UASIP.Forms
{
    public partial class EntryView : Template
    {
        int pageNum = 1;
        EntryService entryService = new EntryService();

        public EntryView()
        {
            InitializeComponent();
            ToDataGrid(pageNum);
        }

        public void ToDataGrid(int pageNum)
        {
            List<EntryObject> list = entryService.UpdateData().ToList();
            int take;
            if (pageNum > list.Count / 10)
            {
                take = list.Count % 10;
            }
            else
            {
                take = 10;
            }

            EntryViewGrid.DataSource = list.Skip(pageNum * 10 - 10).Take(take).ToList();
            Arrows(pageNum, list);
            PageNum.Text = "Page: " + pageNum.ToString();
            EntryViewGrid.Columns[0].Visible = false;
        }

        private void EntryView_Load(object sender, EventArgs e) { }

        private void refreshToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pageNum = 1;
            ToDataGrid(pageNum);
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Main main = new Main();
            main.ShowDialog();
        }

        private void PrRageButton_Click(object sender, EventArgs e)
        {
            pageNum -= 1;
            ToDataGrid(pageNum);
        }

        private void NxPageButton_Click(object sender, EventArgs e)
        {
            pageNum += 1;
            ToDataGrid(pageNum);
        }
        public void Arrows(int pageNum, List<EntryObject> list)
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
    }
}