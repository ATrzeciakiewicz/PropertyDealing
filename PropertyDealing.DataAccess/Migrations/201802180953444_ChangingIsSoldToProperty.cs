namespace PropertyDealing.DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangingIsSoldToProperty : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Property", "IsSold", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Property", "IsSold", c => c.Boolean());
        }
    }
}
