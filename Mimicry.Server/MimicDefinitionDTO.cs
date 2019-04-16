using System.ComponentModel.DataAnnotations.Schema;

namespace Mimicry.Server
{
    [Table("MimicryDefinition")]
    public class MimicDefinitionDTO
    {
        public int Id { get; set; }
        public string RelativeEndpointUrl { get; set; }
        public string ContentType { get; set; }
        public string Method { get; set; }
        public string RawResponse { get; set; }
        public int Delay { get; set; }
    }
}