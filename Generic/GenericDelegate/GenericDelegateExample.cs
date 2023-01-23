class Program
{
    static void Mul(int x, int y)
    {
        System.Console.WriteLine($"{x} * {y} = {x*y}");
    }

    static int Add(int x, int y)
    {
        var output = x + y;
        return output;
    }

    static void Main(string[] args)
    {
        Action<int, int> mul = Mul;
        mul.Invoke(7, 9);

        Func<int, int, int> add1 = Add;
        System.Console.WriteLine(add1(2, 7));

        Func<double, double, double> add2 = (x, y) => {return x+y;};
        System.Console.WriteLine(add2.Invoke(9, 3));
    }
}
