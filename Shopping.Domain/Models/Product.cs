using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shopping.Domain.Models
{
    public abstract class Product
    {
        protected static int _id;
        
        public string Name { get; set; }
        public double PurchasePrice { get; set; }
        public double SalesPrice { get; set; }
        protected static int _count;
        protected static double TotalInCome { get; set; }

        public abstract void Sell();
        public abstract void ShowInfo();
    }
}
