using System;

namespace CarLotSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO

            //Create a seperate class file called Car
            //Car shall have the following properties: Year, Make, Model, EngineNoise, HonkNoise, IsDriveable
            //Car shall have the following methods: MakeEngineNoise(), MakeHonkNoise()
            //The methods should take one string parameter: the respective noise property


            //Now that the Car class is created we can instanciate 3 new cars
            //Set the properties for each of the cars
            //Call each of the methods for each car

            //*************BONUS*************//

            // Set the properties utilizing the 3 different ways we learned about, one way for each car

            //*************BONUS X 2*************//

            //Create a CarLot class
            //It should have at least one property: a List of cars
            //Instanciate the a Carlot at the beginning of the program and as you create a car add the car to the list.
            //At the end iterate through the list printing each of car's Year, Make, and Model to the console
            

            var dealership = new CarLot();
            
            Car car1 = new Car();
            car1.Make = "Dodge";
            car1.Year = 2015;
            car1.Model = "Challenger";
            car1.EngineNoise = "Loud";
            car1.HonkNoise = "Loud";
            car1.IsDrivable = false;
            dealership.Cars.Add(car1);

            Car car2 = new Car("Toyota", "Prius", 2022, "Silent", "Medium", true);
            dealership.Cars.Add(car2);

            Car car3 = new Car()
            {
                Make = "Acura",
                Model = "TL",
                EngineNoise = "Loud",
                Year = 2015,
                HonkNoise = "Quiet",
                IsDrivable = true
            };
            dealership.Cars.Add(car3);
            
            car1.MakeEngineNoise(car1.EngineNoise);
            car1.MakeHonkNoise(car1.HonkNoise);
                
            car2.MakeHonkNoise(car2.HonkNoise);
            car2.MakeEngineNoise(car2.EngineNoise);
            
            car3.MakeEngineNoise(car3.EngineNoise);
            car3.MakeHonkNoise(car3.HonkNoise);
            
            dealership.DisplayCars();


        }
    }
}
