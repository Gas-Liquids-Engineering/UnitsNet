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
    ///     The viscosity of a fluid is a measure of its resistance to gradual deformation by shear stress or tensile stress.
    /// </summary>
    /// <remarks>
    ///     http://en.wikipedia.org/wiki/Viscosity
    /// </remarks>
    public struct  KinematicViscosity
    {
        /// <summary>
        ///     The numeric value this quantity was constructed with.
        /// </summary>
        private readonly double _value;

        /// <summary>
        ///     The unit this quantity was constructed with.
        /// </summary>
        private readonly KinematicViscosityUnit _unit;

        /// <summary>
        ///     The numeric value this quantity was constructed with.
        /// </summary>
        public double Value => _value;

        /// <inheritdoc />
        public KinematicViscosityUnit Unit => _unit;
        /// <summary>
        ///     Creates the quantity with the given numeric value and unit.
        /// </summary>
        /// <param name="value">The numeric value to construct this quantity with.</param>
        /// <param name="unit">The unit representation to construct this quantity with.</param>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public KinematicViscosity(double value, KinematicViscosityUnit unit)
        {
            _value = value;
            _unit = unit;
        }

        /// <summary>
        ///     The base unit of Duration, which is Second. All conversions go via this value.
        /// </summary>
        public static KinematicViscosityUnit BaseUnit { get; } = KinematicViscosityUnit.SquareMeterPerSecond;

        /// <summary>
        /// Represents the largest possible value of Duration
        /// </summary>
        public static KinematicViscosity MaxValue { get; } = new KinematicViscosity(double.MaxValue, BaseUnit);

        /// <summary>
        /// Represents the smallest possible value of Duration
        /// </summary>
        public static KinematicViscosity MinValue { get; } = new KinematicViscosity(double.MinValue, BaseUnit);
        /// <summary>
        ///     Gets an instance of this quantity with a value of 0 in the base unit Second.
        /// </summary>
        public static KinematicViscosity Zero { get; } = new KinematicViscosity(0, BaseUnit);
        #region Conversion Properties

        /// <summary>
        ///     Get KinematicViscosity in Centistokes.
        /// </summary>
        public double Centistokes => As(KinematicViscosityUnit.Centistokes);

        /// <summary>
        ///     Get KinematicViscosity in Decistokes.
        /// </summary>
        public double Decistokes => As(KinematicViscosityUnit.Decistokes);

        /// <summary>
        ///     Get KinematicViscosity in Kilostokes.
        /// </summary>
        public double Kilostokes => As(KinematicViscosityUnit.Kilostokes);

        /// <summary>
        ///     Get KinematicViscosity in Microstokes.
        /// </summary>
        public double Microstokes => As(KinematicViscosityUnit.Microstokes);

        /// <summary>
        ///     Get KinematicViscosity in Millistokes.
        /// </summary>
        public double Millistokes => As(KinematicViscosityUnit.Millistokes);

        /// <summary>
        ///     Get KinematicViscosity in Nanostokes.
        /// </summary>
        public double Nanostokes => As(KinematicViscosityUnit.Nanostokes);

        /// <summary>
        ///     Get KinematicViscosity in SquareFeetPerHour.
        /// </summary>
        public double SquareFeetPerHour => As(KinematicViscosityUnit.SquareFootPerHour);

        /// <summary>
        ///     Get KinematicViscosity in SquareFeetPerSecond.
        /// </summary>
        public double SquareFeetPerSecond => As(KinematicViscosityUnit.SquareFootPerSecond);

        /// <summary>
        ///     Get KinematicViscosity in SquareInchesPerSecond.
        /// </summary>
        public double SquareInchesPerSecond => As(KinematicViscosityUnit.SquareInchPerSecond);

        /// <summary>
        ///     Get KinematicViscosity in SquareMetersPerHour.
        /// </summary>
        public double SquareMetersPerHour => As(KinematicViscosityUnit.SquareMeterPerHour);

        /// <summary>
        ///     Get KinematicViscosity in SquareMetersPerSecond.
        /// </summary>
        public double SquareMetersPerSecond => As(KinematicViscosityUnit.SquareMeterPerSecond);

        /// <summary>
        ///     Get KinematicViscosity in Stokes.
        /// </summary>
        public double Stokes => As(KinematicViscosityUnit.Stokes);

        #endregion

        #region Static Factory Methods

        /// <summary>
        ///     Get KinematicViscosity from Centistokes.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static KinematicViscosity FromCentistokes(double centistokes) => new KinematicViscosity(centistokes, KinematicViscosityUnit.Centistokes);

        /// <summary>
        ///     Get KinematicViscosity from Decistokes.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static KinematicViscosity FromDecistokes(double decistokes) => new KinematicViscosity(decistokes, KinematicViscosityUnit.Decistokes);

        /// <summary>
        ///     Get KinematicViscosity from Kilostokes.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static KinematicViscosity FromKilostokes(double kilostokes) => new KinematicViscosity(kilostokes, KinematicViscosityUnit.Kilostokes);

        /// <summary>
        ///     Get KinematicViscosity from Microstokes.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static KinematicViscosity FromMicrostokes(double microstokes) => new KinematicViscosity(microstokes, KinematicViscosityUnit.Microstokes);

        /// <summary>
        ///     Get KinematicViscosity from Millistokes.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static KinematicViscosity FromMillistokes(double millistokes) => new KinematicViscosity(millistokes, KinematicViscosityUnit.Millistokes);

        /// <summary>
        ///     Get KinematicViscosity from Nanostokes.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static KinematicViscosity FromNanostokes(double nanostokes) => new KinematicViscosity(nanostokes, KinematicViscosityUnit.Nanostokes);

        /// <summary>
        ///     Get KinematicViscosity from SquareFeetPerHour.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static KinematicViscosity FromSquareFeetPerHour(double squarefeetperhour) => new KinematicViscosity(squarefeetperhour, KinematicViscosityUnit.SquareFootPerHour);

        /// <summary>
        ///     Get KinematicViscosity from SquareFeetPerSecond.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static KinematicViscosity FromSquareFeetPerSecond(double squarefeetpersecond) => new KinematicViscosity(squarefeetpersecond, KinematicViscosityUnit.SquareFootPerSecond);

        /// <summary>
        ///     Get KinematicViscosity from SquareInchesPerSecond.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static KinematicViscosity FromSquareInchesPerSecond(double squareinchespersecond) => new KinematicViscosity(squareinchespersecond, KinematicViscosityUnit.SquareInchPerSecond);

        /// <summary>
        ///     Get KinematicViscosity from SquareMetersPerHour.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static KinematicViscosity FromSquareMetersPerHour(double squaremetersperhour) => new KinematicViscosity(squaremetersperhour, KinematicViscosityUnit.SquareMeterPerHour);

        /// <summary>
        ///     Get KinematicViscosity from SquareMetersPerSecond.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static KinematicViscosity FromSquareMetersPerSecond(double squaremeterspersecond) => new KinematicViscosity(squaremeterspersecond, KinematicViscosityUnit.SquareMeterPerSecond);

        /// <summary>
        ///     Get KinematicViscosity from Stokes.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static KinematicViscosity FromStokes(double stokes) => new KinematicViscosity(stokes, KinematicViscosityUnit.Stokes);


        /// <summary>
        ///     Dynamically convert from value and unit enum <see cref="KinematicViscosityUnit" /> to <see cref="KinematicViscosity" />.
        /// </summary>
        /// <param name="value">Value to convert from.</param>
        /// <param name="fromUnit">Unit to convert from.</param>
        /// <returns>KinematicViscosity unit value.</returns>
        public static KinematicViscosity From(double value, KinematicViscosityUnit fromUnit)
        {
            return new KinematicViscosity(value, fromUnit);
        }

        #endregion

        #region Conversion Methods

        /// <summary>
        ///     Convert to the unit representation <paramref name="unit" />.
        /// </summary>
        /// <returns>Value converted to the specified unit.</returns>
        public double As(KinematicViscosityUnit unit) => GetValueAs(unit);        

        /// <summary>
        ///     Converts this Duration to another Duration with the unit representation <paramref name="unit" />.
        /// </summary>
        /// <returns>A Duration with the specified unit.</returns>
        public KinematicViscosity ToUnit(KinematicViscosityUnit unit)
        {
                
            var convertedValue = GetValueAs(unit);
            return new KinematicViscosity(convertedValue, unit);
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
                case KinematicViscosityUnit.Centistokes: return (_value/1e4) * 1e-2d;
                case KinematicViscosityUnit.Decistokes: return (_value/1e4) * 1e-1d;
                case KinematicViscosityUnit.Kilostokes: return (_value/1e4) * 1e3d;
                case KinematicViscosityUnit.Microstokes: return (_value/1e4) * 1e-6d;
                case KinematicViscosityUnit.Millistokes: return (_value/1e4) * 1e-3d;
                case KinematicViscosityUnit.Nanostokes: return (_value/1e4) * 1e-9d;
                case KinematicViscosityUnit.SquareFootPerHour: return _value*(0.3048*0.3048*1/3600);
                case KinematicViscosityUnit.SquareFootPerSecond: return _value*(0.3048*0.3048);
                case KinematicViscosityUnit.SquareInchPerSecond: return _value*(0.0254*0.0254);
                case KinematicViscosityUnit.SquareMeterPerHour: return _value*(1.0/3600.0);
                case KinematicViscosityUnit.SquareMeterPerSecond: return _value;
                case KinematicViscosityUnit.Stokes: return _value/1e4;
                default:
                    throw new NotImplementedException($"Can not convert {Unit} to base units.");
            }
        }

        private double GetValueAs(KinematicViscosityUnit unit)
        {
            if(Unit == unit)
                return _value;

            var baseUnitValue = GetValueInBaseUnit();

            switch(unit)
            {
                case KinematicViscosityUnit.Centistokes: return (baseUnitValue*1e4) / 1e-2d;
                case KinematicViscosityUnit.Decistokes: return (baseUnitValue*1e4) / 1e-1d;
                case KinematicViscosityUnit.Kilostokes: return (baseUnitValue*1e4) / 1e3d;
                case KinematicViscosityUnit.Microstokes: return (baseUnitValue*1e4) / 1e-6d;
                case KinematicViscosityUnit.Millistokes: return (baseUnitValue*1e4) / 1e-3d;
                case KinematicViscosityUnit.Nanostokes: return (baseUnitValue*1e4) / 1e-9d;
                case KinematicViscosityUnit.SquareFootPerHour: return baseUnitValue/(0.3048*0.3048*1/3600);
                case KinematicViscosityUnit.SquareFootPerSecond: return baseUnitValue/(0.3048*0.3048);
                case KinematicViscosityUnit.SquareInchPerSecond: return baseUnitValue/(0.0254*0.0254);
                case KinematicViscosityUnit.SquareMeterPerHour: return baseUnitValue/(1.0/3600.0);
                case KinematicViscosityUnit.SquareMeterPerSecond: return baseUnitValue;
                case KinematicViscosityUnit.Stokes: return baseUnitValue*1e4;
                default:
                    throw new NotImplementedException($"Can not convert {Unit} to {unit}.");
            }
        }

        #endregion

    }
}

