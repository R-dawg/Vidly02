namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SetMembershipNames : DbMigration
    {
        public override void Up()
        {
            Sql("Update MembershipTypes SET MembershipName = 'Pay as You Go' WHERE id = 1");
            Sql("Update MembershipTypes SET MembershipName = 'Monthly' WHERE id = 2");
            Sql("Update MembershipTypes SET MembershipName = 'Quartarly' WHERE id = 3");
            Sql("Update MembershipTypes SET MembershipName = 'Annual' WHERE id = 4");
        }
        
        public override void Down()
        {
        }
    }
}
