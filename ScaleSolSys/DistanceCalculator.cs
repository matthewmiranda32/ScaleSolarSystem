using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScaleSolSys
{
    public class DistanceCalculator
    {
        double mercDistance;
        double venDistance;
        double ertDistance;
        double marsDistance;
        double jupDistance;
        double satDistance;
        double uraDistance;
        double neptDistance;
        SizeCalculator sizecalc = new SizeCalculator();
        public void FindDistancesinFeet(Scaler scaler)
        {


            double sunInFeet = (scaler.size) / 12;
            mercDistance = (sunInFeet / sizecalc.actualSunSize) * 57910000;
            Console.WriteLine("Mercury would be " + Math.Round(mercDistance, 3) + " feet away from the Sun");
            venDistance = (sunInFeet / sizecalc.actualSunSize) * 108200000;
            Console.WriteLine("Venus would be " + Math.Round(venDistance, 3) + " feet away from the Sun");
            ertDistance = (sunInFeet / sizecalc.actualSunSize) * 149600000;
            Console.WriteLine("Earth would be " + Math.Round(ertDistance, 3) + " feet away from the Sun");
            marsDistance = (sunInFeet / sizecalc.actualSunSize) * 227900000;
            Console.WriteLine("Mars would be " + Math.Round(marsDistance, 3) + " feet away from the Sun");
            jupDistance = (sunInFeet / sizecalc.actualSunSize) * 778200000;
            Console.WriteLine("Jupiter would be " + Math.Round(jupDistance, 3) + " feet away from the Sun");
            satDistance = (sunInFeet / sizecalc.actualSunSize) * 1427000000;
            Console.WriteLine("Saturn would be " + Math.Round(satDistance, 3) + " feet away from the Sun");
            uraDistance = (sunInFeet / sizecalc.actualSunSize) * 2870000000;
            Console.WriteLine("Uranus would be " + Math.Round(uraDistance, 3) + " feet away from the Sun");
            neptDistance = (sunInFeet / sizecalc.actualSunSize) * 4497000000;
            Console.WriteLine("Neptune would be " + Math.Round(neptDistance, 3) + " feet away from the Sun");
        }

        public void FindDistancesinMeters(Scaler scaler)
        {

            double sunInMeters = (scaler.size) / 100;
            mercDistance = (sunInMeters / sizecalc.actualSunSize) * 57910000;
            Console.WriteLine("Mercury would be " + Math.Round(mercDistance, 3) + " meters away from the Sun");
            venDistance = (sunInMeters / sizecalc.actualSunSize) * 108200000;
            Console.WriteLine("Venus would be " + Math.Round(venDistance, 3) + " meters away from the Sun");
            ertDistance = (sunInMeters / sizecalc.actualSunSize) * 149600000;
            Console.WriteLine("Earth would be " + Math.Round(ertDistance, 3) + " meters away from the Sun");
            marsDistance = (sunInMeters / sizecalc.actualSunSize) * 227900000;
            Console.WriteLine("Mars would be " + Math.Round(marsDistance, 3) + " meters away from the Sun");
            jupDistance = (sunInMeters / sizecalc.actualSunSize) * 778200000;
            Console.WriteLine("Jupiter would be " + Math.Round(jupDistance, 3) + " meters away from the Sun");
            satDistance = (sunInMeters / sizecalc.actualSunSize) * 1427000000;
            Console.WriteLine("Saturn would be " + Math.Round(satDistance, 3) + " meters away from the Sun");
            uraDistance = (sunInMeters / sizecalc.actualSunSize) * 2870000000;
            Console.WriteLine("Uranus would be " + Math.Round(uraDistance, 3) + " meters away from the Sun");
            neptDistance = (sunInMeters / sizecalc.actualSunSize) * 4497000000;
            Console.WriteLine("Neptune would be " + Math.Round(neptDistance, 3) + " meters away from the Sun");
        }
        public void Convertunits(Scaler scaler)
        {
            if (scaler.units.Equals("inches") || scaler.units.Equals("in"))
            {
                double mercmeter = mercDistance * 0.3048;
                Console.WriteLine("Mercury would be " + Math.Round(mercmeter, 3) + " meters from the Sun.");
                double venmeter = venDistance * 0.3048;
                Console.WriteLine("Venus would be " + Math.Round(venmeter, 3) + " meters from the Sun.");
                double ertmeter = ertDistance * 0.3048;
                Console.WriteLine("Earth would be " + Math.Round(ertmeter, 3) + " meters from the Sun.");
                double marsmeter = marsDistance * 0.3048;
                Console.WriteLine("Mars would be " + Math.Round(marsmeter, 3) + " meters from the Sun.");
                double jupmeter = jupDistance * 0.3048;
                Console.WriteLine("Jupiter would be " + Math.Round(jupmeter, 3) + " meters from the Sun.");
                double satmeter = satDistance * 0.3048;
                Console.WriteLine("Saturn would be " + Math.Round(satmeter, 3) + " meters from the Sun.");
                double urameter = uraDistance * 0.3048;
                Console.WriteLine("Uranus would be " + Math.Round(urameter, 3) + " meters from the Sun.");
                double neptmeter = neptDistance * 0.3048;
                Console.WriteLine("Neptune would be " + Math.Round(neptmeter, 3) + " meters from the Sun.");
            }
            else if (scaler.units.Equals("centimeters") || scaler.units.Equals("cm"))
            {
                double mercfeet = mercDistance * 3.28084;
                Console.WriteLine("Mercury would be " + Math.Round(mercfeet, 3) + " feet from the Sun.");
                double feetVenus = venDistance * 3.28084;
                Console.WriteLine("Venus would be " + Math.Round(feetVenus, 3) + " feet from the Sun.");
                double Earthfoot = ertDistance * 3.28084;
                Console.WriteLine("Earth would be " + Math.Round(Earthfoot, 3) + " feet from the Sun.");
                double marfoot = marsDistance * 3.28084;
                Console.WriteLine("Mars would be " + Math.Round(marfoot, 3) + " feet from the Sun.");
                double jupfeet = jupDistance * 3.28084;
                Console.WriteLine("Jupiter would be " + Math.Round(jupfeet, 3) + " feet from the Sun.");
                double satfeet = satDistance * 3.28084;
                Console.WriteLine("Saturn would be " + Math.Round(satfeet, 3) + " feet from the Sun.");
                double urafeet = uraDistance * 3.28084;
                Console.WriteLine("Uranus would be " + Math.Round(urafeet, 3) + " feet from the Sun.");
                double footnept = neptDistance * 3.28084;
                Console.WriteLine("Neptune would be " + Math.Round(footnept, 3) + " feet from the Sun.");
            }
        }
    }
}
