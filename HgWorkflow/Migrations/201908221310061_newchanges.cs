namespace HgWorkflow.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class newchanges : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.WorkOrders", "sStatus", c => c.Int(nullable: false));
            DropColumn("dbo.WorkOrders", "Status");
        }
        
        public override void Down()
        {
            AddColumn("dbo.WorkOrders", "Status", c => c.String());
            DropColumn("dbo.WorkOrders", "sStatus");
        }
    }
}
