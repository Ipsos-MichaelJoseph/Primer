using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;

namespace Primer.Controllers
{
    public class PageSizeController : ApiController
    {
        private static string TargetUrl = "http://neverssl.com"; // "https://www.apress.com/gb";

        public async Task<long> GetPageSize()
        {
            WebClient wc = new WebClient();
            Stopwatch sw = Stopwatch.StartNew();
            byte[] apressData = await wc.DownloadDataTaskAsync(TargetUrl);

            Debug.WriteLine("Ellapsed Time {0} ms", sw.ElapsedMilliseconds);

            return apressData.LongLength;
        }
    }
}
