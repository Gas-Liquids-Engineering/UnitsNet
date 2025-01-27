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
    ///     The dynamic (shear) viscosity of a fluid expresses its resistance to shearing flows, where adjacent layers move parallel to each other with different speeds
    /// </summary>
    /// <remarks>
    ///     https://en.wikipedia.org/wiki/Viscosity#Dynamic_.28shear.29_viscosity
    /// </remarks>
    public struct  DynamicViscosity
    {
        /// <summary>
        ///     The numeric value this quantity was constructed with.
        /// </summary>
        private readonly double _value;

        /// <summary>
        ///     The unit this quantity was constructed with.
        /// </summary>
        private readonly DynamicViscosityUnit _unit;

        /// <summary>
        ///     The numeric value this quantity was constructed with.
        /// </summary>
        public double Value => _value;

        /// <inheritdoc />
        public DynamicViscosityUnit Unit => _unit;
        /// <summary>
        ///     Creates the quantity with the given numeric value and unit.
        /// </summary>
        /// <param name="value">The numeric value to construct this quantity with.</param>
        /// <param name="unit">The unit representation to construct this quantity with.</param>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public DynamicViscosity(double value, DynamicViscosityUnit unit)
        {
            _value = value;
            _unit = unit;
        }

        /// <summary>
        ///     The base unit of Duration, which is Second. All conversions go via this value.
        /// </summary>
        public static DynamicViscosityUnit BaseUnit { get; } = DynamicViscosityUnit.NewtonSecondPerMeterSquared;

        /// <summary>
        /// Represents the largest possible value of Duration
        /// </summary>
        public static DynamicViscosity MaxValue { get; } = new DynamicViscosity(double.MaxValue, BaseUnit);

        /// <summary>
        /// Represents the smallest possible value of Duration
        /// </summary>
        public static DynamicViscosity MinValue { get; } = new DynamicViscosity(double.MinValue, BaseUnit);
        /// <summary>
        ///     Gets an instance of this quantity with a value of 0 in the base unit Second.
        /// </summary>
        public static DynamicViscosity Zero { get; } = new DynamicViscosity(0, BaseUnit);
        #region Conversion Properties

        /// <summary>
        ///     Get DynamicViscosity in Centipoise.
        /// </summary>
        public double Centipoise => As(DynamicViscosityUnit.Centipoise);

        /// <summary>
        ///     Get DynamicViscosity in MicropascalSeconds.
        /// </summary>
        public double MicropascalSeconds => As(DynamicViscosityUnit.MicropascalSecond);

        /// <summary>
        ///     Get DynamicViscosity in Micropoise.
        /// </summary>
        public double Micropoise => As(DynamicViscosityUnit.Micropoise);

        /// <summary>
        ///     Get DynamicViscosity in MillipascalSeconds.
        /// </summary>
        public double MillipascalSeconds => As(DynamicViscosityUnit.MillipascalSecond);

        /// <summary>
        ///     Get DynamicViscosity in NewtonSecondsPerMeterSquared.
        /// </summary>
        public double NewtonSecondsPerMeterSquared => As(DynamicViscosityUnit.NewtonSecondPerMeterSquared);

        /// <summary>
        ///     Get DynamicViscosity in PascalSeconds.
        /// </summary>
        public double PascalSeconds => As(DynamicViscosityUnit.PascalSecond);

        /// <summary>
        ///     Get DynamicViscosity in Poise.
        /// </summary>
        public double Poise => As(DynamicViscosityUnit.Poise);

        /// <summary>
        ///     Get DynamicViscosity in PoundsForceSecondPerSquareFoot.
        /// </summary>
        public double PoundsForceSecondPerSquareFoot => As(DynamicViscosityUnit.PoundForceSecondPerSquareFoot);

        /// <summary>
        ///     Get DynamicViscosity in PoundsForceSecondPerSquareInch.
        /// </summary>
        public double PoundsForceSecondPerSquareInch => As(DynamicViscosityUnit.PoundForceSecondPerSquareInch);

        /// <summary>
        ///     Get DynamicViscosity in PoundsPerFootHour.
        /// </summary>
        public double PoundsPerFootHour => As(DynamicViscosityUnit.PoundPerFootHour);

        /// <summary>
        ///     Get DynamicViscosity in PoundsPerFootSecond.
        /// </summary>
        public double PoundsPerFootSecond => As(DynamicViscosityUnit.PoundPerFootSecond);

        /// <summary>
        ///     Get DynamicViscosity in Reyns.
        /// </summary>
        public double Reyns => As(DynamicViscosityUnit.Reyn);

        #endregion

        #region Static Factory Methods

        /// <summary>
        ///     Get DynamicViscosity from Centipoise.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static DynamicViscosity FromCentipoise(double centipoise) => new DynamicViscosity(centipoise, DynamicViscosityUnit.Centipoise);

        /// <summary>
        ///     Get DynamicViscosity from MicropascalSeconds.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static DynamicViscosity FromMicropascalSeconds(double micropascalseconds) => new DynamicViscosity(micropascalseconds, DynamicViscosityUnit.MicropascalSecond);

        /// <summary>
        ///     Get DynamicViscosity from Micropoise.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static DynamicViscosity FromMicropoise(double micropoise) => new DynamicViscosity(micropoise, DynamicViscosityUnit.Micropoise);

        /// <summary>
        ///     Get DynamicViscosity from MillipascalSeconds.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static DynamicViscosity FromMillipascalSeconds(double millipascalseconds) => new DynamicViscosity(millipascalseconds, DynamicViscosityUnit.MillipascalSecond);

        /// <summary>
        ///     Get DynamicViscosity from NewtonSecondsPerMeterSquared.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static DynamicViscosity FromNewtonSecondsPerMeterSquared(double newtonsecondspermetersquared) => new DynamicViscosity(newtonsecondspermetersquared, DynamicViscosityUnit.NewtonSecondPerMeterSquared);

        /// <summary>
        ///     Get DynamicViscosity from PascalSeconds.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static DynamicViscosity FromPascalSeconds(double pascalseconds) => new DynamicViscosity(pascalseconds, DynamicViscosityUnit.PascalSecond);

        /// <summary>
        ///     Get DynamicViscosity from Poise.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static DynamicViscosity FromPoise(double poise) => new DynamicViscosity(poise, DynamicViscosityUnit.Poise);

        /// <summary>
        ///     Get DynamicViscosity from PoundsForceSecondPerSquareFoot.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static DynamicViscosity FromPoundsForceSecondPerSquareFoot(double poundsforcesecondpersquarefoot) => new DynamicViscosity(poundsforcesecondpersquarefoot, DynamicViscosityUnit.PoundForceSecondPerSquareFoot);

        /// <summary>
        ///     Get DynamicViscosity from PoundsForceSecondPerSquareInch.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static DynamicViscosity FromPoundsForceSecondPerSquareInch(double poundsforcesecondpersquareinch) => new DynamicViscosity(poundsforcesecondpersquareinch, DynamicViscosityUnit.PoundForceSecondPerSquareInch);

        /// <summary>
        ///     Get DynamicViscosity from PoundsPerFootHour.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static DynamicViscosity FromPoundsPerFootHour(double poundsperfoothour) => new DynamicViscosity(poundsperfoothour, DynamicViscosityUnit.PoundPerFootHour);

        /// <summary>
        ///     Get DynamicViscosity from PoundsPerFootSecond.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static DynamicViscosity FromPoundsPerFootSecond(double poundsperfootsecond) => new DynamicViscosity(poundsperfootsecond, DynamicViscosityUnit.PoundPerFootSecond);

        /// <summary>
        ///     Get DynamicViscosity from Reyns.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static DynamicViscosity FromReyns(double reyns) => new DynamicViscosity(reyns, DynamicViscosityUnit.Reyn);


        /// <summary>
        ///     Dynamically convert from value and unit enum <see cref="DynamicViscosityUnit" /> to <see cref="DynamicViscosity" />.
        /// </summary>
        /// <param name="value">Value to convert from.</param>
        /// <param name="fromUnit">Unit to convert from.</param>
        /// <returns>DynamicViscosity unit value.</returns>
        public static DynamicViscosity From(double value, DynamicViscosityUnit fromUnit)
        {
            return new DynamicViscosity(value, fromUnit);
        }

        #endregion

        #region Conversion Methods

        /// <summary>
        ///     Convert to the unit representation <paramref name="unit" />.
        /// </summary>
        /// <returns>Value converted to the specified unit.</returns>
        public double As(DynamicViscosityUnit unit) => GetValueAs(unit);        

        /// <summary>
        ///     Converts this Duration to another Duration with the unit representation <paramref name="unit" />.
        /// </summary>
        /// <returns>A Duration with the specified unit.</returns>
        public DynamicViscosity ToUnit(DynamicViscosityUnit unit)
        {
                
            var convertedValue = GetValueAs(unit);
            return new DynamicViscosity(convertedValue, unit);
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
                case DynamicViscosityUnit.Centipoise: return (_value/10) * 1e-2d;
                case DynamicViscosityUnit.MicropascalSecond: return (_value) * 1e-6d;
                case DynamicViscosityUnit.Micropoise: return (_value/10) * 1e-6d;
                case DynamicViscosityUnit.MillipascalSecond: return (_value) * 1e-3d;
                case DynamicViscosityUnit.NewtonSecondPerMeterSquared: return _value;
                case DynamicViscosityUnit.PascalSecond: return _value;
                case DynamicViscosityUnit.Poise: return _value/10;
                case DynamicViscosityUnit.PoundForceSecondPerSquareFoot: return _value*(0.45359237*1/0.3048*1/0.3048*9.80665);
                case DynamicViscosityUnit.PoundForceSecondPerSquareInch: return _value*(0.45359237*12/0.3048*12/0.3048*9.80665);
                case DynamicViscosityUnit.PoundPerFootHour: return _value*(0.4535927/0.3048/3600);
                case DynamicViscosityUnit.PoundPerFootSecond: return _value*(0.45359237/0.3048);
                case DynamicViscosityUnit.Reyn: return _value*(0.45359237*12/0.3048*12/0.3048*9.80665);
                default:
                    throw new NotImplementedException($"Can not convert {Unit} to base units.");
            }
        }

        private double GetValueAs(DynamicViscosityUnit unit)
        {
            if(Unit == unit)
                return _value;

            var baseUnitValue = GetValueInBaseUnit();

            switch(unit)
            {
                case DynamicViscosityUnit.Centipoise: return (baseUnitValue*10) / 1e-2d;
                case DynamicViscosityUnit.MicropascalSecond: return (baseUnitValue) / 1e-6d;
                case DynamicViscosityUnit.Micropoise: return (baseUnitValue*10) / 1e-6d;
                case DynamicViscosityUnit.MillipascalSecond: return (baseUnitValue) / 1e-3d;
                case DynamicViscosityUnit.NewtonSecondPerMeterSquared: return baseUnitValue;
                case DynamicViscosityUnit.PascalSecond: return baseUnitValue;
                case DynamicViscosityUnit.Poise: return baseUnitValue*10;
                case DynamicViscosityUnit.PoundForceSecondPerSquareFoot: return baseUnitValue/(0.45359237*1/0.3048*1/0.3048*9.80665);
                case DynamicViscosityUnit.PoundForceSecondPerSquareInch: return baseUnitValue/(0.45359237*12/0.3048*12/0.3048*9.80665);
                case DynamicViscosityUnit.PoundPerFootHour: return baseUnitValue/(0.4535927/0.3048/3600);
                case DynamicViscosityUnit.PoundPerFootSecond: return baseUnitValue/(0.45359237/0.3048);
                case DynamicViscosityUnit.Reyn: return baseUnitValue/(0.45359237*12/0.3048*12/0.3048*9.80665);
                default:
                    throw new NotImplementedException($"Can not convert {Unit} to {unit}.");
            }
        }

        #endregion

    }
}

