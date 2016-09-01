using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Lab6;
using ClassLibrary1;

namespace TranslatorTest
{
    [TestClass]
    public class TranslatorTest
    {
        //-----Vowel beginning-----
        [TestMethod]
        public void TestThatAppleTranslatesToApplewat()
        {
            string toTranslateApple = "apple";
            string TranslatedString1 = Class1.PigLat(toTranslateApple);
            Assert.AreEqual("appleway", TranslatedString1);
        }
        //-----2 Consonant beginning-----
        [TestMethod]
        public void TestBreadToEadbray()
        {
            string toTranslateBread = "bread";
            string TranslatedString2 = Class1.PigLat(toTranslateBread);
            Assert.AreEqual("eadbray", TranslatedString2);
        }
        //-----3 Consonant beginnning-----
        [TestMethod]
        public void TestScrapToApscray()
        {
            string toTranslateLaptop = "scrap";
            string TranslatedString3 = Class1.PigLat(toTranslateLaptop);
            Assert.AreEqual("apscray", TranslatedString3);
        }
        //-----1 Consonant beginning-----
        [TestMethod]
        public void TestLaptopToAptoplay()
        {
            string toTranslateLaptop = "laptop";
            string TranslatedString3 = Class1.PigLat(toTranslateLaptop);
            Assert.AreEqual("aptoplay", TranslatedString3);
        }
    }
}