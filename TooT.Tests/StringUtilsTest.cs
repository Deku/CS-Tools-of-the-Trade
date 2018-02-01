using TooT;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace TooT.Tests
{
    
    
    /// <summary>
    ///Se trata de una clase de prueba para StringUtilsTest y se pretende que
    ///contenga todas las pruebas unitarias StringUtilsTest.
    ///</summary>
    [TestClass()]
    public class StringUtilsTest
    {


        private TestContext testContextInstance;

        /// <summary>
        ///Obtiene o establece el contexto de la prueba que proporciona
        ///la información y funcionalidad para la ejecución de pruebas actual.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        #region Atributos de prueba adicionales
        // 
        //Puede utilizar los siguientes atributos adicionales mientras escribe sus pruebas:
        //
        //Use ClassInitialize para ejecutar código antes de ejecutar la primera prueba en la clase 
        //[ClassInitialize()]
        //public static void MyClassInitialize(TestContext testContext)
        //{
        //}
        //
        //Use ClassCleanup para ejecutar código después de haber ejecutado todas las pruebas en una clase
        //[ClassCleanup()]
        //public static void MyClassCleanup()
        //{
        //}
        //
        //Use TestInitialize para ejecutar código antes de ejecutar cada prueba
        //[TestInitialize()]
        //public void MyTestInitialize()
        //{
        //}
        //
        //Use TestCleanup para ejecutar código después de que se hayan ejecutado todas las pruebas
        //[TestCleanup()]
        //public void MyTestCleanup()
        //{
        //}
        //
        #endregion


        /// <summary>
        ///Una prueba de CountFormatArgs
        ///</summary>
        [TestMethod()]
        public void CountFormatArgsTest()
        {
            string str1 = "The quick brown fox jumps over the lazy dog";
            string str2 = "The {0} {1} fox jumps over the {2} dog";
            string str3 = "The {0} {0} fox jumps over the {0} dog";

            Assert.AreEqual(0, StringUtils.CountFormatArgs(str1));
            Assert.AreEqual(3, StringUtils.CountFormatArgs(str2));
            Assert.AreEqual(1, StringUtils.CountFormatArgs(str3));
        }

        /// <summary>
        ///Una prueba de GetRandomString
        ///</summary>
        [TestMethod()]
        public void GetRandomStringTest()
        {
            int size = 8;
            string str = StringUtils.GetRandomString(size);
            Assert.AreEqual(size, str.Length);
        }

        /// <summary>
        ///Una prueba de GetSecureRandomString
        ///</summary>
        [TestMethod()]
        public void GetSecureRandomStringTest()
        {
            int size = 8;
            string str = StringUtils.GetSecureRandomString(size);
            Assert.AreEqual(size, str.Length);
        }

        /// <summary>
        ///Una prueba de IsStringFormat
        ///</summary>
        [TestMethod()]
        public void IsStringFormatTest()
        {
            string str1 = "The quick brown fox jumps over the lazy dog";
            string str2 = "The {0} {1} fox jumps over the {2} dog";

            Assert.IsFalse(StringUtils.IsStringFormat(str1));
            Assert.IsTrue(StringUtils.IsStringFormat(str2));
        }
    }
}
