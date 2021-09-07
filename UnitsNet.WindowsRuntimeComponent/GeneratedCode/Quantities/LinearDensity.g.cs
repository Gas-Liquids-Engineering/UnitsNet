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
using System.Globalization;
using System.Linq;
using JetBrains.Annotations;
using UnitsNet.Units;
using UnitsNet.InternalHelpers;

// ReSharper disable once CheckNamespace

namespace UnitsNet
{
    /// <summary>
    ///     The Linear Density, or more precisely, the linear mass density, of a substance is its mass per unit length.  The term linear density is most often used when describing the characteristics of one-dimensional objects, although linear density can also be used to describe the density of a three-dimensional quantity along one particular dimension.
    /// </summary>
    /// <remarks>
    ///     http://en.wikipedia.org/wiki/Linear_density
    /// </remarks>
    // Windows Runtime Component has constraints on public types: https://msdn.microsoft.com/en-us/library/br230301.aspx#Declaring types in Windows Runtime Components
    // Public structures can't have any members other than public fields, and those fields must be value types or strings.
    // Public classes must be sealed (NotInheritable in Visual Basic). If your programming model requires polymorphism, you can create a public interface and implement that interface on the classes that must be polymorphic.
    public sealed partial class LinearDensity : IQuantity
    {
        /// <summary>
        ///     The numeric value this quantity was constructed with.
        /// </summary>
        private readonly double _value;

        /// <summary>
        ///     The unit this quantity was constructed with.
        /// </summary>
        private readonly LinearDensityUnit? _unit;

        static LinearDensity()
        {
            BaseDimensions = new BaseDimensions(-1, 1, 0, 0, 0, 0, 0);
            Info = new QuantityInfo(QuantityType.LinearDensity, Units.Cast<Enum>().ToArray(), BaseUnit, Zero, BaseDimensions);
        }

        /// <summary>
        ///     Creates the quantity with a value of 0 in the base unit KilogramPerMeter.
        /// </summary>
        /// <remarks>
        ///     Windows Runtime Component requires a default constructor.
        /// </remarks>
        public LinearDensity()
        {
            _value = 0;
            _unit = BaseUnit;
        }

        /// <summary>
        ///     Creates the quantity with the given numeric value and unit.
        /// </summary>
        /// <param name="value">The numeric value to construct this quantity with.</param>
        /// <param name="unit">The unit representation to construct this quantity with.</param>
        /// <remarks>Value parameter cannot be named 'value' due to constraint when targeting Windows Runtime Component.</remarks>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        private LinearDensity(double value, LinearDensityUnit unit)
        {
            if(unit == LinearDensityUnit.Undefined)
              throw new ArgumentException("The quantity can not be created with an undefined unit.", nameof(unit));

            _value = Guard.EnsureValidNumber(value, nameof(value));
            _unit = unit;
        }

        #region Static Properties

        /// <summary>
        ///     Information about the quantity type, such as unit values and names.
        /// </summary>
        internal static QuantityInfo Info { get; }

        /// <summary>
        ///     The <see cref="BaseDimensions" /> of this quantity.
        /// </summary>
        public static BaseDimensions BaseDimensions { get; }

        /// <summary>
        ///     The base unit of LinearDensity, which is KilogramPerMeter. All conversions go via this value.
        /// </summary>
        public static LinearDensityUnit BaseUnit { get; } = LinearDensityUnit.KilogramPerMeter;

        /// <summary>
        /// Represents the largest possible value of LinearDensity
        /// </summary>
        public static LinearDensity MaxValue { get; } = new LinearDensity(double.MaxValue, BaseUnit);

        /// <summary>
        /// Represents the smallest possible value of LinearDensity
        /// </summary>
        public static LinearDensity MinValue { get; } = new LinearDensity(double.MinValue, BaseUnit);

        /// <summary>
        ///     The <see cref="QuantityType" /> of this quantity.
        /// </summary>
        public static QuantityType QuantityType { get; } = QuantityType.LinearDensity;

        /// <summary>
        ///     All units of measurement for the LinearDensity quantity.
        /// </summary>
        public static LinearDensityUnit[] Units { get; } = Enum.GetValues(typeof(LinearDensityUnit)).Cast<LinearDensityUnit>().Except(new LinearDensityUnit[]{ LinearDensityUnit.Undefined }).ToArray();

        /// <summary>
        ///     Gets an instance of this quantity with a value of 0 in the base unit KilogramPerMeter.
        /// </summary>
        public static LinearDensity Zero { get; } = new LinearDensity(0, BaseUnit);

        #endregion

        #region Properties

        /// <summary>
        ///     The numeric value this quantity was constructed with.
        /// </summary>
        public double Value => Convert.ToDouble(_value);

        /// <inheritdoc cref="IQuantity.Unit"/>
        object IQuantity.Unit => Unit;

        /// <summary>
        ///     The unit this quantity was constructed with -or- <see cref="BaseUnit" /> if default ctor was used.
        /// </summary>
        public LinearDensityUnit Unit => _unit.GetValueOrDefault(BaseUnit);

        internal QuantityInfo QuantityInfo => Info;

        /// <summary>
        ///     The <see cref="QuantityType" /> of this quantity.
        /// </summary>
        public QuantityType Type => LinearDensity.QuantityType;

        /// <summary>
        ///     The <see cref="BaseDimensions" /> of this quantity.
        /// </summary>
        public BaseDimensions Dimensions => LinearDensity.BaseDimensions;

        #endregion

        #region Conversion Properties

        /// <summary>
        ///     Get LinearDensity in GramsPerCentimeter.
        /// </summary>
        public double GramsPerCentimeter => As(LinearDensityUnit.GramPerCentimeter);

        /// <summary>
        ///     Get LinearDensity in GramsPerMeter.
        /// </summary>
        public double GramsPerMeter => As(LinearDensityUnit.GramPerMeter);

        /// <summary>
        ///     Get LinearDensity in GramsPerMillimeter.
        /// </summary>
        public double GramsPerMillimeter => As(LinearDensityUnit.GramPerMillimeter);

        /// <summary>
        ///     Get LinearDensity in KilogramsPerCentimeter.
        /// </summary>
        public double KilogramsPerCentimeter => As(LinearDensityUnit.KilogramPerCentimeter);

        /// <summary>
        ///     Get LinearDensity in KilogramsPerMeter.
        /// </summary>
        public double KilogramsPerMeter => As(LinearDensityUnit.KilogramPerMeter);

        /// <summary>
        ///     Get LinearDensity in KilogramsPerMillimeter.
        /// </summary>
        public double KilogramsPerMillimeter => As(LinearDensityUnit.KilogramPerMillimeter);

        /// <summary>
        ///     Get LinearDensity in MicrogramsPerCentimeter.
        /// </summary>
        public double MicrogramsPerCentimeter => As(LinearDensityUnit.MicrogramPerCentimeter);

        /// <summary>
        ///     Get LinearDensity in MicrogramsPerMeter.
        /// </summary>
        public double MicrogramsPerMeter => As(LinearDensityUnit.MicrogramPerMeter);

        /// <summary>
        ///     Get LinearDensity in MicrogramsPerMillimeter.
        /// </summary>
        public double MicrogramsPerMillimeter => As(LinearDensityUnit.MicrogramPerMillimeter);

        /// <summary>
        ///     Get LinearDensity in MilligramsPerCentimeter.
        /// </summary>
        public double MilligramsPerCentimeter => As(LinearDensityUnit.MilligramPerCentimeter);

        /// <summary>
        ///     Get LinearDensity in MilligramsPerMeter.
        /// </summary>
        public double MilligramsPerMeter => As(LinearDensityUnit.MilligramPerMeter);

        /// <summary>
        ///     Get LinearDensity in MilligramsPerMillimeter.
        /// </summary>
        public double MilligramsPerMillimeter => As(LinearDensityUnit.MilligramPerMillimeter);

        /// <summary>
        ///     Get LinearDensity in PoundsPerFoot.
        /// </summary>
        public double PoundsPerFoot => As(LinearDensityUnit.PoundPerFoot);

        /// <summary>
        ///     Get LinearDensity in PoundsPerInch.
        /// </summary>
        public double PoundsPerInch => As(LinearDensityUnit.PoundPerInch);

        #endregion

        #region Static Methods

        /// <summary>
        ///     Get unit abbreviation string.
        /// </summary>
        /// <param name="unit">Unit to get abbreviation for.</param>
        /// <returns>Unit abbreviation string.</returns>
        public static string GetAbbreviation(LinearDensityUnit unit)
        {
            return GetAbbreviation(unit, null);
        }

        /// <summary>
        ///     Get unit abbreviation string.
        /// </summary>
        /// <param name="unit">Unit to get abbreviation for.</param>
        /// <returns>Unit abbreviation string.</returns>
        /// <param name="cultureName">Name of culture (ex: "en-US") to use when parsing number and unit. Defaults to <see cref="GlobalConfiguration.DefaultCulture" /> if null.</param>
        public static string GetAbbreviation(LinearDensityUnit unit, [CanBeNull] string cultureName)
        {
            IFormatProvider provider = GetFormatProviderFromCultureName(cultureName);
            return UnitAbbreviationsCache.Default.GetDefaultAbbreviation(unit, provider);
        }

        #endregion

        #region Static Factory Methods

        /// <summary>
        ///     Get LinearDensity from GramsPerCentimeter.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        [Windows.Foundation.Metadata.DefaultOverload]
        public static LinearDensity FromGramsPerCentimeter(double gramspercentimeter)
        {
            double value = (double) gramspercentimeter;
            return new LinearDensity(value, LinearDensityUnit.GramPerCentimeter);
        }
        /// <summary>
        ///     Get LinearDensity from GramsPerMeter.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        [Windows.Foundation.Metadata.DefaultOverload]
        public static LinearDensity FromGramsPerMeter(double gramspermeter)
        {
            double value = (double) gramspermeter;
            return new LinearDensity(value, LinearDensityUnit.GramPerMeter);
        }
        /// <summary>
        ///     Get LinearDensity from GramsPerMillimeter.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        [Windows.Foundation.Metadata.DefaultOverload]
        public static LinearDensity FromGramsPerMillimeter(double gramspermillimeter)
        {
            double value = (double) gramspermillimeter;
            return new LinearDensity(value, LinearDensityUnit.GramPerMillimeter);
        }
        /// <summary>
        ///     Get LinearDensity from KilogramsPerCentimeter.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        [Windows.Foundation.Metadata.DefaultOverload]
        public static LinearDensity FromKilogramsPerCentimeter(double kilogramspercentimeter)
        {
            double value = (double) kilogramspercentimeter;
            return new LinearDensity(value, LinearDensityUnit.KilogramPerCentimeter);
        }
        /// <summary>
        ///     Get LinearDensity from KilogramsPerMeter.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        [Windows.Foundation.Metadata.DefaultOverload]
        public static LinearDensity FromKilogramsPerMeter(double kilogramspermeter)
        {
            double value = (double) kilogramspermeter;
            return new LinearDensity(value, LinearDensityUnit.KilogramPerMeter);
        }
        /// <summary>
        ///     Get LinearDensity from KilogramsPerMillimeter.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        [Windows.Foundation.Metadata.DefaultOverload]
        public static LinearDensity FromKilogramsPerMillimeter(double kilogramspermillimeter)
        {
            double value = (double) kilogramspermillimeter;
            return new LinearDensity(value, LinearDensityUnit.KilogramPerMillimeter);
        }
        /// <summary>
        ///     Get LinearDensity from MicrogramsPerCentimeter.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        [Windows.Foundation.Metadata.DefaultOverload]
        public static LinearDensity FromMicrogramsPerCentimeter(double microgramspercentimeter)
        {
            double value = (double) microgramspercentimeter;
            return new LinearDensity(value, LinearDensityUnit.MicrogramPerCentimeter);
        }
        /// <summary>
        ///     Get LinearDensity from MicrogramsPerMeter.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        [Windows.Foundation.Metadata.DefaultOverload]
        public static LinearDensity FromMicrogramsPerMeter(double microgramspermeter)
        {
            double value = (double) microgramspermeter;
            return new LinearDensity(value, LinearDensityUnit.MicrogramPerMeter);
        }
        /// <summary>
        ///     Get LinearDensity from MicrogramsPerMillimeter.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        [Windows.Foundation.Metadata.DefaultOverload]
        public static LinearDensity FromMicrogramsPerMillimeter(double microgramspermillimeter)
        {
            double value = (double) microgramspermillimeter;
            return new LinearDensity(value, LinearDensityUnit.MicrogramPerMillimeter);
        }
        /// <summary>
        ///     Get LinearDensity from MilligramsPerCentimeter.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        [Windows.Foundation.Metadata.DefaultOverload]
        public static LinearDensity FromMilligramsPerCentimeter(double milligramspercentimeter)
        {
            double value = (double) milligramspercentimeter;
            return new LinearDensity(value, LinearDensityUnit.MilligramPerCentimeter);
        }
        /// <summary>
        ///     Get LinearDensity from MilligramsPerMeter.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        [Windows.Foundation.Metadata.DefaultOverload]
        public static LinearDensity FromMilligramsPerMeter(double milligramspermeter)
        {
            double value = (double) milligramspermeter;
            return new LinearDensity(value, LinearDensityUnit.MilligramPerMeter);
        }
        /// <summary>
        ///     Get LinearDensity from MilligramsPerMillimeter.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        [Windows.Foundation.Metadata.DefaultOverload]
        public static LinearDensity FromMilligramsPerMillimeter(double milligramspermillimeter)
        {
            double value = (double) milligramspermillimeter;
            return new LinearDensity(value, LinearDensityUnit.MilligramPerMillimeter);
        }
        /// <summary>
        ///     Get LinearDensity from PoundsPerFoot.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        [Windows.Foundation.Metadata.DefaultOverload]
        public static LinearDensity FromPoundsPerFoot(double poundsperfoot)
        {
            double value = (double) poundsperfoot;
            return new LinearDensity(value, LinearDensityUnit.PoundPerFoot);
        }
        /// <summary>
        ///     Get LinearDensity from PoundsPerInch.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        [Windows.Foundation.Metadata.DefaultOverload]
        public static LinearDensity FromPoundsPerInch(double poundsperinch)
        {
            double value = (double) poundsperinch;
            return new LinearDensity(value, LinearDensityUnit.PoundPerInch);
        }

        /// <summary>
        ///     Dynamically convert from value and unit enum <see cref="LinearDensityUnit" /> to <see cref="LinearDensity" />.
        /// </summary>
        /// <param name="value">Value to convert from.</param>
        /// <param name="fromUnit">Unit to convert from.</param>
        /// <returns>LinearDensity unit value.</returns>
        // Fix name conflict with parameter "value"
        [return: System.Runtime.InteropServices.WindowsRuntime.ReturnValueName("returnValue")]
        public static LinearDensity From(double value, LinearDensityUnit fromUnit)
        {
            return new LinearDensity((double)value, fromUnit);
        }

        #endregion

        #region Static Parse Methods

        /// <summary>
        ///     Parse a string with one or two quantities of the format "&lt;quantity&gt; &lt;unit&gt;".
        /// </summary>
        /// <param name="str">String to parse. Typically in the form: {number} {unit}</param>
        /// <example>
        ///     Length.Parse("5.5 m", new CultureInfo("en-US"));
        /// </example>
        /// <exception cref="ArgumentNullException">The value of 'str' cannot be null. </exception>
        /// <exception cref="ArgumentException">
        ///     Expected string to have one or two pairs of quantity and unit in the format
        ///     "&lt;quantity&gt; &lt;unit&gt;". Eg. "5.5 m" or "1ft 2in"
        /// </exception>
        /// <exception cref="AmbiguousUnitParseException">
        ///     More than one unit is represented by the specified unit abbreviation.
        ///     Example: Volume.Parse("1 cup") will throw, because it can refer to any of
        ///     <see cref="VolumeUnit.MetricCup" />, <see cref="VolumeUnit.UsLegalCup" /> and <see cref="VolumeUnit.UsCustomaryCup" />.
        /// </exception>
        /// <exception cref="UnitsNetException">
        ///     If anything else goes wrong, typically due to a bug or unhandled case.
        ///     We wrap exceptions in <see cref="UnitsNetException" /> to allow you to distinguish
        ///     Units.NET exceptions from other exceptions.
        /// </exception>
        public static LinearDensity Parse(string str)
        {
            return Parse(str, null);
        }

        /// <summary>
        ///     Parse a string with one or two quantities of the format "&lt;quantity&gt; &lt;unit&gt;".
        /// </summary>
        /// <param name="str">String to parse. Typically in the form: {number} {unit}</param>
        /// <example>
        ///     Length.Parse("5.5 m", new CultureInfo("en-US"));
        /// </example>
        /// <exception cref="ArgumentNullException">The value of 'str' cannot be null. </exception>
        /// <exception cref="ArgumentException">
        ///     Expected string to have one or two pairs of quantity and unit in the format
        ///     "&lt;quantity&gt; &lt;unit&gt;". Eg. "5.5 m" or "1ft 2in"
        /// </exception>
        /// <exception cref="AmbiguousUnitParseException">
        ///     More than one unit is represented by the specified unit abbreviation.
        ///     Example: Volume.Parse("1 cup") will throw, because it can refer to any of
        ///     <see cref="VolumeUnit.MetricCup" />, <see cref="VolumeUnit.UsLegalCup" /> and <see cref="VolumeUnit.UsCustomaryCup" />.
        /// </exception>
        /// <exception cref="UnitsNetException">
        ///     If anything else goes wrong, typically due to a bug or unhandled case.
        ///     We wrap exceptions in <see cref="UnitsNetException" /> to allow you to distinguish
        ///     Units.NET exceptions from other exceptions.
        /// </exception>
        /// <param name="cultureName">Name of culture (ex: "en-US") to use when parsing number and unit. Defaults to <see cref="GlobalConfiguration.DefaultCulture" /> if null.</param>
        public static LinearDensity Parse(string str, [CanBeNull] string cultureName)
        {
            IFormatProvider provider = GetFormatProviderFromCultureName(cultureName);
            return QuantityParser.Default.Parse<LinearDensity, LinearDensityUnit>(
                str,
                provider,
                From);
        }

        /// <summary>
        ///     Try to parse a string with one or two quantities of the format "&lt;quantity&gt; &lt;unit&gt;".
        /// </summary>
        /// <param name="str">String to parse. Typically in the form: {number} {unit}</param>
        /// <param name="result">Resulting unit quantity if successful.</param>
        /// <example>
        ///     Length.Parse("5.5 m", new CultureInfo("en-US"));
        /// </example>
        public static bool TryParse([CanBeNull] string str, out LinearDensity result)
        {
            return TryParse(str, null, out result);
        }

        /// <summary>
        ///     Try to parse a string with one or two quantities of the format "&lt;quantity&gt; &lt;unit&gt;".
        /// </summary>
        /// <param name="str">String to parse. Typically in the form: {number} {unit}</param>
        /// <param name="result">Resulting unit quantity if successful.</param>
        /// <returns>True if successful, otherwise false.</returns>
        /// <example>
        ///     Length.Parse("5.5 m", new CultureInfo("en-US"));
        /// </example>
        /// <param name="cultureName">Name of culture (ex: "en-US") to use when parsing number and unit. Defaults to <see cref="GlobalConfiguration.DefaultCulture" /> if null.</param>
        public static bool TryParse([CanBeNull] string str, [CanBeNull] string cultureName, out LinearDensity result)
        {
            IFormatProvider provider = GetFormatProviderFromCultureName(cultureName);
            return QuantityParser.Default.TryParse<LinearDensity, LinearDensityUnit>(
                str,
                provider,
                From,
                out result);
        }

        /// <summary>
        ///     Parse a unit string.
        /// </summary>
        /// <param name="str">String to parse. Typically in the form: {number} {unit}</param>
        /// <example>
        ///     Length.ParseUnit("m", new CultureInfo("en-US"));
        /// </example>
        /// <exception cref="ArgumentNullException">The value of 'str' cannot be null. </exception>
        /// <exception cref="UnitsNetException">Error parsing string.</exception>
        public static LinearDensityUnit ParseUnit(string str)
        {
            return ParseUnit(str, null);
        }

        /// <summary>
        ///     Parse a unit string.
        /// </summary>
        /// <param name="str">String to parse. Typically in the form: {number} {unit}</param>
        /// <example>
        ///     Length.ParseUnit("m", new CultureInfo("en-US"));
        /// </example>
        /// <exception cref="ArgumentNullException">The value of 'str' cannot be null. </exception>
        /// <exception cref="UnitsNetException">Error parsing string.</exception>
        /// <param name="cultureName">Name of culture (ex: "en-US") to use when parsing number and unit. Defaults to <see cref="GlobalConfiguration.DefaultCulture" /> if null.</param>
        public static LinearDensityUnit ParseUnit(string str, [CanBeNull] string cultureName)
        {
            IFormatProvider provider = GetFormatProviderFromCultureName(cultureName);
            return UnitParser.Default.Parse<LinearDensityUnit>(str, provider);
        }

        public static bool TryParseUnit(string str, out LinearDensityUnit unit)
        {
            return TryParseUnit(str, null, out unit);
        }

        /// <summary>
        ///     Parse a unit string.
        /// </summary>
        /// <param name="str">String to parse. Typically in the form: {number} {unit}</param>
        /// <param name="unit">The parsed unit if successful.</param>
        /// <returns>True if successful, otherwise false.</returns>
        /// <example>
        ///     Length.TryParseUnit("m", new CultureInfo("en-US"));
        /// </example>
        /// <param name="cultureName">Name of culture (ex: "en-US") to use when parsing number and unit. Defaults to <see cref="GlobalConfiguration.DefaultCulture" /> if null.</param>
        public static bool TryParseUnit(string str, [CanBeNull] string cultureName, out LinearDensityUnit unit)
        {
            IFormatProvider provider = GetFormatProviderFromCultureName(cultureName);
            return UnitParser.Default.TryParse<LinearDensityUnit>(str, provider, out unit);
        }

        #endregion

        #region Equality / IComparable

        public int CompareTo(object obj)
        {
            if(obj is null) throw new ArgumentNullException(nameof(obj));
            if(!(obj is LinearDensity objLinearDensity)) throw new ArgumentException("Expected type LinearDensity.", nameof(obj));

            return CompareTo(objLinearDensity);
        }

        // Windows Runtime Component does not allow public methods/ctors with same number of parameters: https://msdn.microsoft.com/en-us/library/br230301.aspx#Overloaded methods
        internal int CompareTo(LinearDensity other)
        {
            return _value.CompareTo(other.AsBaseNumericType(this.Unit));
        }

        [Windows.Foundation.Metadata.DefaultOverload]
        public override bool Equals(object obj)
        {
            if(obj is null || !(obj is LinearDensity objLinearDensity))
                return false;

            return Equals(objLinearDensity);
        }

        public bool Equals(LinearDensity other)
        {
            return _value.Equals(other.AsBaseNumericType(this.Unit));
        }

        /// <summary>
        ///     <para>
        ///     Compare equality to another LinearDensity within the given absolute or relative tolerance.
        ///     </para>
        ///     <para>
        ///     Relative tolerance is defined as the maximum allowable absolute difference between this quantity's value and
        ///     <paramref name="other"/> as a percentage of this quantity's value. <paramref name="other"/> will be converted into
        ///     this quantity's unit for comparison. A relative tolerance of 0.01 means the absolute difference must be within +/- 1% of
        ///     this quantity's value to be considered equal.
        ///     <example>
        ///     In this example, the two quantities will be equal if the value of b is within +/- 1% of a (0.02m or 2cm).
        ///     <code>
        ///     var a = Length.FromMeters(2.0);
        ///     var b = Length.FromInches(50.0);
        ///     a.Equals(b, 0.01, ComparisonType.Relative);
        ///     </code>
        ///     </example>
        ///     </para>
        ///     <para>
        ///     Absolute tolerance is defined as the maximum allowable absolute difference between this quantity's value and
        ///     <paramref name="other"/> as a fixed number in this quantity's unit. <paramref name="other"/> will be converted into
        ///     this quantity's unit for comparison.
        ///     <example>
        ///     In this example, the two quantities will be equal if the value of b is within 0.01 of a (0.01m or 1cm).
        ///     <code>
        ///     var a = Length.FromMeters(2.0);
        ///     var b = Length.FromInches(50.0);
        ///     a.Equals(b, 0.01, ComparisonType.Absolute);
        ///     </code>
        ///     </example>
        ///     </para>
        ///     <para>
        ///     Note that it is advised against specifying zero difference, due to the nature
        ///     of floating point operations and using System.Double internally.
        ///     </para>
        /// </summary>
        /// <param name="other">The other quantity to compare to.</param>
        /// <param name="tolerance">The absolute or relative tolerance value. Must be greater than or equal to 0.</param>
        /// <param name="comparisonType">The comparison type: either relative or absolute.</param>
        /// <returns>True if the absolute difference between the two values is not greater than the specified relative or absolute tolerance.</returns>
        public bool Equals(LinearDensity other, double tolerance, ComparisonType comparisonType)
        {
            if(tolerance < 0)
                throw new ArgumentOutOfRangeException("tolerance", "Tolerance must be greater than or equal to 0.");

            double thisValue = (double)this.Value;
            double otherValueInThisUnits = other.As(this.Unit);

            return UnitsNet.Comparison.Equals(thisValue, otherValueInThisUnits, tolerance, comparisonType);
        }

        /// <summary>
        ///     Returns the hash code for this instance.
        /// </summary>
        /// <returns>A hash code for the current LinearDensity.</returns>
        public override int GetHashCode()
        {
            return new { QuantityType, Value, Unit }.GetHashCode();
        }

        #endregion

        #region Conversion Methods

        double IQuantity.As(object unit) => As((LinearDensityUnit)unit);

        /// <summary>
        ///     Convert to the unit representation <paramref name="unit" />.
        /// </summary>
        /// <returns>Value converted to the specified unit.</returns>
        public double As(LinearDensityUnit unit)
        {
            if(Unit == unit)
                return Convert.ToDouble(Value);

            var converted = AsBaseNumericType(unit);
            return Convert.ToDouble(converted);
        }

        /// <summary>
        ///     Converts this LinearDensity to another LinearDensity with the unit representation <paramref name="unit" />.
        /// </summary>
        /// <returns>A LinearDensity with the specified unit.</returns>
        public LinearDensity ToUnit(LinearDensityUnit unit)
        {
            var convertedValue = AsBaseNumericType(unit);
            return new LinearDensity(convertedValue, unit);
        }

        /// <summary>
        ///     Converts the current value + unit to the base unit.
        ///     This is typically the first step in converting from one unit to another.
        /// </summary>
        /// <returns>The value in the base unit representation.</returns>
        private double AsBaseUnit()
        {
            switch(Unit)
            {
                case LinearDensityUnit.GramPerCentimeter: return _value*1e-1;
                case LinearDensityUnit.GramPerMeter: return _value*1e-3;
                case LinearDensityUnit.GramPerMillimeter: return _value;
                case LinearDensityUnit.KilogramPerCentimeter: return (_value*1e-1) * 1e3d;
                case LinearDensityUnit.KilogramPerMeter: return (_value*1e-3) * 1e3d;
                case LinearDensityUnit.KilogramPerMillimeter: return (_value) * 1e3d;
                case LinearDensityUnit.MicrogramPerCentimeter: return (_value*1e-1) * 1e-6d;
                case LinearDensityUnit.MicrogramPerMeter: return (_value*1e-3) * 1e-6d;
                case LinearDensityUnit.MicrogramPerMillimeter: return (_value) * 1e-6d;
                case LinearDensityUnit.MilligramPerCentimeter: return (_value*1e-1) * 1e-3d;
                case LinearDensityUnit.MilligramPerMeter: return (_value*1e-3) * 1e-3d;
                case LinearDensityUnit.MilligramPerMillimeter: return (_value) * 1e-3d;
                case LinearDensityUnit.PoundPerFoot: return _value*(453.59237/304.8);
                case LinearDensityUnit.PoundPerInch: return _value*(453.59237*1/25.4);
                default:
                    throw new NotImplementedException($"Can not convert {Unit} to base units.");
            }
        }

        private double AsBaseNumericType(LinearDensityUnit unit)
        {
            if(Unit == unit)
                return _value;

            var baseUnitValue = AsBaseUnit();

            switch(unit)
            {
                case LinearDensityUnit.GramPerCentimeter: return baseUnitValue/1e-1;
                case LinearDensityUnit.GramPerMeter: return baseUnitValue/1e-3;
                case LinearDensityUnit.GramPerMillimeter: return baseUnitValue;
                case LinearDensityUnit.KilogramPerCentimeter: return (baseUnitValue/1e-1) / 1e3d;
                case LinearDensityUnit.KilogramPerMeter: return (baseUnitValue/1e-3) / 1e3d;
                case LinearDensityUnit.KilogramPerMillimeter: return (baseUnitValue) / 1e3d;
                case LinearDensityUnit.MicrogramPerCentimeter: return (baseUnitValue/1e-1) / 1e-6d;
                case LinearDensityUnit.MicrogramPerMeter: return (baseUnitValue/1e-3) / 1e-6d;
                case LinearDensityUnit.MicrogramPerMillimeter: return (baseUnitValue) / 1e-6d;
                case LinearDensityUnit.MilligramPerCentimeter: return (baseUnitValue/1e-1) / 1e-3d;
                case LinearDensityUnit.MilligramPerMeter: return (baseUnitValue/1e-3) / 1e-3d;
                case LinearDensityUnit.MilligramPerMillimeter: return (baseUnitValue) / 1e-3d;
                case LinearDensityUnit.PoundPerFoot: return baseUnitValue/(453.59237/304.8);
                case LinearDensityUnit.PoundPerInch: return baseUnitValue/(453.59237*1/25.4);
                default:
                    throw new NotImplementedException($"Can not convert {Unit} to {unit}.");
            }
        }

        #endregion

        #region ToString Methods

        /// <summary>
        ///     Get default string representation of value and unit.
        /// </summary>
        /// <returns>String representation.</returns>
        public override string ToString()
        {
            return ToString(null);
        }

        /// <summary>
        ///     Get string representation of value and unit. Using two significant digits after radix.
        /// </summary>
        /// <returns>String representation.</returns>
        /// <param name="cultureName">Name of culture (ex: "en-US") to use for localization and number formatting. Defaults to <see cref="GlobalConfiguration.DefaultCulture" /> if null.</param>
        public string ToString([CanBeNull] string cultureName)
        {
            var provider = cultureName;
            return ToString(provider, 2);
        }

        /// <summary>
        ///     Get string representation of value and unit.
        /// </summary>
        /// <param name="significantDigitsAfterRadix">The number of significant digits after the radix point.</param>
        /// <returns>String representation.</returns>
        /// <param name="cultureName">Name of culture (ex: "en-US") to use for localization and number formatting. Defaults to <see cref="GlobalConfiguration.DefaultCulture" /> if null.</param>
        public string ToString(string cultureName, int significantDigitsAfterRadix)
        {
            var provider = cultureName;
            var value = Convert.ToDouble(Value);
            var format = UnitFormatter.GetFormat(value, significantDigitsAfterRadix);
            return ToString(provider, format);
        }

        /// <summary>
        ///     Get string representation of value and unit.
        /// </summary>
        /// <param name="format">String format to use. Default:  "{0:0.##} {1} for value and unit abbreviation respectively."</param>
        /// <param name="args">Arguments for string format. Value and unit are implicitly included as arguments 0 and 1.</param>
        /// <returns>String representation.</returns>
        /// <param name="cultureName">Name of culture (ex: "en-US") to use for localization and number formatting. Defaults to <see cref="GlobalConfiguration.DefaultCulture" /> if null.</param>
        public string ToString([CanBeNull] string cultureName, [NotNull] string format, [NotNull] params object[] args)
        {
            var provider = GetFormatProviderFromCultureName(cultureName);
            if (format == null) throw new ArgumentNullException(nameof(format));
            if (args == null) throw new ArgumentNullException(nameof(args));

            provider = provider ?? GlobalConfiguration.DefaultCulture;

            var value = Convert.ToDouble(Value);
            var formatArgs = UnitFormatter.GetFormatArgs(Unit, value, provider, args);
            return string.Format(provider, format, formatArgs);
        }

        #endregion

        private static IFormatProvider GetFormatProviderFromCultureName([CanBeNull] string cultureName)
        {
            return cultureName != null ? new CultureInfo(cultureName) : (IFormatProvider)null;
        }
    }
}
