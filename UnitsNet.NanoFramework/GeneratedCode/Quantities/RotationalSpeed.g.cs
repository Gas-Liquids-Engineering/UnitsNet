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
    ///     Rotational speed (sometimes called speed of revolution) is the number of complete rotations, revolutions, cycles, or turns per time unit. Rotational speed is a cyclic frequency, measured in radians per second or in hertz in the SI System by scientists, or in revolutions per minute (rpm or min-1) or revolutions per second in everyday life. The symbol for rotational speed is ω (the Greek lowercase letter "omega").
    /// </summary>
    public struct  RotationalSpeed
    {
        /// <summary>
        ///     The numeric value this quantity was constructed with.
        /// </summary>
        private readonly double _value;

        /// <summary>
        ///     The unit this quantity was constructed with.
        /// </summary>
        private readonly RotationalSpeedUnit _unit;

        /// <summary>
        ///     The numeric value this quantity was constructed with.
        /// </summary>
        public double Value => _value;

        /// <inheritdoc />
        public RotationalSpeedUnit Unit => _unit;
        /// <summary>
        ///     Creates the quantity with the given numeric value and unit.
        /// </summary>
        /// <param name="value">The numeric value to construct this quantity with.</param>
        /// <param name="unit">The unit representation to construct this quantity with.</param>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public RotationalSpeed(double value, RotationalSpeedUnit unit)
        {
            _value = value;
            _unit = unit;
        }

        /// <summary>
        ///     The base unit of Duration, which is Second. All conversions go via this value.
        /// </summary>
        public static RotationalSpeedUnit BaseUnit { get; } = RotationalSpeedUnit.RadianPerSecond;

        /// <summary>
        /// Represents the largest possible value of Duration
        /// </summary>
        public static RotationalSpeed MaxValue { get; } = new RotationalSpeed(double.MaxValue, BaseUnit);

        /// <summary>
        /// Represents the smallest possible value of Duration
        /// </summary>
        public static RotationalSpeed MinValue { get; } = new RotationalSpeed(double.MinValue, BaseUnit);
        /// <summary>
        ///     Gets an instance of this quantity with a value of 0 in the base unit Second.
        /// </summary>
        public static RotationalSpeed Zero { get; } = new RotationalSpeed(0, BaseUnit);
        #region Conversion Properties

        /// <summary>
        ///     Get RotationalSpeed in CentiradiansPerMinute.
        /// </summary>
        public double CentiradiansPerMinute => As(RotationalSpeedUnit.CentiradianPerMinute);

        /// <summary>
        ///     Get RotationalSpeed in CentiradiansPerSecond.
        /// </summary>
        public double CentiradiansPerSecond => As(RotationalSpeedUnit.CentiradianPerSecond);

        /// <summary>
        ///     Get RotationalSpeed in DeciradiansPerMinute.
        /// </summary>
        public double DeciradiansPerMinute => As(RotationalSpeedUnit.DeciradianPerMinute);

        /// <summary>
        ///     Get RotationalSpeed in DeciradiansPerSecond.
        /// </summary>
        public double DeciradiansPerSecond => As(RotationalSpeedUnit.DeciradianPerSecond);

        /// <summary>
        ///     Get RotationalSpeed in DegreesPerHour.
        /// </summary>
        public double DegreesPerHour => As(RotationalSpeedUnit.DegreePerHour);

        /// <summary>
        ///     Get RotationalSpeed in DegreesPerMinute.
        /// </summary>
        public double DegreesPerMinute => As(RotationalSpeedUnit.DegreePerMinute);

        /// <summary>
        ///     Get RotationalSpeed in DegreesPerSecond.
        /// </summary>
        public double DegreesPerSecond => As(RotationalSpeedUnit.DegreePerSecond);

        /// <summary>
        ///     Get RotationalSpeed in MicrodegreesPerHour.
        /// </summary>
        public double MicrodegreesPerHour => As(RotationalSpeedUnit.MicrodegreePerHour);

        /// <summary>
        ///     Get RotationalSpeed in MicrodegreesPerSecond.
        /// </summary>
        public double MicrodegreesPerSecond => As(RotationalSpeedUnit.MicrodegreePerSecond);

        /// <summary>
        ///     Get RotationalSpeed in MicroradiansPerMinute.
        /// </summary>
        public double MicroradiansPerMinute => As(RotationalSpeedUnit.MicroradianPerMinute);

        /// <summary>
        ///     Get RotationalSpeed in MicroradiansPerSecond.
        /// </summary>
        public double MicroradiansPerSecond => As(RotationalSpeedUnit.MicroradianPerSecond);

        /// <summary>
        ///     Get RotationalSpeed in MillidegreesPerHour.
        /// </summary>
        public double MillidegreesPerHour => As(RotationalSpeedUnit.MillidegreePerHour);

        /// <summary>
        ///     Get RotationalSpeed in MillidegreesPerSecond.
        /// </summary>
        public double MillidegreesPerSecond => As(RotationalSpeedUnit.MillidegreePerSecond);

        /// <summary>
        ///     Get RotationalSpeed in MilliradiansPerMinute.
        /// </summary>
        public double MilliradiansPerMinute => As(RotationalSpeedUnit.MilliradianPerMinute);

        /// <summary>
        ///     Get RotationalSpeed in MilliradiansPerSecond.
        /// </summary>
        public double MilliradiansPerSecond => As(RotationalSpeedUnit.MilliradianPerSecond);

        /// <summary>
        ///     Get RotationalSpeed in NanodegreesPerHour.
        /// </summary>
        public double NanodegreesPerHour => As(RotationalSpeedUnit.NanodegreePerHour);

        /// <summary>
        ///     Get RotationalSpeed in NanodegreesPerSecond.
        /// </summary>
        public double NanodegreesPerSecond => As(RotationalSpeedUnit.NanodegreePerSecond);

        /// <summary>
        ///     Get RotationalSpeed in NanoradiansPerMinute.
        /// </summary>
        public double NanoradiansPerMinute => As(RotationalSpeedUnit.NanoradianPerMinute);

        /// <summary>
        ///     Get RotationalSpeed in NanoradiansPerSecond.
        /// </summary>
        public double NanoradiansPerSecond => As(RotationalSpeedUnit.NanoradianPerSecond);

        /// <summary>
        ///     Get RotationalSpeed in RadiansPerMinute.
        /// </summary>
        public double RadiansPerMinute => As(RotationalSpeedUnit.RadianPerMinute);

        /// <summary>
        ///     Get RotationalSpeed in RadiansPerSecond.
        /// </summary>
        public double RadiansPerSecond => As(RotationalSpeedUnit.RadianPerSecond);

        /// <summary>
        ///     Get RotationalSpeed in RevolutionsPerHour.
        /// </summary>
        public double RevolutionsPerHour => As(RotationalSpeedUnit.RevolutionPerHour);

        /// <summary>
        ///     Get RotationalSpeed in RevolutionsPerMinute.
        /// </summary>
        public double RevolutionsPerMinute => As(RotationalSpeedUnit.RevolutionPerMinute);

        /// <summary>
        ///     Get RotationalSpeed in RevolutionsPerSecond.
        /// </summary>
        public double RevolutionsPerSecond => As(RotationalSpeedUnit.RevolutionPerSecond);

        #endregion

        #region Static Factory Methods

        /// <summary>
        ///     Get RotationalSpeed from CentiradiansPerMinute.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static RotationalSpeed FromCentiradiansPerMinute(double centiradiansperminute) => new RotationalSpeed(centiradiansperminute, RotationalSpeedUnit.CentiradianPerMinute);

        /// <summary>
        ///     Get RotationalSpeed from CentiradiansPerSecond.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static RotationalSpeed FromCentiradiansPerSecond(double centiradianspersecond) => new RotationalSpeed(centiradianspersecond, RotationalSpeedUnit.CentiradianPerSecond);

        /// <summary>
        ///     Get RotationalSpeed from DeciradiansPerMinute.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static RotationalSpeed FromDeciradiansPerMinute(double deciradiansperminute) => new RotationalSpeed(deciradiansperminute, RotationalSpeedUnit.DeciradianPerMinute);

        /// <summary>
        ///     Get RotationalSpeed from DeciradiansPerSecond.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static RotationalSpeed FromDeciradiansPerSecond(double deciradianspersecond) => new RotationalSpeed(deciradianspersecond, RotationalSpeedUnit.DeciradianPerSecond);

        /// <summary>
        ///     Get RotationalSpeed from DegreesPerHour.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static RotationalSpeed FromDegreesPerHour(double degreesperhour) => new RotationalSpeed(degreesperhour, RotationalSpeedUnit.DegreePerHour);

        /// <summary>
        ///     Get RotationalSpeed from DegreesPerMinute.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static RotationalSpeed FromDegreesPerMinute(double degreesperminute) => new RotationalSpeed(degreesperminute, RotationalSpeedUnit.DegreePerMinute);

        /// <summary>
        ///     Get RotationalSpeed from DegreesPerSecond.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static RotationalSpeed FromDegreesPerSecond(double degreespersecond) => new RotationalSpeed(degreespersecond, RotationalSpeedUnit.DegreePerSecond);

        /// <summary>
        ///     Get RotationalSpeed from MicrodegreesPerHour.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static RotationalSpeed FromMicrodegreesPerHour(double microdegreesperhour) => new RotationalSpeed(microdegreesperhour, RotationalSpeedUnit.MicrodegreePerHour);

        /// <summary>
        ///     Get RotationalSpeed from MicrodegreesPerSecond.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static RotationalSpeed FromMicrodegreesPerSecond(double microdegreespersecond) => new RotationalSpeed(microdegreespersecond, RotationalSpeedUnit.MicrodegreePerSecond);

        /// <summary>
        ///     Get RotationalSpeed from MicroradiansPerMinute.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static RotationalSpeed FromMicroradiansPerMinute(double microradiansperminute) => new RotationalSpeed(microradiansperminute, RotationalSpeedUnit.MicroradianPerMinute);

        /// <summary>
        ///     Get RotationalSpeed from MicroradiansPerSecond.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static RotationalSpeed FromMicroradiansPerSecond(double microradianspersecond) => new RotationalSpeed(microradianspersecond, RotationalSpeedUnit.MicroradianPerSecond);

        /// <summary>
        ///     Get RotationalSpeed from MillidegreesPerHour.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static RotationalSpeed FromMillidegreesPerHour(double millidegreesperhour) => new RotationalSpeed(millidegreesperhour, RotationalSpeedUnit.MillidegreePerHour);

        /// <summary>
        ///     Get RotationalSpeed from MillidegreesPerSecond.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static RotationalSpeed FromMillidegreesPerSecond(double millidegreespersecond) => new RotationalSpeed(millidegreespersecond, RotationalSpeedUnit.MillidegreePerSecond);

        /// <summary>
        ///     Get RotationalSpeed from MilliradiansPerMinute.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static RotationalSpeed FromMilliradiansPerMinute(double milliradiansperminute) => new RotationalSpeed(milliradiansperminute, RotationalSpeedUnit.MilliradianPerMinute);

        /// <summary>
        ///     Get RotationalSpeed from MilliradiansPerSecond.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static RotationalSpeed FromMilliradiansPerSecond(double milliradianspersecond) => new RotationalSpeed(milliradianspersecond, RotationalSpeedUnit.MilliradianPerSecond);

        /// <summary>
        ///     Get RotationalSpeed from NanodegreesPerHour.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static RotationalSpeed FromNanodegreesPerHour(double nanodegreesperhour) => new RotationalSpeed(nanodegreesperhour, RotationalSpeedUnit.NanodegreePerHour);

        /// <summary>
        ///     Get RotationalSpeed from NanodegreesPerSecond.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static RotationalSpeed FromNanodegreesPerSecond(double nanodegreespersecond) => new RotationalSpeed(nanodegreespersecond, RotationalSpeedUnit.NanodegreePerSecond);

        /// <summary>
        ///     Get RotationalSpeed from NanoradiansPerMinute.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static RotationalSpeed FromNanoradiansPerMinute(double nanoradiansperminute) => new RotationalSpeed(nanoradiansperminute, RotationalSpeedUnit.NanoradianPerMinute);

        /// <summary>
        ///     Get RotationalSpeed from NanoradiansPerSecond.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static RotationalSpeed FromNanoradiansPerSecond(double nanoradianspersecond) => new RotationalSpeed(nanoradianspersecond, RotationalSpeedUnit.NanoradianPerSecond);

        /// <summary>
        ///     Get RotationalSpeed from RadiansPerMinute.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static RotationalSpeed FromRadiansPerMinute(double radiansperminute) => new RotationalSpeed(radiansperminute, RotationalSpeedUnit.RadianPerMinute);

        /// <summary>
        ///     Get RotationalSpeed from RadiansPerSecond.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static RotationalSpeed FromRadiansPerSecond(double radianspersecond) => new RotationalSpeed(radianspersecond, RotationalSpeedUnit.RadianPerSecond);

        /// <summary>
        ///     Get RotationalSpeed from RevolutionsPerHour.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static RotationalSpeed FromRevolutionsPerHour(double revolutionsperhour) => new RotationalSpeed(revolutionsperhour, RotationalSpeedUnit.RevolutionPerHour);

        /// <summary>
        ///     Get RotationalSpeed from RevolutionsPerMinute.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static RotationalSpeed FromRevolutionsPerMinute(double revolutionsperminute) => new RotationalSpeed(revolutionsperminute, RotationalSpeedUnit.RevolutionPerMinute);

        /// <summary>
        ///     Get RotationalSpeed from RevolutionsPerSecond.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static RotationalSpeed FromRevolutionsPerSecond(double revolutionspersecond) => new RotationalSpeed(revolutionspersecond, RotationalSpeedUnit.RevolutionPerSecond);


        /// <summary>
        ///     Dynamically convert from value and unit enum <see cref="RotationalSpeedUnit" /> to <see cref="RotationalSpeed" />.
        /// </summary>
        /// <param name="value">Value to convert from.</param>
        /// <param name="fromUnit">Unit to convert from.</param>
        /// <returns>RotationalSpeed unit value.</returns>
        public static RotationalSpeed From(double value, RotationalSpeedUnit fromUnit)
        {
            return new RotationalSpeed(value, fromUnit);
        }

        #endregion

        #region Conversion Methods

        /// <summary>
        ///     Convert to the unit representation <paramref name="unit" />.
        /// </summary>
        /// <returns>Value converted to the specified unit.</returns>
        public double As(RotationalSpeedUnit unit) => GetValueAs(unit);        

        /// <summary>
        ///     Converts this Duration to another Duration with the unit representation <paramref name="unit" />.
        /// </summary>
        /// <returns>A Duration with the specified unit.</returns>
        public RotationalSpeed ToUnit(RotationalSpeedUnit unit)
        {
                
            var convertedValue = GetValueAs(unit);
            return new RotationalSpeed(convertedValue, unit);
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
                case RotationalSpeedUnit.CentiradianPerMinute: return (_value*60) * 1e-2d;
                case RotationalSpeedUnit.CentiradianPerSecond: return (_value) * 1e-2d;
                case RotationalSpeedUnit.DeciradianPerMinute: return (_value*60) * 1e-1d;
                case RotationalSpeedUnit.DeciradianPerSecond: return (_value) * 1e-1d;
                case RotationalSpeedUnit.DegreePerHour: return (60*3.1415926535897931/180)*_value;
                case RotationalSpeedUnit.DegreePerMinute: return (3.1415926535897931/(180*60))*_value;
                case RotationalSpeedUnit.DegreePerSecond: return (3.1415926535897931/180)*_value;
                case RotationalSpeedUnit.MicrodegreePerHour: return ((60*3.1415926535897931/180)*_value) * 1e-6d;
                case RotationalSpeedUnit.MicrodegreePerSecond: return ((3.1415926535897931/180)*_value) * 1e-6d;
                case RotationalSpeedUnit.MicroradianPerMinute: return (_value*60) * 1e-6d;
                case RotationalSpeedUnit.MicroradianPerSecond: return (_value) * 1e-6d;
                case RotationalSpeedUnit.MillidegreePerHour: return ((60*3.1415926535897931/180)*_value) * 1e-3d;
                case RotationalSpeedUnit.MillidegreePerSecond: return ((3.1415926535897931/180)*_value) * 1e-3d;
                case RotationalSpeedUnit.MilliradianPerMinute: return (_value*60) * 1e-3d;
                case RotationalSpeedUnit.MilliradianPerSecond: return (_value) * 1e-3d;
                case RotationalSpeedUnit.NanodegreePerHour: return ((60*3.1415926535897931/180)*_value) * 1e-9d;
                case RotationalSpeedUnit.NanodegreePerSecond: return ((3.1415926535897931/180)*_value) * 1e-9d;
                case RotationalSpeedUnit.NanoradianPerMinute: return (_value*60) * 1e-9d;
                case RotationalSpeedUnit.NanoradianPerSecond: return (_value) * 1e-9d;
                case RotationalSpeedUnit.RadianPerMinute: return _value*60;
                case RotationalSpeedUnit.RadianPerSecond: return _value;
                case RotationalSpeedUnit.RevolutionPerHour: return (_value*6.2831853072)/3600;
                case RotationalSpeedUnit.RevolutionPerMinute: return (_value*6.2831853072)/60;
                case RotationalSpeedUnit.RevolutionPerSecond: return _value*6.2831853072;
                default:
                    throw new NotImplementedException($"Can not convert {Unit} to base units.");
            }
        }

        private double GetValueAs(RotationalSpeedUnit unit)
        {
            if(Unit == unit)
                return _value;

            var baseUnitValue = GetValueInBaseUnit();

            switch(unit)
            {
                case RotationalSpeedUnit.CentiradianPerMinute: return (baseUnitValue*60) / 1e-2d;
                case RotationalSpeedUnit.CentiradianPerSecond: return (baseUnitValue) / 1e-2d;
                case RotationalSpeedUnit.DeciradianPerMinute: return (baseUnitValue*60) / 1e-1d;
                case RotationalSpeedUnit.DeciradianPerSecond: return (baseUnitValue) / 1e-1d;
                case RotationalSpeedUnit.DegreePerHour: return (180/3.1415926535897931/60)*baseUnitValue;
                case RotationalSpeedUnit.DegreePerMinute: return (180*60/3.1415926535897931)*baseUnitValue;
                case RotationalSpeedUnit.DegreePerSecond: return (180/3.1415926535897931)*baseUnitValue;
                case RotationalSpeedUnit.MicrodegreePerHour: return ((180/3.1415926535897931/60)*baseUnitValue) / 1e-6d;
                case RotationalSpeedUnit.MicrodegreePerSecond: return ((180/3.1415926535897931)*baseUnitValue) / 1e-6d;
                case RotationalSpeedUnit.MicroradianPerMinute: return (baseUnitValue*60) / 1e-6d;
                case RotationalSpeedUnit.MicroradianPerSecond: return (baseUnitValue) / 1e-6d;
                case RotationalSpeedUnit.MillidegreePerHour: return ((180/3.1415926535897931/60)*baseUnitValue) / 1e-3d;
                case RotationalSpeedUnit.MillidegreePerSecond: return ((180/3.1415926535897931)*baseUnitValue) / 1e-3d;
                case RotationalSpeedUnit.MilliradianPerMinute: return (baseUnitValue*60) / 1e-3d;
                case RotationalSpeedUnit.MilliradianPerSecond: return (baseUnitValue) / 1e-3d;
                case RotationalSpeedUnit.NanodegreePerHour: return ((180/3.1415926535897931/60)*baseUnitValue) / 1e-9d;
                case RotationalSpeedUnit.NanodegreePerSecond: return ((180/3.1415926535897931)*baseUnitValue) / 1e-9d;
                case RotationalSpeedUnit.NanoradianPerMinute: return (baseUnitValue*60) / 1e-9d;
                case RotationalSpeedUnit.NanoradianPerSecond: return (baseUnitValue) / 1e-9d;
                case RotationalSpeedUnit.RadianPerMinute: return baseUnitValue*60;
                case RotationalSpeedUnit.RadianPerSecond: return baseUnitValue;
                case RotationalSpeedUnit.RevolutionPerHour: return (baseUnitValue/6.2831853072)*3600;
                case RotationalSpeedUnit.RevolutionPerMinute: return (baseUnitValue/6.2831853072)*60;
                case RotationalSpeedUnit.RevolutionPerSecond: return baseUnitValue/6.2831853072;
                default:
                    throw new NotImplementedException($"Can not convert {Unit} to {unit}.");
            }
        }

        #endregion

    }
}

