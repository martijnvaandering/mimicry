using System.Net.Http;
using System.Net.Mime;

namespace Mimicry.Interfaces
{
    public interface IMimicDefinition
    {
        string RelativeEndpointUrl { get; }
        ContentType ContentType { get; }
        HttpMethod Method { get; }
        string RawResponse { get; }

        /// <summary>
        /// Delay in Milliseconds
        /// </summary>
        int Delay { get; }
    }
}