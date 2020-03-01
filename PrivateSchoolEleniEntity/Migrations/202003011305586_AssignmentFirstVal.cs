namespace PrivateSchoolEleniEntity.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AssignmentFirstVal : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Assignments", "Title", c => c.String(nullable: false));
            AlterColumn("dbo.Assignments", "Description", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Assignments", "Description", c => c.String());
            AlterColumn("dbo.Assignments", "Title", c => c.String());
        }
    }
}
