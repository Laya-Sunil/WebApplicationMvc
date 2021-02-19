namespace WebApplicationMvc.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class columnNamechanged : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.Users", name: "Email Id", newName: "EmailId");
            AlterColumn("dbo.Users", "Gender", c => c.String(nullable: false));
            AlterColumn("dbo.Users", "Subscription", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Users", "Subscription", c => c.String());
            AlterColumn("dbo.Users", "Gender", c => c.String());
            RenameColumn(table: "dbo.Users", name: "EmailId", newName: "Email Id");
        }
    }
}
