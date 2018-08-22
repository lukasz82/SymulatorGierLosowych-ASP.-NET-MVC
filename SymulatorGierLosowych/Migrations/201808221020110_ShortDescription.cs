namespace SymulatorGierLosowych.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ShortDescription : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.GameGenres", "ShortDescription", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.GameGenres", "ShortDescription");
        }
    }
}
