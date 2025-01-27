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
    ///     Force change rate is the ratio of the force change to the time during which the change occurred (value of force changes per unit time).
    /// </summary>
    public struct  ForceChangeRate
    {
        /// <summary>
        ///     The numeric value this quantity was constructed with.
        /// </summary>
        private readonly double _value;

        /// <summary>
        ///     The unit this quantity was constructed with.
        /// </summary>
        private readonly ForceChangeRateUnit _unit;

        /// <summary>
        ///     The numeric value this quantity was constructed with.
        /// </summary>
        public double Value => _value;

        /// <inheritdoc />
        public ForceChangeRateUnit Unit => _unit;
        /// <summary>
        ///     Creates the quantity with the given numeric value and unit.
        /// </summary>
        /// <param name="value">The numeric value to construct this quantity with.</param>
        /// <param name="unit">The unit representation to construct this quantity with.</param>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public ForceChangeRate(double value, ForceChangeRateUnit unit)
        {
            _value = value;
            _unit = unit;
        }

        /// <summary>
        ///     The base unit of Duration, which is Second. All conversions go via this value.
        /// </summary>
        public static ForceChangeRateUnit BaseUnit { get; } = ForceChangeRateUnit.NewtonPerSecond;

        /// <summary>
        /// Represents the largest possible value of Duration
        /// </summary>
        public static ForceChangeRate MaxValue { get; } = new ForceChangeRate(double.MaxValue, BaseUnit);

        /// <summary>
        /// Represents the smallest possible value of Duration
        /// </summary>
        public static ForceChangeRate MinValue { get; } = new ForceChangeRate(double.MinValue, BaseUnit);
        /// <summary>
        ///     Gets an instance of this quantity with a value of 0 in the base unit Second.
        /// </summary>
        public static ForceChangeRate Zero { get; } = new ForceChangeRate(0, BaseUnit);
        #region Conversion Properties

        /// <summary>
        ///     Get ForceChangeRate in CentinewtonsPerSecond.
        /// </summary>
        public double CentinewtonsPerSecond => As(ForceChangeRateUnit.CentinewtonPerSecond);

        /// <summary>
        ///     Get ForceChangeRate in DecanewtonsPerMinute.
        /// </summary>
        public double DecanewtonsPerMinute => As(ForceChangeRateUnit.DecanewtonPerMinute);

        /// <summary>
        ///     Get ForceChangeRate in DecanewtonsPerSecond.
        /// </summary>
        public double DecanewtonsPerSecond => As(ForceChangeRateUnit.DecanewtonPerSecond);

        /// <summary>
        ///     Get ForceChangeRate in DecinewtonsPerSecond.
        /// </summary>
        public double DecinewtonsPerSecond => As(ForceChangeRateUnit.DecinewtonPerSecond);

        /// <summary>
        ///     Get ForceChangeRate in KilonewtonsPerMinute.
        /// </summary>
        public double KilonewtonsPerMinute => As(ForceChangeRateUnit.KilonewtonPerMinute);

        /// <summary>
        ///     Get ForceChangeRate in KilonewtonsPerSecond.
        /// </summary>
        public double KilonewtonsPerSecond => As(ForceChangeRateUnit.KilonewtonPerSecond);

        /// <summary>
        ///     Get ForceChangeRate in KilopoundsForcePerMinute.
        /// </summary>
        public double KilopoundsForcePerMinute => As(ForceChangeRateUnit.KilopoundForcePerMinute);

        /// <summary>
        ///     Get ForceChangeRate in KilopoundsForcePerSecond.
        /// </summary>
        public double KilopoundsForcePerSecond => As(ForceChangeRateUnit.KilopoundForcePerSecond);

        /// <summary>
        ///     Get ForceChangeRate in MicronewtonsPerSecond.
        /// </summary>
        public double MicronewtonsPerSecond => As(ForceChangeRateUnit.MicronewtonPerSecond);

        /// <summary>
        ///     Get ForceChangeRate in MillinewtonsPerSecond.
        /// </summary>
        public double MillinewtonsPerSecond => As(ForceChangeRateUnit.MillinewtonPerSecond);

        /// <summary>
        ///     Get ForceChangeRate in NanonewtonsPerSecond.
        /// </summary>
        public double NanonewtonsPerSecond => As(ForceChangeRateUnit.NanonewtonPerSecond);

        /// <summary>
        ///     Get ForceChangeRate in NewtonsPerMinute.
        /// </summary>
        public double NewtonsPerMinute => As(ForceChangeRateUnit.NewtonPerMinute);

        /// <summary>
        ///     Get ForceChangeRate in NewtonsPerSecond.
        /// </summary>
        public double NewtonsPerSecond => As(ForceChangeRateUnit.NewtonPerSecond);

        /// <summary>
        ///     Get ForceChangeRate in PoundsForcePerMinute.
        /// </summary>
        public double PoundsForcePerMinute => As(ForceChangeRateUnit.PoundForcePerMinute);

        /// <summary>
        ///     Get ForceChangeRate in PoundsForcePerSecond.
        /// </summary>
        public double PoundsForcePerSecond => As(ForceChangeRateUnit.PoundForcePerSecond);

        #endregion

        #region Static Factory Methods

        /// <summary>
        ///     Get ForceChangeRate from CentinewtonsPerSecond.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static ForceChangeRate FromCentinewtonsPerSecond(double centinewtonspersecond) => new ForceChangeRate(centinewtonspersecond, ForceChangeRateUnit.CentinewtonPerSecond);

        /// <summary>
        ///     Get ForceChangeRate from DecanewtonsPerMinute.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static ForceChangeRate FromDecanewtonsPerMinute(double decanewtonsperminute) => new ForceChangeRate(decanewtonsperminute, ForceChangeRateUnit.DecanewtonPerMinute);

        /// <summary>
        ///     Get ForceChangeRate from DecanewtonsPerSecond.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static ForceChangeRate FromDecanewtonsPerSecond(double decanewtonspersecond) => new ForceChangeRate(decanewtonspersecond, ForceChangeRateUnit.DecanewtonPerSecond);

        /// <summary>
        ///     Get ForceChangeRate from DecinewtonsPerSecond.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static ForceChangeRate FromDecinewtonsPerSecond(double decinewtonspersecond) => new ForceChangeRate(decinewtonspersecond, ForceChangeRateUnit.DecinewtonPerSecond);

        /// <summary>
        ///     Get ForceChangeRate from KilonewtonsPerMinute.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static ForceChangeRate FromKilonewtonsPerMinute(double kilonewtonsperminute) => new ForceChangeRate(kilonewtonsperminute, ForceChangeRateUnit.KilonewtonPerMinute);

        /// <summary>
        ///     Get ForceChangeRate from KilonewtonsPerSecond.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static ForceChangeRate FromKilonewtonsPerSecond(double kilonewtonspersecond) => new ForceChangeRate(kilonewtonspersecond, ForceChangeRateUnit.KilonewtonPerSecond);

        /// <summary>
        ///     Get ForceChangeRate from KilopoundsForcePerMinute.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static ForceChangeRate FromKilopoundsForcePerMinute(double kilopoundsforceperminute) => new ForceChangeRate(kilopoundsforceperminute, ForceChangeRateUnit.KilopoundForcePerMinute);

        /// <summary>
        ///     Get ForceChangeRate from KilopoundsForcePerSecond.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static ForceChangeRate FromKilopoundsForcePerSecond(double kilopoundsforcepersecond) => new ForceChangeRate(kilopoundsforcepersecond, ForceChangeRateUnit.KilopoundForcePerSecond);

        /// <summary>
        ///     Get ForceChangeRate from MicronewtonsPerSecond.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static ForceChangeRate FromMicronewtonsPerSecond(double micronewtonspersecond) => new ForceChangeRate(micronewtonspersecond, ForceChangeRateUnit.MicronewtonPerSecond);

        /// <summary>
        ///     Get ForceChangeRate from MillinewtonsPerSecond.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static ForceChangeRate FromMillinewtonsPerSecond(double millinewtonspersecond) => new ForceChangeRate(millinewtonspersecond, ForceChangeRateUnit.MillinewtonPerSecond);

        /// <summary>
        ///     Get ForceChangeRate from NanonewtonsPerSecond.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static ForceChangeRate FromNanonewtonsPerSecond(double nanonewtonspersecond) => new ForceChangeRate(nanonewtonspersecond, ForceChangeRateUnit.NanonewtonPerSecond);

        /// <summary>
        ///     Get ForceChangeRate from NewtonsPerMinute.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static ForceChangeRate FromNewtonsPerMinute(double newtonsperminute) => new ForceChangeRate(newtonsperminute, ForceChangeRateUnit.NewtonPerMinute);

        /// <summary>
        ///     Get ForceChangeRate from NewtonsPerSecond.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static ForceChangeRate FromNewtonsPerSecond(double newtonspersecond) => new ForceChangeRate(newtonspersecond, ForceChangeRateUnit.NewtonPerSecond);

        /// <summary>
        ///     Get ForceChangeRate from PoundsForcePerMinute.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static ForceChangeRate FromPoundsForcePerMinute(double poundsforceperminute) => new ForceChangeRate(poundsforceperminute, ForceChangeRateUnit.PoundForcePerMinute);

        /// <summary>
        ///     Get ForceChangeRate from PoundsForcePerSecond.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static ForceChangeRate FromPoundsForcePerSecond(double poundsforcepersecond) => new ForceChangeRate(poundsforcepersecond, ForceChangeRateUnit.PoundForcePerSecond);


        /// <summary>
        ///     Dynamically convert from value and unit enum <see cref="ForceChangeRateUnit" /> to <see cref="ForceChangeRate" />.
        /// </summary>
        /// <param name="value">Value to convert from.</param>
        /// <param name="fromUnit">Unit to convert from.</param>
        /// <returns>ForceChangeRate unit value.</returns>
        public static ForceChangeRate From(double value, ForceChangeRateUnit fromUnit)
        {
            return new ForceChangeRate(value, fromUnit);
        }

        #endregion

        #region Conversion Methods

        /// <summary>
        ///     Convert to the unit representation <paramref name="unit" />.
        /// </summary>
        /// <returns>Value converted to the specified unit.</returns>
        public double As(ForceChangeRateUnit unit) => GetValueAs(unit);        

        /// <summary>
        ///     Converts this Duration to another Duration with the unit representation <paramref name="unit" />.
        /// </summary>
        /// <returns>A Duration with the specified unit.</returns>
        public ForceChangeRate ToUnit(ForceChangeRateUnit unit)
        {
                
            var convertedValue = GetValueAs(unit);
            return new ForceChangeRate(convertedValue, unit);
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
                case ForceChangeRateUnit.CentinewtonPerSecond: return (_value) * 1e-2d;
                case ForceChangeRateUnit.DecanewtonPerMinute: return (_value/60) * 1e1d;
                case ForceChangeRateUnit.DecanewtonPerSecond: return (_value) * 1e1d;
                case ForceChangeRateUnit.DecinewtonPerSecond: return (_value) * 1e-1d;
                case ForceChangeRateUnit.KilonewtonPerMinute: return (_value/60) * 1e3d;
                case ForceChangeRateUnit.KilonewtonPerSecond: return (_value) * 1e3d;
                case ForceChangeRateUnit.KilopoundForcePerMinute: return (_value*(32.174*0.45359237*0.3048)/60) * 1e3d;
                case ForceChangeRateUnit.KilopoundForcePerSecond: return (_value*(32.174*0.45359237*0.3048)) * 1e3d;
                case ForceChangeRateUnit.MicronewtonPerSecond: return (_value) * 1e-6d;
                case ForceChangeRateUnit.MillinewtonPerSecond: return (_value) * 1e-3d;
                case ForceChangeRateUnit.NanonewtonPerSecond: return (_value) * 1e-9d;
                case ForceChangeRateUnit.NewtonPerMinute: return _value/60;
                case ForceChangeRateUnit.NewtonPerSecond: return _value;
                case ForceChangeRateUnit.PoundForcePerMinute: return _value*(32.174*0.45359237*0.3048)/60;
                case ForceChangeRateUnit.PoundForcePerSecond: return _value*(32.174*0.45359237*0.3048);
                default:
                    throw new NotImplementedException($"Can not convert {Unit} to base units.");
            }
        }

        private double GetValueAs(ForceChangeRateUnit unit)
        {
            if(Unit == unit)
                return _value;

            var baseUnitValue = GetValueInBaseUnit();

            switch(unit)
            {
                case ForceChangeRateUnit.CentinewtonPerSecond: return (baseUnitValue) / 1e-2d;
                case ForceChangeRateUnit.DecanewtonPerMinute: return (baseUnitValue*60) / 1e1d;
                case ForceChangeRateUnit.DecanewtonPerSecond: return (baseUnitValue) / 1e1d;
                case ForceChangeRateUnit.DecinewtonPerSecond: return (baseUnitValue) / 1e-1d;
                case ForceChangeRateUnit.KilonewtonPerMinute: return (baseUnitValue*60) / 1e3d;
                case ForceChangeRateUnit.KilonewtonPerSecond: return (baseUnitValue) / 1e3d;
                case ForceChangeRateUnit.KilopoundForcePerMinute: return (baseUnitValue/(32.174*0.45359237*0.3048)*60) / 1e3d;
                case ForceChangeRateUnit.KilopoundForcePerSecond: return (baseUnitValue/(32.174*0.45359237*0.3048)) / 1e3d;
                case ForceChangeRateUnit.MicronewtonPerSecond: return (baseUnitValue) / 1e-6d;
                case ForceChangeRateUnit.MillinewtonPerSecond: return (baseUnitValue) / 1e-3d;
                case ForceChangeRateUnit.NanonewtonPerSecond: return (baseUnitValue) / 1e-9d;
                case ForceChangeRateUnit.NewtonPerMinute: return baseUnitValue*60;
                case ForceChangeRateUnit.NewtonPerSecond: return baseUnitValue;
                case ForceChangeRateUnit.PoundForcePerMinute: return baseUnitValue/(32.174*0.45359237*0.3048)*60;
                case ForceChangeRateUnit.PoundForcePerSecond: return baseUnitValue/(32.174*0.45359237*0.3048);
                default:
                    throw new NotImplementedException($"Can not convert {Unit} to {unit}.");
            }
        }

        #endregion

    }
}

