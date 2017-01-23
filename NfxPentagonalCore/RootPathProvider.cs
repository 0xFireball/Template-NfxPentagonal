using System.IO;
using Nancy;

namespace NfxPentagonalCore
{
    public class CustomRootPathProvider : IRootPathProvider
    {
        public string GetRootPath() => Directory.GetCurrentDirectory();
    }
}