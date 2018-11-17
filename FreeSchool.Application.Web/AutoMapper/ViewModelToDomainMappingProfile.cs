using AutoMapper;
using FreeSchool.Application.Web.ViewModel;
using FreeSchool.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FreeSchool.Application.Web.AutoMapper
{
    public class ViewModelToDomainMappingProfile : Profile
    {
        public ViewModelToDomainMappingProfile()
        {
            CreateMap<PersonViewModel, Person>();
            CreateMap<StatusStudentViewModel, StatusStudent>();
            CreateMap<StudentViewModel, Student>();
            CreateMap<TypeStudentViewModel, TypeStudent>();
        }
    }
}