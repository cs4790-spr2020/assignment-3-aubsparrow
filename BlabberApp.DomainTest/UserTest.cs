using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BlabberApp.Domain;

namespace BlabberApp.DomainTest
{
    [TestClass]
    public class UserTest
    {
        [TestMethod]
        public void TestSetGetUserID_Success()
        {
            //arragne
            User harness = new User();
            string expected = "foobar@example.com";
            harness.UserID = "foobar@example.com";
            //act
            string actual = harness.UserID;
            Assert.AreEqual(actual, expected);
        }

        [TestMethod]
        public void TestGetUserID_Fail_0()
        {
            //arrange
            User harness = new User();
            //act
            var ex = Assert.ThrowsException<FormatException>(() => harness.UserID = "foobar");
            //assert
            Assert.AreEqual("not an email", ex.Message);
        }

        [TestMethod]
        public void TestGetUserID_Fail_1()
        {
            //arrange
            User harness = new User();
            //act
            var ex = Assert.ThrowsException<FormatException>(() => harness.UserID = "example.com");
            //assert
            Assert.AreEqual("not an email", ex.Message);
        }

         [TestMethod]
        public void TestGetSysId()
        {
            User harness = new User();
            string expected = harness.getSysId();
            //act & assert
            string actual = harness.getSysId();
            Assert.AreEqual(actual, expected);
            Assert.IsInstanceOfType(harness.getSysId(), typeof(string));
        }


    }

}