//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by \generate-code.bat.
//
//     Changes to this file will be lost when the code is regenerated.
//     The build server regenerates the code before each build and a pre-build
//     step will regenerate the code on each local build.
//
//     See https://github.com/angularsen/UnitsNet/wiki/Adding-a-New-Unit for how to add or edit units.
//
//     Add CustomCode\Quantities\MyQuantity.extra.cs files to add code to generated quantities.
//     Add UnitDefinitions\MyQuantity.json and run generate-code.bat to generate new units or quantities.
//
// </auto-generated>
//------------------------------------------------------------------------------

// Licensed under MIT No Attribution, see LICENSE file at the root.
// Copyright 2013 Andreas Gullberg Larsen (andreas.larsen84@gmail.com). Maintained at https://github.com/angularsen/UnitsNet.

using System;
using UnitsNet.Units;

namespace UnitsNet
{
    /// <inheritdoc />
    /// <summary>
    ///     Electric charge is the physical property of matter that causes it to experience a force when placed in an electromagnetic field.
    /// </summary>
    /// <remarks>
    ///     https://en.wikipedia.org/wiki/Electric_charge
    /// </remarks>
    public struct  ElectricCharge
    {
        /// <summary>
        ///     The numeric value this quantity was constructed with.
        /// </summary>
        private readonly double _value;

        /// <summary>
        ///     The unit this quantity was constructed with.
        /// </summary>
        private readonly ElectricChargeUnit _unit;

        /// <summary>
        ///     The numeric value this quantity was constructed with.
        /// </summary>
        public double Value => _value;

        /// <inheritdoc />
        public ElectricChargeUnit Unit => _unit;
        /// <summary>
        ///     Creates the quantity with the given numeric value and unit.
        /// </summary>
        /// <param name="value">The numeric value to construct this quantity with.</param>
        /// <param name="unit">The unit representation to construct this quantity with.</param>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public ElectricCharge(double value, ElectricChargeUnit unit)
        {
            _value = value;
            _unit = unit;
        }

        /// <summary>
        ///     The base unit of Duration, which is Second. All conversions go via this value.
        /// </summary>
        public static ElectricChargeUnit BaseUnit { get; } = ElectricChargeUnit.Coulomb;

        /// <summary>
        /// Represents the largest possible value of Duration
        /// </summary>
        public static ElectricCharge MaxValue { get; } = new ElectricCharge(double.MaxValue, BaseUnit);

        /// <summary>
        /// Represents the smallest possible value of Duration
        /// </summary>
        public static ElectricCharge MinValue { get; } = new ElectricCharge(double.MinValue, BaseUnit);
        /// <summary>
        ///     Gets an instance of this quantity with a value of 0 in the base unit Second.
        /// </summary>
        public static ElectricCharge Zero { get; } = new ElectricCharge(0, BaseUnit);
        #region Conversion Properties

        /// <summary>
        ///     Get ElectricCharge in AmpereHours.
        /// </summary>
        public double AmpereHours => As(ElectricChargeUnit.AmpereHour);

        /// <summary>
        ///     Get ElectricCharge in Coulombs.
        /// </summary>
        public double Coulombs => As(ElectricChargeUnit.Coulomb);

        /// <summary>
        ///     Get ElectricCharge in KiloampereHours.
        /// </summary>
        public double KiloampereHours => As(ElectricChargeUnit.KiloampereHour);

        /// <summary>
        ///     Get ElectricCharge in MegaampereHours.
        /// </summary>
        public double MegaampereHours => As(ElectricChargeUnit.MegaampereHour);

        /// <summary>
        ///     Get ElectricCharge in MilliampereHours.
        /// </summary>
        public double MilliampereHours => As(ElectricChargeUnit.MilliampereHour);

        #endregion

        #region Static Factory Methods

        /// <summary>
        ///     Get ElectricCharge from AmpereHours.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static ElectricCharge FromAmpereHours(double amperehours) => new ElectricCharge(amperehours, ElectricChargeUnit.AmpereHour);

        /// <summary>
        ///     Get ElectricCharge from Coulombs.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static ElectricCharge FromCoulombs(double coulombs) => new ElectricCharge(coulombs, ElectricChargeUnit.Coulomb);

        /// <summary>
        ///     Get ElectricCharge from KiloampereHours.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static ElectricCharge FromKiloampereHours(double kiloamperehours) => new ElectricCharge(kiloamperehours, ElectricChargeUnit.KiloampereHour);

        /// <summary>
        ///     Get ElectricCharge from MegaampereHours.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static ElectricCharge FromMegaampereHours(double megaamperehours) => new ElectricCharge(megaamperehours, ElectricChargeUnit.MegaampereHour);

        /// <summary>
        ///     Get ElectricCharge from MilliampereHours.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static ElectricCharge FromMilliampereHours(double milliamperehours) => new ElectricCharge(milliamperehours, ElectricChargeUnit.MilliampereHour);


        /// <summary>
        ///     Dynamically convert from value and unit enum <see cref="ElectricChargeUnit" /> to <see cref="ElectricCharge" />.
        /// </summary>
        /// <param name="value">Value to convert from.</param>
        /// <param name="fromUnit">Unit to convert from.</param>
        /// <returns>ElectricCharge unit value.</returns>
        public static ElectricCharge From(double value, ElectricChargeUnit fromUnit)
        {
            return new ElectricCharge(value, fromUnit);
        }

        #endregion

        #region Conversion Methods

        /// <summary>
        ///     Convert to the unit representation <paramref name="unit" />.
        /// </summary>
        /// <returns>Value converted to the specified unit.</returns>
        public double As(ElectricChargeUnit unit) => GetValueAs(unit);        

        /// <summary>
        ///     Converts this Duration to another Duration with the unit representation <paramref name="unit" />.
        /// </summary>
        /// <returns>A Duration with the specified unit.</returns>
        public ElectricCharge ToUnit(ElectricChargeUnit unit)
        {
                
            var convertedValue = GetValueAs(unit);
            return new ElectricCharge(convertedValue, unit);
        }


        /// <summary>
        ///     Converts the current value + unit to the base unit.
        ///     This is typically the first step in converting from one unit to another.
        /// </summary>
        /// <returns>The value in the base unit representation.</returns>
        private double GetValueInBaseUnit()
        {
            switch(Unit)
            {
                case ElectricChargeUnit.AmpereHour: return _value*3600;
                case ElectricChargeUnit.Coulomb: return _value;
                case ElectricChargeUnit.KiloampereHour: return (_value*3600) * 1e3d;
                case ElectricChargeUnit.MegaampereHour: return (_value*3600) * 1e6d;
                case ElectricChargeUnit.MilliampereHour: return (_value*3600) * 1e-3d;
                default:
                    throw new NotImplementedException($"Can not convert {Unit} to base units.");
            }
        }

        private double GetValueAs(ElectricChargeUnit unit)
        {
            if(Unit == unit)
                return _value;

            var baseUnitValue = GetValueInBaseUnit();

            switch(unit)
            {
                case ElectricChargeUnit.AmpereHour: return baseUnitValue/3600;
                case ElectricChargeUnit.Coulomb: return baseUnitValue;
                case ElectricChargeUnit.KiloampereHour: return (baseUnitValue/3600) / 1e3d;
                case ElectricChargeUnit.MegaampereHour: return (baseUnitValue/3600) / 1e6d;
                case ElectricChargeUnit.MilliampereHour: return (baseUnitValue/3600) / 1e-3d;
                default:
                    throw new NotImplementedException($"Can not convert {Unit} to {unit}.");
            }
        }

        #endregion

    }
}

