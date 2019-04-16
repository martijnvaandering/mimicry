using System.Collections.Generic;

namespace Mimicry.Interfaces
{
    public interface IMimicDefinitionLoader
    {
        IEnumerable<IMimicDefinition> GetDefinitions();
    }
}