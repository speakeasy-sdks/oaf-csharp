
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
    /// Course evening session
    /// </summary>
    public class Evening
    {

        /// <summary>
        /// Session end time
        /// </summary>
        [JsonProperty("endsAt")]
        public string EndsAt { get; set; } = default!;

        /// <summary>
        /// Offer dinner during session
        /// </summary>
        [JsonProperty("offerDinner")]
        public bool OfferDinner { get; set; } = default!;

        [JsonProperty("sessionType")]
        public string SessionType { get; set; } = default!;

        /// <summary>
        /// Session start time
        /// </summary>
        [JsonProperty("startsAt")]
        public string StartsAt { get; set; } = default!;
    }
}