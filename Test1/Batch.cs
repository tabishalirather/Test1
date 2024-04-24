namespace Test1;

public class Batch : Thing
{
    private List<Thing> _things;
    private decimal batchTotal = 0;

    
    public  Batch(string number, string name): base(number, name)
    {
        _things = new List<Thing>();
    }
    
    public void Add(Thing thing)
    {
        _things.Add(thing);
    }
    
    public override void  Print()
    {
        Console.WriteLine($"{_number}, {_name}");
        foreach (Thing thing in _things)
        {
            thing.Print();
        }
    }
    
    public override decimal Total()
    {
        foreach (Thing thing in _things)
        {
            batchTotal += thing.Total();
        }
        return batchTotal;
    }
    
    // public string Number
    // {
    //     get
    //     {
    //         return _number;
    //     }
    // }
    // public string Name
    // {
    //     get
    //     {
    //         return _name;
    //     }
    // }
    
}