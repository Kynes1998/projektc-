using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using restauranttest;



namespace TestyJednostkowe
{
    [TestClass]
    public class Testy
    {
        [TestMethod]
        public void TestMethod1()
        {

            //arrange
            Form1 form = new Form1();
            double testZmiennejTotal = form.iTotal;


            //act
            double podatek = (form.iSubTotal * 3.9) / 100;
            double poprawneObliczenia = form.iSubTotal + podatek;

            //assert

            Assert.AreEqual(testZmiennejTotal, poprawneObliczenia);




        }

        [TestMethod]
        public void TestMethod2()
        {

            //arrange
            Form1 form = new Form1();
            double zmiennaChange = form.iChange;
            double poprawnaWartoscReszty = form.cost;

            //act
            double podatek = (form.iSubTotal * 3.9) / 100;
            double sprawdzenieReszty = zmiennaChange - podatek;

            //assert

            Assert.AreEqual(poprawnaWartoscReszty, sprawdzenieReszty);




        }
    }
}
