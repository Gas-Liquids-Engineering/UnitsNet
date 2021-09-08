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
    ///     Torque, moment or moment of force (see the terminology below), is the tendency of a force to rotate an object about an axis,[1] fulcrum, or pivot. Just as a force is a push or a pull, a torque can be thought of as a twist to an object. Mathematically, torque is defined as the cross product of the lever-arm distance and force, which tends to produce rotation. Loosely speaking, torque is a measure of the turning force on an object such as a bolt or a flywheel. For example, pushing or pulling the handle of a wrench connected to a nut or bolt produces a torque (turning force) that loosens or tightens the nut or bolt.
    /// </summary>
    public struct  Torque
    {
        /// <summary>
        ///     The numeric value this quantity was constructed with.
        /// </summary>
        private readonly double _value;

        /// <summary>
        ///     The unit this quantity was constructed with.
        /// </summary>
        private readonly TorqueUnit _unit;

        /// <summary>
        ///     The numeric value this quantity was constructed with.
        /// </summary>
        public double Value => _value;

        /// <inheritdoc />
        public TorqueUnit Unit => _unit;
        /// <summary>
        ///     Creates the quantity with the given numeric value and unit.
        /// </summary>
        /// <param name="value">The numeric value to construct this quantity with.</param>
        /// <param name="unit">The unit representation to construct this quantity with.</param>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public Torque(double value, TorqueUnit unit)
        {
            _value = value;
            _unit = unit;
        }

        /// <summary>
        ///     The base unit of Duration, which is Second. All conversions go via this value.
        /// </summary>
        public static TorqueUnit BaseUnit { get; } = TorqueUnit.NewtonMeter;

        /// <summary>
        /// Represents the largest possible value of Duration
        /// </summary>
        public static Torque MaxValue { get; } = new Torque(double.MaxValue, BaseUnit);

        /// <summary>
        /// Represents the smallest possible value of Duration
        /// </summary>
        public static Torque MinValue { get; } = new Torque(double.MinValue, BaseUnit);
        /// <summary>
        ///     Gets an instance of this quantity with a value of 0 in the base unit Second.
        /// </summary>
        public static Torque Zero { get; } = new Torque(0, BaseUnit);
        #region Conversion Properties

        /// <summary>
        ///     Get Torque in KilogramForceCentimeters.
        /// </summary>
        public double KilogramForceCentimeters => As(TorqueUnit.KilogramForceCentimeter);

        /// <summary>
        ///     Get Torque in KilogramForceMeters.
        /// </summary>
        public double KilogramForceMeters => As(TorqueUnit.KilogramForceMeter);

        /// <summary>
        ///     Get Torque in KilogramForceMillimeters.
        /// </summary>
        public double KilogramForceMillimeters => As(TorqueUnit.KilogramForceMillimeter);

        /// <summary>
        ///     Get Torque in KilonewtonCentimeters.
        /// </summary>
        public double KilonewtonCentimeters => As(TorqueUnit.KilonewtonCentimeter);

        /// <summary>
        ///     Get Torque in KilonewtonMeters.
        /// </summary>
        public double KilonewtonMeters => As(TorqueUnit.KilonewtonMeter);

        /// <summary>
        ///     Get Torque in KilonewtonMillimeters.
        /// </summary>
        public double KilonewtonMillimeters => As(TorqueUnit.KilonewtonMillimeter);

        /// <summary>
        ///     Get Torque in KilopoundForceFeet.
        /// </summary>
        public double KilopoundForceFeet => As(TorqueUnit.KilopoundForceFoot);

        /// <summary>
        ///     Get Torque in KilopoundForceInches.
        /// </summary>
        public double KilopoundForceInches => As(TorqueUnit.KilopoundForceInch);

        /// <summary>
        ///     Get Torque in MeganewtonCentimeters.
        /// </summary>
        public double MeganewtonCentimeters => As(TorqueUnit.MeganewtonCentimeter);

        /// <summary>
        ///     Get Torque in MeganewtonMeters.
        /// </summary>
        public double MeganewtonMeters => As(TorqueUnit.MeganewtonMeter);

        /// <summary>
        ///     Get Torque in MeganewtonMillimeters.
        /// </summary>
        public double MeganewtonMillimeters => As(TorqueUnit.MeganewtonMillimeter);

        /// <summary>
        ///     Get Torque in MegapoundForceFeet.
        /// </summary>
        public double MegapoundForceFeet => As(TorqueUnit.MegapoundForceFoot);

        /// <summary>
        ///     Get Torque in MegapoundForceInches.
        /// </summary>
        public double MegapoundForceInches => As(TorqueUnit.MegapoundForceInch);

        /// <summary>
        ///     Get Torque in NewtonCentimeters.
        /// </summary>
        public double NewtonCentimeters => As(TorqueUnit.NewtonCentimeter);

        /// <summary>
        ///     Get Torque in NewtonMeters.
        /// </summary>
        public double NewtonMeters => As(TorqueUnit.NewtonMeter);

        /// <summary>
        ///     Get Torque in NewtonMillimeters.
        /// </summary>
        public double NewtonMillimeters => As(TorqueUnit.NewtonMillimeter);

        /// <summary>
        ///     Get Torque in PoundalFeet.
        /// </summary>
        public double PoundalFeet => As(TorqueUnit.PoundalFoot);

        /// <summary>
        ///     Get Torque in PoundForceFeet.
        /// </summary>
        public double PoundForceFeet => As(TorqueUnit.PoundForceFoot);

        /// <summary>
        ///     Get Torque in PoundForceInches.
        /// </summary>
        public double PoundForceInches => As(TorqueUnit.PoundForceInch);

        /// <summary>
        ///     Get Torque in TonneForceCentimeters.
        /// </summary>
        public double TonneForceCentimeters => As(TorqueUnit.TonneForceCentimeter);

        /// <summary>
        ///     Get Torque in TonneForceMeters.
        /// </summary>
        public double TonneForceMeters => As(TorqueUnit.TonneForceMeter);

        /// <summary>
        ///     Get Torque in TonneForceMillimeters.
        /// </summary>
        public double TonneForceMillimeters => As(TorqueUnit.TonneForceMillimeter);

        #endregion

        #region Static Factory Methods

        /// <summary>
        ///     Get Torque from KilogramForceCentimeters.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Torque FromKilogramForceCentimeters(double kilogramforcecentimeters) => new Torque(kilogramforcecentimeters, TorqueUnit.KilogramForceCentimeter);

        /// <summary>
        ///     Get Torque from KilogramForceMeters.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Torque FromKilogramForceMeters(double kilogramforcemeters) => new Torque(kilogramforcemeters, TorqueUnit.KilogramForceMeter);

        /// <summary>
        ///     Get Torque from KilogramForceMillimeters.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Torque FromKilogramForceMillimeters(double kilogramforcemillimeters) => new Torque(kilogramforcemillimeters, TorqueUnit.KilogramForceMillimeter);

        /// <summary>
        ///     Get Torque from KilonewtonCentimeters.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Torque FromKilonewtonCentimeters(double kilonewtoncentimeters) => new Torque(kilonewtoncentimeters, TorqueUnit.KilonewtonCentimeter);

        /// <summary>
        ///     Get Torque from KilonewtonMeters.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Torque FromKilonewtonMeters(double kilonewtonmeters) => new Torque(kilonewtonmeters, TorqueUnit.KilonewtonMeter);

        /// <summary>
        ///     Get Torque from KilonewtonMillimeters.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Torque FromKilonewtonMillimeters(double kilonewtonmillimeters) => new Torque(kilonewtonmillimeters, TorqueUnit.KilonewtonMillimeter);

        /// <summary>
        ///     Get Torque from KilopoundForceFeet.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Torque FromKilopoundForceFeet(double kilopoundforcefeet) => new Torque(kilopoundforcefeet, TorqueUnit.KilopoundForceFoot);

        /// <summary>
        ///     Get Torque from KilopoundForceInches.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Torque FromKilopoundForceInches(double kilopoundforceinches) => new Torque(kilopoundforceinches, TorqueUnit.KilopoundForceInch);

        /// <summary>
        ///     Get Torque from MeganewtonCentimeters.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Torque FromMeganewtonCentimeters(double meganewtoncentimeters) => new Torque(meganewtoncentimeters, TorqueUnit.MeganewtonCentimeter);

        /// <summary>
        ///     Get Torque from MeganewtonMeters.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Torque FromMeganewtonMeters(double meganewtonmeters) => new Torque(meganewtonmeters, TorqueUnit.MeganewtonMeter);

        /// <summary>
        ///     Get Torque from MeganewtonMillimeters.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Torque FromMeganewtonMillimeters(double meganewtonmillimeters) => new Torque(meganewtonmillimeters, TorqueUnit.MeganewtonMillimeter);

        /// <summary>
        ///     Get Torque from MegapoundForceFeet.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Torque FromMegapoundForceFeet(double megapoundforcefeet) => new Torque(megapoundforcefeet, TorqueUnit.MegapoundForceFoot);

        /// <summary>
        ///     Get Torque from MegapoundForceInches.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Torque FromMegapoundForceInches(double megapoundforceinches) => new Torque(megapoundforceinches, TorqueUnit.MegapoundForceInch);

        /// <summary>
        ///     Get Torque from NewtonCentimeters.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Torque FromNewtonCentimeters(double newtoncentimeters) => new Torque(newtoncentimeters, TorqueUnit.NewtonCentimeter);

        /// <summary>
        ///     Get Torque from NewtonMeters.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Torque FromNewtonMeters(double newtonmeters) => new Torque(newtonmeters, TorqueUnit.NewtonMeter);

        /// <summary>
        ///     Get Torque from NewtonMillimeters.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Torque FromNewtonMillimeters(double newtonmillimeters) => new Torque(newtonmillimeters, TorqueUnit.NewtonMillimeter);

        /// <summary>
        ///     Get Torque from PoundalFeet.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Torque FromPoundalFeet(double poundalfeet) => new Torque(poundalfeet, TorqueUnit.PoundalFoot);

        /// <summary>
        ///     Get Torque from PoundForceFeet.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Torque FromPoundForceFeet(double poundforcefeet) => new Torque(poundforcefeet, TorqueUnit.PoundForceFoot);

        /// <summary>
        ///     Get Torque from PoundForceInches.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Torque FromPoundForceInches(double poundforceinches) => new Torque(poundforceinches, TorqueUnit.PoundForceInch);

        /// <summary>
        ///     Get Torque from TonneForceCentimeters.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Torque FromTonneForceCentimeters(double tonneforcecentimeters) => new Torque(tonneforcecentimeters, TorqueUnit.TonneForceCentimeter);

        /// <summary>
        ///     Get Torque from TonneForceMeters.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Torque FromTonneForceMeters(double tonneforcemeters) => new Torque(tonneforcemeters, TorqueUnit.TonneForceMeter);

        /// <summary>
        ///     Get Torque from TonneForceMillimeters.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Torque FromTonneForceMillimeters(double tonneforcemillimeters) => new Torque(tonneforcemillimeters, TorqueUnit.TonneForceMillimeter);


        /// <summary>
        ///     Dynamically convert from value and unit enum <see cref="TorqueUnit" /> to <see cref="Torque" />.
        /// </summary>
        /// <param name="value">Value to convert from.</param>
        /// <param name="fromUnit">Unit to convert from.</param>
        /// <returns>Torque unit value.</returns>
        public static Torque From(double value, TorqueUnit fromUnit)
        {
            return new Torque(value, fromUnit);
        }

        #endregion

        #region Conversion Methods

        /// <summary>
        ///     Convert to the unit representation <paramref name="unit" />.
        /// </summary>
        /// <returns>Value converted to the specified unit.</returns>
        public double As(TorqueUnit unit) => GetValueAs(unit);        

        /// <summary>
        ///     Converts this Duration to another Duration with the unit representation <paramref name="unit" />.
        /// </summary>
        /// <returns>A Duration with the specified unit.</returns>
        public Torque ToUnit(TorqueUnit unit)
        {
                
            var convertedValue = GetValueAs(unit);
            return new Torque(convertedValue, unit);
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
                case TorqueUnit.KilogramForceCentimeter: return _value*0.0980665;
                case TorqueUnit.KilogramForceMeter: return _value*9.80665;
                case TorqueUnit.KilogramForceMillimeter: return _value*0.00980665;
                case TorqueUnit.KilonewtonCentimeter: return (_value*0.01) * 1e3d;
                case TorqueUnit.KilonewtonMeter: return (_value) * 1e3d;
                case TorqueUnit.KilonewtonMillimeter: return (_value*0.001) * 1e3d;
                case TorqueUnit.KilopoundForceFoot: return (_value*(32.174*0.3048*0.3048*0.45359237)) * 1e3d;
                case TorqueUnit.KilopoundForceInch: return (_value*(32.174*0.3048*0.45359237*0.0254)) * 1e3d;
                case TorqueUnit.MeganewtonCentimeter: return (_value*0.01) * 1e6d;
                case TorqueUnit.MeganewtonMeter: return (_value) * 1e6d;
                case TorqueUnit.MeganewtonMillimeter: return (_value*0.001) * 1e6d;
                case TorqueUnit.MegapoundForceFoot: return (_value*(32.174*0.3048*0.3048*0.45359237)) * 1e6d;
                case TorqueUnit.MegapoundForceInch: return (_value*(32.174*0.3048*0.45359237*0.0254)) * 1e6d;
                case TorqueUnit.NewtonCentimeter: return _value*0.01;
                case TorqueUnit.NewtonMeter: return _value;
                case TorqueUnit.NewtonMillimeter: return _value*0.001;
                case TorqueUnit.PoundalFoot: return _value*(0.45359237*0.3048*0.3048);
                case TorqueUnit.PoundForceFoot: return _value*(32.174*0.3048*0.3048*0.45359237);
                case TorqueUnit.PoundForceInch: return _value*(32.174*0.3048*0.45359237*0.0254);
                case TorqueUnit.TonneForceCentimeter: return _value*98.0665;
                case TorqueUnit.TonneForceMeter: return _value*9806.65;
                case TorqueUnit.TonneForceMillimeter: return _value*9.80665;
                default:
                    throw new NotImplementedException($"Can not convert {Unit} to base units.");
            }
        }

        private double GetValueAs(TorqueUnit unit)
        {
            if(Unit == unit)
                return _value;

            var baseUnitValue = GetValueInBaseUnit();

            switch(unit)
            {
                case TorqueUnit.KilogramForceCentimeter: return baseUnitValue/0.0980665;
                case TorqueUnit.KilogramForceMeter: return baseUnitValue/9.80665;
                case TorqueUnit.KilogramForceMillimeter: return baseUnitValue/0.00980665;
                case TorqueUnit.KilonewtonCentimeter: return (baseUnitValue*100) / 1e3d;
                case TorqueUnit.KilonewtonMeter: return (baseUnitValue) / 1e3d;
                case TorqueUnit.KilonewtonMillimeter: return (baseUnitValue*1000) / 1e3d;
                case TorqueUnit.KilopoundForceFoot: return (baseUnitValue/(32.174*0.3048*0.3048*0.45359237)) / 1e3d;
                case TorqueUnit.KilopoundForceInch: return (baseUnitValue/(32.174*0.3048*0.45359237*0.0254)) / 1e3d;
                case TorqueUnit.MeganewtonCentimeter: return (baseUnitValue*100) / 1e6d;
                case TorqueUnit.MeganewtonMeter: return (baseUnitValue) / 1e6d;
                case TorqueUnit.MeganewtonMillimeter: return (baseUnitValue*1000) / 1e6d;
                case TorqueUnit.MegapoundForceFoot: return (baseUnitValue/(32.174*0.3048*0.3048*0.45359237)) / 1e6d;
                case TorqueUnit.MegapoundForceInch: return (baseUnitValue/(32.174*0.3048*0.45359237*0.0254)) / 1e6d;
                case TorqueUnit.NewtonCentimeter: return baseUnitValue*100;
                case TorqueUnit.NewtonMeter: return baseUnitValue;
                case TorqueUnit.NewtonMillimeter: return baseUnitValue*1000;
                case TorqueUnit.PoundalFoot: return baseUnitValue/(0.45359237*0.3048*0.3048);
                case TorqueUnit.PoundForceFoot: return baseUnitValue/(32.174*0.3048*0.3048*0.45359237);
                case TorqueUnit.PoundForceInch: return baseUnitValue/(32.174*0.3048*0.45359237*0.0254);
                case TorqueUnit.TonneForceCentimeter: return baseUnitValue/98.0665;
                case TorqueUnit.TonneForceMeter: return baseUnitValue/9806.65;
                case TorqueUnit.TonneForceMillimeter: return baseUnitValue/9.80665;
                default:
                    throw new NotImplementedException($"Can not convert {Unit} to {unit}.");
            }
        }

        #endregion

    }
}

