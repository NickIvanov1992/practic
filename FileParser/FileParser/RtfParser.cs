using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part3
{
    public class RtfParser:FileParser
    {
        public RtfParser(string filename) : base(filename)
        {

        }
        public override void Read()
        {
            Console.WriteLine($"{nameof(RtfParser)}: Файл {FileName}, был прочитан");
        }
        public override void Open()
        {
            Console.WriteLine($"{nameof(RtfParser)}: Файл {FileName}, был открыт");
        }
        public override void Analize()
        {
            Console.WriteLine($"{nameof(RtfParser)}: Файл {FileName}, был проанализирован");
        }
        public override void Close()
        {
            Console.WriteLine($"{nameof(RtfParser)}: Файл {FileName}, был закрыт");
        }

        public override string ParserFormat { get => $"{nameof(RtfParser)}: Файл {FileName}"; }
    }
}
