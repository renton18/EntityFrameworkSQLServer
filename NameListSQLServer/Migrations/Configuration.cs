namespace NameListSQLServer.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<NameListSQLServer.Model.NameListDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            ContextKey = "NameListSQLServer.Model.NameListDbContext";
        }

        protected override void Seed(NameListSQLServer.Model.NameListDbContext context)
        {
            //p.acountName�������Ȃ�Ώ㏑�������
            context.persons.AddOrUpdate(p => p.personId
                , new Model.Person("toudou001", "����",  "toudou@yahoo.co.jp", "09098887654", "���ɂȂ�", DateTime.Now, DateTime.Now)
                , new Model.Person("minami001", "��",  "minami@yahoo.co.jp", "09098887655", "���ɂȂ�", DateTime.Now, DateTime.Now)
                , new Model.Person("suto001", "�{��",  "suto@yahoo.co.jp", "09098887656", "���ɂȂ�", DateTime.Now, DateTime.Now)
            );

        }
    }
}
