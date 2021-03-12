using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace evoh.yard.DTO
{
    public class PattiHeader
    {
        public int Id { get; set; }
        public int  CustomerId { get; set; }
        public string VNo { get; set; }
        public decimal TotalBag { get; set; }
        public decimal TotalKg { get; set; }
        public decimal TotalAMT { get; set; }

    }
}
