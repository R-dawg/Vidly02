namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddPropertiesToMovie1 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Movies", "GenreType_Id", "dbo.GenreTypes");
            DropIndex("dbo.Movies", new[] { "GenreType_Id" });
            DropPrimaryKey("dbo.GenreTypes");
            AlterColumn("dbo.Movies", "GenreType_Id", c => c.Byte());
            AlterColumn("dbo.GenreTypes", "Id", c => c.Byte(nullable: false));
            AddPrimaryKey("dbo.GenreTypes", "Id");
            CreateIndex("dbo.Movies", "GenreType_Id");
            AddForeignKey("dbo.Movies", "GenreType_Id", "dbo.GenreTypes", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Movies", "GenreType_Id", "dbo.GenreTypes");
            DropIndex("dbo.Movies", new[] { "GenreType_Id" });
            DropPrimaryKey("dbo.GenreTypes");
            AlterColumn("dbo.GenreTypes", "Id", c => c.Int(nullable: false, identity: true));
            AlterColumn("dbo.Movies", "GenreType_Id", c => c.Int());
            AddPrimaryKey("dbo.GenreTypes", "Id");
            CreateIndex("dbo.Movies", "GenreType_Id");
            AddForeignKey("dbo.Movies", "GenreType_Id", "dbo.GenreTypes", "Id");
        }
    }
}
