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
            Feet feet = new Feet(0);
            int actual = feet.isValueEqual();
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// TestCase 1.2
        /// </summary>
        [Test]
        public void Test_For_Equality_Null_Check_For_Feet()
        {
            Feet feet = new Feet();
            bool result = feet.Equals(null);
            Assert.IsTrue(result);
        }

        /// <summary>
        /// TestCase 1.3
        /// </summary>
        [Test]
        public void Test_For_Equality_Reference_Check_For_Feet()
        {
            Feet feet = new Feet();
            bool result = feet.Equals(feet);
            Assert.IsTrue(result);
        }

        /// <summary>
        /// TestCase 1.4
        /// </summary>
        [Test]
        public void Perform_Test_For_Equality_Type_Check()
        {
            Feet feet = new Feet();
            bool result = feet.Equals(new Feet());
            Assert.IsTrue(result);
        }

        /// <summary>
        /// TestCase 1.5
        /// </summary>
        [Test]
        public void Perform_Test_For_Equality_Value_Check()
        {
            Feet feet = new Feet(16);
            int result = feet.isValueEqual();
            Assert.AreEqual(16, result);
        }
    }
}