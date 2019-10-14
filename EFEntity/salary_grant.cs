using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFEntity
{
   public class salary_grant
    {

        public int sgr_id { get; set; } //主键，自动增长列                                                                      
        public string salary_grant_id { get; set; } //薪酬发放编号                                                                
        public string salary_standard_id { get; set; }  //薪酬标准单编号                                                            
        public int first_kind_id { get; set; } //一级机构编号                                                                  
        public string first_kind_name { get; set; } //一级机构名称                                                                
        public int second_kind_id { get; set; } //二级机构编号                                                                 
        public string second_kind_name { get; set; }  //二级机构名称                                                               
        public int third_kind_id { get; set; } //三级机构编号                                                                 
        public string third_kind_name { get; set; } //三级机构名称                                                                
        public int human_amount { get; set; } //总人数                                                                      
        public Decimal? salary_standard_sum { get; set; } //标准薪酬总金额                                                           
        public Decimal? salary_paid_sum { get; set; } //实发总金额                                                                 
        public string register { get; set; } //登记人                                                                          
        public DateTime? regist_time { get; set; } //登记时间                                                                      
        public string checker { get; set; } //复核人                                                                           
        public DateTime? check_time { get; set; } //复核时间                                                                       
        public int check_status { get; set; } //复核状态      
    }
}
