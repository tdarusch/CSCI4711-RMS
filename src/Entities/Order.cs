using System;
using System.Collections.Generic;

public class Order
{
    private List<Item> items;
    private double total;
    private Account waiter;
    private int tableNo;

    public Order(List<Item> items, Account waiter, int tableNo)
    {
        this.items = items;
        total = calculateTotal();
        setWaiter(waiter);
        setTableNo(tableNo);
    }

    public Order(Account waiter, int tableNo)
    {
        items = new List<Item>();
        setWaiter(waiter);
        setTableNo(tableNo);
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

    public void setWaiter(Account waiter)
    {
        this.waiter = waiter;
    }

    public int getTableNo()
    {
        return tableNo;
    }

    public void setTableNo(int tableNo)
    {
        tableNo > 0 ? this.tableNo = tableNo : throw new ArgumentException("Invalid table number");
    }

}