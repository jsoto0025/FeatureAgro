using Lamar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FutureAgro.Web
{
    public class BasicScanning : ServiceRegistry
    {
        public BasicScanning()
        {
            Scan(x =>
            {
                // Declare which assemblies to scan
                //_.Assembly("StructureMap.Testing");
                //_.AssemblyContainingType<IWidget>();

                //// Filter types
                //_.Exclude(type => type.Name.Contains("Bad"));

                //// A custom registration convention
                //_.Convention<MySpecialRegistrationConvention>();

                //// Built in registration conventions
                //_.AddAllTypesOf<IWidget>().NameBy(x => x.Name.Replace("Widget", ""));
                x.TheCallingAssembly();
                x.WithDefaultConventions();
            });
        }
    }
}
