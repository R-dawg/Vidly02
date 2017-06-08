namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateGenreTypes : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO GenreTypes (Id, Category) VALUES (1,'Comedy')");
            Sql("INSERT INTO GenreTypes (Id, Category) VALUES (2,'Action')");
            Sql("INSERT INTO GenreTypes (Id, Category) VALUES (3,'Family')");
            Sql("INSERT INTO GenreTypes (Id, Category) VALUES (4,'Romance')");
        }
        
        public override void Down()
        {
        }
    }
}
