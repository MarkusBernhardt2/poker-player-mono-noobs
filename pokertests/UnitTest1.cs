using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Nancy.Simple;

namespace pokertests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void BetRequestReturnsValue()
        {

            Assert.AreEqual(5,  PokerPlayer.BetRequest(null));


        }
    }
}
