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

        public string ProductName { get; set; }

        public string PackageName { get; set; }
        public int OrderCarton { get; set; }

        public int OrderPiece { get; set; }

        public int TotalPiece { get; set; }
        public string ReturnCarton { get; set; } = string.Empty;

        public string ReturnOrderPiece { get; set; } = string.Empty;

        public string ReturnTotalPiece { get; set; } = string.Empty;
    }
}
