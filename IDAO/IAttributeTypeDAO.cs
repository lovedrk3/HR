using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
namespace IDAO
{
    public interface IAttributeTypeDAO
    {
        int AttributeNameAdd(AttributeNameModel at);
        int AttributeNameUpdate(AttributeNameModel at);
        int AttributeNameDelete(AttributeNameModel at);
        List<AttributeNameModel> AttributeNameSelect();
        List<AttributeTypeModel> AttributeTypeSelect();
        List<AttributeNameModel> AttributeNameSelectBy(int id);
        
    }
}
