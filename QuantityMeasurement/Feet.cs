﻿namespace QuantityMeasurement
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
        /// Parameterized Constructor
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
            if (feetValue.Equals(obj))
                return true;
            else
                return false;

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
