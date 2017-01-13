using Nancy;

namespace NancyCore.Modules
{
    public class HomeModule : NancyModule
    {
        public HomeModule()
        {
            Get("/", _ => View["index"]);
            Get("/hello", _ => "Hello, World from NancyCore!");
        }
    }
}