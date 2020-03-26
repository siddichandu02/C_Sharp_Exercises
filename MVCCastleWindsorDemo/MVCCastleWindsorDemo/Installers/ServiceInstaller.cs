using Castle.MicroKernel.Registration;
using MVCCastleWindsorDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCCastleWindsorDemo.Installers
{
    public class ServiceInstaller : IWindsorInstaller
    {
        public void Install(Castle.Windsor.IWindsorContainer container,
        Castle.MicroKernel.SubSystems.Configuration.IConfigurationStore store)
        {
            container.Register(
                Component
                    .For<ProductDbContext>()
                    .LifestyleSingleton());
        }
    }
}