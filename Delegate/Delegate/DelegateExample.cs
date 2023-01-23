class Calculator
{
    public void Report()
    {
        System.Console.WriteLine("I am a calculator.");
    }

    public int Add(int x, int y)
    {
        return x + y;
    }

    public double Sub(double x, double y)
    {
        return x - y;
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Predefined delegate
        Calculator calculator = new Calculator();
        Action action = new Action(calculator.Report); // Delegate void type methods
        action += calculator.Report;
        action.Invoke();
        
        Func<int, int, int> func1 = new Func<int, int, int>(calculator.Add); // Delegate other (excluding void) type methods 
        System.Console.WriteLine(func1.Invoke(3, 6));
        Func<double, double, double> func2 = new Func<double, double, double>(calculator.Sub);
        System.Console.WriteLine(func2(3.0, 6));
    }
}