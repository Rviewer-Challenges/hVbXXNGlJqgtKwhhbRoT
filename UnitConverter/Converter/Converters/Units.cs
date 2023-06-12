using Converter.Enums;
using System;

namespace Converter.Converters
{

    #region BASICS
    public class BasicUnit : IUnit
    {
        public Units unitType { get; set; }
        public double relationShip { get; set; }
        public string descriptor { get; set; }
    }

    public class TemperatureUnit : IUnit 
    {
        public Units unitType { get; set; }
        public double relationShip { get; set; }
        public string descriptor { get; set; }
        public double celsiusOffset { get; set; }
    }
    #endregion

    #region DISTANCES

    public class Milimeter : BasicUnit
    {
        public Milimeter() 
        {
            unitType = Units.Milimeter;
            relationShip = 0.001;
            descriptor = "mm";
        }
    }
    public class Centimeter : BasicUnit
    {
        public Centimeter() 
        {
            unitType = Units.Centimeter;
            relationShip = 0.01;
            descriptor = "cm";
        }
    }

    public class Meter : BasicUnit
    {
        public Meter() 
        {
            unitType = Units.Meter;
            relationShip = 1;
            descriptor = "m";
        }
    }

    public class Kilometer : BasicUnit
    {
        public Kilometer() 
        {
            unitType = Units.Kilometer;
            relationShip = 1000;
            descriptor = "km";
        }
    }
    public class Feet : BasicUnit
    {
        public Feet() 
        {
            unitType = Units.Feet;
            relationShip = 0.3048;
            descriptor = "ft";
        }
    }
    public class Inches : BasicUnit
    {
        public Inches() 
        {
            unitType = Units.Inches;
            relationShip = 0.0254;
            descriptor = "in";
        }
    }

    public class Yard : BasicUnit
    {
        public Yard() 
        {
            unitType = Units.Yard;
            relationShip = 0.9144;
            descriptor = "yd";
        }
    }
    public class Mille : BasicUnit
    {
        public Mille() 
        {
            unitType = Units.Mille;
            relationShip = 1609.34;
            descriptor = "mi";
        }
    }
    public class NauticMille : BasicUnit
    {
        public NauticMille() 
        {
            unitType = Units.NauticMille;
            relationShip = 1852;
            descriptor = "nm";
        }
    }
    public class YearLight : BasicUnit
    {
        public YearLight() 
        {
            unitType = Units.YearLight;
            relationShip = 9.461 * Math.Pow(10,12);
            descriptor = "yl";
        }
    }

    public class HappyStick : BasicUnit
    {
        public HappyStick() 
        {
            unitType = Units.HappyStick;
            relationShip = 0.21;
            descriptor = "HS";
        }
    }
    public class MoonDistance : BasicUnit
    {
        public MoonDistance() 
        {
            unitType = Units.MoonDistance;
            relationShip = 3844 * Math.Pow(10,5);
            descriptor = "Moon Distance";
        }
    }
    public class BasketCourt : BasicUnit
    {
        public BasketCourt() 
        {
            unitType = Units.BasketCourt;
            relationShip = 28;
            descriptor = "Basket Court";
        }
    }
    public class SoccerField : BasicUnit
    {
        public SoccerField() 
        {
            unitType = Units.SoccerField;
            relationShip = 100;
            descriptor = "Soccer Field";
        }
    }
    #endregion

    #region WEIGHTS

    public class Miligrams : BasicUnit
    {
        public Miligrams() 
        {
            unitType = Units.Miligrams;
            relationShip = 0.001;
            descriptor = "mg";
        }
    }
    public class Centigrams : BasicUnit
    {
        public Centigrams() 
        {
            unitType = Units.Centigrams;
            relationShip = 0.01;
            descriptor = "cg";
        }
    }
    public class Decigrams : BasicUnit
    {
        public Decigrams() 
        {
            unitType = Units.Decigrams;
            relationShip = 0.1;
            descriptor = "dg";
        }
    }
    public class Grams : BasicUnit
    {
        public Grams() 
        {
            unitType = Units.Grams;
            relationShip = 1;
            descriptor = "g";
        }
    }
    public class Decagrams : BasicUnit
    {
        public Decagrams() 
        {
            unitType = Units.Decagrams;
            relationShip = 10;
            descriptor = "dag";
        }
    }
    public class Hectograms : BasicUnit
    {
        public Hectograms() 
        {
            unitType = Units.Hectograms;
            relationShip = 100;
            descriptor = "hg";
        }
    }
    public class Kilograms : BasicUnit
    {
        public Kilograms() 
        {
            unitType = Units.Kilograms;
            relationShip = 1000;
            descriptor = "Kg";
        }
    }
    public class Ton : BasicUnit
    {
        public Ton() 
        {
            unitType = Units.Ton;
            relationShip = 1000000;
            descriptor = "t";
        }
    }

    public class Ounze : BasicUnit
    {
        public Ounze() 
        {
            unitType = Units.Ounze;
            relationShip = 28.3495;
            descriptor = "oz";
        }
    }
    public class TroyOunze : BasicUnit
    {
        public TroyOunze() 
        {
            unitType = Units.TroyOunze;
            relationShip = 31.1;
            descriptor = "ozt";
        }
    }
    public class Pound : BasicUnit
    {
        public Pound() 
        {
            unitType = Units.Pound;
            relationShip = 453.592;
            descriptor = "lb";
        }
    }
    public class Packets : BasicUnit
    {
        public Packets() 
        {
            unitType = Units.Packets;
            relationShip = 72.5;
            descriptor = "ю";
        }
    }
    public class EiffelTower : BasicUnit
    {
        public EiffelTower() 
        {
            unitType = Units.GreatPiramyd;
            relationShip = 10.1 * Math.Pow(10,9);
            descriptor = "Eiffel Tower";
        }
    }
    public class PisaTower : BasicUnit
    {
        public PisaTower() 
        {
            unitType = Units.PisaTower;
            relationShip = 14.5 * Math.Pow(10,9);
            descriptor = "Pisa Tower";
        }
    }
    public class GreatPiramyd : BasicUnit
    {
        public GreatPiramyd() 
        {
            unitType = Units.GreatPiramyd;
            relationShip = 5.9 * Math.Pow(10,12);
            descriptor = "Great Piramyds";
        }
    }
    public class Human : BasicUnit
    {
        public Human() 
        {
            unitType = Units.Human;
            relationShip = 75000;
            descriptor = "Humans";
        }
    }
    public class AAABattery : BasicUnit
    {
        public AAABattery() 
        {
            unitType = Units.AAABattery;
            relationShip = 11;
            descriptor = "AAA";
        }
    }
    public class EuroCoin : BasicUnit
    {
        public EuroCoin() 
        {
            unitType = Units.EuroCoin;
            relationShip = 7.5;
            descriptor = "€";
        }
    }
    public class Earth : BasicUnit
    {
        public Earth() 
        {
            unitType = Units.Earth;
            relationShip = 5.972 * Math.Pow(10,24);
            descriptor = "Earths";
        }
    }
    public class Mars : BasicUnit
    {
        public Mars() 
        {
            unitType = Units.Mars;
            relationShip = 6.39 * Math.Pow(10,23);
            descriptor = "Mars";
        }
    }
    public class Sun : BasicUnit
    {
        public Sun() 
        {
            unitType = Units.Sun;
            relationShip = 1.989 * Math.Pow(10,30);
            descriptor = "Suns";
        }
    }
    public class Soul : BasicUnit
    {
        public Soul() 
        {
            unitType = Units.Soul;
            relationShip = 21;
            descriptor = "Soul";
        }
    }



    #endregion

    #region SPEED
    public class MetersPerSecond : BasicUnit
    {
        public MetersPerSecond() 
        {
            unitType = Units.MetersPerSecond;
            relationShip = 1;
            descriptor = "m/s";
        }
    }
    public class KilometerPerHour : BasicUnit
    {
        public KilometerPerHour() 
        {
            unitType = Units.KilometerPerHour;
            relationShip = 0.2778;
            descriptor = "km/h";
        }
    }
    public class MilePerHour : BasicUnit
    {
        public MilePerHour() 
        {
            unitType = Units.MilePerHour;
            relationShip = 0.447;
            descriptor = "mph";
        }
    }
    public class Knot : BasicUnit
    {
        public Knot() 
        {
            unitType = Units.Knot;
            relationShip = 0.5144;
            descriptor = "kt";
        }
    }
    public class FeetPerSecond : BasicUnit
    {
        public FeetPerSecond() 
        {
            unitType = Units.FeetPerSecond;
            relationShip = 0.3048;
            descriptor = "ft/s";
        }
    }
    public class KilometerPerSecond : BasicUnit
    {
        public KilometerPerSecond() 
        {
            unitType = Units.KilometerPerSecond;
            relationShip = 1000;
            descriptor = "km/s";
        }
    }
    public class MicroMeterPerSecond : BasicUnit
    {
        public MicroMeterPerSecond() 
        {
            unitType = Units.MicroMeterPerSecond;
            relationShip = 0.000001;
            descriptor = "μm/s";
        }
    }
    public class NauticMillePerHour : BasicUnit
    {
        public NauticMillePerHour() 
        {
            unitType = Units.NauticMillePerHour;
            relationShip = 0.5144;
            descriptor = "kn";
        }
    }
    public class HumanRun : BasicUnit
    {
        public HumanRun() 
        {
            unitType = Units.HumanRun;
            relationShip = 5;
            descriptor = "Human Running";
        }
    }
    public class Leopard : BasicUnit
    {
        public Leopard() 
        {
            unitType = Units.Leopard;
            relationShip = 16.1;
            descriptor = "Leopard";
        }
    }
    #endregion

    #region TEMPERATURE
    public class Celsius : TemperatureUnit
    {
        public Celsius() 
        {
            unitType = Units.Celsius;
            relationShip = 1;
            descriptor = "Cº";
            celsiusOffset = 0;
        }
    }
    public class Kelvin : TemperatureUnit
    {
        public Kelvin() 
        {
            unitType = Units.Kelvin;
            relationShip = 1;
            descriptor = "K";
            celsiusOffset = 273.15;
        }
    }
    public class Farenheit : TemperatureUnit
    {
        public Farenheit() 
        {
            unitType = Units.Farenheit;
            relationShip = 0.55;
            descriptor = "ºF";
            celsiusOffset = 32;
        }
    }
    #endregion


}
