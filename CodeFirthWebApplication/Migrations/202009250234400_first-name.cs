namespace CodeFirthWebApplication.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class firstname : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.Students", name: "FistMidName", newName: "First Name");
            AlterColumn("dbo.Students", "LastName", c => c.String(maxLength: 10));
            AlterColumn("dbo.Students", "First Name", c => c.String(nullable: false, maxLength: 10));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Students", "First Name", c => c.String());
            AlterColumn("dbo.Students", "LastName", c => c.String());
            RenameColumn(table: "dbo.Students", name: "First Name", newName: "FistMidName");
        }
    }
}
