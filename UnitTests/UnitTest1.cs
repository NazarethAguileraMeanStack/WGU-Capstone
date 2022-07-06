using Microsoft.VisualStudio.TestTools.UnitTesting;
using SchedulingSoftware;

namespace UnitTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestPhoneNumber_10Digits()
        {
            string correctInput1 = "9991114545";
            bool testCaseCorrect1 = SchedulingSoftware.FormInputValidator.checkCustomerPhoneNumber(correctInput1);
            Assert.AreEqual(true, testCaseCorrect1);
        }

        [TestMethod]
        public void TestPhoneNumber_7Digits() {
            string correctInput2 = "9472610";
            bool testCaseCorrect2 = SchedulingSoftware.FormInputValidator.checkCustomerPhoneNumber(correctInput2);
            Assert.AreEqual(true, testCaseCorrect2);
        }

        [TestMethod]
        public void TestPhoneNumber_stringInput() {
            string lettersInput = "jfiasojfiosdjifo";
            bool testCaseLetters = SchedulingSoftware.FormInputValidator.checkCustomerPhoneNumber(lettersInput);
            Assert.AreEqual(false, testCaseLetters);
        }

        [TestMethod]
        public void TestPhoneNumber_tooManyNumbers() {
            string tooLong = "1389120839081928390182938192083910283908192083109283";
            bool testCaseTooLong = SchedulingSoftware.FormInputValidator.checkCustomerPhoneNumber(tooLong);
            Assert.AreEqual(false, testCaseTooLong);
        }

        [TestMethod]
        public void TestPhoneNumber_notEnoughNumbers() {
            string tooShort = "38";
            bool testCaseTooShort = SchedulingSoftware.FormInputValidator.checkCustomerPhoneNumber(tooShort);
            Assert.AreEqual(false, testCaseTooShort);
        }

        [TestMethod]
        public void TestPhoneNumber_mixedInput() {
            string mixedInput = "B9991114545";
            bool testCaseMixed = SchedulingSoftware.FormInputValidator.checkCustomerPhoneNumber(mixedInput);
            Assert.AreEqual(false, testCaseMixed);
        }

    }
}
