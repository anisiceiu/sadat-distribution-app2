using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderDisburse
{
    public class SalesReportVM
    {
        public int ProductId { get; set; }

        public string ProductName { get; set; } = string.Empty;
        public decimal UnitPrice { get; set; } = 0;
        public string PackageName { get; set; } = string.Empty;
        public int OrderCarton { get; set; }

        public int OrderPiece { get; set; }

        public int TotalPiece { get; set; }
        public decimal TotalAmount { get; set; }
        public string ReturnCarton { get; set; } = string.Empty;

        public string ReturnOrderPiece { get; set; } = string.Empty;

        public string ReturnTotalPiece { get; set; } = string.Empty;
        public string ReturnTotalAmount { get; set; } = string.Empty;
    }

    public class SalesOrderReportVM
    {
        public int ProductId { get; set; }

        public string ProductName { get; set; } = string.Empty;
        public decimal UnitPrice { get; set; } = 0;
        public string PackageName { get; set; } = string.Empty;
        public int OrderCarton { get; set; }

        public int OrderPiece { get; set; }

        public int TotalPiece { get; set; }
        public decimal TotalAmount { get; set; } = 0;
        public string ReturnCarton { get; set; } = string.Empty;

        public string ReturnOrderPiece { get; set; } = string.Empty;

        public string ReturnTotalPiece { get; set; } = string.Empty;
        public string ReturnTotalAmount { get; set; } = string.Empty;
    }
}
