using System;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace DOtel
{
    public partial class AUTH : Form
    {
        //ПОДКЛЮЧЕНИЕ К БД
        public static string con = @"Data Source=DESKTOP-1Q46A8D\SQLEXPRESS;Initial Catalog=Отдел_кадров;Integrated Security=True";
        public readonly SqlConnection Conn = new SqlConnection(con);
        
        //ПЕРЕМЕННАЯ ДЛЯ ЗАПУСКА КАПЧИ
        public int kol = 0;

        public AUTH()
        {
            InitializeComponent();
            Conn.Open();
        }

        #region КНОПКА ВЫХОДА
        private void EXIT_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        #endregion

        #region КНОПКА СКРЫТИЯ ПАРОЛЯ
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == false)
            {
                grayTXT2.UseSystemPasswordChar = true;
            }
            else
                grayTXT2.UseSystemPasswordChar = false;
        }
        #endregion

        #region КНОПКА ВХОДА
        private void SINGIN_Click(object sender, EventArgs e)
        {
            if (grayTXT1.Text.Length > 0)
            {
                if (grayTXT2.Text.Length > 0)
                {
                    string sdastr = "SELECT Логин, Пароль, Тип_учетки FROM dbo.Сотрудники WHERE (Логин = '" + grayTXT1.Text + "') AND (Пароль = '" + grayTXT2.Text + "');";

                    SqlCommand cmd = new SqlCommand(sdastr, Conn);

                    cmd.ExecuteNonQuery();

                    if (cmd.ExecuteScalar() != null)
                    {
                        SqlDataReader reader = cmd.ExecuteReader();
                        reader.Read();
                        this.Hide();
                        string role = reader["Тип_учетки"].ToString().TrimEnd();

                        switch (role)
                        {
                            case "Админ":
                                this.Hide();
                                ADMIN main = new ADMIN();
                                main.Show();
                                break;

                            case "Сотрудник":
                                this.Hide();
                                SOTR sotr = new SOTR();
                                sotr.Show();
                                break;

                            case "Кадры":
                                this.Hide();
                                CADR cadr = new CADR();
                                cadr.Show();
                                break;
                        }
                        grayTXT1.Clear();
                        grayTXT2.Clear();
                    }

                    else
                    {
                      
                        MessageBox.Show("Неверный логин или пароль.");
                        grayTXT1.Clear();
                        grayTXT2.Clear();
//ЗАПУСК КАПЧИ

                        if (kol < 2)
                        {kol++;}
                        else
                        {
                            this.Hide();
                            CAPTCHA cap = new CAPTCHA();
                            cap.ShowDialog();
                            kol = 0;
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Введите значение для поля 'Пароль'");
                }
            }
            else
            {
                MessageBox.Show("Введите значение для поля 'Логин'");
            }

        }
        #endregion

    }
}
