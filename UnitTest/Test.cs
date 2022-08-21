using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BusinessLayer;
using EntityLayer;
using InterfaceLayer;
using System.Configuration;

namespace UnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void LoadFileTest()
        {
            String FilePath = ConfigurationManager.AppSettings["FilePath"];
            FileloadInterface LoadFile = new LoadYaml();
            EntityClass[] entityClasses = LoadFile.Load(FilePath);  
            Assert.IsNotNull(entityClasses);
            Assert.AreEqual(3, entityClasses.Length);
        }

    }
}
