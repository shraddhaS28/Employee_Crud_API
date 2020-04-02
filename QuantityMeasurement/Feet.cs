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
        /// Overridden equals method
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override bool Equals(object obj)
        {
            if ((obj == null) || object.ReferenceEquals(this, obj) || this.GetType().Equals(obj.GetType()))
                return true;
            else
                return false;

        }

        public int isValueEqual()
        {
            return this.feetValue;
        }
    }
}
