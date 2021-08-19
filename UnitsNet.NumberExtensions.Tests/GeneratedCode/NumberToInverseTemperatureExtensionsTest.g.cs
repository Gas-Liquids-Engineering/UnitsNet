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

using UnitsNet.NumberExtensions.NumberToInverseTemperature;
using Xunit;

namespace UnitsNet.Tests
{
    public class NumberToInverseTemperatureExtensionsTests
    {
        [Fact]
        public void NumberToInverseDegreesCelsiusTest() =>
            Assert.Equal(InverseTemperature.FromInverseDegreesCelsius(2), 2.InverseDegreesCelsius());

        [Fact]
        public void NumberToInverseDegreesFahrenheitTest() =>
            Assert.Equal(InverseTemperature.FromInverseDegreesFahrenheit(2), 2.InverseDegreesFahrenheit());

        [Fact]
        public void NumberToInverseDegreesRankineTest() =>
            Assert.Equal(InverseTemperature.FromInverseDegreesRankine(2), 2.InverseDegreesRankine());

        [Fact]
        public void NumberToInverseKelvinsTest() =>
            Assert.Equal(InverseTemperature.FromInverseKelvins(2), 2.InverseKelvins());

    }
}
