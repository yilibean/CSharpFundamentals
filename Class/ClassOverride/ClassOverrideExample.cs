class Vehicle
{
    public virtual void Run()
    {
        System.Console.WriteLine("Running Vehicle");
        System.Console.WriteLine(new String('-', 80));
    }
}

class Car : Vehicle
{
    public override void Run()
    {
        System.Console.WriteLine("Running Car");
        System.Console.WriteLine(new String('-', 80));
    }
}

class Program
{
    static void Main(string[] args)
    {
        Vehicle vehicle = new Vehicle();
        vehicle.Run();

        Car car = new Car();
        car.Run();

        Vehicle vehicle1 = new Car(); // Implying a <Car> instance is also from <Vehicle> class
        vehicle1.Run();
    }
}