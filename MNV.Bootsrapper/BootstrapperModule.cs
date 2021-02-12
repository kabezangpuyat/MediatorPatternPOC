using Autofac;
using MediatR.Extensions.Autofac.DependencyInjection;
using MNV.Core.Database;
using System;

namespace MNV.Bootsrapper
{
    public class BootstrapperModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            RegisterServices(builder);
            RegisterInfrastructureDependencies(builder);
            RegisterDataHandlingDependencies(builder);
            //RegisterAWSDependencies(builder);
            //RegisterUtils(builder);
        }

        #region MyRegion
        private static void RegisterServices(ContainerBuilder builder)
        {
            //builder
            //    .RegisterType<ServiceName>()
            //    .As<IServiceName>();
        }

        private static void RegisterInfrastructureDependencies(ContainerBuilder builder)
        {
            //builder
            //  .RegisterType<DataContext>()
            //  .As(typeof(IDataContext))
            //  .InstancePerLifetimeScope();
        }

        public static void RegisterDataHandlingDependencies(ContainerBuilder builder)
        {
            //builder.AddMediatR(
            //    typeof(ApplicationInsightsLogExceptionCommand).Assembly
            //    typeof(ApplicationInsightsLogExceptionHandler).Assembly);
        }
        #endregion
    }
}
