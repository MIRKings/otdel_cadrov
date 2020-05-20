using DOtel.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DOtel
{
    public partial class CADR : Form
    {
        private bool IsColl;
        public CADR()
        {
            InitializeComponent();             
        }
  
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (IsColl)
            {
                MENUBUTTON.Image = Resources.Collapse_Arrow_20px;
                panel1.Height += 10;
                if (panel1.Size == panel1.MaximumSize)
                {
                    timer1.Stop();
                    IsColl = false;
                }
            }
            else
            {
                MENUBUTTON.Image = Resources.Expand_Arrow_20px;

                panel1.Height -= 10;
                if (panel1.Size == panel1.MinimumSize)
                {
                    timer1.Stop();
                    IsColl = true;
                }
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }     

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void назадToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            AUTH auth = new AUTH();
            auth.Show();
        }

      
        private void CADR_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "отдел_кадровDataSet.Оценка_сотрудников". При необходимости она может быть перемещена или удалена.
            this.оценка_сотрудниковTableAdapter.Fill(this.отдел_кадровDataSet.Оценка_сотрудников);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "отдел_кадровDataSet.Задачи". При необходимости она может быть перемещена или удалена.
            this.задачиTableAdapter.Fill(this.отдел_кадровDataSet.Задачи);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "отдел_кадровDataSet.Штатное_расписание". При необходимости она может быть перемещена или удалена.
            this.штатное_расписаниеTableAdapter.Fill(this.отдел_кадровDataSet.Штатное_расписание);

        }

        private void ZADACHIBUTTON_Click(object sender, EventArgs e)
        {
            panelZADACHI.BringToFront();
            panelZADACHI.Visible = true;
            panelZADACHI.Dock = DockStyle.Fill;
        }
        private void raspisanieBUTTON_Click(object sender, EventArgs e)
        {
            panel_RASPIS.BringToFront();
            panel_RASPIS.Visible = true;
            panel_RASPIS.Dock = DockStyle.Fill;

        }
        private void OCENKABUTTON_Click(object sender, EventArgs e)
        {
            panelOCENKA.BringToFront();
            panelOCENKA.Visible = true;
            panelOCENKA.Dock = DockStyle.Fill;
        }

        private void toolStripButton2_Click_1(object sender, EventArgs e)
        {
            CADR cadr = new CADR();
            cadr.Show();
        }
    }
}
