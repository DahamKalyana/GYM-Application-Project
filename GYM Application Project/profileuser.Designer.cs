
namespace GYM_Application_Project
{
    partial class profileuser
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pbprofile = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblname = new System.Windows.Forms.Label();
            this.lblemail = new System.Windows.Forms.Label();
            this.lblage = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbprofile)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pbprofile
            // 
            this.pbprofile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pbprofile.Location = new System.Drawing.Point(9, 10);
            this.pbprofile.Name = "pbprofile";
            this.pbprofile.Size = new System.Drawing.Size(130, 130);
            this.pbprofile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbprofile.TabIndex = 0;
            this.pbprofile.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.lblage);
            this.panel1.Controls.Add(this.lblemail);
            this.panel1.Controls.Add(this.lblname);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(610, 150);
            this.panel1.TabIndex = 1;
            // 
            // lblname
            // 
            this.lblname.AutoSize = true;
            this.lblname.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblname.Location = new System.Drawing.Point(166, 21);
            this.lblname.Name = "lblname";
            this.lblname.Size = new System.Drawing.Size(72, 25);
            this.lblname.TabIndex = 0;
            this.lblname.Text = "Name";
            // 
            // lblemail
            // 
            this.lblemail.AutoSize = true;
            this.lblemail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblemail.Location = new System.Drawing.Point(167, 55);
            this.lblemail.Name = "lblemail";
            this.lblemail.Size = new System.Drawing.Size(48, 20);
            this.lblemail.TabIndex = 1;
            this.lblemail.Text = "Email";
            // 
            // lblage
            // 
            this.lblage.AutoSize = true;
            this.lblage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblage.Location = new System.Drawing.Point(167, 85);
            this.lblage.Name = "lblage";
            this.lblage.Size = new System.Drawing.Size(38, 20);
            this.lblage.TabIndex = 2;
            this.lblage.Text = "Age";
            // 
            // profileuser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pbprofile);
            this.Controls.Add(this.panel1);
            this.Name = "profileuser";
            this.Size = new System.Drawing.Size(610, 150);
            ((System.ComponentModel.ISupportInitialize)(this.pbprofile)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbprofile;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblname;
        private System.Windows.Forms.Label lblage;
        private System.Windows.Forms.Label lblemail;
    }
}
