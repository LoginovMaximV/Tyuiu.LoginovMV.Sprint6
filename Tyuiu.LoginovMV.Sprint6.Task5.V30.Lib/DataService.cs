using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint6;
using System.IO;
namespace Tyuiu.LoginovMV.Sprint6.Task5.V30.Lib
{
    public class DataService : ISprint6Task5V30
    {
        public int len = 0;
        public double[] LoadFromDataFile(string path)
        {
            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    len++;
                }
            }
            double[] mas = new double[len];
            int index = 0;
            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                while((line = reader.ReadLine()) != null)
                {
                    mas[index] = Math.Round(Convert.ToDouble(line),3);
                    index++;
                }
            }
            mas = mas.Where(val => (val >= 2)&&(val <=7)).ToArray();
            return mas;
        }
    }
}
