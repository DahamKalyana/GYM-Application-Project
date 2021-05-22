
namespace GYM_Application_Project
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.HomePanel = new System.Windows.Forms.Panel();
            this.LogoutButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.PaymentButton = new System.Windows.Forms.Button();
            this.TrainersButton = new System.Windows.Forms.Button();
            this.ProfileButton = new System.Windows.Forms.Button();
            this.NewmemberButton = new System.Windows.Forms.Button();
            this.HomeButton = new System.Windows.Forms.Button();
            this.DashboardLabel = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.HomePanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // HomePanel
            // 
            this.HomePanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("HomePanel.BackgroundImage")));
            this.HomePanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.HomePanel.Controls.Add(this.LogoutButton);
            this.HomePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.HomePanel.Location = new System.Drawing.Point(326, 0);
            this.HomePanel.Name = "HomePanel";
            this.HomePanel.Size = new System.Drawing.Size(856, 703);
            this.HomePanel.TabIndex = 1;
            // 
            // LogoutButton
            // 
            this.LogoutButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LogoutButton.BackColor = System.Drawing.Color.Transparent;
            this.LogoutButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.LogoutButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LogoutButton.FlatAppearance.BorderSize = 0;
            this.LogoutButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LogoutButton.Font = new System.Drawing.Font("Helvetica Neue", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogoutButton.ForeColor = System.Drawing.Color.White;
            this.LogoutButton.Image = ((System.Drawing.Image)(resources.GetObject("LogoutButton.Image")));
            this.LogoutButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LogoutButton.Location = new System.Drawing.Point(681, 29);
            this.LogoutButton.Name = "LogoutButton";
            this.LogoutButton.Size = new System.Drawing.Size(172, 61);
            this.LogoutButton.TabIndex = 0;
            this.LogoutButton.Text = "Log Out  ";
            this.LogoutButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LogoutButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.LogoutButton.UseVisualStyleBackColor = false;
            this.LogoutButton.Click += new System.EventHandler(this.LogoutButton_Click);
            this.LogoutButton.MouseLeave += new System.EventHandler(this.LogoutButton_MouseLeave);
            this.LogoutButton.MouseHover += new System.EventHandler(this.LogoutButton_MouseHover);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(45)))), ((int)(((byte)(57)))));
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.PaymentButton);
            this.panel1.Controls.Add(this.TrainersButton);
            this.panel1.Controls.Add(this.ProfileButton);
            this.panel1.Controls.Add(this.NewmemberButton);
            this.panel1.Controls.Add(this.HomeButton);
            this.panel1.Controls.Add(this.DashboardLabel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(326, 703);
            this.panel1.TabIndex = 0;
            // 
            // PaymentButton
            // 
            this.PaymentButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PaymentButton.FlatAppearance.BorderSize = 0;
            this.PaymentButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PaymentButton.Font = new System.Drawing.Font("Helvetica Neue", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PaymentButton.ForeColor = System.Drawing.Color.White;
            this.PaymentButton.Image = ((System.Drawing.Image)(resources.GetObject("PaymentButton.Image")));
            this.PaymentButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.PaymentButton.Location = new System.Drawing.Point(-3, 459);
            this.PaymentButton.Name = "PaymentButton";
            this.PaymentButton.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.PaymentButton.Size = new System.Drawing.Size(326, 75);
            this.PaymentButton.TabIndex = 3;
            this.PaymentButton.Text = "   Payments";
            this.PaymentButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.PaymentButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.PaymentButton.UseVisualStyleBackColor = true;
            this.PaymentButton.Click += new System.EventHandler(this.PaymentButton_Click);
            // 
            // TrainersButton
            // 
            this.TrainersButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TrainersButton.FlatAppearance.BorderSize = 0;
            this.TrainersButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TrainersButton.Font = new System.Drawing.Font("Helvetica Neue", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TrainersButton.ForeColor = System.Drawing.Color.White;
            this.TrainersButton.Image = ((System.Drawing.Image)(resources.GetObject("TrainersButton.Image")));
            this.TrainersButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.TrainersButton.Location = new System.Drawing.Point(0, 378);
            this.TrainersButton.Name = "TrainersButton";
            this.TrainersButton.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.TrainersButton.Size = new System.Drawing.Size(326, 75);
            this.TrainersButton.TabIndex = 4;
            this.TrainersButton.Text = "   Trainer";
            this.TrainersButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.TrainersButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.TrainersButton.UseVisualStyleBackColor = true;
            this.TrainersButton.Click += new System.EventHandler(this.TrainersButton_Click);
            // 
            // ProfileButton
            // 
            this.ProfileButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ProfileButton.FlatAppearance.BorderSize = 0;
            this.ProfileButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ProfileButton.Font = new System.Drawing.Font("Helvetica Neue", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProfileButton.ForeColor = System.Drawing.Color.White;
            this.ProfileButton.Image = ((System.Drawing.Image)(resources.GetObject("ProfileButton.Image")));
            this.ProfileButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ProfileButton.Location = new System.Drawing.Point(0, 297);
            this.ProfileButton.Name = "ProfileButton";
            this.ProfileButton.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.ProfileButton.Size = new System.Drawing.Size(326, 75);
            this.ProfileButton.TabIndex = 5;
            this.ProfileButton.Text = "   Profile";
            this.ProfileButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ProfileButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ProfileButton.UseVisualStyleBackColor = true;
            this.ProfileButton.Click += new System.EventHandler(this.ProfileButton_Click);
            // 
            // NewmemberButton
            // 
            this.NewmemberButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.NewmemberButton.FlatAppearance.BorderSize = 0;
            this.NewmemberButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NewmemberButton.Font = new System.Drawing.Font("Helvetica Neue", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewmemberButton.ForeColor = System.Drawing.Color.White;
            this.NewmemberButton.Image = ((System.Drawing.Image)(resources.GetObject("NewmemberButton.Image")));
            this.NewmemberButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.NewmemberButton.Location = new System.Drawing.Point(0, 216);
            this.NewmemberButton.Name = "NewmemberButton";
            this.NewmemberButton.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.NewmemberButton.Size = new System.Drawing.Size(326, 75);
            this.NewmemberButton.TabIndex = 6;
            this.NewmemberButton.Text = "   New member";
            this.NewmemberButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.NewmemberButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.NewmemberButton.UseVisualStyleBackColor = true;
            this.NewmemberButton.Click += new System.EventHandler(this.NewmemberButton_Click);
            // 
            // HomeButton
            // 
            this.HomeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.HomeButton.FlatAppearance.BorderSize = 0;
            this.HomeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HomeButton.Font = new System.Drawing.Font("Helvetica Neue", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HomeButton.ForeColor = System.Drawing.Color.White;
            this.HomeButton.Image = ((System.Drawing.Image)(resources.GetObject("HomeButton.Image")));
            this.HomeButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.HomeButton.Location = new System.Drawing.Point(0, 135);
            this.HomeButton.Name = "HomeButton";
            this.HomeButton.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.HomeButton.Size = new System.Drawing.Size(326, 75);
            this.HomeButton.TabIndex = 7;
            this.HomeButton.Text = "   Home";
            this.HomeButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.HomeButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.HomeButton.UseVisualStyleBackColor = true;
            this.HomeButton.Click += new System.EventHandler(this.HomeButton_Click_1);
            // 
            // DashboardLabel
            // 
            this.DashboardLabel.AutoSize = true;
            this.DashboardLabel.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.DashboardLabel.Font = new System.Drawing.Font("Helvetica Neue", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DashboardLabel.ForeColor = System.Drawing.Color.White;
            this.DashboardLabel.Location = new System.Drawing.Point(12, 29);
            this.DashboardLabel.Name = "DashboardLabel";
            this.DashboardLabel.Size = new System.Drawing.Size(249, 51);
            this.DashboardLabel.TabIndex = 2;
            this.DashboardLabel.Text = "Dashboard";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.panel2.Location = new System.Drawing.Point(0, 135);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(13, 75);
            this.panel2.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 703);
            this.Controls.Add(this.HomePanel);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.HomePanel.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel HomePanel;
        private System.Windows.Forms.Button LogoutButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button PaymentButton;
        private System.Windows.Forms.Button TrainersButton;
        private System.Windows.Forms.Button ProfileButton;
        private System.Windows.Forms.Button NewmemberButton;
        private System.Windows.Forms.Button HomeButton;
        private System.Windows.Forms.Label DashboardLabel;
        private System.Windows.Forms.Panel panel2;
    }
}

