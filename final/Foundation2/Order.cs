using System;
public class Order
{
    private const int UsShippingCost = 5;
    private const int IntlShippingCost = 35;

    private List<Product> _products = new List<Product>();
    private Customer _customer;

    public Order(Customer customer, List<Product> products)
    {
        _customer = customer;
        _products = products;
    }

    public double GetTotalCost()
    {
        double totalCost = 0;
        foreach (Product product in _products)
        {
            totalCost += product.GetTotalCost();
        }
        if (_customer.IsAmerican())
        {
            totalCost += UsShippingCost;
        }
        else{
            totalCost += IntlShippingCost;
        }
        return totalCost;
    }

    public string GetPackingLabel()
    {
        string packingLabel = "Packing Label: ";
        foreach(Product product in _products)
        {
            packingLabel += $"\n{product.Name} -- {product.ProductId}";
        }
        packingLabel += "\n";
        return packingLabel;
    }

    public string GetShippingLabel()
    {
        return $"Shipping Label: {_customer.Name} | {_customer.Address.GetCompleteAddress()}";
    }
}