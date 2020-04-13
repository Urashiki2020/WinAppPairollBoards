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
    public partial class FormEditTasks : Form
    {
        public FormEditTasks()
        {
            InitializeComponent();
        }

        private void FormEditTasks_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "pairollBoardsDataSet.Tasks". При необходимости она может быть перемещена или удалена.
            this.tasksTableAdapter.Fill(this.pairollBoardsDataSet.Tasks);

        }

        private void buttonSave2_Click(object sender, EventArgs e)
        {
            tasksTableAdapter.Update(pairollBoardsDataSet);
            MessageBox.Show("Изменения сохранены в базе данных");
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

        private void buttonDelete2_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.RemoveAt(dataGridView1.CurrentCell.RowIndex);//Удаление записи
            tasksTableAdapter.Update(pairollBoardsDataSet);//Обновление данных в базе
            MessageBox.Show("Запись удалена, изменения сохранены в базе данных");
        }

        private void buttonBack2_Click(object sender, EventArgs e)
        {
            Form formExecutor = new FormExecutor();
            formExecutor.ShowDialog();
            this.Hide();
        }
    }
}
