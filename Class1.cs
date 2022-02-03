using System;

public class Class1
{
    class Program
    {
        static void Main(string[] args)
        {
            string jsonString = String.Empty;
            using (StreamReader sr = new StreamReader("C:/Users/Илнур/Documents/Уку/Lab16/Products.json"))
            {
                jsonString = sr.ReadToEnd();
            }
            Products[] products = JsonSerializer.Deserialize<Employee[]>(jsonString);

            Products maxProducts = products[0];
            foreach (Products e in products)
            {
                if (e.Summa > maxProducts.Summa)
                {
                    maxProducts = e;
                }
            }
            Console.WriteLine($"{maxProducts.Code} {maxProducts.Name} {maxProducts.Price}");
            Console.ReadKey();
        }
    }
}
