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

    public static class XamarinNuGetSampleExtension
    {
        public static async Task<bool> LoadUrlAsync(this XamarinNuGetSample sample, string uri)
        {
            var result = await sample.LoadUrlAsync(uri);

            if (result)
            {
                var browserLaunched = await Windows.System.Launcher.LaunchUriAsync(sample.Url);
            }

            return true;
        }
    }
}
