using Mimicry.Interfaces;
using System;

namespace Mimicry.Server
{
    public class MimicInvocation
    {
        public IMimicDefinition MinicDefinition { get; set; }
        public DateTime TimeStamp { get; set; }
        public TimeSpan LoadTime { get; set; }

    }
}
