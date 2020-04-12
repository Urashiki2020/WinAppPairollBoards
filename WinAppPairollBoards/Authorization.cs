using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace WinAppPairollBoards
{
    public partial class FormAuthorization : Form
    {
        public FormAuthorization()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen; //Чтобы форма отображалась в центре экрана при запуске
            this.BackColor = Color.FromArgb(255, 255, 255); //Цвет фона белый
            this.Width = 800; //Ширина формы
            this.MinimumSize = new Size(800, 410); //Минимальный неизменяемый размер окна
        }

        private void labelPassword_Click(object sender, EventArgs e)
        {

        }

        private void FormAuthorization_Load(object sender, EventArgs e)
        {

        }
        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonInput_Click_1(object sender, EventArgs e)
        {

            SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-TVLAIMU\SQLEXPRESS;Initial Catalog=PairollBoards;Integrated Security=True");
            try
            {
                //Код проверки совпадения логин-пароль-роль для менеджера
                string commandManager = "SELECT*FROM Users WHERE login='" + textBoxLogin.Text + "' AND password='" + textBoxPassword.Text + "'AND role='manager'";
                SqlCommand checkManager = new SqlCommand(commandManager, connection);

                //Код проверки совпадения логин-пароль-роль для исполнителя
                string comandExecutor = "SELECT*FROM Users WHERE login='" + textBoxLogin.Text + "' AND password='" + textBoxPassword.Text + "'AND role='executor'";
                SqlCommand checkExecutor = new SqlCommand(comandExecutor, connection);
                connection.Open();
                if (checkManager.ExecuteScalar() != null)//Если логин-пароль менеджера совпадают то переход на форму менеджера
                {
                    Form formManager = new FormManager();
                    formManager.ShowDialog();
                    this.Hide();
                }
                else
                {
                    if (checkExecutor.ExecuteScalar() != null)//Если логин-пароль исполнителя совпадают то переход на форму исполнителя
                    {
                        Form formExecutor = new FormExecutor();
                        formExecutor.ShowDialog();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Пожалуйста проверьте еще раз введенные данные!", "Вы ввели неверный логин или пароль!");
                    }
                }
            }
            catch
            {
                MessageBox.Show("Возникло исключение!");
                connection.Close();
            }
        }
    }
}
