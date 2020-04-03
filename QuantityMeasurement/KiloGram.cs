// --------------------------------------------------------------------------------------------------------------------
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
        private int kgValue;

        public override bool Equals(object obj)
        {
            if( (obj == null) || object.ReferenceEquals(this, obj) )
                return true;
            return false;
        }
    }
}
