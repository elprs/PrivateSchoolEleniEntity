namespace PrivateSchoolEleniEntity.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class dbStudentsMoreProperties : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Students", "PhotoUrl", c => c.String());
            AddColumn("dbo.Students", "Email", c => c.String());
            AddColumn("dbo.Students", "Telephone", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Students", "Telephone");
            DropColumn("dbo.Students", "Email");
            DropColumn("dbo.Students", "PhotoUrl");
        }
    }
}
