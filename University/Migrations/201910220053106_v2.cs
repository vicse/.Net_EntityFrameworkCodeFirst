namespace University.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class v2 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Courses", "Points", c => c.Int(nullable: false));
            AddColumn("dbo.People", "Estado", c => c.Boolean());
            AddColumn("dbo.OfficeAssignments", "Activo", c => c.Boolean());
        }
        
        public override void Down()
        {
            DropColumn("dbo.OfficeAssignments", "Activo");
            DropColumn("dbo.People", "Estado");
            DropColumn("dbo.Courses", "Points");
        }
    }
}
