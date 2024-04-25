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
            batchOrder1.Add(new Transaction("1", "Deep Learning in Python", 10m));
            batchOrder1.Add(new Transaction("2", "C# in Action", 10m));
            batchOrder1.Add(new Transaction("3", "Design Patterns", 10m));
            sales.Add(batchOrder1);
            
            // Batch batchOrderX = new Batch("#2024x00001", "Second Batch testing");
            // batchOrderX.Add(new Transaction("1", "Deep Learning in Python", 5m));
            // batchOrderX.Add(new Transaction("2", "C# in Action", 5m));
            // batchOrderX.Add(new Transaction("3", "Design Patterns", 5m));
            // sales.Add(batchOrderX);

            Batch batchOrder2 = new Batch("#2024x00002", "Fantasy Books-Empty");
            sales.Add(batchOrder2);
            
            // c. Add single transaction orders to the Sales object.
            Transaction singleOrder1 = new Transaction("00-0001", "Compilers", 10m);
            Transaction singleOrder2 = new Transaction("10-0003", "Hunger Games 1-3", 10m);
            Transaction singleOrder3 = new Transaction("15-0020", "Learning Blender", 10m);
            sales.Add(singleOrder1);
            sales.Add(singleOrder2);
            sales.Add(singleOrder3);

            // Nested Batch
            Batch hostBatch = new Batch("4", "2024x00003 Host");
            Batch guestBatch = new Batch("5", "2024x00004 Guest");
            hostBatch.Add(guestBatch);
            Transaction transInGuestBatch = new Transaction("00-00", "Transaction GuestBatch in HostBatch", 11.2m);
            hostBatch.Add(transInGuestBatch);
            sales.Add(hostBatch);
            
            sales.PrintOrders();
            Console.WriteLine($"Sales total: {sales.Total()}");
        }
    }
}