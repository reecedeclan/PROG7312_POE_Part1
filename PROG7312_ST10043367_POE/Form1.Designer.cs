using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace PROG7312_ST10043367_POE
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private Button btnAction1;
        private Button btnAction2;
        private Button btnAction3;
        private Label lblHeading;
        private Button btnViewLoggedIssues;
        private Button btnCommunityForums;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        // Initializing components on form
        private void InitializeComponent()
        {
            this.btnAction1 = new System.Windows.Forms.Button();
            this.btnAction2 = new System.Windows.Forms.Button();
            this.btnAction3 = new System.Windows.Forms.Button();
            this.lblHeading = new System.Windows.Forms.Label();
            this.btnViewLoggedIssues = new System.Windows.Forms.Button();
            this.btnCommunityForums = new System.Windows.Forms.Button();
            this.SuspendLayout();
            
            // 
            // btnAction1
            // 
            this.btnAction1.BackColor = System.Drawing.Color.LightCoral;
            this.btnAction1.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.btnAction1.Location = new System.Drawing.Point(170, 365);
            this.btnAction1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnAction1.Name = "btnAction1";
            this.btnAction1.Size = new System.Drawing.Size(560, 131);
            this.btnAction1.TabIndex = 2;
            this.btnAction1.Text = "Report an Issue";
            this.btnAction1.UseVisualStyleBackColor = false;
            this.btnAction1.Click += new System.EventHandler(this.btnAction1_Click);
            // 
            // btnAction2
            // 
            this.btnAction2.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnAction2.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.btnAction2.Location = new System.Drawing.Point(170, 647);
            this.btnAction2.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnAction2.Name = "btnAction2";
            this.btnAction2.Size = new System.Drawing.Size(560, 131);
            this.btnAction2.TabIndex = 1;
            this.btnAction2.Text = "Local Events and Announcements";
            this.btnAction2.UseVisualStyleBackColor = false;
            this.btnAction2.Click += new System.EventHandler(this.btnAction2_Click);
            // 
            // btnAction3
            // 
            this.btnAction3.BackColor = System.Drawing.Color.LightGreen;
            this.btnAction3.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.btnAction3.Location = new System.Drawing.Point(170, 788);
            this.btnAction3.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnAction3.Name = "btnAction3";
            this.btnAction3.Size = new System.Drawing.Size(560, 131);
            this.btnAction3.TabIndex = 0;
            this.btnAction3.Text = "Service Request Status";
            this.btnAction3.UseVisualStyleBackColor = false;
            this.btnAction3.Click += new System.EventHandler(this.btnAction3_Click);
            // 
            // lblHeading
            // 
            this.lblHeading.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold);
            this.lblHeading.Location = new System.Drawing.Point(224, 80);
            this.lblHeading.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblHeading.Name = "lblHeading";
            this.lblHeading.Size = new System.Drawing.Size(467, 186);
            this.lblHeading.TabIndex = 0;
            this.lblHeading.Text = "Welcome to eCitizen";
            this.lblHeading.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnViewLoggedIssues
            // 
            this.btnViewLoggedIssues.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.btnViewLoggedIssues.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.btnViewLoggedIssues.Location = new System.Drawing.Point(170, 507);
            this.btnViewLoggedIssues.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnViewLoggedIssues.Name = "btnViewLoggedIssues";
            this.btnViewLoggedIssues.Size = new System.Drawing.Size(560, 131);
            this.btnViewLoggedIssues.TabIndex = 3;
            this.btnViewLoggedIssues.Text = "View Logged Issues";
            this.btnViewLoggedIssues.UseVisualStyleBackColor = false;
            this.btnViewLoggedIssues.Click += new System.EventHandler(this.btnViewLoggedIssues_Click);
            // 
            // btnCommunityForums
            // 
            this.btnCommunityForums.BackColor = System.Drawing.Color.LightSalmon;
            this.btnCommunityForums.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.btnCommunityForums.Location = new System.Drawing.Point(170, 928);
            this.btnCommunityForums.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnCommunityForums.Name = "btnCommunityForums";
            this.btnCommunityForums.Size = new System.Drawing.Size(560, 131);
            this.btnCommunityForums.TabIndex = 4;
            this.btnCommunityForums.Text = "Community Forums";
            this.btnCommunityForums.UseVisualStyleBackColor = false;
            this.btnCommunityForums.Click += new System.EventHandler(this.btnCommunityForums_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(943, 1214);
            this.Controls.Add(this.btnCommunityForums);
            this.Controls.Add(this.btnViewLoggedIssues);
            this.Controls.Add(this.lblHeading);
            this.Controls.Add(this.btnAction3);
            this.Controls.Add(this.btnAction2);
            this.Controls.Add(this.btnAction1);
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "Form1";
            this.Text = "eCitizen";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }
    }
}