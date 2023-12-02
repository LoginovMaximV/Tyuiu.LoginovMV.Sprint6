using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.LoginovMV.Sprint6.Task1.V14.Lib;

namespace Tyuiu.LoginovMV.Sprint6.Task1.V14
{
    public partial class FormMain_LMV : Form
    {
        public FormMain_LMV()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();
        private void buttonDone_LMV_Click(object sender, EventArgs e)
        {
            try
            {
                int start = Convert.ToInt32(textBoxStart_LMV.Text);
                int stop = Convert.ToInt32(textBoxStop_LMV.Text);
                string line;
                int len = ds.GetMassFunction(start, stop).Length;
                double[] valueA = new double[len];
                valueA = ds.GetMassFunction(start, stop);
                textBoxOutPut_LMV.Text = "";
                textBoxOutPut_LMV.AppendText("+--------+---------+"+ Environment.NewLine);
                textBoxOutPut_LMV.AppendText("|    x   |   f(x)  |" + Environment.NewLine);
                textBoxOutPut_LMV.AppendText("+--------+---------+" + Environment.NewLine);
                for (int i = 0; i <= len - 1; i++)
                {
                    line = String.Format("|{0,5:d}   | {1,5:f2}   |", start, valueA[i]);
                    textBoxOutPut_LMV.AppendText(line + Environment.NewLine);
                    start++;
                }
                textBoxOutPut_LMV.AppendText("+--------+---------+"+ Environment.NewLine);
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonHelp_LMV_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 0 выполнил студент группы ИИПб-23-2 Логинов Максим Валерьевич", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void textBoxStart_LMV_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && (e.KeyChar != ',') && (e.KeyChar != 8))
            {
                e.Handled = true;
            }
        }

        private void FormMain_LMV_Load(object sender, EventArgs e)
        {

        }
    }
}
