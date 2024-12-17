using Lombok.NET;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using Lombok.NET;


namespace Struct_home_work
{
    [AllArgsConstructor]
    internal struct Product
    {
        public string Name;// Наименование товара
        public int Quantity;// Количество
        public decimal Price;// Цена за единицу
        public decimal Discount;// Скидка в процентах
        public Category Category;// Категория товара
        
        
        // Конструктор структуры Product
        public Product(string name, int quantity, decimal price, decimal discount, Category category)
        {
            Name = name;
            Quantity = quantity;
            Price = price;
            Discount = discount;
            Category = category;
        }

        public void SetName(string Name) { this.Name = Name; }
        public string GetName() { return this.Name; }

        public void SetQuantity(int Quantity) { this.Quantity = Quantity; }
        public int GetQuantity() { return this.Quantity; }

        public void SetPrice(decimal Price) { this.Price = Price; }
        public decimal GetPrice() { return this.Price; }

        public void SetDiscount(decimal Discount) { this.Discount = Discount; }
        public decimal GetDiscount() { return this.Discount; }

        public void SetCategory(Category Category) { this.Category = Category; }
        public Category GetCategory() { return this.Category; }

        public Product()
        {
            Name = "bread";
            Quantity = 1;
            Price = 25;
            Discount = 0.1m;
            Category = 0;
        }
        public override string ToString()
        {
            //return Name + Quantity + Price + Discount + Category;
            return $"Наиенование товара: {Name} ({Category})\nКоличество: {Quantity},\nЦена за единицу: {Price },\nЦена за единицу с учетом скидки: {Price * Discount}";
        }
    }
}
