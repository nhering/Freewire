namespace Freewire.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class editEquipmentModel : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.EquipmentModels", "Distance", c => c.Double(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.EquipmentModels", "Distance", c => c.Int(nullable: false));
        }
    }
}
