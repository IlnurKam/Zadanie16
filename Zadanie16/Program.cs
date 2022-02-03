using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.IO;
using System.Text.Encodings.Web;
using System.Text.Unicode;

namespace Zadanie16
{
    class Program
    {
        public static object JsonConvert { get; private set; }

        static void Main(string[] args)
        {
            const int n = 5;
            Products[] products = new Products[n];

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Код товара");
                int code = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Название");
                string name = Console.ReadLine();
                Console.WriteLine("Цена");
                int price = Convert.ToInt32(Console.ReadLine());
                products[i] = new Products() { Code = code, Name = name, Price = price };
            }

            JsonSerializerOptions options = new JsonSerializerOptions()
            {
                Encoder = JavaScriptEncoder.Create(UnicodeRanges.BasicLatin, UnicodeRanges.Cyrillic),
                WriteIndented = true
            };
            string jsonString = JsonSerializer.Serialize(products, options);

            using (StreamWriter sw = new StreamWriter("C:/Users/Илнур/Documents/Уку/Lab16/Products.json"))
            {
                sw.WriteLine(jsonString);
            }
        }
    }

}