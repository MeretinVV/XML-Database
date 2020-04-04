namespace Person_Search.Forms
{
    partial class FilterWindow
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
            this.lastNameFilterField = new System.Windows.Forms.TextBox();
            this.hireDateFilterField = new System.Windows.Forms.DateTimePicker();
            this.departmentIDFilterField = new System.Windows.Forms.ComboBox();
            this.applyFilterBtn = new System.Windows.Forms.Button();
            this.cancelFilterChangesBtn = new System.Windows.Forms.Button();
            this.departmentIDFilter = new System.Windows.Forms.CheckBox();
            this.lastNameFilter = new System.Windows.Forms.CheckBox();
            this.sexFilter = new System.Windows.Forms.CheckBox();
            this.hireDateFilter = new System.Windows.Forms.CheckBox();
            this.sexFilterField = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lastNameFilterField
            // 
            this.lastNameFilterField.Enabled = false;
            this.lastNameFilterField.Location = new System.Drawing.Point(142, 51);
            this.lastNameFilterField.Name = "lastNameFilterField";
            this.lastNameFilterField.Size = new System.Drawing.Size(150, 20);
            this.lastNameFilterField.TabIndex = 0;
            // 
            // hireDateFilterField
            // 
            this.hireDateFilterField.Enabled = false;
            this.hireDateFilterField.Location = new System.Drawing.Point(142, 127);
            this.hireDateFilterField.Name = "hireDateFilterField";
            this.hireDateFilterField.Size = new System.Drawing.Size(150, 20);
            this.hireDateFilterField.TabIndex = 5;
            // 
            // departmentIDFilterField
            // 
            this.departmentIDFilterField.Enabled = false;
            this.departmentIDFilterField.FormattingEnabled = true;
            this.departmentIDFilterField.Location = new System.Drawing.Point(142, 16);
            this.departmentIDFilterField.Name = "departmentIDFilterField";
            this.departmentIDFilterField.Size = new System.Drawing.Size(150, 21);
            this.departmentIDFilterField.TabIndex = 6;
            // 
            // applyFilterBtn
            // 
            this.applyFilterBtn.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.applyFilterBtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.applyFilterBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.applyFilterBtn.Location = new System.Drawing.Point(13, 164);
            this.applyFilterBtn.Name = "applyFilterBtn";
            this.applyFilterBtn.Size = new System.Drawing.Size(123, 30);
            this.applyFilterBtn.TabIndex = 7;
            this.applyFilterBtn.Text = "Apply";
            this.applyFilterBtn.UseVisualStyleBackColor = false;
            this.applyFilterBtn.Click += new System.EventHandler(this.ApplyFilterBtn_Click);
            // 
            // cancelFilterChangesBtn
            // 
            this.cancelFilterChangesBtn.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.cancelFilterChangesBtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.cancelFilterChangesBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cancelFilterChangesBtn.Location = new System.Drawing.Point(169, 164);
            this.cancelFilterChangesBtn.Name = "cancelFilterChangesBtn";
            this.cancelFilterChangesBtn.Size = new System.Drawing.Size(123, 30);
            this.cancelFilterChangesBtn.TabIndex = 8;
            this.cancelFilterChangesBtn.Text = "Cancel";
            this.cancelFilterChangesBtn.UseVisualStyleBackColor = false;
            this.cancelFilterChangesBtn.Click += new System.EventHandler(this.CancelFilterChangesBtn_Click);
            // 
            // departmentIDFilter
            // 
            this.departmentIDFilter.AutoSize = true;
            this.departmentIDFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.departmentIDFilter.Location = new System.Drawing.Point(18, 16);
            this.departmentIDFilter.Name = "departmentIDFilter";
            this.departmentIDFilter.Size = new System.Drawing.Size(118, 21);
            this.departmentIDFilter.TabIndex = 11;
            this.departmentIDFilter.Text = "Department ID";
            this.departmentIDFilter.UseVisualStyleBackColor = true;
            this.departmentIDFilter.CheckedChanged += new System.EventHandler(this.FilterOption_CheckedChanged);
            // 
            // lastNameFilter
            // 
            this.lastNameFilter.AutoSize = true;
            this.lastNameFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lastNameFilter.Location = new System.Drawing.Point(18, 51);
            this.lastNameFilter.Name = "lastNameFilter";
            this.lastNameFilter.Size = new System.Drawing.Size(95, 21);
            this.lastNameFilter.TabIndex = 12;
            this.lastNameFilter.Text = "Last Name";
            this.lastNameFilter.UseVisualStyleBackColor = true;
            this.lastNameFilter.CheckedChanged += new System.EventHandler(this.FilterOption_CheckedChanged);
            // 
            // sexFilter
            // 
            this.sexFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sexFilter.Location = new System.Drawing.Point(18, 90);
            this.sexFilter.Name = "sexFilter";
            this.sexFilter.Size = new System.Drawing.Size(95, 21);
            this.sexFilter.TabIndex = 13;
            this.sexFilter.Text = "Sex";
            this.sexFilter.UseVisualStyleBackColor = true;
            this.sexFilter.CheckedChanged += new System.EventHandler(this.FilterOption_CheckedChanged);
            // 
            // hireDateFilter
            // 
            this.hireDateFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.hireDateFilter.Location = new System.Drawing.Point(18, 126);
            this.hireDateFilter.Name = "hireDateFilter";
            this.hireDateFilter.Size = new System.Drawing.Size(95, 21);
            this.hireDateFilter.TabIndex = 14;
            this.hireDateFilter.Text = "Hire Date";
            this.hireDateFilter.UseVisualStyleBackColor = true;
            this.hireDateFilter.CheckedChanged += new System.EventHandler(this.FilterOption_CheckedChanged);
            // 
            // sexFilterField
            // 
            this.sexFilterField.Enabled = false;
            this.sexFilterField.FormattingEnabled = true;
            this.sexFilterField.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.sexFilterField.Location = new System.Drawing.Point(142, 90);
            this.sexFilterField.Name = "sexFilterField";
            this.sexFilterField.Size = new System.Drawing.Size(150, 21);
            this.sexFilterField.TabIndex = 15;
            // 
            // FilterWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(304, 211);
            this.Controls.Add(this.sexFilterField);
            this.Controls.Add(this.hireDateFilter);
            this.Controls.Add(this.sexFilter);
            this.Controls.Add(this.lastNameFilter);
            this.Controls.Add(this.departmentIDFilter);
            this.Controls.Add(this.cancelFilterChangesBtn);
            this.Controls.Add(this.applyFilterBtn);
            this.Controls.Add(this.departmentIDFilterField);
            this.Controls.Add(this.hireDateFilterField);
            this.Controls.Add(this.lastNameFilterField);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FilterWindow";
            this.Text = "Filter Properties";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox lastNameFilterField;
        private System.Windows.Forms.DateTimePicker hireDateFilterField;
        private System.Windows.Forms.ComboBox departmentIDFilterField;
        private System.Windows.Forms.Button applyFilterBtn;
        private System.Windows.Forms.Button cancelFilterChangesBtn;
        private System.Windows.Forms.CheckBox departmentIDFilter;
        private System.Windows.Forms.CheckBox lastNameFilter;
        private System.Windows.Forms.CheckBox sexFilter;
        private System.Windows.Forms.CheckBox hireDateFilter;
        private System.Windows.Forms.ComboBox sexFilterField;
    }
}