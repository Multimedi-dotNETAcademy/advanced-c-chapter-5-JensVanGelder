using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Bookmark_Manager
{
    class HiddenBookMark:BookMark
    {
        public override void OpenSite()
        {
            Process.Start(@"C:\Program Files\BraveSoftware\Brave-Browser\Application\brave.exe"," -incognito"+ URL);
            Process.Start(@"chrome.exe", "--incognito http://domain.com");
        }
    }
}
