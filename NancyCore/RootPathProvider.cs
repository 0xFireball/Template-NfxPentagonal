using System.IO;
using Nancy;

namespace NancyCore
{
    public class CustomRootPathProvider : IRootPathProvider
    {
        public string GetRootPath() => Directory.GetCurrentDirectory();
    }
}