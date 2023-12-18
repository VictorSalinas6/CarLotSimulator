using System;
using System.Xml.Schema;
using CarLotSimulator;

namespace CarLotSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            var car1 = new Car();
            var Carlot = new Carlot();

            car1.Year = 2022;
            car1.Make = "Tesla";
            car1.Model = "Model 3";
            car1.EngineNoise = "Vriiii";
            car1.HonkNoise = "Ptoooom";
            car1.IsDriveable = true;

            car1.MakeEngineNoise(car1.EngineNoise);
            car1.MakeHonkNoise(car1.HonkNoise);

            var car2 = new Car()
            {
                Year = 1982,
                Make = "Toyota",
                Model = "Supra",
                EngineNoise = "Brooooom",
                HonkNoise = "Hoonk Hooonk",
                IsDriveable = false
            };

            car2.MakeEngineNoise(car2.EngineNoise);
            car2.MakeHonkNoise(car2.HonkNoise);

            var car3 = new Car(1969,"Chevrolet","Camaro","Thoooock","Pooom Pooom",true);

            car3.MakeEngineNoise(car3.EngineNoise);
            car3.MakeHonkNoise(car3.HonkNoise);

            Carlot.OurCarlot.Add(car1);
            Carlot.OurCarlot.Add(car2);
            Carlot.OurCarlot.Add(car3);

            Carlot.GetProperties();


        }
    }
}
