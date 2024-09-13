using System;
using System.Windows.Forms;

namespace PROG7312_ST10043367_POE
{
    partial class DiscussionReply
    {
        private System.Windows.Forms.TextBox txtReply;
        private System.Windows.Forms.Button btnSubmitReply;

        private void InitializeComponent()
        {
            this.txtReply = new System.Windows.Forms.TextBox();
            this.btnSubmitReply = new System.Windows.Forms.Button();
            this.SuspendLayout();

            // txtReply
            this.txtReply.Location = new System.Drawing.Point(50, 50);
            this.txtReply.Multiline = true;
            this.txtReply.Name = "txtReply";
            this.txtReply.Size = new System.Drawing.Size(400, 200);
            this.txtReply.TabIndex = 0;

            // btnSubmitReply
            this.btnSubmitReply.Location = new System.Drawing.Point(50, 270);
            this.btnSubmitReply.Name = "btnSubmitReply";
            this.btnSubmitReply.Size = new System.Drawing.Size(75, 23);
            this.btnSubmitReply.TabIndex = 1;
            this.btnSubmitReply.Text = "Submit";
            this.btnSubmitReply.UseVisualStyleBackColor = true;
            this.btnSubmitReply.Click += new System.EventHandler(this.btnSubmitReply_Click);

            // DiscussionReply
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 350);
            this.Controls.Add(this.txtReply);
            this.Controls.Add(this.btnSubmitReply);
            this.Name = "DiscussionReply";
            this.Text = "Reply to Discussion";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}