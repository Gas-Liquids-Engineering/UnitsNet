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
    ///     Volume, typically of fluid, that a container can hold within a unit of length.
    /// </summary>
    public struct  VolumePerLength
    {
        /// <summary>
        ///     The numeric value this quantity was constructed with.
        /// </summary>
        private readonly double _value;

        /// <summary>
        ///     The unit this quantity was constructed with.
        /// </summary>
        private readonly VolumePerLengthUnit _unit;

        /// <summary>
        ///     The numeric value this quantity was constructed with.
        /// </summary>
        public double Value => _value;

        /// <inheritdoc />
        public VolumePerLengthUnit Unit => _unit;
        /// <summary>
        ///     Creates the quantity with the given numeric value and unit.
        /// </summary>
        /// <param name="value">The numeric value to construct this quantity with.</param>
        /// <param name="unit">The unit representation to construct this quantity with.</param>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public VolumePerLength(double value, VolumePerLengthUnit unit)
        {
            _value = value;
            _unit = unit;
        }

        /// <summary>
        ///     The base unit of Duration, which is Second. All conversions go via this value.
        /// </summary>
        public static VolumePerLengthUnit BaseUnit { get; } = VolumePerLengthUnit.CubicMeterPerMeter;

        /// <summary>
        /// Represents the largest possible value of Duration
        /// </summary>
        public static VolumePerLength MaxValue { get; } = new VolumePerLength(double.MaxValue, BaseUnit);

        /// <summary>
        /// Represents the smallest possible value of Duration
        /// </summary>
        public static VolumePerLength MinValue { get; } = new VolumePerLength(double.MinValue, BaseUnit);
        /// <summary>
        ///     Gets an instance of this quantity with a value of 0 in the base unit Second.
        /// </summary>
        public static VolumePerLength Zero { get; } = new VolumePerLength(0, BaseUnit);
        #region Conversion Properties

        /// <summary>
        ///     Get VolumePerLength in CubicMetersPerMeter.
        /// </summary>
        public double CubicMetersPerMeter => As(VolumePerLengthUnit.CubicMeterPerMeter);

        /// <summary>
        ///     Get VolumePerLength in CubicYardsPerFoot.
        /// </summary>
        public double CubicYardsPerFoot => As(VolumePerLengthUnit.CubicYardPerFoot);

        /// <summary>
        ///     Get VolumePerLength in CubicYardsPerUsSurveyFoot.
        /// </summary>
        public double CubicYardsPerUsSurveyFoot => As(VolumePerLengthUnit.CubicYardPerUsSurveyFoot);

        /// <summary>
        ///     Get VolumePerLength in LitersPerKilometer.
        /// </summary>
        public double LitersPerKilometer => As(VolumePerLengthUnit.LiterPerKilometer);

        /// <summary>
        ///     Get VolumePerLength in LitersPerMeter.
        /// </summary>
        public double LitersPerMeter => As(VolumePerLengthUnit.LiterPerMeter);

        /// <summary>
        ///     Get VolumePerLength in LitersPerMillimeter.
        /// </summary>
        public double LitersPerMillimeter => As(VolumePerLengthUnit.LiterPerMillimeter);

        /// <summary>
        ///     Get VolumePerLength in OilBarrelsPerFoot.
        /// </summary>
        public double OilBarrelsPerFoot => As(VolumePerLengthUnit.OilBarrelPerFoot);

        #endregion

        #region Static Factory Methods

        /// <summary>
        ///     Get VolumePerLength from CubicMetersPerMeter.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static VolumePerLength FromCubicMetersPerMeter(double cubicmeterspermeter) => new VolumePerLength(cubicmeterspermeter, VolumePerLengthUnit.CubicMeterPerMeter);

        /// <summary>
        ///     Get VolumePerLength from CubicYardsPerFoot.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static VolumePerLength FromCubicYardsPerFoot(double cubicyardsperfoot) => new VolumePerLength(cubicyardsperfoot, VolumePerLengthUnit.CubicYardPerFoot);

        /// <summary>
        ///     Get VolumePerLength from CubicYardsPerUsSurveyFoot.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static VolumePerLength FromCubicYardsPerUsSurveyFoot(double cubicyardsperussurveyfoot) => new VolumePerLength(cubicyardsperussurveyfoot, VolumePerLengthUnit.CubicYardPerUsSurveyFoot);

        /// <summary>
        ///     Get VolumePerLength from LitersPerKilometer.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static VolumePerLength FromLitersPerKilometer(double litersperkilometer) => new VolumePerLength(litersperkilometer, VolumePerLengthUnit.LiterPerKilometer);

        /// <summary>
        ///     Get VolumePerLength from LitersPerMeter.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static VolumePerLength FromLitersPerMeter(double literspermeter) => new VolumePerLength(literspermeter, VolumePerLengthUnit.LiterPerMeter);

        /// <summary>
        ///     Get VolumePerLength from LitersPerMillimeter.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static VolumePerLength FromLitersPerMillimeter(double literspermillimeter) => new VolumePerLength(literspermillimeter, VolumePerLengthUnit.LiterPerMillimeter);

        /// <summary>
        ///     Get VolumePerLength from OilBarrelsPerFoot.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static VolumePerLength FromOilBarrelsPerFoot(double oilbarrelsperfoot) => new VolumePerLength(oilbarrelsperfoot, VolumePerLengthUnit.OilBarrelPerFoot);


        /// <summary>
        ///     Dynamically convert from value and unit enum <see cref="VolumePerLengthUnit" /> to <see cref="VolumePerLength" />.
        /// </summary>
        /// <param name="value">Value to convert from.</param>
        /// <param name="fromUnit">Unit to convert from.</param>
        /// <returns>VolumePerLength unit value.</returns>
        public static VolumePerLength From(double value, VolumePerLengthUnit fromUnit)
        {
            return new VolumePerLength(value, fromUnit);
        }

        #endregion

        #region Conversion Methods

        /// <summary>
        ///     Convert to the unit representation <paramref name="unit" />.
        /// </summary>
        /// <returns>Value converted to the specified unit.</returns>
        public double As(VolumePerLengthUnit unit) => GetValueAs(unit);        

        /// <summary>
        ///     Converts this Duration to another Duration with the unit representation <paramref name="unit" />.
        /// </summary>
        /// <returns>A Duration with the specified unit.</returns>
        public VolumePerLength ToUnit(VolumePerLengthUnit unit)
        {
                
            var convertedValue = GetValueAs(unit);
            return new VolumePerLength(convertedValue, unit);
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
                case VolumePerLengthUnit.CubicMeterPerMeter: return _value;
                case VolumePerLengthUnit.CubicYardPerFoot: return _value*(3*3*3*0.3048*0.3048);
                case VolumePerLengthUnit.CubicYardPerUsSurveyFoot: return _value*(3*3*3*0.3048*0.3048*0.3048*3937/1200);
                case VolumePerLengthUnit.LiterPerKilometer: return _value/1e6;
                case VolumePerLengthUnit.LiterPerMeter: return _value/1000;
                case VolumePerLengthUnit.LiterPerMillimeter: return _value;
                case VolumePerLengthUnit.OilBarrelPerFoot: return _value*(42*231*0.0254*0.0254*0.0254*1/0.3048);
                default:
                    throw new NotImplementedException($"Can not convert {Unit} to base units.");
            }
        }

        private double GetValueAs(VolumePerLengthUnit unit)
        {
            if(Unit == unit)
                return _value;

            var baseUnitValue = GetValueInBaseUnit();

            switch(unit)
            {
                case VolumePerLengthUnit.CubicMeterPerMeter: return baseUnitValue;
                case VolumePerLengthUnit.CubicYardPerFoot: return baseUnitValue/(3*3*3*0.3048*0.3048);
                case VolumePerLengthUnit.CubicYardPerUsSurveyFoot: return baseUnitValue/(3*3*3*0.3048*0.3048*0.3048*3937/1200);
                case VolumePerLengthUnit.LiterPerKilometer: return baseUnitValue*1e6;
                case VolumePerLengthUnit.LiterPerMeter: return baseUnitValue*1000;
                case VolumePerLengthUnit.LiterPerMillimeter: return baseUnitValue;
                case VolumePerLengthUnit.OilBarrelPerFoot: return baseUnitValue/(42*231*0.0254*0.0254*0.0254*1/0.3048);
                default:
                    throw new NotImplementedException($"Can not convert {Unit} to {unit}.");
            }
        }

        #endregion

    }
}

