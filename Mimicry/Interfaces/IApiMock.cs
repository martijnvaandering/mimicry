using Microsoft.Owin;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

namespace Mimicry.Interfaces
{
    public interface IApiMock
    {
        IEnumerable<IMimicDefinition> MinicDefinitions { get; }

        void Load(IMimicDefinitionLoader loader);

        Task InvokeMimickedEndpoint(string relativeUrl,IOwinContext owinContext);
    }
}