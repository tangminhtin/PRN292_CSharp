using Microsoft.VisualStudio.TestTools.UnitTesting;
using DemoCodePhanHe.Management;
using System;
using System.Collections.Generic;
using System.Text;

namespace DemoCodePhanHe.Management.Tests
{
    [TestClass()]
    public class MonHocManagerTests
    {

        [TestMethod()]
        public void insertMonHocTest()
        {
            MonHocManager monHocManager = new MonHocManager();
            Assert.AreEqual(true, monHocManager.insertMonHoc("OOP192", "FALL", "C#", 1, 2, 3));
        }
        
        [TestMethod()]
        public void insertMonHocTest1()
        {
            MonHocManager monHocManager = new MonHocManager();
            Assert.AreEqual(false, monHocManager.insertMonHoc("PRN292", "FALL", "C#", 1, 2, 3));
        }

        [TestMethod()]
        public void updateMonHocTest()
        {
            MonHocManager monHocManager = new MonHocManager();
            Assert.AreEqual(true, monHocManager.updateMonHoc("PRN292", "abc", "java", 1, 2, 3));
        }
    }
}