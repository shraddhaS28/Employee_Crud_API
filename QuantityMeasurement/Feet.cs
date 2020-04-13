// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Feet.cs" company="Bridgelabz">
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
    /// Feet Class 
    /// </summary>
    public class Feet
    {
        /// <summary>
        /// value of feet parameter
        /// </summary>
        private readonly double feetValue;

        /// <summary>
        /// Default Constructor
        /// </summary>
        public Feet()
        {

        }

        /// <summary>
        /// Parameterized Constructor
        /// </summary>
        /// <param name="feetValue"></param>
        public Feet(double feetValue)
        {
            this.feetValue = feetValue;
        }

        /// <summary>
        /// to get value
        /// </summary>
        /// <returns> updated parameter value </returns>
        public double GetValue()
        {
            return this.feetValue;
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
    }
}
