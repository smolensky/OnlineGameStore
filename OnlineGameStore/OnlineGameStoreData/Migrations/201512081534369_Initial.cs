namespace OnlineGameStoreData.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.CommentEntities",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Body = c.String(),
                        ParentId = c.Int(),
                        Game_Key = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.GameEntities", t => t.Game_Key)
                .Index(t => t.Game_Key);
            
            CreateTable(
                "dbo.GameEntities",
                c => new
                    {
                        Key = c.String(nullable: false, maxLength: 128),
                        Name = c.String(),
                        Description = c.String(),
                    })
                .PrimaryKey(t => t.Key);
            
            CreateTable(
                "dbo.GameGenreEntities",
                c => new
                    {
                        GameId = c.Int(nullable: false, identity: true),
                        GenreId = c.Int(nullable: false),
                        Game_Key = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.GameId)
                .ForeignKey("dbo.GameEntities", t => t.Game_Key)
                .Index(t => t.Game_Key);
            
            CreateTable(
                "dbo.GenreEntities",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Genre = c.String(),
                        ParentId = c.Int(),
                        GameGenreEntity_GameId = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.GameGenreEntities", t => t.GameGenreEntity_GameId)
                .Index(t => t.GameGenreEntity_GameId);
            
            CreateTable(
                "dbo.GamePlatformTypeEntities",
                c => new
                    {
                        GameId = c.Int(nullable: false, identity: true),
                        TypeId = c.Int(nullable: false),
                        Game_Key = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.GameId)
                .ForeignKey("dbo.GameEntities", t => t.Game_Key)
                .Index(t => t.Game_Key);
            
            CreateTable(
                "dbo.PlatformTypeEntities",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Type = c.String(),
                        GamePlatformTypeEntity_GameId = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.GamePlatformTypeEntities", t => t.GamePlatformTypeEntity_GameId)
                .Index(t => t.GamePlatformTypeEntity_GameId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.PlatformTypeEntities", "GamePlatformTypeEntity_GameId", "dbo.GamePlatformTypeEntities");
            DropForeignKey("dbo.GamePlatformTypeEntities", "Game_Key", "dbo.GameEntities");
            DropForeignKey("dbo.GenreEntities", "GameGenreEntity_GameId", "dbo.GameGenreEntities");
            DropForeignKey("dbo.GameGenreEntities", "Game_Key", "dbo.GameEntities");
            DropForeignKey("dbo.CommentEntities", "Game_Key", "dbo.GameEntities");
            DropIndex("dbo.PlatformTypeEntities", new[] { "GamePlatformTypeEntity_GameId" });
            DropIndex("dbo.GamePlatformTypeEntities", new[] { "Game_Key" });
            DropIndex("dbo.GenreEntities", new[] { "GameGenreEntity_GameId" });
            DropIndex("dbo.GameGenreEntities", new[] { "Game_Key" });
            DropIndex("dbo.CommentEntities", new[] { "Game_Key" });
            DropTable("dbo.PlatformTypeEntities");
            DropTable("dbo.GamePlatformTypeEntities");
            DropTable("dbo.GenreEntities");
            DropTable("dbo.GameGenreEntities");
            DropTable("dbo.GameEntities");
            DropTable("dbo.CommentEntities");
        }
    }
}
