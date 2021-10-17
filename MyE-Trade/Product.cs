using System;
using System.Collections.Generic;
using System.Text;

namespace MyE_Trade
{
    class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal UnitPrice { get; set; }
        public int UnitInStock { get; set; }
        public string Description { get; set; }

        public Product(int Id, string Name,decimal UnitPrice, int UnitInStock,string Description)
        {
            this.Id = Id;
            this.Name = Name;
            this.UnitPrice = UnitPrice;
            this.UnitInStock = UnitInStock;
            this.Description = Description;
        }
    }
}
