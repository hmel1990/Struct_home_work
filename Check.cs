using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lombok.NET;

namespace Struct_home_work
{
    [AllArgsConstructor]
    internal partial struct Check
    {
        private List<Product> list;

        public Check()
        { list = new List<Product>(); }

        public void AddToCheck(Product product)
        {
            list.Add(product);
        }

        public void Show()
        {
                Console.WriteLine("------------------Кассовый чек---------------------\n\n");
                Console.WriteLine($"Дата выдачи: {DateTime.Now}\n\n");
            foreach (Product product in list)
            {

                Console.WriteLine(product);
            }
            double count = 0;
            foreach (Product product in list)
            {
                count = count + (double)(product.Price * product.Discount);
            }
            Console.WriteLine("..............................................................");

            Console.WriteLine($"\nИТОГО: {count} грн");
        }
        public Product GetByIndex(int index)
        {
            return list[index];
        }

        public void ChangeProduct (int index, string name, int quantity, decimal price, decimal discount, Category category)
        {
            Product product = new Product(name,  quantity,  price,  discount, category);
            list[index] = product;
        }
    }
}
