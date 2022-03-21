using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

public class Person
{
    public string name { get; set; }
    public string city { get; set; }
    public string email { get; set; }
    public Person(string n, string c, string e)
    {
        name = n;
        city = c;
        email = e;
    }
    public override string ToString()
    {
        return $"Name: {name}, City: {city}, Email: {email}";
    }
}
