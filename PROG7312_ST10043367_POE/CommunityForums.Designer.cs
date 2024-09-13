using System.Windows.Forms;

namespace PROG7312_ST10043367_POE
{
    partial class CommunityForums
    {
        private ListBox listBoxDiscussions;
        private TextBox textBoxNewPost;
        private Button btnPost;

        private void InitializeComponent()
        {
            this.listBoxDiscussions = new System.Windows.Forms.ListBox();
            this.textBoxNewPost = new System.Windows.Forms.TextBox();
            this.btnPost = new System.Windows.Forms.Button();
            this.SuspendLayout();

            // listBoxDiscussions
            this.listBoxDiscussions.Font = new System.Drawing.Font("Arial", 12F);
            this.listBoxDiscussions.FormattingEnabled = true;
            this.listBoxDiscussions.ItemHeight = 18;
            this.listBoxDiscussions.Location = new System.Drawing.Point(12, 12);
            this.listBoxDiscussions.Name = "listBoxDiscussions";
            this.listBoxDiscussions.Size = new System.Drawing.Size(360, 274);
            this.listBoxDiscussions.TabIndex = 0;

            // textBoxNewPost
            this.textBoxNewPost.Font = new System.Drawing.Font("Arial", 12F);
            this.textBoxNewPost.Location = new System.Drawing.Point(12, 300);
            this.textBoxNewPost.Name = "textBoxNewPost";
            this.textBoxNewPost.Size = new System.Drawing.Size(260, 26);
            this.textBoxNewPost.TabIndex = 1;

            // btnPost
            this.btnPost.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.btnPost.Location = new System.Drawing.Point(290, 300);
            this.btnPost.Name = "btnPost";
            this.btnPost.Size = new System.Drawing.Size(82, 26);
            this.btnPost.TabIndex = 2;
            this.btnPost.Text = "Post";
            this.btnPost.UseVisualStyleBackColor = true;
            this.btnPost.Click += new System.EventHandler(this.btnPost_Click);

            // CommunityForums
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 361);
            this.Controls.Add(this.btnPost);
            this.Controls.Add(this.textBoxNewPost);
            this.Controls.Add(this.listBoxDiscussions);
            this.Name = "CommunityForums";
            this.Text = "eCitizen: Community Forums";
            this.Load += new System.EventHandler(this.CommunityForums_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}