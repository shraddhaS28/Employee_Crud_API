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
            int feetValue = 0;
            Feet feet = new Feet(feetValue);
            bool result = feet.checkFeetValue(new Feet(0));
            Assert.IsTrue(result);
        }

        /// <summary>
        /// TestCase 1.2
        /// </summary>
        [Test]
        public void Test_For_Equality_Null_Check_For_Feet()
        {
            Feet feet = new Feet(null);
            bool result = feet.Equals(new Feet(0));
            Assert.IsTrue(result);
        }

        [Test]
        public void Test_For_Equality_Reference_Check_For_Feet()
        {
            Feet feet = new Feet();
            bool result = feet.Equals(feet);
            Assert.IsTrue(result);
        }
    }
}