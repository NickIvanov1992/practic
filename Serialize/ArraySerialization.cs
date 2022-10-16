using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.Text.Json;



public class ArraySerialization
    {
        public static void getserialize( Shape[] myArray)
        {
            Shape[]? desShape = null;
            Console.WriteLine("введите формат сериализации: json или xml");
            string? str = Console.ReadLine();

            if (str == "json")
            {
                Console.WriteLine("Введите имя файла сериализации");
                string? variable = Console.ReadLine();
            try
            {
                using (Stream stream = new FileStream(variable + ".json", FileMode.OpenOrCreate))
                {
                    JsonSerializer.Serialize<Shape[]>(stream, myArray);
                }

                Console.WriteLine("Введите имя файла десериализации");
                variable = Console.ReadLine();
                using (Stream stream = new FileStream(variable + ".json", FileMode.OpenOrCreate))
                {
                    desShape = JsonSerializer.Deserialize<Shape[]>(stream);
                }
            }
            catch(FormatException)
            {
               Console.WriteLine("Ошибка формата данных");
            } 
            }
            if (str == "xml")
            {
            Console.WriteLine("Введите имя файла сериализации");
            string? variable = Console.ReadLine();
            try
            {
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(Shape[]));
                using (Stream stream = new FileStream(variable + ".xml", FileMode.OpenOrCreate))
                {
                    xmlSerializer.Serialize(stream, myArray.ToArray());
                }

                Console.WriteLine("Введите имя файла десериализации");
                variable = Console.ReadLine();
                using (Stream stream = new FileStream(variable + ".xml", FileMode.OpenOrCreate))
                {
                    desShape = (Shape[]?)xmlSerializer.Deserialize(stream);
                }
            }
            catch(FormatException)
            {
                Console.WriteLine("Ошибка формата данных");
            }
            }
        // Newtonsoft.Json

        Console.WriteLine("Выполняется сериализация с пакетом Newtonsoft.Json ");
        string newtonsoft_str = Newtonsoft.Json.JsonConvert.SerializeObject(myArray);
        desShape = Newtonsoft.Json.JsonConvert.DeserializeObject<Shape[]>(newtonsoft_str);
    }
}

