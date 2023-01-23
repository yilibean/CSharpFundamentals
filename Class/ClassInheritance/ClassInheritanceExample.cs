class Vehicle // Parent class
{
    public Vehicle(string owner)
    { 
        this.Owner = owner;
    }

    public string Owner { get; set; }
}

class Car : Vehicle // Child class
{
    public Car(string owner) : base(owner){}
}

class Program
{
    static void Main(string[] args)
    {
        Car car = new Car("Yingrui"); // Constructor is not inherited from parent class and thus needs to be defined
        System.Console.WriteLine(car.Owner);
    }
}