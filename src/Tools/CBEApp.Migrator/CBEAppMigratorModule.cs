using System.Data.Entity;
using System.Reflection;
using Abp.Modules;
using CBEApp.EntityFramework;

namespace CBEApp.Migrator
{
    [DependsOn(typeof(CBEAppDataModule))]
    public class CBEAppMigratorModule : AbpModule
    {
        public override void PreInitialize()
        {
            Database.SetInitializer<CBEAppDbContext>(null);

            Configuration.BackgroundJobs.IsJobExecutionEnabled = false;
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}