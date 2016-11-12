namespace Books.Web.DataContexts.BookMigrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DefaultShema : DbMigration
    {
        public override void Up()
        {
            MoveTable(name: "dbo.Books", newSchema: "library");
        }
        
        public override void Down()
        {
            MoveTable(name: "library.Books", newSchema: "dbo");
        }
    }
}
