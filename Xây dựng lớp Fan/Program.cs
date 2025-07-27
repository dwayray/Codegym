using System;
using Fanprogram;

class Program
{
    static void Main(string[] args)
    {
        Fan fan1 = new Fan();
        fan1.Speed = Fan.FAST;
        fan1.Radius = 10;
        fan1.Color = "yellow";
        fan1.On = true;

        Fan fan2 = new Fan();
        fan2.Speed = Fan.MEDIUM;
        fan2.Radius = 5;
        fan2.Color = "blue";
        fan2.On = false;

        Console.WriteLine("Fan 1: " + fan1.ToString());
        Console.WriteLine("Fan 2: " + fan2.ToString());
    }
}
