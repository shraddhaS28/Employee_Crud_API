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
        private int value;
        /// <summary>
        /// Method to conver value from feet to inch type 
        /// </summary>
        /// <returns></returns>
        public int ConvertFromInchToFeet(int value)
        {
            this.value = value;
            return this.value / 12;
        }
    }
}
