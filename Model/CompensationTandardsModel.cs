using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Model
{
   public class CompensationTandardsModel
    {
        public string Ctid { get; set; }
        [Required(ErrorMessage = "请输薪酬标准名称")]
        public string CtName { get; set; }


        public Decimal? CtMoney { get; set; }
        [Required(ErrorMessage = "请输制定人")]
        public string CtMan { get; set; }
        [Required(ErrorMessage = "请输登记人")]
        public string Ctregist { get; set; }

        public DateTime? CtregistDate { get; set; }

        public string bz { get; set; }
        public string fhyj { get; set; }

        public int CtState { get; set; }
    }
}
