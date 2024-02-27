using CRMAlphaVersion.Scripts_Update;
using System;
using System.Windows.Forms;

namespace CRMAlphaVersion.UpdateRecord
{
    public partial class UpdateOrganization : Form
    {
        private int organizationID;
        private updateScriptOrganization updater;
        public UpdateOrganization(int id, Organizations organizationsForm)
        {
            InitializeComponent();
            organizationID = id;
            updater = new updateScriptOrganization();
            updater.FillTextBoxesFromDatabase(id, this);
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            string nameOrganizations = nameOrganization.Text;
            string Emails = Email.Text;
            string addressOrganizations = addressOrganization.Text;
            string mobilePhoneOrganizations = mobilePhoneOrganization.Text;
            string codeEDRPOYs = codeEDRPOY.Text;

            updater.UpdateOrganizationInfo(organizationID, nameOrganizations, Emails, addressOrganizations,
                mobilePhoneOrganizations, codeEDRPOYs);
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
