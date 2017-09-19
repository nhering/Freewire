namespace Freewire.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addEquipmentModelAttemptTwo : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.EquipmentModels",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Make = c.String(nullable: false),
                        Model = c.String(),
                        Distance = c.Int(nullable: false),
                        Bandwidth = c.Int(nullable: false),
                        License = c.Int(nullable: false),
                        Cost = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.EquipmentModels");
        }
    }
}
