using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uygavazifa
{
    internal class Car
    {
        public Car(decimal id , string model , string brand, decimal price , decimal taxPercentage)
        {
            Id = id;
            Model = model;
            Brand = brand;
            Price = price;
            TaxPercentage = taxPercentage;

        }
        public decimal Id { get; set; }
        public string Model { get; set; }
        public string Brand { get; set; }
        public decimal Price { get; set; }
        public static decimal TaxPercentage { get; set; }
        public  decimal CalculaTetotal()
        {
            return Price-(Price*TaxPercentage/100);
        }
    }
}
