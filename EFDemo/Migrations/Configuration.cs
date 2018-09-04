namespace EFDemo.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<EFDemo.EFCodeFirstDbContext>
    {
        public Configuration()
        {
            //��AutomaticMigrationEnable����Ϊtrue����ʾ�����Զ�Ǩ�Ƽ���
            AutomaticMigrationsEnabled = true;//false;
            //��AutomaticMigrationDataLossAllowed����Ϊtrue����ʾ�ڸ������ݱ�ṹ�ǣ�����ʧ���ݡ�
            AutomaticMigrationDataLossAllowed = true;
        }

        protected override void Seed(EFDemo.EFCodeFirstDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.
        }
    }
}
