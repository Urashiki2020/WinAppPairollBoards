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
    public partial class FormManager : Form
    {
        public FormManager()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;//Чтобы форма отображалась в центре экрана при запуске
            this.BackColor = Color.FromArgb(255, 255, 255);//Цвет фона белый
            this.Width = 800;//Ширина формы
            this.MinimumSize = new Size(800, 410);//Минимальный неизменяемый размер окна
        }

        private void FormManager_Load(object sender, EventArgs e)
        {

        }
    }
}
