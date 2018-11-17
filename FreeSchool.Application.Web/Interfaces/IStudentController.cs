using FreeSchool.Application.Web.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FreeSchool.Application.Web.Interfaces
{
    public interface IStudentController
    {
        ActionResult Index();
        ActionResult Create();
        ActionResult Create(StudentViewModel studentViewModel);
        ActionResult Edit(int id);
        ActionResult Edit(int id, StudentViewModel collection);
        ActionResult Delete(int id);
        ActionResult Delete(int id, StudentViewModel collection);

    }
}