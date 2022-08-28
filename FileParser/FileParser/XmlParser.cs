using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part1
{

    public class XmlParser : FileParser
    {
        public XmlParser(string filename) : base(filename)
        {

        }
        public override void Read()
        {
            Console.WriteLine($"{nameof(XmlParser)}: Файл {FileName}, был прочитан");
        }
        public override void Open()
        {
            Console.WriteLine($"{nameof(XmlParser)}: Файл {FileName}, был открыт");
        }
        public override void Analize()
        {
            Console.WriteLine($"{nameof(XmlParser)}: Файл {FileName}, был проанализирован");
        }
        public override void Close()
        {
            Console.WriteLine($"{nameof(XmlParser)}: Файл {FileName}, был закрыт");
        }

        public override string ParserFormat { get => $"{nameof(XmlParser)}: Файл {FileName}"; }



    }
}
