sealed class Parent
{

}

class Child : Parent // Error: 'Child' cannot derive from sealed type 'Parent' (sealed class can not derive classes)
{

}

class Program
{
    static void Main(string[] args)
    {
        Parent parent = new Parent();
        Child child = new Child(); 
    }
}

