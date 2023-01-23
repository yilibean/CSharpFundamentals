public class AccessModifier
{
    public string? PublicProperty { get {return "Public";} } 
    internal string? InternalProperty { get {return "Internal";} } // Access is limited to the current assembly
    protected string? ProtectedProperty { get {return "Protected";} } // Access is limited to the containing class or types derived from the containing class
    private string? PrivateProperty { get {return "Private";} } // Access is limited to the containing type
    protected internal string? ProtectedInternalProperty { get {return "ProtectedInternal";} } // Access is limited to the current assembly or types derived from the containing class
    private protected string? PrivateProtectedProperty { get {return "PrivateProtected";} } // Access is limited to the containing class or types derived from the containing class within the current assembly

    public void ShowProperty()
    {
        System.Console.WriteLine("Show properties of class <AccessModifier>: ");

        System.Console.WriteLine(this.PublicProperty);
        System.Console.WriteLine(this.InternalProperty);
        System.Console.WriteLine(this.ProtectedProperty);
        System.Console.WriteLine(this.PrivateProperty);
        System.Console.WriteLine(this.ProtectedInternalProperty);
        System.Console.WriteLine(this.PrivateProtectedProperty);

        System.Console.WriteLine(new String('-', 80));
    }
}

public class AccessModifierChild : AccessModifier
{    
    public void ShowPropertyOfParent()
    {
        System.Console.WriteLine("Show properties of the child class of class <AccessModifier>: ");

        System.Console.WriteLine(base.PublicProperty);
        System.Console.WriteLine(base.InternalProperty);
        System.Console.WriteLine(base.ProtectedProperty);
        System.Console.WriteLine(base.ProtectedInternalProperty);
        System.Console.WriteLine(base.PrivateProtectedProperty);

        System.Console.WriteLine(new String('-', 80));
    }
}

public class AccessModifierOther
{
    public void ShowProperty()
    {
        System.Console.WriteLine("Show properties of an unrelated class in the same assembly: ");

        AccessModifier accessModifier = new AccessModifier();
        System.Console.WriteLine(accessModifier.PublicProperty);
        System.Console.WriteLine(accessModifier.InternalProperty);
        System.Console.WriteLine(accessModifier.ProtectedInternalProperty);

        System.Console.WriteLine(new String('-', 80));
    }
}

class Program
{
    static void Main(string[] args)
    {
        AccessModifier accessModifier = new AccessModifier();
        AccessModifierChild accessModifierChild = new AccessModifierChild();
        AccessModifierOther accessModifierOther = new AccessModifierOther();

        accessModifier.ShowProperty();
        accessModifierChild.ShowPropertyOfParent();
        accessModifierOther.ShowProperty();
    }
}
