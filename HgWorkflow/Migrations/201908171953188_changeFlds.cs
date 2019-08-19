namespace HgWorkflow.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class changeFlds : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.WorkOrders", "DateProposed");
            DropColumn("dbo.WorkOrders", "ProductToBeReturnedOn");
            DropColumn("dbo.WorkOrders", "AmountEstimate");
        }
        
        public override void Down()
        {
            AddColumn("dbo.WorkOrders", "AmountEstimate", c => c.Int(nullable: false));
            AddColumn("dbo.WorkOrders", "ProductToBeReturnedOn", c => c.DateTime());
            AddColumn("dbo.WorkOrders", "DateProposed", c => c.DateTime(nullable: false));
        }
    }
}
