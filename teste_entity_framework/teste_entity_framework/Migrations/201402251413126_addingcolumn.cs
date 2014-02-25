namespace teste_entity_framework.data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addingcolumn : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Clients", "LastName", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Clients", "LastName");
        }
    }
}
