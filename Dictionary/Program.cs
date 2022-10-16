using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    public class Program
    {
    static void Main(string[] args)
    {
        ApplicationDictionary<string,string> applicationDictionary = new ApplicationDictionary<string,string>();
        
        // ввести свое значение в словарь
        Console.WriteLine("Введите значения в словарь в формате: ключ , значение");
        string str = Console.ReadLine();
        string[] words = str.Split(',');
        string key = words[0];
        string value = words[1];
        applicationDictionary.Adding_element(key, value);

        // добавил еще значений по умолчанию
        applicationDictionary.Adding_element("engine", "двигатель");
        applicationDictionary.Adding_element("gearbox", "коробка передач");
        applicationDictionary.Adding_element("wheel", "колесо");

        // удаление значения
        Console.WriteLine("Для удаления из словаря введите соответствующий ключ");
        key = Console.ReadLine();
        applicationDictionary.delete_element(key);

        // поиск значений 
        Console.WriteLine("Введите значение для поиска");
        key = Console.ReadLine();
        applicationDictionary.Get_value(key);
        Console.WriteLine($"Найдено значение {applicationDictionary.Get_value(key)}");

        // вывести список всех ключей
        applicationDictionary.View_all();
        Console.ReadKey();
        
    }
    }

///Реализовать простейший вариант класса Dictionary<TKey, TValue>, 
///например ApplicationDictionary<TKey, TValue>. 
///Класс должен предоставлять возможность добавления элемента в словарь,
///удаления элемента, получения элемента по ключу, получение списка всех ключей.

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
