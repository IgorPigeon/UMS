
namespace UASIP.Forms
{
    partial class EntryView
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.refreshToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.EntryViewGrid = new System.Windows.Forms.DataGridView();
            this.PrRageButton = new System.Windows.Forms.Button();
            this.NxPageButton = new System.Windows.Forms.Button();
            this.PageNum = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EntryViewGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(78)))), ((int)(((byte)(91)))));
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.closeToolStripMenuItem,
            this.toolStripMenuItem2,
            this.refreshToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(664, 31);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
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
            // EntryViewGrid
            // 
            this.EntryViewGrid.AllowUserToAddRows = false;
            this.EntryViewGrid.AllowUserToDeleteRows = false;
            this.EntryViewGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.EntryViewGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(78)))), ((int)(((byte)(91)))));
            this.EntryViewGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.EntryViewGrid.GridColor = System.Drawing.Color.PaleTurquoise;
            this.EntryViewGrid.Location = new System.Drawing.Point(12, 46);
            this.EntryViewGrid.Name = "EntryViewGrid";
            this.EntryViewGrid.ReadOnly = true;
            this.EntryViewGrid.RowHeadersWidth = 51;
            this.EntryViewGrid.RowTemplate.Height = 24;
            this.EntryViewGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.EntryViewGrid.Size = new System.Drawing.Size(640, 324);
            this.EntryViewGrid.TabIndex = 2;
            // 
            // PrRageButton
            // 
            this.PrRageButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(39)))), ((int)(((byte)(52)))));
            this.PrRageButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PrRageButton.Location = new System.Drawing.Point(594, 376);
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
            this.NxPageButton.Location = new System.Drawing.Point(626, 376);
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
            this.PageNum.Location = new System.Drawing.Point(12, 382);
            this.PageNum.Name = "PageNum";
            this.PageNum.Size = new System.Drawing.Size(53, 20);
            this.PageNum.TabIndex = 18;
            this.PageNum.Text = "label2";
            // 
            // EntryView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(664, 419);
            this.Controls.Add(this.PrRageButton);
            this.Controls.Add(this.NxPageButton);
            this.Controls.Add(this.PageNum);
            this.Controls.Add(this.EntryViewGrid);
            this.Controls.Add(this.menuStrip1);
            this.Name = "EntryView";
            this.Text = "Entries";
            this.Load += new System.EventHandler(this.EntryView_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EntryViewGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem refreshToolStripMenuItem;
        private System.Windows.Forms.DataGridView EntryViewGrid;
        private System.Windows.Forms.Button PrRageButton;
        private System.Windows.Forms.Button NxPageButton;
        private System.Windows.Forms.Label PageNum;
    }
}