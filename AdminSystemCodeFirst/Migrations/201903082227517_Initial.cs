namespace AdminSystemCodeFirst.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.BusinessUnits",
                c => new
                    {
                        businessUnitId = c.Int(nullable: false, identity: true),
                        businessUnitCode = c.String(),
                        title = c.String(),
                        description = c.String(),
                        officeAddress1 = c.String(),
                        officeAddresss2 = c.String(),
                        officeAddress3 = c.String(),
                        officePostCode = c.String(),
                        officeContact = c.String(),
                        officePhone = c.String(),
                        officeEmail = c.String(),
                        Active = c.Boolean(),
                    })
                .PrimaryKey(t => t.businessUnitId);
            
            CreateTable(
                "dbo.Staffs",
                c => new
                    {
                        staffId = c.Int(nullable: false, identity: true),
                        businessUnitId = c.Int(nullable: false),
                        staffCode = c.String(),
                        firstName = c.String(),
                        middleName = c.String(),
                        lastName = c.String(),
                        dob = c.DateTime(nullable: false),
                        startDate = c.DateTime(nullable: false),
                        profile = c.String(),
                        emailAddress = c.String(),
                        PhotoUrl = c.String(),
                        Active = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.staffId)
                .ForeignKey("dbo.BusinessUnits", t => t.businessUnitId, cascadeDelete: true)
                .Index(t => t.businessUnitId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Staffs", "businessUnitId", "dbo.BusinessUnits");
            DropIndex("dbo.Staffs", new[] { "businessUnitId" });
            DropTable("dbo.Staffs");
            DropTable("dbo.BusinessUnits");
        }
    }
}
