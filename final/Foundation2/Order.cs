using System;

public class Order
{
    private List<Product> _products;
    private Customer _customer;

    public Order(Customer customer)
    {
        _products = new List<Product>();
        _customer = customer;
    }
    
    public void AddProduct(Product product)
    {
        _products.Add(product);
    }

    public double GetTotalPrice()
    {
        double totalCost = 0;
        double shippingCost;
        foreach (var product in _products)
        {
            totalCost += product.CalculateCost();
        }

        if (_customer.IsLiveInUSA())
        {
            shippingCost = 5;
        }
        else
        {
            shippingCost = 35;
        }

        return totalCost + shippingCost;
    }

    public string DisplayPackingLabel()
    {
        List<string> label = new List<string>();

        foreach (var product in _products)
        {
            label.Add($"{product.GetProductId()} - {product.GetName()} ");
        }
        return string.Join(Environment.NewLine, label);
    }

    public string ShippingLabel()
    {
         return $"{_customer.GetName()}\n{_customer.GetAddress().GetAddress()}";
    }
}