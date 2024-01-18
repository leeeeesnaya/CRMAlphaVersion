using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRMAlphaVersion
{
    public partial class ColumnsSettingsForm : Form
    {
        public ColumnsSettingsForm()
        {
            InitializeComponent();
        }

        public List<string> SelectedColumns { get; private set; }

        public ColumnsSettingsForm(List<string> allColumns)
        {
            InitializeComponent();

            checkedListBoxColumns.Items.AddRange(allColumns.ToArray());
        }

        private void buttonApplySettings_Click(object sender, EventArgs e)
        {
            SelectedColumns = checkedListBoxColumns.CheckedItems.OfType<string>().ToList();
            DialogResult = DialogResult.OK;
            Close();
        }

        private void resetColumnSettings_Click(object sender, EventArgs e)
        {
            //Сбрасываем в дефолт настройку
            for (int i = 0; i < checkedListBoxColumns.Items.Count; i++)
            {
                checkedListBoxColumns.SetItemChecked(i, false);
            }

            // Отображаем колонки в таблице 
            for (int i = 0; i < checkedListBoxColumns.Items.Count; i++)
            {
                checkedListBoxColumns.SetItemChecked(i, true);
            }
            SelectedColumns = checkedListBoxColumns.CheckedItems.OfType<string>().ToList();
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
