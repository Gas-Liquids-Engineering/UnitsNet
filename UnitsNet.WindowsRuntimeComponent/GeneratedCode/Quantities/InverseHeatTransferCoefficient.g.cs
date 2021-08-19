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
    ///     The (inverse) heat transfer coefficient or film coefficient, or film effectiveness, in thermodynamics and in mechanics is the proportionality constant between the heat flux and the thermodynamic driving force for the flow of heat (i.e., the temperature difference, ΔT)
    /// </summary>
    // Windows Runtime Component has constraints on public types: https://msdn.microsoft.com/en-us/library/br230301.aspx#Declaring types in Windows Runtime Components
    // Public structures can't have any members other than public fields, and those fields must be value types or strings.
    // Public classes must be sealed (NotInheritable in Visual Basic). If your programming model requires polymorphism, you can create a public interface and implement that interface on the classes that must be polymorphic.
    public sealed partial class InverseHeatTransferCoefficient : IQuantity
    {
        /// <summary>
        ///     The numeric value this quantity was constructed with.
        /// </summary>
        private readonly double _value;

        /// <summary>
        ///     The unit this quantity was constructed with.
        /// </summary>
        private readonly InverseHeatTransferCoefficientUnit? _unit;

        static InverseHeatTransferCoefficient()
        {
            BaseDimensions = new BaseDimensions(0, -1, 3, 0, 1, 0, 0);
            Info = new QuantityInfo(QuantityType.InverseHeatTransferCoefficient, Units.Cast<Enum>().ToArray(), BaseUnit, Zero, BaseDimensions);
        }

        /// <summary>
        ///     Creates the quantity with a value of 0 in the base unit SquareMeterKelvinPerWatt.
        /// </summary>
        /// <remarks>
        ///     Windows Runtime Component requires a default constructor.
        /// </remarks>
        public InverseHeatTransferCoefficient()
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
        private InverseHeatTransferCoefficient(double value, InverseHeatTransferCoefficientUnit unit)
        {
            if(unit == InverseHeatTransferCoefficientUnit.Undefined)
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
        ///     The base unit of InverseHeatTransferCoefficient, which is SquareMeterKelvinPerWatt. All conversions go via this value.
        /// </summary>
        public static InverseHeatTransferCoefficientUnit BaseUnit { get; } = InverseHeatTransferCoefficientUnit.SquareMeterKelvinPerWatt;

        /// <summary>
        /// Represents the largest possible value of InverseHeatTransferCoefficient
        /// </summary>
        public static InverseHeatTransferCoefficient MaxValue { get; } = new InverseHeatTransferCoefficient(double.MaxValue, BaseUnit);

        /// <summary>
        /// Represents the smallest possible value of InverseHeatTransferCoefficient
        /// </summary>
        public static InverseHeatTransferCoefficient MinValue { get; } = new InverseHeatTransferCoefficient(double.MinValue, BaseUnit);

        /// <summary>
        ///     The <see cref="QuantityType" /> of this quantity.
        /// </summary>
        public static QuantityType QuantityType { get; } = QuantityType.InverseHeatTransferCoefficient;

        /// <summary>
        ///     All units of measurement for the InverseHeatTransferCoefficient quantity.
        /// </summary>
        public static InverseHeatTransferCoefficientUnit[] Units { get; } = Enum.GetValues(typeof(InverseHeatTransferCoefficientUnit)).Cast<InverseHeatTransferCoefficientUnit>().Except(new InverseHeatTransferCoefficientUnit[]{ InverseHeatTransferCoefficientUnit.Undefined }).ToArray();

        /// <summary>
        ///     Gets an instance of this quantity with a value of 0 in the base unit SquareMeterKelvinPerWatt.
        /// </summary>
        public static InverseHeatTransferCoefficient Zero { get; } = new InverseHeatTransferCoefficient(0, BaseUnit);

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
        public InverseHeatTransferCoefficientUnit Unit => _unit.GetValueOrDefault(BaseUnit);

        internal QuantityInfo QuantityInfo => Info;

        /// <summary>
        ///     The <see cref="QuantityType" /> of this quantity.
        /// </summary>
        public QuantityType Type => InverseHeatTransferCoefficient.QuantityType;

        /// <summary>
        ///     The <see cref="BaseDimensions" /> of this quantity.
        /// </summary>
        public BaseDimensions Dimensions => InverseHeatTransferCoefficient.BaseDimensions;

        #endregion

        #region Conversion Properties

        /// <summary>
        ///     Get InverseHeatTransferCoefficient in SquareCentimeterKelvinsPerWatt.
        /// </summary>
        public double SquareCentimeterKelvinsPerWatt => As(InverseHeatTransferCoefficientUnit.SquareCentimeterKelvinPerWatt);

        /// <summary>
        ///     Get InverseHeatTransferCoefficient in SquareCentimeterSecondKelvinsPerCalorie.
        /// </summary>
        public double SquareCentimeterSecondKelvinsPerCalorie => As(InverseHeatTransferCoefficientUnit.SquareCentimeterSecondKelvinPerCalorie);

        /// <summary>
        ///     Get InverseHeatTransferCoefficient in SquareFootHourFahrenheitsPerBtu.
        /// </summary>
        public double SquareFootHourFahrenheitsPerBtu => As(InverseHeatTransferCoefficientUnit.SquareFootHourFahrenheitPerBtu);

        /// <summary>
        ///     Get InverseHeatTransferCoefficient in SquareMetersCelsiusPerWatt.
        /// </summary>
        public double SquareMetersCelsiusPerWatt => As(InverseHeatTransferCoefficientUnit.SquareMeterCelsiusPerWatt);

        /// <summary>
        ///     Get InverseHeatTransferCoefficient in SquareMeterHourKelvinsPerKilocalorie.
        /// </summary>
        public double SquareMeterHourKelvinsPerKilocalorie => As(InverseHeatTransferCoefficientUnit.SquareMeterHourKelvinPerKilocalorie);

        /// <summary>
        ///     Get InverseHeatTransferCoefficient in SquareMetersKelvinPerWatt.
        /// </summary>
        public double SquareMetersKelvinPerWatt => As(InverseHeatTransferCoefficientUnit.SquareMeterKelvinPerWatt);

        #endregion

        #region Static Methods

        /// <summary>
        ///     Get unit abbreviation string.
        /// </summary>
        /// <param name="unit">Unit to get abbreviation for.</param>
        /// <returns>Unit abbreviation string.</returns>
        public static string GetAbbreviation(InverseHeatTransferCoefficientUnit unit)
        {
            return GetAbbreviation(unit, null);
        }

        /// <summary>
        ///     Get unit abbreviation string.
        /// </summary>
        /// <param name="unit">Unit to get abbreviation for.</param>
        /// <returns>Unit abbreviation string.</returns>
        /// <param name="cultureName">Name of culture (ex: "en-US") to use when parsing number and unit. Defaults to <see cref="GlobalConfiguration.DefaultCulture" /> if null.</param>
        public static string GetAbbreviation(InverseHeatTransferCoefficientUnit unit, [CanBeNull] string cultureName)
        {
            IFormatProvider provider = GetFormatProviderFromCultureName(cultureName);
            return UnitAbbreviationsCache.Default.GetDefaultAbbreviation(unit, provider);
        }

        #endregion

        #region Static Factory Methods

        /// <summary>
        ///     Get InverseHeatTransferCoefficient from SquareCentimeterKelvinsPerWatt.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        [Windows.Foundation.Metadata.DefaultOverload]
        public static InverseHeatTransferCoefficient FromSquareCentimeterKelvinsPerWatt(double squarecentimeterkelvinsperwatt)
        {
            double value = (double) squarecentimeterkelvinsperwatt;
            return new InverseHeatTransferCoefficient(value, InverseHeatTransferCoefficientUnit.SquareCentimeterKelvinPerWatt);
        }
        /// <summary>
        ///     Get InverseHeatTransferCoefficient from SquareCentimeterSecondKelvinsPerCalorie.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        [Windows.Foundation.Metadata.DefaultOverload]
        public static InverseHeatTransferCoefficient FromSquareCentimeterSecondKelvinsPerCalorie(double squarecentimetersecondkelvinspercalorie)
        {
            double value = (double) squarecentimetersecondkelvinspercalorie;
            return new InverseHeatTransferCoefficient(value, InverseHeatTransferCoefficientUnit.SquareCentimeterSecondKelvinPerCalorie);
        }
        /// <summary>
        ///     Get InverseHeatTransferCoefficient from SquareFootHourFahrenheitsPerBtu.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        [Windows.Foundation.Metadata.DefaultOverload]
        public static InverseHeatTransferCoefficient FromSquareFootHourFahrenheitsPerBtu(double squarefoothourfahrenheitsperbtu)
        {
            double value = (double) squarefoothourfahrenheitsperbtu;
            return new InverseHeatTransferCoefficient(value, InverseHeatTransferCoefficientUnit.SquareFootHourFahrenheitPerBtu);
        }
        /// <summary>
        ///     Get InverseHeatTransferCoefficient from SquareMetersCelsiusPerWatt.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        [Windows.Foundation.Metadata.DefaultOverload]
        public static InverseHeatTransferCoefficient FromSquareMetersCelsiusPerWatt(double squaremeterscelsiusperwatt)
        {
            double value = (double) squaremeterscelsiusperwatt;
            return new InverseHeatTransferCoefficient(value, InverseHeatTransferCoefficientUnit.SquareMeterCelsiusPerWatt);
        }
        /// <summary>
        ///     Get InverseHeatTransferCoefficient from SquareMeterHourKelvinsPerKilocalorie.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        [Windows.Foundation.Metadata.DefaultOverload]
        public static InverseHeatTransferCoefficient FromSquareMeterHourKelvinsPerKilocalorie(double squaremeterhourkelvinsperkilocalorie)
        {
            double value = (double) squaremeterhourkelvinsperkilocalorie;
            return new InverseHeatTransferCoefficient(value, InverseHeatTransferCoefficientUnit.SquareMeterHourKelvinPerKilocalorie);
        }
        /// <summary>
        ///     Get InverseHeatTransferCoefficient from SquareMetersKelvinPerWatt.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        [Windows.Foundation.Metadata.DefaultOverload]
        public static InverseHeatTransferCoefficient FromSquareMetersKelvinPerWatt(double squaremeterskelvinperwatt)
        {
            double value = (double) squaremeterskelvinperwatt;
            return new InverseHeatTransferCoefficient(value, InverseHeatTransferCoefficientUnit.SquareMeterKelvinPerWatt);
        }

        /// <summary>
        ///     Dynamically convert from value and unit enum <see cref="InverseHeatTransferCoefficientUnit" /> to <see cref="InverseHeatTransferCoefficient" />.
        /// </summary>
        /// <param name="value">Value to convert from.</param>
        /// <param name="fromUnit">Unit to convert from.</param>
        /// <returns>InverseHeatTransferCoefficient unit value.</returns>
        // Fix name conflict with parameter "value"
        [return: System.Runtime.InteropServices.WindowsRuntime.ReturnValueName("returnValue")]
        public static InverseHeatTransferCoefficient From(double value, InverseHeatTransferCoefficientUnit fromUnit)
        {
            return new InverseHeatTransferCoefficient((double)value, fromUnit);
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
        public static InverseHeatTransferCoefficient Parse(string str)
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
        public static InverseHeatTransferCoefficient Parse(string str, [CanBeNull] string cultureName)
        {
            IFormatProvider provider = GetFormatProviderFromCultureName(cultureName);
            return QuantityParser.Default.Parse<InverseHeatTransferCoefficient, InverseHeatTransferCoefficientUnit>(
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
        public static bool TryParse([CanBeNull] string str, out InverseHeatTransferCoefficient result)
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
        public static bool TryParse([CanBeNull] string str, [CanBeNull] string cultureName, out InverseHeatTransferCoefficient result)
        {
            IFormatProvider provider = GetFormatProviderFromCultureName(cultureName);
            return QuantityParser.Default.TryParse<InverseHeatTransferCoefficient, InverseHeatTransferCoefficientUnit>(
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
        public static InverseHeatTransferCoefficientUnit ParseUnit(string str)
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
        public static InverseHeatTransferCoefficientUnit ParseUnit(string str, [CanBeNull] string cultureName)
        {
            IFormatProvider provider = GetFormatProviderFromCultureName(cultureName);
            return UnitParser.Default.Parse<InverseHeatTransferCoefficientUnit>(str, provider);
        }

        public static bool TryParseUnit(string str, out InverseHeatTransferCoefficientUnit unit)
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
        public static bool TryParseUnit(string str, [CanBeNull] string cultureName, out InverseHeatTransferCoefficientUnit unit)
        {
            IFormatProvider provider = GetFormatProviderFromCultureName(cultureName);
            return UnitParser.Default.TryParse<InverseHeatTransferCoefficientUnit>(str, provider, out unit);
        }

        #endregion

        #region Equality / IComparable

        public int CompareTo(object obj)
        {
            if(obj is null) throw new ArgumentNullException(nameof(obj));
            if(!(obj is InverseHeatTransferCoefficient objInverseHeatTransferCoefficient)) throw new ArgumentException("Expected type InverseHeatTransferCoefficient.", nameof(obj));

            return CompareTo(objInverseHeatTransferCoefficient);
        }

        // Windows Runtime Component does not allow public methods/ctors with same number of parameters: https://msdn.microsoft.com/en-us/library/br230301.aspx#Overloaded methods
        internal int CompareTo(InverseHeatTransferCoefficient other)
        {
            return _value.CompareTo(other.AsBaseNumericType(this.Unit));
        }

        [Windows.Foundation.Metadata.DefaultOverload]
        public override bool Equals(object obj)
        {
            if(obj is null || !(obj is InverseHeatTransferCoefficient objInverseHeatTransferCoefficient))
                return false;

            return Equals(objInverseHeatTransferCoefficient);
        }

        public bool Equals(InverseHeatTransferCoefficient other)
        {
            return _value.Equals(other.AsBaseNumericType(this.Unit));
        }

        /// <summary>
        ///     <para>
        ///     Compare equality to another InverseHeatTransferCoefficient within the given absolute or relative tolerance.
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
        public bool Equals(InverseHeatTransferCoefficient other, double tolerance, ComparisonType comparisonType)
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
        /// <returns>A hash code for the current InverseHeatTransferCoefficient.</returns>
        public override int GetHashCode()
        {
            return new { QuantityType, Value, Unit }.GetHashCode();
        }

        #endregion

        #region Conversion Methods

        double IQuantity.As(object unit) => As((InverseHeatTransferCoefficientUnit)unit);

        /// <summary>
        ///     Convert to the unit representation <paramref name="unit" />.
        /// </summary>
        /// <returns>Value converted to the specified unit.</returns>
        public double As(InverseHeatTransferCoefficientUnit unit)
        {
            if(Unit == unit)
                return Convert.ToDouble(Value);

            var converted = AsBaseNumericType(unit);
            return Convert.ToDouble(converted);
        }

        /// <summary>
        ///     Converts this InverseHeatTransferCoefficient to another InverseHeatTransferCoefficient with the unit representation <paramref name="unit" />.
        /// </summary>
        /// <returns>A InverseHeatTransferCoefficient with the specified unit.</returns>
        public InverseHeatTransferCoefficient ToUnit(InverseHeatTransferCoefficientUnit unit)
        {
            var convertedValue = AsBaseNumericType(unit);
            return new InverseHeatTransferCoefficient(convertedValue, unit);
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
                case InverseHeatTransferCoefficientUnit.SquareCentimeterKelvinPerWatt: return _value/10000;
                case InverseHeatTransferCoefficientUnit.SquareCentimeterSecondKelvinPerCalorie: return _value*(1/4184);
                case InverseHeatTransferCoefficientUnit.SquareFootHourFahrenheitPerBtu: return _value*(0.3048*0.3048*5/9*3600/1055);
                case InverseHeatTransferCoefficientUnit.SquareMeterCelsiusPerWatt: return _value;
                case InverseHeatTransferCoefficientUnit.SquareMeterHourKelvinPerKilocalorie: return _value * (3600/4184);
                case InverseHeatTransferCoefficientUnit.SquareMeterKelvinPerWatt: return _value;
                default:
                    throw new NotImplementedException($"Can not convert {Unit} to base units.");
            }
        }

        private double AsBaseNumericType(InverseHeatTransferCoefficientUnit unit)
        {
            if(Unit == unit)
                return _value;

            var baseUnitValue = AsBaseUnit();

            switch(unit)
            {
                case InverseHeatTransferCoefficientUnit.SquareCentimeterKelvinPerWatt: return baseUnitValue*10000;
                case InverseHeatTransferCoefficientUnit.SquareCentimeterSecondKelvinPerCalorie: return baseUnitValue/(1/4184);
                case InverseHeatTransferCoefficientUnit.SquareFootHourFahrenheitPerBtu: return baseUnitValue/(0.3048*0.3048*5/9*3600/1055);
                case InverseHeatTransferCoefficientUnit.SquareMeterCelsiusPerWatt: return baseUnitValue;
                case InverseHeatTransferCoefficientUnit.SquareMeterHourKelvinPerKilocalorie: return baseUnitValue / (3600/4184);
                case InverseHeatTransferCoefficientUnit.SquareMeterKelvinPerWatt: return baseUnitValue;
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
