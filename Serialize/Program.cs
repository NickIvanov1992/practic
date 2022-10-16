///Написать программу выполняющую сериализацию и десериализацию. 
///Создать класс Point со свойствами float X, float Y. 
///Создать класс Shape со свойствами Point ShapePoint, float Length, float Height, string Name. 
///В методе Main создать массив из заполненных элементов типа Shape. 
///Выполнить сериализацию и десериализацию этого массива. 
///Название файла для сериализации и десериализации вводить с клавиатуры. 
///Сериализуемые форматы XML и JSON. 
///Так же необходимо использовать блоки для обработки исключений.
///После выполнения задания, скачать nuget-пакет Newtonsoft.Json. 
///Попробовать выполнить сериализацию с помощью Json сериализатора из этого пакета

ArraySerialization arraySerialization = new ArraySerialization();
Shape[] myArray = new Shape[2] 
{
    new Shape(new Point(10,20),30,40,"shape1"),
    new Shape (new Point(50,60),70,80,"shape2")
};

ArraySerialization.getserialize(myArray);

  
    