using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.LoginovMV.Sprint6.Task4.V14.Lib;
using System.IO;

namespace Tyuiu.LoginovMV.Sprint6.Task4.V14
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
                int len = ds.GetMassFunction(start, stop).Length;
                double[] valueA = new double[len];
                valueA = ds.GetMassFunction(start, stop);
                this.chartFunction_LMV.ChartAreas[0].AxisX.Title = "Ось Х";
                this.chartFunction_LMV.ChartAreas[0].AxisY.Title = "Ось Y";
                textBoxRes_LMV.Text = "";
                chartFunction_LMV.Series[0].Points.Clear();
                for (int i = 0; i <= len-1; i++)
                {
                    this.chartFunction_LMV.Series[0].Points.AddXY(start, valueA[i]);
                    textBoxRes_LMV.AppendText(valueA[i] + Environment.NewLine);
                    start++;
                }
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonHelp_LMV_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 4 выполнил студент группы ИИПб-23-2 Логинов Максим Валерьевич", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonFile_LMV_Click(object sender, EventArgs e)
        {
            try
            {

                string path = $@"{Directory.GetCurrentDirectory()}\OutPutFile.Task4.txt";
                FileInfo file = new FileInfo(path);
                bool fileExist = file.Exists;
                if (fileExist)
                {
                    File.Delete(path);
                }
                File.AppendAllText(path, textBoxRes_LMV.Text);
                DialogResult dialogResult = MessageBox.Show("Файл" + path + "сохранен успешно!\n Открыть его в блокноте?", "Сообщение", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (dialogResult == DialogResult.Yes)
                {
                    System.Diagnostics.Process txt = new System.Diagnostics.Process();
                    txt.StartInfo.FileName = "notepad.exe";
                    txt.StartInfo.Arguments = path;
                    txt.Start();
                }
            }
            catch
            {
                MessageBox.Show("Сбой при сохранении файла", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
