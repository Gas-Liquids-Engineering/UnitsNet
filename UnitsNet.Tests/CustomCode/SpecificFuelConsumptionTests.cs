﻿//------------------------------------------------------------------------------
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

namespace UnitsNet.Tests.CustomCode
{
    public class SpecificFuelConsumptionTests : SpecificFuelConsumptionTestsBase
    {
        // Override properties in base class here
        protected override bool SupportsSIUnitSystem => false;

        protected override double GramsPerKiloNewtonSecondInOneGramPerKiloNewtonSecond => 1;

        protected override double KilogramsPerKiloNewtonSecondInOneGramPerKiloNewtonSecond => 1e-3;

        protected override double PoundsMassPerPoundForceHourInOneGramPerKiloNewtonSecond => 0.035304;

        protected override double KilogramsPerKilogramForceHourInOneGramPerKiloNewtonSecond => 0.035304;        
    }
}
