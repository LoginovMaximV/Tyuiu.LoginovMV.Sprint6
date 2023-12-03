using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.LoginovMV.Sprint6.Task3.V29.Lib;

namespace Tyuiu.LoginovMV.Sprint6.Task3.V29
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();
        int[,] matrix = new int[5, 5] { {-2, -13, -15, -9, -17},
                                            {13,-20, -15,  27,  18 },
                                            {-12, -1, -20, 13, 0 },
                                            {15, 32, 18, -12, -18},
                                            {16, 5, 3,-5, -8 }};
        private void buttonDone_LMV_Click(object sender, EventArgs e)
        {
            int[,] matres = ds.Calculate(matrix);
            int n = matres.GetLength(0);
            int m = matres.GetLength(1);
            dataGridViewRes_LMV.ColumnCount = m;
            dataGridViewRes_LMV.RowCount = n;
            for (int i = 0; i < m; i++)
            {
                dataGridViewRes_LMV.Columns[i].Width = 25;
            }
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    dataGridViewRes_LMV.Rows[i].Cells[j].Value = Convert.ToString(matres[i, j]);
                }
            }
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            int n = matrix.GetLength(0);
            int m = matrix.GetLength(1);
            dataGridViewInPut_LMV.ColumnCount = m;
            dataGridViewInPut_LMV.RowCount = n;
            for (int i = 0; i < m; i++)
            {
                dataGridViewInPut_LMV.Columns[i].Width = 25;
            }
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    dataGridViewInPut_LMV.Rows[i].Cells[j].Value = Convert.ToString(matrix[i, j]);
                }
            }
        }

        private void buttonHelp_LMV_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 3 выполнил студент группы ИИПб-23-2 Логинов Максим Валерьевич", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
