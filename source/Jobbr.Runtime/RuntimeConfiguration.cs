using System;
using System.Reflection;

namespace Jobbr.Runtime
{
    public class RuntimeConfiguration
    {
        /// <summary>
        /// Gets or sets the assembly where the Job should be found at. Will enummerate all loaded assemblies if not found here
        /// </summary>
        public Assembly JobTypeSearchAssembly { get; set; }

        /// <summary>
        /// Gets ot sets own implementation of a service provider. Let the implementation also implement the <seealso cref="IConfigurableServiceProvider"/> 
        /// interface so that additional components for a specific jobRun can be registered
        /// </summary>
        public IServiceProvider ServiceProvider { get; set; }
    }
}