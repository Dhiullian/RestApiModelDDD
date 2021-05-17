using Autofac;

namespace RestApiModeloDDD.Infrastructure.CrossCutting.Ioc
{
    public class ModuleIoc: Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            ConfigurationIoc.Load(builder);
        }
    }
}
