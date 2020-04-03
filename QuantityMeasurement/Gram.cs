// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Gram.cs" company="Bridgelabz">
// Copyright © 2020 Company="BridgeLabz".
// </copyright>
// <creator name="Shraddha Singh"/>
// --------------------------------------------------------------------------------------------------------------------

namespace QuantityMeasurement
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// Gram class
    /// </summary>
    public class Gram
    {
        /// <summary>
        /// private parameter
        /// </summary>
        private double gramValue;

        /// <summary>
        /// Method to get gram value
        /// </summary>
        /// <param name="gramValue"></param>
        /// <returns> double value </returns>
        public double GetValue(double gramValue)
        {
            this.gramValue = gramValue;
            return this.gramValue;
        }

        /// <summary>
        /// Overridden Equals method
        /// </summary>
        /// <param name="obj"></param>
        /// <returns>True or false</returns>
        public override bool Equals(object obj)
        {
            if ((obj == null) || object.ReferenceEquals(this, obj) || this.GetType().Equals(obj.GetType()))
                return true;
            return false;
        }
    }
}
