enum Level
{
    Junior = 1,
    Senior = 2,
    Manager = 3,
    ET = 4,
}

enum Skill 
{
    Test = 1, // Bit-wise usage
    Develop = 2,
    Analyze = 4,
    Monitor = 8,
}

class Employee
{
    public int ID { get; set; }
    public string Name { get; set; }
    public Level Level { get; set; }
    public Skill Skill { get; set; }
}

class Program
{
    static void Main(string[] args)
    {
        Employee employee = new Employee(){};
        employee.Level = Level.Senior;
        System.Console.WriteLine(employee.Level);

        employee.Skill = Skill.Test | Skill.Develop | Skill.Analyze;
        System.Console.WriteLine(employee.Skill);
    }
}