namespace Test1;

public class Sales
{
    // private List<Batch> _batchOrders;
    // private List<Transaction> _singleOrders;
    private List<Thing> _orders;
    
    public Sales()
    {
        _orders = new List<Thing>();
    }
    
    public void Add(Thing order)
    {
        _orders.Add(order);
    }
    
    public void PrintOrders()
    {
        foreach (Thing order in _orders)
        {
            order.Print();
        }
    }
    
    public decimal Total()
    {
        decimal total = 0;
        foreach (Thing order in _orders)
        {
            total += order.Total();
        }
        return total;
    }
}