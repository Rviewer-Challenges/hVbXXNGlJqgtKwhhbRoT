using Converter.Enums;
using System.Collections.Generic;

namespace Converter
{
    /// <summary>
    /// Main interface used for converters.
    /// </summary>
    public interface IConverter
    {
        List<IUnit> AvailableUnits { get; set; }
        IUnit From { get; set; }
        IUnit To { get; set; }
        Units masterUnit { get; set; }
        void SetUnitsListRelative(int fromIdx, int toIdx);
        double Calculate(double valueToConvert);
        double Calculate(double valueToConvert, double fromOffset, double toOffset);
    }

    /// <summary>
    /// Main interface used for units.
    /// </summary>
    public interface IUnit 
    {
        Units unitType { get; set; }
        double relationShip { get; set; }
        string descriptor { get; set; }
    }

}
