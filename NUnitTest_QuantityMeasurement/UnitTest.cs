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
            double result = feet.getValue();
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
            double result = inch.getValue();
            Assert.AreEqual(19, result);
        }

        /// <summary>
        /// TestCase 9
        /// </summary>
        [Test]
        public void Given1FeetIsEqualTo1Feet_WhenAnalyse_ShouldReturnEqual()
        {
            Feet feet = new Feet(1);
            double expected = 1;
            double actual = feet.getValue();
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
            double expected = feet.getValue();
            double actual = conversion.ConvertFromInchToFeet(12);
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// TestCase 11
        /// </summary>
        [Test]
        public void Given1FeetIsNotEqualTo2Feet_WhenAnalyse_ShouldReturnNotEqual()
        {
            Feet feet = new Feet(2);
            double expected = 1;
            double actual = feet.getValue();
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
            double expected = feet.getValue();
            double actual = conversion.ConvertFromInchToFeet(24);
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

        /// <summary>
        /// TestCase 14
        /// </summary>
        [Test]
        public void GivenTestForEqualityKGValueReferenceCheck_WhenAnalyse_ShouldReturnTrue()
        {
            KiloGram kg = new KiloGram(); 
            bool result = kg.Equals(kg);
            Assert.IsTrue(result);
        }

        /// <summary>
        /// TestCase 15
        /// </summary>
        [Test]
        public void GivenTestForEqualityKGValueTypeCheck_WhenAnalyse_ShouldReturnTrue()
        {
            KiloGram kg = new KiloGram();
            bool result = kg.Equals(new KiloGram());
            Assert.IsTrue(result);
        }

        /// <summary>
        /// TestCase 16
        /// </summary>
        [Test]
        public void GivenTestForEqualityKGValueCheck_WhenAnalyse_ShouldReturnEqual()
        {
            KiloGram kg = new KiloGram();
            double result = kg.getValue(16);
            Assert.AreEqual(16, result);
        }

        /// <summary>
        /// TestCase 17
        /// </summary>
        [Test]
        public void GivenTestForEqualityGramValueNullCheck_WhenAnalyse_ShouldReturnTrue()
        {
            Gram gm = new Gram();
            bool result = gm.Equals(null);
            Assert.IsTrue(result);
        }

        /// <summary>
        /// TestCase 18
        /// </summary>
        [Test]
        public void GivenTestForEqualityGramValueReferenceCheck_WhenAnalyse_ShouldReturnTrue()
        {
            Gram gm = new Gram();
            bool result = gm.Equals(gm);
            Assert.IsTrue(result);
        }

        /// <summary>
        /// TestCase 19
        /// </summary>
        [Test]
        public void GivenTestForEqualityGramValueTypeCheck_WhenAnalyse_ShouldReturnTrue()
        {
            Gram gm = new Gram();
            bool result = gm.Equals(new Gram());
            Assert.IsTrue(result);
        }

        /// <summary>
        /// TestCase 20
        /// </summary>
        [Test]
        public void GivenTestForEqualityGramValueCheck_WhenAnalyse_ShouldReturnEqual()
        {
            Gram gm = new Gram();
            double result = gm.getValue(16);
            Assert.AreEqual(16, result);
        }

        /// <summary>
        /// TestCase 21
        /// </summary>
        [Test]
        public void Given1GramIsEqualTo1Gram_WhenAnalyse_ShouldReturnEqual()
        {
            Gram gm = new Gram();
            double expected = 1;
            double actual = gm.getValue(1);
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// TestCase 22
        /// </summary>
        [Test]
        public void Given1KiloGramIsEqualTo1000Gram_WhenAnalyse_ShouldReturnEqual()
        {
            KiloGram kg = new KiloGram();
            MeasurementConversion conversion = new MeasurementConversion();
            double expected = kg.getValue(1);
            double actual = conversion.ConvertFromGramToKilogram(1000);
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// TestCase 23
        /// </summary>
        [Test]
        public void Given1GramIsNotEqualTo2Gram_WhenAnalyse_ShouldReturnNotEqual()
        {
            Gram gm = new Gram();
            double expected = 1;
            double actual = gm.getValue(2);
            Assert.AreNotEqual(expected, actual);
        }

        /// <summary>
        /// TestCase 24
        /// </summary>
        [Test]
        public void Given1KiloGramIsEqualTo2000Gram_WhenAnalyse_ShouldReturnNotEqual()
        {
            KiloGram kg = new KiloGram();
            MeasurementConversion conversion = new MeasurementConversion();
            double expected = kg.getValue(1);
            double actual = conversion.ConvertFromGramToKilogram(2000);
            Assert.AreNotEqual(expected, actual);
        }

        /// <summary>
        /// TestCase 25
        /// </summary>
        [Test]
        public void GivenTestForEqualityCelValueNullCheck_WhenAnalyse_ShouldReturnTrue()
        {
            Celsius cel = new Celsius();
            bool result = cel.Equals(null);
            Assert.IsTrue(result);
        }
    }
}