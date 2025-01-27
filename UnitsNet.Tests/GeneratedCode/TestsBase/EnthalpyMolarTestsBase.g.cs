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
    /// Test of EnthalpyMolar.
    /// </summary>
// ReSharper disable once PartialTypeWithSinglePart
    public abstract partial class EnthalpyMolarTestsBase : QuantityTestsBase
    {
        protected abstract double BTUsPerPoundMoleInOneJoulePerMole { get; }
        protected abstract double CaloriesPerMoleInOneJoulePerMole { get; }
        protected abstract double JoulesPerKilomoleInOneJoulePerMole { get; }
        protected abstract double JoulesPerMoleInOneJoulePerMole { get; }
        protected abstract double KilojoulesPerKilomoleInOneJoulePerMole { get; }
        protected abstract double KilojoulesPerMoleInOneJoulePerMole { get; }
        protected abstract double MegajoulesPerMoleInOneJoulePerMole { get; }

// ReSharper disable VirtualMemberNeverOverriden.Global
        protected virtual double BTUsPerPoundMoleTolerance { get { return 1e-5; } }
        protected virtual double CaloriesPerMoleTolerance { get { return 1e-5; } }
        protected virtual double JoulesPerKilomoleTolerance { get { return 1e-5; } }
        protected virtual double JoulesPerMoleTolerance { get { return 1e-5; } }
        protected virtual double KilojoulesPerKilomoleTolerance { get { return 1e-5; } }
        protected virtual double KilojoulesPerMoleTolerance { get { return 1e-5; } }
        protected virtual double MegajoulesPerMoleTolerance { get { return 1e-5; } }
// ReSharper restore VirtualMemberNeverOverriden.Global

        [Fact]
        public void Ctor_WithUndefinedUnit_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => new EnthalpyMolar((double)0.0, EnthalpyMolarUnit.Undefined));
        }

        [Fact]
        public void DefaultCtor_ReturnsQuantityWithZeroValueAndBaseUnit()
        {
            var quantity = new EnthalpyMolar();
            Assert.Equal(0, quantity.Value);
            Assert.Equal(EnthalpyMolarUnit.JoulePerMole, quantity.Unit);
        }


        [Fact]
        public void Ctor_WithInfinityValue_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => new EnthalpyMolar(double.PositiveInfinity, EnthalpyMolarUnit.JoulePerMole));
            Assert.Throws<ArgumentException>(() => new EnthalpyMolar(double.NegativeInfinity, EnthalpyMolarUnit.JoulePerMole));
        }

        [Fact]
        public void Ctor_WithNaNValue_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => new EnthalpyMolar(double.NaN, EnthalpyMolarUnit.JoulePerMole));
        }

        [Fact]
        public void Ctor_NullAsUnitSystem_ThrowsArgumentNullException()
        {
            Assert.Throws<ArgumentNullException>(() => new EnthalpyMolar(value: 1, unitSystem: null));
        }

        [Fact]
        public void Ctor_SIUnitSystem_ThrowsArgumentExceptionIfNotSupported()
        {
            Func<object> TestCode = () => new EnthalpyMolar(value: 1, unitSystem: UnitSystem.SI);
            if (SupportsSIUnitSystem)
            {
                var quantity = (EnthalpyMolar) TestCode();
                Assert.Equal(1, quantity.Value);
            }
            else
            {
                Assert.Throws<ArgumentException>(TestCode);
            }
        }

        [Fact]
        public void EnthalpyMolar_QuantityInfo_ReturnsQuantityInfoDescribingQuantity()
        {
            var quantity = new EnthalpyMolar(1, EnthalpyMolarUnit.JoulePerMole);

            QuantityInfo<EnthalpyMolarUnit> quantityInfo = quantity.QuantityInfo;

            Assert.Equal(EnthalpyMolar.Zero, quantityInfo.Zero);
            Assert.Equal("EnthalpyMolar", quantityInfo.Name);
            Assert.Equal(QuantityType.EnthalpyMolar, quantityInfo.QuantityType);

            var units = EnumUtils.GetEnumValues<EnthalpyMolarUnit>().Except(new[] {EnthalpyMolarUnit.Undefined}).ToArray();
            var unitNames = units.Select(x => x.ToString());

            // Obsolete members
            Assert.Equal(units, quantityInfo.Units);
            Assert.Equal(unitNames, quantityInfo.UnitNames);
        }

        [Fact]
        public void JoulePerMoleToEnthalpyMolarUnits()
        {
            EnthalpyMolar joulepermole = EnthalpyMolar.FromJoulesPerMole(1);
            AssertEx.EqualTolerance(BTUsPerPoundMoleInOneJoulePerMole, joulepermole.BTUsPerPoundMole, BTUsPerPoundMoleTolerance);
            AssertEx.EqualTolerance(CaloriesPerMoleInOneJoulePerMole, joulepermole.CaloriesPerMole, CaloriesPerMoleTolerance);
            AssertEx.EqualTolerance(JoulesPerKilomoleInOneJoulePerMole, joulepermole.JoulesPerKilomole, JoulesPerKilomoleTolerance);
            AssertEx.EqualTolerance(JoulesPerMoleInOneJoulePerMole, joulepermole.JoulesPerMole, JoulesPerMoleTolerance);
            AssertEx.EqualTolerance(KilojoulesPerKilomoleInOneJoulePerMole, joulepermole.KilojoulesPerKilomole, KilojoulesPerKilomoleTolerance);
            AssertEx.EqualTolerance(KilojoulesPerMoleInOneJoulePerMole, joulepermole.KilojoulesPerMole, KilojoulesPerMoleTolerance);
            AssertEx.EqualTolerance(MegajoulesPerMoleInOneJoulePerMole, joulepermole.MegajoulesPerMole, MegajoulesPerMoleTolerance);
        }

        [Fact]
        public void From_ValueAndUnit_ReturnsQuantityWithSameValueAndUnit()
        {
            var quantity00 = EnthalpyMolar.From(1, EnthalpyMolarUnit.BTUPerPoundMole);
            AssertEx.EqualTolerance(1, quantity00.BTUsPerPoundMole, BTUsPerPoundMoleTolerance);
            Assert.Equal(EnthalpyMolarUnit.BTUPerPoundMole, quantity00.Unit);

            var quantity01 = EnthalpyMolar.From(1, EnthalpyMolarUnit.CaloriesPerMole);
            AssertEx.EqualTolerance(1, quantity01.CaloriesPerMole, CaloriesPerMoleTolerance);
            Assert.Equal(EnthalpyMolarUnit.CaloriesPerMole, quantity01.Unit);

            var quantity02 = EnthalpyMolar.From(1, EnthalpyMolarUnit.JoulePerKilomole);
            AssertEx.EqualTolerance(1, quantity02.JoulesPerKilomole, JoulesPerKilomoleTolerance);
            Assert.Equal(EnthalpyMolarUnit.JoulePerKilomole, quantity02.Unit);

            var quantity03 = EnthalpyMolar.From(1, EnthalpyMolarUnit.JoulePerMole);
            AssertEx.EqualTolerance(1, quantity03.JoulesPerMole, JoulesPerMoleTolerance);
            Assert.Equal(EnthalpyMolarUnit.JoulePerMole, quantity03.Unit);

            var quantity04 = EnthalpyMolar.From(1, EnthalpyMolarUnit.KilojoulePerKilomole);
            AssertEx.EqualTolerance(1, quantity04.KilojoulesPerKilomole, KilojoulesPerKilomoleTolerance);
            Assert.Equal(EnthalpyMolarUnit.KilojoulePerKilomole, quantity04.Unit);

            var quantity05 = EnthalpyMolar.From(1, EnthalpyMolarUnit.KilojoulePerMole);
            AssertEx.EqualTolerance(1, quantity05.KilojoulesPerMole, KilojoulesPerMoleTolerance);
            Assert.Equal(EnthalpyMolarUnit.KilojoulePerMole, quantity05.Unit);

            var quantity06 = EnthalpyMolar.From(1, EnthalpyMolarUnit.MegajoulePerMole);
            AssertEx.EqualTolerance(1, quantity06.MegajoulesPerMole, MegajoulesPerMoleTolerance);
            Assert.Equal(EnthalpyMolarUnit.MegajoulePerMole, quantity06.Unit);

        }

        [Fact]
        public void FromJoulesPerMole_WithInfinityValue_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => EnthalpyMolar.FromJoulesPerMole(double.PositiveInfinity));
            Assert.Throws<ArgumentException>(() => EnthalpyMolar.FromJoulesPerMole(double.NegativeInfinity));
        }

        [Fact]
        public void FromJoulesPerMole_WithNanValue_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => EnthalpyMolar.FromJoulesPerMole(double.NaN));
        }

        [Fact]
        public void As()
        {
            var joulepermole = EnthalpyMolar.FromJoulesPerMole(1);
            AssertEx.EqualTolerance(BTUsPerPoundMoleInOneJoulePerMole, joulepermole.As(EnthalpyMolarUnit.BTUPerPoundMole), BTUsPerPoundMoleTolerance);
            AssertEx.EqualTolerance(CaloriesPerMoleInOneJoulePerMole, joulepermole.As(EnthalpyMolarUnit.CaloriesPerMole), CaloriesPerMoleTolerance);
            AssertEx.EqualTolerance(JoulesPerKilomoleInOneJoulePerMole, joulepermole.As(EnthalpyMolarUnit.JoulePerKilomole), JoulesPerKilomoleTolerance);
            AssertEx.EqualTolerance(JoulesPerMoleInOneJoulePerMole, joulepermole.As(EnthalpyMolarUnit.JoulePerMole), JoulesPerMoleTolerance);
            AssertEx.EqualTolerance(KilojoulesPerKilomoleInOneJoulePerMole, joulepermole.As(EnthalpyMolarUnit.KilojoulePerKilomole), KilojoulesPerKilomoleTolerance);
            AssertEx.EqualTolerance(KilojoulesPerMoleInOneJoulePerMole, joulepermole.As(EnthalpyMolarUnit.KilojoulePerMole), KilojoulesPerMoleTolerance);
            AssertEx.EqualTolerance(MegajoulesPerMoleInOneJoulePerMole, joulepermole.As(EnthalpyMolarUnit.MegajoulePerMole), MegajoulesPerMoleTolerance);
        }

        [Fact]
        public void As_SIUnitSystem_ThrowsArgumentExceptionIfNotSupported()
        {
            var quantity = new EnthalpyMolar(value: 1, unit: EnthalpyMolar.BaseUnit);
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
            var joulepermole = EnthalpyMolar.FromJoulesPerMole(1);

            var btuperpoundmoleQuantity = joulepermole.ToUnit(EnthalpyMolarUnit.BTUPerPoundMole);
            AssertEx.EqualTolerance(BTUsPerPoundMoleInOneJoulePerMole, (double)btuperpoundmoleQuantity.Value, BTUsPerPoundMoleTolerance);
            Assert.Equal(EnthalpyMolarUnit.BTUPerPoundMole, btuperpoundmoleQuantity.Unit);

            var caloriespermoleQuantity = joulepermole.ToUnit(EnthalpyMolarUnit.CaloriesPerMole);
            AssertEx.EqualTolerance(CaloriesPerMoleInOneJoulePerMole, (double)caloriespermoleQuantity.Value, CaloriesPerMoleTolerance);
            Assert.Equal(EnthalpyMolarUnit.CaloriesPerMole, caloriespermoleQuantity.Unit);

            var jouleperkilomoleQuantity = joulepermole.ToUnit(EnthalpyMolarUnit.JoulePerKilomole);
            AssertEx.EqualTolerance(JoulesPerKilomoleInOneJoulePerMole, (double)jouleperkilomoleQuantity.Value, JoulesPerKilomoleTolerance);
            Assert.Equal(EnthalpyMolarUnit.JoulePerKilomole, jouleperkilomoleQuantity.Unit);

            var joulepermoleQuantity = joulepermole.ToUnit(EnthalpyMolarUnit.JoulePerMole);
            AssertEx.EqualTolerance(JoulesPerMoleInOneJoulePerMole, (double)joulepermoleQuantity.Value, JoulesPerMoleTolerance);
            Assert.Equal(EnthalpyMolarUnit.JoulePerMole, joulepermoleQuantity.Unit);

            var kilojouleperkilomoleQuantity = joulepermole.ToUnit(EnthalpyMolarUnit.KilojoulePerKilomole);
            AssertEx.EqualTolerance(KilojoulesPerKilomoleInOneJoulePerMole, (double)kilojouleperkilomoleQuantity.Value, KilojoulesPerKilomoleTolerance);
            Assert.Equal(EnthalpyMolarUnit.KilojoulePerKilomole, kilojouleperkilomoleQuantity.Unit);

            var kilojoulepermoleQuantity = joulepermole.ToUnit(EnthalpyMolarUnit.KilojoulePerMole);
            AssertEx.EqualTolerance(KilojoulesPerMoleInOneJoulePerMole, (double)kilojoulepermoleQuantity.Value, KilojoulesPerMoleTolerance);
            Assert.Equal(EnthalpyMolarUnit.KilojoulePerMole, kilojoulepermoleQuantity.Unit);

            var megajoulepermoleQuantity = joulepermole.ToUnit(EnthalpyMolarUnit.MegajoulePerMole);
            AssertEx.EqualTolerance(MegajoulesPerMoleInOneJoulePerMole, (double)megajoulepermoleQuantity.Value, MegajoulesPerMoleTolerance);
            Assert.Equal(EnthalpyMolarUnit.MegajoulePerMole, megajoulepermoleQuantity.Unit);
        }

        [Fact]
        public void ToBaseUnit_ReturnsQuantityWithBaseUnit()
        {
            var quantityInBaseUnit = EnthalpyMolar.FromJoulesPerMole(1).ToBaseUnit();
            Assert.Equal(EnthalpyMolar.BaseUnit, quantityInBaseUnit.Unit);
        }

        [Fact]
        public void ConversionRoundTrip()
        {
            EnthalpyMolar joulepermole = EnthalpyMolar.FromJoulesPerMole(1);
            AssertEx.EqualTolerance(1, EnthalpyMolar.FromBTUsPerPoundMole(joulepermole.BTUsPerPoundMole).JoulesPerMole, BTUsPerPoundMoleTolerance);
            AssertEx.EqualTolerance(1, EnthalpyMolar.FromCaloriesPerMole(joulepermole.CaloriesPerMole).JoulesPerMole, CaloriesPerMoleTolerance);
            AssertEx.EqualTolerance(1, EnthalpyMolar.FromJoulesPerKilomole(joulepermole.JoulesPerKilomole).JoulesPerMole, JoulesPerKilomoleTolerance);
            AssertEx.EqualTolerance(1, EnthalpyMolar.FromJoulesPerMole(joulepermole.JoulesPerMole).JoulesPerMole, JoulesPerMoleTolerance);
            AssertEx.EqualTolerance(1, EnthalpyMolar.FromKilojoulesPerKilomole(joulepermole.KilojoulesPerKilomole).JoulesPerMole, KilojoulesPerKilomoleTolerance);
            AssertEx.EqualTolerance(1, EnthalpyMolar.FromKilojoulesPerMole(joulepermole.KilojoulesPerMole).JoulesPerMole, KilojoulesPerMoleTolerance);
            AssertEx.EqualTolerance(1, EnthalpyMolar.FromMegajoulesPerMole(joulepermole.MegajoulesPerMole).JoulesPerMole, MegajoulesPerMoleTolerance);
        }

        [Fact]
        public void ArithmeticOperators()
        {
            EnthalpyMolar v = EnthalpyMolar.FromJoulesPerMole(1);
            AssertEx.EqualTolerance(-1, -v.JoulesPerMole, JoulesPerMoleTolerance);
            AssertEx.EqualTolerance(2, (EnthalpyMolar.FromJoulesPerMole(3)-v).JoulesPerMole, JoulesPerMoleTolerance);
            AssertEx.EqualTolerance(2, (v + v).JoulesPerMole, JoulesPerMoleTolerance);
            AssertEx.EqualTolerance(10, (v*10).JoulesPerMole, JoulesPerMoleTolerance);
            AssertEx.EqualTolerance(10, (10*v).JoulesPerMole, JoulesPerMoleTolerance);
            AssertEx.EqualTolerance(2, (EnthalpyMolar.FromJoulesPerMole(10)/5).JoulesPerMole, JoulesPerMoleTolerance);
            AssertEx.EqualTolerance(2, EnthalpyMolar.FromJoulesPerMole(10)/EnthalpyMolar.FromJoulesPerMole(5), JoulesPerMoleTolerance);
        }

        [Fact]
        public void ComparisonOperators()
        {
            EnthalpyMolar oneJoulePerMole = EnthalpyMolar.FromJoulesPerMole(1);
            EnthalpyMolar twoJoulesPerMole = EnthalpyMolar.FromJoulesPerMole(2);

            Assert.True(oneJoulePerMole < twoJoulesPerMole);
            Assert.True(oneJoulePerMole <= twoJoulesPerMole);
            Assert.True(twoJoulesPerMole > oneJoulePerMole);
            Assert.True(twoJoulesPerMole >= oneJoulePerMole);

            Assert.False(oneJoulePerMole > twoJoulesPerMole);
            Assert.False(oneJoulePerMole >= twoJoulesPerMole);
            Assert.False(twoJoulesPerMole < oneJoulePerMole);
            Assert.False(twoJoulesPerMole <= oneJoulePerMole);
        }

        [Fact]
        public void CompareToIsImplemented()
        {
            EnthalpyMolar joulepermole = EnthalpyMolar.FromJoulesPerMole(1);
            Assert.Equal(0, joulepermole.CompareTo(joulepermole));
            Assert.True(joulepermole.CompareTo(EnthalpyMolar.Zero) > 0);
            Assert.True(EnthalpyMolar.Zero.CompareTo(joulepermole) < 0);
        }

        [Fact]
        public void CompareToThrowsOnTypeMismatch()
        {
            EnthalpyMolar joulepermole = EnthalpyMolar.FromJoulesPerMole(1);
            Assert.Throws<ArgumentException>(() => joulepermole.CompareTo(new object()));
        }

        [Fact]
        public void CompareToThrowsOnNull()
        {
            EnthalpyMolar joulepermole = EnthalpyMolar.FromJoulesPerMole(1);
            Assert.Throws<ArgumentNullException>(() => joulepermole.CompareTo(null));
        }

        [Fact]
        public void EqualityOperators()
        {
            var a = EnthalpyMolar.FromJoulesPerMole(1);
            var b = EnthalpyMolar.FromJoulesPerMole(2);

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
            var a = EnthalpyMolar.FromJoulesPerMole(1);
            var b = EnthalpyMolar.FromJoulesPerMole(2);

            Assert.True(a.Equals(a));
            Assert.False(a.Equals(b));
        }

        [Fact]
        public void Equals_QuantityAsObject_IsImplemented()
        {
            object a = EnthalpyMolar.FromJoulesPerMole(1);
            object b = EnthalpyMolar.FromJoulesPerMole(2);

            Assert.True(a.Equals(a));
            Assert.False(a.Equals(b));
            Assert.False(a.Equals((object)null));
        }

        [Fact]
        public void Equals_RelativeTolerance_IsImplemented()
        {
            var v = EnthalpyMolar.FromJoulesPerMole(1);
            Assert.True(v.Equals(EnthalpyMolar.FromJoulesPerMole(1), JoulesPerMoleTolerance, ComparisonType.Relative));
            Assert.False(v.Equals(EnthalpyMolar.Zero, JoulesPerMoleTolerance, ComparisonType.Relative));
        }

        [Fact]
        public void Equals_NegativeRelativeTolerance_ThrowsArgumentOutOfRangeException()
        {
            var v = EnthalpyMolar.FromJoulesPerMole(1);
            Assert.Throws<ArgumentOutOfRangeException>(() => v.Equals(EnthalpyMolar.FromJoulesPerMole(1), -1, ComparisonType.Relative));
        }

        [Fact]
        public void EqualsReturnsFalseOnTypeMismatch()
        {
            EnthalpyMolar joulepermole = EnthalpyMolar.FromJoulesPerMole(1);
            Assert.False(joulepermole.Equals(new object()));
        }

        [Fact]
        public void EqualsReturnsFalseOnNull()
        {
            EnthalpyMolar joulepermole = EnthalpyMolar.FromJoulesPerMole(1);
            Assert.False(joulepermole.Equals(null));
        }

        [Fact]
        public void UnitsDoesNotContainUndefined()
        {
            Assert.DoesNotContain(EnthalpyMolarUnit.Undefined, EnthalpyMolar.Units);
        }

        [Fact]
        public void HasAtLeastOneAbbreviationSpecified()
        {
            var units = Enum.GetValues(typeof(EnthalpyMolarUnit)).Cast<EnthalpyMolarUnit>();
            foreach(var unit in units)
            {
                if(unit == EnthalpyMolarUnit.Undefined)
                    continue;

                var defaultAbbreviation = UnitAbbreviationsCache.Default.GetDefaultAbbreviation(unit);
            }
        }

        [Fact]
        public void BaseDimensionsShouldNeverBeNull()
        {
            Assert.False(EnthalpyMolar.BaseDimensions is null);
        }

        [Fact]
        public void ToString_ReturnsValueAndUnitAbbreviationInCurrentCulture()
        {
            var prevCulture = Thread.CurrentThread.CurrentUICulture;
            Thread.CurrentThread.CurrentUICulture = CultureInfo.GetCultureInfo("en-US");
            try {
                Assert.Equal("1 BTU/lbmol", new EnthalpyMolar(1, EnthalpyMolarUnit.BTUPerPoundMole).ToString());
                Assert.Equal("1 cal/mol", new EnthalpyMolar(1, EnthalpyMolarUnit.CaloriesPerMole).ToString());
                Assert.Equal("1 J/kmol", new EnthalpyMolar(1, EnthalpyMolarUnit.JoulePerKilomole).ToString());
                Assert.Equal("1 J/mol", new EnthalpyMolar(1, EnthalpyMolarUnit.JoulePerMole).ToString());
                Assert.Equal("1 kJ/kmol", new EnthalpyMolar(1, EnthalpyMolarUnit.KilojoulePerKilomole).ToString());
                Assert.Equal("1 kJ/mol", new EnthalpyMolar(1, EnthalpyMolarUnit.KilojoulePerMole).ToString());
                Assert.Equal("1 MJ/mol", new EnthalpyMolar(1, EnthalpyMolarUnit.MegajoulePerMole).ToString());
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

            Assert.Equal("1 BTU/lbmol", new EnthalpyMolar(1, EnthalpyMolarUnit.BTUPerPoundMole).ToString(swedishCulture));
            Assert.Equal("1 cal/mol", new EnthalpyMolar(1, EnthalpyMolarUnit.CaloriesPerMole).ToString(swedishCulture));
            Assert.Equal("1 J/kmol", new EnthalpyMolar(1, EnthalpyMolarUnit.JoulePerKilomole).ToString(swedishCulture));
            Assert.Equal("1 J/mol", new EnthalpyMolar(1, EnthalpyMolarUnit.JoulePerMole).ToString(swedishCulture));
            Assert.Equal("1 kJ/kmol", new EnthalpyMolar(1, EnthalpyMolarUnit.KilojoulePerKilomole).ToString(swedishCulture));
            Assert.Equal("1 kJ/mol", new EnthalpyMolar(1, EnthalpyMolarUnit.KilojoulePerMole).ToString(swedishCulture));
            Assert.Equal("1 MJ/mol", new EnthalpyMolar(1, EnthalpyMolarUnit.MegajoulePerMole).ToString(swedishCulture));
        }

        [Fact]
        public void ToString_SFormat_FormatsNumberWithGivenDigitsAfterRadixForCurrentCulture()
        {
            var oldCulture = CultureInfo.CurrentUICulture;
            try
            {
                CultureInfo.CurrentUICulture = CultureInfo.InvariantCulture;
                Assert.Equal("0.1 J/mol", new EnthalpyMolar(0.123456, EnthalpyMolarUnit.JoulePerMole).ToString("s1"));
                Assert.Equal("0.12 J/mol", new EnthalpyMolar(0.123456, EnthalpyMolarUnit.JoulePerMole).ToString("s2"));
                Assert.Equal("0.123 J/mol", new EnthalpyMolar(0.123456, EnthalpyMolarUnit.JoulePerMole).ToString("s3"));
                Assert.Equal("0.1235 J/mol", new EnthalpyMolar(0.123456, EnthalpyMolarUnit.JoulePerMole).ToString("s4"));
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
            Assert.Equal("0.1 J/mol", new EnthalpyMolar(0.123456, EnthalpyMolarUnit.JoulePerMole).ToString("s1", culture));
            Assert.Equal("0.12 J/mol", new EnthalpyMolar(0.123456, EnthalpyMolarUnit.JoulePerMole).ToString("s2", culture));
            Assert.Equal("0.123 J/mol", new EnthalpyMolar(0.123456, EnthalpyMolarUnit.JoulePerMole).ToString("s3", culture));
            Assert.Equal("0.1235 J/mol", new EnthalpyMolar(0.123456, EnthalpyMolarUnit.JoulePerMole).ToString("s4", culture));
        }


        [Fact]
        public void ToString_NullFormat_ThrowsArgumentNullException()
        {
            var quantity = EnthalpyMolar.FromJoulesPerMole(1.0);
            Assert.Throws<ArgumentNullException>(() => quantity.ToString(null, null, null));
        }

        [Fact]
        public void ToString_NullArgs_ThrowsArgumentNullException()
        {
            var quantity = EnthalpyMolar.FromJoulesPerMole(1.0);
            Assert.Throws<ArgumentNullException>(() => quantity.ToString(null, "g", null));
        }

        [Fact]
        public void ToString_NullProvider_EqualsCurrentUICulture()
        {
            var quantity = EnthalpyMolar.FromJoulesPerMole(1.0);
            Assert.Equal(quantity.ToString(CultureInfo.CurrentUICulture, "g"), quantity.ToString(null, "g"));
        }


        [Fact]
        public void Convert_ToBool_ThrowsInvalidCastException()
        {
            var quantity = EnthalpyMolar.FromJoulesPerMole(1.0);
            Assert.Throws<InvalidCastException>(() => Convert.ToBoolean(quantity));
        }

        [Fact]
        public void Convert_ToByte_EqualsValueAsSameType()
        {
            var quantity = EnthalpyMolar.FromJoulesPerMole(1.0);
           Assert.Equal((byte)quantity.Value, Convert.ToByte(quantity));
        }

        [Fact]
        public void Convert_ToChar_ThrowsInvalidCastException()
        {
            var quantity = EnthalpyMolar.FromJoulesPerMole(1.0);
            Assert.Throws<InvalidCastException>(() => Convert.ToChar(quantity));
        }

        [Fact]
        public void Convert_ToDateTime_ThrowsInvalidCastException()
        {
            var quantity = EnthalpyMolar.FromJoulesPerMole(1.0);
            Assert.Throws<InvalidCastException>(() => Convert.ToDateTime(quantity));
        }

        [Fact]
        public void Convert_ToDecimal_EqualsValueAsSameType()
        {
            var quantity = EnthalpyMolar.FromJoulesPerMole(1.0);
            Assert.Equal((decimal)quantity.Value, Convert.ToDecimal(quantity));
        }

        [Fact]
        public void Convert_ToDouble_EqualsValueAsSameType()
        {
            var quantity = EnthalpyMolar.FromJoulesPerMole(1.0);
            Assert.Equal((double)quantity.Value, Convert.ToDouble(quantity));
        }

        [Fact]
        public void Convert_ToInt16_EqualsValueAsSameType()
        {
            var quantity = EnthalpyMolar.FromJoulesPerMole(1.0);
            Assert.Equal((short)quantity.Value, Convert.ToInt16(quantity));
        }

        [Fact]
        public void Convert_ToInt32_EqualsValueAsSameType()
        {
            var quantity = EnthalpyMolar.FromJoulesPerMole(1.0);
            Assert.Equal((int)quantity.Value, Convert.ToInt32(quantity));
        }

        [Fact]
        public void Convert_ToInt64_EqualsValueAsSameType()
        {
            var quantity = EnthalpyMolar.FromJoulesPerMole(1.0);
            Assert.Equal((long)quantity.Value, Convert.ToInt64(quantity));
        }

        [Fact]
        public void Convert_ToSByte_EqualsValueAsSameType()
        {
            var quantity = EnthalpyMolar.FromJoulesPerMole(1.0);
            Assert.Equal((sbyte)quantity.Value, Convert.ToSByte(quantity));
        }

        [Fact]
        public void Convert_ToSingle_EqualsValueAsSameType()
        {
            var quantity = EnthalpyMolar.FromJoulesPerMole(1.0);
            Assert.Equal((float)quantity.Value, Convert.ToSingle(quantity));
        }

        [Fact]
        public void Convert_ToString_EqualsToString()
        {
            var quantity = EnthalpyMolar.FromJoulesPerMole(1.0);
            Assert.Equal(quantity.ToString(), Convert.ToString(quantity));
        }

        [Fact]
        public void Convert_ToUInt16_EqualsValueAsSameType()
        {
            var quantity = EnthalpyMolar.FromJoulesPerMole(1.0);
            Assert.Equal((ushort)quantity.Value, Convert.ToUInt16(quantity));
        }

        [Fact]
        public void Convert_ToUInt32_EqualsValueAsSameType()
        {
            var quantity = EnthalpyMolar.FromJoulesPerMole(1.0);
            Assert.Equal((uint)quantity.Value, Convert.ToUInt32(quantity));
        }

        [Fact]
        public void Convert_ToUInt64_EqualsValueAsSameType()
        {
            var quantity = EnthalpyMolar.FromJoulesPerMole(1.0);
            Assert.Equal((ulong)quantity.Value, Convert.ToUInt64(quantity));
        }

        [Fact]
        public void Convert_ChangeType_SelfType_EqualsSelf()
        {
            var quantity = EnthalpyMolar.FromJoulesPerMole(1.0);
            Assert.Equal(quantity, Convert.ChangeType(quantity, typeof(EnthalpyMolar)));
        }

        [Fact]
        public void Convert_ChangeType_UnitType_EqualsUnit()
        {
            var quantity = EnthalpyMolar.FromJoulesPerMole(1.0);
            Assert.Equal(quantity.Unit, Convert.ChangeType(quantity, typeof(EnthalpyMolarUnit)));
        }

        [Fact]
        public void Convert_ChangeType_QuantityType_EqualsQuantityType()
        {
            var quantity = EnthalpyMolar.FromJoulesPerMole(1.0);
            Assert.Equal(QuantityType.EnthalpyMolar, Convert.ChangeType(quantity, typeof(QuantityType)));
        }

        [Fact]
        public void Convert_ChangeType_QuantityInfo_EqualsQuantityInfo()
        {
            var quantity = EnthalpyMolar.FromJoulesPerMole(1.0);
            Assert.Equal(EnthalpyMolar.Info, Convert.ChangeType(quantity, typeof(QuantityInfo)));
        }

        [Fact]
        public void Convert_ChangeType_BaseDimensions_EqualsBaseDimensions()
        {
            var quantity = EnthalpyMolar.FromJoulesPerMole(1.0);
            Assert.Equal(EnthalpyMolar.BaseDimensions, Convert.ChangeType(quantity, typeof(BaseDimensions)));
        }

        [Fact]
        public void Convert_ChangeType_InvalidType_ThrowsInvalidCastException()
        {
            var quantity = EnthalpyMolar.FromJoulesPerMole(1.0);
            Assert.Throws<InvalidCastException>(() => Convert.ChangeType(quantity, typeof(QuantityFormatter)));
        }

        [Fact]
        public void GetHashCode_Equals()
        {
            var quantity = EnthalpyMolar.FromJoulesPerMole(1.0);
            Assert.Equal(new {EnthalpyMolar.Info.Name, quantity.Value, quantity.Unit}.GetHashCode(), quantity.GetHashCode());
        }

        [Theory]
        [InlineData(1.0)]
        [InlineData(-1.0)]
        public void NegationOperator_ReturnsQuantity_WithNegatedValue(double value)
        {
            var quantity = EnthalpyMolar.FromJoulesPerMole(value);
            Assert.Equal(EnthalpyMolar.FromJoulesPerMole(-value), -quantity);
        }
    }
}
