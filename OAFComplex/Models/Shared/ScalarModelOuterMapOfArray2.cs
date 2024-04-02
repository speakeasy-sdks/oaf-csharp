
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
    using OAFComplex.Utils;
    using System.Collections.Generic;
    using System.Numerics;
    using System;
    

    public class ScalarModelOuterMapOfArray2Type
    {
        private ScalarModelOuterMapOfArray2Type(string value) { Value = value; }

        public string Value { get; private set; }
        public static ScalarModelOuterMapOfArray2Type MapOfint32 { get { return new ScalarModelOuterMapOfArray2Type("mapOfint32"); } }
        
        public static ScalarModelOuterMapOfArray2Type MapOfboolean { get { return new ScalarModelOuterMapOfArray2Type("mapOfboolean"); } }
        
        public static ScalarModelOuterMapOfArray2Type Any { get { return new ScalarModelOuterMapOfArray2Type("any"); } }
        
        public static ScalarModelOuterMapOfArray2Type Null { get { return new ScalarModelOuterMapOfArray2Type("null"); } }

        public override string ToString() { return Value; }
        public static implicit operator String(ScalarModelOuterMapOfArray2Type v) { return v.Value; }
        public static ScalarModelOuterMapOfArray2Type FromString(string v) {
            switch(v) {
                case "mapOfint32": return MapOfint32;
                case "mapOfboolean": return MapOfboolean;
                case "any": return Any;
                case "null": return Null;
                default: throw new ArgumentException("Invalid value for ScalarModelOuterMapOfArray2Type");
            }
        }
        public override bool Equals(object? obj)
        {
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }
            return Value.Equals(((ScalarModelOuterMapOfArray2Type)obj).Value);
        }

        public override int GetHashCode()
        {
            return Value.GetHashCode();
        }
    }
    

    [JsonConverter(typeof(ScalarModelOuterMapOfArray2.ScalarModelOuterMapOfArray2Converter))]
    public class ScalarModelOuterMapOfArray2 {
        public ScalarModelOuterMapOfArray2(ScalarModelOuterMapOfArray2Type type) {
            Type = type;
        }
        public Dictionary<string, int>? MapOfint32 { get; set; } 
        public Dictionary<string, bool>? MapOfboolean { get; set; } 
        public object? Any { get; set; } 

        public ScalarModelOuterMapOfArray2Type Type { get; set; }


        public static ScalarModelOuterMapOfArray2 CreateMapOfint32(Dictionary<string, int> mapOfint32) {
            ScalarModelOuterMapOfArray2Type typ = ScalarModelOuterMapOfArray2Type.MapOfint32;

            ScalarModelOuterMapOfArray2 res = new ScalarModelOuterMapOfArray2(typ);
            res.MapOfint32 = mapOfint32;
            return res;
        }

        public static ScalarModelOuterMapOfArray2 CreateMapOfboolean(Dictionary<string, bool> mapOfboolean) {
            ScalarModelOuterMapOfArray2Type typ = ScalarModelOuterMapOfArray2Type.MapOfboolean;

            ScalarModelOuterMapOfArray2 res = new ScalarModelOuterMapOfArray2(typ);
            res.MapOfboolean = mapOfboolean;
            return res;
        }

        public static ScalarModelOuterMapOfArray2 CreateAny(object any) {
            ScalarModelOuterMapOfArray2Type typ = ScalarModelOuterMapOfArray2Type.Any;

            ScalarModelOuterMapOfArray2 res = new ScalarModelOuterMapOfArray2(typ);
            res.Any = any;
            return res;
        }

        public static ScalarModelOuterMapOfArray2 CreateNull() {
            ScalarModelOuterMapOfArray2Type typ = ScalarModelOuterMapOfArray2Type.Null;
            return new ScalarModelOuterMapOfArray2(typ);
        }

        public class ScalarModelOuterMapOfArray2Converter : JsonConverter
        {

            public override bool CanConvert(System.Type objectType) => objectType == typeof(ScalarModelOuterMapOfArray2);

            public override bool CanRead => true;

            public override object? ReadJson(JsonReader reader, System.Type objectType, object? existingValue, JsonSerializer serializer)
            { 
                var json = JRaw.Create(reader).ToString();

                if (json == "null") {
                    return null;
                }
                try
                {
                    Dictionary<string, int>? mapOfint32 = ResponseBodyDeserializer.Deserialize<Dictionary<string, int>>(json, missingMemberHandling: MissingMemberHandling.Error);
                    return new ScalarModelOuterMapOfArray2(ScalarModelOuterMapOfArray2Type.MapOfint32) {
                        MapOfint32 = mapOfint32
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
                    Dictionary<string, bool>? mapOfboolean = ResponseBodyDeserializer.Deserialize<Dictionary<string, bool>>(json, missingMemberHandling: MissingMemberHandling.Error);
                    return new ScalarModelOuterMapOfArray2(ScalarModelOuterMapOfArray2Type.MapOfboolean) {
                        MapOfboolean = mapOfboolean
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
                    return new ScalarModelOuterMapOfArray2(ScalarModelOuterMapOfArray2Type.Any) {
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
                ScalarModelOuterMapOfArray2 res = (ScalarModelOuterMapOfArray2)value;
                if (ScalarModelOuterMapOfArray2Type.FromString(res.Type).Equals(ScalarModelOuterMapOfArray2Type.Null))
                {
                    writer.WriteRawValue("null");
                    return;
                }
                if (res.MapOfint32 != null)
                {
                    writer.WriteRawValue(Utilities.SerializeJSON(res.MapOfint32));
                    return;
                }
                if (res.MapOfboolean != null)
                {
                    writer.WriteRawValue(Utilities.SerializeJSON(res.MapOfboolean));
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