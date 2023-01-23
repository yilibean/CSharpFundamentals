using System.Reflection;

interface IVehicle // <IVehicle> only provides related method -- "Run()"
{
    void Run(); 
}

interface IWeapon 
{
    void Fire();
}

interface ITank : IVehicle, IWeapon{} // Multiple interfaces inheritance

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

class Program
{
    static void Main(string[] args)
    {
        ITank tank = new LightTank();
        Type tankType = tank.GetType();
        object o = Activator.CreateInstance(tankType);
        MethodInfo runMethod = tankType.GetMethod("Run");
        MethodInfo fireMethod = tankType.GetMethod("Fire"); 
        runMethod.Invoke(o, null);
        fireMethod.Invoke(o, null);
    }
}