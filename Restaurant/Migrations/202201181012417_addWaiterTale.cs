namespace Restaurant.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addWaiterTale : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Waiters",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        lName = c.String(),
                        birthDate = c.DateTime(nullable: false),
                        WorkHour = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Waiters");
        }
    }
}
