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
    ///     A property of body reflects how its mass is distributed with regard to an axis.
    /// </summary>
    public struct  MassMomentOfInertia
    {
        /// <summary>
        ///     The numeric value this quantity was constructed with.
        /// </summary>
        private readonly double _value;

        /// <summary>
        ///     The unit this quantity was constructed with.
        /// </summary>
        private readonly MassMomentOfInertiaUnit _unit;

        /// <summary>
        ///     The numeric value this quantity was constructed with.
        /// </summary>
        public double Value => _value;

        /// <inheritdoc />
        public MassMomentOfInertiaUnit Unit => _unit;
        /// <summary>
        ///     Creates the quantity with the given numeric value and unit.
        /// </summary>
        /// <param name="value">The numeric value to construct this quantity with.</param>
        /// <param name="unit">The unit representation to construct this quantity with.</param>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public MassMomentOfInertia(double value, MassMomentOfInertiaUnit unit)
        {
            _value = value;
            _unit = unit;
        }

        /// <summary>
        ///     The base unit of Duration, which is Second. All conversions go via this value.
        /// </summary>
        public static MassMomentOfInertiaUnit BaseUnit { get; } = MassMomentOfInertiaUnit.KilogramSquareMeter;

        /// <summary>
        /// Represents the largest possible value of Duration
        /// </summary>
        public static MassMomentOfInertia MaxValue { get; } = new MassMomentOfInertia(double.MaxValue, BaseUnit);

        /// <summary>
        /// Represents the smallest possible value of Duration
        /// </summary>
        public static MassMomentOfInertia MinValue { get; } = new MassMomentOfInertia(double.MinValue, BaseUnit);
        /// <summary>
        ///     Gets an instance of this quantity with a value of 0 in the base unit Second.
        /// </summary>
        public static MassMomentOfInertia Zero { get; } = new MassMomentOfInertia(0, BaseUnit);
        #region Conversion Properties

        /// <summary>
        ///     Get MassMomentOfInertia in GramSquareCentimeters.
        /// </summary>
        public double GramSquareCentimeters => As(MassMomentOfInertiaUnit.GramSquareCentimeter);

        /// <summary>
        ///     Get MassMomentOfInertia in GramSquareDecimeters.
        /// </summary>
        public double GramSquareDecimeters => As(MassMomentOfInertiaUnit.GramSquareDecimeter);

        /// <summary>
        ///     Get MassMomentOfInertia in GramSquareMeters.
        /// </summary>
        public double GramSquareMeters => As(MassMomentOfInertiaUnit.GramSquareMeter);

        /// <summary>
        ///     Get MassMomentOfInertia in GramSquareMillimeters.
        /// </summary>
        public double GramSquareMillimeters => As(MassMomentOfInertiaUnit.GramSquareMillimeter);

        /// <summary>
        ///     Get MassMomentOfInertia in KilogramSquareCentimeters.
        /// </summary>
        public double KilogramSquareCentimeters => As(MassMomentOfInertiaUnit.KilogramSquareCentimeter);

        /// <summary>
        ///     Get MassMomentOfInertia in KilogramSquareDecimeters.
        /// </summary>
        public double KilogramSquareDecimeters => As(MassMomentOfInertiaUnit.KilogramSquareDecimeter);

        /// <summary>
        ///     Get MassMomentOfInertia in KilogramSquareMeters.
        /// </summary>
        public double KilogramSquareMeters => As(MassMomentOfInertiaUnit.KilogramSquareMeter);

        /// <summary>
        ///     Get MassMomentOfInertia in KilogramSquareMillimeters.
        /// </summary>
        public double KilogramSquareMillimeters => As(MassMomentOfInertiaUnit.KilogramSquareMillimeter);

        /// <summary>
        ///     Get MassMomentOfInertia in KilotonneSquareCentimeters.
        /// </summary>
        public double KilotonneSquareCentimeters => As(MassMomentOfInertiaUnit.KilotonneSquareCentimeter);

        /// <summary>
        ///     Get MassMomentOfInertia in KilotonneSquareDecimeters.
        /// </summary>
        public double KilotonneSquareDecimeters => As(MassMomentOfInertiaUnit.KilotonneSquareDecimeter);

        /// <summary>
        ///     Get MassMomentOfInertia in KilotonneSquareMeters.
        /// </summary>
        public double KilotonneSquareMeters => As(MassMomentOfInertiaUnit.KilotonneSquareMeter);

        /// <summary>
        ///     Get MassMomentOfInertia in KilotonneSquareMilimeters.
        /// </summary>
        public double KilotonneSquareMilimeters => As(MassMomentOfInertiaUnit.KilotonneSquareMilimeter);

        /// <summary>
        ///     Get MassMomentOfInertia in MegatonneSquareCentimeters.
        /// </summary>
        public double MegatonneSquareCentimeters => As(MassMomentOfInertiaUnit.MegatonneSquareCentimeter);

        /// <summary>
        ///     Get MassMomentOfInertia in MegatonneSquareDecimeters.
        /// </summary>
        public double MegatonneSquareDecimeters => As(MassMomentOfInertiaUnit.MegatonneSquareDecimeter);

        /// <summary>
        ///     Get MassMomentOfInertia in MegatonneSquareMeters.
        /// </summary>
        public double MegatonneSquareMeters => As(MassMomentOfInertiaUnit.MegatonneSquareMeter);

        /// <summary>
        ///     Get MassMomentOfInertia in MegatonneSquareMilimeters.
        /// </summary>
        public double MegatonneSquareMilimeters => As(MassMomentOfInertiaUnit.MegatonneSquareMilimeter);

        /// <summary>
        ///     Get MassMomentOfInertia in MilligramSquareCentimeters.
        /// </summary>
        public double MilligramSquareCentimeters => As(MassMomentOfInertiaUnit.MilligramSquareCentimeter);

        /// <summary>
        ///     Get MassMomentOfInertia in MilligramSquareDecimeters.
        /// </summary>
        public double MilligramSquareDecimeters => As(MassMomentOfInertiaUnit.MilligramSquareDecimeter);

        /// <summary>
        ///     Get MassMomentOfInertia in MilligramSquareMeters.
        /// </summary>
        public double MilligramSquareMeters => As(MassMomentOfInertiaUnit.MilligramSquareMeter);

        /// <summary>
        ///     Get MassMomentOfInertia in MilligramSquareMillimeters.
        /// </summary>
        public double MilligramSquareMillimeters => As(MassMomentOfInertiaUnit.MilligramSquareMillimeter);

        /// <summary>
        ///     Get MassMomentOfInertia in PoundSquareFeet.
        /// </summary>
        public double PoundSquareFeet => As(MassMomentOfInertiaUnit.PoundSquareFoot);

        /// <summary>
        ///     Get MassMomentOfInertia in PoundSquareInches.
        /// </summary>
        public double PoundSquareInches => As(MassMomentOfInertiaUnit.PoundSquareInch);

        /// <summary>
        ///     Get MassMomentOfInertia in SlugSquareFeet.
        /// </summary>
        public double SlugSquareFeet => As(MassMomentOfInertiaUnit.SlugSquareFoot);

        /// <summary>
        ///     Get MassMomentOfInertia in SlugSquareInches.
        /// </summary>
        public double SlugSquareInches => As(MassMomentOfInertiaUnit.SlugSquareInch);

        /// <summary>
        ///     Get MassMomentOfInertia in TonneSquareCentimeters.
        /// </summary>
        public double TonneSquareCentimeters => As(MassMomentOfInertiaUnit.TonneSquareCentimeter);

        /// <summary>
        ///     Get MassMomentOfInertia in TonneSquareDecimeters.
        /// </summary>
        public double TonneSquareDecimeters => As(MassMomentOfInertiaUnit.TonneSquareDecimeter);

        /// <summary>
        ///     Get MassMomentOfInertia in TonneSquareMeters.
        /// </summary>
        public double TonneSquareMeters => As(MassMomentOfInertiaUnit.TonneSquareMeter);

        /// <summary>
        ///     Get MassMomentOfInertia in TonneSquareMilimeters.
        /// </summary>
        public double TonneSquareMilimeters => As(MassMomentOfInertiaUnit.TonneSquareMilimeter);

        #endregion

        #region Static Factory Methods

        /// <summary>
        ///     Get MassMomentOfInertia from GramSquareCentimeters.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static MassMomentOfInertia FromGramSquareCentimeters(double gramsquarecentimeters) => new MassMomentOfInertia(gramsquarecentimeters, MassMomentOfInertiaUnit.GramSquareCentimeter);

        /// <summary>
        ///     Get MassMomentOfInertia from GramSquareDecimeters.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static MassMomentOfInertia FromGramSquareDecimeters(double gramsquaredecimeters) => new MassMomentOfInertia(gramsquaredecimeters, MassMomentOfInertiaUnit.GramSquareDecimeter);

        /// <summary>
        ///     Get MassMomentOfInertia from GramSquareMeters.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static MassMomentOfInertia FromGramSquareMeters(double gramsquaremeters) => new MassMomentOfInertia(gramsquaremeters, MassMomentOfInertiaUnit.GramSquareMeter);

        /// <summary>
        ///     Get MassMomentOfInertia from GramSquareMillimeters.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static MassMomentOfInertia FromGramSquareMillimeters(double gramsquaremillimeters) => new MassMomentOfInertia(gramsquaremillimeters, MassMomentOfInertiaUnit.GramSquareMillimeter);

        /// <summary>
        ///     Get MassMomentOfInertia from KilogramSquareCentimeters.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static MassMomentOfInertia FromKilogramSquareCentimeters(double kilogramsquarecentimeters) => new MassMomentOfInertia(kilogramsquarecentimeters, MassMomentOfInertiaUnit.KilogramSquareCentimeter);

        /// <summary>
        ///     Get MassMomentOfInertia from KilogramSquareDecimeters.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static MassMomentOfInertia FromKilogramSquareDecimeters(double kilogramsquaredecimeters) => new MassMomentOfInertia(kilogramsquaredecimeters, MassMomentOfInertiaUnit.KilogramSquareDecimeter);

        /// <summary>
        ///     Get MassMomentOfInertia from KilogramSquareMeters.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static MassMomentOfInertia FromKilogramSquareMeters(double kilogramsquaremeters) => new MassMomentOfInertia(kilogramsquaremeters, MassMomentOfInertiaUnit.KilogramSquareMeter);

        /// <summary>
        ///     Get MassMomentOfInertia from KilogramSquareMillimeters.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static MassMomentOfInertia FromKilogramSquareMillimeters(double kilogramsquaremillimeters) => new MassMomentOfInertia(kilogramsquaremillimeters, MassMomentOfInertiaUnit.KilogramSquareMillimeter);

        /// <summary>
        ///     Get MassMomentOfInertia from KilotonneSquareCentimeters.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static MassMomentOfInertia FromKilotonneSquareCentimeters(double kilotonnesquarecentimeters) => new MassMomentOfInertia(kilotonnesquarecentimeters, MassMomentOfInertiaUnit.KilotonneSquareCentimeter);

        /// <summary>
        ///     Get MassMomentOfInertia from KilotonneSquareDecimeters.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static MassMomentOfInertia FromKilotonneSquareDecimeters(double kilotonnesquaredecimeters) => new MassMomentOfInertia(kilotonnesquaredecimeters, MassMomentOfInertiaUnit.KilotonneSquareDecimeter);

        /// <summary>
        ///     Get MassMomentOfInertia from KilotonneSquareMeters.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static MassMomentOfInertia FromKilotonneSquareMeters(double kilotonnesquaremeters) => new MassMomentOfInertia(kilotonnesquaremeters, MassMomentOfInertiaUnit.KilotonneSquareMeter);

        /// <summary>
        ///     Get MassMomentOfInertia from KilotonneSquareMilimeters.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static MassMomentOfInertia FromKilotonneSquareMilimeters(double kilotonnesquaremilimeters) => new MassMomentOfInertia(kilotonnesquaremilimeters, MassMomentOfInertiaUnit.KilotonneSquareMilimeter);

        /// <summary>
        ///     Get MassMomentOfInertia from MegatonneSquareCentimeters.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static MassMomentOfInertia FromMegatonneSquareCentimeters(double megatonnesquarecentimeters) => new MassMomentOfInertia(megatonnesquarecentimeters, MassMomentOfInertiaUnit.MegatonneSquareCentimeter);

        /// <summary>
        ///     Get MassMomentOfInertia from MegatonneSquareDecimeters.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static MassMomentOfInertia FromMegatonneSquareDecimeters(double megatonnesquaredecimeters) => new MassMomentOfInertia(megatonnesquaredecimeters, MassMomentOfInertiaUnit.MegatonneSquareDecimeter);

        /// <summary>
        ///     Get MassMomentOfInertia from MegatonneSquareMeters.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static MassMomentOfInertia FromMegatonneSquareMeters(double megatonnesquaremeters) => new MassMomentOfInertia(megatonnesquaremeters, MassMomentOfInertiaUnit.MegatonneSquareMeter);

        /// <summary>
        ///     Get MassMomentOfInertia from MegatonneSquareMilimeters.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static MassMomentOfInertia FromMegatonneSquareMilimeters(double megatonnesquaremilimeters) => new MassMomentOfInertia(megatonnesquaremilimeters, MassMomentOfInertiaUnit.MegatonneSquareMilimeter);

        /// <summary>
        ///     Get MassMomentOfInertia from MilligramSquareCentimeters.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static MassMomentOfInertia FromMilligramSquareCentimeters(double milligramsquarecentimeters) => new MassMomentOfInertia(milligramsquarecentimeters, MassMomentOfInertiaUnit.MilligramSquareCentimeter);

        /// <summary>
        ///     Get MassMomentOfInertia from MilligramSquareDecimeters.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static MassMomentOfInertia FromMilligramSquareDecimeters(double milligramsquaredecimeters) => new MassMomentOfInertia(milligramsquaredecimeters, MassMomentOfInertiaUnit.MilligramSquareDecimeter);

        /// <summary>
        ///     Get MassMomentOfInertia from MilligramSquareMeters.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static MassMomentOfInertia FromMilligramSquareMeters(double milligramsquaremeters) => new MassMomentOfInertia(milligramsquaremeters, MassMomentOfInertiaUnit.MilligramSquareMeter);

        /// <summary>
        ///     Get MassMomentOfInertia from MilligramSquareMillimeters.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static MassMomentOfInertia FromMilligramSquareMillimeters(double milligramsquaremillimeters) => new MassMomentOfInertia(milligramsquaremillimeters, MassMomentOfInertiaUnit.MilligramSquareMillimeter);

        /// <summary>
        ///     Get MassMomentOfInertia from PoundSquareFeet.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static MassMomentOfInertia FromPoundSquareFeet(double poundsquarefeet) => new MassMomentOfInertia(poundsquarefeet, MassMomentOfInertiaUnit.PoundSquareFoot);

        /// <summary>
        ///     Get MassMomentOfInertia from PoundSquareInches.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static MassMomentOfInertia FromPoundSquareInches(double poundsquareinches) => new MassMomentOfInertia(poundsquareinches, MassMomentOfInertiaUnit.PoundSquareInch);

        /// <summary>
        ///     Get MassMomentOfInertia from SlugSquareFeet.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static MassMomentOfInertia FromSlugSquareFeet(double slugsquarefeet) => new MassMomentOfInertia(slugsquarefeet, MassMomentOfInertiaUnit.SlugSquareFoot);

        /// <summary>
        ///     Get MassMomentOfInertia from SlugSquareInches.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static MassMomentOfInertia FromSlugSquareInches(double slugsquareinches) => new MassMomentOfInertia(slugsquareinches, MassMomentOfInertiaUnit.SlugSquareInch);

        /// <summary>
        ///     Get MassMomentOfInertia from TonneSquareCentimeters.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static MassMomentOfInertia FromTonneSquareCentimeters(double tonnesquarecentimeters) => new MassMomentOfInertia(tonnesquarecentimeters, MassMomentOfInertiaUnit.TonneSquareCentimeter);

        /// <summary>
        ///     Get MassMomentOfInertia from TonneSquareDecimeters.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static MassMomentOfInertia FromTonneSquareDecimeters(double tonnesquaredecimeters) => new MassMomentOfInertia(tonnesquaredecimeters, MassMomentOfInertiaUnit.TonneSquareDecimeter);

        /// <summary>
        ///     Get MassMomentOfInertia from TonneSquareMeters.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static MassMomentOfInertia FromTonneSquareMeters(double tonnesquaremeters) => new MassMomentOfInertia(tonnesquaremeters, MassMomentOfInertiaUnit.TonneSquareMeter);

        /// <summary>
        ///     Get MassMomentOfInertia from TonneSquareMilimeters.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static MassMomentOfInertia FromTonneSquareMilimeters(double tonnesquaremilimeters) => new MassMomentOfInertia(tonnesquaremilimeters, MassMomentOfInertiaUnit.TonneSquareMilimeter);


        /// <summary>
        ///     Dynamically convert from value and unit enum <see cref="MassMomentOfInertiaUnit" /> to <see cref="MassMomentOfInertia" />.
        /// </summary>
        /// <param name="value">Value to convert from.</param>
        /// <param name="fromUnit">Unit to convert from.</param>
        /// <returns>MassMomentOfInertia unit value.</returns>
        public static MassMomentOfInertia From(double value, MassMomentOfInertiaUnit fromUnit)
        {
            return new MassMomentOfInertia(value, fromUnit);
        }

        #endregion

        #region Conversion Methods

        /// <summary>
        ///     Convert to the unit representation <paramref name="unit" />.
        /// </summary>
        /// <returns>Value converted to the specified unit.</returns>
        public double As(MassMomentOfInertiaUnit unit) => GetValueAs(unit);        

        /// <summary>
        ///     Converts this Duration to another Duration with the unit representation <paramref name="unit" />.
        /// </summary>
        /// <returns>A Duration with the specified unit.</returns>
        public MassMomentOfInertia ToUnit(MassMomentOfInertiaUnit unit)
        {
                
            var convertedValue = GetValueAs(unit);
            return new MassMomentOfInertia(convertedValue, unit);
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
                case MassMomentOfInertiaUnit.GramSquareCentimeter: return _value/1e7;
                case MassMomentOfInertiaUnit.GramSquareDecimeter: return _value/1e5;
                case MassMomentOfInertiaUnit.GramSquareMeter: return _value/1e3;
                case MassMomentOfInertiaUnit.GramSquareMillimeter: return _value/1e9;
                case MassMomentOfInertiaUnit.KilogramSquareCentimeter: return (_value/1e7) * 1e3d;
                case MassMomentOfInertiaUnit.KilogramSquareDecimeter: return (_value/1e5) * 1e3d;
                case MassMomentOfInertiaUnit.KilogramSquareMeter: return (_value/1e3) * 1e3d;
                case MassMomentOfInertiaUnit.KilogramSquareMillimeter: return (_value/1e9) * 1e3d;
                case MassMomentOfInertiaUnit.KilotonneSquareCentimeter: return (_value/1e1) * 1e3d;
                case MassMomentOfInertiaUnit.KilotonneSquareDecimeter: return (_value/1e-1) * 1e3d;
                case MassMomentOfInertiaUnit.KilotonneSquareMeter: return (_value/1e-3) * 1e3d;
                case MassMomentOfInertiaUnit.KilotonneSquareMilimeter: return (_value/1e3) * 1e3d;
                case MassMomentOfInertiaUnit.MegatonneSquareCentimeter: return (_value/1e1) * 1e6d;
                case MassMomentOfInertiaUnit.MegatonneSquareDecimeter: return (_value/1e-1) * 1e6d;
                case MassMomentOfInertiaUnit.MegatonneSquareMeter: return (_value/1e-3) * 1e6d;
                case MassMomentOfInertiaUnit.MegatonneSquareMilimeter: return (_value/1e3) * 1e6d;
                case MassMomentOfInertiaUnit.MilligramSquareCentimeter: return (_value/1e7) * 1e-3d;
                case MassMomentOfInertiaUnit.MilligramSquareDecimeter: return (_value/1e5) * 1e-3d;
                case MassMomentOfInertiaUnit.MilligramSquareMeter: return (_value/1e3) * 1e-3d;
                case MassMomentOfInertiaUnit.MilligramSquareMillimeter: return (_value/1e9) * 1e-3d;
                case MassMomentOfInertiaUnit.PoundSquareFoot: return _value*(0.45359237*0.3048*0.3048);
                case MassMomentOfInertiaUnit.PoundSquareInch: return _value*(0.45359237*0.0254*0.0254);
                case MassMomentOfInertiaUnit.SlugSquareFoot: return _value*(0.45359237*32.174*0.3048*0.3048);
                case MassMomentOfInertiaUnit.SlugSquareInch: return _value*(0.45359237*32.174*0.0254*0.0254);
                case MassMomentOfInertiaUnit.TonneSquareCentimeter: return _value/1e1;
                case MassMomentOfInertiaUnit.TonneSquareDecimeter: return _value/1e-1;
                case MassMomentOfInertiaUnit.TonneSquareMeter: return _value/1e-3;
                case MassMomentOfInertiaUnit.TonneSquareMilimeter: return _value/1e3;
                default:
                    throw new NotImplementedException($"Can not convert {Unit} to base units.");
            }
        }

        private double GetValueAs(MassMomentOfInertiaUnit unit)
        {
            if(Unit == unit)
                return _value;

            var baseUnitValue = GetValueInBaseUnit();

            switch(unit)
            {
                case MassMomentOfInertiaUnit.GramSquareCentimeter: return baseUnitValue*1e7;
                case MassMomentOfInertiaUnit.GramSquareDecimeter: return baseUnitValue*1e5;
                case MassMomentOfInertiaUnit.GramSquareMeter: return baseUnitValue*1e3;
                case MassMomentOfInertiaUnit.GramSquareMillimeter: return baseUnitValue*1e9;
                case MassMomentOfInertiaUnit.KilogramSquareCentimeter: return (baseUnitValue*1e7) / 1e3d;
                case MassMomentOfInertiaUnit.KilogramSquareDecimeter: return (baseUnitValue*1e5) / 1e3d;
                case MassMomentOfInertiaUnit.KilogramSquareMeter: return (baseUnitValue*1e3) / 1e3d;
                case MassMomentOfInertiaUnit.KilogramSquareMillimeter: return (baseUnitValue*1e9) / 1e3d;
                case MassMomentOfInertiaUnit.KilotonneSquareCentimeter: return (baseUnitValue*1e1) / 1e3d;
                case MassMomentOfInertiaUnit.KilotonneSquareDecimeter: return (baseUnitValue*1e-1) / 1e3d;
                case MassMomentOfInertiaUnit.KilotonneSquareMeter: return (baseUnitValue*1e-3) / 1e3d;
                case MassMomentOfInertiaUnit.KilotonneSquareMilimeter: return (baseUnitValue*1e3) / 1e3d;
                case MassMomentOfInertiaUnit.MegatonneSquareCentimeter: return (baseUnitValue*1e1) / 1e6d;
                case MassMomentOfInertiaUnit.MegatonneSquareDecimeter: return (baseUnitValue*1e-1) / 1e6d;
                case MassMomentOfInertiaUnit.MegatonneSquareMeter: return (baseUnitValue*1e-3) / 1e6d;
                case MassMomentOfInertiaUnit.MegatonneSquareMilimeter: return (baseUnitValue*1e3) / 1e6d;
                case MassMomentOfInertiaUnit.MilligramSquareCentimeter: return (baseUnitValue*1e7) / 1e-3d;
                case MassMomentOfInertiaUnit.MilligramSquareDecimeter: return (baseUnitValue*1e5) / 1e-3d;
                case MassMomentOfInertiaUnit.MilligramSquareMeter: return (baseUnitValue*1e3) / 1e-3d;
                case MassMomentOfInertiaUnit.MilligramSquareMillimeter: return (baseUnitValue*1e9) / 1e-3d;
                case MassMomentOfInertiaUnit.PoundSquareFoot: return baseUnitValue/(0.45359237*0.3048*0.3048);
                case MassMomentOfInertiaUnit.PoundSquareInch: return baseUnitValue/(0.45359237*0.0254*0.0254);
                case MassMomentOfInertiaUnit.SlugSquareFoot: return baseUnitValue/(0.45359237*32.174*0.3048*0.3048);
                case MassMomentOfInertiaUnit.SlugSquareInch: return baseUnitValue/(0.45359237*32.174*0.0254*0.0254);
                case MassMomentOfInertiaUnit.TonneSquareCentimeter: return baseUnitValue*1e1;
                case MassMomentOfInertiaUnit.TonneSquareDecimeter: return baseUnitValue*1e-1;
                case MassMomentOfInertiaUnit.TonneSquareMeter: return baseUnitValue*1e-3;
                case MassMomentOfInertiaUnit.TonneSquareMilimeter: return baseUnitValue*1e3;
                default:
                    throw new NotImplementedException($"Can not convert {Unit} to {unit}.");
            }
        }

        #endregion

    }
}

