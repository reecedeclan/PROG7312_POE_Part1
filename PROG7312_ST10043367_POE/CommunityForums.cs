using System;
using System.Windows.Forms;

namespace PROG7312_ST10043367_POE
{
    public partial class CommunityForums : Form
    {
        public CommunityForums()
        {
            InitializeComponent();
        }

        private void CommunityForums_Load(object sender, EventArgs e)
        {
            // Placeholder discussions
            listBoxDiscussions.Items.Add("Discussion 1: How to resolve billing issues");
            listBoxDiscussions.Items.Add("Discussion 2: Road maintenance delays");
            listBoxDiscussions.Items.Add("Discussion 3: Water outages in the area");
        }

        private void btnPost_Click(object sender, EventArgs e)
        {
            string newPost = textBoxNewPost.Text;

            if (string.IsNullOrWhiteSpace(newPost))
            {
                // Error handling for if user submits empty post
                MessageBox.Show(
                    "Please enter text to post a discussion.",
                    "eCitizen: Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
            else
            {
                // Add the new post to the list box if text is provided
                listBoxDiscussions.Items.Add("New Post: " + newPost);
                textBoxNewPost.Clear();
            }
        }
    }
}