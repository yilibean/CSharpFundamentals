abstract class Vehicle // Abstract class could not be instantiated which contains at least one abstract method that will be further implemented by its derived classes
{
    public abstract void Run();
    public void Stop()
    {
        System.Console.WriteLine("Stopped...");
    }
    public void Fill()
    {
        System.Console.WriteLine("Filling...");
    }
}

class Car : Vehicle
{
    public override void Run()
    {
        System.Console.WriteLine("Car is running...");
    }
}

class Truck : Vehicle
{
    public override void Run()
    {
        System.Console.WriteLine("Truck is running...");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Car car = new Car();
        Truck truck = new Truck();

        car.Fill();
        car.Stop();
        car.Run();
        truck.Run();
    }
}