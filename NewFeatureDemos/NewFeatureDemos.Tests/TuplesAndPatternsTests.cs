using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace NewFeatureDemos.Tests
{
    [TestClass]
    public class TuplesAndPatternsTests
    {
        [DataTestMethod]
        [DataRow(1900, false)]
        [DataRow(2000, true)]
        [DataRow(2003, false)]
        [DataRow(2004, true)]
        public void TestLeapYearIf(int year, bool shouldBeLeapYear)
        {
            var isLeapYear = TuplesAndPatterns.LeapYearIf(year);
            Assert.AreEqual(shouldBeLeapYear, isLeapYear);
        }

        [DataTestMethod]
        [DataRow(1900, false)]
        [DataRow(2000, true)]
        [DataRow(2003, false)]
        [DataRow(2004, true)]
        public void TestLeapYearTuplePatterns(int year, bool shouldBeLeapYear)
        {
            var isLeapYear = TuplesAndPatterns.LeapYearTuplePatterns(year);
            Assert.AreEqual(shouldBeLeapYear, isLeapYear);
        }

        [TestMethod]
        public void TestVipPatrickDoesntGetBeta()
        {
            var result = TuplesAndPatterns.ElligibleForBetaAccess((true, false, true, 1, "Patrick"));
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void TestVipGetsBeta()
        {
            var result = TuplesAndPatterns.ElligibleForBetaAccess((true, false, true, 1, "Karl"));
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void TestNonVipPatrickGetsBeta()
        {
            var result = TuplesAndPatterns.ElligibleForBetaAccess((true, true, false, 1, "Patrick"));
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void TestUserUnder10000GetsAccess()
        {
            var result = TuplesAndPatterns.ElligibleForBetaAccess((true, true, false, 1, "Hans"));
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void TestUserUnder10000GetsNoAccessWhenNotRequested()
        {
            var result = TuplesAndPatterns.ElligibleForBetaAccess((false, true, false, 1, "Hans"));
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void TestUserUnder10000GetsNoAccessWhenNotAttended()
        {
            var result = TuplesAndPatterns.ElligibleForBetaAccess((true, false, false, 1, "Hans"));
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void TestUserOver10000GetsNoAccess()
        {
            var result = TuplesAndPatterns.ElligibleForBetaAccess((true, true, false, 10001, "Hans"));
            Assert.IsFalse(result);
        }
    }
}