using Converter.Enums;
using System;
using System.Collections.Generic;

namespace Converter
{
    public interface IConverter
    {
        List<IUnit> AvailableUnits { get; set; }
        IUnit From { get; set; }
        IUnit To { get; set; }
        Units masterUnit { get; set; }
        void SetUnitsListRelative(int fromIdx, int toIdx);
        double Calculate(double valueToConvert);
    }


    public interface IUnit 
    {
        Units unitType { get; set; }
        double relationShip { get; set; }
        string descriptor { get; set; }
    }

}
