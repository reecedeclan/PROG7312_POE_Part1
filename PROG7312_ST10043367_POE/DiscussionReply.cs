using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROG7312_ST10043367_POE
{
    public partial class DiscussionReply : Form
    {
        public DiscussionReply()
        {
            InitializeComponent(); 
        }

        //Reply to discussion
        private void btnSubmitReply_Click(object sender, EventArgs e)
        {
            string replyText = txtReply.Text;
            if (!string.IsNullOrWhiteSpace(replyText))
            {
                MessageBox.Show("Your reply has been submitted!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("Please enter a reply before submitting.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}