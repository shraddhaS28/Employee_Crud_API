// --------------------------------------------------------------------------------------------------------------------
// <copyright file="MeasurementConversion.cs" company="Bridgelabz">
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
    /// conversion class conains method to convert measurements from one type to other
    /// </summary>
    public class MeasurementConversion
    {
        private double value;

        /// <summary>
        /// Method to convert value from inch to feet type 
        /// </summary>
        /// <param name="value"></param>
        /// <returns> value in feet </returns>
        public double ConvertFromInchToFeet(double value)
        {
            this.value = value;
            return this.value / 12;
        }

        /// <summary>
        /// Method to convert value from gram to kilogram type 
        /// </summary>
        /// <param name="value"></param>
        /// <returns> value in kilogram </returns>
        public double ConvertFromGramToKilogram(double value)
        {
            this.value = value;
            return this.value / 1000;
        }

        /// <summary>
        /// Method to convert value from fahrenheit to celsius type 
        /// </summary>
        /// <param name="value"></param>
        /// <returns> value in celsius </returns>
        public double ConvertFromFahrenheitToCelsius(double value)
        {
            this.value = value;
            return this.value / 33.8;
        }
    }
}