﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="KiloGram.cs" company="Bridgelabz">
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
    /// kilogram class
    /// </summary>
    public class KiloGram
    {
        /// <summary>
        /// private parameter
        /// </summary>
        private double kgValue;

        /// <summary>
        /// method to get kilogram value.
        /// </summary>
        /// <param name="kgValue"></param>
        /// <returns>kilogram value </returns>
        public double GetValue(double kgValue)
        {
            this.kgValue = kgValue;
            return this.kgValue;
        }

        /// <summary>
        /// Overridden Equals method
        /// </summary>
        /// <param name="obj"></param>
        /// <returns>True or false</returns>
        public override bool Equals(object obj)
        {
            if( (obj == null) || object.ReferenceEquals(this, obj) || this.GetType().Equals(obj.GetType()) )
                return true;
            return false;
        }
    }
}
