using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part2
{

    public class HtmlParser : FileParser
    {
        public HtmlParser(string filename) : base(filename)

        {
        }

        public override void Read()
        {
            Console.WriteLine($"{nameof(HtmlParser)}: Файл {FileName}, был прочитан");
        }
        public override void Open()
        {
            Console.WriteLine($"{nameof(HtmlParser)}: Файл {FileName}, был открыт");
        }
        public override void Analize()
        {
            Console.WriteLine($"{nameof(HtmlParser)}: Файл {FileName}, был проанализирован");
        }
        public override void Close()
        {
            Console.WriteLine($"{nameof(HtmlParser)}: Файл {FileName}, был закрыт");
        }

        public override string ParserFormat { get => $"{nameof(HtmlParser)}: Файл {FileName}"; }

    }
}