using Cashbox.Models.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cashbox.Models.ViewModels
{
    public class BasketProduct: ModelBase
    {

        public BasketProduct() { }
        public BasketProduct(StoredProduct storedProduct)
        {
            Product = storedProduct.Product;
            Id = storedProduct.Product.Id;
            Code = storedProduct.Product.Code;
            Name = storedProduct.Name;
            Price = storedProduct.Product.Price;
            Rests = storedProduct.Count;
        }

        public Product Product { get; set; }
 
        public string Code { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public decimal Sum { get { return Math.Round(Count * Price, 2); } }
        public int Count { get; set; }
        public int Rests { get; set; }
    }
}
