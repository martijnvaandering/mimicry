using Mimicry.Interfaces;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Mime;

namespace Mimicry.Server
{
    public sealed class EFDefinitionLoader : DefaultDefinitionLoader
    {
        public EFDefinitionLoader(DefinitionContext context)
        {
            Context = context;
            Context.Database.EnsureCreated();
        }

        private DefinitionContext Context { get; }

        public override IEnumerable<IMimicDefinition> GetDefinitions()
        {
            return Context.MimicDefinitions.Select(a => new DefaultMimicDefinition(a.RelativeEndpointUrl, a.RawResponse, new ContentType(a.ContentType), a.Delay, new HttpMethod(a.Method)));
        }
    }
}
