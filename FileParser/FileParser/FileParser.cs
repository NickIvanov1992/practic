using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;




    public abstract class FileParser                     // абстрактный класс FileParser
    {
        public readonly string  FileName;                  // поле только для чтения FileName
        public FileParser(string filename)        //  Конструктор должен принимать параметр типа string. 
        {                                         // В конструкторе необходимо устанавливать поле FileName
            FileName = filename;
        }

        public abstract void Read();                // создаем абстрактные методы

        public abstract void Open();

        public abstract void Analize();

        public abstract void Close();

        public virtual void Parse()                          // виртуальный метод Parse
        {
            Open(); Read(); Analize(); Close();
        }
        public  virtual string? ParserFormat { get; }                   // свойство только для чтения

        public static FileParser? GetParser(string fileName)
        {
            FileParser? nameType;

            if (fileName.EndsWith(".xml"))                     // если название файла оканчивается на .xml 
                nameType = new Part1.XmlParser(fileName);            // создаем экземпляр класса XmlParser
            else if (fileName.EndsWith(".rtf"))                // если название файла оканчивается на .rtf 
                nameType = new Part3.RtfParser(fileName);            // создаем экземпляр класса RtfParser
            else if (fileName.EndsWith(".html"))               // если название файла оканчивается на .html
                nameType = new Part2.HtmlParser(fileName);           // создаем экземпляр класса HtmlParser
            else
                nameType = null;                               // если парсера нет, то null

            return nameType;                                   // возврат текущего имени экземпляра класса

        }


    }


 
