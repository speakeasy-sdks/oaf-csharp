
//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by Speakeasy (https://speakeasyapi.dev). DO NOT EDIT.
//
// Changes to this file may cause incorrect behavior and will be lost when
// the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
#nullable enable
namespace OAFComplex.Models.Shared
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    
    public class SendCollectCombinedRequestBody
    {

        [JsonProperty("bodyMixed")]
        public List<Dictionary<string, bool>>? BodyMixed { get; set; }

        [JsonProperty("bodyNonScalar")]
        public Dictionary<string, object> BodyNonScalar { get; set; } = default!;

        [JsonProperty("bodyScalar")]
        public List<Dictionary<string, object>> BodyScalar { get; set; } = default!;
    }
}