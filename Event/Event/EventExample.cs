using Timer = System.Timers.Timer;

class Girl
{
    internal void Action(object? sender, System.Timers.ElapsedEventArgs e) // Event handler
    {
        System.Console.WriteLine("Sing...");
    }
}

class Boy
{
    internal void Action(object? sender, System.Timers.ElapsedEventArgs e)
    {
       System.Console.WriteLine("Jump...");
    }
}

class Program
{
    static void Main(string[] args)
    {
        /*
        Event source: timer
        Event: timer.Elapsed
        Event subscriber: girl
        Event handler: girl.Action
        Subscription: +=
        */
        Timer timer = new Timer();
        timer.Interval = 1000;
        Girl girl = new Girl();
        Boy boy = new Boy();
        timer.Elapsed += girl.Action;
        timer.Elapsed += boy.Action;
        
        timer.Start();
        Console.ReadLine();
    }
}
