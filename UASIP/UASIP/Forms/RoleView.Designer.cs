
namespace UASIP.Forms
{
    partial class RoleView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RoleView));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.newRoleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.refreshToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.RoleViewGrid = new System.Windows.Forms.DataGridView();
            this.RoleSearchingBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SearchButton = new System.Windows.Forms.Button();
            this.PrRageButton = new System.Windows.Forms.Button();
            this.NxPageButton = new System.Windows.Forms.Button();
            this.PageNum = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RoleViewGrid)).BeginInit();
            this.SuspendLayout();
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
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // newRoleToolStripMenuItem
            // 
            this.newRoleToolStripMenuItem.ForeColor = System.Drawing.Color.PaleTurquoise;
            this.newRoleToolStripMenuItem.Name = "newRoleToolStripMenuItem";
            this.newRoleToolStripMenuItem.Size = new System.Drawing.Size(96, 27);
            this.newRoleToolStripMenuItem.Text = "New Role";
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
            // RoleViewGrid
            // 
            this.RoleViewGrid.AllowUserToAddRows = false;
            this.RoleViewGrid.AllowUserToDeleteRows = false;
            this.RoleViewGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.RoleViewGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(78)))), ((int)(((byte)(91)))));
            this.RoleViewGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.RoleViewGrid.GridColor = System.Drawing.Color.PaleTurquoise;
            this.RoleViewGrid.Location = new System.Drawing.Point(12, 101);
            this.RoleViewGrid.Name = "RoleViewGrid";
            this.RoleViewGrid.ReadOnly = true;
            this.RoleViewGrid.RowHeadersWidth = 51;
            this.RoleViewGrid.RowTemplate.Height = 24;
            this.RoleViewGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.RoleViewGrid.Size = new System.Drawing.Size(640, 324);
            this.RoleViewGrid.TabIndex = 1;
            this.RoleViewGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.RoleViewGrid_CellContentClick);
            this.RoleViewGrid.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.RoleViewGrid_CellDoubleClick);
            // 
            // RoleSearchingBox
            // 
            this.RoleSearchingBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(78)))), ((int)(((byte)(91)))));
            this.RoleSearchingBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RoleSearchingBox.ForeColor = System.Drawing.Color.PaleTurquoise;
            this.RoleSearchingBox.Location = new System.Drawing.Point(161, 53);
            this.RoleSearchingBox.MaxLength = 50;
            this.RoleSearchingBox.Name = "RoleSearchingBox";
            this.RoleSearchingBox.Size = new System.Drawing.Size(380, 26);
            this.RoleSearchingBox.TabIndex = 2;
            this.RoleSearchingBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.PaleTurquoise;
            this.label1.Location = new System.Drawing.Point(12, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Role Searching";
            this.label1.Click += new System.EventHandler(this.label1_Click);
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
            this.SearchButton.TabIndex = 4;
            this.SearchButton.Text = "Search";
            this.SearchButton.UseVisualStyleBackColor = false;
            this.SearchButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // PrRageButton
            // 
            this.PrRageButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(39)))), ((int)(((byte)(52)))));
            this.PrRageButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PrRageButton.ForeColor = System.Drawing.Color.PaleTurquoise;
            this.PrRageButton.Location = new System.Drawing.Point(594, 431);
            this.PrRageButton.Name = "PrRageButton";
            this.PrRageButton.Size = new System.Drawing.Size(26, 26);
            this.PrRageButton.TabIndex = 20;
            this.PrRageButton.Text = "<";
            this.PrRageButton.UseVisualStyleBackColor = false;
            this.PrRageButton.Click += new System.EventHandler(this.PrRageButton_Click);
            // 
            // NxPageButton
            // 
            this.NxPageButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(39)))), ((int)(((byte)(52)))));
            this.NxPageButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NxPageButton.ForeColor = System.Drawing.Color.PaleTurquoise;
            this.NxPageButton.Location = new System.Drawing.Point(626, 431);
            this.NxPageButton.Name = "NxPageButton";
            this.NxPageButton.Size = new System.Drawing.Size(26, 26);
            this.NxPageButton.TabIndex = 19;
            this.NxPageButton.Text = ">";
            this.NxPageButton.UseVisualStyleBackColor = false;
            this.NxPageButton.Click += new System.EventHandler(this.NxPageButton_Click);
            // 
            // PageNum
            // 
            this.PageNum.AutoSize = true;
            this.PageNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PageNum.Location = new System.Drawing.Point(-188, 393);
            this.PageNum.Name = "PageNum";
            this.PageNum.Size = new System.Drawing.Size(53, 20);
            this.PageNum.TabIndex = 18;
            this.PageNum.Text = "label2";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.PaleTurquoise;
            this.label2.Location = new System.Drawing.Point(12, 437);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 20);
            this.label2.TabIndex = 21;
            this.label2.Text = "label2";
            // 
            // RoleView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(664, 475);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.PrRageButton);
            this.Controls.Add(this.NxPageButton);
            this.Controls.Add(this.PageNum);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.RoleSearchingBox);
            this.Controls.Add(this.RoleViewGrid);
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "RoleView";
            this.Text = "View Roles";
            this.Load += new System.EventHandler(this.RoleView_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RoleViewGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem newRoleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.DataGridView RoleViewGrid;
        private System.Windows.Forms.TextBox RoleSearchingBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem refreshToolStripMenuItem;
        private System.Windows.Forms.Button PrRageButton;
        private System.Windows.Forms.Button NxPageButton;
        private System.Windows.Forms.Label PageNum;
        private System.Windows.Forms.Label label2;
    }
}