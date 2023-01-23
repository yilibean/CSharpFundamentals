class Calculator
{
    public int Add(int x, int y)
    {
        return x + y;
    }
    public int Sub(int x, int y)
    {
        return x - y;
    }
    public int Mul(int x, int y)
    {
        return x * y;
    }
    public int Div(int x, int y)
    {
        return x / y;
    }
}

delegate int Calc(int x, int y);

class Program
{
    static void Main(string[] args)
    {
        Calculator calculator = new Calculator();
        
        Calc calcAdd = new Calc(calculator.Add);
        System.Console.WriteLine(calcAdd(9, 3));
        Calc calcSub = new Calc(calculator.Sub);
        System.Console.WriteLine(calcSub(9, 3));
        Calc calcMul = new Calc(calculator.Mul);
        System.Console.WriteLine(calcMul(9, 3));
        Calc calcDiv = new Calc(calculator.Div);
        System.Console.WriteLine(calcDiv(9, 3));
    }
}
