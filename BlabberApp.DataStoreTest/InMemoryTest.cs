using System.Collections;
using System.Collections.Generic;
using BlabberApp.Domain;
using BlabberApp.DataStore;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BlabberApp.DataStoreTest

{
    [TestClass]
    public class InMemoryTest
    {
        [TestMethod]
        public void TestAdd()
        {
            //act
            BaseDatum assert = new BaseDatum();
            InMemory mem = new InMemory();
            string expected = assert.getSysId();
            //arrange
            mem.Add(assert);
            //assert
            CollectionAssert.Contains(mem.Items, assert);
        }

        [TestMethod]
        public void TestDelete()
        {
            BaseDatum assert = new BaseDatum();
            InMemory mem = new InMemory();
            string expected = assert.getSysId();
            mem.Add(assert);
            mem.Delete(assert);
            CollectionAssert.DoesNotContain(mem.Items, assert);
        }

        [TestMethod]
        public void TestGetById()
        {
            BaseDatum expected = new BaseDatum();
            InMemory mem = new InMemory();
            mem.Add(expected);
            string id = expected.getSysId();
            BaseDatum actual = mem.GetByID<BaseDatum>(id);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestGetAll()
        {
            List<BaseDatum> expectedList = new List<BaseDatum>();
            BaseDatum dat1 = new BaseDatum();
            BaseDatum dat2 = new BaseDatum();
            BaseDatum dat3 = new BaseDatum();
            InMemory mem = new InMemory();
            mem.Add(dat1);
            mem.Add(dat2);
            mem.Add(dat3);
            expectedList.Add(dat1);
            expectedList.Add(dat2);
            expectedList.Add(dat3);
            CollectionAssert.AreEqual(expectedList, mem.GetAll<BaseDatum>());
        }

        [TestMethod]
        public void TestUpdate()
        {
            BaseDatum originalItem = new BaseDatum();
            InMemory mem = new InMemory();
            mem.Add(originalItem);
            BaseDatum newItem = new BaseDatum();
            mem.Update(originalItem, newItem);
        }
    }
}
