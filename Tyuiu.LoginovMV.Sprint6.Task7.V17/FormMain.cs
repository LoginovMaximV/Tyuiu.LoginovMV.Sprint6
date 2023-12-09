using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.LoginovMV.Sprint6.Task7.V17.Lib;
using System.IO;

namespace Tyuiu.LoginovMV.Sprint6.Task7.V17
{
    public partial class FormMain_LMV : Form
    {
        public FormMain_LMV()
        {
            InitializeComponent();
            openFileDialogTask_LMV.Filter = "Значения, разделенные запятыми(*.csv)|*.csv|Все файлы(*.*)|*.*";
            saveFileDialogMatrix_LMV.Filter = "Значения, разделенные запятыми(*.csv)|*.csv|Все файлы(*.*)|*.*";
        }
        public string openFilePath;
        public string path = @"C:\Users\Валерий\source\repos\Tyuiu.LoginovMV.Sprint6\Tyuiu.LoginovMV.Sprint6.Task7.V17\bin\Debug\InPutFileTask7V17.csv";
        DataService ds = new DataService();

        private void FormMain_LMV_Load(object sender, EventArgs e)
        {

        }

        private void buttonOpenFile_LMV_Click(object sender, EventArgs e)
        {
            openFileDialogTask_LMV.ShowDialog();
            openFilePath = openFileDialogTask_LMV.FileName;
            string fileData = File.ReadAllText(path);
            // разделение на строки
            fileData = fileData.Replace('\n', '\r');
            string[] lines = fileData.Split(new char[] { '\r' }, StringSplitOptions.RemoveEmptyEntries);

            // количество строк и столбцов
            int rows = lines.Length;
            int columns = lines[0].Split(';').Length;

            // массив
            int[,] mas = new int[rows, columns];
            for (int i = 0; i < rows; i++)
            {
                string[] values = lines[i].Split(';');
                for (int j = 0; j < columns; j++)
                {
                    mas[i, j] = int.Parse(values[j]);
                }
            }
            dataGridViewInPut_LMV.ColumnCount = columns;
            dataGridViewInPut_LMV.RowCount = rows;
            dataGridViewOutPut_LMV.ColumnCount = columns;
            dataGridViewOutPut_LMV.RowCount = rows;

            for (int i = 0; i < columns; i++) 
            {
                dataGridViewInPut_LMV.Columns[i].Width = 25;
                dataGridViewOutPut_LMV.Columns[i].Width = 25;
            }
            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < columns; c++) 
                {
                    dataGridViewInPut_LMV.Rows[r].Cells[c].Value = mas[r, c];
                }
            }
            mas = ds.GetMatrix(openFilePath);
            buttonDone_LMV.Enabled = true;
        }

        private void buttonDone_LMV_Click(object sender, EventArgs e)
        {
            int rows = 10;
            int columns = 10;
            int[,] res = new int[rows, columns];
            res = ds.GetMatrix(path);
            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < columns; c++)
                {
                    dataGridViewOutPut_LMV.Rows[r].Cells[c].Value = res[r, c];
                }
            }
            buttonSaveFile_LMV.Enabled = true;
        }

        private void buttonSaveFile_LMV_Click(object sender, EventArgs e)
        {
            saveFileDialogMatrix_LMV.FileName = "OutPutFileTask7.csv";
            saveFileDialogMatrix_LMV.InitialDirectory = Directory.GetCurrentDirectory();
            saveFileDialogMatrix_LMV.ShowDialog();
            string pathsave = saveFileDialogMatrix_LMV.FileName;
            FileInfo fileinfo = new FileInfo(pathsave);
            bool fileExist = fileinfo.Exists;
            if(fileExist)
            {
                File.Delete(pathsave);
            }
            int rows = dataGridViewOutPut_LMV.RowCount;
            int columns = dataGridViewOutPut_LMV.ColumnCount;
            string str = "";
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (j != columns - 1)
                    {
                        str = str + dataGridViewOutPut_LMV.Rows[i].Cells[j].Value + ";";
                    }
                    else
                    {
                        str = str + dataGridViewOutPut_LMV.Rows[i].Cells[j].Value;
                    }

                }
                File.AppendAllText(pathsave, str + Environment.NewLine);
                str = "";
            }

        }

        private void buttonAbout_LMV_Click(object sender, EventArgs e)
        {
            FormAbout_LMV formAbout = new FormAbout_LMV();
            formAbout.ShowDialog();
        }

        private void splitter1_SplitterMoved(object sender, SplitterEventArgs e)
        {

        }
    }
}
