using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarLotSimulator
{
    internal class Carlot
    {
        public List<Car> OurCarlot {  get; set; } = new List<Car>();

        public void GetProperties()
        {
            foreach (var car in OurCarlot)
            {
                Console.WriteLine($"The {car.Model} is from {car.Make} and it´s from the year {car.Year}.\n");
            }
        }

        public static int NumberOfCars {  get; set; }
    }
}
