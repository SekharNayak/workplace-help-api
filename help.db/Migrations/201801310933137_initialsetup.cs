namespace help.db.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initialsetup : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.AttachedItems",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FileType = c.String(),
                        Path = c.String(),
                        WorkNote_WorkNoteId = c.Guid(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.WorkNotes", t => t.WorkNote_WorkNoteId)
                .Index(t => t.WorkNote_WorkNoteId);
            
            CreateTable(
                "dbo.Issues",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Subject = c.String(),
                        Description = c.String(),
                        CreatedBy = c.Int(nullable: false),
                        CurrentStatus = c.String(),
                        CreatedOn = c.DateTime(nullable: false),
                        AssignedTeam_Id = c.Int(),
                        AssignedTo_Id = c.Int(),
                        Status_StatusId = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Teams", t => t.AssignedTeam_Id)
                .ForeignKey("dbo.Users", t => t.AssignedTo_Id)
                .ForeignKey("dbo.Status", t => t.Status_StatusId)
                .Index(t => t.AssignedTeam_Id)
                .Index(t => t.AssignedTo_Id)
                .Index(t => t.Status_StatusId);
            
            CreateTable(
                "dbo.Teams",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Email = c.String(),
                        EmployeeId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Status",
                c => new
                    {
                        StatusId = c.Int(nullable: false, identity: true),
                        StatusDescription = c.String(),
                    })
                .PrimaryKey(t => t.StatusId);
            
            CreateTable(
                "dbo.WorkNotes",
                c => new
                    {
                        WorkNoteId = c.Guid(nullable: false),
                        Note = c.String(),
                        Description = c.String(),
                        CreatedBy = c.Int(nullable: false),
                        Issue_Id = c.Int(),
                    })
                .PrimaryKey(t => t.WorkNoteId)
                .ForeignKey("dbo.Issues", t => t.Issue_Id)
                .Index(t => t.Issue_Id);
            
            CreateTable(
                "dbo.UserTeams",
                c => new
                    {
                        User_Id = c.Int(nullable: false),
                        Team_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.User_Id, t.Team_Id })
                .ForeignKey("dbo.Users", t => t.User_Id, cascadeDelete: true)
                .ForeignKey("dbo.Teams", t => t.Team_Id, cascadeDelete: true)
                .Index(t => t.User_Id)
                .Index(t => t.Team_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.WorkNotes", "Issue_Id", "dbo.Issues");
            DropForeignKey("dbo.AttachedItems", "WorkNote_WorkNoteId", "dbo.WorkNotes");
            DropForeignKey("dbo.Issues", "Status_StatusId", "dbo.Status");
            DropForeignKey("dbo.Issues", "AssignedTo_Id", "dbo.Users");
            DropForeignKey("dbo.Issues", "AssignedTeam_Id", "dbo.Teams");
            DropForeignKey("dbo.UserTeams", "Team_Id", "dbo.Teams");
            DropForeignKey("dbo.UserTeams", "User_Id", "dbo.Users");
            DropIndex("dbo.UserTeams", new[] { "Team_Id" });
            DropIndex("dbo.UserTeams", new[] { "User_Id" });
            DropIndex("dbo.WorkNotes", new[] { "Issue_Id" });
            DropIndex("dbo.Issues", new[] { "Status_StatusId" });
            DropIndex("dbo.Issues", new[] { "AssignedTo_Id" });
            DropIndex("dbo.Issues", new[] { "AssignedTeam_Id" });
            DropIndex("dbo.AttachedItems", new[] { "WorkNote_WorkNoteId" });
            DropTable("dbo.UserTeams");
            DropTable("dbo.WorkNotes");
            DropTable("dbo.Status");
            DropTable("dbo.Users");
            DropTable("dbo.Teams");
            DropTable("dbo.Issues");
            DropTable("dbo.AttachedItems");
        }
    }
}
