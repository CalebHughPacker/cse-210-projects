using System;
using System.Dynamic;
using System.Reflection.Metadata.Ecma335;

public class Product
{
    

    private string _name;
    private string _productId;
    private double _price;
    private int _quantity;

    
    public Product(string name, string productId, double price, int quantity)
    {
        _name = name;
        _productId = productId;
        _price = price;
        _quantity = quantity;
    }

    public string Name
    {
        get {return _name;}
        set {_name = value;}
    }

    public string ProductId
    {
        get {return _productId;}
        set {_productId = value;}
    }

    public double GetTotalCost()
    {
        return _price*_quantity;
    }
}