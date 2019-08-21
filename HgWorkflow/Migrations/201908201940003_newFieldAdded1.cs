namespace HgWorkflow.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class newFieldAdded1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.WorkOrders", "sAcceptedRejectedStatus", c => c.Int(nullable: false));
            DropColumn("dbo.WorkOrders", "AcceptedRejectedStatus");
        }
        
        public override void Down()
        {
            AddColumn("dbo.WorkOrders", "AcceptedRejectedStatus", c => c.String());
            DropColumn("dbo.WorkOrders", "sAcceptedRejectedStatus");
        }
    }
}
