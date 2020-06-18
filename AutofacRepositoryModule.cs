using Autofac;
using FUS.Business;
using FUS.Business.Interfaces;

namespace FUS
{
    internal class AutofacRepositoryModule : Autofac.Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<FileUpload>().As<IFileUpload>();
        }
    }
}