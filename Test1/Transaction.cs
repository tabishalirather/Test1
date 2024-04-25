﻿namespace Test1;

public class Transaction : Thing
{
    // private string _number;
    // private string _name;
    private decimal _amount;
    
    public  Transaction(string number, string name, decimal amount) : base( number, name)
    {
        _number = number;
        _name = name;
        _amount = amount;
    }

    public override void Print()
    {
        Console.WriteLine($"{_number}, {_name}, {_amount}");
    }

    public override decimal Total()
    {
        return _amount;
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