
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
    
    /// <summary>
    /// This class contains mix of scalar and non scalar types in oneOf/anyOf cases.
    /// </summary>
    public class MixedModel
    {

        [JsonProperty("allInnerArrayOfMap")]
        public object AllInnerArrayOfMap { get; set; } = default!;

        [JsonProperty("allInnerArrayOfMap2")]
        public Dictionary<string, object> AllInnerArrayOfMap2 { get; set; } = default!;

        [JsonProperty("multiAnyOf")]
        public object MultiAnyOf { get; set; } = default!;

        [JsonProperty("multiOneOfAnyOf")]
        public object MultiOneOfAnyOf { get; set; } = default!;

        [JsonProperty("outerArrayOfMap")]
        public List<Dictionary<string, object>>? OuterArrayOfMap { get; set; }

        [JsonProperty("outerArrayOfMap2")]
        public List<Dictionary<string, List<Car>>>? OuterArrayOfMap2 { get; set; }

        [JsonProperty("outerMapOfArray")]
        public Dictionary<string, List<object>>? OuterMapOfArray { get; set; }

        [JsonProperty("outerMapOfArray2")]
        public Dictionary<string, List<object>>? OuterMapOfArray2 { get; set; }

        [JsonProperty("outerMapOfSingleInnerArray")]
        public Dictionary<string, object> OuterMapOfSingleInnerArray { get; set; } = default!;

        [JsonProperty("singleInnerMapOfArray")]
        public object SingleInnerMapOfArray { get; set; } = default!;
    }
}