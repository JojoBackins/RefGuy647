using System;

class Program
{
    static void ModifyAnIntAndGuy(ref int valueRef, ref Guy guyRef)
    {
        valueRef += 10;
        guyRef.Name = "Bob";
        guyRef.Age = 37;
    }
    static void Main(string[] args)
    {
        var i = 1;
        var guy = new Guy() { Name = "Joe", Age = 26 };
        Console.WriteLine("i is {0} and guy is {1}", i, guy);
        ModifyAnIntAndGuy(ref i, ref guy);
        Console.WriteLine("Now i is {0} and guy is {1}", i, guy);
        Console.WriteLine();
        CheckTemperature(101.3);
        CheckTemperature(101.3, 102.5, 100.5);
        CheckTemperature(96.2, tooLow: 95.5);
    }
    static void CheckTemperature (double temp, double tooHigh = 99.5, double tooLow = 96.5) //необязательный параметр
    {
        if (temp < tooHigh && temp > tooLow)
        {
            Console.WriteLine("{0} degrees F - feeling good!", temp);
        }else
        {
            Console.WriteLine("Uh-oh {0} degrees F -- better see a doctor!", temp);
        }
    }
}

class Guy
{
    public string Name { get; set; }
    public int Age { get; set; }
    public override string ToString() => $"a {Age}-year-old named {Name}"; 
}