using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Code_First_Lab.Startup))]
namespace Code_First_Lab
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
