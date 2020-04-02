// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Tests.cs" company="Bridgelabz">
// Copyright � 2020 Company="BridgeLabz".
// </copyright>
// <creator name="Shraddha Singh"/>
// --------------------------------------------------------------------------------------------------------------------

namespace NUnitTest_QuantityMeasurement
{
    using NUnit.Framework;
    using QuantityMeasurement;

    /// <summary>
    /// Test Case Class
    /// </summary>
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        /// <summary>
        /// TestCase 1.1
        /// </summary>
        [Test]
        public void Given_0_and_0_Feet_WhenAnalyse_Should_Return_Equal()
        {
            int expected = 0;
            UnitCheck feet = new UnitCheck(0);
            int actual = feet.isValueEqual();
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// TestCase 1.2
        /// </summary>
        [Test]
        public void Test_For_Equality_Null_Check_For_Feet()
        {
            UnitCheck feet = new UnitCheck();
            bool result = feet.Equals(null);
            Assert.IsTrue(result);
        }

        /// <summary>
        /// TestCase 1.3
        /// </summary>
        [Test]
        public void Test_For_Equality_Reference_Check_For_Feet()
        {
            UnitCheck feet = new UnitCheck();
            bool result = feet.Equals(feet);
            Assert.IsTrue(result);
        }

        /// <summary>
        /// TestCase 1.4
        /// </summary>
        [Test]
        public void Test_For_Equality_Type_Check_For_Feet()
        {
            UnitCheck feet = new UnitCheck();
            bool result = feet.Equals(new UnitCheck());
            Assert.IsTrue(result);
        }

        /// <summary>
        /// TestCase 1.5/1.6(Refactor)
        /// </summary>
        [Test]
        public void Test_For_Equality_Value_Check_For_Feet()
        {
            UnitCheck feet = new UnitCheck(16);
            int result = feet.isValueEqual();
            Assert.AreEqual(16, result);
        }

        /// <summary>
        /// TestCase 1.7
        /// </summary>
        [Test]
        public void Given_0_and_0_Inch_WhenAnalyse_Should_Return_Equal()
        {
            int expected = 0;
            UnitCheck inch = new UnitCheck(0);
            int actual = inch.isValueEqual();
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// TestCase 1.8
        /// </summary>
        [Test]
        public void Test_For_Equality_Null_Check_For_Inch()
        {
            UnitCheck inch = new UnitCheck();
            bool result = inch.Equals(null);
            Assert.IsTrue(result);
        }

        /// <summary>
        /// TestCase 1.9
        /// </summary>
        [Test]
        public void Test_For_Equality_Reference_Check_For_Inch()
        {
            UnitCheck inch = new UnitCheck();
            bool result = inch.Equals(inch);
            Assert.IsTrue(result);
        }

        /// <summary>
        /// TestCase 1.10
        /// </summary>
        [Test]
        public void Test_For_Equality_Type_Check_For_Inch()
        {
            UnitCheck inch = new UnitCheck();
            bool result = inch.Equals(new UnitCheck());
            Assert.IsTrue(result);
        }

        /// <summary>
        /// TestCase 1.11
        /// </summary>
        [Test]
        public void Test_For_Equality_Value_Check_For_Inch()
        {
            UnitCheck inch = new UnitCheck(19);
            int result = inch.isValueEqual();
            Assert.AreEqual(19, result);
        }
    }
}