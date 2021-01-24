using System.Diagnostics;

namespace Bookmark_Manager
{
    internal class BookMark
    {
        public string Naam { get; set; }
        public string URL { get; set; }

        public virtual void OpenSite()
        {
            Process.Start(@"C:\Program Files\BraveSoftware\Brave-Browser\Application\brave.exe", URL);
        }
    }
}