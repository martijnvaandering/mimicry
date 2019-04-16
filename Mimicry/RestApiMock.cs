using Microsoft.Owin;
using Mimicry.Interfaces;
using Owin;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Mimicry
{
    public class RestApiMock : IApiMock
    {
        public IEnumerable<IMimicDefinition> MinicDefinitions { get; private set; }

        public RestApiMock(IEnumerable<IMimicDefinition> minicDefinitions)
        {
            MinicDefinitions = minicDefinitions;
        }

        public RestApiMock() { }

        public virtual async Task InvokeMimickedEndpoint(string relativeUrl, IOwinContext ctx)
        {
            var definition = MinicDefinitions.FirstOrDefault(a => a.RelativeEndpointUrl == relativeUrl);
            if (definition != null)
            {
                ctx.Response.ContentType = definition.ContentType.ToString();
                await ctx.Response.WriteAsync(await Task.Delay(definition.Delay).ContinueWith(t => definition.RawResponse));
            }
        }

        public void Load(IMimicDefinitionLoader loader)
        {
            MinicDefinitions = loader.GetDefinitions();
        }
    }
}
