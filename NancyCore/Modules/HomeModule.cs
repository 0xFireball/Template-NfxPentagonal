using Nancy;

namespace NfxPentagonalCore.Modules
{
    public class HomeModule : NancyModule
    {
        public HomeModule()
        {
            Get("/", _ => View["index"]);
            Get("/hello", _ => "Hello, World from NfxPentagonalCore!");
        }
    }
}