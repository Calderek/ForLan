namespace ForLan.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangeNameForeignKeyInDictionaryMigrations : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.DictionaryPlEngs", "EnglishWord_WordID", "dbo.EnglishWords");
            DropForeignKey("dbo.DictionaryPlEngs", "PolishWord_WordID", "dbo.PolishWords");
            DropForeignKey("dbo.DictionaryPlDes", "GermanWord_WordID", "dbo.GermanWords");
            DropForeignKey("dbo.DictionaryPlDes", "PolishWord_WordID", "dbo.PolishWords");
            DropIndex("dbo.DictionaryPlEngs", new[] { "EnglishWord_WordID" });
            DropIndex("dbo.DictionaryPlEngs", new[] { "PolishWord_WordID" });
            DropIndex("dbo.DictionaryPlDes", new[] { "GermanWord_WordID" });
            DropIndex("dbo.DictionaryPlDes", new[] { "PolishWord_WordID" });
            DropColumn("dbo.DictionaryPlEngs", "EnglishWordID");
            DropColumn("dbo.DictionaryPlEngs", "PolishWordID");
            DropColumn("dbo.DictionaryPlDes", "GermanWordID");
            DropColumn("dbo.DictionaryPlDes", "PolishWordID");
            RenameColumn(table: "dbo.DictionaryPlEngs", name: "EnglishWord_WordID", newName: "EnglishWordId");
            RenameColumn(table: "dbo.DictionaryPlEngs", name: "PolishWord_WordID", newName: "PolishWordId");
            RenameColumn(table: "dbo.DictionaryPlDes", name: "GermanWord_WordID", newName: "GermanWordID");
            RenameColumn(table: "dbo.DictionaryPlDes", name: "PolishWord_WordID", newName: "PolishWordID");
            AlterColumn("dbo.DictionaryPlEngs", "EnglishWordId", c => c.Int(nullable: false));
            AlterColumn("dbo.DictionaryPlEngs", "PolishWordId", c => c.Int(nullable: false));
            AlterColumn("dbo.DictionaryPlDes", "GermanWordID", c => c.Int(nullable: false));
            AlterColumn("dbo.DictionaryPlDes", "PolishWordID", c => c.Int(nullable: false));
            CreateIndex("dbo.DictionaryPlEngs", "PolishWordId");
            CreateIndex("dbo.DictionaryPlEngs", "EnglishWordId");
            CreateIndex("dbo.DictionaryPlDes", "PolishWordID");
            CreateIndex("dbo.DictionaryPlDes", "GermanWordID");
            AddForeignKey("dbo.DictionaryPlEngs", "EnglishWordId", "dbo.EnglishWords", "WordID", cascadeDelete: true);
            AddForeignKey("dbo.DictionaryPlEngs", "PolishWordId", "dbo.PolishWords", "WordID", cascadeDelete: true);
            AddForeignKey("dbo.DictionaryPlDes", "GermanWordID", "dbo.GermanWords", "WordID", cascadeDelete: true);
            AddForeignKey("dbo.DictionaryPlDes", "PolishWordID", "dbo.PolishWords", "WordID", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.DictionaryPlDes", "PolishWordID", "dbo.PolishWords");
            DropForeignKey("dbo.DictionaryPlDes", "GermanWordID", "dbo.GermanWords");
            DropForeignKey("dbo.DictionaryPlEngs", "PolishWordId", "dbo.PolishWords");
            DropForeignKey("dbo.DictionaryPlEngs", "EnglishWordId", "dbo.EnglishWords");
            DropIndex("dbo.DictionaryPlDes", new[] { "GermanWordID" });
            DropIndex("dbo.DictionaryPlDes", new[] { "PolishWordID" });
            DropIndex("dbo.DictionaryPlEngs", new[] { "EnglishWordId" });
            DropIndex("dbo.DictionaryPlEngs", new[] { "PolishWordId" });
            AlterColumn("dbo.DictionaryPlDes", "PolishWordID", c => c.Int());
            AlterColumn("dbo.DictionaryPlDes", "GermanWordID", c => c.Int());
            AlterColumn("dbo.DictionaryPlEngs", "PolishWordId", c => c.Int());
            AlterColumn("dbo.DictionaryPlEngs", "EnglishWordId", c => c.Int());
            RenameColumn(table: "dbo.DictionaryPlDes", name: "PolishWordID", newName: "PolishWord_WordID");
            RenameColumn(table: "dbo.DictionaryPlDes", name: "GermanWordID", newName: "GermanWord_WordID");
            RenameColumn(table: "dbo.DictionaryPlEngs", name: "PolishWordId", newName: "PolishWord_WordID");
            RenameColumn(table: "dbo.DictionaryPlEngs", name: "EnglishWordId", newName: "EnglishWord_WordID");
            AddColumn("dbo.DictionaryPlDes", "PolishWordID", c => c.Int(nullable: false));
            AddColumn("dbo.DictionaryPlDes", "GermanWordID", c => c.Int(nullable: false));
            AddColumn("dbo.DictionaryPlEngs", "PolishWordID", c => c.Int(nullable: false));
            AddColumn("dbo.DictionaryPlEngs", "EnglishWordID", c => c.Int(nullable: false));
            CreateIndex("dbo.DictionaryPlDes", "PolishWord_WordID");
            CreateIndex("dbo.DictionaryPlDes", "GermanWord_WordID");
            CreateIndex("dbo.DictionaryPlEngs", "PolishWord_WordID");
            CreateIndex("dbo.DictionaryPlEngs", "EnglishWord_WordID");
            AddForeignKey("dbo.DictionaryPlDes", "PolishWord_WordID", "dbo.PolishWords", "WordID");
            AddForeignKey("dbo.DictionaryPlDes", "GermanWord_WordID", "dbo.GermanWords", "WordID");
            AddForeignKey("dbo.DictionaryPlEngs", "PolishWord_WordID", "dbo.PolishWords", "WordID");
            AddForeignKey("dbo.DictionaryPlEngs", "EnglishWord_WordID", "dbo.EnglishWords", "WordID");
        }
    }
}
