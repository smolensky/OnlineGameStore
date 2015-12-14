namespace OnlineGameStoreData.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class IdForComments : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("dbo.CommentEntities");
            AddColumn("dbo.CommentEntities", "Id", c => c.Int(nullable: false, identity: true));
            AlterColumn("dbo.CommentEntities", "Name", c => c.String());
            AddPrimaryKey("dbo.CommentEntities", "Id");
        }
        
        public override void Down()
        {
            DropPrimaryKey("dbo.CommentEntities");
            AlterColumn("dbo.CommentEntities", "Name", c => c.String(nullable: false, maxLength: 128));
            DropColumn("dbo.CommentEntities", "Id");
            AddPrimaryKey("dbo.CommentEntities", "Name");
        }
    }
}
