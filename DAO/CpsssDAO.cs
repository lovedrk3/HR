using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using IDAO;
using EFEntity;


namespace DAO
{
    public class CpsssDAO : DaoBase<Cpsss>, ICpsssDAO
    {
        public List<CpsssModel> CtSelect()
        {
            
            MyDbContext db = new MyDbContext();
            List<Cpsss> list = Select();
            List<CpsssModel> list2 = new List<CpsssModel>();
            foreach (Cpsss item in list)
            {
                CpsssModel sm = new CpsssModel() {id = item.id, CpName = item.CpName};
                list2.Add(sm);
            }
            return list2;
        
    }
    }
}
