using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Lab6;
using ClassLibrary1;

namespace TranslatorTest
{
    [TestClass]
    public class TranslatorTest
    {
        [TestMethod]
        public void TestThatAppleTranslatesToApplewat()
        {
            string toTranslateApple = "apple";
            //Class1 brad = new Class1();
            string TranslatedString1 = Class1.PigLat(toTranslateApple);
            Assert.AreEqual("appleway", TranslatedString1);
        }
        [TestMethod]
        public void TestBreadToEadbray()
        {
            string toTranslateBread = "bread";
            //Class1 diego = new Class1();
            string TranslatedString2 = Class1.PigLat(toTranslateBread);
            Assert.AreEqual("eadbray", TranslatedString2);
        }
        [TestMethod]
        public void TestScrapToApscray()
        {
            string toTranslateLaptop = "scrap";
            //Class1 dora = new Class1();
            string TranslatedString3 = Class1.PigLat(toTranslateLaptop);
            Assert.AreEqual("apscray", TranslatedString3);
        }
        [TestMethod]
        public void TestLaptopToAptoplay()
        {
            string toTranslateLaptop = "laptop";
            Class1 boots = new Class1();
            string TranslatedString3 = Class1.PigLat(toTranslateLaptop);
            Assert.AreEqual("aptoplay", TranslatedString3);
        }
    }
}