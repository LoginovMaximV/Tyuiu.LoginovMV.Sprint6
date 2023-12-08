using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.LoginovMV.Sprint6.Task6.V25.Lib;
using System.IO;

namespace Tyuiu.LoginovMV.Sprint6.Task6.V25.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = @"C:\Users\Валерий\source\repos\Tyuiu.LoginovMV.Sprint6\Tyuiu.LoginovMV.Sprint6.Task6.V25\bin\Debug\InPutFileTask6V25.txt";
            DataService ds = new DataService();
            string res = ds.CollectTextFromFile(path);
            string wait = " ELHLVt EgQpG dsE jiUFMDjMsEervIz ZujmucpYQE";
            Assert.AreEqual(wait, res);
        }
    }
}
