using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IBLL
{
    public interface IAttributeTypeBLL
    {
        int AttributeNameAdd(AttributeNameModel at);
        int AttributeNameUpdate(AttributeNameModel at);
        int AttributeNameDelete(AttributeNameModel at);
        List<AttributeNameModel> AttributeNameSelect();
        List<AttributeTypeModel> AttributeTypeSelect();
    }
}
