using FreeSchool.Application.Interfaces;
using FreeSchool.Application.Web.ViewModel;
using FreeSchool.Domain.Entities;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using FreeSchool.Infra.Cross;
using FreeSchool.Application.Web.Interfaces;

namespace FreeSchool.Application.Web.Controllers
{
    public class StudentController : Controller, IStudentController
    {
        private readonly IStudentAppService _app;
        // GET: Student

        public StudentController(IStudentAppService app)
        {
            _app = app;
        }
        public ActionResult Index()
        {
            List<StudentViewModel> studentList = _app.List().MapTo<IEnumerable<StudentViewModel>>().ToList();
            return View(studentList);
        }


        // GET: Student/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Student/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(StudentViewModel studentViewModel)
        {
            if (ModelState.IsValid)
            {
                _app.Add(studentViewModel.MapTo<Student>());
                return RedirectToAction("Index");
            }
            return View();
        }

        // GET: Student/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Student/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, StudentViewModel collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Student/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Student/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, StudentViewModel collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
