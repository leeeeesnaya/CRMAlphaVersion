using CRMAlphaVersion.Scripts_Delete;
using System;
using System.Windows.Forms;

namespace CRMAlphaVersion
{
    public partial class accept : Form
    {
        private int userID;

        public accept(int ID)
        {
            InitializeComponent();
            userID = ID;
        }

        private void acceptButton_Click(object sender, EventArgs e)
        {
            deleteScriptUser deleter = new deleteScriptUser();
            deleter.DeleteUserByID(userID);
            this.Close();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Users users = new Users();
            users.LoadDataToDataGridView();
            this.Close();
        }
    }
}
