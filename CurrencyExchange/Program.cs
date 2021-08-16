using ExchangeService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurrencyExchange
{
    class Program
    {
        static void Main(string[] args)
        {
            //var v = Convertor.Convert(Enum.Parse(typeof(CurrencyEnum), "EUR"), Enum.Parse(typeof(CurrencyEnum), "USD", true), 2);
            Console.ReadLine();
            string[] arguments = Environment.GetCommandLineArgs();
            if (args.Length != 0)
            {
                Console.WriteLine(args.Length);
                return;
            }

            Convertor convertor = new Convertor();                

            var v = convertor.Convert(CurrencyEnum.EUR, CurrencyEnum.USD, 2);

            Console.WriteLine(v);
        }
    }
}
