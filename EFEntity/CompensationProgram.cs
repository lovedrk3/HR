using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFEntity
{
   public class CompensationProgram
    {
        public int Cpid { get; set; }

        public string CpName { get; set; }

        public decimal? CpMoney { get; set; }

        public string Ctid { get; set; }
    }
}
