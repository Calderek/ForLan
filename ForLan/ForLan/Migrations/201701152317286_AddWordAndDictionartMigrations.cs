namespace ForLan.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddWordAndDictionartMigrations : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.DictionaryPlEngs",
                c => new
                    {
                        DictionaryID = c.Int(nullable: false, identity: true),
                        PolishWordID = c.Int(nullable: false),
                        EnglishWordID = c.Int(nullable: false),
                        EnglishWord_WordID = c.Int(),
                        PolishWord_WordID = c.Int(),
                    })
                .PrimaryKey(t => t.DictionaryID)
                .ForeignKey("dbo.EnglishWords", t => t.EnglishWord_WordID)
                .ForeignKey("dbo.PolishWords", t => t.PolishWord_WordID)
                .Index(t => t.EnglishWord_WordID)
                .Index(t => t.PolishWord_WordID);
            
            CreateTable(
                "dbo.EnglishWords",
                c => new
                    {
                        WordID = c.Int(nullable: false, identity: true),
                        Word = c.String(),
                    })
                .PrimaryKey(t => t.WordID);
            
            CreateTable(
                "dbo.PolishWords",
                c => new
                    {
                        WordID = c.Int(nullable: false, identity: true),
                        Word = c.String(),
                    })
                .PrimaryKey(t => t.WordID);
            
            CreateTable(
                "dbo.DictionaryPlDes",
                c => new
                    {
                        DictionaryId = c.Int(nullable: false, identity: true),
                        PolishWordID = c.Int(nullable: false),
                        GermanWordID = c.Int(nullable: false),
                        GermanWord_WordID = c.Int(),
                        PolishWord_WordID = c.Int(),
                    })
                .PrimaryKey(t => t.DictionaryId)
                .ForeignKey("dbo.GermanWords", t => t.GermanWord_WordID)
                .ForeignKey("dbo.PolishWords", t => t.PolishWord_WordID)
                .Index(t => t.GermanWord_WordID)
                .Index(t => t.PolishWord_WordID);
            
            CreateTable(
                "dbo.GermanWords",
                c => new
                    {
                        WordID = c.Int(nullable: false, identity: true),
                        Word = c.String(),
                    })
                .PrimaryKey(t => t.WordID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.DictionaryPlDes", "PolishWord_WordID", "dbo.PolishWords");
            DropForeignKey("dbo.DictionaryPlDes", "GermanWord_WordID", "dbo.GermanWords");
            DropForeignKey("dbo.DictionaryPlEngs", "PolishWord_WordID", "dbo.PolishWords");
            DropForeignKey("dbo.DictionaryPlEngs", "EnglishWord_WordID", "dbo.EnglishWords");
            DropIndex("dbo.DictionaryPlDes", new[] { "PolishWord_WordID" });
            DropIndex("dbo.DictionaryPlDes", new[] { "GermanWord_WordID" });
            DropIndex("dbo.DictionaryPlEngs", new[] { "PolishWord_WordID" });
            DropIndex("dbo.DictionaryPlEngs", new[] { "EnglishWord_WordID" });
            DropTable("dbo.GermanWords");
            DropTable("dbo.DictionaryPlDes");
            DropTable("dbo.PolishWords");
            DropTable("dbo.EnglishWords");
            DropTable("dbo.DictionaryPlEngs");
        }
    }
}
