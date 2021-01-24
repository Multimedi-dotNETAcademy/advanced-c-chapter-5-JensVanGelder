using System.Diagnostics;

namespace Bookmark_Manager
{
    internal class HiddenBookMark : BookMark
    {
        public override void OpenSite()
        {
            Process.Start(@"C:\Program Files\BraveSoftware\Brave-Browser\Application\brave.exe", $" -incognito {URL}");
        }
    }
}