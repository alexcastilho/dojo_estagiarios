namespace AutoInsurance.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addTableProposal : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Insureds",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FirstName = c.String(),
                        LastName = c.String(),
                        Age = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Cars",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Model = c.String(),
                        Manufacturer = c.String(),
                        PhotoUrl = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Proposals",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Value = c.Int(nullable: false),
                        Car_Id = c.Int(),
                        Insured_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Cars", t => t.Car_Id)
                .ForeignKey("dbo.Insureds", t => t.Insured_Id)
                .Index(t => t.Car_Id)
                .Index(t => t.Insured_Id);
            
        }
        
        public override void Down()
        {
            DropIndex("dbo.Proposals", new[] { "Insured_Id" });
            DropIndex("dbo.Proposals", new[] { "Car_Id" });
            DropForeignKey("dbo.Proposals", "Insured_Id", "dbo.Insureds");
            DropForeignKey("dbo.Proposals", "Car_Id", "dbo.Cars");
            DropTable("dbo.Proposals");
            DropTable("dbo.Cars");
            DropTable("dbo.Insureds");
        }
    }
}
