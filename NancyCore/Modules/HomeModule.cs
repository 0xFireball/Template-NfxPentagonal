using Nancy;

namespace NancyCore.Modules
{
    public class HomeModule : NancyModule
    {
        public HomeModule()
        {
            Get("/", _ => "Hello, World from NancyCore!");
        }
    }
}