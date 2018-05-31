using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScaleSolSys
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Solar System Scaler. Here you can build your own scale model of Our Solar System. Just put in the size you want the Sun to be and the code does the rest. Give it a try!");
            Console.ReadLine();
            Scaler scaler = new Scaler();
            scaler.Sunsize();
            scaler.Sununits(scaler);
            scaler.ConvertUnits(scaler);
        }
    }

}
