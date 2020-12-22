namespace AdminSystemCodeFirst.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using AdminSystemCodeFirst.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<AdminSystemCodeFirst.Models.AdminSystemCodeFirstContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(AdminSystemCodeFirst.Models.AdminSystemCodeFirstContext context)
        {
            context.BusinessUnits.AddOrUpdate(x => x.businessUnitId,
                new BusinessUnit()
                {
                    businessUnitId = 1,
                    businessUnitCode = "SCM",
                    title = "School of Computing",
                    description = "School of Computing are at the forefront of current technology. Trying to predict future advances is both exciting and challenging. There has never been a more exciting time to study with us.",
                    officeAddress1 = "Grieg Building",
                    officeAddresss2 = "Southfield Road",
                    officeAddress3 = "Middlesbrough",
                    officePostCode = "TS10 2NT",
                    officeContact = "Simon Stobart",
                    officePhone = "01642344600",
                    officeEmail = "scm@tees.ac.uk",
                    Active = true
                });

            context.Staffs.AddOrUpdate(x => x.staffId,
                new Staff()
                {
                    staffId = 1,
                    businessUnitId = 1,
                    staffCode = "u0000700",
                    firstName = "John",
                    middleName = "Jo",
                    lastName = "Smith",
                    dob = DateTime.Now,
                    startDate = DateTime.Now,
                    profile = "John is good at AI",
                    emailAddress = "j.smith@tees.ac.uk",
                    PhotoUrl = "url",
                    Active = true

                });


        }
    }
}

