namespace OnlineGameStoreData.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class GameKeyFieldForComment : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.CommentEntities", name: "Game_Key", newName: "GameKey");
            RenameIndex(table: "dbo.CommentEntities", name: "IX_Game_Key", newName: "IX_GameKey");
        }
        
        public override void Down()
        {
            RenameIndex(table: "dbo.CommentEntities", name: "IX_GameKey", newName: "IX_Game_Key");
            RenameColumn(table: "dbo.CommentEntities", name: "GameKey", newName: "Game_Key");
        }
    }
}
