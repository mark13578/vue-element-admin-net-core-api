
using System;

namespace JMWebAPI.Models.Entity
{
    public class Order1
    {
        public int DocEntry { get; set; }
        public int DocNum { get; set; }
        public DateTime DocDate { get; set; }
        public DateTime OrderCreateTime { get; set; }
        public int CustomerID { get; set; }
        public string CustomerName { get; set; }
        public string CustomerContact { get; set; }
        public string CustomerPhone { get; set; }
        public string PS { get; set; }
        public string Casename { get; set; }
        public string Casetype { get; set; }
        public string Caseitem { get; set; }
        public string Print { get; set; }
        public string Paper1 { get; set; }
        public string Paper2 { get; set; }
        public string Paper3 { get; set; }
        public string Paper4 { get; set; }
        public int Quantity { get; set; }
        public string Unit { get; set; }
        public string Number { get; set; }
        public string StartNum { get; set; }
        public string Tear { get; set; }
        public int TearQty { get; set; }
        public string Pasty { get; set; }
        public string PastyDirection { get; set; }
        public int CopyQuantity { get; set; }
        public string Cover { get; set; }
        public string Hole { get; set; }
        public int HoleQuantity { get; set; }
        public string Nail { get; set; }
        public string Thickplate { get; set; }
        public string Preparation { get; set; }
        public string Vendor { get; set; }
    }
}

