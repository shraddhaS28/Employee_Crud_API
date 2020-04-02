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
        private int inchValue;

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
        public Inch(int inchValue)
        {
            this.inchValue = inchValue;
        }

        /// <summary>
        /// Method to get inch value
        /// </summary>
        /// <returns></returns>
        public int isValueEqual()
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
            if ((obj == null) || object.ReferenceEquals(this, obj))
                return true;

            return false;
        }
    }
}
