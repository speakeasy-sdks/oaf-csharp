
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
    
    /// <summary>
    /// Course noon session
    /// </summary>
    public class Noon
    {

        /// <summary>
        /// Session end time
        /// </summary>
        [JsonProperty("endsAt")]
        public string EndsAt { get; set; } = default!;

        /// <summary>
        /// Offer lunch during session
        /// </summary>
        [JsonProperty("offerLunch")]
        public bool OfferLunch { get; set; } = default!;

        [JsonProperty("sessionType")]
        public string SessionType { get; set; } = default!;

        /// <summary>
        /// Session start time
        /// </summary>
        [JsonProperty("startsAt")]
        public string StartsAt { get; set; } = default!;
    }
}