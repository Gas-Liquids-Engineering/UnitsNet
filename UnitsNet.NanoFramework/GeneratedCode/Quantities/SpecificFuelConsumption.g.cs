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
    ///     SFC is the fuel efficiency of an engine design with respect to thrust output
    /// </summary>
    /// <remarks>
    ///     https://en.wikipedia.org/wiki/Thrust-specific_fuel_consumption
    /// </remarks>
    public struct  SpecificFuelConsumption
    {
        /// <summary>
        ///     The numeric value this quantity was constructed with.
        /// </summary>
        private readonly double _value;

        /// <summary>
        ///     The unit this quantity was constructed with.
        /// </summary>
        private readonly SpecificFuelConsumptionUnit _unit;

        /// <summary>
        ///     The numeric value this quantity was constructed with.
        /// </summary>
        public double Value => _value;

        /// <inheritdoc />
        public SpecificFuelConsumptionUnit Unit => _unit;
        /// <summary>
        ///     Creates the quantity with the given numeric value and unit.
        /// </summary>
        /// <param name="value">The numeric value to construct this quantity with.</param>
        /// <param name="unit">The unit representation to construct this quantity with.</param>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public SpecificFuelConsumption(double value, SpecificFuelConsumptionUnit unit)
        {
            _value = value;
            _unit = unit;
        }

        /// <summary>
        ///     The base unit of Duration, which is Second. All conversions go via this value.
        /// </summary>
        public static SpecificFuelConsumptionUnit BaseUnit { get; } = SpecificFuelConsumptionUnit.GramPerKiloNewtonSecond;

        /// <summary>
        /// Represents the largest possible value of Duration
        /// </summary>
        public static SpecificFuelConsumption MaxValue { get; } = new SpecificFuelConsumption(double.MaxValue, BaseUnit);

        /// <summary>
        /// Represents the smallest possible value of Duration
        /// </summary>
        public static SpecificFuelConsumption MinValue { get; } = new SpecificFuelConsumption(double.MinValue, BaseUnit);
        /// <summary>
        ///     Gets an instance of this quantity with a value of 0 in the base unit Second.
        /// </summary>
        public static SpecificFuelConsumption Zero { get; } = new SpecificFuelConsumption(0, BaseUnit);
        #region Conversion Properties

        /// <summary>
        ///     Get SpecificFuelConsumption in GramsPerKiloNewtonSecond.
        /// </summary>
        public double GramsPerKiloNewtonSecond => As(SpecificFuelConsumptionUnit.GramPerKiloNewtonSecond);

        /// <summary>
        ///     Get SpecificFuelConsumption in KilogramsPerKilogramForceHour.
        /// </summary>
        public double KilogramsPerKilogramForceHour => As(SpecificFuelConsumptionUnit.KilogramPerKilogramForceHour);

        /// <summary>
        ///     Get SpecificFuelConsumption in KilogramsPerKiloNewtonSecond.
        /// </summary>
        public double KilogramsPerKiloNewtonSecond => As(SpecificFuelConsumptionUnit.KilogramPerKiloNewtonSecond);

        /// <summary>
        ///     Get SpecificFuelConsumption in PoundsMassPerPoundForceHour.
        /// </summary>
        public double PoundsMassPerPoundForceHour => As(SpecificFuelConsumptionUnit.PoundMassPerPoundForceHour);

        #endregion

        #region Static Factory Methods

        /// <summary>
        ///     Get SpecificFuelConsumption from GramsPerKiloNewtonSecond.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static SpecificFuelConsumption FromGramsPerKiloNewtonSecond(double gramsperkilonewtonsecond) => new SpecificFuelConsumption(gramsperkilonewtonsecond, SpecificFuelConsumptionUnit.GramPerKiloNewtonSecond);

        /// <summary>
        ///     Get SpecificFuelConsumption from KilogramsPerKilogramForceHour.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static SpecificFuelConsumption FromKilogramsPerKilogramForceHour(double kilogramsperkilogramforcehour) => new SpecificFuelConsumption(kilogramsperkilogramforcehour, SpecificFuelConsumptionUnit.KilogramPerKilogramForceHour);

        /// <summary>
        ///     Get SpecificFuelConsumption from KilogramsPerKiloNewtonSecond.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static SpecificFuelConsumption FromKilogramsPerKiloNewtonSecond(double kilogramsperkilonewtonsecond) => new SpecificFuelConsumption(kilogramsperkilonewtonsecond, SpecificFuelConsumptionUnit.KilogramPerKiloNewtonSecond);

        /// <summary>
        ///     Get SpecificFuelConsumption from PoundsMassPerPoundForceHour.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static SpecificFuelConsumption FromPoundsMassPerPoundForceHour(double poundsmassperpoundforcehour) => new SpecificFuelConsumption(poundsmassperpoundforcehour, SpecificFuelConsumptionUnit.PoundMassPerPoundForceHour);


        /// <summary>
        ///     Dynamically convert from value and unit enum <see cref="SpecificFuelConsumptionUnit" /> to <see cref="SpecificFuelConsumption" />.
        /// </summary>
        /// <param name="value">Value to convert from.</param>
        /// <param name="fromUnit">Unit to convert from.</param>
        /// <returns>SpecificFuelConsumption unit value.</returns>
        public static SpecificFuelConsumption From(double value, SpecificFuelConsumptionUnit fromUnit)
        {
            return new SpecificFuelConsumption(value, fromUnit);
        }

        #endregion

        #region Conversion Methods

        /// <summary>
        ///     Convert to the unit representation <paramref name="unit" />.
        /// </summary>
        /// <returns>Value converted to the specified unit.</returns>
        public double As(SpecificFuelConsumptionUnit unit) => GetValueAs(unit);        

        /// <summary>
        ///     Converts this Duration to another Duration with the unit representation <paramref name="unit" />.
        /// </summary>
        /// <returns>A Duration with the specified unit.</returns>
        public SpecificFuelConsumption ToUnit(SpecificFuelConsumptionUnit unit)
        {
                
            var convertedValue = GetValueAs(unit);
            return new SpecificFuelConsumption(convertedValue, unit);
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
                case SpecificFuelConsumptionUnit.GramPerKiloNewtonSecond: return _value;
                case SpecificFuelConsumptionUnit.KilogramPerKilogramForceHour: return _value*(1e6*1/32.174*1/3600*1/0.3048);
                case SpecificFuelConsumptionUnit.KilogramPerKiloNewtonSecond: return (_value) * 1e3d;
                case SpecificFuelConsumptionUnit.PoundMassPerPoundForceHour: return _value*(1e6*1/32.174*1/3600*1/0.3048);
                default:
                    throw new NotImplementedException($"Can not convert {Unit} to base units.");
            }
        }

        private double GetValueAs(SpecificFuelConsumptionUnit unit)
        {
            if(Unit == unit)
                return _value;

            var baseUnitValue = GetValueInBaseUnit();

            switch(unit)
            {
                case SpecificFuelConsumptionUnit.GramPerKiloNewtonSecond: return baseUnitValue;
                case SpecificFuelConsumptionUnit.KilogramPerKilogramForceHour: return baseUnitValue/(1e6*1/32.174*1/3600*1/0.3048);
                case SpecificFuelConsumptionUnit.KilogramPerKiloNewtonSecond: return (baseUnitValue) / 1e3d;
                case SpecificFuelConsumptionUnit.PoundMassPerPoundForceHour: return baseUnitValue/(1e6*1/32.174*1/3600*1/0.3048);
                default:
                    throw new NotImplementedException($"Can not convert {Unit} to {unit}.");
            }
        }

        #endregion

    }
}

