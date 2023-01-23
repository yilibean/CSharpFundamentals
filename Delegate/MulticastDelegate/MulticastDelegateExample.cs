class Student
{
    public int ID { get; set; }
    public ConsoleColor Color { get; set; }

    public void DoHomework()
    {
        for (int i = 0; i < 5; i++)
        {   
            Console.ForegroundColor = this.Color;
            System.Console.WriteLine($"Student {this.ID} doing homework {i} hour(s)");
            Thread.Sleep(500);
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        Student student1 = new Student(){ID = 1, Color = ConsoleColor.Green};
        Student student2 = new Student(){ID = 2, Color = ConsoleColor.Blue};
        Student student3 = new Student(){ID = 3, Color = ConsoleColor.Magenta};

        Action action1 = new Action(student1.DoHomework);
        Action action2 = new Action(student2.DoHomework);
        Action action3 = new Action(student3.DoHomework);

        action1 += action2;
        action1 += action3;
        action1.Invoke(); // Multicast
    }
}