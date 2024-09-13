using System.Windows.Forms;

namespace PROG7312_ST10043367_POE
{
    partial class ViewIssues
    {
        private System.ComponentModel.IContainer components = null;
        private DataGridView dataGridViewIssues;
        private Button btnBackToMainMenu;

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
            this.dataGridViewIssues = new System.Windows.Forms.DataGridView();
            this.btnBackToMainMenu = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewIssues)).BeginInit();
            this.SuspendLayout();

            // dataGridViewIssues
            this.dataGridViewIssues.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewIssues.Location = new System.Drawing.Point(12, 12);
            this.dataGridViewIssues.Name = "dataGridViewIssues";
            this.dataGridViewIssues.RowHeadersWidth = 51;
            this.dataGridViewIssues.RowTemplate.Height = 24;
            this.dataGridViewIssues.Size = new System.Drawing.Size(760, 400);
            this.dataGridViewIssues.TabIndex = 0;

            // btnBackToMainMenu
            this.btnBackToMainMenu.Location = new System.Drawing.Point(650, 420);
            this.btnBackToMainMenu.Name = "btnBackToMainMenu";
            this.btnBackToMainMenu.Size = new System.Drawing.Size(122, 36);
            this.btnBackToMainMenu.TabIndex = 1;
            this.btnBackToMainMenu.Text = "Back to eCitizen";
            this.btnBackToMainMenu.UseVisualStyleBackColor = true;
            this.btnBackToMainMenu.Click += new System.EventHandler(this.btnBackToMainMenu_Click);
            
            // ViewIssues
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.btnBackToMainMenu);
            this.Controls.Add(this.dataGridViewIssues);
            this.Name = "ViewIssues";
            this.Text = "eCitizen: Issues Logged";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewIssues)).EndInit();
            this.ResumeLayout(false);

        }
    }
}