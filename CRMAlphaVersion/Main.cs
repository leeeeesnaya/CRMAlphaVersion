using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace CRMAlphaVersion
{
    public partial class Main : Form
    {
        DataBase dataBase;
        public string UserName { get; set; }
        public string UserPosition { get; set; }

        private DataTable currentDataTable;

        public Main(string userName, string userPosition)
        {
            InitializeComponent();
            UserName = userName;
            UserPosition = userPosition;
            InitializeOthersLabels();
        }

        private void InitializeOthersLabels()
        {
            if (!string.IsNullOrEmpty(UserName) && !string.IsNullOrEmpty(UserPosition))
            {
                FirstLabel.Text = UserName;
                SecondLabel.Text = UserPosition;
            }
            else
            {
                MessageBox.Show("UserName is not initialized!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
        private void container(object _form)
        {
            if(MainPanel.Controls.Count > 0) MainPanel.Controls.Clear();

            Form main = _form as Form;
            main.TopLevel = false;
            main.FormBorderStyle = FormBorderStyle.None;
            main.Dock = DockStyle.Fill;
            MainPanel.Controls.Add(main);
            MainPanel.Tag = main;
            main.Show();
        }

        private void LeadsButton_Click(object sender, EventArgs e)
        {
            container(new Leads());
        }

        private void DealsButton_Click(object sender, EventArgs e)
        {
            container(new Deals());
        }

        private void ActivitiesButton_Click(object sender, EventArgs e)
        {
            container(new Users());
        }

        private void ContractButton_Click(object sender, EventArgs e)
        {
            container(new Users());
        }

        private void UsersButton_Click(object sender, System.EventArgs e)
        {
            container(new Users());
        }

        //Временно не работает, сделать позже, пока что в приоритете таблицы
        private void searchTextBox_TextChanged(object sender, EventArgs e)
        {
            if (currentDataTable != null)
            {
                // Создайте динамическое выражение для фильтрации
                string filterExpression = string.Empty;

                foreach (DataColumn column in currentDataTable.Columns)
                {
                    filterExpression += $"{column.ColumnName} LIKE '%{searchTextBox.Text}%' OR ";
                }

                // Удалите последний " OR "
                if (!string.IsNullOrEmpty(filterExpression))
                {
                    filterExpression = filterExpression.Substring(0, filterExpression.Length - 4);
                }

                // Примените динамическое выражение фильтрации к текущей таблице
                currentDataTable.DefaultView.RowFilter = filterExpression;
            }
        }
    }
}
