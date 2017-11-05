namespace EventHubApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateGenresTable : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO GENRES (Id, Name) VALUES (1, 'Dev Talk')");
            Sql("INSERT INTO GENRES (Id, Name) VALUES (2, 'Workshop')");
            Sql("INSERT INTO GENRES (Id, Name) VALUES (3, 'Coding JAM')");
            Sql("INSERT INTO GENRES (Id, Name) VALUES (4, 'Conference')");
            Sql("INSERT INTO GENRES (Id, Name) VALUES (5, 'Hackathon')");
        }
        
        public override void Down()
        {
            Sql("DELETE FROM Genres WHERE Id IN (1, 2, 3, 4, 5)");
        }
    }
}
