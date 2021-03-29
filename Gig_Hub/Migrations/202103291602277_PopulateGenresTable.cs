namespace Gig_Hub.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateGenresTable : DbMigration
    {
        public override void Up()
        {
            Sql("Insert into Genres Values ('Jazz')");
            Sql("Insert into Genres Values ('Blues')");
            Sql("Insert into Genres Values ('Rock')");
            Sql("Insert into Genres Values ('Country')");
        }

        public override void Down()
        {
            Sql("Delete from Genres Where Id in (1, 2, 3, 4)");
        }
    }
}
