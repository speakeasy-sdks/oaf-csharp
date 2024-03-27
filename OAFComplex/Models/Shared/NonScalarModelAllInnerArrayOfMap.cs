
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
    using Newtonsoft.Json.Linq;
    using Newtonsoft.Json;
    using OAFComplex.Models.Shared;
    using OAFComplex.Utils;
    using System.Collections.Generic;
    using System.Numerics;
    using System;
    

    public class NonScalarModelAllInnerArrayOfMapType
    {
        private NonScalarModelAllInnerArrayOfMapType(string value) { Value = value; }

        public string Value { get; private set; }
        public static NonScalarModelAllInnerArrayOfMapType ArrayOfmapOfOrbit { get { return new NonScalarModelAllInnerArrayOfMapType("arrayOfmapOfOrbit"); } }
        
        public static NonScalarModelAllInnerArrayOfMapType ArrayOfmapOfVehicle { get { return new NonScalarModelAllInnerArrayOfMapType("arrayOfmapOfVehicle"); } }
        
        public static NonScalarModelAllInnerArrayOfMapType Any { get { return new NonScalarModelAllInnerArrayOfMapType("any"); } }
        
        public static NonScalarModelAllInnerArrayOfMapType Null { get { return new NonScalarModelAllInnerArrayOfMapType("null"); } }

        public override string ToString() { return Value; }
        public static implicit operator String(NonScalarModelAllInnerArrayOfMapType v) { return v.Value; }
        public static NonScalarModelAllInnerArrayOfMapType FromString(string v) {
            switch(v) {
                case "arrayOfmapOfOrbit": return ArrayOfmapOfOrbit;
                case "arrayOfmapOfVehicle": return ArrayOfmapOfVehicle;
                case "any": return Any;
                case "null": return Null;
                default: throw new ArgumentException("Invalid value for NonScalarModelAllInnerArrayOfMapType");
            }
        }
        public override bool Equals(object? obj)
        {
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }
            return Value.Equals(((NonScalarModelAllInnerArrayOfMapType)obj).Value);
        }

        public override int GetHashCode()
        {
            return Value.GetHashCode();
        }
    }
    

    [JsonConverter(typeof(NonScalarModelAllInnerArrayOfMap.NonScalarModelAllInnerArrayOfMapConverter))]
    public class NonScalarModelAllInnerArrayOfMap {
        public NonScalarModelAllInnerArrayOfMap(NonScalarModelAllInnerArrayOfMapType type) {
            Type = type;
        }
        public List<Dictionary<string, Orbit>>? ArrayOfmapOfOrbit { get; set; } 
        public List<Dictionary<string, Vehicle>>? ArrayOfmapOfVehicle { get; set; } 
        public object? Any { get; set; } 

        public NonScalarModelAllInnerArrayOfMapType Type { get; set; }


        public static NonScalarModelAllInnerArrayOfMap CreateArrayOfmapOfOrbit(List<Dictionary<string, Orbit>> arrayOfmapOfOrbit) {
            NonScalarModelAllInnerArrayOfMapType typ = NonScalarModelAllInnerArrayOfMapType.ArrayOfmapOfOrbit;

            NonScalarModelAllInnerArrayOfMap res = new NonScalarModelAllInnerArrayOfMap(typ);
            res.ArrayOfmapOfOrbit = arrayOfmapOfOrbit;
            return res;
        }

        public static NonScalarModelAllInnerArrayOfMap CreateArrayOfmapOfVehicle(List<Dictionary<string, Vehicle>> arrayOfmapOfVehicle) {
            NonScalarModelAllInnerArrayOfMapType typ = NonScalarModelAllInnerArrayOfMapType.ArrayOfmapOfVehicle;

            NonScalarModelAllInnerArrayOfMap res = new NonScalarModelAllInnerArrayOfMap(typ);
            res.ArrayOfmapOfVehicle = arrayOfmapOfVehicle;
            return res;
        }

        public static NonScalarModelAllInnerArrayOfMap CreateAny(object any) {
            NonScalarModelAllInnerArrayOfMapType typ = NonScalarModelAllInnerArrayOfMapType.Any;

            NonScalarModelAllInnerArrayOfMap res = new NonScalarModelAllInnerArrayOfMap(typ);
            res.Any = any;
            return res;
        }

        public static NonScalarModelAllInnerArrayOfMap CreateNull() {
            NonScalarModelAllInnerArrayOfMapType typ = NonScalarModelAllInnerArrayOfMapType.Null;
            return new NonScalarModelAllInnerArrayOfMap(typ);
        }

        public class NonScalarModelAllInnerArrayOfMapConverter : JsonConverter
        {

            public override bool CanConvert(System.Type objectType) => objectType == typeof(NonScalarModelAllInnerArrayOfMap);

            public override bool CanRead => true;

            public override object? ReadJson(JsonReader reader, System.Type objectType, object? existingValue, JsonSerializer serializer)
            { 
                var json = JRaw.Create(reader).ToString();

                if (json == "null") {
                    return null;
                }
                try
                {
                    List<Dictionary<string, Orbit>>? arrayOfmapOfOrbit = JsonConvert.DeserializeObject<List<Dictionary<string, Orbit>>>(json, new JsonSerializerSettings(){ NullValueHandling = NullValueHandling.Ignore, MissingMemberHandling = MissingMemberHandling.Error, Converters = Utilities.GetJsonConverters(typeof(List<Dictionary<string, Orbit>>))});
                    return new NonScalarModelAllInnerArrayOfMap(NonScalarModelAllInnerArrayOfMapType.ArrayOfmapOfOrbit) {
                        ArrayOfmapOfOrbit = arrayOfmapOfOrbit
                    };
                }
                catch (Exception ex)
                {
                    if (!(ex is Newtonsoft.Json.JsonReaderException || ex is Newtonsoft.Json.JsonSerializationException)) {
                        throw ex;
                    }
                }
                try
                {
                    List<Dictionary<string, Vehicle>>? arrayOfmapOfVehicle = JsonConvert.DeserializeObject<List<Dictionary<string, Vehicle>>>(json, new JsonSerializerSettings(){ NullValueHandling = NullValueHandling.Ignore, MissingMemberHandling = MissingMemberHandling.Error, Converters = Utilities.GetJsonConverters(typeof(List<Dictionary<string, Vehicle>>))});
                    return new NonScalarModelAllInnerArrayOfMap(NonScalarModelAllInnerArrayOfMapType.ArrayOfmapOfVehicle) {
                        ArrayOfmapOfVehicle = arrayOfmapOfVehicle
                    };
                }
                catch (Exception ex)
                {
                    if (!(ex is Newtonsoft.Json.JsonReaderException || ex is Newtonsoft.Json.JsonSerializationException)) {
                        throw ex;
                    }
                }
                try
                {
                    object? any = JsonConvert.DeserializeObject<object>(json, new JsonSerializerSettings(){ NullValueHandling = NullValueHandling.Ignore, MissingMemberHandling = MissingMemberHandling.Error, Converters = Utilities.GetJsonConverters(typeof(object))});
                    return new NonScalarModelAllInnerArrayOfMap(NonScalarModelAllInnerArrayOfMapType.Any) {
                        Any = any
                    };
                }
                catch (Exception ex)
                {
                    if (!(ex is Newtonsoft.Json.JsonReaderException || ex is Newtonsoft.Json.JsonSerializationException)) {
                        throw ex;
                    }
                }

                throw new InvalidOperationException("Could not deserialize into any supported types.");
            }

            public override void WriteJson(JsonWriter writer, object? value, JsonSerializer serializer)
            {
                if (value == null) {
                    writer.WriteRawValue("null");
                    return;
                }
                NonScalarModelAllInnerArrayOfMap res = (NonScalarModelAllInnerArrayOfMap)value;
                if (NonScalarModelAllInnerArrayOfMapType.FromString(res.Type).Equals(NonScalarModelAllInnerArrayOfMapType.Null))
                {
                    writer.WriteRawValue("null");
                    return;
                }
                if (res.ArrayOfmapOfOrbit != null)
                {
                    writer.WriteRawValue(Utilities.SerializeJSON(res.ArrayOfmapOfOrbit));
                    return;
                }
                if (res.ArrayOfmapOfVehicle != null)
                {
                    writer.WriteRawValue(Utilities.SerializeJSON(res.ArrayOfmapOfVehicle));
                    return;
                }
                if (res.Any != null)
                {
                    writer.WriteRawValue(Utilities.SerializeJSON(res.Any));
                    return;
                }

            }
        }

    }

}