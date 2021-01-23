using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Diagnostics;

namespace Bookmark_Manager
{
    class BookMark
    {
        public string Naam { get; set; }
        public string URL { get; set; }
        public virtual void OpenSite()
        {
            Process.Start(@"C:\Program Files\BraveSoftware\Brave-Browser\Application\brave.exe", URL);
        }
    }
}
