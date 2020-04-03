﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="UnitCheck.cs" company="Bridgelabz">
// Copyright © 2020 Company="BridgeLabz".
// </copyright>
// <creator name="Shraddha Singh"/>
// --------------------------------------------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Text;

namespace QuantityMeasurement
{
    public class UnitCheck
    {
        /// <summary>
        /// Private value
        /// </summary>
        private int value;

        /// <summary>
        /// Default UnitCheck Constructor.
        /// </summary>
        public UnitCheck()
        {

        }

        /// <summary>
        /// Parameterized UnitCheck Constructor.
        /// </summary>
        /// <param name="value"></param>
        public UnitCheck(int value)
        {
            this.value = value;
        }

        /// <summary>
        /// Method to get value.
        /// </summary>
        /// <returns> int value </returns>
        public int isValueEqual()
        {
            return this.value;
        }


        /// <summary>
        /// Method to convert feet value into inch
        /// </summary>
        /// /// <param name="feet"></param>
        /// <returns> int value </returns>
        public int ConvertFromFeetToInch(int value)
        {
            this.value = value;
            return this.value * 12;
        }

        /// <summary>
        /// Method to convert inch value into feet
        /// </summary>
        /// /// <param name="inch"></param>
        /// <returns> int value </returns>
        public int ConvertFromInchToFeet(int value)
        {
            this.value = value;
            return this.value / 12;
        }

        /// <summary>
        /// Method to convert feet value into yard
        /// </summary>
        /// <param name="feet"></param>
        /// <returns></returns>
        public int ConvertFromFeetToYard(int value)
        {
            this.value = value;
            return this.value / 3;
        }

        /// <summary>
        /// Method to convert inch value into yard
        /// </summary>
        /// <param name="inch"></param>
        /// <returns></returns>
        public int ConvertFromInchToYard(int value)
        {
            this.value = value;
            return this.value / 36;
        }

        /// <summary>
        /// Method to convert inch value into yard
        /// </summary>
        /// <param name="yard"></param>
        /// <returns></returns>
        public int ConvertFromYardToInch(int value)
        {
            this.value = value;
            return this.value * 36;
        }

        /// <summary>
        /// Method to convert inch value into yard
        /// </summary>
        /// <param name="yard"></param>
        /// <returns></returns>
        public int ConvertFromYardToFeet(int value)
        {
            this.value = value;
            return this.value * 3;
        }



        /// <summary>
        /// Overridden EqualsMethod.
        /// </summary>
        /// <param name="obj"></param>
        /// <returns> bool value </returns>
        public override bool Equals(object obj)
        {
            if ((obj == null) || Object.ReferenceEquals(this, obj) || this.GetType().Equals(obj.GetType()))
                return true;

            return false;
        }
    }
}
