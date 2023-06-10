
namespace UASIP.Forms
{
    partial class UserView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.UserSearchingBox = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.newRoleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.refreshToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SearchButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.UserViewGrid = new System.Windows.Forms.DataGridView();
            this.PageNum = new System.Windows.Forms.Label();
            this.NxPageButton = new System.Windows.Forms.Button();
            this.PrRageButton = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UserViewGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // UserSearchingBox
            // 
            this.UserSearchingBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(78)))), ((int)(((byte)(91)))));
            this.UserSearchingBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.UserSearchingBox.ForeColor = System.Drawing.Color.PaleTurquoise;
            this.UserSearchingBox.Location = new System.Drawing.Point(161, 53);
            this.UserSearchingBox.MaxLength = 50;
            this.UserSearchingBox.Name = "UserSearchingBox";
            this.UserSearchingBox.Size = new System.Drawing.Size(380, 26);
            this.UserSearchingBox.TabIndex = 12;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(78)))), ((int)(((byte)(91)))));
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newRoleToolStripMenuItem,
            this.toolStripMenuItem1,
            this.closeToolStripMenuItem,
            this.toolStripMenuItem2,
            this.refreshToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(664, 31);
            this.menuStrip1.TabIndex = 10;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // newRoleToolStripMenuItem
            // 
            this.newRoleToolStripMenuItem.ForeColor = System.Drawing.Color.PaleTurquoise;
            this.newRoleToolStripMenuItem.Name = "newRoleToolStripMenuItem";
            this.newRoleToolStripMenuItem.Size = new System.Drawing.Size(97, 27);
            this.newRoleToolStripMenuItem.Text = "New User";
            this.newRoleToolStripMenuItem.Click += new System.EventHandler(this.newRoleToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.ForeColor = System.Drawing.Color.MediumTurquoise;
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(28, 27);
            this.toolStripMenuItem1.Text = "|";
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.ForeColor = System.Drawing.Color.PaleTurquoise;
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(65, 27);
            this.closeToolStripMenuItem.Text = "Close";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.ForeColor = System.Drawing.Color.MediumTurquoise;
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(28, 27);
            this.toolStripMenuItem2.Text = "|";
            // 
            // refreshToolStripMenuItem
            // 
            this.refreshToolStripMenuItem.ForeColor = System.Drawing.Color.PaleTurquoise;
            this.refreshToolStripMenuItem.Name = "refreshToolStripMenuItem";
            this.refreshToolStripMenuItem.Size = new System.Drawing.Size(80, 27);
            this.refreshToolStripMenuItem.Text = "Refresh";
            this.refreshToolStripMenuItem.Click += new System.EventHandler(this.refreshToolStripMenuItem_Click);
            // 
            // SearchButton
            // 
            this.SearchButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(78)))), ((int)(((byte)(91)))));
            this.SearchButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.SearchButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SearchButton.ForeColor = System.Drawing.Color.PaleTurquoise;
            this.SearchButton.Location = new System.Drawing.Point(556, 50);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(96, 32);
            this.SearchButton.TabIndex = 14;
            this.SearchButton.Text = "Search";
            this.SearchButton.UseVisualStyleBackColor = false;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.PaleTurquoise;
            this.label1.Location = new System.Drawing.Point(12, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 20);
            this.label1.TabIndex = 13;
            this.label1.Text = "User Searching";
            // 
            // UserViewGrid
            // 
            this.UserViewGrid.AllowUserToAddRows = false;
            this.UserViewGrid.AllowUserToDeleteRows = false;
            this.UserViewGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.UserViewGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(78)))), ((int)(((byte)(91)))));
            this.UserViewGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.UserViewGrid.GridColor = System.Drawing.Color.PaleTurquoise;
            this.UserViewGrid.Location = new System.Drawing.Point(12, 101);
            this.UserViewGrid.Name = "UserViewGrid";
            this.UserViewGrid.ReadOnly = true;
            this.UserViewGrid.RowHeadersWidth = 51;
            this.UserViewGrid.RowTemplate.Height = 24;
            this.UserViewGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.UserViewGrid.Size = new System.Drawing.Size(640, 324);
            this.UserViewGrid.TabIndex = 11;
            this.UserViewGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.UserViewGrid_CellContentClick);
            this.UserViewGrid.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.UserViewGrid_CellDoubleClick);
            // 
            // PageNum
            // 
            this.PageNum.AutoSize = true;
            this.PageNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PageNum.Location = new System.Drawing.Point(12, 437);
            this.PageNum.Name = "PageNum";
            this.PageNum.Size = new System.Drawing.Size(53, 20);
            this.PageNum.TabIndex = 15;
            this.PageNum.Text = "label2";
            this.PageNum.Click += new System.EventHandler(this.PageNum_Click);
            // 
            // NxPageButton
            // 
            this.NxPageButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(39)))), ((int)(((byte)(52)))));
            this.NxPageButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NxPageButton.Location = new System.Drawing.Point(626, 431);
            this.NxPageButton.Name = "NxPageButton";
            this.NxPageButton.Size = new System.Drawing.Size(26, 26);
            this.NxPageButton.TabIndex = 16;
            this.NxPageButton.Text = ">";
            this.NxPageButton.UseVisualStyleBackColor = false;
            this.NxPageButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // PrRageButton
            // 
            this.PrRageButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(39)))), ((int)(((byte)(52)))));
            this.PrRageButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PrRageButton.Location = new System.Drawing.Point(594, 431);
            this.PrRageButton.Name = "PrRageButton";
            this.PrRageButton.Size = new System.Drawing.Size(26, 26);
            this.PrRageButton.TabIndex = 17;
            this.PrRageButton.Text = "<";
            this.PrRageButton.UseVisualStyleBackColor = false;
            this.PrRageButton.Click += new System.EventHandler(this.PrRageButton_Click);
            // 
            // UserView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(664, 475);
            this.Controls.Add(this.PrRageButton);
            this.Controls.Add(this.NxPageButton);
            this.Controls.Add(this.PageNum);
            this.Controls.Add(this.UserSearchingBox);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.UserViewGrid);
            this.Name = "UserView";
            this.Text = "View Users";
            this.Load += new System.EventHandler(this.UserView_Load_1);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UserViewGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox UserSearchingBox;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem newRoleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem refreshToolStripMenuItem;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView UserViewGrid;
        private System.Windows.Forms.Label PageNum;
        private System.Windows.Forms.Button NxPageButton;
        private System.Windows.Forms.Button PrRageButton;
    }
}