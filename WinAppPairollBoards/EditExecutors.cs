using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinAppPairollBoards
{
    public partial class FormEditExecutors : Form
    {
        private object list_of_executorBindingSource;

        public FormEditExecutors()
        {
            InitializeComponent();
        }

        private void EditExecutors_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "pairollBoardsDataSet.Executor". При необходимости она может быть перемещена или удалена.
            this.executorTableAdapter.Fill(this.pairollBoardsDataSet.Executor);

        }

        private void buttonSave1_Click(object sender, EventArgs e)
        {
            executorTableAdapter.Update(pairollBoardsDataSet);
            MessageBox.Show("Изменение сохранены в базе данных");
        }

        private void buttonBack1_Click(object sender, EventArgs e)
        {
            Form formManager = new FormManager();
            formManager.ShowDialog();
            this.Hide();
        }

        private void dataGridView1_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            DialogResult dr = MessageBox.Show("Удалить запись?", "Удаление", MessageBoxButtons.OKCancel,
                MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
            if (dr == DialogResult.Cancel)
            {
                e.Cancel = true;
            }
        }

        private void buttonDelete1_Click(object sender, EventArgs e)
        {
            dataGridView2.Rows.RemoveAt(dataGridView2.CurrentCell.RowIndex);//Удаление записи
            executorTableAdapter.Update(pairollBoardsDataSet);//Обновление данных в базе
            MessageBox.Show("Запись удалена, изменения сохранены в базе данных");
        }
    }
}
