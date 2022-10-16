using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Shape
{
    public Point ShapePoint { get; set; }
    public float? Length { get; set; }
    public float? Height { get; set; }
    public string? Name { get; set; }
    // конструктор с параметрами
    public Shape(Point shapePoint, float length, float height, string name)
    {
        ShapePoint = shapePoint;
        Length = length;
        Height = height;
        Name = name = "figure";
    }
    //конструктор без параметров для xml serialize
    public Shape()
    {

    }
 
}

