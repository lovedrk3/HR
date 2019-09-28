using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using IBLL;
using IDAO;
using DAO;
using IOC;
namespace BLL
{
    /// <summary>
    /// 777788
    /// </summary>
    public class AttributeTypeBLL : IAttributeTypeBLL
    {
        IAttributeTypeDAO iat = IocCreate.CreateAttributeTypeDAL();

        public int AttributeNameAdd(AttributeNameModel at)
        {
            return iat.AttributeNameAdd(at);//2
        }

        public int AttributeNameDelete(AttributeNameModel at)
        {
            return iat.AttributeNameDelete(at);
        }

        public List<AttributeNameModel> AttributeNameSelect()
        {
            return iat.AttributeNameSelect();
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
            return iat.AttributeTypeSelect();
        }
        //
    }
}
