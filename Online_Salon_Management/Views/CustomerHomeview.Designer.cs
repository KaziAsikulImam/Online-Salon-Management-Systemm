namespace Online_Salon_Management.Views
{
    partial class CustomerHomeview
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
            this.SeeAllCatalogButton = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.PersonalDetailsButton = new System.Windows.Forms.Button();
            this.SeeAllBillButton = new System.Windows.Forms.Button();
            this.LogOutButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // SeeAllCatalogButton
            // 
            this.SeeAllCatalogButton.Location = new System.Drawing.Point(115, 138);
            this.SeeAllCatalogButton.Name = "SeeAllCatalogButton";
            this.SeeAllCatalogButton.Size = new System.Drawing.Size(131, 44);
            this.SeeAllCatalogButton.TabIndex = 0;
            this.SeeAllCatalogButton.Text = "See All Catalog";
            this.SeeAllCatalogButton.UseVisualStyleBackColor = true;
            this.SeeAllCatalogButton.Click += new System.EventHandler(this.SeeAllCatalogButton_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(115, 203);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(131, 44);
            this.button3.TabIndex = 2;
            this.button3.Text = "Change Password";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.Button3_Click);
            // 
            // PersonalDetailsButton
            // 
            this.PersonalDetailsButton.Location = new System.Drawing.Point(580, 138);
            this.PersonalDetailsButton.Name = "PersonalDetailsButton";
            this.PersonalDetailsButton.Size = new System.Drawing.Size(131, 44);
            this.PersonalDetailsButton.TabIndex = 3;
            this.PersonalDetailsButton.Text = "Personal Details";
            this.PersonalDetailsButton.UseVisualStyleBackColor = true;
            this.PersonalDetailsButton.Click += new System.EventHandler(this.PersonalDetailsButton_Click);
            // 
            // SeeAllBillButton
            // 
            this.SeeAllBillButton.Location = new System.Drawing.Point(339, 138);
            this.SeeAllBillButton.Name = "SeeAllBillButton";
            this.SeeAllBillButton.Size = new System.Drawing.Size(131, 44);
            this.SeeAllBillButton.TabIndex = 4;
            this.SeeAllBillButton.Text = "See All Bill";
            this.SeeAllBillButton.UseVisualStyleBackColor = true;
            this.SeeAllBillButton.Click += new System.EventHandler(this.SeeAllBillButton_Click);
            // 
            // LogOutButton
            // 
            this.LogOutButton.Location = new System.Drawing.Point(115, 383);
            this.LogOutButton.Name = "LogOutButton";
            this.LogOutButton.Size = new System.Drawing.Size(131, 34);
            this.LogOutButton.TabIndex = 5;
            this.LogOutButton.Text = "Log out";
            this.LogOutButton.UseVisualStyleBackColor = true;
            this.LogOutButton.Click += new System.EventHandler(this.LogOutButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.Location = new System.Drawing.Point(636, 383);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(131, 34);
            this.ExitButton.TabIndex = 6;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // CustomerHomeview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.LogOutButton);
            this.Controls.Add(this.SeeAllBillButton);
            this.Controls.Add(this.PersonalDetailsButton);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.SeeAllCatalogButton);
            this.Name = "CustomerHomeview";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CustomerHomeview";
            this.Load += new System.EventHandler(this.CustomerHomeview_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button SeeAllCatalogButton;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button PersonalDetailsButton;
        private System.Windows.Forms.Button SeeAllBillButton;
        private System.Windows.Forms.Button LogOutButton;
        private System.Windows.Forms.Button ExitButton;
    }
}