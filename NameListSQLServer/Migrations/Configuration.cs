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
            //p.acountNameÇ™ìØÇ∂Ç»ÇÁÇŒè„èëÇ´Ç≥ÇÍÇÈ
            context.persons.AddOrUpdate(p => p.personId
                , new Model.Person("toudou001", "ì°ì∞",  "toudou@yahoo.co.jp", "09098887654", "ì¡Ç…Ç»Çµ", DateTime.Now, DateTime.Now)
                , new Model.Person("minami001", "ìÏ",  "minami@yahoo.co.jp", "09098887655", "ì¡Ç…Ç»Çµ", DateTime.Now, DateTime.Now)
                , new Model.Person("suto001", "ê{ì°",  "suto@yahoo.co.jp", "09098887656", "ì¡Ç…Ç»Çµ", DateTime.Now, DateTime.Now)
            );

        }
    }
}
