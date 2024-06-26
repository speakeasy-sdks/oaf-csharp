
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
    

    public class AllInnerArrayOfMapType
    {
        private AllInnerArrayOfMapType(string value) { Value = value; }

        public string Value { get; private set; }
        public static AllInnerArrayOfMapType ArrayOfmapOfboolean { get { return new AllInnerArrayOfMapType("arrayOfmapOfboolean"); } }
        
        public static AllInnerArrayOfMapType ArrayOfmapOfVehicle { get { return new AllInnerArrayOfMapType("arrayOfmapOfVehicle"); } }
        
        public static AllInnerArrayOfMapType Any { get { return new AllInnerArrayOfMapType("any"); } }
        
        public static AllInnerArrayOfMapType Null { get { return new AllInnerArrayOfMapType("null"); } }

        public override string ToString() { return Value; }
        public static implicit operator String(AllInnerArrayOfMapType v) { return v.Value; }
        public static AllInnerArrayOfMapType FromString(string v) {
            switch(v) {
                case "arrayOfmapOfboolean": return ArrayOfmapOfboolean;
                case "arrayOfmapOfVehicle": return ArrayOfmapOfVehicle;
                case "any": return Any;
                case "null": return Null;
                default: throw new ArgumentException("Invalid value for AllInnerArrayOfMapType");
            }
        }
        public override bool Equals(object? obj)
        {
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }
            return Value.Equals(((AllInnerArrayOfMapType)obj).Value);
        }

        public override int GetHashCode()
        {
            return Value.GetHashCode();
        }
    }
    

    [JsonConverter(typeof(AllInnerArrayOfMap.AllInnerArrayOfMapConverter))]
    public class AllInnerArrayOfMap {
        public AllInnerArrayOfMap(AllInnerArrayOfMapType type) {
            Type = type;
        }
        public List<Dictionary<string, bool>>? ArrayOfmapOfboolean { get; set; } 
        public List<Dictionary<string, Vehicle>>? ArrayOfmapOfVehicle { get; set; } 
        public object? Any { get; set; } 

        public AllInnerArrayOfMapType Type { get; set; }


        public static AllInnerArrayOfMap CreateArrayOfmapOfboolean(List<Dictionary<string, bool>> arrayOfmapOfboolean) {
            AllInnerArrayOfMapType typ = AllInnerArrayOfMapType.ArrayOfmapOfboolean;

            AllInnerArrayOfMap res = new AllInnerArrayOfMap(typ);
            res.ArrayOfmapOfboolean = arrayOfmapOfboolean;
            return res;
        }

        public static AllInnerArrayOfMap CreateArrayOfmapOfVehicle(List<Dictionary<string, Vehicle>> arrayOfmapOfVehicle) {
            AllInnerArrayOfMapType typ = AllInnerArrayOfMapType.ArrayOfmapOfVehicle;

            AllInnerArrayOfMap res = new AllInnerArrayOfMap(typ);
            res.ArrayOfmapOfVehicle = arrayOfmapOfVehicle;
            return res;
        }

        public static AllInnerArrayOfMap CreateAny(object any) {
            AllInnerArrayOfMapType typ = AllInnerArrayOfMapType.Any;

            AllInnerArrayOfMap res = new AllInnerArrayOfMap(typ);
            res.Any = any;
            return res;
        }

        public static AllInnerArrayOfMap CreateNull() {
            AllInnerArrayOfMapType typ = AllInnerArrayOfMapType.Null;
            return new AllInnerArrayOfMap(typ);
        }

        public class AllInnerArrayOfMapConverter : JsonConverter
        {

            public override bool CanConvert(System.Type objectType) => objectType == typeof(AllInnerArrayOfMap);

            public override bool CanRead => true;

            public override object? ReadJson(JsonReader reader, System.Type objectType, object? existingValue, JsonSerializer serializer)
            { 
                var json = JRaw.Create(reader).ToString();

                if (json == "null") {
                    return null;
                }
                try
                {
                    List<Dictionary<string, bool>>? arrayOfmapOfboolean = ResponseBodyDeserializer.Deserialize<List<Dictionary<string, bool>>>(json, missingMemberHandling: MissingMemberHandling.Error);
                    return new AllInnerArrayOfMap(AllInnerArrayOfMapType.ArrayOfmapOfboolean) {
                        ArrayOfmapOfboolean = arrayOfmapOfboolean
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
                    List<Dictionary<string, Vehicle>>? arrayOfmapOfVehicle = ResponseBodyDeserializer.Deserialize<List<Dictionary<string, Vehicle>>>(json, missingMemberHandling: MissingMemberHandling.Error);
                    return new AllInnerArrayOfMap(AllInnerArrayOfMapType.ArrayOfmapOfVehicle) {
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
                    object? any = ResponseBodyDeserializer.Deserialize<object>(json, missingMemberHandling: MissingMemberHandling.Error);
                    return new AllInnerArrayOfMap(AllInnerArrayOfMapType.Any) {
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
                AllInnerArrayOfMap res = (AllInnerArrayOfMap)value;
                if (AllInnerArrayOfMapType.FromString(res.Type).Equals(AllInnerArrayOfMapType.Null))
                {
                    writer.WriteRawValue("null");
                    return;
                }
                if (res.ArrayOfmapOfboolean != null)
                {
                    writer.WriteRawValue(Utilities.SerializeJSON(res.ArrayOfmapOfboolean));
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