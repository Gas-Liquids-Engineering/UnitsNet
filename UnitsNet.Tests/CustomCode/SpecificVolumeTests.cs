﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated (once) by \generate-code.bat, but will not be
//     regenerated when it already exists. The purpose of creating this file is to make
//     it easier to remember to implement all the unit conversion test cases.
//
//     Whenever a new unit is added to this quantity and \generate-code.bat is run,
//     the base test class will get a new abstract property and cause a compile error
//     in this derived class, reminding the developer to implement the test case
//     for the new unit.
//
//     See https://github.com/angularsen/UnitsNet/wiki/Adding-a-New-Unit for how to add or edit units.
//
//     Add CustomCode\Quantities\MyQuantity.extra.cs files to add code to generated quantities.
//     Add UnitDefinitions\MyQuantity.json and run GeneratUnits.bat to generate new units or quantities.
//
// </auto-generated>
//------------------------------------------------------------------------------

// Licensed under MIT No Attribution, see LICENSE file at the root.
// Copyright 2013 Andreas Gullberg Larsen (andreas.larsen84@gmail.com). Maintained at https://github.com/angularsen/UnitsNet.

using Xunit;

namespace UnitsNet.Tests.CustomCode
{
    public class SpecificVolumeTests : SpecificVolumeTestsBase
    {
        protected override bool SupportsSIUnitSystem => false;
        protected override double CubicMetersPerKilogramInOneCubicMeterPerKilogram => 1;

        protected override double CubicFeetPerPoundInOneCubicMeterPerKilogram => 16.01846353;

        protected override double MillicubicMetersPerKilogramInOneCubicMeterPerKilogram => 1e3;

        protected override double LitersPerGramInOneCubicMeterPerKilogram => 1.0;

        protected override double MillilitersPerGramInOneCubicMeterPerKilogram => 1.0e3;

        protected override double USGallonsPerPoundInOneCubicMeterPerKilogram => 119.8264273;

        [Fact]
        public static void SpecificVolumeTimesMassEqualsVolume()
        {
            Volume volume = SpecificVolume.FromCubicMetersPerKilogram(5) * Mass.FromKilograms(10);
            Assert.Equal(volume, Volume.FromCubicMeters(50));
        }

        [Fact]
        public static void ConstantOverSpecificVolumeEqualsDensity()
        {
            Density density = 5 / SpecificVolume.FromCubicMetersPerKilogram(20);
            Assert.Equal(density, Density.FromKilogramsPerCubicMeter(0.25));
        }
    }
}
