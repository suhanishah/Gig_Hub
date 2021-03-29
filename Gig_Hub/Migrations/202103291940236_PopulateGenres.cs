namespace Gig_Hub.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateGenres : DbMigration
    {
        public override void Up()
        {
            Sql("Insert into Genres Values ('Jazz')");
            Sql("Insert into Genres Values ('Blues')");

        }

        public override void Down()
        {
        }
    }
}
