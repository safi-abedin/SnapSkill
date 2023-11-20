using Autofac;
using SnapSkill.Web.Areas.Admin.Models;
using SnapSkill.Web.Areas.User.Models;
using SnapSkill.Web.Models;

namespace SnapSkill.Web
{
    public class WebModule :Module
    {

        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<Areas.Admin.Models.Course>().As<Areas.Admin.Models.ICourse>();
            builder.RegisterType<Areas.User.Models.Course>().As<Areas.User.Models.ICourse>();

        }
    }
}
