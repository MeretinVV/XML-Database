namespace Person_Search
{
    partial class MainWindow
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
            this.tableView = new System.Windows.Forms.TextBox();
            this.filterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.setFilterBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.clearBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.insertBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.saveBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cancelChangesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableView
            // 
            this.tableView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableView.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.tableView.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tableView.Location = new System.Drawing.Point(10, 29);
            this.tableView.Margin = new System.Windows.Forms.Padding(2);
            this.tableView.Multiline = true;
            this.tableView.Name = "tableView";
            this.tableView.ReadOnly = true;
            this.tableView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tableView.Size = new System.Drawing.Size(624, 372);
            this.tableView.TabIndex = 2;
            this.tableView.TabStop = false;
            // 
            // filterToolStripMenuItem
            // 
            this.filterToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.setFilterBtn,
            this.clearBtn});
            this.filterToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.filterToolStripMenuItem.Name = "filterToolStripMenuItem";
            this.filterToolStripMenuItem.Size = new System.Drawing.Size(51, 23);
            this.filterToolStripMenuItem.Text = "Filter";
            // 
            // setFilterBtn
            // 
            this.setFilterBtn.Name = "setFilterBtn";
            this.setFilterBtn.Size = new System.Drawing.Size(180, 24);
            this.setFilterBtn.Text = "Set filter";
            this.setFilterBtn.Click += new System.EventHandler(this.SetFilterBtn_Click);
            // 
            // clearBtn
            // 
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(180, 24);
            this.clearBtn.Text = "Clear";
            this.clearBtn.Click += new System.EventHandler(this.ClearBtn_Click);
            // 
            // insertBtn
            // 
            this.insertBtn.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.insertBtn.Name = "insertBtn";
            this.insertBtn.Size = new System.Drawing.Size(56, 23);
            this.insertBtn.Text = "Insert";
            this.insertBtn.Click += new System.EventHandler(this.InsertBtn_Click);
            // 
            // deleteBtn
            // 
            this.deleteBtn.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(60, 23);
            this.deleteBtn.Text = "Delete";
            this.deleteBtn.Click += new System.EventHandler(this.DeleteBtn_Click);
            // 
            // saveBtn
            // 
            this.saveBtn.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(49, 23);
            this.saveBtn.Text = "Save";
            this.saveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.filterToolStripMenuItem,
            this.insertBtn,
            this.deleteBtn,
            this.saveBtn,
            this.cancelChangesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(644, 27);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // cancelChangesToolStripMenuItem
            // 
            this.cancelChangesToolStripMenuItem.Name = "cancelChangesToolStripMenuItem";
            this.cancelChangesToolStripMenuItem.Size = new System.Drawing.Size(104, 23);
            this.cancelChangesToolStripMenuItem.Text = "Cancel Changes";
            this.cancelChangesToolStripMenuItem.Click += new System.EventHandler(this.CancelChangesBtn_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(644, 412);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.tableView);
            this.Name = "MainWindow";
            this.Text = "Person Search";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tableView;
        private System.Windows.Forms.ToolStripMenuItem filterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem setFilterBtn;
        private System.Windows.Forms.ToolStripMenuItem clearBtn;
        private System.Windows.Forms.ToolStripMenuItem insertBtn;
        private System.Windows.Forms.ToolStripMenuItem deleteBtn;
        private System.Windows.Forms.ToolStripMenuItem saveBtn;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cancelChangesToolStripMenuItem;
    }
}

