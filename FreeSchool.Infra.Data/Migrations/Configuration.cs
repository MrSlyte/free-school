namespace FreeSchool.Infra.Data.Migrations
{
    using FreeSchool.Domain.Entities;
    using FreeSchool.Domain.Enums;
    using FreeSchool.Domain.Interfaces;
    using FreeSchool.Infra.Cross;
    using FreeSchool.Infra.Data.Context;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<FreeSchoolContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(FreeSchoolContext context)
        {
            context.TypeApprobationNote.AddOrUpdate(FillTypeApprobationNote().ToArray());
            context.TypeStudent.AddOrUpdate(FillTypeStudent().ToArray());
            context.TypeContact.AddOrUpdate(FillTypeContact().ToArray());
            context.TypeDocument.AddOrUpdate(FillTypeDocument().ToArray());
            context.TypeResponsible.AddOrUpdate(FillTypeResponsible().ToArray());
        }

        private List<TypeApprobationNote> FillTypeApprobationNote()
        {
            List<TypeApprobationNote> typeApprobationList = new List<TypeApprobationNote>();
            for (int i = 1; i <= 10; i++)
                typeApprobationList.Add(new TypeApprobationNote() { ApprobationNoteSchool = i.ToString(), ApprobationNoteSystem = i });
            return typeApprobationList;
        }

        private List<TypeStudent> FillTypeStudent()
        {
            List<TypeStudent> typeStudentList = new List<TypeStudent>();
            IEnumerable<EnumTypeStudent> values = EnumUtil.GetValues<EnumTypeStudent>();
            foreach (EnumTypeStudent value in values)
                typeStudentList.Add(new TypeStudent() { Name = value.ToString(), Description = value.GetDescription(), IsDeleted = false });
            return typeStudentList;
        }

        private List<TypeContact> FillTypeContact()
        {
            List<TypeContact> typeContactList = new List<TypeContact>();
            IEnumerable<EnumTypeContact> values = EnumUtil.GetValues<EnumTypeContact>();
            foreach (EnumTypeContact value in values)
                typeContactList.Add(new TypeContact() { Name = value.ToString(), Description = value.GetDescription(), IsDeleted = false });
            return typeContactList;
        }

        private List<TypeDocument> FillTypeDocument()
        {
            List<TypeDocument> typeDocumentList = new List<TypeDocument>();
            IEnumerable<EnumTypeDocument> values = EnumUtil.GetValues<EnumTypeDocument>();
            foreach (EnumTypeDocument value in values)
                typeDocumentList.Add(new TypeDocument() { Name = value.ToString(), Description = value.GetDescription(), IsDeleted = false });
            return typeDocumentList;
        }

        private List<TypeResponsible> FillTypeResponsible()
        {
            List<TypeResponsible> typeResponsibleList = new List<TypeResponsible>();
            IEnumerable<EnumTypeResponsible> values = EnumUtil.GetValues<EnumTypeResponsible>();
            foreach (EnumTypeResponsible value in values)
                typeResponsibleList.Add(new TypeResponsible() { Name = value.ToString(), Description = value.GetDescription(), IsDeleted = false });
            return typeResponsibleList;
        }
    }
}
