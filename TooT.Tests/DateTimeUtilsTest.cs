using TooT;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace TooT.Tests
{
    
    
    /// <summary>
    ///Se trata de una clase de prueba para DateTimeUtilsTest y se pretende que
    ///contenga todas las pruebas unitarias DateTimeUtilsTest.
    ///</summary>
    [TestClass()]
    public class DateTimeUtilsTest
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
        ///Una prueba de TodayWeekNumber
        ///</summary>
        [TestMethod()]
        public void TodayWeekNumberTest()
        {
            int expected = 5;
            int actual = DateTimeUtils.TodayWeekNumber();

            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        ///Una prueba de MonthToInt
        ///</summary>
        [TestMethod()]
        public void MonthToIntTest()
        {
            string name = "Enero";
            int expected = 1;
            int actual = DateTimeUtils.MonthToInt(name);

            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        ///Una prueba de MinutesToString
        ///</summary>
        [TestMethod()]
        public void MinutesToStringTest()
        {
            int m = 123;
            string expected = "2 horas, 3 minutos";
            string actual = DateTimeUtils.MinutesToString(m);
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        ///Una prueba de IsValidMonth
        ///</summary>
        [TestMethod()]
        public void IsValidMonthTest()
        {
            int m1 = 0;
            int m2 = 1;
            int m3 = 12;
            int m4 = 13;

            Assert.IsFalse(DateTimeUtils.IsValidMonth(m1));
            Assert.IsTrue(DateTimeUtils.IsValidMonth(m2));
            Assert.IsTrue(DateTimeUtils.IsValidMonth(m3));
            Assert.IsFalse(DateTimeUtils.IsValidMonth(m4));
        }

        /// <summary>
        ///Una prueba de DaysInWeek
        ///</summary>
        [TestMethod()]
        public void DaysInWeekTest()
        {
            int week = 1;
            int year = 2018;
            List<DateTime> expected = new List<DateTime>();
            expected.Add(new DateTime(2018, 1, 1));
            expected.Add(new DateTime(2018, 1, 2));
            expected.Add(new DateTime(2018, 1, 3));
            expected.Add(new DateTime(2018, 1, 4));
            expected.Add(new DateTime(2018, 1, 5));
            expected.Add(new DateTime(2018, 1, 6));
            expected.Add(new DateTime(2018, 1, 7));
            List<DateTime> actual = DateTimeUtils.DaysInWeek(week, year);

            foreach (DateTime d in actual)
                Assert.IsTrue(expected.Contains(d));
        }

        /// <summary>
        ///Una prueba de DayWeekNumber
        ///</summary>
        [TestMethod()]
        public void DayWeekNumberTest()
        {
            DateTime day = new DateTime(2018, 1, 1);
            int expected = 1;
            int actual = DateTimeUtils.DayWeekNumber(day);

            Assert.AreEqual(expected, actual);
        }
    }
}
