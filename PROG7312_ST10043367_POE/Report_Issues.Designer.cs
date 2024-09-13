using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace PROG7312_ST10043367_POE
{
    partial class Report_Issues
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox txtLocation;
        private System.Windows.Forms.ComboBox cmbCategory;
        private System.Windows.Forms.RichTextBox rtxtDescription;
        private System.Windows.Forms.Button btnAttachMedia;
        private System.Windows.Forms.Button btnRemoveMedia;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Button btnBackToMainMenu;
        private System.Windows.Forms.Label lblLocationHeading;
        private System.Windows.Forms.Label lblCategoryHeading;
        private System.Windows.Forms.Label lblDescriptionHeading;
        private System.Windows.Forms.ListBox lstMediaFiles;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ProgressBar progressBar;


        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.txtLocation = new System.Windows.Forms.TextBox();
            this.cmbCategory = new System.Windows.Forms.ComboBox();
            this.rtxtDescription = new System.Windows.Forms.RichTextBox();
            this.btnAttachMedia = new System.Windows.Forms.Button();
            this.btnRemoveMedia = new System.Windows.Forms.Button();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.lblStatus = new System.Windows.Forms.Label();
            this.btnBackToMainMenu = new System.Windows.Forms.Button();
            this.lblLocationHeading = new System.Windows.Forms.Label();
            this.lblCategoryHeading = new System.Windows.Forms.Label();
            this.lblDescriptionHeading = new System.Windows.Forms.Label();
            this.lstMediaFiles = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();

            // txtLocation
            this.txtLocation.ForeColor = System.Drawing.Color.Black;
            this.txtLocation.Location = new System.Drawing.Point(27, 92);
            this.txtLocation.Margin = new System.Windows.Forms.Padding(2);
            this.txtLocation.Name = "txtLocation";
            this.txtLocation.Size = new System.Drawing.Size(134, 20);
            this.txtLocation.TabIndex = 0;
          
            // cmbCategory
            this.cmbCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCategory.ForeColor = System.Drawing.Color.Black;
            this.cmbCategory.Items.AddRange(new object[] {
            "Electricity",
            "Environmental Concerns",
            "Parks and Recreation",
            "Public Safety",
            "Roads",
            "Sanitation",
            "Utilities",
            "Waste Management",
            "Water Supply",
            "Other"});
            this.cmbCategory.Location = new System.Drawing.Point(186, 91);
            this.cmbCategory.Margin = new System.Windows.Forms.Padding(2);
            this.cmbCategory.Name = "cmbCategory";
            this.cmbCategory.Size = new System.Drawing.Size(134, 21);
            this.cmbCategory.TabIndex = 1;
            
            // rtxtDescription
            this.rtxtDescription.ForeColor = System.Drawing.Color.Black;
            this.rtxtDescription.Location = new System.Drawing.Point(27, 144);
            this.rtxtDescription.Margin = new System.Windows.Forms.Padding(2);
            this.rtxtDescription.Name = "rtxtDescription";
            this.rtxtDescription.Size = new System.Drawing.Size(293, 64);
            this.rtxtDescription.TabIndex = 2;
            this.rtxtDescription.Text = "";
            
            // btnAttachMedia
            this.btnAttachMedia.Location = new System.Drawing.Point(217, 242);
            this.btnAttachMedia.Margin = new System.Windows.Forms.Padding(2);
            this.btnAttachMedia.Name = "btnAttachMedia";
            this.btnAttachMedia.Size = new System.Drawing.Size(103, 36);
            this.btnAttachMedia.TabIndex = 3;
            this.btnAttachMedia.Text = "Attach Media";
            this.btnAttachMedia.UseVisualStyleBackColor = true;
            
            // btnRemoveMedia
            this.btnRemoveMedia.Location = new System.Drawing.Point(217, 284);
            this.btnRemoveMedia.Margin = new System.Windows.Forms.Padding(2);
            this.btnRemoveMedia.Name = "btnRemoveMedia";
            this.btnRemoveMedia.Size = new System.Drawing.Size(103, 36);
            this.btnRemoveMedia.TabIndex = 4;
            this.btnRemoveMedia.Text = "Remove Media";
            this.btnRemoveMedia.UseVisualStyleBackColor = true;
            
            // btnSubmit
            this.btnSubmit.Location = new System.Drawing.Point(134, 356);
            this.btnSubmit.Margin = new System.Windows.Forms.Padding(2);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(186, 36);
            this.btnSubmit.TabIndex = 5;
            this.btnSubmit.Text = "Submit issue";
            this.btnSubmit.UseVisualStyleBackColor = true;
            
            // lblStatus
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.lblStatus.Location = new System.Drawing.Point(96, 30);
            this.lblStatus.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(155, 22);
            this.lblStatus.TabIndex = 6;
            this.lblStatus.Text = "Report an issue";
            
            // btnBackToMainMenu
            this.btnBackToMainMenu.Location = new System.Drawing.Point(27, 356);
            this.btnBackToMainMenu.Margin = new System.Windows.Forms.Padding(2);
            this.btnBackToMainMenu.Name = "btnBackToMainMenu";
            this.btnBackToMainMenu.Size = new System.Drawing.Size(103, 36);
            this.btnBackToMainMenu.TabIndex = 7;
            this.btnBackToMainMenu.Text = "Cancel";
            this.btnBackToMainMenu.UseVisualStyleBackColor = true;
            
            // lblLocationHeading
            this.lblLocationHeading.AutoSize = true;
            this.lblLocationHeading.Font = new System.Drawing.Font("Arial", 10F);
            this.lblLocationHeading.Location = new System.Drawing.Point(24, 73);
            this.lblLocationHeading.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLocationHeading.Name = "lblLocationHeading";
            this.lblLocationHeading.Size = new System.Drawing.Size(102, 16);
            this.lblLocationHeading.TabIndex = 8;
            this.lblLocationHeading.Text = "Issue Location:";
            
            // lblCategoryHeading
            this.lblCategoryHeading.AutoSize = true;
            this.lblCategoryHeading.Font = new System.Drawing.Font("Arial", 10F);
            this.lblCategoryHeading.Location = new System.Drawing.Point(183, 73);
            this.lblCategoryHeading.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCategoryHeading.Name = "lblCategoryHeading";
            this.lblCategoryHeading.Size = new System.Drawing.Size(69, 16);
            this.lblCategoryHeading.TabIndex = 9;
            this.lblCategoryHeading.Text = "Category:";
            
            // lblDescriptionHeading
            this.lblDescriptionHeading.AutoSize = true;
            this.lblDescriptionHeading.Font = new System.Drawing.Font("Arial", 10F);
            this.lblDescriptionHeading.Location = new System.Drawing.Point(24, 126);
            this.lblDescriptionHeading.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDescriptionHeading.Name = "lblDescriptionHeading";
            this.lblDescriptionHeading.Size = new System.Drawing.Size(166, 16);
            this.lblDescriptionHeading.TabIndex = 10;
            this.lblDescriptionHeading.Text = "Brief description of issue:";
            
            // lstMediaFiles
            this.lstMediaFiles.FormattingEnabled = true;
            this.lstMediaFiles.Location = new System.Drawing.Point(27, 242);
            this.lstMediaFiles.Name = "lstMediaFiles";
            this.lstMediaFiles.Size = new System.Drawing.Size(185, 82);
            this.lstMediaFiles.TabIndex = 11;
            this.lstMediaFiles.SelectedIndexChanged += new System.EventHandler(this.lstMediaFiles_SelectedIndexChanged);
            
            // label1
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 10F);
            this.label1.Location = new System.Drawing.Point(24, 223);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 16);
            this.label1.TabIndex = 12;
            this.label1.Text = "Attachments:";
            
            // progressBar
            this.progressBar.Location = new System.Drawing.Point(27, 329);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(293, 23);
            this.progressBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBar.TabIndex = 13;
            this.progressBar.Visible = false;
            
            // Report_Issues
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(355, 418);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstMediaFiles);
            this.Controls.Add(this.btnBackToMainMenu);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.btnAttachMedia);
            this.Controls.Add(this.btnRemoveMedia);
            this.Controls.Add(this.rtxtDescription);
            this.Controls.Add(this.lblDescriptionHeading);
            this.Controls.Add(this.cmbCategory);
            this.Controls.Add(this.lblCategoryHeading);
            this.Controls.Add(this.txtLocation);
            this.Controls.Add(this.lblLocationHeading);
            this.Controls.Add(this.progressBar);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Report_Issues";
            this.Text = "eCitizen: Report an Issue";
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}