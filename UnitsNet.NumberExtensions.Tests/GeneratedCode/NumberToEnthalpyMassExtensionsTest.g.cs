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

using UnitsNet.NumberExtensions.NumberToEnthalpyMass;
using Xunit;

namespace UnitsNet.Tests
{
    public class NumberToEnthalpyMassExtensionsTests
    {
        [Fact]
        public void NumberToBTUsPerPoundTest() =>
            Assert.Equal(EnthalpyMass.FromBTUsPerPound(2), 2.BTUsPerPound());

        [Fact]
        public void NumberToCaloriesPerGramTest() =>
            Assert.Equal(EnthalpyMass.FromCaloriesPerGram(2), 2.CaloriesPerGram());

        [Fact]
        public void NumberToJoulesPerKilogramTest() =>
            Assert.Equal(EnthalpyMass.FromJoulesPerKilogram(2), 2.JoulesPerKilogram());

        [Fact]
        public void NumberToKilocaloriesPerGramTest() =>
            Assert.Equal(EnthalpyMass.FromKilocaloriesPerGram(2), 2.KilocaloriesPerGram());

        [Fact]
        public void NumberToKilojoulesPerKilogramTest() =>
            Assert.Equal(EnthalpyMass.FromKilojoulesPerKilogram(2), 2.KilojoulesPerKilogram());

        [Fact]
        public void NumberToMegajoulesPerKilogramTest() =>
            Assert.Equal(EnthalpyMass.FromMegajoulesPerKilogram(2), 2.MegajoulesPerKilogram());

    }
}
