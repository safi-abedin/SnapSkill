using Autofac;
using SnapSkill.Web.Models;

namespace SnapSkill.Web
{
    public class WebModule :Module
    {

        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<Course>().As<ICourse>();
        }
    }
}
