namespace Test1
{
    class Program
    {
        static void Main()
        {
            // a. Create a Sales object.
            Sales sales = new Sales();

            // b. Add batch orders to the Sales object.
            Batch batchOrder1 = new Batch("#2024x00001", "CompSci Books");
            batchOrder1.Add(new Transaction("1", "Deep Learning in Python", 67.90m));
            batchOrder1.Add(new Transaction("2", "C# in Action", 54.10m));
            batchOrder1.Add(new Transaction("3", "Design Patterns", 129.75m));
            sales.Add(batchOrder1);

            Batch batchOrder2 = new Batch("#2024x00002", "Fantasy Books");
            sales.Add(batchOrder2);

            // c. Add single transaction orders to the Sales object.
            Transaction singleOrder1 = new Transaction("00-0001", "Compilers", 134.60m);
            sales.Add(singleOrder1);

            Transaction singleOrder2 = new Transaction("10-0003", "Hunger Games 1-3", 45.00m);
            sales.Add(singleOrder2);

            Transaction singleOrder3 = new Transaction("15-0020", "Learning Blender", 56.90m);
            sales.Add(singleOrder3);

            // d. Must create one nested batch order.
            Batch hostBatch = new Batch("2", "HostBatch");
            Batch guestBatch = new Batch("3", "GuestBatch");
            Transaction transInGuestBatch = new Transaction("2", "Transaction2", 200);
            guestBatch.Add(transInGuestBatch);
            hostBatch.Add(guestBatch);
            sales.Add(hostBatch);

            // e. Add an empty batch order.
            Batch emptyBatch = new Batch("4", "EmptyBatch");
            sales.Add(emptyBatch);

            // f. Tell PrintOrders to the Sales object.
            sales.PrintOrders();
            Console.WriteLine($"Sales total: {sales.Total()}");
        }
    }
}