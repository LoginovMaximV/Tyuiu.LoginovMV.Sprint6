using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint6;
using System.IO;

namespace Tyuiu.LoginovMV.Sprint6.Task7.V17.Lib
{
    public class DataService : ISprint6Task7V17
    {
        public int[,] GetMatrix(string path)
        {
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
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (mas[2, j] % 2 == 0)
                    {
                        mas[2, j] = 4;
                    }
                }
            }
            return mas;
        }
    }
}
