using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpHealthCheck
{
    class CheckPages
    {
        public void chk(string node, string url)
        {

            Boolean working = false;
            UpdateTimer up = new UpdateTimer();
            GetSite get = new GetSite();


            
            string page = get.DownloadString(url);

            if (page.Contains("<div class=\"time pull-right\">a few seconds</div>"))
            {
                working = true;
            }
            if (page.Contains("<div class=\"time pull-right\">a minute</div>"))
            {
                working = true;
            }


            if (working == true)
            {
                up.update(node);
            }
        }

    }
}
