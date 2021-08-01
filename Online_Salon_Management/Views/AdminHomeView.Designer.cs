namespace Online_Salon_Management.Views
{
    partial class AdminHomeView
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
            this.ManageAdminButton = new System.Windows.Forms.Button();
            this.ManageCatalogButton = new System.Windows.Forms.Button();
            this.ManageEmployeeButton = new System.Windows.Forms.Button();
            this.CheckBillButton = new System.Windows.Forms.Button();
            this.PersonalDetailsButton = new System.Windows.Forms.Button();
            this.ChangePasswordButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.LogOutButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ManageAdminButton
            // 
            this.ManageAdminButton.Location = new System.Drawing.Point(82, 69);
            this.ManageAdminButton.Margin = new System.Windows.Forms.Padding(2);
            this.ManageAdminButton.Name = "ManageAdminButton";
            this.ManageAdminButton.Size = new System.Drawing.Size(116, 33);
            this.ManageAdminButton.TabIndex = 0;
            this.ManageAdminButton.Text = "Manage Admin";
            this.ManageAdminButton.UseVisualStyleBackColor = true;
            this.ManageAdminButton.Click += new System.EventHandler(this.ManageAdminButton_Click);
            // 
            // ManageCatalogButton
            // 
            this.ManageCatalogButton.Location = new System.Drawing.Point(82, 129);
            this.ManageCatalogButton.Margin = new System.Windows.Forms.Padding(2);
            this.ManageCatalogButton.Name = "ManageCatalogButton";
            this.ManageCatalogButton.Size = new System.Drawing.Size(116, 32);
            this.ManageCatalogButton.TabIndex = 1;
            this.ManageCatalogButton.Text = "Manage Catalog";
            this.ManageCatalogButton.UseVisualStyleBackColor = true;
            this.ManageCatalogButton.Click += new System.EventHandler(this.ManageCatalogButton_Click);
            // 
            // ManageEmployeeButton
            // 
            this.ManageEmployeeButton.Location = new System.Drawing.Point(329, 69);
            this.ManageEmployeeButton.Margin = new System.Windows.Forms.Padding(2);
            this.ManageEmployeeButton.Name = "ManageEmployeeButton";
            this.ManageEmployeeButton.Size = new System.Drawing.Size(122, 33);
            this.ManageEmployeeButton.TabIndex = 2;
            this.ManageEmployeeButton.Text = "ManageEmployee";
            this.ManageEmployeeButton.UseVisualStyleBackColor = true;
            this.ManageEmployeeButton.Click += new System.EventHandler(this.ManageEmployeeButton_Click);
            // 
            // CheckBillButton
            // 
            this.CheckBillButton.Location = new System.Drawing.Point(572, 69);
            this.CheckBillButton.Margin = new System.Windows.Forms.Padding(2);
            this.CheckBillButton.Name = "CheckBillButton";
            this.CheckBillButton.Size = new System.Drawing.Size(112, 33);
            this.CheckBillButton.TabIndex = 3;
            this.CheckBillButton.Text = "Check Bill";
            this.CheckBillButton.UseVisualStyleBackColor = true;
            this.CheckBillButton.Click += new System.EventHandler(this.CheckBillButton_Click);
            // 
            // PersonalDetailsButton
            // 
            this.PersonalDetailsButton.Location = new System.Drawing.Point(572, 129);
            this.PersonalDetailsButton.Margin = new System.Windows.Forms.Padding(2);
            this.PersonalDetailsButton.Name = "PersonalDetailsButton";
            this.PersonalDetailsButton.Size = new System.Drawing.Size(112, 32);
            this.PersonalDetailsButton.TabIndex = 5;
            this.PersonalDetailsButton.Text = "Personal Details";
            this.PersonalDetailsButton.UseVisualStyleBackColor = true;
            this.PersonalDetailsButton.Click += new System.EventHandler(this.PersonalDetailsButton_Click);
            // 
            // ChangePasswordButton
            // 
            this.ChangePasswordButton.Location = new System.Drawing.Point(329, 130);
            this.ChangePasswordButton.Margin = new System.Windows.Forms.Padding(2);
            this.ChangePasswordButton.Name = "ChangePasswordButton";
            this.ChangePasswordButton.Size = new System.Drawing.Size(122, 31);
            this.ChangePasswordButton.TabIndex = 6;
            this.ChangePasswordButton.Text = "Change Password";
            this.ChangePasswordButton.UseVisualStyleBackColor = true;
            this.ChangePasswordButton.Click += new System.EventHandler(this.ChangePasswordButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.Location = new System.Drawing.Point(82, 292);
            this.ExitButton.Margin = new System.Windows.Forms.Padding(2);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(56, 25);
            this.ExitButton.TabIndex = 8;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // LogOutButton
            // 
            this.LogOutButton.Location = new System.Drawing.Point(628, 292);
            this.LogOutButton.Margin = new System.Windows.Forms.Padding(2);
            this.LogOutButton.Name = "LogOutButton";
            this.LogOutButton.Size = new System.Drawing.Size(56, 25);
            this.LogOutButton.TabIndex = 9;
            this.LogOutButton.Text = "Log Out";
            this.LogOutButton.UseVisualStyleBackColor = true;
            this.LogOutButton.Click += new System.EventHandler(this.LogOutButton_Click);
            // 
            // AdminHomeView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(757, 462);
            this.Controls.Add(this.LogOutButton);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.ChangePasswordButton);
            this.Controls.Add(this.PersonalDetailsButton);
            this.Controls.Add(this.CheckBillButton);
            this.Controls.Add(this.ManageEmployeeButton);
            this.Controls.Add(this.ManageCatalogButton);
            this.Controls.Add(this.ManageAdminButton);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "AdminHomeView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminHomeView";
            this.Load += new System.EventHandler(this.AdminHomeView_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ManageAdminButton;
        private System.Windows.Forms.Button ManageCatalogButton;
        private System.Windows.Forms.Button ManageEmployeeButton;
        private System.Windows.Forms.Button CheckBillButton;
        private System.Windows.Forms.Button PersonalDetailsButton;
        private System.Windows.Forms.Button ChangePasswordButton;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Button LogOutButton;
    }
}