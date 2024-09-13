using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace PROG7312_ST10043367_POE
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Centering label and buttons 
            Size labelSize = this.lblHeading.Size;
            this.lblHeading.Location = new Point((this.ClientSize.Width - labelSize.Width) / 2, 50);

            Size buttonSize = this.btnAction1.Size;
            this.btnAction1.Location = new Point((this.ClientSize.Width - buttonSize.Width) / 2, 145);
            this.btnAction2.Location = new Point((this.ClientSize.Width - buttonSize.Width) / 2, 245);
            this.btnAction3.Location = new Point((this.ClientSize.Width - buttonSize.Width) / 2, 345);
            this.btnViewLoggedIssues.Location = new Point((this.ClientSize.Width - buttonSize.Width) / 2, 445);
            this.btnCommunityForums.Location = new Point((this.ClientSize.Width - buttonSize.Width) / 2, 545);

            //Resize the form size
            int formPadding = 50; // Add some padding to the bottom of the form
            int requiredHeight = this.btnCommunityForums.Bottom + formPadding;
            this.ClientSize = new Size(this.ClientSize.Width, requiredHeight);
        }

        //Report an issue button
        private void btnAction1_Click(object sender, EventArgs e)
        {
            Report_Issues reportIssuesForm = new Report_Issues();
            reportIssuesForm.Show();
        }

        // Local events and announcements - disabled
        private void btnAction2_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "Local Events and Announcements is currently disabled & will be implemented at a later date.",
                "eCitizen: Error!",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error
            );
        }

        // Service Request status - disabled
        private void btnAction3_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "Service Request Status is currently disabled & will be implemented at a later stage.",
                "eCitizen: Error!",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error
            );
        }

        // Open Community Forums - user engagement stratergy
        private void btnCommunityForums_Click(object sender, EventArgs e)
        {
            CommunityForums communityForumsForm = new CommunityForums();
            communityForumsForm.Show();
        }

        public static class GlobalData
        {
            public static List<Issue> ReportedIssues = new List<Issue>();
        }

        // View logged issues - temp
        private void btnViewLoggedIssues_Click(object sender, EventArgs e)
        {
            ViewIssues viewIssuesForm = new ViewIssues(GlobalData.ReportedIssues);
            viewIssuesForm.Show();
        }
    }
}