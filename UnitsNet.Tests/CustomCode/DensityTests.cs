﻿// Licensed under MIT No Attribution, see LICENSE file at the root.
// Copyright 2013 Andreas Gullberg Larsen (andreas.larsen84@gmail.com). Maintained at https://github.com/angularsen/UnitsNet.

using Xunit;

namespace UnitsNet.Tests.CustomCode
{
    public class DensityTests : DensityTestsBase
    {
        protected override bool SupportsSIUnitSystem => false;

        protected override double MilligramsPerCubicMeterInOneKilogramPerCubicMeter => 1e6;

        protected override double GramsPerCubicCentimeterInOneKilogramPerCubicMeter => 1e-3;

        protected override double GramsPerCubicMeterInOneKilogramPerCubicMeter => 1e3;

        protected override double GramsPerCubicMillimeterInOneKilogramPerCubicMeter => 1e-6;

        protected override double KilogramsPerCubicCentimeterInOneKilogramPerCubicMeter => 1e-6;

        protected override double KilogramsPerCubicMeterInOneKilogramPerCubicMeter => 1;

        protected override double KilogramsPerCubicMillimeterInOneKilogramPerCubicMeter => 1e-9;

        protected override double KilopoundsPerCubicFootInOneKilogramPerCubicMeter => 6.242796e-5;

        protected override double KilopoundsPerCubicInchInOneKilogramPerCubicMeter => 3.6127292e-8;

        protected override double PoundsPerCubicFootInOneKilogramPerCubicMeter => 6.242796e-2;

        protected override double PoundsPerCubicInchInOneKilogramPerCubicMeter => 3.61272923e-5;

        protected override double PoundsPerUSGallonInOneKilogramPerCubicMeter => 8.3454045e-3;

        protected override double PoundsPerImperialGallonInOneKilogramPerCubicMeter => 1.002241e-2;

        protected override double TonnesPerCubicCentimeterInOneKilogramPerCubicMeter => 1e-9;

        protected override double TonnesPerCubicMeterInOneKilogramPerCubicMeter => 1e-3;

        protected override double TonnesPerCubicMillimeterInOneKilogramPerCubicMeter => 1e-12;

        protected override double SlugsPerCubicFootInOneKilogramPerCubicMeter => 0.00194032;

        protected override double CentigramsPerDeciliterInOneKilogramPerCubicMeter => 1e1;

        protected override double CentigramsPerLiterInOneKilogramPerCubicMeter => 1e2;

        protected override double CentigramsPerMilliliterInOneKilogramPerCubicMeter => 1e-1;

        protected override double DecigramsPerDeciliterInOneKilogramPerCubicMeter => 1;

        protected override double DecigramsPerLiterInOneKilogramPerCubicMeter => 1e1;

        protected override double DecigramsPerMilliliterInOneKilogramPerCubicMeter => 1e-2;

        protected override double GramsPerDeciliterInOneKilogramPerCubicMeter => 1e-1;

        protected override double GramsPerLiterInOneKilogramPerCubicMeter => 1;

        protected override double GramsPerMilliliterInOneKilogramPerCubicMeter => 1e-3;

        protected override double MicrogramsPerDeciliterInOneKilogramPerCubicMeter => 1e5;

        protected override double MicrogramsPerLiterInOneKilogramPerCubicMeter => 1e6;

        protected override double MicrogramsPerMilliliterInOneKilogramPerCubicMeter => 1e3;

        protected override double MilligramsPerDeciliterInOneKilogramPerCubicMeter => 1e2;

        protected override double MilligramsPerLiterInOneKilogramPerCubicMeter => 1e3;

        protected override double MilligramsPerMilliliterInOneKilogramPerCubicMeter => 1;

        protected override double NanogramsPerDeciliterInOneKilogramPerCubicMeter => 1e8;

        protected override double NanogramsPerLiterInOneKilogramPerCubicMeter => 1e9;

        protected override double NanogramsPerMilliliterInOneKilogramPerCubicMeter => 1e6;

        protected override double PicogramsPerDeciliterInOneKilogramPerCubicMeter => 1e11;

        protected override double PicogramsPerLiterInOneKilogramPerCubicMeter => 1e12;

        protected override double PicogramsPerMilliliterInOneKilogramPerCubicMeter => 1e9;

        protected override double MicrogramsPerCubicMeterInOneKilogramPerCubicMeter => 1e9;

        protected override double KilogramsPerLiterInOneKilogramPerCubicMeter => 1e-3;

        [Fact]
        public static void DensityTimesVolumeEqualsMass()
        {
            Mass mass = Density.FromKilogramsPerCubicMeter(2) * Volume.FromCubicMeters(3);
            Assert.Equal(mass, Mass.FromKilograms(6));
        }

        [Fact]
        public static void VolumeTimesDensityEqualsMass()
        {
            Mass mass = Volume.FromCubicMeters(3) * Density.FromKilogramsPerCubicMeter(2);
            Assert.Equal(mass, Mass.FromKilograms(6));
        }

        [Fact]
        public static void DensityTimesKinematicViscosityEqualsDynamicViscosity()
        {
            DynamicViscosity dynamicViscosity = Density.FromKilogramsPerCubicMeter(2) * KinematicViscosity.FromSquareMetersPerSecond(10);
            Assert.Equal(dynamicViscosity, DynamicViscosity.FromNewtonSecondsPerMeterSquared(20));
        }

        [Fact]
        public void DensityTimesSpeedEqualsMassFlux()
        {
            MassFlux massFlux = Density.FromKilogramsPerCubicMeter(20) * Speed.FromMetersPerSecond(2);
            Assert.Equal(massFlux, MassFlux.FromKilogramsPerSecondPerSquareMeter(40));
        }

        [Fact]
        public void DensityTimesAccelerationEqualsSpecificWeight()
        {
            SpecificWeight specificWeight = Density.FromKilogramsPerCubicMeter(10) * Acceleration.FromMetersPerSecondSquared(2);
            Assert.Equal(SpecificWeight.FromNewtonsPerCubicMeter(20), specificWeight);
        }

        [Fact]
        public void DensityTimesAreaEqualsLinearDensity()
        {
            LinearDensity linearDensity = Density.FromGramsPerCubicCentimeter(10) * Area.FromSquareCentimeters(2);
            Assert.Equal(LinearDensity.FromGramsPerCentimeter(20), linearDensity);
        }
    }
}
