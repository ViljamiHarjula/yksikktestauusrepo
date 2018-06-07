using Microsoft.VisualStudio.TestTools.UnitTesting;
using hetu;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace hetu.Tests
{
    [TestClass()]
    public class hetuntarkistusTests
    {
        [TestMethod()]
        public void HeTuOkTest()
        {
            hetuntarkistus t = new hetuntarkistus();
            string hetu = "12121233";
            bool expected = true;
            bool actual = t.HeTuOk(hetu);
            Assert.AreEqual(expected, actual, "Joku pielessä, pitäisi olla ok hetu");
            // klljll
            //Assert.Fail();
        }
    }
}