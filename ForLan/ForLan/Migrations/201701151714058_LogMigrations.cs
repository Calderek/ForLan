namespace ForLan.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class LogMigrations : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Logs",
                c => new
                    {
                        LogID = c.Int(nullable: false, identity: true),
                        Message = c.String(),
                        onCreated = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.LogID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Logs");
        }
    }
}
