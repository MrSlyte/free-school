using FreeSchool.Application.Web;
using Microsoft.Web.Infrastructure.DynamicModuleHelper;
using Ninject;
using Ninject.Modules;
using Ninject.Web.Common;
using Ninject.Web.Common.WebHost;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Web;
using System.Linq;
using FreeSchool.Application.Interfaces;
using FreeSchool.Domain.Interfaces.Services;
using FreeSchool.Domain.Services;
using FreeSchool.Domain.Interfaces.Repositories;
using FreeSchool.Infra.Data.Repositories;

[assembly: WebActivatorEx.PreApplicationStartMethod(typeof(NinjectWebCommon), "Start")]
[assembly: WebActivatorEx.ApplicationShutdownMethodAttribute(typeof(NinjectWebCommon), "Stop")]

namespace FreeSchool.Ninject
{
    public static class NinjectWebCommon
    {
        private static readonly Bootstrapper bootstrapper = new Bootstrapper();

        public static void Start()
        {
            DynamicModuleUtility.RegisterModule(typeof(OnePerRequestHttpModule));
            DynamicModuleUtility.RegisterModule(typeof(NinjectHttpModule));
            bootstrapper.Initialize(CreateKernel);
        }

        public static void Stop()
        {
            bootstrapper.ShutDown();
        }

        public static IKernel CreateKernel()
        {
            var kernel = new StandardKernel();
            kernel.Bind<Func<IKernel>>().ToMethod(ctx => () => new Bootstrapper().Kernel);
            kernel.Bind<IHttpModule>().To<HttpApplicationInitializationHttpModule>();

            RegisterServices(kernel);
            return kernel;
        }
        private static void RegisterServices(IKernel kernel)
        {
            kernel.Bind(typeof(IBaseAppService<>)).To(typeof(BaseAppService<>));
            kernel.Bind<IStudentAppService>().To<StudentAppService>();

            kernel.Bind(typeof(IBaseService<>)).To(typeof(BaseService<>));
            kernel.Bind<IStudentService>().To<StudentService>();
            kernel.Bind<IPersonService>().To<PersonService>();

            kernel.Bind(typeof(IBaseRepository<>)).To(typeof(BaseRepository<>));
            kernel.Bind<IStudentRepository>().To<StudentRepository>();
            kernel.Bind<IPersonRepository>().To<PersonRepository>();
        }

    }
}