// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Fahrenheit.cs" company="Bridgelabz">
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
    /// fahrenheit class
    /// </summary>
    public class Fahrenheit
    {
        /// <summary>
        /// private parameter
        /// </summary>
        private double ftValue;

        /// <summary>
        /// Method to get gram value
        /// </summary>
        /// <param name="ftValue"></param>
        /// <returns> double value </returns>
        public double getValue(double ftValue)
        {
            this.ftValue = ftValue;
            return this.ftValue;
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
