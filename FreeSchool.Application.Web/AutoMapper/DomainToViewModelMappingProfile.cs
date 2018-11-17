using AutoMapper;
using FreeSchool.Application.Web.ViewModel;
using FreeSchool.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FreeSchool.Application.Web.AutoMapper
{
    public class DomainToViewModelMappingProfile : Profile
    {
        public DomainToViewModelMappingProfile()
        {
            CreateMap<Person, PersonViewModel>();
            CreateMap<StatusStudent, StatusStudentViewModel>();
            CreateMap<Student, StudentViewModel>();
            CreateMap<TypeStudent, TypeStudentViewModel>();
        }
    }
}