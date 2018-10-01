namespace CatibilisimBlog.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class a1 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Makale", "SeoLink", c => c.String(nullable: false, maxLength: 50));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Makale", "SeoLink", c => c.String());
        }
    }
}
