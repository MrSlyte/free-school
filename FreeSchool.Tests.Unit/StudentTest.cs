using Microsoft.VisualStudio.TestTools.UnitTesting;
using FreeSchool.Application.Web.Controllers;
using FreeSchool.Application.Web;
using FreeSchool.Application.Web.Interfaces;
using FreeSchool.Application.Web.ViewModel;
using FreeSchool.Application.Interfaces;
using FreeSchool.Application;
using FreeSchool.Domain.Entities;
using Ninject;

namespace FreeSchool.Tests.Unit
{
    [TestClass]
    public class StudentTest
    {
        private IStudentAppService _service;

        [TestInitialize]
        public void StudentTestInitialize()
        {
            IKernel kernel = NinjectWebCommon.CreateKernel();
            _service = kernel.Get<IStudentAppService>();
        }

        [TestMethod]
        public void TestSave()
        {
            Student student = new Student();
            student.Id = 0;
            student.IdentificationNumberSchool = "";
            student.Person = new Person();
            Assert.IsNotNull(_service.Add(student), "Student not created");
        }
    }
}
