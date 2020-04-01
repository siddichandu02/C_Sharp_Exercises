using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.ComponentModel.Composition.Hosting;
using System.IO;
using System.Linq;
using System.Reflection;
using Calculator_Contract;

namespace CompositionHelper
{
    public class CalciCompositionHelper
    {
        [ImportMany]
        public System.Lazy<ICalculator,
    IDictionary<string, object>>[] CalciPlugins
        { get; set; }
        public void AssembleCalculatorComponents()
        {
            try
            {
                var aggregateCatalog = new AggregateCatalog();
                var directoryPath =
                    "C:\\Users\\BK185139\\source\\repos\\SimpleMEF\\ExportComponents\\Components";
                var directoryCatalog = new DirectoryCatalog(directoryPath, "*.dll");
                var assemblyCatalog = new AssemblyCatalog(Assembly.GetExecutingAssembly());
                aggregateCatalog.Catalogs.Add(directoryCatalog);
                aggregateCatalog.Catalogs.Add(assemblyCatalog);
                var container = new CompositionContainer(aggregateCatalog);
                container.ComposeParts(this);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public int GetResult(int num1, int num2, string operationType)
        {
            int result = 0;
            foreach (var CalciPlugin in CalciPlugins)
            {
                if ((string)CalciPlugin.Metadata["CalciMetaData"] == operationType)
                {
                    result = CalciPlugin.Value.GetNumber(num1, num2);
                    break;
                }
            }
            return result;
        }
    }
}
