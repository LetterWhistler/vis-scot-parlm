using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using VisualScotParliament.Common;

namespace VisualScotParliament.UnitTests
{
    [TestClass]
    public class TWFYServiceTests
    {
        private const string apiKey = "HFnf8dD4HZVEAuxm4xFuRYZP";

        [TestMethod]
        public void TestGetMSPs()
        {
            TWFYService twfy = new TWFYService(apiKey);
            var msps = twfy.GetMSPs();
            //check that list of msps is not null
            Assert.IsNotNull(msps);
        }
    }
}
