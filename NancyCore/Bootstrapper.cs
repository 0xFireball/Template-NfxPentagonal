using Nancy;
using Nancy.Bootstrapper;
using Nancy.TinyIoc;

namespace NancyCore
{
    class Bootstrapper : DefaultNancyBootstrapper
    {
        protected override void ApplicationStartup(TinyIoCContainer container, IPipelines pipelines)
        {
            base.ApplicationStartup(container, pipelines);

            // TODO: Your customization
        }
    }
}