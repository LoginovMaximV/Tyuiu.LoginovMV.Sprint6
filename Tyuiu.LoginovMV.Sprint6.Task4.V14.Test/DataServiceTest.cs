using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.LoginovMV.Sprint6.Task4.V14.Lib;

namespace Tyuiu.LoginovMV.Sprint6.Task4.V14.Test
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
            valueWA[0] = -19.62;
            valueWA[1] = -17.12;
            valueWA[2] = -18.15;
            valueWA[3] = -63.13;
            valueWA[4] = -24.92;
            valueWA[5] = -5;
            valueWA[6] = -1.46;
            valueWA[7] = 1.57;
            valueWA[8] = 6.38;
            valueWA[9] = 32.78;
            valueWA[10] = 225.11;
            double[] res = new double[len];
            res = ds.GetMassFunction(startValue, stopValue);
            CollectionAssert.AreEqual(valueWA, res);
        }
    }
}
