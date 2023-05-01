using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorsApp;

public class Customer
{
    public int Id;  // Note - fields will normally be private, but are set to public for the purpose of this exercise

    public string? Name;

    public List<Order> Orders;

    public Customer()   // default (parameterless) constructor
    {
        Orders = new List<Order>();
    }

    public Customer(int id) : this() // overload
    {
        this.Id = id;
    }

    public Customer(int id, string name) : this(id) // overload
    {
        this.Id = id;
        this.Name = name;
    }

}

