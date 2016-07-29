namespace ContosoUniversity.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MaxLengthOnNames : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.Student", name: "FirstMidName", newName: "First Name");
            AlterColumn("dbo.Student", "LastName", c => c.String(nullable: false, maxLength: 50));
            AlterColumn("dbo.Student", "First Name", c => c.String(nullable: false, maxLength: 50));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Student", "First Name", c => c.String());
            AlterColumn("dbo.Student", "LastName", c => c.String());
            RenameColumn(table: "dbo.Student", name: "First Name", newName: "FirstMidName");
        }
    }
}
