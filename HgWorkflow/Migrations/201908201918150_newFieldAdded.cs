namespace HgWorkflow.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class newFieldAdded : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.WorkOrders", "AcceptedRejectedStatus", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.WorkOrders", "AcceptedRejectedStatus");
        }
    }
}
