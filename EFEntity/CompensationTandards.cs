using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFEntity
{
  public  class CompensationTandards
    {
        public string Ctid { get; set; }

        public string CtName { get; set; }


        public Decimal? CtMoney { get; set; }

        public string CtMan { get; set; }

        public string Ctregist{ get; set; } 

        public DateTime? CtregistDate { get; set; }

        public string bz { get; set; }
        public string fhyj { get; set; }

        public int CtState { get; set; }
    }
}
