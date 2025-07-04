using System;

public class Task4
{
    readonly string personName;
    const double PI = 3.14;

    Task4(string name) //As readonly value is assigned either at declaration or through constructor function
    {
        personName = name;
        Console.WriteLine(personName);
    }
    public static void Main(string[] args)

    {
        Task4 T = new Task4("Ammar");
        Console.WriteLine(PI);
    }
}