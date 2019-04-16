using Mimicry.Interfaces;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Mime;
using System.Text;

namespace Mimicry
{
    public class DefaultMimicDefinition : IMimicDefinition
    {
        public DefaultMimicDefinition(string relativeEndpointUrl, string rawResponse, ContentType contentType = null, int delay = 0, HttpMethod httpMethod = null)
        {
            RelativeEndpointUrl = relativeEndpointUrl;
            RawResponse = rawResponse;
            ContentType = contentType ?? new ContentType("application/json");
            Delay = delay;
            Method = httpMethod ?? HttpMethod.Get;
        }

        public string RelativeEndpointUrl { get; set; }

        public ContentType ContentType { get; set; }

        public HttpMethod Method { get; set; }
        public string RawResponse { get; set; }

        public int Delay { get; set; }
    }
}
