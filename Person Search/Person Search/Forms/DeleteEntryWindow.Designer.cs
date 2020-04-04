namespace Person_Search.Forms
{
    partial class DeleteEntryWindow
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
            System.Windows.Forms.Label entryToRemoveDetails;
            System.Windows.Forms.Label emloyeeIDToRemove;
            this.employeeIDToDeelete = new System.Windows.Forms.TextBox();
            this.cancelDelete = new System.Windows.Forms.Button();
            this.deleteEntry = new System.Windows.Forms.Button();
            entryToRemoveDetails = new System.Windows.Forms.Label();
            emloyeeIDToRemove = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // entryToRemoveDetails
            // 
            entryToRemoveDetails.AutoSize = true;
            entryToRemoveDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            entryToRemoveDetails.Location = new System.Drawing.Point(68, 15);
            entryToRemoveDetails.Name = "entryToRemoveDetails";
            entryToRemoveDetails.Size = new System.Drawing.Size(113, 24);
            entryToRemoveDetails.TabIndex = 15;
            entryToRemoveDetails.Text = "Entry Details";
            // 
            // emloyeeIDToRemove
            // 
            emloyeeIDToRemove.AutoSize = true;
            emloyeeIDToRemove.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            emloyeeIDToRemove.Location = new System.Drawing.Point(12, 58);
            emloyeeIDToRemove.Name = "emloyeeIDToRemove";
            emloyeeIDToRemove.Size = new System.Drawing.Size(91, 17);
            emloyeeIDToRemove.TabIndex = 14;
            emloyeeIDToRemove.Text = "Employee ID:";
            // 
            // employeeIDToDeelete
            // 
            this.employeeIDToDeelete.Location = new System.Drawing.Point(115, 58);
            this.employeeIDToDeelete.Name = "employeeIDToDeelete";
            this.employeeIDToDeelete.Size = new System.Drawing.Size(122, 20);
            this.employeeIDToDeelete.TabIndex = 16;
            // 
            // cancelDelete
            // 
            this.cancelDelete.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.cancelDelete.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.cancelDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cancelDelete.Location = new System.Drawing.Point(135, 98);
            this.cancelDelete.Name = "cancelDelete";
            this.cancelDelete.Size = new System.Drawing.Size(100, 30);
            this.cancelDelete.TabIndex = 28;
            this.cancelDelete.Text = "Cancel";
            this.cancelDelete.UseVisualStyleBackColor = false;
            this.cancelDelete.Click += new System.EventHandler(this.CancelDelete_Click);
            // 
            // deleteEntry
            // 
            this.deleteEntry.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.deleteEntry.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.deleteEntry.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.deleteEntry.Location = new System.Drawing.Point(13, 98);
            this.deleteEntry.Name = "deleteEntry";
            this.deleteEntry.Size = new System.Drawing.Size(100, 30);
            this.deleteEntry.TabIndex = 27;
            this.deleteEntry.Text = "Delete";
            this.deleteEntry.UseVisualStyleBackColor = false;
            this.deleteEntry.Click += new System.EventHandler(this.DeleteEntry_Click);
            // 
            // DeleteEntryWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(249, 143);
            this.Controls.Add(this.cancelDelete);
            this.Controls.Add(this.deleteEntry);
            this.Controls.Add(this.employeeIDToDeelete);
            this.Controls.Add(entryToRemoveDetails);
            this.Controls.Add(emloyeeIDToRemove);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DeleteEntryWindow";
            this.Text = "Delete Entry";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox employeeIDToDeelete;
        private System.Windows.Forms.Button cancelDelete;
        private System.Windows.Forms.Button deleteEntry;
    }
}