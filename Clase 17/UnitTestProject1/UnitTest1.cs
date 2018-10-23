using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Listas;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            MiLista<int> a = new MiLista<int>();
            bool exc = false;

            try
            {
                a.DatoDeMiLista = 3;
            }
            catch (Exception e)
            {
                exc = true;
            }

            Assert.IsTrue(exc);
        }

        [TestMethod]
        public void TestMethod2()
        {
            MiLista<int> lista = new MiLista<int>();
            lista.Add(4);
            lista.Add(40);
            Assert.IsTrue(lista.Count == 2);
            int i = 0;
            foreach (int item in lista)
            {
                Assert.AreEqual(item, lista[i]);
                i++;
            }

            MiLista<string> lista2 = new MiLista<string>();
            lista2.Add("4");
            lista2.Add("40");

            Assert.IsTrue(lista2.Count == 2);
        }
    }
}
