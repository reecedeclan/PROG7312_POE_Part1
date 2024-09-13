using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace PROG7312_ST10043367_POE
{
    public partial class ViewIssues : Form
    {
        private List<Issue> issues;

        public ViewIssues(List<Issue> issues)
        {
            InitializeComponent();
            this.issues = issues;
            DisplayIssues();
        }

        private void DisplayIssues()
        {
            //DataGrid View to view issue details
            dataGridViewIssues.Columns.Add("Location", "Location");
            dataGridViewIssues.Columns.Add("Category", "Category");
            dataGridViewIssues.Columns.Add("Description", "Description");
            //dataGridViewIssues.Columns.Add("Attachments", "Attachments");

            // Populate the DataGridView with issues
            foreach (var issue in issues)
            {
                dataGridViewIssues.Rows.Add(issue.Location, issue.Category, issue.Description/*, issue.MediaFilePaths.Count*/);
            }
        }

        //Go back to form1
        private void btnBackToMainMenu_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}