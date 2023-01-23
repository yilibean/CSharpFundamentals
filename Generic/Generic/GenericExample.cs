class Apple
{
    public string? Breed { get; set; }
}

class Grape
{
    public string? Breed { get; set; }
}

class Box<T> // Generic class
{
    public T Cargo { get; set; }
}

class Program
{
    static void Main(string[] args)
    {
        Apple apple = new Apple(){Breed = "Fuji"};
        Grape grape = new Grape(){Breed = "Shine muscat"};
        Box<Apple> boxOfApple = new Box<Apple>(){Cargo = apple};
        Box<Grape> boxOfGrape = new Box<Grape>(){Cargo = grape};

        System.Console.WriteLine(boxOfApple.Cargo.Breed);
        System.Console.WriteLine(boxOfGrape.Cargo.Breed);
    }
}