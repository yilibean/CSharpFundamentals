class Vehicle // Parent class
{
    public Vehicle()
    {
        System.Console.WriteLine("This is a vehicle.");
        System.Console.WriteLine(new String('-', 80));   
    }
}

class Car : Vehicle // Child class
{
    public Car()
    {
        System.Console.WriteLine("This is a car.");   
        System.Console.WriteLine(new String('-', 80));
    }
}

class Program
{
    static void Main(string[] args)
    {
        Car car = new Car();
        Vehicle vehicle = new Vehicle();
        System.Console.WriteLine(car is Vehicle); // Child instance is also from parent class

        Vehicle vehicle1 = new Car(); // Parent instance can refer to a instance of child class
    }
}