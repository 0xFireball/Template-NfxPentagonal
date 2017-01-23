using LiteDB;
using Nancy;
using Nancy.Bootstrapper;
using Nancy.Configuration;
using Nancy.TinyIoc;
using Pentagonal;
using Pentagonal.Auth;

namespace NfxPentagonalCore
{
    public class Bootstrapper : DefaultNancyBootstrapper
    {
        protected override void ApplicationStartup(TinyIoCContainer container, IPipelines pipelines)
        {
            base.ApplicationStartup(container, pipelines);

            // TODO: Your customization
        }

        public override void Configure(INancyEnvironment environment)
        {
            base.Configure(environment);

            // Install Pentagonal services

            PentagonalServices.Enable(pipelines, new PentagonalConfiguration());
            PentagonalAuthenticationServices.Enable(pipelines, new PentagonalAuthConfiguration
            {
                Database = new LiteDatabase("omnibus-demo.lidb")
            });

#if DEBUG
            // If in Debug mode, set some options to speed up development
            environment.Views(runtimeViewDiscovery: true, runtimeViewUpdates: true);
#endif
        }
    }
}