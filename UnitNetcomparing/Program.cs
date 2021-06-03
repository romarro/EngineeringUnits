﻿using System;
using System.Diagnostics;

namespace UnitNetcomparing
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            UnitsNet.MassFlow L1 = new UnitsNet.MassFlow(45442, UnitsNet.Units.MassFlowUnit.PoundPerMinute);
            EngineeringUnits.MassFlow L2 = new EngineeringUnits.MassFlow(45442, EngineeringUnits.MassFlowUnit.PoundPerMinute);






            //Debug.Print($"EngineeringUnits: {L2.As(EngineeringUnits.SpecificHeatCapacityUnit.JoulePerKilogramKelvin)}");
            //Debug.Print($"UnitsNet: {L1.As(UnitsNet.Units.SpecificEntropyUnit.JoulePerKilogramKelvin)}");


            //Debug.Print($"EngineeringUnits: {L2.As(EngineeringUnits.SpecificHeatCapacityUnit.BtuPerPoundFahrenheit)}");
            //Debug.Print($"UnitsNet: {L1.As(UnitsNet.Units.SpecificEntropyUnit.BtuPerPoundFahrenheit)}");


            Debug.Print($"UnitsNet: {L1.As(UnitsNet.Units.MassFlowUnit.PoundPerHour)}");
            Debug.Print($"EngineeringUnits: {L2.As(EngineeringUnits.MassFlowUnit.PoundPerHour)}");

            Debug.Print($"EngineeringUnits: {((L2.As(EngineeringUnits.MassFlowUnit.PoundPerHour) - L1.As(UnitsNet.Units.MassFlowUnit.PoundPerHour)) / L2.As(EngineeringUnits.MassFlowUnit.PoundPerHour))*100}");

            //Debug.Print($"{L2.As(EngineeringUnits.EnergyUnit.Joule) - L1.As(UnitsNet.Units.EnergyUnit.Joule)}");






            //Assert.AreEqual(0, L2.As(EngineeringUnits.LengthUnit.Millimeter) - L1.As(UnitsNet.Units.LengthUnit.Millimeter), 4);
            //Assert.AreEqual(0, L2.As(EngineeringUnits.LengthUnit.Micrometer) - L1.As(UnitsNet.Units.LengthUnit.Micrometer), 4000);
            //Assert.AreEqual(0, L2.As(EngineeringUnits.LengthUnit.Nanometer) - L1.As(UnitsNet.Units.LengthUnit.Nanometer), 4000001);
            //Assert.AreEqual(0, L2.As(EngineeringUnits.LengthUnit.Inch) - L1.As(UnitsNet.Units.LengthUnit.Inch), 0.16);
            //Assert.AreEqual(0, L2.As(EngineeringUnits.LengthUnit.Hand) - L1.As(UnitsNet.Units.LengthUnit.Hand), 5281);
            //Assert.AreEqual(0, L2.As(EngineeringUnits.LengthUnit.Foot) - L1.As(UnitsNet.Units.LengthUnit.Foot), 0.014);
            //Assert.AreEqual(0, L2.As(EngineeringUnits.LengthUnit.Yard) - L1.As(UnitsNet.Units.LengthUnit.Yard), 0.0044);
            //Assert.AreEqual(0, L2.As(EngineeringUnits.LengthUnit.Chain) - L1.As(UnitsNet.Units.LengthUnit.Chain), 0.0002);
            //Assert.AreEqual(0, L2.As(EngineeringUnits.LengthUnit.Mile) - L1.As(UnitsNet.Units.LengthUnit.Mile), 0);
            //Assert.AreEqual(0, L2.As(EngineeringUnits.LengthUnit.NauticalMile) - L1.As(UnitsNet.Units.LengthUnit.NauticalMile), 2.2E-06);
            //Assert.AreEqual(0, L2.As(EngineeringUnits.LengthUnit.LightYear) - L1.As(UnitsNet.Units.LengthUnit.LightYear), 4.3E-19);
            //Assert.AreEqual(0, L2.As(EngineeringUnits.LengthUnit.AstronomicalUnit) - L1.As(UnitsNet.Units.LengthUnit.AstronomicalUnit), 2.74E-14);
            //Assert.AreEqual(0, L2.As(EngineeringUnits.LengthUnit.Parsec) - L1.As(UnitsNet.Units.LengthUnit.Parsec), 1.3E-19);



        }
    }
}
