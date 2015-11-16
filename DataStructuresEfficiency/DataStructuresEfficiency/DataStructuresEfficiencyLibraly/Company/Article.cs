using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresEfficiencyLibraly.Company
{
    using System;
    public class Article : IComparable<Article>
    {
        private string chashedToStrig;

        public Article(string title, string barcode, string vendor, decimal price)
        {
            this.Title = title;
            this.Barcode = barcode;
            this.Vendor = vendor;
            this.Price = price;
        }

        public string Title { get; set; }

        public string Barcode { get; set; }

        public string Vendor { get; set; }

        public decimal Price { get; set; }

        public override string ToString()
        {
            return this.Title + " Barcode: " + this.Barcode + string.Format(" Price: {0:F2}", this.Price);
        }

        public int CompareTo(Article other)
        {
            return this.Price.CompareTo(other.Price);
        }
    }
}
