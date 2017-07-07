using Android.Content;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XamarinNuGetSample.Abstractions;

using Uri = Android.Net.Uri;

namespace XamarinNuGetSample
{
    public class XamarinNuGetSample : IXamarinNuGetSample
    {
        public Uri Url { get; private set; } = null;


        public Task<bool> LoadUrlAsync(string uri)
        {
            Url = Uri.Parse(uri);
            return Task.FromResult(true);
        }
    }

    public static class XamarinNuGetSampleExtension
    {
        public static async Task<bool> LoadUrlAsync(this XamarinNuGetSample sample, Context context, string uri)
        {
            var result = await sample.LoadUrlAsync(uri);

            if (result)
            {
                context.StartActivity(new Intent(Intent.ActionView, sample.Url));
            }

            return result;
        }
    }
}
