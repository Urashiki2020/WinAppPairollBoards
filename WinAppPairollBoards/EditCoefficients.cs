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
    public partial class FormEditCoefficients : Form
    {
        public FormEditCoefficients()
        {
            InitializeComponent();
        }

        private void FormEditCoefficients_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "pairollBoardsDataSet.Coefficient". При необходимости она может быть перемещена или удалена.
            this.coefficientTableAdapter.Fill(this.pairollBoardsDataSet.Coefficient);

        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            coefficientTableAdapter.Update(pairollBoardsDataSet);
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

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.RemoveAt(dataGridView1.CurrentCell.RowIndex); //Удаление записи
            coefficientTableAdapter.Update(pairollBoardsDataSet); //Обновление данных в базе
            MessageBox.Show("Запись удалена из базы данных");
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            Form formManager = new FormManager();
            formManager.ShowDialog();
            this.Hide();
        }
    }
}
