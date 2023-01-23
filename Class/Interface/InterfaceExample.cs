interface IPhone // Interface only defines the (abstract) methods that should be implemented
{
    void Dail(); // All methods in the interface are implicitly "public"
    void PickUp();
    void SendMessage();
    void ReceiveMessage();
}

class User
{
    private IPhone _phone;
    public User(IPhone phone)
    {   
        _phone = phone;
    }
    public void UsePhone()
    {
        _phone.Dail();
        _phone.PickUp();
        _phone.SendMessage();
        _phone.ReceiveMessage();
    }
}

class NokiaPhone : IPhone
{
    public void Dail()
    {
        System.Console.WriteLine("Nokia is dailing...");
    }

    public void PickUp()
    {
        System.Console.WriteLine("Picking up Nokia...");
    }

    public void SendMessage()
    {
        System.Console.WriteLine("Nokia is sending message...");
    }

    public void ReceiveMessage()
    {
        System.Console.WriteLine("Getting new message on Nokia...");
    }
}

class OppoPhone : IPhone
{
    public void Dail()
    {
        System.Console.WriteLine("Oppo is dailing...");
    }

    public void PickUp()
    {
        System.Console.WriteLine("Picking up Oppo...");
    }

    public void SendMessage()
    {
        System.Console.WriteLine("Oppo is sending message...");
    }

    public void ReceiveMessage()
    {
        System.Console.WriteLine("Getting new message on Oppo...");
    }
}

class Program
{
    static void Main(string[] args)
    {
        User user = new User(new OppoPhone());
        user.UsePhone();
    }
}