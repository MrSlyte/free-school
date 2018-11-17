namespace FreeSchool.Infra.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Activity",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ModuleId = c.Int(nullable: false),
                        TypeActivityId = c.Int(nullable: false),
                        Name = c.String(maxLength: 250, unicode: false),
                        Description = c.String(maxLength: 250, unicode: false),
                        MinimumApprobation = c.String(maxLength: 250, unicode: false),
                        IsOnline = c.Boolean(nullable: false),
                        CreateDate = c.DateTime(nullable: false),
                        UpdateDate = c.DateTime(nullable: false),
                        DeleteDate = c.DateTime(),
                        IsDeleted = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Module", t => t.ModuleId)
                .ForeignKey("dbo.TypeActivity", t => t.TypeActivityId)
                .Index(t => t.ModuleId)
                .Index(t => t.TypeActivityId);
            
            CreateTable(
                "dbo.Module",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(maxLength: 250, unicode: false),
                        Description = c.String(maxLength: 250, unicode: false),
                        WorkLoad = c.Decimal(nullable: false, precision: 18, scale: 2),
                        IsOnline = c.Boolean(nullable: false),
                        IsDeleted = c.Boolean(nullable: false),
                        CreateDate = c.DateTime(nullable: false),
                        UpdateDate = c.DateTime(nullable: false),
                        DeleteDate = c.DateTime(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.TypeActivity",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(maxLength: 250, unicode: false),
                        Description = c.String(maxLength: 250, unicode: false),
                        IsDeleted = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Address",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        PersonId = c.Int(nullable: false),
                        TypeAddressId = c.Int(nullable: false),
                        Rua = c.String(maxLength: 250, unicode: false),
                        Bairro = c.String(maxLength: 250, unicode: false),
                        Cidade = c.String(maxLength: 250, unicode: false),
                        Uf = c.String(maxLength: 250, unicode: false),
                        Cep = c.String(maxLength: 250, unicode: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Person", t => t.PersonId)
                .ForeignKey("dbo.TypeAddress", t => t.TypeAddressId)
                .Index(t => t.PersonId)
                .Index(t => t.TypeAddressId);
            
            CreateTable(
                "dbo.Person",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(maxLength: 250, unicode: false),
                        IdentificationDocument = c.String(maxLength: 250, unicode: false),
                        BirthDate = c.DateTime(nullable: false),
                        CreateDate = c.DateTime(nullable: false),
                        UpdateDate = c.DateTime(nullable: false),
                        DeleteDate = c.DateTime(),
                        IsDeleted = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.TypeAddress",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(maxLength: 250, unicode: false),
                        Description = c.String(maxLength: 250, unicode: false),
                        IsDeleted = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Contact",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        TypeContactId = c.Int(nullable: false),
                        PersonId = c.Int(nullable: false),
                        Value = c.String(maxLength: 250, unicode: false),
                        IsOnline = c.Boolean(nullable: false),
                        IsDeleted = c.Boolean(nullable: false),
                        CreateDate = c.DateTime(nullable: false),
                        UpdateDate = c.DateTime(nullable: false),
                        DeleteDate = c.DateTime(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Person", t => t.PersonId)
                .ForeignKey("dbo.TypeContact", t => t.TypeContactId)
                .Index(t => t.TypeContactId)
                .Index(t => t.PersonId);
            
            CreateTable(
                "dbo.TypeContact",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(maxLength: 250, unicode: false),
                        Description = c.String(maxLength: 250, unicode: false),
                        IsDeleted = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Curse",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(maxLength: 250, unicode: false),
                        Description = c.String(maxLength: 250, unicode: false),
                        IsOnline = c.Boolean(nullable: false),
                        IsDeleted = c.Boolean(nullable: false),
                        CreateDate = c.DateTime(nullable: false),
                        UpdateDate = c.DateTime(nullable: false),
                        DeleteDate = c.DateTime(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Document",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        TypeDocumentId = c.Int(nullable: false),
                        PersonId = c.Int(nullable: false),
                        Value = c.String(maxLength: 250, unicode: false),
                        IsOnline = c.Boolean(nullable: false),
                        IsDeleted = c.Boolean(nullable: false),
                        CreateDate = c.DateTime(nullable: false),
                        UpdateDate = c.DateTime(nullable: false),
                        DeleteDate = c.DateTime(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.TypeDocument", t => t.TypeDocumentId)
                .Index(t => t.TypeDocumentId);
            
            CreateTable(
                "dbo.TypeDocument",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(maxLength: 250, unicode: false),
                        Description = c.String(maxLength: 250, unicode: false),
                        IsDeleted = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.FrequencyJob",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(maxLength: 250, unicode: false),
                        IsDeleted = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.ItemActivity",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ActivityId = c.Int(nullable: false),
                        Name = c.String(maxLength: 250, unicode: false),
                        ApprobationNoteId = c.Int(nullable: false),
                        CreateDate = c.DateTime(nullable: false),
                        UpdateDate = c.DateTime(nullable: false),
                        DeleteDate = c.DateTime(),
                        IsDeleted = c.Boolean(nullable: false),
                        TypeApprobationNote_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Activity", t => t.ActivityId)
                .ForeignKey("dbo.TypeApprobationNote", t => t.TypeApprobationNote_Id)
                .Index(t => t.ActivityId)
                .Index(t => t.TypeApprobationNote_Id);
            
            CreateTable(
                "dbo.TypeApprobationNote",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ApprobationNoteSchool = c.String(maxLength: 250, unicode: false),
                        ApprobationNoteSystem = c.Int(nullable: false),
                        IsDeleted = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Job",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        PersonId = c.Int(nullable: false),
                        TaskId = c.Int(nullable: false),
                        IsDeleted = c.Boolean(nullable: false),
                        FrequencyId = c.Int(nullable: false),
                        RepeatForever = c.Boolean(nullable: false),
                        EndJobDate = c.DateTime(),
                        CreateDate = c.DateTime(nullable: false),
                        UpdateDate = c.DateTime(nullable: false),
                        DeleteDate = c.DateTime(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.JobRole",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(maxLength: 250, unicode: false),
                        IsDeleted = c.Boolean(nullable: false),
                        CreateDate = c.DateTime(nullable: false),
                        UpdateDate = c.DateTime(nullable: false),
                        DeleteDate = c.DateTime(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.ModulePerCurse",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CurseId = c.Int(nullable: false),
                        ModuleId = c.Int(nullable: false),
                        IsDeleted = c.Boolean(nullable: false),
                        CreateDate = c.DateTime(nullable: false),
                        UpdateDate = c.DateTime(nullable: false),
                        DeleteDate = c.DateTime(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.PersonPerCurse",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        PersonId = c.Int(nullable: false),
                        CurseId = c.Int(nullable: false),
                        StartDate = c.DateTime(),
                        EndDate = c.DateTime(),
                        IsOnline = c.Boolean(nullable: false),
                        IsDeleted = c.Boolean(nullable: false),
                        CreateDate = c.DateTime(nullable: false),
                        UpdateDate = c.DateTime(nullable: false),
                        DeleteDate = c.DateTime(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Curse", t => t.CurseId)
                .ForeignKey("dbo.Person", t => t.PersonId)
                .Index(t => t.PersonId)
                .Index(t => t.CurseId);
            
            CreateTable(
                "dbo.Responsible",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        PersonId = c.Int(nullable: false),
                        Name = c.String(maxLength: 250, unicode: false),
                        BithDate = c.DateTime(nullable: false),
                        IsDeleted = c.Boolean(nullable: false),
                        CreateDate = c.DateTime(nullable: false),
                        UpdateDate = c.DateTime(nullable: false),
                        DeleteDate = c.DateTime(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Person", t => t.PersonId)
                .Index(t => t.PersonId);
            
            CreateTable(
                "dbo.School",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(maxLength: 250, unicode: false),
                        IdentificationDocument = c.String(maxLength: 250, unicode: false),
                        CompanyName = c.String(maxLength: 250, unicode: false),
                        IsOnline = c.Boolean(nullable: false),
                        IsDeleted = c.Boolean(nullable: false),
                        CreateDate = c.DateTime(nullable: false),
                        UpdateDate = c.DateTime(nullable: false),
                        DeleteDate = c.DateTime(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.StatusStudent",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(maxLength: 250, unicode: false),
                        IsDeleted = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Student",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        PersonId = c.Int(nullable: false),
                        TypeStudentId = c.Int(nullable: false),
                        RegisterDate = c.DateTime(),
                        UpdateDate = c.DateTime(),
                        IdentificationNumberSchool = c.String(maxLength: 250, unicode: false),
                        Status = c.Int(nullable: false),
                        CreateDate = c.DateTime(nullable: false),
                        DeleteDate = c.DateTime(),
                        IsDeleted = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Person", t => t.PersonId)
                .ForeignKey("dbo.TypeStudent", t => t.TypeStudentId)
                .Index(t => t.PersonId)
                .Index(t => t.TypeStudentId);
            
            CreateTable(
                "dbo.TypeStudent",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(maxLength: 250, unicode: false),
                        Description = c.String(maxLength: 250, unicode: false),
                        IsDeleted = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Task",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(maxLength: 250, unicode: false),
                        RemaningTime = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.TypeResponsible",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(maxLength: 250, unicode: false),
                        Description = c.String(maxLength: 250, unicode: false),
                        IsDeleted = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.User",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        PersonId = c.Int(nullable: false),
                        UserName = c.String(maxLength: 250, unicode: false),
                        Password = c.String(maxLength: 250, unicode: false),
                        CreateDate = c.DateTime(nullable: false),
                        UpdateDate = c.DateTime(nullable: false),
                        DeleteDate = c.DateTime(),
                        IsDeleted = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Worker",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        PersonId = c.Int(nullable: false),
                        SchoolId = c.Int(nullable: false),
                        JobRoleId = c.Int(nullable: false),
                        IsDeleted = c.Boolean(nullable: false),
                        CreateDate = c.DateTime(nullable: false),
                        UpdateDate = c.DateTime(),
                        DeleteDate = c.DateTime(),
                        ContractBeginDate = c.DateTime(nullable: false),
                        ContractEndDate = c.DateTime(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Student", "TypeStudentId", "dbo.TypeStudent");
            DropForeignKey("dbo.Student", "PersonId", "dbo.Person");
            DropForeignKey("dbo.Responsible", "PersonId", "dbo.Person");
            DropForeignKey("dbo.PersonPerCurse", "PersonId", "dbo.Person");
            DropForeignKey("dbo.PersonPerCurse", "CurseId", "dbo.Curse");
            DropForeignKey("dbo.ItemActivity", "TypeApprobationNote_Id", "dbo.TypeApprobationNote");
            DropForeignKey("dbo.ItemActivity", "ActivityId", "dbo.Activity");
            DropForeignKey("dbo.Document", "TypeDocumentId", "dbo.TypeDocument");
            DropForeignKey("dbo.Contact", "TypeContactId", "dbo.TypeContact");
            DropForeignKey("dbo.Contact", "PersonId", "dbo.Person");
            DropForeignKey("dbo.Address", "TypeAddressId", "dbo.TypeAddress");
            DropForeignKey("dbo.Address", "PersonId", "dbo.Person");
            DropForeignKey("dbo.Activity", "TypeActivityId", "dbo.TypeActivity");
            DropForeignKey("dbo.Activity", "ModuleId", "dbo.Module");
            DropIndex("dbo.Student", new[] { "TypeStudentId" });
            DropIndex("dbo.Student", new[] { "PersonId" });
            DropIndex("dbo.Responsible", new[] { "PersonId" });
            DropIndex("dbo.PersonPerCurse", new[] { "CurseId" });
            DropIndex("dbo.PersonPerCurse", new[] { "PersonId" });
            DropIndex("dbo.ItemActivity", new[] { "TypeApprobationNote_Id" });
            DropIndex("dbo.ItemActivity", new[] { "ActivityId" });
            DropIndex("dbo.Document", new[] { "TypeDocumentId" });
            DropIndex("dbo.Contact", new[] { "PersonId" });
            DropIndex("dbo.Contact", new[] { "TypeContactId" });
            DropIndex("dbo.Address", new[] { "TypeAddressId" });
            DropIndex("dbo.Address", new[] { "PersonId" });
            DropIndex("dbo.Activity", new[] { "TypeActivityId" });
            DropIndex("dbo.Activity", new[] { "ModuleId" });
            DropTable("dbo.Worker");
            DropTable("dbo.User");
            DropTable("dbo.TypeResponsible");
            DropTable("dbo.Task");
            DropTable("dbo.TypeStudent");
            DropTable("dbo.Student");
            DropTable("dbo.StatusStudent");
            DropTable("dbo.School");
            DropTable("dbo.Responsible");
            DropTable("dbo.PersonPerCurse");
            DropTable("dbo.ModulePerCurse");
            DropTable("dbo.JobRole");
            DropTable("dbo.Job");
            DropTable("dbo.TypeApprobationNote");
            DropTable("dbo.ItemActivity");
            DropTable("dbo.FrequencyJob");
            DropTable("dbo.TypeDocument");
            DropTable("dbo.Document");
            DropTable("dbo.Curse");
            DropTable("dbo.TypeContact");
            DropTable("dbo.Contact");
            DropTable("dbo.TypeAddress");
            DropTable("dbo.Person");
            DropTable("dbo.Address");
            DropTable("dbo.TypeActivity");
            DropTable("dbo.Module");
            DropTable("dbo.Activity");
        }
    }
}
