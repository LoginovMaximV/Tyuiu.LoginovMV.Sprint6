using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.LoginovMV.Sprint6.Task5.V30.Lib;

namespace Tyuiu.LoginovMV.Sprint6.Task5.V30.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            string path = @"C:\Users\Валерий\source\repos\Tyuiu.LoginovMV.Sprint6\Tyuiu.LoginovMV.Sprint6.Task5.V30\bin\Debug\InPutFileTask5V30.txt";
            double[] res = ds.LoadFromDataFile(path);
            double i = res[0];
            double wait = 5;
            Assert.AreEqual(wait, i);
        }
    }
}
