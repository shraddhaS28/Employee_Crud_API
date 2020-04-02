namespace QuantityMeasurement
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// Feet Class 
    /// </summary>
    public class Feet
    {
        /// <summary>
        /// value of feet parameter
        /// </summary>
        private int feetValue;

        /// <summary>
        /// object type to check for null feet value.
        /// </summary>
        private object o;

        public Feet()
        {

        }

        /// <summary>
        /// Parameterized Constructor(Int Type)
        /// </summary>
        /// <param name="feetValue"></param>
        public Feet(int feetValue)
        {
            this.feetValue = feetValue;
        }

        /// <summary>
        /// Parameterized Constructor(object Type)
        /// </summary>
        /// <param name="o"></param>
        public Feet(object o)
        {
            this.o = o;
        }

        /// <summary>
        /// Overridden equals method
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override bool Equals(object obj)
        {
            if (obj == null)
                return false;
            else
                return true;

        }

        public bool checkFeetValue(Feet feetValue)
        {
            if (this.feetValue.Equals(feetValue.feetValue))
                return true;
            else
                return false;
        }
    }
}
