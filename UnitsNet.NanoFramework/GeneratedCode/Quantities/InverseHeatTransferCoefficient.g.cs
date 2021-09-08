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
    ///     The (inverse) heat transfer coefficient or film coefficient, or film effectiveness, in thermodynamics and in mechanics is the proportionality constant between the heat flux and the thermodynamic driving force for the flow of heat (i.e., the temperature difference, ΔT)
    /// </summary>
    public struct  InverseHeatTransferCoefficient
    {
        /// <summary>
        ///     The numeric value this quantity was constructed with.
        /// </summary>
        private readonly double _value;

        /// <summary>
        ///     The unit this quantity was constructed with.
        /// </summary>
        private readonly InverseHeatTransferCoefficientUnit _unit;

        /// <summary>
        ///     The numeric value this quantity was constructed with.
        /// </summary>
        public double Value => _value;

        /// <inheritdoc />
        public InverseHeatTransferCoefficientUnit Unit => _unit;
        /// <summary>
        ///     Creates the quantity with the given numeric value and unit.
        /// </summary>
        /// <param name="value">The numeric value to construct this quantity with.</param>
        /// <param name="unit">The unit representation to construct this quantity with.</param>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public InverseHeatTransferCoefficient(double value, InverseHeatTransferCoefficientUnit unit)
        {
            _value = value;
            _unit = unit;
        }

        /// <summary>
        ///     The base unit of Duration, which is Second. All conversions go via this value.
        /// </summary>
        public static InverseHeatTransferCoefficientUnit BaseUnit { get; } = InverseHeatTransferCoefficientUnit.SquareMeterKelvinPerWatt;

        /// <summary>
        /// Represents the largest possible value of Duration
        /// </summary>
        public static InverseHeatTransferCoefficient MaxValue { get; } = new InverseHeatTransferCoefficient(double.MaxValue, BaseUnit);

        /// <summary>
        /// Represents the smallest possible value of Duration
        /// </summary>
        public static InverseHeatTransferCoefficient MinValue { get; } = new InverseHeatTransferCoefficient(double.MinValue, BaseUnit);
        /// <summary>
        ///     Gets an instance of this quantity with a value of 0 in the base unit Second.
        /// </summary>
        public static InverseHeatTransferCoefficient Zero { get; } = new InverseHeatTransferCoefficient(0, BaseUnit);
        #region Conversion Properties

        /// <summary>
        ///     Get InverseHeatTransferCoefficient in SquareCentimeterKelvinsPerWatt.
        /// </summary>
        public double SquareCentimeterKelvinsPerWatt => As(InverseHeatTransferCoefficientUnit.SquareCentimeterKelvinPerWatt);

        /// <summary>
        ///     Get InverseHeatTransferCoefficient in SquareCentimeterSecondKelvinsPerCalorie.
        /// </summary>
        public double SquareCentimeterSecondKelvinsPerCalorie => As(InverseHeatTransferCoefficientUnit.SquareCentimeterSecondKelvinPerCalorie);

        /// <summary>
        ///     Get InverseHeatTransferCoefficient in SquareFootHourFahrenheitsPerBtu.
        /// </summary>
        public double SquareFootHourFahrenheitsPerBtu => As(InverseHeatTransferCoefficientUnit.SquareFootHourFahrenheitPerBtu);

        /// <summary>
        ///     Get InverseHeatTransferCoefficient in SquareMetersCelsiusPerWatt.
        /// </summary>
        public double SquareMetersCelsiusPerWatt => As(InverseHeatTransferCoefficientUnit.SquareMeterCelsiusPerWatt);

        /// <summary>
        ///     Get InverseHeatTransferCoefficient in SquareMeterHourKelvinsPerKilocalorie.
        /// </summary>
        public double SquareMeterHourKelvinsPerKilocalorie => As(InverseHeatTransferCoefficientUnit.SquareMeterHourKelvinPerKilocalorie);

        /// <summary>
        ///     Get InverseHeatTransferCoefficient in SquareMetersKelvinPerKilowatt.
        /// </summary>
        public double SquareMetersKelvinPerKilowatt => As(InverseHeatTransferCoefficientUnit.SquareMeterKelvinPerKilowatt);

        /// <summary>
        ///     Get InverseHeatTransferCoefficient in SquareMetersKelvinPerWatt.
        /// </summary>
        public double SquareMetersKelvinPerWatt => As(InverseHeatTransferCoefficientUnit.SquareMeterKelvinPerWatt);

        #endregion

        #region Static Factory Methods

        /// <summary>
        ///     Get InverseHeatTransferCoefficient from SquareCentimeterKelvinsPerWatt.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static InverseHeatTransferCoefficient FromSquareCentimeterKelvinsPerWatt(double squarecentimeterkelvinsperwatt) => new InverseHeatTransferCoefficient(squarecentimeterkelvinsperwatt, InverseHeatTransferCoefficientUnit.SquareCentimeterKelvinPerWatt);

        /// <summary>
        ///     Get InverseHeatTransferCoefficient from SquareCentimeterSecondKelvinsPerCalorie.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static InverseHeatTransferCoefficient FromSquareCentimeterSecondKelvinsPerCalorie(double squarecentimetersecondkelvinspercalorie) => new InverseHeatTransferCoefficient(squarecentimetersecondkelvinspercalorie, InverseHeatTransferCoefficientUnit.SquareCentimeterSecondKelvinPerCalorie);

        /// <summary>
        ///     Get InverseHeatTransferCoefficient from SquareFootHourFahrenheitsPerBtu.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static InverseHeatTransferCoefficient FromSquareFootHourFahrenheitsPerBtu(double squarefoothourfahrenheitsperbtu) => new InverseHeatTransferCoefficient(squarefoothourfahrenheitsperbtu, InverseHeatTransferCoefficientUnit.SquareFootHourFahrenheitPerBtu);

        /// <summary>
        ///     Get InverseHeatTransferCoefficient from SquareMetersCelsiusPerWatt.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static InverseHeatTransferCoefficient FromSquareMetersCelsiusPerWatt(double squaremeterscelsiusperwatt) => new InverseHeatTransferCoefficient(squaremeterscelsiusperwatt, InverseHeatTransferCoefficientUnit.SquareMeterCelsiusPerWatt);

        /// <summary>
        ///     Get InverseHeatTransferCoefficient from SquareMeterHourKelvinsPerKilocalorie.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static InverseHeatTransferCoefficient FromSquareMeterHourKelvinsPerKilocalorie(double squaremeterhourkelvinsperkilocalorie) => new InverseHeatTransferCoefficient(squaremeterhourkelvinsperkilocalorie, InverseHeatTransferCoefficientUnit.SquareMeterHourKelvinPerKilocalorie);

        /// <summary>
        ///     Get InverseHeatTransferCoefficient from SquareMetersKelvinPerKilowatt.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static InverseHeatTransferCoefficient FromSquareMetersKelvinPerKilowatt(double squaremeterskelvinperkilowatt) => new InverseHeatTransferCoefficient(squaremeterskelvinperkilowatt, InverseHeatTransferCoefficientUnit.SquareMeterKelvinPerKilowatt);

        /// <summary>
        ///     Get InverseHeatTransferCoefficient from SquareMetersKelvinPerWatt.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static InverseHeatTransferCoefficient FromSquareMetersKelvinPerWatt(double squaremeterskelvinperwatt) => new InverseHeatTransferCoefficient(squaremeterskelvinperwatt, InverseHeatTransferCoefficientUnit.SquareMeterKelvinPerWatt);


        /// <summary>
        ///     Dynamically convert from value and unit enum <see cref="InverseHeatTransferCoefficientUnit" /> to <see cref="InverseHeatTransferCoefficient" />.
        /// </summary>
        /// <param name="value">Value to convert from.</param>
        /// <param name="fromUnit">Unit to convert from.</param>
        /// <returns>InverseHeatTransferCoefficient unit value.</returns>
        public static InverseHeatTransferCoefficient From(double value, InverseHeatTransferCoefficientUnit fromUnit)
        {
            return new InverseHeatTransferCoefficient(value, fromUnit);
        }

        #endregion

        #region Conversion Methods

        /// <summary>
        ///     Convert to the unit representation <paramref name="unit" />.
        /// </summary>
        /// <returns>Value converted to the specified unit.</returns>
        public double As(InverseHeatTransferCoefficientUnit unit) => GetValueAs(unit);        

        /// <summary>
        ///     Converts this Duration to another Duration with the unit representation <paramref name="unit" />.
        /// </summary>
        /// <returns>A Duration with the specified unit.</returns>
        public InverseHeatTransferCoefficient ToUnit(InverseHeatTransferCoefficientUnit unit)
        {
                
            var convertedValue = GetValueAs(unit);
            return new InverseHeatTransferCoefficient(convertedValue, unit);
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
                case InverseHeatTransferCoefficientUnit.SquareCentimeterKelvinPerWatt: return _value/10000;
                case InverseHeatTransferCoefficientUnit.SquareCentimeterSecondKelvinPerCalorie: return _value*(1.0/4184.0);
                case InverseHeatTransferCoefficientUnit.SquareFootHourFahrenheitPerBtu: return _value*(0.3048*0.3048*5/9*3600/1055);
                case InverseHeatTransferCoefficientUnit.SquareMeterCelsiusPerWatt: return _value;
                case InverseHeatTransferCoefficientUnit.SquareMeterHourKelvinPerKilocalorie: return _value * (3600.0/4184.0);
                case InverseHeatTransferCoefficientUnit.SquareMeterKelvinPerKilowatt: return _value*1000;
                case InverseHeatTransferCoefficientUnit.SquareMeterKelvinPerWatt: return _value;
                default:
                    throw new NotImplementedException($"Can not convert {Unit} to base units.");
            }
        }

        private double GetValueAs(InverseHeatTransferCoefficientUnit unit)
        {
            if(Unit == unit)
                return _value;

            var baseUnitValue = GetValueInBaseUnit();

            switch(unit)
            {
                case InverseHeatTransferCoefficientUnit.SquareCentimeterKelvinPerWatt: return baseUnitValue*10000;
                case InverseHeatTransferCoefficientUnit.SquareCentimeterSecondKelvinPerCalorie: return baseUnitValue/(1.0/4184.0);
                case InverseHeatTransferCoefficientUnit.SquareFootHourFahrenheitPerBtu: return baseUnitValue/(0.3048*0.3048*5/9*3600/1055);
                case InverseHeatTransferCoefficientUnit.SquareMeterCelsiusPerWatt: return baseUnitValue;
                case InverseHeatTransferCoefficientUnit.SquareMeterHourKelvinPerKilocalorie: return baseUnitValue / (3600.0/4184.0);
                case InverseHeatTransferCoefficientUnit.SquareMeterKelvinPerKilowatt: return baseUnitValue/1000;
                case InverseHeatTransferCoefficientUnit.SquareMeterKelvinPerWatt: return baseUnitValue;
                default:
                    throw new NotImplementedException($"Can not convert {Unit} to {unit}.");
            }
        }

        #endregion

    }
}

