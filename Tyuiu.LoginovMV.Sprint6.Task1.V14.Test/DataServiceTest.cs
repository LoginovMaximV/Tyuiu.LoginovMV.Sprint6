using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.LoginovMV.Sprint6.Task1.V14.Lib;

namespace Tyuiu.LoginovMV.Sprint6.Task1.V14.Test
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
            valueWA[0] = -2.15;
            valueWA[1] = -2.57;
            valueWA[2] = -3;
            valueWA[3] = -3.83;
            valueWA[4] = -11.7;
            valueWA[5] = 3;
            valueWA[6] = 2.19;
            valueWA[7] = 3.31;
            valueWA[8] = 2.97;
            valueWA[9] = 1.18;
            valueWA[10] = 0.03;
            double[] res = new double[len];
            res = ds.GetMassFunction(startValue, stopValue);
            CollectionAssert.AreEqual(valueWA, res);

        }
    }
}
