namespace NameListSQLServer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.m_persons",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        personId = c.String(nullable: false, maxLength: 100),
                        personName = c.String(nullable: false, maxLength: 100),
                        mailAddress = c.String(),
                        phoneNumber = c.String(maxLength: 20),
                        detail = c.String(maxLength: 200),
                        createdDatetime = c.DateTime(nullable: false),
                        updatedDatetime = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.m_persons");
        }
    }
}
