using Mimicry.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Mimicry
{
    public class DefaultDefinitionLoader : IMimicDefinitionLoader
    {
        private IEnumerable<IMimicDefinition> MinicDefinitions { get; }

        public DefaultDefinitionLoader(params IMimicDefinition[] minicDefinitions)
        {
            MinicDefinitions = minicDefinitions;
        }

        public DefaultDefinitionLoader()
        {

        }


        public virtual IEnumerable<IMimicDefinition> GetDefinitions()
        {
            return MinicDefinitions;
        }
    }
}
