using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XamarinNuGetSample.Abstractions
{
    public interface IXamarinNuGetSample
    {
        Task<bool> LoadUrlAsync(string uri);
    }
}
