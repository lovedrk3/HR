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
    public class AttributeTypeDAO : DaoBase<AttributeName>, IAttributeTypeDAO
    {
        public int AttributeNameAdd(AttributeNameModel at)
        {
            AttributeName a = new AttributeName() { ANID = at.ANID, ANName = at.ANName, ATID = at.ATID };
            return Add(a);
        }

        public int AttributeNameDelete(AttributeNameModel at)
        {
            AttributeName a = new AttributeName() { ANID = at.ANID, ANName = at.ANName, ATID = at.ATID };
            return Delete(a);
        }

        public List<AttributeNameModel> AttributeNameSelectBy(int id)
        {
            throw new NotImplementedException();
        }

        public int AttributeNameUpdate(AttributeNameModel at)
        {
            throw new NotImplementedException();
        }

        public List<AttributeTypeModel> AttributeTypeSelect()
        {
            MyDbContext db = new MyDbContext();
            List<AttributeType> list = db.AttributeType.Select(e=>e).ToList() ;
            List<AttributeTypeModel> list2 = new List<AttributeTypeModel>();
            foreach (AttributeType item in list)
            {
                AttributeTypeModel at = new AttributeTypeModel() { ATID=item.ATID,ATName=item.ATName};
                list2.Add(at);
            }
            return list2;
        }

        List<AttributeNameModel> IAttributeTypeDAO.AttributeNameSelect()
        {
            MyDbContext db = new MyDbContext();
            //db.AttributeName.AsNoTracking().Join(db.AttributeType, s => s.ATID, cc => cc.ATID, (s, cc) => new { s.ANID, s.ANName, cc.ATName }).ToList()
            var res = db.AttributeName.AsNoTracking().Join(db.AttributeType, s => s.ATID, cc => cc.ATID, (s, cc) => new { s.ANID, s.ANName, cc.ATName });
            List<AttributeNameModel> list2 = new List<AttributeNameModel>();
            foreach (var item in res)
            {
                AttributeNameModel sm = new AttributeNameModel() { ANID=item.ANID,ANName=item.ANName,ATName = item.ATName};
                list2.Add(sm);
            }
            return list2;
        }
    }
}
