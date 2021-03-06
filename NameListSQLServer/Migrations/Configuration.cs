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
            //p.acountNameが同じならば上書きされる
            context.persons.AddOrUpdate(p => p.personId
                , new Model.Person("toudou001", "藤堂",  "toudou@yahoo.co.jp", "09098887654", "特になし", DateTime.Now, DateTime.Now)
                , new Model.Person("minami001", "南",  "minami@yahoo.co.jp", "09098887655", "特になし", DateTime.Now, DateTime.Now)
                , new Model.Person("suto001", "須藤",  "suto@yahoo.co.jp", "09098887656", "特になし", DateTime.Now, DateTime.Now)
            );

        }
    }
}
