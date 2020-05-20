
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Linq.Expressions;
namespace DOtel
{
    public partial class ADMIN : Form
    {
        public static string sqlConnection = @"Data Source=DESKTOP-1Q46A8D\SQLEXPRESS;Initial Catalog=Отдел_кадров;Integrated Security=True";

        private SqlConnection Connection = new SqlConnection(sqlConnection);      

        public ADMIN()
        {
            InitializeComponent();          
        }

        private void ADMIN_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "отдел_кадровDataSet.Сотрудники". При необходимости она может быть перемещена или удалена.
            this.сотрудникиTableAdapter.Fill(this.отдел_кадровDataSet.Сотрудники);

            Connection.Open();

        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            string del = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            string cmdSTR = "DELETE FROM dbo.Сотрудники WHERE ID_сотрудника = '" + del + "';";
            SqlCommand command = new SqlCommand(cmdSTR, Connection);
            command.ExecuteNonQuery();
            Connection.Close();
            this.сотрудникиTableAdapter.Fill(this.отдел_кадровDataSet.Сотрудники);
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void обновитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            AUTH auth = new AUTH();
            auth.Show();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
           
            try
            {
                this.сотрудникиTableAdapter.Update(this.отдел_кадровDataSet.Сотрудники);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка! Заполните все поля!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            if (toolStripComboBox1.Text == "По убыванию")
            {
                dataGridView1.Sort(dataGridView1.Columns[dataGridView1.CurrentCell.ColumnIndex], ListSortDirection.Descending);

            }
            else if (toolStripComboBox1.Text == " По возрастанию")
            {
                dataGridView1.Sort(dataGridView1.Columns[dataGridView1.CurrentCell.ColumnIndex], ListSortDirection.Ascending);
            }
        }
    }

}
