using CRMAlphaVersion.Scripts_Update;
using System;

using System.Windows.Forms;

namespace CRMAlphaVersion.UpdateRecord
{
    public partial class UpdateUser : Form
    {
        private int userID; 
        private updateScriptUser updater; 

        public UpdateUser(int id, Users usersForm)
        {
            InitializeComponent();
            userID = id; 
            updater = new updateScriptUser(); 
            updater.FillTextBoxesFromDatabase(id, this);
        }

        private void UpdateUser_Load(object sender, EventArgs e)
        {

        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            string newName = firstName.Text + " " + secondName.Text + " " + thirdName.Text;
            string newPosition = positionUser.Text;
            string newPhone = mobilePhoneUser.Text;
            string newEmail = Email.Text;
            string newPassword = passwordUser.Text;
            string newStatus = statusAcc.Text;

            updater.UpdateUsersInfo(userID, newName, newPosition, newPhone, newEmail, newPassword, newStatus);
        }
    }
}
