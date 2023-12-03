using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.LoginovMV.Sprint6.Task3.V29.Lib
{
    public class DataService : ISprint6Task3V29
    {
        public int[,] Calculate(int[,] matrix)
        {
            int n = matrix.GetLength(0);
            int m = matrix.GetLength(1);
            int[] massiv = new int[5];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++) 
                {
                    massiv[0] = matrix[0, 4];
                    massiv[1] = matrix[1, 4];
                    massiv[2] = matrix[2, 4];
                    massiv[3] = matrix[3, 4];
                    massiv[4] = matrix[4, 4];
                }
            }
            Array.Sort(massiv);
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    matrix[0, 4] = massiv[0];
                    matrix[1, 4] = massiv[1];
                    matrix[2, 4] = massiv[2];
                    matrix[3, 4] = massiv[3];
                    matrix[4, 4] = massiv[4];
                }
            }
            return matrix;
        }
    }
}
