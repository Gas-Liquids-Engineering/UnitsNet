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
using UnitsNet.Units;

namespace UnitsNet
{
    /// <inheritdoc />
    /// <summary>
    ///     The amount of power in a volume.
    /// </summary>
    public struct  PowerDensity
    {
        /// <summary>
        ///     The numeric value this quantity was constructed with.
        /// </summary>
        private readonly double _value;

        /// <summary>
        ///     The unit this quantity was constructed with.
        /// </summary>
        private readonly PowerDensityUnit _unit;

        /// <summary>
        ///     The numeric value this quantity was constructed with.
        /// </summary>
        public double Value => _value;

        /// <inheritdoc />
        public PowerDensityUnit Unit => _unit;
        /// <summary>
        ///     Creates the quantity with the given numeric value and unit.
        /// </summary>
        /// <param name="value">The numeric value to construct this quantity with.</param>
        /// <param name="unit">The unit representation to construct this quantity with.</param>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public PowerDensity(double value, PowerDensityUnit unit)
        {
            _value = value;
            _unit = unit;
        }

        /// <summary>
        ///     The base unit of Duration, which is Second. All conversions go via this value.
        /// </summary>
        public static PowerDensityUnit BaseUnit { get; } = PowerDensityUnit.WattPerCubicMeter;

        /// <summary>
        /// Represents the largest possible value of Duration
        /// </summary>
        public static PowerDensity MaxValue { get; } = new PowerDensity(double.MaxValue, BaseUnit);

        /// <summary>
        /// Represents the smallest possible value of Duration
        /// </summary>
        public static PowerDensity MinValue { get; } = new PowerDensity(double.MinValue, BaseUnit);
        /// <summary>
        ///     Gets an instance of this quantity with a value of 0 in the base unit Second.
        /// </summary>
        public static PowerDensity Zero { get; } = new PowerDensity(0, BaseUnit);
        #region Conversion Properties

        /// <summary>
        ///     Get PowerDensity in DecawattsPerCubicFoot.
        /// </summary>
        public double DecawattsPerCubicFoot => As(PowerDensityUnit.DecawattPerCubicFoot);

        /// <summary>
        ///     Get PowerDensity in DecawattsPerCubicInch.
        /// </summary>
        public double DecawattsPerCubicInch => As(PowerDensityUnit.DecawattPerCubicInch);

        /// <summary>
        ///     Get PowerDensity in DecawattsPerCubicMeter.
        /// </summary>
        public double DecawattsPerCubicMeter => As(PowerDensityUnit.DecawattPerCubicMeter);

        /// <summary>
        ///     Get PowerDensity in DecawattsPerLiter.
        /// </summary>
        public double DecawattsPerLiter => As(PowerDensityUnit.DecawattPerLiter);

        /// <summary>
        ///     Get PowerDensity in DeciwattsPerCubicFoot.
        /// </summary>
        public double DeciwattsPerCubicFoot => As(PowerDensityUnit.DeciwattPerCubicFoot);

        /// <summary>
        ///     Get PowerDensity in DeciwattsPerCubicInch.
        /// </summary>
        public double DeciwattsPerCubicInch => As(PowerDensityUnit.DeciwattPerCubicInch);

        /// <summary>
        ///     Get PowerDensity in DeciwattsPerCubicMeter.
        /// </summary>
        public double DeciwattsPerCubicMeter => As(PowerDensityUnit.DeciwattPerCubicMeter);

        /// <summary>
        ///     Get PowerDensity in DeciwattsPerLiter.
        /// </summary>
        public double DeciwattsPerLiter => As(PowerDensityUnit.DeciwattPerLiter);

        /// <summary>
        ///     Get PowerDensity in GigawattsPerCubicFoot.
        /// </summary>
        public double GigawattsPerCubicFoot => As(PowerDensityUnit.GigawattPerCubicFoot);

        /// <summary>
        ///     Get PowerDensity in GigawattsPerCubicInch.
        /// </summary>
        public double GigawattsPerCubicInch => As(PowerDensityUnit.GigawattPerCubicInch);

        /// <summary>
        ///     Get PowerDensity in GigawattsPerCubicMeter.
        /// </summary>
        public double GigawattsPerCubicMeter => As(PowerDensityUnit.GigawattPerCubicMeter);

        /// <summary>
        ///     Get PowerDensity in GigawattsPerLiter.
        /// </summary>
        public double GigawattsPerLiter => As(PowerDensityUnit.GigawattPerLiter);

        /// <summary>
        ///     Get PowerDensity in KilowattsPerCubicFoot.
        /// </summary>
        public double KilowattsPerCubicFoot => As(PowerDensityUnit.KilowattPerCubicFoot);

        /// <summary>
        ///     Get PowerDensity in KilowattsPerCubicInch.
        /// </summary>
        public double KilowattsPerCubicInch => As(PowerDensityUnit.KilowattPerCubicInch);

        /// <summary>
        ///     Get PowerDensity in KilowattsPerCubicMeter.
        /// </summary>
        public double KilowattsPerCubicMeter => As(PowerDensityUnit.KilowattPerCubicMeter);

        /// <summary>
        ///     Get PowerDensity in KilowattsPerLiter.
        /// </summary>
        public double KilowattsPerLiter => As(PowerDensityUnit.KilowattPerLiter);

        /// <summary>
        ///     Get PowerDensity in MegawattsPerCubicFoot.
        /// </summary>
        public double MegawattsPerCubicFoot => As(PowerDensityUnit.MegawattPerCubicFoot);

        /// <summary>
        ///     Get PowerDensity in MegawattsPerCubicInch.
        /// </summary>
        public double MegawattsPerCubicInch => As(PowerDensityUnit.MegawattPerCubicInch);

        /// <summary>
        ///     Get PowerDensity in MegawattsPerCubicMeter.
        /// </summary>
        public double MegawattsPerCubicMeter => As(PowerDensityUnit.MegawattPerCubicMeter);

        /// <summary>
        ///     Get PowerDensity in MegawattsPerLiter.
        /// </summary>
        public double MegawattsPerLiter => As(PowerDensityUnit.MegawattPerLiter);

        /// <summary>
        ///     Get PowerDensity in MicrowattsPerCubicFoot.
        /// </summary>
        public double MicrowattsPerCubicFoot => As(PowerDensityUnit.MicrowattPerCubicFoot);

        /// <summary>
        ///     Get PowerDensity in MicrowattsPerCubicInch.
        /// </summary>
        public double MicrowattsPerCubicInch => As(PowerDensityUnit.MicrowattPerCubicInch);

        /// <summary>
        ///     Get PowerDensity in MicrowattsPerCubicMeter.
        /// </summary>
        public double MicrowattsPerCubicMeter => As(PowerDensityUnit.MicrowattPerCubicMeter);

        /// <summary>
        ///     Get PowerDensity in MicrowattsPerLiter.
        /// </summary>
        public double MicrowattsPerLiter => As(PowerDensityUnit.MicrowattPerLiter);

        /// <summary>
        ///     Get PowerDensity in MilliwattsPerCubicFoot.
        /// </summary>
        public double MilliwattsPerCubicFoot => As(PowerDensityUnit.MilliwattPerCubicFoot);

        /// <summary>
        ///     Get PowerDensity in MilliwattsPerCubicInch.
        /// </summary>
        public double MilliwattsPerCubicInch => As(PowerDensityUnit.MilliwattPerCubicInch);

        /// <summary>
        ///     Get PowerDensity in MilliwattsPerCubicMeter.
        /// </summary>
        public double MilliwattsPerCubicMeter => As(PowerDensityUnit.MilliwattPerCubicMeter);

        /// <summary>
        ///     Get PowerDensity in MilliwattsPerLiter.
        /// </summary>
        public double MilliwattsPerLiter => As(PowerDensityUnit.MilliwattPerLiter);

        /// <summary>
        ///     Get PowerDensity in NanowattsPerCubicFoot.
        /// </summary>
        public double NanowattsPerCubicFoot => As(PowerDensityUnit.NanowattPerCubicFoot);

        /// <summary>
        ///     Get PowerDensity in NanowattsPerCubicInch.
        /// </summary>
        public double NanowattsPerCubicInch => As(PowerDensityUnit.NanowattPerCubicInch);

        /// <summary>
        ///     Get PowerDensity in NanowattsPerCubicMeter.
        /// </summary>
        public double NanowattsPerCubicMeter => As(PowerDensityUnit.NanowattPerCubicMeter);

        /// <summary>
        ///     Get PowerDensity in NanowattsPerLiter.
        /// </summary>
        public double NanowattsPerLiter => As(PowerDensityUnit.NanowattPerLiter);

        /// <summary>
        ///     Get PowerDensity in PicowattsPerCubicFoot.
        /// </summary>
        public double PicowattsPerCubicFoot => As(PowerDensityUnit.PicowattPerCubicFoot);

        /// <summary>
        ///     Get PowerDensity in PicowattsPerCubicInch.
        /// </summary>
        public double PicowattsPerCubicInch => As(PowerDensityUnit.PicowattPerCubicInch);

        /// <summary>
        ///     Get PowerDensity in PicowattsPerCubicMeter.
        /// </summary>
        public double PicowattsPerCubicMeter => As(PowerDensityUnit.PicowattPerCubicMeter);

        /// <summary>
        ///     Get PowerDensity in PicowattsPerLiter.
        /// </summary>
        public double PicowattsPerLiter => As(PowerDensityUnit.PicowattPerLiter);

        /// <summary>
        ///     Get PowerDensity in TerawattsPerCubicFoot.
        /// </summary>
        public double TerawattsPerCubicFoot => As(PowerDensityUnit.TerawattPerCubicFoot);

        /// <summary>
        ///     Get PowerDensity in TerawattsPerCubicInch.
        /// </summary>
        public double TerawattsPerCubicInch => As(PowerDensityUnit.TerawattPerCubicInch);

        /// <summary>
        ///     Get PowerDensity in TerawattsPerCubicMeter.
        /// </summary>
        public double TerawattsPerCubicMeter => As(PowerDensityUnit.TerawattPerCubicMeter);

        /// <summary>
        ///     Get PowerDensity in TerawattsPerLiter.
        /// </summary>
        public double TerawattsPerLiter => As(PowerDensityUnit.TerawattPerLiter);

        /// <summary>
        ///     Get PowerDensity in WattsPerCubicFoot.
        /// </summary>
        public double WattsPerCubicFoot => As(PowerDensityUnit.WattPerCubicFoot);

        /// <summary>
        ///     Get PowerDensity in WattsPerCubicInch.
        /// </summary>
        public double WattsPerCubicInch => As(PowerDensityUnit.WattPerCubicInch);

        /// <summary>
        ///     Get PowerDensity in WattsPerCubicMeter.
        /// </summary>
        public double WattsPerCubicMeter => As(PowerDensityUnit.WattPerCubicMeter);

        /// <summary>
        ///     Get PowerDensity in WattsPerLiter.
        /// </summary>
        public double WattsPerLiter => As(PowerDensityUnit.WattPerLiter);

        #endregion

        #region Static Factory Methods

        /// <summary>
        ///     Get PowerDensity from DecawattsPerCubicFoot.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static PowerDensity FromDecawattsPerCubicFoot(double decawattspercubicfoot) => new PowerDensity(decawattspercubicfoot, PowerDensityUnit.DecawattPerCubicFoot);

        /// <summary>
        ///     Get PowerDensity from DecawattsPerCubicInch.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static PowerDensity FromDecawattsPerCubicInch(double decawattspercubicinch) => new PowerDensity(decawattspercubicinch, PowerDensityUnit.DecawattPerCubicInch);

        /// <summary>
        ///     Get PowerDensity from DecawattsPerCubicMeter.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static PowerDensity FromDecawattsPerCubicMeter(double decawattspercubicmeter) => new PowerDensity(decawattspercubicmeter, PowerDensityUnit.DecawattPerCubicMeter);

        /// <summary>
        ///     Get PowerDensity from DecawattsPerLiter.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static PowerDensity FromDecawattsPerLiter(double decawattsperliter) => new PowerDensity(decawattsperliter, PowerDensityUnit.DecawattPerLiter);

        /// <summary>
        ///     Get PowerDensity from DeciwattsPerCubicFoot.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static PowerDensity FromDeciwattsPerCubicFoot(double deciwattspercubicfoot) => new PowerDensity(deciwattspercubicfoot, PowerDensityUnit.DeciwattPerCubicFoot);

        /// <summary>
        ///     Get PowerDensity from DeciwattsPerCubicInch.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static PowerDensity FromDeciwattsPerCubicInch(double deciwattspercubicinch) => new PowerDensity(deciwattspercubicinch, PowerDensityUnit.DeciwattPerCubicInch);

        /// <summary>
        ///     Get PowerDensity from DeciwattsPerCubicMeter.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static PowerDensity FromDeciwattsPerCubicMeter(double deciwattspercubicmeter) => new PowerDensity(deciwattspercubicmeter, PowerDensityUnit.DeciwattPerCubicMeter);

        /// <summary>
        ///     Get PowerDensity from DeciwattsPerLiter.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static PowerDensity FromDeciwattsPerLiter(double deciwattsperliter) => new PowerDensity(deciwattsperliter, PowerDensityUnit.DeciwattPerLiter);

        /// <summary>
        ///     Get PowerDensity from GigawattsPerCubicFoot.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static PowerDensity FromGigawattsPerCubicFoot(double gigawattspercubicfoot) => new PowerDensity(gigawattspercubicfoot, PowerDensityUnit.GigawattPerCubicFoot);

        /// <summary>
        ///     Get PowerDensity from GigawattsPerCubicInch.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static PowerDensity FromGigawattsPerCubicInch(double gigawattspercubicinch) => new PowerDensity(gigawattspercubicinch, PowerDensityUnit.GigawattPerCubicInch);

        /// <summary>
        ///     Get PowerDensity from GigawattsPerCubicMeter.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static PowerDensity FromGigawattsPerCubicMeter(double gigawattspercubicmeter) => new PowerDensity(gigawattspercubicmeter, PowerDensityUnit.GigawattPerCubicMeter);

        /// <summary>
        ///     Get PowerDensity from GigawattsPerLiter.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static PowerDensity FromGigawattsPerLiter(double gigawattsperliter) => new PowerDensity(gigawattsperliter, PowerDensityUnit.GigawattPerLiter);

        /// <summary>
        ///     Get PowerDensity from KilowattsPerCubicFoot.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static PowerDensity FromKilowattsPerCubicFoot(double kilowattspercubicfoot) => new PowerDensity(kilowattspercubicfoot, PowerDensityUnit.KilowattPerCubicFoot);

        /// <summary>
        ///     Get PowerDensity from KilowattsPerCubicInch.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static PowerDensity FromKilowattsPerCubicInch(double kilowattspercubicinch) => new PowerDensity(kilowattspercubicinch, PowerDensityUnit.KilowattPerCubicInch);

        /// <summary>
        ///     Get PowerDensity from KilowattsPerCubicMeter.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static PowerDensity FromKilowattsPerCubicMeter(double kilowattspercubicmeter) => new PowerDensity(kilowattspercubicmeter, PowerDensityUnit.KilowattPerCubicMeter);

        /// <summary>
        ///     Get PowerDensity from KilowattsPerLiter.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static PowerDensity FromKilowattsPerLiter(double kilowattsperliter) => new PowerDensity(kilowattsperliter, PowerDensityUnit.KilowattPerLiter);

        /// <summary>
        ///     Get PowerDensity from MegawattsPerCubicFoot.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static PowerDensity FromMegawattsPerCubicFoot(double megawattspercubicfoot) => new PowerDensity(megawattspercubicfoot, PowerDensityUnit.MegawattPerCubicFoot);

        /// <summary>
        ///     Get PowerDensity from MegawattsPerCubicInch.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static PowerDensity FromMegawattsPerCubicInch(double megawattspercubicinch) => new PowerDensity(megawattspercubicinch, PowerDensityUnit.MegawattPerCubicInch);

        /// <summary>
        ///     Get PowerDensity from MegawattsPerCubicMeter.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static PowerDensity FromMegawattsPerCubicMeter(double megawattspercubicmeter) => new PowerDensity(megawattspercubicmeter, PowerDensityUnit.MegawattPerCubicMeter);

        /// <summary>
        ///     Get PowerDensity from MegawattsPerLiter.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static PowerDensity FromMegawattsPerLiter(double megawattsperliter) => new PowerDensity(megawattsperliter, PowerDensityUnit.MegawattPerLiter);

        /// <summary>
        ///     Get PowerDensity from MicrowattsPerCubicFoot.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static PowerDensity FromMicrowattsPerCubicFoot(double microwattspercubicfoot) => new PowerDensity(microwattspercubicfoot, PowerDensityUnit.MicrowattPerCubicFoot);

        /// <summary>
        ///     Get PowerDensity from MicrowattsPerCubicInch.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static PowerDensity FromMicrowattsPerCubicInch(double microwattspercubicinch) => new PowerDensity(microwattspercubicinch, PowerDensityUnit.MicrowattPerCubicInch);

        /// <summary>
        ///     Get PowerDensity from MicrowattsPerCubicMeter.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static PowerDensity FromMicrowattsPerCubicMeter(double microwattspercubicmeter) => new PowerDensity(microwattspercubicmeter, PowerDensityUnit.MicrowattPerCubicMeter);

        /// <summary>
        ///     Get PowerDensity from MicrowattsPerLiter.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static PowerDensity FromMicrowattsPerLiter(double microwattsperliter) => new PowerDensity(microwattsperliter, PowerDensityUnit.MicrowattPerLiter);

        /// <summary>
        ///     Get PowerDensity from MilliwattsPerCubicFoot.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static PowerDensity FromMilliwattsPerCubicFoot(double milliwattspercubicfoot) => new PowerDensity(milliwattspercubicfoot, PowerDensityUnit.MilliwattPerCubicFoot);

        /// <summary>
        ///     Get PowerDensity from MilliwattsPerCubicInch.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static PowerDensity FromMilliwattsPerCubicInch(double milliwattspercubicinch) => new PowerDensity(milliwattspercubicinch, PowerDensityUnit.MilliwattPerCubicInch);

        /// <summary>
        ///     Get PowerDensity from MilliwattsPerCubicMeter.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static PowerDensity FromMilliwattsPerCubicMeter(double milliwattspercubicmeter) => new PowerDensity(milliwattspercubicmeter, PowerDensityUnit.MilliwattPerCubicMeter);

        /// <summary>
        ///     Get PowerDensity from MilliwattsPerLiter.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static PowerDensity FromMilliwattsPerLiter(double milliwattsperliter) => new PowerDensity(milliwattsperliter, PowerDensityUnit.MilliwattPerLiter);

        /// <summary>
        ///     Get PowerDensity from NanowattsPerCubicFoot.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static PowerDensity FromNanowattsPerCubicFoot(double nanowattspercubicfoot) => new PowerDensity(nanowattspercubicfoot, PowerDensityUnit.NanowattPerCubicFoot);

        /// <summary>
        ///     Get PowerDensity from NanowattsPerCubicInch.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static PowerDensity FromNanowattsPerCubicInch(double nanowattspercubicinch) => new PowerDensity(nanowattspercubicinch, PowerDensityUnit.NanowattPerCubicInch);

        /// <summary>
        ///     Get PowerDensity from NanowattsPerCubicMeter.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static PowerDensity FromNanowattsPerCubicMeter(double nanowattspercubicmeter) => new PowerDensity(nanowattspercubicmeter, PowerDensityUnit.NanowattPerCubicMeter);

        /// <summary>
        ///     Get PowerDensity from NanowattsPerLiter.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static PowerDensity FromNanowattsPerLiter(double nanowattsperliter) => new PowerDensity(nanowattsperliter, PowerDensityUnit.NanowattPerLiter);

        /// <summary>
        ///     Get PowerDensity from PicowattsPerCubicFoot.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static PowerDensity FromPicowattsPerCubicFoot(double picowattspercubicfoot) => new PowerDensity(picowattspercubicfoot, PowerDensityUnit.PicowattPerCubicFoot);

        /// <summary>
        ///     Get PowerDensity from PicowattsPerCubicInch.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static PowerDensity FromPicowattsPerCubicInch(double picowattspercubicinch) => new PowerDensity(picowattspercubicinch, PowerDensityUnit.PicowattPerCubicInch);

        /// <summary>
        ///     Get PowerDensity from PicowattsPerCubicMeter.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static PowerDensity FromPicowattsPerCubicMeter(double picowattspercubicmeter) => new PowerDensity(picowattspercubicmeter, PowerDensityUnit.PicowattPerCubicMeter);

        /// <summary>
        ///     Get PowerDensity from PicowattsPerLiter.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static PowerDensity FromPicowattsPerLiter(double picowattsperliter) => new PowerDensity(picowattsperliter, PowerDensityUnit.PicowattPerLiter);

        /// <summary>
        ///     Get PowerDensity from TerawattsPerCubicFoot.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static PowerDensity FromTerawattsPerCubicFoot(double terawattspercubicfoot) => new PowerDensity(terawattspercubicfoot, PowerDensityUnit.TerawattPerCubicFoot);

        /// <summary>
        ///     Get PowerDensity from TerawattsPerCubicInch.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static PowerDensity FromTerawattsPerCubicInch(double terawattspercubicinch) => new PowerDensity(terawattspercubicinch, PowerDensityUnit.TerawattPerCubicInch);

        /// <summary>
        ///     Get PowerDensity from TerawattsPerCubicMeter.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static PowerDensity FromTerawattsPerCubicMeter(double terawattspercubicmeter) => new PowerDensity(terawattspercubicmeter, PowerDensityUnit.TerawattPerCubicMeter);

        /// <summary>
        ///     Get PowerDensity from TerawattsPerLiter.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static PowerDensity FromTerawattsPerLiter(double terawattsperliter) => new PowerDensity(terawattsperliter, PowerDensityUnit.TerawattPerLiter);

        /// <summary>
        ///     Get PowerDensity from WattsPerCubicFoot.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static PowerDensity FromWattsPerCubicFoot(double wattspercubicfoot) => new PowerDensity(wattspercubicfoot, PowerDensityUnit.WattPerCubicFoot);

        /// <summary>
        ///     Get PowerDensity from WattsPerCubicInch.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static PowerDensity FromWattsPerCubicInch(double wattspercubicinch) => new PowerDensity(wattspercubicinch, PowerDensityUnit.WattPerCubicInch);

        /// <summary>
        ///     Get PowerDensity from WattsPerCubicMeter.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static PowerDensity FromWattsPerCubicMeter(double wattspercubicmeter) => new PowerDensity(wattspercubicmeter, PowerDensityUnit.WattPerCubicMeter);

        /// <summary>
        ///     Get PowerDensity from WattsPerLiter.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static PowerDensity FromWattsPerLiter(double wattsperliter) => new PowerDensity(wattsperliter, PowerDensityUnit.WattPerLiter);


        /// <summary>
        ///     Dynamically convert from value and unit enum <see cref="PowerDensityUnit" /> to <see cref="PowerDensity" />.
        /// </summary>
        /// <param name="value">Value to convert from.</param>
        /// <param name="fromUnit">Unit to convert from.</param>
        /// <returns>PowerDensity unit value.</returns>
        public static PowerDensity From(double value, PowerDensityUnit fromUnit)
        {
            return new PowerDensity(value, fromUnit);
        }

        #endregion

        #region Conversion Methods

        /// <summary>
        ///     Convert to the unit representation <paramref name="unit" />.
        /// </summary>
        /// <returns>Value converted to the specified unit.</returns>
        public double As(PowerDensityUnit unit) => GetValueAs(unit);        

        /// <summary>
        ///     Converts this Duration to another Duration with the unit representation <paramref name="unit" />.
        /// </summary>
        /// <returns>A Duration with the specified unit.</returns>
        public PowerDensity ToUnit(PowerDensityUnit unit)
        {
                
            var convertedValue = GetValueAs(unit);
            return new PowerDensity(convertedValue, unit);
        }


        /// <summary>
        ///     Converts the current value + unit to the base unit.
        ///     This is typically the first step in converting from one unit to another.
        /// </summary>
        /// <returns>The value in the base unit representation.</returns>
        private double GetValueInBaseUnit()
        {
            switch(Unit)
            {
                case PowerDensityUnit.DecawattPerCubicFoot: return (_value*(1/0.3048*1/0.3048*1/0.3048)) * 1e1d;
                case PowerDensityUnit.DecawattPerCubicInch: return (_value*(1/0.0254*1/0.0254*1/0.0254)) * 1e1d;
                case PowerDensityUnit.DecawattPerCubicMeter: return (_value) * 1e1d;
                case PowerDensityUnit.DecawattPerLiter: return (_value*1.0e3) * 1e1d;
                case PowerDensityUnit.DeciwattPerCubicFoot: return (_value*(1/0.3048*1/0.3048*1/0.3048)) * 1e-1d;
                case PowerDensityUnit.DeciwattPerCubicInch: return (_value*(1/0.0254*1/0.0254*1/0.0254)) * 1e-1d;
                case PowerDensityUnit.DeciwattPerCubicMeter: return (_value) * 1e-1d;
                case PowerDensityUnit.DeciwattPerLiter: return (_value*1.0e3) * 1e-1d;
                case PowerDensityUnit.GigawattPerCubicFoot: return (_value*(1/0.3048*1/0.3048*1/0.3048)) * 1e9d;
                case PowerDensityUnit.GigawattPerCubicInch: return (_value*(1/0.0254*1/0.0254*1/0.0254)) * 1e9d;
                case PowerDensityUnit.GigawattPerCubicMeter: return (_value) * 1e9d;
                case PowerDensityUnit.GigawattPerLiter: return (_value*1.0e3) * 1e9d;
                case PowerDensityUnit.KilowattPerCubicFoot: return (_value*(1/0.3048*1/0.3048*1/0.3048)) * 1e3d;
                case PowerDensityUnit.KilowattPerCubicInch: return (_value*(1/0.0254*1/0.0254*1/0.0254)) * 1e3d;
                case PowerDensityUnit.KilowattPerCubicMeter: return (_value) * 1e3d;
                case PowerDensityUnit.KilowattPerLiter: return (_value*1.0e3) * 1e3d;
                case PowerDensityUnit.MegawattPerCubicFoot: return (_value*(1/0.3048*1/0.3048*1/0.3048)) * 1e6d;
                case PowerDensityUnit.MegawattPerCubicInch: return (_value*(1/0.0254*1/0.0254*1/0.0254)) * 1e6d;
                case PowerDensityUnit.MegawattPerCubicMeter: return (_value) * 1e6d;
                case PowerDensityUnit.MegawattPerLiter: return (_value*1.0e3) * 1e6d;
                case PowerDensityUnit.MicrowattPerCubicFoot: return (_value*(1/0.3048*1/0.3048*1/0.3048)) * 1e-6d;
                case PowerDensityUnit.MicrowattPerCubicInch: return (_value*(1/0.0254*1/0.0254*1/0.0254)) * 1e-6d;
                case PowerDensityUnit.MicrowattPerCubicMeter: return (_value) * 1e-6d;
                case PowerDensityUnit.MicrowattPerLiter: return (_value*1.0e3) * 1e-6d;
                case PowerDensityUnit.MilliwattPerCubicFoot: return (_value*(1/0.3048*1/0.3048*1/0.3048)) * 1e-3d;
                case PowerDensityUnit.MilliwattPerCubicInch: return (_value*(1/0.0254*1/0.0254*1/0.0254)) * 1e-3d;
                case PowerDensityUnit.MilliwattPerCubicMeter: return (_value) * 1e-3d;
                case PowerDensityUnit.MilliwattPerLiter: return (_value*1.0e3) * 1e-3d;
                case PowerDensityUnit.NanowattPerCubicFoot: return (_value*(1/0.3048*1/0.3048*1/0.3048)) * 1e-9d;
                case PowerDensityUnit.NanowattPerCubicInch: return (_value*(1/0.0254*1/0.0254*1/0.0254)) * 1e-9d;
                case PowerDensityUnit.NanowattPerCubicMeter: return (_value) * 1e-9d;
                case PowerDensityUnit.NanowattPerLiter: return (_value*1.0e3) * 1e-9d;
                case PowerDensityUnit.PicowattPerCubicFoot: return (_value*(1/0.3048*1/0.3048*1/0.3048)) * 1e-12d;
                case PowerDensityUnit.PicowattPerCubicInch: return (_value*(1/0.0254*1/0.0254*1/0.0254)) * 1e-12d;
                case PowerDensityUnit.PicowattPerCubicMeter: return (_value) * 1e-12d;
                case PowerDensityUnit.PicowattPerLiter: return (_value*1.0e3) * 1e-12d;
                case PowerDensityUnit.TerawattPerCubicFoot: return (_value*(1/0.3048*1/0.3048*1/0.3048)) * 1e12d;
                case PowerDensityUnit.TerawattPerCubicInch: return (_value*(1/0.0254*1/0.0254*1/0.0254)) * 1e12d;
                case PowerDensityUnit.TerawattPerCubicMeter: return (_value) * 1e12d;
                case PowerDensityUnit.TerawattPerLiter: return (_value*1.0e3) * 1e12d;
                case PowerDensityUnit.WattPerCubicFoot: return _value*(1/0.3048*1/0.3048*1/0.3048);
                case PowerDensityUnit.WattPerCubicInch: return _value*(1/0.0254*1/0.0254*1/0.0254);
                case PowerDensityUnit.WattPerCubicMeter: return _value;
                case PowerDensityUnit.WattPerLiter: return _value*1.0e3;
                default:
                    throw new NotImplementedException($"Can not convert {Unit} to base units.");
            }
        }

        private double GetValueAs(PowerDensityUnit unit)
        {
            if(Unit == unit)
                return _value;

            var baseUnitValue = GetValueInBaseUnit();

            switch(unit)
            {
                case PowerDensityUnit.DecawattPerCubicFoot: return (baseUnitValue/(1/0.3048*1/0.3048*1/0.3048)) / 1e1d;
                case PowerDensityUnit.DecawattPerCubicInch: return (baseUnitValue/(1/0.0254*1/0.0254*1/0.0254)) / 1e1d;
                case PowerDensityUnit.DecawattPerCubicMeter: return (baseUnitValue) / 1e1d;
                case PowerDensityUnit.DecawattPerLiter: return (baseUnitValue/1.0e3) / 1e1d;
                case PowerDensityUnit.DeciwattPerCubicFoot: return (baseUnitValue/(1/0.3048*1/0.3048*1/0.3048)) / 1e-1d;
                case PowerDensityUnit.DeciwattPerCubicInch: return (baseUnitValue/(1/0.0254*1/0.0254*1/0.0254)) / 1e-1d;
                case PowerDensityUnit.DeciwattPerCubicMeter: return (baseUnitValue) / 1e-1d;
                case PowerDensityUnit.DeciwattPerLiter: return (baseUnitValue/1.0e3) / 1e-1d;
                case PowerDensityUnit.GigawattPerCubicFoot: return (baseUnitValue/(1/0.3048*1/0.3048*1/0.3048)) / 1e9d;
                case PowerDensityUnit.GigawattPerCubicInch: return (baseUnitValue/(1/0.0254*1/0.0254*1/0.0254)) / 1e9d;
                case PowerDensityUnit.GigawattPerCubicMeter: return (baseUnitValue) / 1e9d;
                case PowerDensityUnit.GigawattPerLiter: return (baseUnitValue/1.0e3) / 1e9d;
                case PowerDensityUnit.KilowattPerCubicFoot: return (baseUnitValue/(1/0.3048*1/0.3048*1/0.3048)) / 1e3d;
                case PowerDensityUnit.KilowattPerCubicInch: return (baseUnitValue/(1/0.0254*1/0.0254*1/0.0254)) / 1e3d;
                case PowerDensityUnit.KilowattPerCubicMeter: return (baseUnitValue) / 1e3d;
                case PowerDensityUnit.KilowattPerLiter: return (baseUnitValue/1.0e3) / 1e3d;
                case PowerDensityUnit.MegawattPerCubicFoot: return (baseUnitValue/(1/0.3048*1/0.3048*1/0.3048)) / 1e6d;
                case PowerDensityUnit.MegawattPerCubicInch: return (baseUnitValue/(1/0.0254*1/0.0254*1/0.0254)) / 1e6d;
                case PowerDensityUnit.MegawattPerCubicMeter: return (baseUnitValue) / 1e6d;
                case PowerDensityUnit.MegawattPerLiter: return (baseUnitValue/1.0e3) / 1e6d;
                case PowerDensityUnit.MicrowattPerCubicFoot: return (baseUnitValue/(1/0.3048*1/0.3048*1/0.3048)) / 1e-6d;
                case PowerDensityUnit.MicrowattPerCubicInch: return (baseUnitValue/(1/0.0254*1/0.0254*1/0.0254)) / 1e-6d;
                case PowerDensityUnit.MicrowattPerCubicMeter: return (baseUnitValue) / 1e-6d;
                case PowerDensityUnit.MicrowattPerLiter: return (baseUnitValue/1.0e3) / 1e-6d;
                case PowerDensityUnit.MilliwattPerCubicFoot: return (baseUnitValue/(1/0.3048*1/0.3048*1/0.3048)) / 1e-3d;
                case PowerDensityUnit.MilliwattPerCubicInch: return (baseUnitValue/(1/0.0254*1/0.0254*1/0.0254)) / 1e-3d;
                case PowerDensityUnit.MilliwattPerCubicMeter: return (baseUnitValue) / 1e-3d;
                case PowerDensityUnit.MilliwattPerLiter: return (baseUnitValue/1.0e3) / 1e-3d;
                case PowerDensityUnit.NanowattPerCubicFoot: return (baseUnitValue/(1/0.3048*1/0.3048*1/0.3048)) / 1e-9d;
                case PowerDensityUnit.NanowattPerCubicInch: return (baseUnitValue/(1/0.0254*1/0.0254*1/0.0254)) / 1e-9d;
                case PowerDensityUnit.NanowattPerCubicMeter: return (baseUnitValue) / 1e-9d;
                case PowerDensityUnit.NanowattPerLiter: return (baseUnitValue/1.0e3) / 1e-9d;
                case PowerDensityUnit.PicowattPerCubicFoot: return (baseUnitValue/(1/0.3048*1/0.3048*1/0.3048)) / 1e-12d;
                case PowerDensityUnit.PicowattPerCubicInch: return (baseUnitValue/(1/0.0254*1/0.0254*1/0.0254)) / 1e-12d;
                case PowerDensityUnit.PicowattPerCubicMeter: return (baseUnitValue) / 1e-12d;
                case PowerDensityUnit.PicowattPerLiter: return (baseUnitValue/1.0e3) / 1e-12d;
                case PowerDensityUnit.TerawattPerCubicFoot: return (baseUnitValue/(1/0.3048*1/0.3048*1/0.3048)) / 1e12d;
                case PowerDensityUnit.TerawattPerCubicInch: return (baseUnitValue/(1/0.0254*1/0.0254*1/0.0254)) / 1e12d;
                case PowerDensityUnit.TerawattPerCubicMeter: return (baseUnitValue) / 1e12d;
                case PowerDensityUnit.TerawattPerLiter: return (baseUnitValue/1.0e3) / 1e12d;
                case PowerDensityUnit.WattPerCubicFoot: return baseUnitValue/(1/0.3048*1/0.3048*1/0.3048);
                case PowerDensityUnit.WattPerCubicInch: return baseUnitValue/(1/0.0254*1/0.0254*1/0.0254);
                case PowerDensityUnit.WattPerCubicMeter: return baseUnitValue;
                case PowerDensityUnit.WattPerLiter: return baseUnitValue/1.0e3;
                default:
                    throw new NotImplementedException($"Can not convert {Unit} to {unit}.");
            }
        }

        #endregion

    }
}

