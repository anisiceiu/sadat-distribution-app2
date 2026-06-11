using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderDisburse.Models
{
    public class SaleOrder
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public string PackageName { get; set; }
        public int TotalPiece { get; set; }
        public int OrderCarton { get; set; }
        public int OrderPiece { get; set; }
        public int SOId { get; set; }
        public DateTime OnDate { get; set; }
        public int CompanyId { get; set; }
        public decimal TotalAmount { get; set; }
    }
}
