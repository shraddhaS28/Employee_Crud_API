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
        /// TestCase 1
        /// </summary>
        [Test]
        public void GivenTestForEqualityFeetValueNullCheck_WhenAnalyse_ShouldReturnTrue()
        {
            Feet feet = new Feet();
            bool result = feet.Equals(null);
            Assert.IsTrue(result);
        }

        /// <summary>
        /// TestCase 2
        /// </summary>
        [Test]
        public void GivenTestForEqualityFeetValueReferenceCheck_WhenAnalyse_ShouldReturnTrue()
        {
            Feet feet = new Feet();
            bool result = feet.Equals(feet);
            Assert.IsTrue(result);
        }

        /// <summary>
        /// TestCase 3
        /// </summary>
        [Test]
        public void GivenTestForEqualityFeetValueTypeCheck_WhenAnalyse_ShouldReturnTrue()
        {
            Feet feet = new Feet();
            bool result = feet.Equals(new Feet());
            Assert.IsTrue(result);
        }

        /// <summary>
        /// TestCase 4
        /// </summary>
        [Test]
        public void GivenTestForEqualityFeetValueCheck_WhenAnalyse_ShouldReturnEqual()
        {
            Feet feet = new Feet(16);
            int result = feet.getValue();
            Assert.AreEqual(16, result);
        }

        /// <summary>
        /// TestCase 5
        /// </summary>
        [Test]
        public void GivenTestForEqualityInchValueNullCheck_WhenAnalyse_ShouldReturnTrue()
        {
            Inch inch = new Inch();
            bool result = inch.Equals(null);
            Assert.IsTrue(result);
        }

        /// <summary>
        /// TestCase 6
        /// </summary>
        [Test]
        public void GivenTestForEqualityInchValueReferenceCheck_WhenAnalyse_ShouldReturnTrue()
        {
            Inch inch = new Inch();
            bool result = inch.Equals(inch);
            Assert.IsTrue(result);
        }

        /// <summary>
        /// TestCase 7
        /// </summary>
        [Test]
        public void GivenTestForEqualityInchValueTypeCheck_WhenAnalyse_ShouldReturnTrue()
        {
            Inch inch = new Inch();
            bool result = inch.Equals(new Inch());
            Assert.IsTrue(result);
        }

        /// <summary>
        /// TestCase 8
        /// </summary>
        [Test]
        public void GivenTestForEqualityInchValueCheck_WhenAnalyse_ShouldReturnEqual()
        {
            Inch inch = new Inch(19);
            int result = inch.getValue();
            Assert.AreEqual(19, result);
        }

        /// <summary>
        /// TestCase 9
        /// </summary>
        [Test]
        public void Given1FeetIsEqualTo1Feet_WhenAnalyse_ShouldReturnEqual()
        {
            Feet feet = new Feet(1);
            int expected = 1;
            int actual = feet.getValue();
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// TestCase 10
        /// </summary>
        [Test]
        public void Given1FeetIsEqualTo12Inch_WhenAnalyse_ShouldReturnEqual()
        {
            Feet feet = new Feet(1);
            MeasurementConversion conversion = new MeasurementConversion();
            int expected = feet.getValue();
            int actual = conversion.ConvertFromInchToFeet(12);
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// TestCase 11
        /// </summary>
        [Test]
        public void Given1FeetIsNotEqualTo2Feet_WhenAnalyse_ShouldReturnNotEqual()
        {
            Feet feet = new Feet(2);
            int expected = 1;
            int actual = feet.getValue();
            Assert.AreNotEqual(expected, actual);
        }

        /// <summary>
        /// TestCase 12
        /// </summary>
        [Test]
        public void Given1FeetIsEqualTo24Inch_WhenAnalyse_ShouldReturnNotEqual()
        {
            Feet feet = new Feet(1);
            MeasurementConversion conversion = new MeasurementConversion();
            int expected = feet.getValue();
            int actual = conversion.ConvertFromInchToFeet(24);
            Assert.AreNotEqual(expected, actual);
        }

        /// <summary>
        /// TestCase 13
        /// </summary>
        [Test]
        public void GivenTestForEqualityKGValueNullCheck_WhenAnalyse_ShouldReturnTrue()
        {
            KiloGram kg = new KiloGram();
            bool result = kg.Equals(null);
            Assert.IsTrue(result);
        }
    }
}