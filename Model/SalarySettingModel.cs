using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
namespace Model
{
    public class SalarySettingModel
    {
        public int SID { get; set; }
        [Required(ErrorMessage ="薪酬项目名不能为空")]
        public string SName { get; set; }
    }
}
