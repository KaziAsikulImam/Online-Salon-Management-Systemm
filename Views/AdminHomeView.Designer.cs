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
            this.SetupScheduleButton = new System.Windows.Forms.Button();
            this.PersonalDetailsButton = new System.Windows.Forms.Button();
            this.ChangePasswordButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.LogOutButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ManageAdminButton
            // 
            this.ManageAdminButton.Location = new System.Drawing.Point(109, 85);
            this.ManageAdminButton.Name = "ManageAdminButton";
            this.ManageAdminButton.Size = new System.Drawing.Size(155, 41);
            this.ManageAdminButton.TabIndex = 0;
            this.ManageAdminButton.Text = "Manage Admin";
            this.ManageAdminButton.UseVisualStyleBackColor = true;
            this.ManageAdminButton.Click += new System.EventHandler(this.ManageAdminButton_Click);
            // 
            // ManageCatalogButton
            // 
            this.ManageCatalogButton.Location = new System.Drawing.Point(109, 159);
            this.ManageCatalogButton.Name = "ManageCatalogButton";
            this.ManageCatalogButton.Size = new System.Drawing.Size(155, 40);
            this.ManageCatalogButton.TabIndex = 1;
            this.ManageCatalogButton.Text = "Manage Catalog";
            this.ManageCatalogButton.UseVisualStyleBackColor = true;
            this.ManageCatalogButton.Click += new System.EventHandler(this.ManageCatalogButton_Click);
            // 
            // ManageEmployeeButton
            // 
            this.ManageEmployeeButton.Location = new System.Drawing.Point(439, 85);
            this.ManageEmployeeButton.Name = "ManageEmployeeButton";
            this.ManageEmployeeButton.Size = new System.Drawing.Size(163, 41);
            this.ManageEmployeeButton.TabIndex = 2;
            this.ManageEmployeeButton.Text = "ManageEmployee";
            this.ManageEmployeeButton.UseVisualStyleBackColor = true;
            this.ManageEmployeeButton.Click += new System.EventHandler(this.ManageEmployeeButton_Click);
            // 
            // CheckBillButton
            // 
            this.CheckBillButton.Location = new System.Drawing.Point(763, 85);
            this.CheckBillButton.Name = "CheckBillButton";
            this.CheckBillButton.Size = new System.Drawing.Size(150, 41);
            this.CheckBillButton.TabIndex = 3;
            this.CheckBillButton.Text = "Check Bill";
            this.CheckBillButton.UseVisualStyleBackColor = true;
            this.CheckBillButton.Click += new System.EventHandler(this.CheckBillButton_Click);
            // 
            // SetupScheduleButton
            // 
            this.SetupScheduleButton.Location = new System.Drawing.Point(439, 159);
            this.SetupScheduleButton.Name = "SetupScheduleButton";
            this.SetupScheduleButton.Size = new System.Drawing.Size(163, 40);
            this.SetupScheduleButton.TabIndex = 4;
            this.SetupScheduleButton.Text = "Setup Work Schedule";
            this.SetupScheduleButton.UseVisualStyleBackColor = true;
            this.SetupScheduleButton.Click += new System.EventHandler(this.SetupScheduleButton_Click);
            // 
            // PersonalDetailsButton
            // 
            this.PersonalDetailsButton.Location = new System.Drawing.Point(763, 159);
            this.PersonalDetailsButton.Name = "PersonalDetailsButton";
            this.PersonalDetailsButton.Size = new System.Drawing.Size(150, 40);
            this.PersonalDetailsButton.TabIndex = 5;
            this.PersonalDetailsButton.Text = "Personal Details";
            this.PersonalDetailsButton.UseVisualStyleBackColor = true;
            this.PersonalDetailsButton.Click += new System.EventHandler(this.PersonalDetailsButton_Click);
            // 
            // ChangePasswordButton
            // 
            this.ChangePasswordButton.Location = new System.Drawing.Point(439, 236);
            this.ChangePasswordButton.Name = "ChangePasswordButton";
            this.ChangePasswordButton.Size = new System.Drawing.Size(163, 38);
            this.ChangePasswordButton.TabIndex = 6;
            this.ChangePasswordButton.Text = "Change Password";
            this.ChangePasswordButton.UseVisualStyleBackColor = true;
            this.ChangePasswordButton.Click += new System.EventHandler(this.ChangePasswordButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.Location = new System.Drawing.Point(109, 360);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(75, 31);
            this.ExitButton.TabIndex = 8;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // LogOutButton
            // 
            this.LogOutButton.Location = new System.Drawing.Point(838, 360);
            this.LogOutButton.Name = "LogOutButton";
            this.LogOutButton.Size = new System.Drawing.Size(75, 31);
            this.LogOutButton.TabIndex = 9;
            this.LogOutButton.Text = "Log Out";
            this.LogOutButton.UseVisualStyleBackColor = true;
            this.LogOutButton.Click += new System.EventHandler(this.LogOutButton_Click);
            // 
            // AdminHomeView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1009, 568);
            this.Controls.Add(this.LogOutButton);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.ChangePasswordButton);
            this.Controls.Add(this.PersonalDetailsButton);
            this.Controls.Add(this.SetupScheduleButton);
            this.Controls.Add(this.CheckBillButton);
            this.Controls.Add(this.ManageEmployeeButton);
            this.Controls.Add(this.ManageCatalogButton);
            this.Controls.Add(this.ManageAdminButton);
            this.MaximizeBox = false;
            this.Name = "AdminHomeView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminHomeView";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ManageAdminButton;
        private System.Windows.Forms.Button ManageCatalogButton;
        private System.Windows.Forms.Button ManageEmployeeButton;
        private System.Windows.Forms.Button CheckBillButton;
        private System.Windows.Forms.Button SetupScheduleButton;
        private System.Windows.Forms.Button PersonalDetailsButton;
        private System.Windows.Forms.Button ChangePasswordButton;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Button LogOutButton;
    }
}