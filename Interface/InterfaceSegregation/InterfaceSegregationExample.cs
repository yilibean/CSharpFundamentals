interface IVehicle // <IVehicle> only provides related method -- "Run()"
{
    void Run(); 
}

interface IWeapon 
{
    void Fire();
}

interface ITank : IVehicle, IWeapon{} // Multiple interfaces inheritance

class Car : IVehicle
{
    public void Run()
    {
        System.Console.WriteLine("Car is running...");
    }
}

class Truck : IVehicle
{
    public void Run()
    {
        System.Console.WriteLine("Truck is running...");
    }
}

class LightTank : ITank
{
    public void Run()
    {
        System.Console.WriteLine("Light tank is running...");
    }

    public void Fire()
    {
        System.Console.WriteLine("Ka! Ka! Ka!");
    }
}

class HeavyTank : ITank
{
    public void Run()
    {
        System.Console.WriteLine("Heavy tank is running...");
    }

    public void Fire()
    {
        System.Console.WriteLine("Ka!!! Ka!!! Ka!!!");
    }
}

class Driver
{
    private IVehicle _vehicle;
    public Driver(IVehicle vehicle)
    {   
        _vehicle = vehicle;
    }
    public void Drive()
    {
        _vehicle.Run();
    }
}

class Program
{
    static void Main(string[] args)
    {
        Driver driver1 = new Driver(new LightTank());
        driver1.Drive();

        Driver driver2 = new Driver(new Truck());
        driver2.Drive();
    }
}




