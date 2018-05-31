using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScaleSolSys
{
    public class Scaler
    {
        public double size;
        public string units;
        SizeCalculator sizeCalc = new SizeCalculator();
        DistanceCalculator distCalc = new DistanceCalculator();
        public double Sunsize()
        {
            Console.WriteLine("How big would you like the Sun to be? ");
            string userInput = Console.ReadLine();
            if (!double.TryParse(userInput, out size))
            {
                Console.WriteLine("Not a valid size, please type a number.");
                Sunsize();
            }
            return size;
        }

        public string Sununits(Scaler scaler)
        {

            Console.WriteLine("Is your size in inches or centimeters? ");
            units = Console.ReadLine();
            if (units == "inches" || units == "in")
            {
                Console.WriteLine("If the Sun is " + size + " inches, then...");
                sizeCalc.FindPlanetSizesinInches(scaler);
                Console.WriteLine(" ");
                distCalc.FindDistancesinFeet(scaler);
                Console.ReadLine();
            }
            else if (units == "centimeters" || units == "cm")
            {
                Console.WriteLine("If the Sun is " + size + " centimeters, then...");
                sizeCalc.FindPlanetSizesinCentimeters(scaler);
                Console.WriteLine(" ");
                distCalc.FindDistancesinMeters(scaler);
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Please type in valid units for computation");
                Console.ReadLine();
            }
            return units;
        }

        public void ConvertUnits(Scaler scaler)
        {

            Console.WriteLine("Would you like to do a unit conversion?");
            string response = Console.ReadLine();
            if (response.Equals("Yes") || response.Equals("yes"))
            {
                sizeCalc.Convertunits(scaler);
                Console.WriteLine(" ");
                distCalc.Convertunits(scaler);
                Console.ReadLine();
            }
            else if (response.Equals("No") || response.Equals("no"))
            {
                Console.WriteLine("All right.");
            }
            else
            {
                Console.WriteLine("Invalid Response. Type Yes or No.");
                scaler.ConvertUnits(scaler);
            }
        }
    }
}
