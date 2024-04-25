namespace Test1;

public class Batch : Thing
{
    private List<Thing> _things;
    private decimal batchTotal;
    

    
    public  Batch(string number, string name): base(number, name)
    {
        _things = new List<Thing>();
    }
    
    public void Add(Thing thing)
    {
        _things.Add(thing);
    }
    
    public override decimal Total()
    {
        decimal batchTotal = 0;
        foreach (Thing thing in _things)
        {
            batchTotal += thing.Total();
        }
        // Console.WriteLine($"BatchTotal in Total is: {batchTotal}");
          return batchTotal;
    }
    
    public override void  Print()
    {
        Console.WriteLine($"{_number}, {_name}");
        if(_things.Count == 0)
        {
            Console.WriteLine("Empty Order");
        }
        else
        {
            foreach (Thing thing in _things)
            {
                thing.Print();
            } 
            Console.WriteLine($"Total: {Total()}");
        }
    }
    
    public string Number
    {
        get
        {
            return _number;
        }
    }
    public string Name
    {
        get
        {
            return _name;
        }
    }
    
}