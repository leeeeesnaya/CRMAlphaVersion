using System;
using System.Data.SqlClient;
using System.Data;
using System.IO;
using System.Windows.Forms;
using GemBox.Document;
using System.Text;
using Spire.Doc;
using System.Diagnostics;


namespace CRMAlphaVersion
{
    public partial class Contract : Form
    {
        private DataBase database;
        private SaveFileToDB fileSaver;
        private DownloadFileFromDB fileFromDB;

        public Contract()
        {
            InitializeComponent();
            database = new DataBase();
            fileSaver = new SaveFileToDB(database);
            fileFromDB = new DownloadFileFromDB(database);
            LoadDataToDataGridView();

            dataGridViewContracts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void Contract_Load(object sender, EventArgs e)
        {

        }

        private void LoadDataToDataGridView()
        {
            try
            {
                database.OpenConnection();
                string query = "Select N.ClientOrganizationName, C.ContractNumber, C.CreatedBy, C.CreatedDate, C.ContractStartDate, C.ContractEndDate\r\n" +
                    "From Contracts C\r\n" +
                    "Join ClientOrganizations N ON C.ClientOrganizationID = N.ClientOrganizationID";

                using (SqlDataAdapter dataAdapter = new SqlDataAdapter(query, database.GetConnection()))
                {
                    using (DataSet dataSet = new DataSet())
                    {
                        dataAdapter.Fill(dataSet, "Contracts");

                        foreach (DataRow row in dataSet.Tables["Contracts"].Rows)
                        {
                            dataGridViewContracts.Rows.Add(
                                row["ClientOrganizationName"],
                                row["ContractNumber"],
                                row["CreatedBy"],
                                row["CreatedDate"],
                                row["ContractStartDate"],
                                row["ContractEndDate"]
                            );
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка загрузки данных: " + ex.Message);
            }
            finally
            {
                database.CloseConnection();
            }
        }

        private void Uploadfile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Word Documents|*.docx";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string fileName = openFileDialog.FileName;
                byte[] fileData = File.ReadAllBytes(fileName);

                fileSaver.SaveFileToDatabase(fileName, fileData);
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            fileFromDB.DownloadFileFromDatabase();
        }
    }
}
