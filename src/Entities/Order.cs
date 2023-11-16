using System;
using System.Collections.Generic;

public class Order
{
    private List<Item> items;
    private double total;
    private Account waiter;
    private int tableNo;

    public Order(List<Item> i, Account w, int tno)
    {
        items = i;
        total = calculateTotal();
        setWaiter(w);
        setTableNo(tno);
    }

    public Order(Account w, int tno)
    {
        items = new List<Item>();
        setWaiter(w);
        setTableNo(tno);
    }

    private int calculateTotal()
    {
        foreach(Item item in items)
        {
            total += item.getPrice();
        }
    }

    public List<Item> getItems()
    {
        return items;
    }

    public void addItem(Item item)
    {
        items.Add(item);
        total = calculateTotal();
    }

    public double getTotal()
    {
        return total;
    }

    public Account getWaiter()
    {
        return waiter;
    }

    public void setWaiter(Account w)
    {
        waiter = w;
    }

    public int getTableNo()
    {
        return tableNo;
    }

    public void setTableNo(int tno)
    {
        tno > 0 ? tableNo = tno : throw new ArgumentException("Invalid table number");
    }

}