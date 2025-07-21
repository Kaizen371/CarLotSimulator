using System;

namespace CarLotSimulator;

public class Car
{
    public string Make { get; set; }
    public string Model { get; set; }
    public int Year { get; set; }
    public string EngineNoise{get; set;}
    public string HonkNoise{get; set;}
    public bool IsDrivable{get; set;}

    public void MakeEngineNoise(string engineNoise)
    {
        Console.WriteLine($"Vroom Vroom {Make} {engineNoise}");
    }

    public void MakeHonkNoise(string honkNoise)
    {
        Console.WriteLine($"Beep Beep {Make} {honkNoise}");
    }

    public Car()
    {
        
    }

    public Car(string make, string model, int year, string engineNoise, string honkNoise, bool isDrivable)
    {
        Make = make;
        Model = model;
        Year = year;
        EngineNoise = engineNoise;
        HonkNoise = honkNoise;
        IsDrivable = isDrivable;
        
    }
}