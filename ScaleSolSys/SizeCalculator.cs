using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScaleSolSys
{
    public class SizeCalculator
    {
        double mercSize;
        double venSize;
        double ertSize;
        double marSize;
        double jupsize;
        double satSize;
        double uranSize;
        double neptSize;
        public double actualSunSize = 1391000;
        public void FindPlanetSizesinInches(Scaler scaler)
        {

            mercSize = ((scaler.size) / actualSunSize) * 4879;
            Console.WriteLine("Mercury would be " + Math.Round(mercSize, 3) + " inches across.");
            venSize = ((scaler.size) / actualSunSize) * 12104;
            Console.WriteLine("Venus would be " + Math.Round(venSize, 3) + " inches across.");
            ertSize = ((scaler.size) / actualSunSize) * 12742;
            Console.WriteLine("Earth would be " + Math.Round(ertSize, 3) + " inches across.");
            marSize = ((scaler.size) / actualSunSize) * 6779;
            Console.WriteLine("Mars would be " + Math.Round(marSize, 3) + " inches across.");
            jupsize = ((scaler.size) / actualSunSize) * 139822;
            Console.WriteLine("Jupiter would be " + Math.Round(jupsize, 3) + " inches across.");
            satSize = ((scaler.size) / actualSunSize) * 116464;
            Console.WriteLine("Saturn would be " + Math.Round(satSize, 3) + " inches across.");
            uranSize = ((scaler.size) / actualSunSize) * 50724;
            Console.WriteLine("Uranus would be " + Math.Round(uranSize, 3) + " inches across.");
            neptSize = ((scaler.size) / actualSunSize) * 49244;
            Console.WriteLine("Neptune would be " + Math.Round(neptSize, 3) + " inches across.");
        }
        public void FindPlanetSizesinCentimeters(Scaler scaler)
        {
            mercSize = ((scaler.size) / actualSunSize) * 4879;
            Console.WriteLine("Mercury would be " + Math.Round(mercSize, 3) + " centimeters across.");
            venSize = ((scaler.size) / actualSunSize) * 12104;
            Console.WriteLine("Venus would be " + Math.Round(venSize, 3) + " centimeters across.");
            ertSize = ((scaler.size) / actualSunSize) * 12742;
            Console.WriteLine("Earth would be " + Math.Round(ertSize, 3) + " centimeters across.");
            marSize = ((scaler.size) / actualSunSize) * 6779;
            Console.WriteLine("Mars would be " + Math.Round(marSize, 3) + " centimeters across.");
            jupsize = ((scaler.size) / actualSunSize) * 139822;
            Console.WriteLine("Jupiter would be " + Math.Round(jupsize, 3) + " centimeters across.");
            satSize = ((scaler.size) / actualSunSize) * 116464;
            Console.WriteLine("Saturn would be " + Math.Round(satSize, 3) + " centimeters across.");
            uranSize = ((scaler.size) / actualSunSize) * 50724;
            Console.WriteLine("Uranus would be " + Math.Round(uranSize, 3) + " centimeters across.");
            neptSize = ((scaler.size) / actualSunSize) * 49244;
            Console.WriteLine("Neptune would be " + Math.Round(neptSize, 3) + " centimeters across.");
        }
        public void Convertunits(Scaler scaler)
        {
            if (scaler.units.Equals("inches") || scaler.units.Equals("in"))
            {
                double rescaledSunSize = scaler.size * 2.54;
                Console.WriteLine("If the Sun is " + Math.Round(rescaledSunSize, 3) + " centimeters across, then...");
                double mercincm = mercSize * 2.54;
                Console.WriteLine("Mercury would be " + Math.Round(mercincm, 3) + " centimeters across.");
                double venincm = venSize * 2.54;
                Console.WriteLine("Venus would be " + Math.Round(venincm, 3) + " centimeters across.");
                double ertincm = ertSize * 2.54;
                Console.WriteLine("Earth would be " + Math.Round(ertincm, 3) + " centimeters across.");
                double marsincm = marSize * 2.54;
                Console.WriteLine("Mars would be " + Math.Round(marsincm, 3) + " centimeters across.");
                double jupincm = jupsize * 2.54;
                Console.WriteLine("Jupiter would be " + Math.Round(jupincm, 3) + " centimeters across.");
                double satincm = satSize * 2.54;
                Console.WriteLine("Saturn would be " + Math.Round(satincm, 3) + " centimeters across.");
                double urancm = uranSize * 2.54;
                Console.WriteLine("Uranus would be " + Math.Round(urancm, 3) + " centimeters across.");
                double neptincm = neptSize * 2.54;
                Console.WriteLine("Neptune would be " + Math.Round(neptincm, 3) + " centimeters across.");
            }
            else if (scaler.units.Equals("centimeters") || scaler.units.Equals("cm"))
            {
                double rescaledSunSize = scaler.size * 0.3937;
                Console.WriteLine("If the Sun is " + Math.Round(rescaledSunSize, 3) + " inches across, then...");
                double inchMercury = mercSize * 0.3937;
                Console.WriteLine("Mercury would be " + Math.Round(inchMercury, 3) + " inches across.");
                double Venusinches = venSize * 0.3937;
                Console.WriteLine("Venus would be " + Math.Round(Venusinches, 3) + " inches across.");
                double Earthinches = ertSize * 0.3937;
                Console.WriteLine("Earth would be " + Math.Round(Earthinches, 3) + " inches across.");
                double inchMars = marSize * 0.3937;
                Console.WriteLine("Mars would be " + Math.Round(inchMars, 3) + " inches across.");
                double inchjup = jupsize * 0.3937;
                Console.WriteLine("Jupiter would be " + Math.Round(inchjup, 3) + " inches across.");
                double satinch = satSize * 0.3937;
                Console.WriteLine("Saturn would be " + Math.Round(satinch, 3) + " inches across.");
                double uraninch = uranSize * 0.3937;
                Console.WriteLine("Uranus would be " + Math.Round(uraninch, 3) + " inches across.");
                double neptinch = neptSize * 0.3937;
                Console.WriteLine("Neptune would be " + Math.Round(neptinch, 3) + " inches across.");
            }

        }
    }
}
