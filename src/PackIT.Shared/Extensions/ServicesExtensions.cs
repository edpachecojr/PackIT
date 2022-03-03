using Microsoft.Extensions.DependencyInjection;
using PackIT.Shared.Abstractions.Commands;
using PackIT.Shared.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace PackIT.Shared.Extensions
{
    public static class ServicesExtensions
    {
        public static IServiceCollection AddCommands(this IServiceCollection services)
        {
            var assembly = Assembly.GetCallingAssembly();

            services.AddSingleton<ICommandDispatcher, InMemoryCommandDispatcher>();
            services.Scan(s => s.FromAssemblies(assembly)
                .AddClasses(c => c.AssignableTo(typeof(ICommandHandler<>)))
                .AsImplementedInterfaces()
                .WithScopedLifetime());

            return services;
        }
    }
}
