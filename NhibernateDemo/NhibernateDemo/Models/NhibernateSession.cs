using NHibernate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.Channels;
using System.Web;
using NHibernate.Cfg;

namespace NhibernateDemo.Mappings
{
    public class NHibernateSession
    {
        public static NHibernate.ISession OpenSession()
        {
            var configuration = new Configuration();
            var configurationPath = HttpContext.Current.Server.MapPath(@"~\Models\hibernate.cfg.xml");
            configuration.Configure(configurationPath);
            var friendConfigurationFile = HttpContext.Current.Server.MapPath(@"~\Mappings\Friend.hbm.xml");
            configuration.AddFile(friendConfigurationFile);
            ISessionFactory sessionFactory = configuration.BuildSessionFactory();
            return sessionFactory.OpenSession();
        }
    }
}