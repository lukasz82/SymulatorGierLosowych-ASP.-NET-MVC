namespace SymulatorGierLosowych.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class nowamigracja : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.GameGenres",
                c => new
                    {
                        GameGenreId = c.Int(nullable: false, identity: true),
                        GenreName = c.String(),
                        Description = c.String(),
                        GenreImage = c.String(),
                        ShortDescription = c.String(),
                    })
                .PrimaryKey(t => t.GameGenreId);
            
            CreateTable(
                "dbo.Games",
                c => new
                    {
                        GameID = c.Int(nullable: false, identity: true),
                        GameName = c.String(nullable: false, maxLength: 150),
                        GameGenreId = c.Int(nullable: false),
                        DateAdded = c.DateTime(),
                        GameImage = c.String(),
                        Description = c.String(),
                    })
                .PrimaryKey(t => t.GameID)
                .ForeignKey("dbo.GameGenres", t => t.GameGenreId, cascadeDelete: true)
                .Index(t => t.GameGenreId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Games", "GameGenreId", "dbo.GameGenres");
            DropIndex("dbo.Games", new[] { "GameGenreId" });
            DropTable("dbo.Games");
            DropTable("dbo.GameGenres");
        }
    }
}
