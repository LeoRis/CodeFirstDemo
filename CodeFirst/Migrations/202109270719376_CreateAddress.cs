namespace CodeFirst.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateAddress : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Addresses",
                c => new
                    {
                        AddressId = c.Int(nullable: false, identity: true),
                        Street = c.String(),
                        Number = c.String(),
                        PostalCode = c.String(),
                        City = c.String(),
                        State = c.String(),
                        Province = c.String(),
                        Country = c.String(),
                        IsActive = c.Int(),
                        IsDeleted = c.Int(),
                    })
                .PrimaryKey(t => t.AddressId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Addresses");
        }
    }
}
