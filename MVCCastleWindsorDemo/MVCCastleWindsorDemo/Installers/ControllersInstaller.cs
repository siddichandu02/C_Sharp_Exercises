using System.Web.Mvc;
using Castle.MicroKernel.Registration;
using Castle.MicroKernel.SubSystems.Configuration;
using Castle.Windsor;

namespace MVCCastleWindsorDemo.Installers
{
    using MVCCastleWindsorDemo.Models;
    using Plumbing;

    public class ControllersInstaller : IWindsorInstaller
    {
        public void Install(IWindsorContainer container, IConfigurationStore store)
        {
            container.Register(
                Classes.
                    FromThisAssembly().
                    BasedOn<IController>().
                    If(c => c.Name.EndsWith("Controller")).
                    LifestyleTransient());

            ControllerBuilder.Current.SetControllerFactory(new WindsorControllerFactory(container));


            container.Register(
                   Component
                       .For<IProductRepository>()
                        .ImplementedBy<ProductRepository>()
                        .LifestyleSingleton());

        }
        
    }
}