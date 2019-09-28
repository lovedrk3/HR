using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace EFEntity
{
    public class MyDbContext:DbContext
    {
        public MyDbContext() : base("Data Source=.;Initial Catalog=HRDB;Integrated Security=True")
        {
           
        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Configurations.AddFromAssembly(Assembly.GetExecutingAssembly());
        }
        public DbSet<Users> Users { get; set; }
        public DbSet<AttributeType> AttributeType { get; set; }
        public DbSet<AttributeName> AttributeName { get; set; }
        public DbSet<SalarySetting> SalarySetting { get; set; }
        //I级机构
        public DbSet<Oneorgan> Oneorgan { get; set; }
        //II级机构
        public DbSet<Twoorgan> Twoorgan { get; set; }
        //III级机构
        public DbSet<Treeorgan> Treeorgan { get; set; }
        public DbSet<Post> Post { get; set; }
        
        public DbSet<PostClassify> PostClassify { get; set; }
    }
}
