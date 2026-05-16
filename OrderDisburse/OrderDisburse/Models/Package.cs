using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderDisburse.Models
{
    public class Package
    {
        public int Id { get; set; }
        public string PackageName { get; set; } = string.Empty;
        public int PackCount { get; set; }
        public int PiecePerPack { get; set; }
        public int TotalPiece { get; set; }
    }
}
