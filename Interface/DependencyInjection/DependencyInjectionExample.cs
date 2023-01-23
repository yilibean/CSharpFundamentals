using Microsoft.Extensions.DependencyInjection;

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
        // Registration
        var sc = new ServiceCollection(); // Create a container
        sc.AddScoped(typeof(ITank), typeof(LightTank)); // Register <serviceType> (i.e. interface) and implementationType
                                                        // (the class that implements the interface) in the container
        sc.AddScoped(typeof(IVehicle), typeof(Car));
        sc.AddScoped<Driver>();
        var sp = sc.BuildServiceProvider();
        //----------------------------------------------------//
        // Get an instance from the container then call it
        ITank tank = sp.GetService<ITank>();
        tank.Run();
        tank.Fire();
        
        var driver = sp.GetService<Driver>(); // Container automatically injects corresponding instance into constructor 
        driver.Drive();
    }
}