using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IDAO;
using Unity;
using IBLL;
using Microsoft.Practices.Unity.Configuration;
using DAO;
using Model;
using System.Configuration;
namespace IOC
{
    public class IocCreate
    {
        #region Users
        public static IUsersDAO CreateUsersDAL()
        { 
            UnityContainer ioc = new UnityContainer();
            ioc.RegisterType<IUsersDAO, UsersDAO>();
            return ioc.Resolve<IUsersDAO>();
        }
        public static IUsersBLL CreateUsersBLL()
        {
            UnityContainer ioc = new UnityContainer();
            //把Unity文件转换为文件对象
            ExeConfigurationFileMap ef = new ExeConfigurationFileMap();
            ef.ExeConfigFilename = @"D:\Visual Studio 2015\MVC\HR\UI\Unity.config";
            //把文件对象转换为配置对象
            Configuration cf = ConfigurationManager.OpenMappedExeConfiguration(ef, ConfigurationUserLevel.None);
            //读取Unity节点(业务逻辑层的块)
            UnityConfigurationSection cs = (UnityConfigurationSection)cf.GetSection("unity");
            //容器里加载业务逻辑层的配置块
            ioc.LoadConfiguration(cs, "containerTwo");
            return ioc.Resolve<IUsersBLL>("UsersBLL");
        }
        #endregion
        #region AttributeType
        public static IAttributeTypeDAO CreateAttributeTypeDAL()
        {
            UnityContainer ioc = new UnityContainer();
            ioc.RegisterType<IAttributeTypeDAO, AttributeTypeDAO>();
            return ioc.Resolve<IAttributeTypeDAO>();
        }
        public static IAttributeTypeBLL CreateAttributeTypeBLL()
        {
            UnityContainer ioc = new UnityContainer();
            ExeConfigurationFileMap ef = new ExeConfigurationFileMap();
            ef.ExeConfigFilename = @"D:\Visual Studio 2015\MVC\HR\UI\Unity.config";
            Configuration cf = ConfigurationManager.OpenMappedExeConfiguration(ef, ConfigurationUserLevel.None);
            UnityConfigurationSection cs = (UnityConfigurationSection)cf.GetSection("unity");
            ioc.LoadConfiguration(cs, "containerTwo");
            return ioc.Resolve<IAttributeTypeBLL>("AttributeTypeBLL");
        }
        #endregion
        #region SalarySetting
        public static ISalarySettingDAO CreateSalarySettingDAL()
        {
            UnityContainer ioc = new UnityContainer();
            ioc.RegisterType<ISalarySettingDAO, SalarySettingDAO>();
            return ioc.Resolve<ISalarySettingDAO>();
        }
        public static ISalarySettingBLL CreateSalarySettingBLL()
        {
            UnityContainer ioc = new UnityContainer();
            ExeConfigurationFileMap ef = new ExeConfigurationFileMap();
            ef.ExeConfigFilename = @"D:\Visual Studio 2015\MVC\HR\UI\Unity.config";
            Configuration cf = ConfigurationManager.OpenMappedExeConfiguration(ef, ConfigurationUserLevel.None);
            UnityConfigurationSection cs = (UnityConfigurationSection)cf.GetSection("unity");
            ioc.LoadConfiguration(cs, "containerTwo");
            return ioc.Resolve<ISalarySettingBLL>("SalarySettingBLL");
        }
        #endregion
        #region Oneorgan
        public static IOneorganDAO CreateOneorganDAL()
        {
            UnityContainer ioc = new UnityContainer();
            ioc.RegisterType<IOneorganDAO, OneorganDAO>();
            return ioc.Resolve<IOneorganDAO>();
        }


        public static IOneorganBLL CreateOneorganBLL()
        {
            UnityContainer ioc = new UnityContainer();
            ExeConfigurationFileMap ef = new ExeConfigurationFileMap();
            ef.ExeConfigFilename = @"D:\Visual Studio 2015\MVC\HR\UI\Unity.config";
            Configuration cf = ConfigurationManager.OpenMappedExeConfiguration(ef, ConfigurationUserLevel.None);
            UnityConfigurationSection cs = (UnityConfigurationSection)cf.GetSection("unity");
            ioc.LoadConfiguration(cs, "containerTwo");
            return ioc.Resolve<IOneorganBLL>("OneorganBLL");
        }
        #endregion
        #region Twoorgan
        public static ITwoorganDAO CreateTwoorganDAL()
        {
            UnityContainer ioc = new UnityContainer();
            ioc.RegisterType<ITwoorganDAO, TwoorganDAO>();
            return ioc.Resolve<ITwoorganDAO>();
        }
        public static ITwoorganBLL CreateTwoorganBLL()
        {
            UnityContainer ioc = new UnityContainer();
            ExeConfigurationFileMap ef = new ExeConfigurationFileMap();
            ef.ExeConfigFilename = @"D:\Visual Studio 2015\MVC\HR\UI\Unity.config";
            Configuration cf = ConfigurationManager.OpenMappedExeConfiguration(ef, ConfigurationUserLevel.None);
            UnityConfigurationSection cs = (UnityConfigurationSection)cf.GetSection("unity");
            ioc.LoadConfiguration(cs, "containerTwo");
            return ioc.Resolve<ITwoorganBLL>("TwoorganBLL");
        } 
        #endregion
        #region Post 
        public static IPostDAO CreatePostDAL()
        {
            UnityContainer ioc = new UnityContainer();
            ioc.RegisterType<IPostDAO, PostDAO>();
            return ioc.Resolve<IPostDAO>();
        }
        public static IPostBLL CreatePostBLL()
        {
            UnityContainer ioc = new UnityContainer();
            ExeConfigurationFileMap ef = new ExeConfigurationFileMap();
            ef.ExeConfigFilename = @"D:\Visual Studio 2015\MVC\HR\UI\Unity.config";
            Configuration cf = ConfigurationManager.OpenMappedExeConfiguration(ef, ConfigurationUserLevel.None);
            UnityConfigurationSection cs = (UnityConfigurationSection)cf.GetSection("unity");
            ioc.LoadConfiguration(cs, "containerTwo");
            return ioc.Resolve<IPostBLL>("PostBLL");
        }
        #region Treeorgan
        public static ITreeorganDAO CreateTreeorganDAL()
        {
            UnityContainer ioc = new UnityContainer();
            ioc.RegisterType<ITreeorganDAO, TreeorganDAO>();
            return ioc.Resolve<ITreeorganDAO>();
        }


        public static ITreeorganBLL CreateTreeorganBLL()
        {
            UnityContainer ioc = new UnityContainer();
            //把Unity文件转换为文件对象
            ExeConfigurationFileMap ef = new ExeConfigurationFileMap();
            ef.ExeConfigFilename = @"D:\Visual Studio 2015\MVC\HR\UI\Unity.config";
            //把文件对象转换为配置对象
            Configuration cf = ConfigurationManager.OpenMappedExeConfiguration(ef, ConfigurationUserLevel.None);
            //读取Unity节点(业务逻辑层的块)
            UnityConfigurationSection cs = (UnityConfigurationSection)cf.GetSection("unity");
            //容器里加载业务逻辑层的配置块
            ioc.LoadConfiguration(cs, "containerTwo");
            return ioc.Resolve<ITreeorganBLL>("TreeorganBLL");
        } 
        #endregion
        #endregion
        #region 职位分类
        public static IPostClassifyDAO CreatePostClassifyDAL()
        {
            UnityContainer ioc = new UnityContainer();
            ioc.RegisterType<IPostClassifyDAO, PostClassifyDAO>();
            return ioc.Resolve<IPostClassifyDAO>();
        }
        public static IPostClassifyBLL CreatePostClassifyBLL()
        {
            UnityContainer ioc = new UnityContainer();
            //把Unity文件转换为文件对象
            ExeConfigurationFileMap ef = new ExeConfigurationFileMap();
            ef.ExeConfigFilename = @"D:\Visual Studio 2015\MVC\HR\UI\Unity.config";
            //把文件对象转换为配置对象
            Configuration cf = ConfigurationManager.OpenMappedExeConfiguration(ef, ConfigurationUserLevel.None);
            //读取Unity节点(业务逻辑层的块)
            UnityConfigurationSection cs = (UnityConfigurationSection)cf.GetSection("unity");
            //容器里加载业务逻辑层的配置块
            ioc.LoadConfiguration(cs, "containerTwo");
            return ioc.Resolve<IPostClassifyBLL>("PostClassifyBLL");
        }
        #endregion
    }
}
