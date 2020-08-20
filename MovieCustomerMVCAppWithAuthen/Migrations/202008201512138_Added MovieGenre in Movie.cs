namespace MovieCustomerMVCAppWithAuthen.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedMovieGenreinMovie : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Movies", "MovieGenre", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Movies", "MovieGenre");
        }
    }
}
