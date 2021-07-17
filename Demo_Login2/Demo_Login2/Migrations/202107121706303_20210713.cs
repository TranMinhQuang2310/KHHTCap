namespace Demo_Login2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _20210713 : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Accounts", "Discriminator");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Accounts", "Discriminator", c => c.String(nullable: false, maxLength: 128));
        }
    }
}
