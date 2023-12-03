using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.LoginovMV.Sprint6.Task2.V5.Lib;

namespace Tyuiu.LoginovMV.Sprint6.Task2.V5.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int startValue = -5;
            int stopValue = 5;
            int len = stopValue - startValue + 1;
            double[] valueWA = new double[len];
            valueWA[0] = -32.26;
            valueWA[1] = -27.50;
            valueWA[2] = -22.80;
            valueWA[3] = -17.95;
            valueWA[4] = -12.97;
            valueWA[5] = -9;
            valueWA[6] = -0.31;
            valueWA[7] = 3.77;
            valueWA[8] = 8.57;
            valueWA[9] = 13.42;
            valueWA[10] = 18.28;
            double[] res = new double[len];
            res = ds.GetMassFunction(startValue, stopValue);
            CollectionAssert.AreEqual(valueWA, res);
        }
    }
}
