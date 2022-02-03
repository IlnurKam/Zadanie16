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
    class Maxprice
    {
        static void Main(string[] args)
        {
            string jsonString = String.Empty;
            using (StreamReader sr = new StreamReader("C:/Users/Илнур/Documents/Уку/Lab16/Products.json"))
            {
                jsonString = sr.ReadToEnd();
            }
            Products[] products = JsonSerializer.Deserialize<Products[]>(jsonString);

            Products maxProducts = products[0];
            foreach (Products e in products)
            {
                if (e.Price > maxProducts.Price)
                {
                    maxProducts = e;
                }
            }
            Console.WriteLine($"{maxProducts.Code} {maxProducts.Name} {maxProducts.Price}");
            Console.ReadKey();
        }
    }
}
