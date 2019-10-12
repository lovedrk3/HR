using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
   public class CompensationProgramModel
    {
        public int Cpid { get; set; }

        public string CpName { get; set; }

        public decimal? CpMoney { get; set; }

        public string Ctid { get; set; }
    }
}
