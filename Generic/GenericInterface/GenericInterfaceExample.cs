interface IUnique<T>
{
    T ID { get; set; }
}

class Student<T> : IUnique<T>
{
    public T ID { get; set; }
}

class Program
{
    static void Main(string[] args)
    {
        Student<int> student1 = new Student<int>(){ID = int.MaxValue};
        System.Console.WriteLine($"Student ID of student1 is {student1.ID}");
        Student<ulong> student2 = new Student<ulong>(){ID = ulong.MaxValue};
        System.Console.WriteLine($"Student ID of student2 is {student2.ID}");
    }
}