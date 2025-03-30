using Microsoft.VisualStudio.TestTools.UnitTesting;
using StrandC;
using System;

namespace StrandTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Strand1()
        {
            Furdo furdo1 = new Furdo("Gyulai Várfürdő", "5700 Gyula, Várfürdő u. 1.", 6000, 36);
            Assert.AreEqual("Gyula", furdo1.Telepules());
        }
    }
}
