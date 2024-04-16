using NUnit.Framework.Interfaces;
using Prime.Services;

namespace PrimeService.Tests;
    public class Tests
    {
        private Test obj;
        [SetUp]
        public void Setup()
        {
            obj = new Test();
        }

        [TestCase(new int[] { 2, 0, 1, 6 }, new int[] { 0, 1, 2, 6 })]
        [TestCase(new int[] { -10, 6, -1, 2 }, new int[] { -10, -1, 2, 6 })]
        [TestCase(new int[] { -9, 0, 4, 2 }, new int[] { -9, 0, 2, 4 })]
        [TestCase(new int[] { }, new int[] { -1 })]
        public void Bubble(int[] array, int[] res)
        {
            Assert.AreEqual(res, obj.Bubble(array));
        }

        [TestCase("1221", true)]
        [TestCase("1212", false)]
        [TestCase("1", true)]
        [TestCase("", false)]
        public void Palindrome(string str, bool res)
        {
            Assert.AreEqual(res, obj.Palindrome(str));
        }

        [TestCase(-12, -1)]
        [TestCase(1000, -1)]
        [TestCase(4, 24)]
        [TestCase(6, 720)]
        public void Factorial(int number, int res)
        {
            Assert.AreEqual(res, obj.Factorial(number));
        }
        [TestCase(0, 0)]
        [TestCase(-12, -1)]
        [TestCase(1000, -1)]
        [TestCase(3, 2)]
        public void Fibonachi(int number, int res)
        {
            Assert.AreEqual(res, obj.Fibonachi(number));
        }
        
        [TestCase("", "", true)]
        [TestCase("qwer1ty", "1", true)]
        [TestCase("", "a", false)]
        [TestCase("qwerty", "", false)]
        public void Substring(string str, string sub, bool res)
        {
            Assert.AreEqual(res, obj.Substring(str, sub));
        }

        [TestCase(-12, false)]
        [TestCase(12, false)]
        [TestCase(3, true)]
        [TestCase(100, false)]
        public void PrimeNumber(int number, bool res)
        {
            Assert.AreEqual(res, obj.PrimeNumber(number));
        }

        [TestCase(-12, -21)]
        [TestCase(-1, -1)]
        [TestCase(1000, 1)]
        [TestCase(2147483647, 0)]
        [TestCase(0, 0)]
        public void ReverseNumber(int number, int res)
        {
            Assert.AreEqual(res, obj.ReverseNumber(number));
        }

        [TestCase(1, "I")]
        [TestCase(2, "II")]
        [TestCase(100, "C")]
        [TestCase(1010, "MX")]
        [TestCase(0, "N")]
        [TestCase(-1000, "error")]
        [TestCase(4000, "error")]
        public void RomanNumber(int n, string res)
        {
            Assert.AreEqual(res, obj.RomanNumber(n));
        }
    }