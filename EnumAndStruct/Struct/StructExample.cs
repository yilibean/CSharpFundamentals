interface ISpeak
{
    void Speak();
}

struct Student : ISpeak // Struct can only derive from interface, but not class/struct
{
    public Student(int id, string name) // Struct cannot have explicit constructor without parameters
    {   
        this.ID = id;
        this.Name = name;
    }

    public int ID { get; set; }
    public string Name { get; set; }

    public void Speak()
    {
        System.Console.WriteLine($"I am {this.Name}, and my student ID is {this.ID}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Student student1 = new Student(1, "Yingrui");
        student1.Speak();

        Student student2 = new Student(){ID = 2};
        student2.Speak();
    }
}
