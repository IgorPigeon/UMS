using System;
namespace UASIP.Forms
{
    public partial class Main : Template
    {
        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {

        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {

        }

        private void RoleButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            RoleView roles = new RoleView();
            roles.ShowDialog();
        }

        private void UsersButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            UserView users = new UserView();
            users.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            EntryView entries = new EntryView();
            entries.ShowDialog();
        }
    }
}
