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
    ///     Force change rate is the ratio of the force change to the time during which the change occurred (value of force changes per unit time).
    /// </summary>
    // Windows Runtime Component has constraints on public types: https://msdn.microsoft.com/en-us/library/br230301.aspx#Declaring types in Windows Runtime Components
    // Public structures can't have any members other than public fields, and those fields must be value types or strings.
    // Public classes must be sealed (NotInheritable in Visual Basic). If your programming model requires polymorphism, you can create a public interface and implement that interface on the classes that must be polymorphic.
    public sealed partial class ForceChangeRate : IQuantity
    {
        /// <summary>
        ///     The numeric value this quantity was constructed with.
        /// </summary>
        private readonly double _value;

        /// <summary>
        ///     The unit this quantity was constructed with.
        /// </summary>
        private readonly ForceChangeRateUnit? _unit;

        static ForceChangeRate()
        {
            BaseDimensions = new BaseDimensions(1, 1, -3, 0, 0, 0, 0);
            Info = new QuantityInfo(QuantityType.ForceChangeRate, Units.Cast<Enum>().ToArray(), BaseUnit, Zero, BaseDimensions);
        }

        /// <summary>
        ///     Creates the quantity with a value of 0 in the base unit NewtonPerSecond.
        /// </summary>
        /// <remarks>
        ///     Windows Runtime Component requires a default constructor.
        /// </remarks>
        public ForceChangeRate()
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
        private ForceChangeRate(double value, ForceChangeRateUnit unit)
        {
            if(unit == ForceChangeRateUnit.Undefined)
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
        ///     The base unit of ForceChangeRate, which is NewtonPerSecond. All conversions go via this value.
        /// </summary>
        public static ForceChangeRateUnit BaseUnit { get; } = ForceChangeRateUnit.NewtonPerSecond;

        /// <summary>
        /// Represents the largest possible value of ForceChangeRate
        /// </summary>
        public static ForceChangeRate MaxValue { get; } = new ForceChangeRate(double.MaxValue, BaseUnit);

        /// <summary>
        /// Represents the smallest possible value of ForceChangeRate
        /// </summary>
        public static ForceChangeRate MinValue { get; } = new ForceChangeRate(double.MinValue, BaseUnit);

        /// <summary>
        ///     The <see cref="QuantityType" /> of this quantity.
        /// </summary>
        public static QuantityType QuantityType { get; } = QuantityType.ForceChangeRate;

        /// <summary>
        ///     All units of measurement for the ForceChangeRate quantity.
        /// </summary>
        public static ForceChangeRateUnit[] Units { get; } = Enum.GetValues(typeof(ForceChangeRateUnit)).Cast<ForceChangeRateUnit>().Except(new ForceChangeRateUnit[]{ ForceChangeRateUnit.Undefined }).ToArray();

        /// <summary>
        ///     Gets an instance of this quantity with a value of 0 in the base unit NewtonPerSecond.
        /// </summary>
        public static ForceChangeRate Zero { get; } = new ForceChangeRate(0, BaseUnit);

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
        public ForceChangeRateUnit Unit => _unit.GetValueOrDefault(BaseUnit);

        internal QuantityInfo QuantityInfo => Info;

        /// <summary>
        ///     The <see cref="QuantityType" /> of this quantity.
        /// </summary>
        public QuantityType Type => ForceChangeRate.QuantityType;

        /// <summary>
        ///     The <see cref="BaseDimensions" /> of this quantity.
        /// </summary>
        public BaseDimensions Dimensions => ForceChangeRate.BaseDimensions;

        #endregion

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

        #region Static Methods

        /// <summary>
        ///     Get unit abbreviation string.
        /// </summary>
        /// <param name="unit">Unit to get abbreviation for.</param>
        /// <returns>Unit abbreviation string.</returns>
        public static string GetAbbreviation(ForceChangeRateUnit unit)
        {
            return GetAbbreviation(unit, null);
        }

        /// <summary>
        ///     Get unit abbreviation string.
        /// </summary>
        /// <param name="unit">Unit to get abbreviation for.</param>
        /// <returns>Unit abbreviation string.</returns>
        /// <param name="cultureName">Name of culture (ex: "en-US") to use when parsing number and unit. Defaults to <see cref="GlobalConfiguration.DefaultCulture" /> if null.</param>
        public static string GetAbbreviation(ForceChangeRateUnit unit, [CanBeNull] string cultureName)
        {
            IFormatProvider provider = GetFormatProviderFromCultureName(cultureName);
            return UnitAbbreviationsCache.Default.GetDefaultAbbreviation(unit, provider);
        }

        #endregion

        #region Static Factory Methods

        /// <summary>
        ///     Get ForceChangeRate from CentinewtonsPerSecond.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        [Windows.Foundation.Metadata.DefaultOverload]
        public static ForceChangeRate FromCentinewtonsPerSecond(double centinewtonspersecond)
        {
            double value = (double) centinewtonspersecond;
            return new ForceChangeRate(value, ForceChangeRateUnit.CentinewtonPerSecond);
        }
        /// <summary>
        ///     Get ForceChangeRate from DecanewtonsPerMinute.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        [Windows.Foundation.Metadata.DefaultOverload]
        public static ForceChangeRate FromDecanewtonsPerMinute(double decanewtonsperminute)
        {
            double value = (double) decanewtonsperminute;
            return new ForceChangeRate(value, ForceChangeRateUnit.DecanewtonPerMinute);
        }
        /// <summary>
        ///     Get ForceChangeRate from DecanewtonsPerSecond.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        [Windows.Foundation.Metadata.DefaultOverload]
        public static ForceChangeRate FromDecanewtonsPerSecond(double decanewtonspersecond)
        {
            double value = (double) decanewtonspersecond;
            return new ForceChangeRate(value, ForceChangeRateUnit.DecanewtonPerSecond);
        }
        /// <summary>
        ///     Get ForceChangeRate from DecinewtonsPerSecond.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        [Windows.Foundation.Metadata.DefaultOverload]
        public static ForceChangeRate FromDecinewtonsPerSecond(double decinewtonspersecond)
        {
            double value = (double) decinewtonspersecond;
            return new ForceChangeRate(value, ForceChangeRateUnit.DecinewtonPerSecond);
        }
        /// <summary>
        ///     Get ForceChangeRate from KilonewtonsPerMinute.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        [Windows.Foundation.Metadata.DefaultOverload]
        public static ForceChangeRate FromKilonewtonsPerMinute(double kilonewtonsperminute)
        {
            double value = (double) kilonewtonsperminute;
            return new ForceChangeRate(value, ForceChangeRateUnit.KilonewtonPerMinute);
        }
        /// <summary>
        ///     Get ForceChangeRate from KilonewtonsPerSecond.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        [Windows.Foundation.Metadata.DefaultOverload]
        public static ForceChangeRate FromKilonewtonsPerSecond(double kilonewtonspersecond)
        {
            double value = (double) kilonewtonspersecond;
            return new ForceChangeRate(value, ForceChangeRateUnit.KilonewtonPerSecond);
        }
        /// <summary>
        ///     Get ForceChangeRate from KilopoundsForcePerMinute.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        [Windows.Foundation.Metadata.DefaultOverload]
        public static ForceChangeRate FromKilopoundsForcePerMinute(double kilopoundsforceperminute)
        {
            double value = (double) kilopoundsforceperminute;
            return new ForceChangeRate(value, ForceChangeRateUnit.KilopoundForcePerMinute);
        }
        /// <summary>
        ///     Get ForceChangeRate from KilopoundsForcePerSecond.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        [Windows.Foundation.Metadata.DefaultOverload]
        public static ForceChangeRate FromKilopoundsForcePerSecond(double kilopoundsforcepersecond)
        {
            double value = (double) kilopoundsforcepersecond;
            return new ForceChangeRate(value, ForceChangeRateUnit.KilopoundForcePerSecond);
        }
        /// <summary>
        ///     Get ForceChangeRate from MicronewtonsPerSecond.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        [Windows.Foundation.Metadata.DefaultOverload]
        public static ForceChangeRate FromMicronewtonsPerSecond(double micronewtonspersecond)
        {
            double value = (double) micronewtonspersecond;
            return new ForceChangeRate(value, ForceChangeRateUnit.MicronewtonPerSecond);
        }
        /// <summary>
        ///     Get ForceChangeRate from MillinewtonsPerSecond.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        [Windows.Foundation.Metadata.DefaultOverload]
        public static ForceChangeRate FromMillinewtonsPerSecond(double millinewtonspersecond)
        {
            double value = (double) millinewtonspersecond;
            return new ForceChangeRate(value, ForceChangeRateUnit.MillinewtonPerSecond);
        }
        /// <summary>
        ///     Get ForceChangeRate from NanonewtonsPerSecond.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        [Windows.Foundation.Metadata.DefaultOverload]
        public static ForceChangeRate FromNanonewtonsPerSecond(double nanonewtonspersecond)
        {
            double value = (double) nanonewtonspersecond;
            return new ForceChangeRate(value, ForceChangeRateUnit.NanonewtonPerSecond);
        }
        /// <summary>
        ///     Get ForceChangeRate from NewtonsPerMinute.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        [Windows.Foundation.Metadata.DefaultOverload]
        public static ForceChangeRate FromNewtonsPerMinute(double newtonsperminute)
        {
            double value = (double) newtonsperminute;
            return new ForceChangeRate(value, ForceChangeRateUnit.NewtonPerMinute);
        }
        /// <summary>
        ///     Get ForceChangeRate from NewtonsPerSecond.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        [Windows.Foundation.Metadata.DefaultOverload]
        public static ForceChangeRate FromNewtonsPerSecond(double newtonspersecond)
        {
            double value = (double) newtonspersecond;
            return new ForceChangeRate(value, ForceChangeRateUnit.NewtonPerSecond);
        }
        /// <summary>
        ///     Get ForceChangeRate from PoundsForcePerMinute.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        [Windows.Foundation.Metadata.DefaultOverload]
        public static ForceChangeRate FromPoundsForcePerMinute(double poundsforceperminute)
        {
            double value = (double) poundsforceperminute;
            return new ForceChangeRate(value, ForceChangeRateUnit.PoundForcePerMinute);
        }
        /// <summary>
        ///     Get ForceChangeRate from PoundsForcePerSecond.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        [Windows.Foundation.Metadata.DefaultOverload]
        public static ForceChangeRate FromPoundsForcePerSecond(double poundsforcepersecond)
        {
            double value = (double) poundsforcepersecond;
            return new ForceChangeRate(value, ForceChangeRateUnit.PoundForcePerSecond);
        }

        /// <summary>
        ///     Dynamically convert from value and unit enum <see cref="ForceChangeRateUnit" /> to <see cref="ForceChangeRate" />.
        /// </summary>
        /// <param name="value">Value to convert from.</param>
        /// <param name="fromUnit">Unit to convert from.</param>
        /// <returns>ForceChangeRate unit value.</returns>
        // Fix name conflict with parameter "value"
        [return: System.Runtime.InteropServices.WindowsRuntime.ReturnValueName("returnValue")]
        public static ForceChangeRate From(double value, ForceChangeRateUnit fromUnit)
        {
            return new ForceChangeRate((double)value, fromUnit);
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
        public static ForceChangeRate Parse(string str)
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
        public static ForceChangeRate Parse(string str, [CanBeNull] string cultureName)
        {
            IFormatProvider provider = GetFormatProviderFromCultureName(cultureName);
            return QuantityParser.Default.Parse<ForceChangeRate, ForceChangeRateUnit>(
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
        public static bool TryParse([CanBeNull] string str, out ForceChangeRate result)
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
        public static bool TryParse([CanBeNull] string str, [CanBeNull] string cultureName, out ForceChangeRate result)
        {
            IFormatProvider provider = GetFormatProviderFromCultureName(cultureName);
            return QuantityParser.Default.TryParse<ForceChangeRate, ForceChangeRateUnit>(
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
        public static ForceChangeRateUnit ParseUnit(string str)
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
        public static ForceChangeRateUnit ParseUnit(string str, [CanBeNull] string cultureName)
        {
            IFormatProvider provider = GetFormatProviderFromCultureName(cultureName);
            return UnitParser.Default.Parse<ForceChangeRateUnit>(str, provider);
        }

        public static bool TryParseUnit(string str, out ForceChangeRateUnit unit)
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
        public static bool TryParseUnit(string str, [CanBeNull] string cultureName, out ForceChangeRateUnit unit)
        {
            IFormatProvider provider = GetFormatProviderFromCultureName(cultureName);
            return UnitParser.Default.TryParse<ForceChangeRateUnit>(str, provider, out unit);
        }

        #endregion

        #region Equality / IComparable

        public int CompareTo(object obj)
        {
            if(obj is null) throw new ArgumentNullException(nameof(obj));
            if(!(obj is ForceChangeRate objForceChangeRate)) throw new ArgumentException("Expected type ForceChangeRate.", nameof(obj));

            return CompareTo(objForceChangeRate);
        }

        // Windows Runtime Component does not allow public methods/ctors with same number of parameters: https://msdn.microsoft.com/en-us/library/br230301.aspx#Overloaded methods
        internal int CompareTo(ForceChangeRate other)
        {
            return _value.CompareTo(other.AsBaseNumericType(this.Unit));
        }

        [Windows.Foundation.Metadata.DefaultOverload]
        public override bool Equals(object obj)
        {
            if(obj is null || !(obj is ForceChangeRate objForceChangeRate))
                return false;

            return Equals(objForceChangeRate);
        }

        public bool Equals(ForceChangeRate other)
        {
            return _value.Equals(other.AsBaseNumericType(this.Unit));
        }

        /// <summary>
        ///     <para>
        ///     Compare equality to another ForceChangeRate within the given absolute or relative tolerance.
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
        public bool Equals(ForceChangeRate other, double tolerance, ComparisonType comparisonType)
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
        /// <returns>A hash code for the current ForceChangeRate.</returns>
        public override int GetHashCode()
        {
            return new { QuantityType, Value, Unit }.GetHashCode();
        }

        #endregion

        #region Conversion Methods

        double IQuantity.As(object unit) => As((ForceChangeRateUnit)unit);

        /// <summary>
        ///     Convert to the unit representation <paramref name="unit" />.
        /// </summary>
        /// <returns>Value converted to the specified unit.</returns>
        public double As(ForceChangeRateUnit unit)
        {
            if(Unit == unit)
                return Convert.ToDouble(Value);

            var converted = AsBaseNumericType(unit);
            return Convert.ToDouble(converted);
        }

        /// <summary>
        ///     Converts this ForceChangeRate to another ForceChangeRate with the unit representation <paramref name="unit" />.
        /// </summary>
        /// <returns>A ForceChangeRate with the specified unit.</returns>
        public ForceChangeRate ToUnit(ForceChangeRateUnit unit)
        {
            var convertedValue = AsBaseNumericType(unit);
            return new ForceChangeRate(convertedValue, unit);
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

        private double AsBaseNumericType(ForceChangeRateUnit unit)
        {
            if(Unit == unit)
                return _value;

            var baseUnitValue = AsBaseUnit();

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
