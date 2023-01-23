class OrderEventArgs : EventArgs
{
    public string DishName { get; set; }
    public double Price { get; set; }

}

delegate void OrderEventHandler(Customer customer, OrderEventArgs e); // Event declaration

class Customer
{
    private OrderEventHandler _orderEventHandler;
    public double Bill { get; set; }

    public event OrderEventHandler Order
    {
        add
        {
            this._orderEventHandler += value;
        }
        remove
        {
            this._orderEventHandler -= value;
        }
    }

    public void Pay()
    {
        System.Console.WriteLine($"I will pay {this.Bill}.");
    }

    public void WalkIn()
    {
        System.Console.WriteLine("I'd like to eat here.");
    }

    public void SitDown()
    {
        System.Console.WriteLine("Nice spot!");
    }

    public void Think()
    {
        for (int i=0; i<5; i++)
        {
            System.Console.WriteLine("Thinking...");
            Thread.Sleep(1000);
        }
    }

    protected void OnOrder(string dishName, double price)
    {
        if (this._orderEventHandler != null)
        {
            OrderEventArgs orderEventArgs = new OrderEventArgs(){DishName = dishName, Price = price}; 
            this._orderEventHandler.Invoke(this, orderEventArgs); // Invocation of <event> can only occur in event source
        }
    }

    public void Action(string dishName, double price)
    {
        this.WalkIn();
        this.SitDown();
        this.Think();
        this.OnOrder(dishName, price);
        this.Pay();
    }
}

class Waiter
{
    internal static void Action(Customer customer, OrderEventArgs e)
    {
        System.Console.WriteLine($"I will serve you {e.DishName} with price {e.Price}");
        customer.Bill += e.Price;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Customer customer = new Customer(){};
        Waiter waiter = new Waiter();
        customer.Order += Waiter.Action;
        customer.Action("Kongpao chicken", 36);        
    }
}