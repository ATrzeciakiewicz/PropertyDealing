namespace PropertyDealing.DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddingIsSoldToProperty : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Property", "IsSold", c => c.Boolean());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Property", "IsSold");
        }
    }
}
