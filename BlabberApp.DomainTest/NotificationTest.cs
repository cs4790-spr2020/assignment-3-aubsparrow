using Microsoft.VisualStudio.TestTools.UnitTesting;
using BlabberApp.Domain;

namespace BlabberApp.DomainTest
{
    [TestClass]
    public class NotificationTest
    {
        [TestMethod]
        public void TestSetDateTime()
        {
            Notification harness = new Notification();
            System.DateTime expectedTime = System.DateTime.Now;
            harness.RegDTTM = expectedTime;
            System.DateTime actualTime = harness.RegDTTM;
            Assert.AreEqual(expectedTime, actualTime);
        }

        [TestMethod]
        public void TestContentText()
        {
            Notification harness = new Notification();
            string expectedText = "Neque porro quisquam est qui dolorem ipsum quia dolor sit amet, consectetur, adipisci velit...";
            harness.ContentText = "Neque porro quisquam est qui dolorem ipsum quia dolor sit amet, consectetur, adipisci velit...";
            string actualText = harness.ContentText;
            Assert.AreEqual(expectedText, actualText);
        }

        [TestMethod]
        public void TestContentTitle()
        {
             Notification harness = new Notification();
            string expectedTitle = "Lorem Ipsum";
            harness.ContentTitle = "Lorem Ipsum";
            string actualTitle = harness.ContentTitle;
            Assert.AreEqual(expectedTitle, actualTitle);
        }
    }

}