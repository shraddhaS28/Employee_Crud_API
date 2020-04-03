// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Inch.cs" company="Bridgelabz">
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
    /// Inch Class
    /// </summary>
    public class Inch
    {
        /// <summary>
        /// private value of inch
        /// </summary>
        private readonly double inchValue;

        /// <summary>
        /// Default Constructor
        /// </summary>
        public Inch()
        {
        }

        /// <summary>
        /// Parameterized Constructor
        /// </summary>
        /// <param name="inchValue"></param>
        public Inch(double inchValue)
        {
            this.inchValue = inchValue;
        }

        /// <summary>
        /// Method to get inch value
        /// </summary>
        /// <returns> updated parameter value </returns>
        public double GetValue()
        {
            return this.inchValue;
        }

        /// <summary>
        /// Overridden equals method
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override bool Equals(object obj)
        {
            if ( (obj == null) || object.ReferenceEquals(this, obj) || this.GetType().Equals(obj.GetType()) )
                return true;

            return false;
        }
    }
}
