using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XamarinNuGetSample.Abstractions;

namespace XamarinNuGetSample
{
    public class XamarinNuGetSample : IXamarinNuGetSample
    {
        public Uri Url { get; private set; }

        public Task<bool> LoadUrlAsync(string uri)
        {
            Url = new Uri(uri);
            return Task.FromResult(true);
        }
    }
}
