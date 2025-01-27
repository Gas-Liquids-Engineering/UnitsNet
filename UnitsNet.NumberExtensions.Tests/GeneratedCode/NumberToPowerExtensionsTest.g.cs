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

using UnitsNet.NumberExtensions.NumberToPower;
using Xunit;

namespace UnitsNet.Tests
{
    public class NumberToPowerExtensionsTests
    {
        [Fact]
        public void NumberToBoilerHorsepowerTest() =>
            Assert.Equal(Power.FromBoilerHorsepower(2), 2.BoilerHorsepower());

        [Fact]
        public void NumberToBritishThermalUnitsPerHourTest() =>
            Assert.Equal(Power.FromBritishThermalUnitsPerHour(2), 2.BritishThermalUnitsPerHour());

        [Fact]
        public void NumberToCaloriesPerHourTest() =>
            Assert.Equal(Power.FromCaloriesPerHour(2), 2.CaloriesPerHour());

        [Fact]
        public void NumberToDecawattsTest() =>
            Assert.Equal(Power.FromDecawatts(2), 2.Decawatts());

        [Fact]
        public void NumberToDeciwattsTest() =>
            Assert.Equal(Power.FromDeciwatts(2), 2.Deciwatts());

        [Fact]
        public void NumberToElectricalHorsepowerTest() =>
            Assert.Equal(Power.FromElectricalHorsepower(2), 2.ElectricalHorsepower());

        [Fact]
        public void NumberToFemtowattsTest() =>
            Assert.Equal(Power.FromFemtowatts(2), 2.Femtowatts());

        [Fact]
        public void NumberToGigacaloriesPerHourTest() =>
            Assert.Equal(Power.FromGigacaloriesPerHour(2), 2.GigacaloriesPerHour());

        [Fact]
        public void NumberToGigajoulesPerHourTest() =>
            Assert.Equal(Power.FromGigajoulesPerHour(2), 2.GigajoulesPerHour());

        [Fact]
        public void NumberToGigawattsTest() =>
            Assert.Equal(Power.FromGigawatts(2), 2.Gigawatts());

        [Fact]
        public void NumberToHydraulicHorsepowerTest() =>
            Assert.Equal(Power.FromHydraulicHorsepower(2), 2.HydraulicHorsepower());

        [Fact]
        public void NumberToJoulesPerHourTest() =>
            Assert.Equal(Power.FromJoulesPerHour(2), 2.JoulesPerHour());

        [Fact]
        public void NumberToKilobritishThermalUnitsPerHourTest() =>
            Assert.Equal(Power.FromKilobritishThermalUnitsPerHour(2), 2.KilobritishThermalUnitsPerHour());

        [Fact]
        public void NumberToKilocaloriesPerHourTest() =>
            Assert.Equal(Power.FromKilocaloriesPerHour(2), 2.KilocaloriesPerHour());

        [Fact]
        public void NumberToKilojoulesPerHourTest() =>
            Assert.Equal(Power.FromKilojoulesPerHour(2), 2.KilojoulesPerHour());

        [Fact]
        public void NumberToKilowattsTest() =>
            Assert.Equal(Power.FromKilowatts(2), 2.Kilowatts());

        [Fact]
        public void NumberToMechanicalHorsepowerTest() =>
            Assert.Equal(Power.FromMechanicalHorsepower(2), 2.MechanicalHorsepower());

        [Fact]
        public void NumberToMegacaloriesPerHourTest() =>
            Assert.Equal(Power.FromMegacaloriesPerHour(2), 2.MegacaloriesPerHour());

        [Fact]
        public void NumberToMegajoulesPerHourTest() =>
            Assert.Equal(Power.FromMegajoulesPerHour(2), 2.MegajoulesPerHour());

        [Fact]
        public void NumberToMegawattsTest() =>
            Assert.Equal(Power.FromMegawatts(2), 2.Megawatts());

        [Fact]
        public void NumberToMetricHorsepowerTest() =>
            Assert.Equal(Power.FromMetricHorsepower(2), 2.MetricHorsepower());

        [Fact]
        public void NumberToMicrowattsTest() =>
            Assert.Equal(Power.FromMicrowatts(2), 2.Microwatts());

        [Fact]
        public void NumberToMillicaloriesPerHourTest() =>
            Assert.Equal(Power.FromMillicaloriesPerHour(2), 2.MillicaloriesPerHour());

        [Fact]
        public void NumberToMillijoulesPerHourTest() =>
            Assert.Equal(Power.FromMillijoulesPerHour(2), 2.MillijoulesPerHour());

        [Fact]
        public void NumberToMilliwattsTest() =>
            Assert.Equal(Power.FromMilliwatts(2), 2.Milliwatts());

        [Fact]
        public void NumberToNanowattsTest() =>
            Assert.Equal(Power.FromNanowatts(2), 2.Nanowatts());

        [Fact]
        public void NumberToPetawattsTest() =>
            Assert.Equal(Power.FromPetawatts(2), 2.Petawatts());

        [Fact]
        public void NumberToPicowattsTest() =>
            Assert.Equal(Power.FromPicowatts(2), 2.Picowatts());

        [Fact]
        public void NumberToTerawattsTest() =>
            Assert.Equal(Power.FromTerawatts(2), 2.Terawatts());

        [Fact]
        public void NumberToWattsTest() =>
            Assert.Equal(Power.FromWatts(2), 2.Watts());

    }
}
