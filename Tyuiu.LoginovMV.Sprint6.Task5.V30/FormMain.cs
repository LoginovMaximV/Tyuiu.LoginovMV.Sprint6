using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.LoginovMV.Sprint6.Task5.V30.Lib;
using System.IO;

namespace Tyuiu.LoginovMV.Sprint6.Task5.V30
{
    public partial class FormMain_LMV : Form
    {
        public FormMain_LMV()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();
        string path = @"C:\Users\Валерий\source\repos\Tyuiu.LoginovMV.Sprint6\Tyuiu.LoginovMV.Sprint6.Task5.V30\bin\Debug\InPutFileTask5V30.txt";
        private void buttonDone_LMV_Click(object sender, EventArgs e)
        {
            dataGridViewRes_LMV.ColumnCount = 2;
            dataGridViewRes_LMV.Columns[0].Width = 20;
            dataGridViewRes_LMV.Columns[1].Width = 50;
            this.chartRes_LMV.ChartAreas[0].AxisX.Title = "Ось Х";
            this.chartRes_LMV.ChartAreas[0].AxisY.Title = "Ось Y";
            chartRes_LMV.Series[0].Points.Clear();
            double[] mas = new double[ds.len];
            mas = ds.LoadFromDataFile(path);
            for (int i = 0; i < mas.Length; i++)
            {
                dataGridViewRes_LMV.Rows.Add(Convert.ToString(i), Convert.ToString(mas[i]));
                chartRes_LMV.Series[0].Points.AddXY(i, mas[i]);
            }
        }

        private void buttonFile_LMV_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process txt = new System.Diagnostics.Process();
            txt.StartInfo.FileName = "notepad.exe";
            txt.StartInfo.Arguments = path;
            txt.Start();
        }

        private void buttonHelp_LMV_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 5 выполнил студент группы ИИПб-23-2 Логинов Максим Валерьевич", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
