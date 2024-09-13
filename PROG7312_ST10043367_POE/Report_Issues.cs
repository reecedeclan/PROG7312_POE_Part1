using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using static PROG7312_ST10043367_POE.Form1;

namespace PROG7312_ST10043367_POE
{
    public partial class Report_Issues : Form
    {
        private List<Issue> reportedIssues = new List<Issue>();
        private List<string> mediaFilePaths = new List<string>();

        public Report_Issues()
        {
            InitializeComponent();
            InitializeCustomComponents();
            InitializeEventHandlers();
        }

        private void InitializeCustomComponents()
        {
            this.btnAttachMedia.Click += new EventHandler(this.btnAttachMedia_Click);
            this.btnRemoveMedia.Click += new EventHandler(this.btnRemoveMedia_Click);
            this.btnSubmit.Click += new EventHandler(this.btnSubmit_Click);
            this.btnBackToMainMenu.Click += new EventHandler(this.btnBackToMainMenu_Click);
            this.txtLocation.TextChanged += new EventHandler(this.ValidateForm);
            this.rtxtDescription.TextChanged += new EventHandler(this.ValidateForm);
            this.cmbCategory.SelectedIndexChanged += new EventHandler(this.ValidateForm);
            this.lstMediaFiles.DoubleClick += new EventHandler(this.lstMediaFiles_DoubleClick);
        }

        // Initialize event handlers for progress bar to update
        private void InitializeEventHandlers()
        {
            this.txtLocation.TextChanged += new EventHandler(UpdateProgressBar);
            this.cmbCategory.SelectedIndexChanged += new EventHandler(UpdateProgressBar);
            this.rtxtDescription.TextChanged += new EventHandler(UpdateProgressBar);
            this.lstMediaFiles.SelectedIndexChanged += new EventHandler(UpdateProgressBar);
        }

        // Update progress bar based on how complete the form is
        private void UpdateProgressBar(object sender, EventArgs e)
        {
            int progress = 0;

            // Increment progress based on the completion of each field
            if (!string.IsNullOrWhiteSpace(txtLocation.Text))
                progress += 25;
            if (cmbCategory.SelectedIndex != -1)
                progress += 25;
            if (!string.IsNullOrWhiteSpace(rtxtDescription.Text))
                progress += 25;
            if (lstMediaFiles.Items.Count > 0)
                progress += 25;


            // Update the progress bar
            progressBar.Value = progress;
            progressBar.Visible = progress > 0;
        }

        //Handling media attached
        private void btnAttachMedia_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png|Document Files|*.pdf;*.docx;*.xlsx|All Files|*.*";
                openFileDialog.Title = "Select Media Files";
                openFileDialog.Multiselect = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    int currentCount = mediaFilePaths.Count;
                    int newCount = openFileDialog.FileNames.Length;

                    //Only allow user to attach 5 media files
                    if (currentCount + newCount > 5)
                    {
                        MessageBox.Show("You can only attach up to 5 media files. Please remove some files before adding more.", "eCitizen: Attachment Limit Exceeded", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    foreach (var filePath in openFileDialog.FileNames)
                    {
                        mediaFilePaths.Add(filePath);
                        lstMediaFiles.Items.Add(Path.GetFileName(filePath));
                    }

                    MessageBox.Show($"{mediaFilePaths.Count} media files attached.", "eCitizen: Success", MessageBoxButtons.OK);
                }
            }
        }

        private async void btnSubmit_Click(object sender, EventArgs e)
        {
            string location = txtLocation.Text;
            string category = cmbCategory.SelectedItem?.ToString();
            string description = rtxtDescription.Text;

            // Error handling if fields are left empty
            if (string.IsNullOrEmpty(location))
            {
                MessageBox.Show("Location is required.", "eCitizen: Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrEmpty(category))
            {
                MessageBox.Show("Category is required.", "eCitizen: Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrEmpty(description))
            {
                MessageBox.Show("Description is required.", "eCitizen: Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Confirmation dialog with the issue details
            var result = MessageBox.Show(
                "Please confirm the details of the issue before submitting:\n\n" +
                $"Location: {location}\n" +
                $"Category: {category}\n" +
                $"Description: {description}\n" +
                $"Attachments: {(mediaFilePaths.Count > 0 ? mediaFilePaths.Count.ToString() : "None")}\n\n" +
                "Do you want to proceed?",
                "eCitizen: Confirm Issue Submission",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (result == DialogResult.Yes)
            {
                // Create the new issue object only after confirmation
                Issue newIssue = new Issue
                {
                    Location = location,
                    Category = category,
                    Description = description,
                    MediaFilePaths = mediaFilePaths
                };

                GlobalData.ReportedIssues.Add(newIssue);

                // Show the progress bar
                this.progressBar.Visible = true;

             

                // Hide the progress bar
                this.progressBar.Visible = false;

                // Clear form after successful submission
                txtLocation.Clear();
                cmbCategory.SelectedIndex = -1;
                rtxtDescription.Clear();
                mediaFilePaths.Clear();
                lstMediaFiles.Items.Clear();
                btnSubmit.Enabled = false;
                this.Close();

                MessageBox.Show("Issue submitted successfully!", "eCitizen: Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                
                //MessageBox.Show("Edit issue to fix errors.", "eCitizen: Edit issue", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        //Back to Form1
        private void btnBackToMainMenu_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Disabled as error handling has been implimented instead
        private void ValidateForm(object sender, EventArgs e)
        {
            // Uncomment this line to enable form validation for submission
            //btnSubmit.Enabled = !string.IsNullOrEmpty(txtLocation.Text) &&
            //                    !string.IsNullOrEmpty(rtxtDescription.Text) &&
            //                    cmbCategory.SelectedIndex != -1;
        }

        //Allows user to view media files if clicked on
        private void lstMediaFiles_DoubleClick(object sender, EventArgs e)
        {
            if (lstMediaFiles.SelectedItem != null)
            {
                string selectedFileName = lstMediaFiles.SelectedItem.ToString();
                string filePath = mediaFilePaths.Find(path => Path.GetFileName(path) == selectedFileName);

                if (!string.IsNullOrEmpty(filePath))
                {
                    try
                    {
                        System.Diagnostics.Process.Start(filePath);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Could not open the media file: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        //Allows user to remove attached media files
        private void btnRemoveMedia_Click(object sender, EventArgs e)
        {
            var selectedItems = lstMediaFiles.SelectedItems.Cast<string>().ToList();

            if (selectedItems.Any())
            {
                foreach (string selectedFileName in selectedItems)
                {
                    string filePath = mediaFilePaths.Find(path => Path.GetFileName(path) == selectedFileName);

                    if (!string.IsNullOrEmpty(filePath))
                    {
                        mediaFilePaths.Remove(filePath);
                        lstMediaFiles.Items.Remove(selectedFileName);
                    }
                }

                MessageBox.Show("Selected media files have been removed successfully.", "eCitizen: Success");
                ValidateForm(null, null);
            }
            else
            {
                MessageBox.Show("Please select one or more media items to remove.", "eCitizen: Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void lstMediaFiles_SelectedIndexChanged(object sender, EventArgs e)
        {
            //
        }
    }

    //Storing issue details
    public class Issue
    {
        public string Location { get; set; }
        public string Category { get; set; }
        public string Description { get; set; }
        public List<string> MediaFilePaths { get; set; } = new List<string>();
    }
}