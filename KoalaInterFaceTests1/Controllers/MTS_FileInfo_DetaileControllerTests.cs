using Microsoft.VisualStudio.TestTools.UnitTesting;
using KoalaInterFace.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KoalaInterFace.Controllers.Tests
{
    [TestClass()]
    public class MTS_FileInfo_DetaileControllerTests
    {
        [TestMethod()]
        public void GetMTS_FileInfo_DetaileTest()
        {
            MTS_FileInfo_DetaileController mf = new MTS_FileInfo_DetaileController();
           string tr= mf.GetMTS_FileInfo_Detaile("", "");
            Assert.Fail();
        }
    }
}