namespace OnlineGameStoreData.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RemovedIds : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.GenreEntities", "GameGenreEntity_GameId", "dbo.GameGenreEntities");
            DropForeignKey("dbo.PlatformTypeEntities", "GamePlatformTypeEntity_GameId", "dbo.GamePlatformTypeEntities");
            DropIndex("dbo.GenreEntities", new[] { "GameGenreEntity_GameId" });
            DropIndex("dbo.PlatformTypeEntities", new[] { "GamePlatformTypeEntity_GameId" });
            RenameColumn(table: "dbo.GenreEntities", name: "GameGenreEntity_GameId", newName: "GameGenreEntity_GameName");
            RenameColumn(table: "dbo.PlatformTypeEntities", name: "GamePlatformTypeEntity_GameId", newName: "GamePlatformTypeEntity_GameName");
            DropPrimaryKey("dbo.CommentEntities");
            DropPrimaryKey("dbo.GameGenreEntities");
            DropPrimaryKey("dbo.GenreEntities");
            DropPrimaryKey("dbo.GamePlatformTypeEntities");
            DropPrimaryKey("dbo.PlatformTypeEntities");
            AddColumn("dbo.CommentEntities", "ParentName", c => c.String());
            AddColumn("dbo.GameGenreEntities", "GameName", c => c.String(nullable: false, maxLength: 128));
            AddColumn("dbo.GameGenreEntities", "GenreName", c => c.String());
            AddColumn("dbo.GenreEntities", "ParentGenre", c => c.String());
            AddColumn("dbo.GamePlatformTypeEntities", "GameName", c => c.String(nullable: false, maxLength: 128));
            AddColumn("dbo.GamePlatformTypeEntities", "TypeName", c => c.String());
            AlterColumn("dbo.CommentEntities", "Name", c => c.String(nullable: false, maxLength: 128));
            AlterColumn("dbo.GenreEntities", "Genre", c => c.String(nullable: false, maxLength: 128));
            AlterColumn("dbo.GenreEntities", "GameGenreEntity_GameName", c => c.String(maxLength: 128));
            AlterColumn("dbo.PlatformTypeEntities", "Type", c => c.String(nullable: false, maxLength: 128));
            AlterColumn("dbo.PlatformTypeEntities", "GamePlatformTypeEntity_GameName", c => c.String(maxLength: 128));
            AddPrimaryKey("dbo.CommentEntities", "Name");
            AddPrimaryKey("dbo.GameGenreEntities", "GameName");
            AddPrimaryKey("dbo.GenreEntities", "Genre");
            AddPrimaryKey("dbo.GamePlatformTypeEntities", "GameName");
            AddPrimaryKey("dbo.PlatformTypeEntities", "Type");
            CreateIndex("dbo.GenreEntities", "GameGenreEntity_GameName");
            CreateIndex("dbo.PlatformTypeEntities", "GamePlatformTypeEntity_GameName");
            AddForeignKey("dbo.GenreEntities", "GameGenreEntity_GameName", "dbo.GameGenreEntities", "GameName");
            AddForeignKey("dbo.PlatformTypeEntities", "GamePlatformTypeEntity_GameName", "dbo.GamePlatformTypeEntities", "GameName");
            DropColumn("dbo.CommentEntities", "Id");
            DropColumn("dbo.CommentEntities", "ParentId");
            DropColumn("dbo.GameGenreEntities", "GameId");
            DropColumn("dbo.GameGenreEntities", "GenreId");
            DropColumn("dbo.GenreEntities", "Id");
            DropColumn("dbo.GenreEntities", "ParentId");
            DropColumn("dbo.GamePlatformTypeEntities", "GameId");
            DropColumn("dbo.GamePlatformTypeEntities", "TypeId");
            DropColumn("dbo.PlatformTypeEntities", "Id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.PlatformTypeEntities", "Id", c => c.Int(nullable: false, identity: true));
            AddColumn("dbo.GamePlatformTypeEntities", "TypeId", c => c.Int(nullable: false));
            AddColumn("dbo.GamePlatformTypeEntities", "GameId", c => c.Int(nullable: false, identity: true));
            AddColumn("dbo.GenreEntities", "ParentId", c => c.Int());
            AddColumn("dbo.GenreEntities", "Id", c => c.Int(nullable: false, identity: true));
            AddColumn("dbo.GameGenreEntities", "GenreId", c => c.Int(nullable: false));
            AddColumn("dbo.GameGenreEntities", "GameId", c => c.Int(nullable: false, identity: true));
            AddColumn("dbo.CommentEntities", "ParentId", c => c.Int());
            AddColumn("dbo.CommentEntities", "Id", c => c.Int(nullable: false, identity: true));
            DropForeignKey("dbo.PlatformTypeEntities", "GamePlatformTypeEntity_GameName", "dbo.GamePlatformTypeEntities");
            DropForeignKey("dbo.GenreEntities", "GameGenreEntity_GameName", "dbo.GameGenreEntities");
            DropIndex("dbo.PlatformTypeEntities", new[] { "GamePlatformTypeEntity_GameName" });
            DropIndex("dbo.GenreEntities", new[] { "GameGenreEntity_GameName" });
            DropPrimaryKey("dbo.PlatformTypeEntities");
            DropPrimaryKey("dbo.GamePlatformTypeEntities");
            DropPrimaryKey("dbo.GenreEntities");
            DropPrimaryKey("dbo.GameGenreEntities");
            DropPrimaryKey("dbo.CommentEntities");
            AlterColumn("dbo.PlatformTypeEntities", "GamePlatformTypeEntity_GameName", c => c.Int());
            AlterColumn("dbo.PlatformTypeEntities", "Type", c => c.String());
            AlterColumn("dbo.GenreEntities", "GameGenreEntity_GameName", c => c.Int());
            AlterColumn("dbo.GenreEntities", "Genre", c => c.String());
            AlterColumn("dbo.CommentEntities", "Name", c => c.String());
            DropColumn("dbo.GamePlatformTypeEntities", "TypeName");
            DropColumn("dbo.GamePlatformTypeEntities", "GameName");
            DropColumn("dbo.GenreEntities", "ParentGenre");
            DropColumn("dbo.GameGenreEntities", "GenreName");
            DropColumn("dbo.GameGenreEntities", "GameName");
            DropColumn("dbo.CommentEntities", "ParentName");
            AddPrimaryKey("dbo.PlatformTypeEntities", "Id");
            AddPrimaryKey("dbo.GamePlatformTypeEntities", "GameId");
            AddPrimaryKey("dbo.GenreEntities", "Id");
            AddPrimaryKey("dbo.GameGenreEntities", "GameId");
            AddPrimaryKey("dbo.CommentEntities", "Id");
            RenameColumn(table: "dbo.PlatformTypeEntities", name: "GamePlatformTypeEntity_GameName", newName: "GamePlatformTypeEntity_GameId");
            RenameColumn(table: "dbo.GenreEntities", name: "GameGenreEntity_GameName", newName: "GameGenreEntity_GameId");
            CreateIndex("dbo.PlatformTypeEntities", "GamePlatformTypeEntity_GameId");
            CreateIndex("dbo.GenreEntities", "GameGenreEntity_GameId");
            AddForeignKey("dbo.PlatformTypeEntities", "GamePlatformTypeEntity_GameId", "dbo.GamePlatformTypeEntities", "GameId");
            AddForeignKey("dbo.GenreEntities", "GameGenreEntity_GameId", "dbo.GameGenreEntities", "GameId");
        }
    }
}
