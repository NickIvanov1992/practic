using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class ApplicationDictionary<Tkey, Tvalue>
{
    public Dictionary<Tkey, Tvalue> car_parts;
    public ApplicationDictionary()
    {
        car_parts = new Dictionary<Tkey, Tvalue>();
    }
    public void Adding_element(Tkey key, Tvalue value)
    {
        car_parts.Add(key, value);
    }
    public void delete_element(Tkey key)
    {
        car_parts.Remove(key);
    }
    public Tvalue Get_value(Tkey key)
    {
        car_parts.TryGetValue(key, out Tvalue value);
        return (value);
    }
    public void View_all()
    {
        foreach (var v in car_parts)
        Console.WriteLine($"Key:[{v.Key}] Value:[{v.Value}]");
    }
}

