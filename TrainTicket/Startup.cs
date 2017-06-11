using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TrainTicket.Startup))]
namespace TrainTicket
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
