using System.ComponentModel.DataAnnotations;
using ACMESharp.Crypto.JOSE;
using ACMESharp.Protocol.Resources;
using Newtonsoft.Json;

namespace ACMESharp.Protocol.Messages
{
    /// <summary>
    /// https://tools.ietf.org/html/draft-ietf-acme-acme-12#section-7.4
    /// </summary>
    public class CreatePreAuthorizationRequest
    {
        [JsonProperty("identifiers", Required = Required.Always)]
        [Required, MinLength(1)]
        public Identifier[] Identifiers { get; set; }
    }
}
