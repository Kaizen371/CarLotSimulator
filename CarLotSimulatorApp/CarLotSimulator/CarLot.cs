using System;
using System.Collections.Generic;

namespace CarLotSimulator;

public class CarLot
{
    public static int NumberOfCars;
    public List<Car> Cars {get; set;} = new List<Car>();
    

    public void DisplayCars()
    {
        foreach (var car in Cars)
        {
            Console.WriteLine(car.Make);
            Console.WriteLine(car.Model);
            Console.WriteLine(car.Year);
            Console.WriteLine(car.IsDrivable);
        }
    }
}