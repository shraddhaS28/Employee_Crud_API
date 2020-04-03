// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Tests.cs" company="Bridgelabz">
// Copyright © 2020 Company="BridgeLabz".
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
        public void Given_0_and_0_Feet_When_Analyse_Should_Return_Equal()
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
        public void Given_0_and_0_Inch_When_Analyse_Should_Return_Equal()
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
        /// TestCase 1.11/1.12(Refactor)
        /// </summary>
        [Test]
        public void Test_For_Equality_Value_Check_For_Inch()
        {
            UnitCheck inch = new UnitCheck(19);
            int result = inch.isValueEqual();
            Assert.AreEqual(19, result);
        }

        /// <summary>
        /// TestCase 1.13
        /// </summary>
        [Test]
        public void Give_0_Feet_and_0_Inch_When_Analyze_Should_Return_Equal()
        {
            Feet feet = new Feet(0);
            int expected = feet.isValueEqual();
            Inch inch = new Inch(0);
            int actual = inch.isValueEqual();
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// TestCase 1.14
        /// </summary>
        [Test]
        public void Compare_1feet_Not_Equal_to_1inch_When_Analyze_return_False()
        {
            int expected = 1;
            UnitCheck check = new UnitCheck();
            int actual = check.ConvertFromFeetToInch(expected);
            Assert.AreNotEqual(expected, actual);
        }

        /// <summary>
        /// TestCase 1.15
        /// </summary>
        [Test]
        public void Compare_1Inch_Not_Equal_to_1Feet_When_Analyze_return_False()
        {
            int expected = 1;
            UnitCheck check = new UnitCheck();
            int actual = check.ConvertFromInchToFeet(expected);
            Assert.AreNotEqual(expected, actual);
        }

        /// <summary>
        /// TestCase 1.16
        /// </summary>
        [Test]
        public void Compare_1feet_Equal_to_12inch_When_Analyze_return_True()
        {
            int expected = 12;
            UnitCheck check = new UnitCheck();
            int actual = check.ConvertFromFeetToInch(1);
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// TestCase 1.17
        /// </summary>
        [Test]
        public void Compare_12Inch_Equal_to_1Feet_When_Analyze_return_True()
        {
            int expected = 1;
            UnitCheck check = new UnitCheck();
            int actual = check.ConvertFromInchToFeet(12);
            Assert.AreEqual(expected, actual);
        }
        
        /// <summary>
        /// TestCase 1.18
        /// </summary>
        [Test]
        public void Compare_3feet_Equal_to_1yard_When_Analyze_return_True()
        {
            int expected = 1;
            UnitCheck check = new UnitCheck();
            int actual = check.ConvertFromFeetToYard(3);
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// TestCase 1.19
        /// </summary>
        [Test]
        public void Compare_1feet_Not_Equal_to_1yard_When_Analyze_return_False()
        {
            int expected = 1;
            UnitCheck check = new UnitCheck();
            int actual = check.ConvertFromFeetToYard(expected);
            Assert.AreNotEqual(expected, actual);
        }

        /// <summary>
        /// TestCase 1.20
        /// </summary>
        [Test]
        public void Compare_1Inch_Not_Equal_to_1yard_When_Analyze_return_False()
        {
            int expected = 1;
            UnitCheck check = new UnitCheck();
            int actual = check.ConvertFromInchToYard(expected);
            Assert.AreNotEqual(expected, actual);
        }

        /// <summary>
        /// TestCase 1.21
        /// </summary>
        [Test]
        public void Compare_1yard_Equal_to_36Inch_When_Analyze_return_True()
        {
            int expected = 36;
            UnitCheck check = new UnitCheck();
            int actual = check.ConvertFromYardToInch(1);
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// TestCase 1.22
        /// </summary>
        [Test]
        public void Compare_36inch_Equal_to_1Yard_When_Analyze_return_True()
        {
            int expected = 1;
            UnitCheck check = new UnitCheck();
            int actual = check.ConvertFromInchToYard(36);
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// TestCase 1.23/1.24(Refactor)
        /// </summary>
        [Test]
        public void Compare_1yard_Equal_to_3feet_When_Analyze_return_True()
        {
            int expected = 3;
            UnitCheck check = new UnitCheck();
            int actual = check.ConvertFromYardToFeet(1);
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// TestCase 25
        /// </summary>
        [Test]
        public void Compare_1feet_To_1feet_When_Analyze_Should_return_Equal()
        {
            Feet feet = new Feet(1);
            int expected = feet.isValueEqual();
            UnitCheck feetValue = new UnitCheck(1);
            int actual = feetValue.isValueEqual();
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// TestCase 26
        /// </summary>
        [Test]
        public void Compare_1feet_To_2feet_When_Analyze_Should_return_False()
        {
            Feet feet = new Feet(1);
            int expected = feet.isValueEqual();
            UnitCheck feetValue = new UnitCheck(2);
            int actual = feetValue.isValueEqual();
            Assert.AreNotEqual(expected, actual);
        }
        
        /// <summary>
        /// TestCase 27
        /// </summary>
        [Test]
        public void Compare_1feet_To_24inch_When_Analyze_Should_return_False()
        {
            UnitCheck feet = new UnitCheck();
            int actual = feet.ConvertFromFeetToInch(1);
            int expected = 24;
            Assert.AreNotEqual(expected, actual);
        }

        /// <summary>
        /// TestCase 28
        /// </summary>
        [Test]
        public void Compare_1gram_To_1gram_When_Analyze_Should_return_Equal()
        {
            UnitCheck gramValue = new UnitCheck(1);
            int expected = 1;
            int actual = gramValue.isValueEqual();
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// TestCase 29
        /// </summary>
        [Test]
        public void Compare_1kilogram_To_1000gram_When_Analyze_Should_return_Equal()
        {
            UnitCheck gramValue = new UnitCheck(1);
            int expected = 1000;
            int actual = gramValue.ConvertFromKGtoGram(1);
            Assert.AreEqual(expected, actual);
        }
    }
}