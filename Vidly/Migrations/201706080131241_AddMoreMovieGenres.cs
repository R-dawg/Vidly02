namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddMoreMovieGenres : DbMigration
    {
        public override void Up()
        {
            Sql("SET IDENTITY_INSERT GenreTypes ON");
            Sql("INSERT INTO GenreTypes (Id, Category) VALUES (5,'Thriller')");
            Sql("INSERT INTO GenreTypes (Id, Category) VALUES (6,'Horror')");
            Sql("INSERT INTO GenreTypes (Id, Category) VALUES (7,'Fantasy')");
            Sql("SET IDENTITY_INSERT GenreTypes OFF");
        }
        
        public override void Down()
        {
        }
    }
}
