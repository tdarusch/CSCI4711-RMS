using System;

public class Item 
{
    private double price;
    private string name;
    private string description;

    public Item (double p, string n, string d) 
    {
        setPrice(p);
        setName(n);
        setDescription(d);
    }

    public double getPrice() {
        return price;
    }

    public void setPrice(double p) {
        p > 0 ? price = p : throw new ArgumentException("Invalid item price");
    }

    public string getName() 
    {
        return name;
    }

    public void setName(string n) 
    {
        name = n;
    }

    public string getDescription()
    {
        return description;
    }

    public void setDescription(string d)
    {
        description = d;
    }

}