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
    ///     Enthalpy is a measure.
    /// </summary>
    public struct  EnthalpyMolar
    {
        /// <summary>
        ///     The numeric value this quantity was constructed with.
        /// </summary>
        private readonly double _value;

        /// <summary>
        ///     The unit this quantity was constructed with.
        /// </summary>
        private readonly EnthalpyMolarUnit _unit;

        /// <summary>
        ///     The numeric value this quantity was constructed with.
        /// </summary>
        public double Value => _value;

        /// <inheritdoc />
        public EnthalpyMolarUnit Unit => _unit;
        /// <summary>
        ///     Creates the quantity with the given numeric value and unit.
        /// </summary>
        /// <param name="value">The numeric value to construct this quantity with.</param>
        /// <param name="unit">The unit representation to construct this quantity with.</param>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public EnthalpyMolar(double value, EnthalpyMolarUnit unit)
        {
            _value = value;
            _unit = unit;
        }

        /// <summary>
        ///     The base unit of Duration, which is Second. All conversions go via this value.
        /// </summary>
        public static EnthalpyMolarUnit BaseUnit { get; } = EnthalpyMolarUnit.JoulePerMole;

        /// <summary>
        /// Represents the largest possible value of Duration
        /// </summary>
        public static EnthalpyMolar MaxValue { get; } = new EnthalpyMolar(double.MaxValue, BaseUnit);

        /// <summary>
        /// Represents the smallest possible value of Duration
        /// </summary>
        public static EnthalpyMolar MinValue { get; } = new EnthalpyMolar(double.MinValue, BaseUnit);
        /// <summary>
        ///     Gets an instance of this quantity with a value of 0 in the base unit Second.
        /// </summary>
        public static EnthalpyMolar Zero { get; } = new EnthalpyMolar(0, BaseUnit);
        #region Conversion Properties

        /// <summary>
        ///     Get EnthalpyMolar in BTUsPerPoundMole.
        /// </summary>
        public double BTUsPerPoundMole => As(EnthalpyMolarUnit.BTUPerPoundMole);

        /// <summary>
        ///     Get EnthalpyMolar in CaloriesPerMole.
        /// </summary>
        public double CaloriesPerMole => As(EnthalpyMolarUnit.CaloriesPerMole);

        /// <summary>
        ///     Get EnthalpyMolar in JoulesPerKilomole.
        /// </summary>
        public double JoulesPerKilomole => As(EnthalpyMolarUnit.JoulePerKilomole);

        /// <summary>
        ///     Get EnthalpyMolar in JoulesPerMole.
        /// </summary>
        public double JoulesPerMole => As(EnthalpyMolarUnit.JoulePerMole);

        /// <summary>
        ///     Get EnthalpyMolar in KilojoulesPerKilomole.
        /// </summary>
        public double KilojoulesPerKilomole => As(EnthalpyMolarUnit.KilojoulePerKilomole);

        /// <summary>
        ///     Get EnthalpyMolar in KilojoulesPerMole.
        /// </summary>
        public double KilojoulesPerMole => As(EnthalpyMolarUnit.KilojoulePerMole);

        /// <summary>
        ///     Get EnthalpyMolar in MegajoulesPerMole.
        /// </summary>
        public double MegajoulesPerMole => As(EnthalpyMolarUnit.MegajoulePerMole);

        #endregion

        #region Static Factory Methods

        /// <summary>
        ///     Get EnthalpyMolar from BTUsPerPoundMole.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static EnthalpyMolar FromBTUsPerPoundMole(double btusperpoundmole) => new EnthalpyMolar(btusperpoundmole, EnthalpyMolarUnit.BTUPerPoundMole);

        /// <summary>
        ///     Get EnthalpyMolar from CaloriesPerMole.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static EnthalpyMolar FromCaloriesPerMole(double caloriespermole) => new EnthalpyMolar(caloriespermole, EnthalpyMolarUnit.CaloriesPerMole);

        /// <summary>
        ///     Get EnthalpyMolar from JoulesPerKilomole.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static EnthalpyMolar FromJoulesPerKilomole(double joulesperkilomole) => new EnthalpyMolar(joulesperkilomole, EnthalpyMolarUnit.JoulePerKilomole);

        /// <summary>
        ///     Get EnthalpyMolar from JoulesPerMole.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static EnthalpyMolar FromJoulesPerMole(double joulespermole) => new EnthalpyMolar(joulespermole, EnthalpyMolarUnit.JoulePerMole);

        /// <summary>
        ///     Get EnthalpyMolar from KilojoulesPerKilomole.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static EnthalpyMolar FromKilojoulesPerKilomole(double kilojoulesperkilomole) => new EnthalpyMolar(kilojoulesperkilomole, EnthalpyMolarUnit.KilojoulePerKilomole);

        /// <summary>
        ///     Get EnthalpyMolar from KilojoulesPerMole.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static EnthalpyMolar FromKilojoulesPerMole(double kilojoulespermole) => new EnthalpyMolar(kilojoulespermole, EnthalpyMolarUnit.KilojoulePerMole);

        /// <summary>
        ///     Get EnthalpyMolar from MegajoulesPerMole.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static EnthalpyMolar FromMegajoulesPerMole(double megajoulespermole) => new EnthalpyMolar(megajoulespermole, EnthalpyMolarUnit.MegajoulePerMole);


        /// <summary>
        ///     Dynamically convert from value and unit enum <see cref="EnthalpyMolarUnit" /> to <see cref="EnthalpyMolar" />.
        /// </summary>
        /// <param name="value">Value to convert from.</param>
        /// <param name="fromUnit">Unit to convert from.</param>
        /// <returns>EnthalpyMolar unit value.</returns>
        public static EnthalpyMolar From(double value, EnthalpyMolarUnit fromUnit)
        {
            return new EnthalpyMolar(value, fromUnit);
        }

        #endregion

        #region Conversion Methods

        /// <summary>
        ///     Convert to the unit representation <paramref name="unit" />.
        /// </summary>
        /// <returns>Value converted to the specified unit.</returns>
        public double As(EnthalpyMolarUnit unit) => GetValueAs(unit);        

        /// <summary>
        ///     Converts this Duration to another Duration with the unit representation <paramref name="unit" />.
        /// </summary>
        /// <returns>A Duration with the specified unit.</returns>
        public EnthalpyMolar ToUnit(EnthalpyMolarUnit unit)
        {
                
            var convertedValue = GetValueAs(unit);
            return new EnthalpyMolar(convertedValue, unit);
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
                case EnthalpyMolarUnit.BTUPerPoundMole: return _value*(1055.05585262/453.59237);
                case EnthalpyMolarUnit.CaloriesPerMole: return _value*4184;
                case EnthalpyMolarUnit.JoulePerKilomole: return _value*(1.0/1000);
                case EnthalpyMolarUnit.JoulePerMole: return _value;
                case EnthalpyMolarUnit.KilojoulePerKilomole: return (_value*(1.0/1000)) * 1e3d;
                case EnthalpyMolarUnit.KilojoulePerMole: return (_value) * 1e3d;
                case EnthalpyMolarUnit.MegajoulePerMole: return (_value) * 1e6d;
                default:
                    throw new NotImplementedException($"Can not convert {Unit} to base units.");
            }
        }

        private double GetValueAs(EnthalpyMolarUnit unit)
        {
            if(Unit == unit)
                return _value;

            var baseUnitValue = GetValueInBaseUnit();

            switch(unit)
            {
                case EnthalpyMolarUnit.BTUPerPoundMole: return baseUnitValue/(1055.05585262/453.59237);
                case EnthalpyMolarUnit.CaloriesPerMole: return baseUnitValue/4184;
                case EnthalpyMolarUnit.JoulePerKilomole: return baseUnitValue/(1.0/1000);
                case EnthalpyMolarUnit.JoulePerMole: return baseUnitValue;
                case EnthalpyMolarUnit.KilojoulePerKilomole: return (baseUnitValue/(1.0/1000)) / 1e3d;
                case EnthalpyMolarUnit.KilojoulePerMole: return (baseUnitValue) / 1e3d;
                case EnthalpyMolarUnit.MegajoulePerMole: return (baseUnitValue) / 1e6d;
                default:
                    throw new NotImplementedException($"Can not convert {Unit} to {unit}.");
            }
        }

        #endregion

    }
}

