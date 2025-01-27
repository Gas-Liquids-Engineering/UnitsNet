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
using System.Threading;
using UnitsNet.Tests.TestsBase;
using UnitsNet.Units;
using Xunit;

// Disable build warning CS1718: Comparison made to same variable; did you mean to compare something else?
#pragma warning disable 1718

// ReSharper disable once CheckNamespace
namespace UnitsNet.Tests
{
    /// <summary>
    /// Test of SpecificVolume.
    /// </summary>
// ReSharper disable once PartialTypeWithSinglePart
    public abstract partial class SpecificVolumeTestsBase : QuantityTestsBase
    {
        protected abstract double CubicFeetPerPoundInOneCubicMeterPerKilogram { get; }
        protected abstract double CubicMetersPerKilogramInOneCubicMeterPerKilogram { get; }
        protected abstract double LitersPerGramInOneCubicMeterPerKilogram { get; }
        protected abstract double MillicubicMetersPerKilogramInOneCubicMeterPerKilogram { get; }
        protected abstract double MillilitersPerGramInOneCubicMeterPerKilogram { get; }
        protected abstract double USGallonsPerPoundInOneCubicMeterPerKilogram { get; }

// ReSharper disable VirtualMemberNeverOverriden.Global
        protected virtual double CubicFeetPerPoundTolerance { get { return 1e-5; } }
        protected virtual double CubicMetersPerKilogramTolerance { get { return 1e-5; } }
        protected virtual double LitersPerGramTolerance { get { return 1e-5; } }
        protected virtual double MillicubicMetersPerKilogramTolerance { get { return 1e-5; } }
        protected virtual double MillilitersPerGramTolerance { get { return 1e-5; } }
        protected virtual double USGallonsPerPoundTolerance { get { return 1e-5; } }
// ReSharper restore VirtualMemberNeverOverriden.Global

        [Fact]
        public void Ctor_WithUndefinedUnit_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => new SpecificVolume((double)0.0, SpecificVolumeUnit.Undefined));
        }

        [Fact]
        public void DefaultCtor_ReturnsQuantityWithZeroValueAndBaseUnit()
        {
            var quantity = new SpecificVolume();
            Assert.Equal(0, quantity.Value);
            Assert.Equal(SpecificVolumeUnit.CubicMeterPerKilogram, quantity.Unit);
        }


        [Fact]
        public void Ctor_WithInfinityValue_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => new SpecificVolume(double.PositiveInfinity, SpecificVolumeUnit.CubicMeterPerKilogram));
            Assert.Throws<ArgumentException>(() => new SpecificVolume(double.NegativeInfinity, SpecificVolumeUnit.CubicMeterPerKilogram));
        }

        [Fact]
        public void Ctor_WithNaNValue_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => new SpecificVolume(double.NaN, SpecificVolumeUnit.CubicMeterPerKilogram));
        }

        [Fact]
        public void Ctor_NullAsUnitSystem_ThrowsArgumentNullException()
        {
            Assert.Throws<ArgumentNullException>(() => new SpecificVolume(value: 1, unitSystem: null));
        }

        [Fact]
        public void Ctor_SIUnitSystem_ThrowsArgumentExceptionIfNotSupported()
        {
            Func<object> TestCode = () => new SpecificVolume(value: 1, unitSystem: UnitSystem.SI);
            if (SupportsSIUnitSystem)
            {
                var quantity = (SpecificVolume) TestCode();
                Assert.Equal(1, quantity.Value);
            }
            else
            {
                Assert.Throws<ArgumentException>(TestCode);
            }
        }

        [Fact]
        public void SpecificVolume_QuantityInfo_ReturnsQuantityInfoDescribingQuantity()
        {
            var quantity = new SpecificVolume(1, SpecificVolumeUnit.CubicMeterPerKilogram);

            QuantityInfo<SpecificVolumeUnit> quantityInfo = quantity.QuantityInfo;

            Assert.Equal(SpecificVolume.Zero, quantityInfo.Zero);
            Assert.Equal("SpecificVolume", quantityInfo.Name);
            Assert.Equal(QuantityType.SpecificVolume, quantityInfo.QuantityType);

            var units = EnumUtils.GetEnumValues<SpecificVolumeUnit>().Except(new[] {SpecificVolumeUnit.Undefined}).ToArray();
            var unitNames = units.Select(x => x.ToString());

            // Obsolete members
            Assert.Equal(units, quantityInfo.Units);
            Assert.Equal(unitNames, quantityInfo.UnitNames);
        }

        [Fact]
        public void CubicMeterPerKilogramToSpecificVolumeUnits()
        {
            SpecificVolume cubicmeterperkilogram = SpecificVolume.FromCubicMetersPerKilogram(1);
            AssertEx.EqualTolerance(CubicFeetPerPoundInOneCubicMeterPerKilogram, cubicmeterperkilogram.CubicFeetPerPound, CubicFeetPerPoundTolerance);
            AssertEx.EqualTolerance(CubicMetersPerKilogramInOneCubicMeterPerKilogram, cubicmeterperkilogram.CubicMetersPerKilogram, CubicMetersPerKilogramTolerance);
            AssertEx.EqualTolerance(LitersPerGramInOneCubicMeterPerKilogram, cubicmeterperkilogram.LitersPerGram, LitersPerGramTolerance);
            AssertEx.EqualTolerance(MillicubicMetersPerKilogramInOneCubicMeterPerKilogram, cubicmeterperkilogram.MillicubicMetersPerKilogram, MillicubicMetersPerKilogramTolerance);
            AssertEx.EqualTolerance(MillilitersPerGramInOneCubicMeterPerKilogram, cubicmeterperkilogram.MillilitersPerGram, MillilitersPerGramTolerance);
            AssertEx.EqualTolerance(USGallonsPerPoundInOneCubicMeterPerKilogram, cubicmeterperkilogram.USGallonsPerPound, USGallonsPerPoundTolerance);
        }

        [Fact]
        public void From_ValueAndUnit_ReturnsQuantityWithSameValueAndUnit()
        {
            var quantity00 = SpecificVolume.From(1, SpecificVolumeUnit.CubicFootPerPound);
            AssertEx.EqualTolerance(1, quantity00.CubicFeetPerPound, CubicFeetPerPoundTolerance);
            Assert.Equal(SpecificVolumeUnit.CubicFootPerPound, quantity00.Unit);

            var quantity01 = SpecificVolume.From(1, SpecificVolumeUnit.CubicMeterPerKilogram);
            AssertEx.EqualTolerance(1, quantity01.CubicMetersPerKilogram, CubicMetersPerKilogramTolerance);
            Assert.Equal(SpecificVolumeUnit.CubicMeterPerKilogram, quantity01.Unit);

            var quantity02 = SpecificVolume.From(1, SpecificVolumeUnit.LiterPerGram);
            AssertEx.EqualTolerance(1, quantity02.LitersPerGram, LitersPerGramTolerance);
            Assert.Equal(SpecificVolumeUnit.LiterPerGram, quantity02.Unit);

            var quantity03 = SpecificVolume.From(1, SpecificVolumeUnit.MillicubicMeterPerKilogram);
            AssertEx.EqualTolerance(1, quantity03.MillicubicMetersPerKilogram, MillicubicMetersPerKilogramTolerance);
            Assert.Equal(SpecificVolumeUnit.MillicubicMeterPerKilogram, quantity03.Unit);

            var quantity04 = SpecificVolume.From(1, SpecificVolumeUnit.MilliliterPerGram);
            AssertEx.EqualTolerance(1, quantity04.MillilitersPerGram, MillilitersPerGramTolerance);
            Assert.Equal(SpecificVolumeUnit.MilliliterPerGram, quantity04.Unit);

            var quantity05 = SpecificVolume.From(1, SpecificVolumeUnit.USGallonPerPound);
            AssertEx.EqualTolerance(1, quantity05.USGallonsPerPound, USGallonsPerPoundTolerance);
            Assert.Equal(SpecificVolumeUnit.USGallonPerPound, quantity05.Unit);

        }

        [Fact]
        public void FromCubicMetersPerKilogram_WithInfinityValue_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => SpecificVolume.FromCubicMetersPerKilogram(double.PositiveInfinity));
            Assert.Throws<ArgumentException>(() => SpecificVolume.FromCubicMetersPerKilogram(double.NegativeInfinity));
        }

        [Fact]
        public void FromCubicMetersPerKilogram_WithNanValue_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => SpecificVolume.FromCubicMetersPerKilogram(double.NaN));
        }

        [Fact]
        public void As()
        {
            var cubicmeterperkilogram = SpecificVolume.FromCubicMetersPerKilogram(1);
            AssertEx.EqualTolerance(CubicFeetPerPoundInOneCubicMeterPerKilogram, cubicmeterperkilogram.As(SpecificVolumeUnit.CubicFootPerPound), CubicFeetPerPoundTolerance);
            AssertEx.EqualTolerance(CubicMetersPerKilogramInOneCubicMeterPerKilogram, cubicmeterperkilogram.As(SpecificVolumeUnit.CubicMeterPerKilogram), CubicMetersPerKilogramTolerance);
            AssertEx.EqualTolerance(LitersPerGramInOneCubicMeterPerKilogram, cubicmeterperkilogram.As(SpecificVolumeUnit.LiterPerGram), LitersPerGramTolerance);
            AssertEx.EqualTolerance(MillicubicMetersPerKilogramInOneCubicMeterPerKilogram, cubicmeterperkilogram.As(SpecificVolumeUnit.MillicubicMeterPerKilogram), MillicubicMetersPerKilogramTolerance);
            AssertEx.EqualTolerance(MillilitersPerGramInOneCubicMeterPerKilogram, cubicmeterperkilogram.As(SpecificVolumeUnit.MilliliterPerGram), MillilitersPerGramTolerance);
            AssertEx.EqualTolerance(USGallonsPerPoundInOneCubicMeterPerKilogram, cubicmeterperkilogram.As(SpecificVolumeUnit.USGallonPerPound), USGallonsPerPoundTolerance);
        }

        [Fact]
        public void As_SIUnitSystem_ThrowsArgumentExceptionIfNotSupported()
        {
            var quantity = new SpecificVolume(value: 1, unit: SpecificVolume.BaseUnit);
            Func<object> AsWithSIUnitSystem = () => quantity.As(UnitSystem.SI);

            if (SupportsSIUnitSystem)
            {
                var value = (double) AsWithSIUnitSystem();
                Assert.Equal(1, value);
            }
            else
            {
                Assert.Throws<ArgumentException>(AsWithSIUnitSystem);
            }
        }

        [Fact]
        public void ToUnit()
        {
            var cubicmeterperkilogram = SpecificVolume.FromCubicMetersPerKilogram(1);

            var cubicfootperpoundQuantity = cubicmeterperkilogram.ToUnit(SpecificVolumeUnit.CubicFootPerPound);
            AssertEx.EqualTolerance(CubicFeetPerPoundInOneCubicMeterPerKilogram, (double)cubicfootperpoundQuantity.Value, CubicFeetPerPoundTolerance);
            Assert.Equal(SpecificVolumeUnit.CubicFootPerPound, cubicfootperpoundQuantity.Unit);

            var cubicmeterperkilogramQuantity = cubicmeterperkilogram.ToUnit(SpecificVolumeUnit.CubicMeterPerKilogram);
            AssertEx.EqualTolerance(CubicMetersPerKilogramInOneCubicMeterPerKilogram, (double)cubicmeterperkilogramQuantity.Value, CubicMetersPerKilogramTolerance);
            Assert.Equal(SpecificVolumeUnit.CubicMeterPerKilogram, cubicmeterperkilogramQuantity.Unit);

            var literpergramQuantity = cubicmeterperkilogram.ToUnit(SpecificVolumeUnit.LiterPerGram);
            AssertEx.EqualTolerance(LitersPerGramInOneCubicMeterPerKilogram, (double)literpergramQuantity.Value, LitersPerGramTolerance);
            Assert.Equal(SpecificVolumeUnit.LiterPerGram, literpergramQuantity.Unit);

            var millicubicmeterperkilogramQuantity = cubicmeterperkilogram.ToUnit(SpecificVolumeUnit.MillicubicMeterPerKilogram);
            AssertEx.EqualTolerance(MillicubicMetersPerKilogramInOneCubicMeterPerKilogram, (double)millicubicmeterperkilogramQuantity.Value, MillicubicMetersPerKilogramTolerance);
            Assert.Equal(SpecificVolumeUnit.MillicubicMeterPerKilogram, millicubicmeterperkilogramQuantity.Unit);

            var milliliterpergramQuantity = cubicmeterperkilogram.ToUnit(SpecificVolumeUnit.MilliliterPerGram);
            AssertEx.EqualTolerance(MillilitersPerGramInOneCubicMeterPerKilogram, (double)milliliterpergramQuantity.Value, MillilitersPerGramTolerance);
            Assert.Equal(SpecificVolumeUnit.MilliliterPerGram, milliliterpergramQuantity.Unit);

            var usgallonperpoundQuantity = cubicmeterperkilogram.ToUnit(SpecificVolumeUnit.USGallonPerPound);
            AssertEx.EqualTolerance(USGallonsPerPoundInOneCubicMeterPerKilogram, (double)usgallonperpoundQuantity.Value, USGallonsPerPoundTolerance);
            Assert.Equal(SpecificVolumeUnit.USGallonPerPound, usgallonperpoundQuantity.Unit);
        }

        [Fact]
        public void ToBaseUnit_ReturnsQuantityWithBaseUnit()
        {
            var quantityInBaseUnit = SpecificVolume.FromCubicMetersPerKilogram(1).ToBaseUnit();
            Assert.Equal(SpecificVolume.BaseUnit, quantityInBaseUnit.Unit);
        }

        [Fact]
        public void ConversionRoundTrip()
        {
            SpecificVolume cubicmeterperkilogram = SpecificVolume.FromCubicMetersPerKilogram(1);
            AssertEx.EqualTolerance(1, SpecificVolume.FromCubicFeetPerPound(cubicmeterperkilogram.CubicFeetPerPound).CubicMetersPerKilogram, CubicFeetPerPoundTolerance);
            AssertEx.EqualTolerance(1, SpecificVolume.FromCubicMetersPerKilogram(cubicmeterperkilogram.CubicMetersPerKilogram).CubicMetersPerKilogram, CubicMetersPerKilogramTolerance);
            AssertEx.EqualTolerance(1, SpecificVolume.FromLitersPerGram(cubicmeterperkilogram.LitersPerGram).CubicMetersPerKilogram, LitersPerGramTolerance);
            AssertEx.EqualTolerance(1, SpecificVolume.FromMillicubicMetersPerKilogram(cubicmeterperkilogram.MillicubicMetersPerKilogram).CubicMetersPerKilogram, MillicubicMetersPerKilogramTolerance);
            AssertEx.EqualTolerance(1, SpecificVolume.FromMillilitersPerGram(cubicmeterperkilogram.MillilitersPerGram).CubicMetersPerKilogram, MillilitersPerGramTolerance);
            AssertEx.EqualTolerance(1, SpecificVolume.FromUSGallonsPerPound(cubicmeterperkilogram.USGallonsPerPound).CubicMetersPerKilogram, USGallonsPerPoundTolerance);
        }

        [Fact]
        public void ArithmeticOperators()
        {
            SpecificVolume v = SpecificVolume.FromCubicMetersPerKilogram(1);
            AssertEx.EqualTolerance(-1, -v.CubicMetersPerKilogram, CubicMetersPerKilogramTolerance);
            AssertEx.EqualTolerance(2, (SpecificVolume.FromCubicMetersPerKilogram(3)-v).CubicMetersPerKilogram, CubicMetersPerKilogramTolerance);
            AssertEx.EqualTolerance(2, (v + v).CubicMetersPerKilogram, CubicMetersPerKilogramTolerance);
            AssertEx.EqualTolerance(10, (v*10).CubicMetersPerKilogram, CubicMetersPerKilogramTolerance);
            AssertEx.EqualTolerance(10, (10*v).CubicMetersPerKilogram, CubicMetersPerKilogramTolerance);
            AssertEx.EqualTolerance(2, (SpecificVolume.FromCubicMetersPerKilogram(10)/5).CubicMetersPerKilogram, CubicMetersPerKilogramTolerance);
            AssertEx.EqualTolerance(2, SpecificVolume.FromCubicMetersPerKilogram(10)/SpecificVolume.FromCubicMetersPerKilogram(5), CubicMetersPerKilogramTolerance);
        }

        [Fact]
        public void ComparisonOperators()
        {
            SpecificVolume oneCubicMeterPerKilogram = SpecificVolume.FromCubicMetersPerKilogram(1);
            SpecificVolume twoCubicMetersPerKilogram = SpecificVolume.FromCubicMetersPerKilogram(2);

            Assert.True(oneCubicMeterPerKilogram < twoCubicMetersPerKilogram);
            Assert.True(oneCubicMeterPerKilogram <= twoCubicMetersPerKilogram);
            Assert.True(twoCubicMetersPerKilogram > oneCubicMeterPerKilogram);
            Assert.True(twoCubicMetersPerKilogram >= oneCubicMeterPerKilogram);

            Assert.False(oneCubicMeterPerKilogram > twoCubicMetersPerKilogram);
            Assert.False(oneCubicMeterPerKilogram >= twoCubicMetersPerKilogram);
            Assert.False(twoCubicMetersPerKilogram < oneCubicMeterPerKilogram);
            Assert.False(twoCubicMetersPerKilogram <= oneCubicMeterPerKilogram);
        }

        [Fact]
        public void CompareToIsImplemented()
        {
            SpecificVolume cubicmeterperkilogram = SpecificVolume.FromCubicMetersPerKilogram(1);
            Assert.Equal(0, cubicmeterperkilogram.CompareTo(cubicmeterperkilogram));
            Assert.True(cubicmeterperkilogram.CompareTo(SpecificVolume.Zero) > 0);
            Assert.True(SpecificVolume.Zero.CompareTo(cubicmeterperkilogram) < 0);
        }

        [Fact]
        public void CompareToThrowsOnTypeMismatch()
        {
            SpecificVolume cubicmeterperkilogram = SpecificVolume.FromCubicMetersPerKilogram(1);
            Assert.Throws<ArgumentException>(() => cubicmeterperkilogram.CompareTo(new object()));
        }

        [Fact]
        public void CompareToThrowsOnNull()
        {
            SpecificVolume cubicmeterperkilogram = SpecificVolume.FromCubicMetersPerKilogram(1);
            Assert.Throws<ArgumentNullException>(() => cubicmeterperkilogram.CompareTo(null));
        }

        [Fact]
        public void EqualityOperators()
        {
            var a = SpecificVolume.FromCubicMetersPerKilogram(1);
            var b = SpecificVolume.FromCubicMetersPerKilogram(2);

#pragma warning disable CS8073
// ReSharper disable EqualExpressionComparison

            Assert.True(a == a);
            Assert.False(a != a);

            Assert.True(a != b);
            Assert.False(a == b);

            Assert.False(a == null);
            Assert.False(null == a);

// ReSharper restore EqualExpressionComparison
#pragma warning restore CS8073
        }

        [Fact]
        public void Equals_SameType_IsImplemented()
        {
            var a = SpecificVolume.FromCubicMetersPerKilogram(1);
            var b = SpecificVolume.FromCubicMetersPerKilogram(2);

            Assert.True(a.Equals(a));
            Assert.False(a.Equals(b));
        }

        [Fact]
        public void Equals_QuantityAsObject_IsImplemented()
        {
            object a = SpecificVolume.FromCubicMetersPerKilogram(1);
            object b = SpecificVolume.FromCubicMetersPerKilogram(2);

            Assert.True(a.Equals(a));
            Assert.False(a.Equals(b));
            Assert.False(a.Equals((object)null));
        }

        [Fact]
        public void Equals_RelativeTolerance_IsImplemented()
        {
            var v = SpecificVolume.FromCubicMetersPerKilogram(1);
            Assert.True(v.Equals(SpecificVolume.FromCubicMetersPerKilogram(1), CubicMetersPerKilogramTolerance, ComparisonType.Relative));
            Assert.False(v.Equals(SpecificVolume.Zero, CubicMetersPerKilogramTolerance, ComparisonType.Relative));
        }

        [Fact]
        public void Equals_NegativeRelativeTolerance_ThrowsArgumentOutOfRangeException()
        {
            var v = SpecificVolume.FromCubicMetersPerKilogram(1);
            Assert.Throws<ArgumentOutOfRangeException>(() => v.Equals(SpecificVolume.FromCubicMetersPerKilogram(1), -1, ComparisonType.Relative));
        }

        [Fact]
        public void EqualsReturnsFalseOnTypeMismatch()
        {
            SpecificVolume cubicmeterperkilogram = SpecificVolume.FromCubicMetersPerKilogram(1);
            Assert.False(cubicmeterperkilogram.Equals(new object()));
        }

        [Fact]
        public void EqualsReturnsFalseOnNull()
        {
            SpecificVolume cubicmeterperkilogram = SpecificVolume.FromCubicMetersPerKilogram(1);
            Assert.False(cubicmeterperkilogram.Equals(null));
        }

        [Fact]
        public void UnitsDoesNotContainUndefined()
        {
            Assert.DoesNotContain(SpecificVolumeUnit.Undefined, SpecificVolume.Units);
        }

        [Fact]
        public void HasAtLeastOneAbbreviationSpecified()
        {
            var units = Enum.GetValues(typeof(SpecificVolumeUnit)).Cast<SpecificVolumeUnit>();
            foreach(var unit in units)
            {
                if(unit == SpecificVolumeUnit.Undefined)
                    continue;

                var defaultAbbreviation = UnitAbbreviationsCache.Default.GetDefaultAbbreviation(unit);
            }
        }

        [Fact]
        public void BaseDimensionsShouldNeverBeNull()
        {
            Assert.False(SpecificVolume.BaseDimensions is null);
        }

        [Fact]
        public void ToString_ReturnsValueAndUnitAbbreviationInCurrentCulture()
        {
            var prevCulture = Thread.CurrentThread.CurrentUICulture;
            Thread.CurrentThread.CurrentUICulture = CultureInfo.GetCultureInfo("en-US");
            try {
                Assert.Equal("1 ft³/lb", new SpecificVolume(1, SpecificVolumeUnit.CubicFootPerPound).ToString());
                Assert.Equal("1 m³/kg", new SpecificVolume(1, SpecificVolumeUnit.CubicMeterPerKilogram).ToString());
                Assert.Equal("1 L/g", new SpecificVolume(1, SpecificVolumeUnit.LiterPerGram).ToString());
                Assert.Equal("1 mm³/kg", new SpecificVolume(1, SpecificVolumeUnit.MillicubicMeterPerKilogram).ToString());
                Assert.Equal("1 mL/g", new SpecificVolume(1, SpecificVolumeUnit.MilliliterPerGram).ToString());
                Assert.Equal("1 gal (U.S.)/lb", new SpecificVolume(1, SpecificVolumeUnit.USGallonPerPound).ToString());
            }
            finally
            {
                Thread.CurrentThread.CurrentUICulture = prevCulture;
            }
        }

        [Fact]
        public void ToString_WithSwedishCulture_ReturnsUnitAbbreviationForEnglishCultureSinceThereAreNoMappings()
        {
            // Chose this culture, because we don't currently have any abbreviations mapped for that culture and we expect the en-US to be used as fallback.
            var swedishCulture = CultureInfo.GetCultureInfo("sv-SE");

            Assert.Equal("1 ft³/lb", new SpecificVolume(1, SpecificVolumeUnit.CubicFootPerPound).ToString(swedishCulture));
            Assert.Equal("1 m³/kg", new SpecificVolume(1, SpecificVolumeUnit.CubicMeterPerKilogram).ToString(swedishCulture));
            Assert.Equal("1 L/g", new SpecificVolume(1, SpecificVolumeUnit.LiterPerGram).ToString(swedishCulture));
            Assert.Equal("1 mm³/kg", new SpecificVolume(1, SpecificVolumeUnit.MillicubicMeterPerKilogram).ToString(swedishCulture));
            Assert.Equal("1 mL/g", new SpecificVolume(1, SpecificVolumeUnit.MilliliterPerGram).ToString(swedishCulture));
            Assert.Equal("1 gal (U.S.)/lb", new SpecificVolume(1, SpecificVolumeUnit.USGallonPerPound).ToString(swedishCulture));
        }

        [Fact]
        public void ToString_SFormat_FormatsNumberWithGivenDigitsAfterRadixForCurrentCulture()
        {
            var oldCulture = CultureInfo.CurrentUICulture;
            try
            {
                CultureInfo.CurrentUICulture = CultureInfo.InvariantCulture;
                Assert.Equal("0.1 m³/kg", new SpecificVolume(0.123456, SpecificVolumeUnit.CubicMeterPerKilogram).ToString("s1"));
                Assert.Equal("0.12 m³/kg", new SpecificVolume(0.123456, SpecificVolumeUnit.CubicMeterPerKilogram).ToString("s2"));
                Assert.Equal("0.123 m³/kg", new SpecificVolume(0.123456, SpecificVolumeUnit.CubicMeterPerKilogram).ToString("s3"));
                Assert.Equal("0.1235 m³/kg", new SpecificVolume(0.123456, SpecificVolumeUnit.CubicMeterPerKilogram).ToString("s4"));
            }
            finally
            {
                CultureInfo.CurrentUICulture = oldCulture;
            }
        }

        [Fact]
        public void ToString_SFormatAndCulture_FormatsNumberWithGivenDigitsAfterRadixForGivenCulture()
        {
            var culture = CultureInfo.InvariantCulture;
            Assert.Equal("0.1 m³/kg", new SpecificVolume(0.123456, SpecificVolumeUnit.CubicMeterPerKilogram).ToString("s1", culture));
            Assert.Equal("0.12 m³/kg", new SpecificVolume(0.123456, SpecificVolumeUnit.CubicMeterPerKilogram).ToString("s2", culture));
            Assert.Equal("0.123 m³/kg", new SpecificVolume(0.123456, SpecificVolumeUnit.CubicMeterPerKilogram).ToString("s3", culture));
            Assert.Equal("0.1235 m³/kg", new SpecificVolume(0.123456, SpecificVolumeUnit.CubicMeterPerKilogram).ToString("s4", culture));
        }


        [Fact]
        public void ToString_NullFormat_ThrowsArgumentNullException()
        {
            var quantity = SpecificVolume.FromCubicMetersPerKilogram(1.0);
            Assert.Throws<ArgumentNullException>(() => quantity.ToString(null, null, null));
        }

        [Fact]
        public void ToString_NullArgs_ThrowsArgumentNullException()
        {
            var quantity = SpecificVolume.FromCubicMetersPerKilogram(1.0);
            Assert.Throws<ArgumentNullException>(() => quantity.ToString(null, "g", null));
        }

        [Fact]
        public void ToString_NullProvider_EqualsCurrentUICulture()
        {
            var quantity = SpecificVolume.FromCubicMetersPerKilogram(1.0);
            Assert.Equal(quantity.ToString(CultureInfo.CurrentUICulture, "g"), quantity.ToString(null, "g"));
        }


        [Fact]
        public void Convert_ToBool_ThrowsInvalidCastException()
        {
            var quantity = SpecificVolume.FromCubicMetersPerKilogram(1.0);
            Assert.Throws<InvalidCastException>(() => Convert.ToBoolean(quantity));
        }

        [Fact]
        public void Convert_ToByte_EqualsValueAsSameType()
        {
            var quantity = SpecificVolume.FromCubicMetersPerKilogram(1.0);
           Assert.Equal((byte)quantity.Value, Convert.ToByte(quantity));
        }

        [Fact]
        public void Convert_ToChar_ThrowsInvalidCastException()
        {
            var quantity = SpecificVolume.FromCubicMetersPerKilogram(1.0);
            Assert.Throws<InvalidCastException>(() => Convert.ToChar(quantity));
        }

        [Fact]
        public void Convert_ToDateTime_ThrowsInvalidCastException()
        {
            var quantity = SpecificVolume.FromCubicMetersPerKilogram(1.0);
            Assert.Throws<InvalidCastException>(() => Convert.ToDateTime(quantity));
        }

        [Fact]
        public void Convert_ToDecimal_EqualsValueAsSameType()
        {
            var quantity = SpecificVolume.FromCubicMetersPerKilogram(1.0);
            Assert.Equal((decimal)quantity.Value, Convert.ToDecimal(quantity));
        }

        [Fact]
        public void Convert_ToDouble_EqualsValueAsSameType()
        {
            var quantity = SpecificVolume.FromCubicMetersPerKilogram(1.0);
            Assert.Equal((double)quantity.Value, Convert.ToDouble(quantity));
        }

        [Fact]
        public void Convert_ToInt16_EqualsValueAsSameType()
        {
            var quantity = SpecificVolume.FromCubicMetersPerKilogram(1.0);
            Assert.Equal((short)quantity.Value, Convert.ToInt16(quantity));
        }

        [Fact]
        public void Convert_ToInt32_EqualsValueAsSameType()
        {
            var quantity = SpecificVolume.FromCubicMetersPerKilogram(1.0);
            Assert.Equal((int)quantity.Value, Convert.ToInt32(quantity));
        }

        [Fact]
        public void Convert_ToInt64_EqualsValueAsSameType()
        {
            var quantity = SpecificVolume.FromCubicMetersPerKilogram(1.0);
            Assert.Equal((long)quantity.Value, Convert.ToInt64(quantity));
        }

        [Fact]
        public void Convert_ToSByte_EqualsValueAsSameType()
        {
            var quantity = SpecificVolume.FromCubicMetersPerKilogram(1.0);
            Assert.Equal((sbyte)quantity.Value, Convert.ToSByte(quantity));
        }

        [Fact]
        public void Convert_ToSingle_EqualsValueAsSameType()
        {
            var quantity = SpecificVolume.FromCubicMetersPerKilogram(1.0);
            Assert.Equal((float)quantity.Value, Convert.ToSingle(quantity));
        }

        [Fact]
        public void Convert_ToString_EqualsToString()
        {
            var quantity = SpecificVolume.FromCubicMetersPerKilogram(1.0);
            Assert.Equal(quantity.ToString(), Convert.ToString(quantity));
        }

        [Fact]
        public void Convert_ToUInt16_EqualsValueAsSameType()
        {
            var quantity = SpecificVolume.FromCubicMetersPerKilogram(1.0);
            Assert.Equal((ushort)quantity.Value, Convert.ToUInt16(quantity));
        }

        [Fact]
        public void Convert_ToUInt32_EqualsValueAsSameType()
        {
            var quantity = SpecificVolume.FromCubicMetersPerKilogram(1.0);
            Assert.Equal((uint)quantity.Value, Convert.ToUInt32(quantity));
        }

        [Fact]
        public void Convert_ToUInt64_EqualsValueAsSameType()
        {
            var quantity = SpecificVolume.FromCubicMetersPerKilogram(1.0);
            Assert.Equal((ulong)quantity.Value, Convert.ToUInt64(quantity));
        }

        [Fact]
        public void Convert_ChangeType_SelfType_EqualsSelf()
        {
            var quantity = SpecificVolume.FromCubicMetersPerKilogram(1.0);
            Assert.Equal(quantity, Convert.ChangeType(quantity, typeof(SpecificVolume)));
        }

        [Fact]
        public void Convert_ChangeType_UnitType_EqualsUnit()
        {
            var quantity = SpecificVolume.FromCubicMetersPerKilogram(1.0);
            Assert.Equal(quantity.Unit, Convert.ChangeType(quantity, typeof(SpecificVolumeUnit)));
        }

        [Fact]
        public void Convert_ChangeType_QuantityType_EqualsQuantityType()
        {
            var quantity = SpecificVolume.FromCubicMetersPerKilogram(1.0);
            Assert.Equal(QuantityType.SpecificVolume, Convert.ChangeType(quantity, typeof(QuantityType)));
        }

        [Fact]
        public void Convert_ChangeType_QuantityInfo_EqualsQuantityInfo()
        {
            var quantity = SpecificVolume.FromCubicMetersPerKilogram(1.0);
            Assert.Equal(SpecificVolume.Info, Convert.ChangeType(quantity, typeof(QuantityInfo)));
        }

        [Fact]
        public void Convert_ChangeType_BaseDimensions_EqualsBaseDimensions()
        {
            var quantity = SpecificVolume.FromCubicMetersPerKilogram(1.0);
            Assert.Equal(SpecificVolume.BaseDimensions, Convert.ChangeType(quantity, typeof(BaseDimensions)));
        }

        [Fact]
        public void Convert_ChangeType_InvalidType_ThrowsInvalidCastException()
        {
            var quantity = SpecificVolume.FromCubicMetersPerKilogram(1.0);
            Assert.Throws<InvalidCastException>(() => Convert.ChangeType(quantity, typeof(QuantityFormatter)));
        }

        [Fact]
        public void GetHashCode_Equals()
        {
            var quantity = SpecificVolume.FromCubicMetersPerKilogram(1.0);
            Assert.Equal(new {SpecificVolume.Info.Name, quantity.Value, quantity.Unit}.GetHashCode(), quantity.GetHashCode());
        }

        [Theory]
        [InlineData(1.0)]
        [InlineData(-1.0)]
        public void NegationOperator_ReturnsQuantity_WithNegatedValue(double value)
        {
            var quantity = SpecificVolume.FromCubicMetersPerKilogram(value);
            Assert.Equal(SpecificVolume.FromCubicMetersPerKilogram(-value), -quantity);
        }
    }
}
