class Vehicle
{
    private readonly string _regNumber;
    public Vehicle()
    {
        Console.WriteLine("vehicle is being initialized..");
    }

    public Vehicle(string regNumber)
    {
     _regNumber = regNumber;   
    }
}

class Car : Vehicle
{
    public Car()
    {
        Console.WriteLine("car is being initializedx");
    }
}