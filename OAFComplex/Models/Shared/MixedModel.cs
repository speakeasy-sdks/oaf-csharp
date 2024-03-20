
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
    using OAFComplex.Models.Shared;
    using System.Collections.Generic;
    
    /// <summary>
    /// This class contains mix of scalar and non scalar types in oneOf/anyOf cases.
    /// </summary>
    public class MixedModel
    {

        [JsonProperty("allInnerArrayOfMap", NullValueHandling = NullValueHandling.Include)]
        public AllInnerArrayOfMap? AllInnerArrayOfMap { get; set; } = default!;

        [JsonProperty("allInnerArrayOfMap2", NullValueHandling = NullValueHandling.Include)]
        public Dictionary<string, AllInnerArrayOfMap2>? AllInnerArrayOfMap2 { get; set; } = default!;

        [JsonProperty("multiAnyOf")]
        public MultiAnyOf MultiAnyOf { get; set; } = default!;

        [JsonProperty("multiOneOfAnyOf")]
        public MultiOneOfAnyOf MultiOneOfAnyOf { get; set; } = default!;

        [JsonProperty("outerArrayOfMap")]
        public List<Dictionary<string, OuterArrayOfMap>>? OuterArrayOfMap { get; set; }

        [JsonProperty("outerArrayOfMap2")]
        public List<Dictionary<string, List<Car>>>? OuterArrayOfMap2 { get; set; }

        [JsonProperty("outerMapOfArray")]
        public Dictionary<string, List<OuterMapOfArray>>? OuterMapOfArray { get; set; }

        [JsonProperty("outerMapOfArray2")]
        public Dictionary<string, List<OuterMapOfArray2>>? OuterMapOfArray2 { get; set; }

        [JsonProperty("outerMapOfSingleInnerArray")]
        public Dictionary<string, OuterMapOfSingleInnerArray> OuterMapOfSingleInnerArray { get; set; } = default!;

        [JsonProperty("singleInnerMapOfArray")]
        public SingleInnerMapOfArray SingleInnerMapOfArray { get; set; } = default!;
    }
}