
[assembly: WebActivatorEx.PreApplicationStartMethod(typeof(ProjetoASIp1.Presentation.App_Start.NinjectWebCommon), "Start")]
[assembly: WebActivatorEx.ApplicationShutdownMethodAttribute(typeof(ProjetoASIp1.Presentation.App_Start.NinjectWebCommon), "Stop")]

namespace ProjetoASIp1.Presentation.App_Start
{
    using System;
    using System.Web;

    using Microsoft.Web.Infrastructure.DynamicModuleHelper;

    using Ninject;
    using Ninject.Web.Common;
    using Domain.Interfaces;
    using Domain.Services.Service;
    using ProjetoASIp1Aplication.Interfaces;
    using ProjetoASIp1Aplication.Services;
    using Domain.Interfaces.Repository;
    using Infra.Data.Repositories;
    using Domain.Interfaces.Service;
    public static class NinjectWebCommon 
    {
        private static readonly Bootstrapper bootstrapper = new Bootstrapper();

        /// <summary>
        /// Starts the application
        /// </summary>
        public static void Start() 
        {
            DynamicModuleUtility.RegisterModule(typeof(OnePerRequestHttpModule));
            DynamicModuleUtility.RegisterModule(typeof(NinjectHttpModule));
            bootstrapper.Initialize(CreateKernel);
        }
        
        /// <summary>
        /// Stops the application.
        /// </summary>
        public static void Stop()
        {
            bootstrapper.ShutDown();
        }
        
        /// <summary>
        /// Creates the kernel that will manage your application.
        /// </summary>
        /// <returns>The created kernel.</returns>
        private static IKernel CreateKernel()
        {
            var kernel = new StandardKernel();
            try
            {
                kernel.Bind<Func<IKernel>>().ToMethod(ctx => () => new Bootstrapper().Kernel);
                kernel.Bind<IHttpModule>().To<HttpApplicationInitializationHttpModule>();

                RegisterServices(kernel);
                return kernel;
            }
            catch
            {
                kernel.Dispose();
                throw;
            }
        }

        /// <summary>
        /// Load your modules or register your services here!
        /// </summary>
        /// <param name="kernel">The kernel.</param>
        private static void RegisterServices(IKernel kernel)
        {
            kernel.Bind<IClienteService>().To<ClienteService>();
            kernel.Bind<IAppClienteService>().To<AppClienteService>();
            kernel.Bind<IClienteRepository>().To<ClienteRepository>();

            kernel.Bind<IFornecedorService>().To<FornecedorService>();
            kernel.Bind<IAppFornecedorService>().To<AppFornecedorService>();
            kernel.Bind<IFornecedorRepository>().To<FornecedorRepository>();

            kernel.Bind<IPratoService>().To<PratoService>();
        }
    }
}
