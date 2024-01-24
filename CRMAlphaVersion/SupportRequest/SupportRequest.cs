using System;
using System.Windows.Forms;
using Atlassian.Jira;

namespace CRMAlphaVersion
{
    public partial class SupportRequest : Form
    {
        private Jira _jira;
        public SupportRequest()
        {
            InitializeComponent();
        }

        private void SupportRequest_Load(object sender, EventArgs e)
        {

        }
        private async void Submit_Click(object sender, EventArgs e)
        {

            try
            {
                _jira = Jira.CreateRestClient("https://crmworktest.atlassian.net", "crmworktestproject@gmail.com", "ATATT3xFfGF0CH_L1KjkP9KCrn3Fd5RsmZSot7ja6RaUdvJ7oVNzT593Lj3C8gWN48cMhwOWaLcQOM1Z7i8JSsVzwPsi7JkQEpgfPphU9Pyvgw95ZsH_OGk5GmLBHFnlujJRsvjO0wcHSpUehE3gGjQUgQ3J80fVJaemficR9OxGPXWro-vXuOE=C9D26998");

                string taskIssueTypeId = "10001";

                var issue = _jira.CreateIssue("SUPPORT");
                issue.Type = new IssueType(taskIssueTypeId);
                issue.Summary = SummaryText.Text;
                issue.Description = DescriptionText.Text;
                issue.Priority = Priority.SelectedItem.ToString();

                await issue.SaveChangesAsync();

                MessageBox.Show($"Задача создана успешно. Ключ задачи: {issue.Key}");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Произошла ошибка: {ex.Message}\nStackTrace: {ex.StackTrace}\nInnerException: {ex.InnerException}");
            }
        }
        private void SubmiTest_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(SummaryText.Text) || string.IsNullOrWhiteSpace(DescriptionText.Text) || Priority.SelectedItem == null)
            {
                MessageBox.Show("Все поля должны быть заполнены", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; 
            }

            string summaryText = SummaryText.Text;
            string descriptionText = DescriptionText.Text;
            string selectedValue = Priority.SelectedItem.ToString();

            MessageBox.Show(summaryText + "\n" + descriptionText + "\n" + selectedValue);
            this.Close();
        }
    }
}
