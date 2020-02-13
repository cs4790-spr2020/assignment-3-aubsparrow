using Microsoft.VisualStudio.TestTools.UnitTesting;
using BlabberApp.Domain;

namespace BlabberApp.DomainTest
{
    [TestClass]
    public class BlabTest
    {
        [TestMethod]
        public void TestSetGetMessage()
        {
            //arrange
            Blab harness = new Blab();
            string expected = "Neque porro quisquam est qui dolorem ipsum quia dolor sit amet, consectetur, adipisci velit...";
            harness.Message = "Neque porro quisquam est qui dolorem ipsum quia dolor sit amet, consectetur, adipisci velit...";
            //act
            string actual = harness.Message;
            //assert
            Assert.AreEqual(actual, expected);
        }

        [TestMethod]
        public void TestSetGetUserId()
        {
            //arrange
            Blab harness = new Blab();
            string expected = "e7200232-aad5-4521-8075-034825f7f76f";
            harness.UserID = "e7200232-aad5-4521-8075-034825f7f76f";
            //act
            string actual = harness.UserID;
            //assert
            Assert.AreEqual(actual, expected);
        }

        [TestMethod]
        public void TestGetSysId()
        {
            Blab harness = new Blab();
            //string expected = "";
            //act & assert
            Assert.IsInstanceOfType(harness.getSysId(), typeof(string));
            //his way:
            //Assert.AreEqual(true, harness.getSysId() is string);
        }

    }
}
