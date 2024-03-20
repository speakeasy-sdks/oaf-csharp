
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
    

    public class ScalarModelAllInnerArrayOfMap2Type
    {
        private ScalarModelAllInnerArrayOfMap2Type(string value) { Value = value; }

        public string Value { get; private set; }
        public static ScalarModelAllInnerArrayOfMap2Type ArrayOfmapOfint32 { get { return new ScalarModelAllInnerArrayOfMap2Type("arrayOfmapOfint32"); } }
        
        public static ScalarModelAllInnerArrayOfMap2Type ArrayOfmapOfstr { get { return new ScalarModelAllInnerArrayOfMap2Type("arrayOfmapOfstr"); } }
        
        public static ScalarModelAllInnerArrayOfMap2Type Any { get { return new ScalarModelAllInnerArrayOfMap2Type("any"); } }
        
        public static ScalarModelAllInnerArrayOfMap2Type Null { get { return new ScalarModelAllInnerArrayOfMap2Type("null"); } } 

        public override string ToString() { return Value; }
        public static implicit operator String(ScalarModelAllInnerArrayOfMap2Type v) { return v.Value; }
        public static ScalarModelAllInnerArrayOfMap2Type FromString(string v) {
            switch(v) {
                case "arrayOfmapOfint32": return ArrayOfmapOfint32;
                case "arrayOfmapOfstr": return ArrayOfmapOfstr;
                case "any": return Any;
                case "null": return Null;
                default: throw new ArgumentException("Invalid value for ScalarModelAllInnerArrayOfMap2Type");
            }
        }
        public override bool Equals(object? obj)
        {
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }
            return Value.Equals(((ScalarModelAllInnerArrayOfMap2Type)obj).Value);
        }

        public override int GetHashCode()
        {
            return Value.GetHashCode();
        }
    }
    

    [JsonConverter(typeof(ScalarModelAllInnerArrayOfMap2.ScalarModelAllInnerArrayOfMap2Converter))]
    public class ScalarModelAllInnerArrayOfMap2 {
        public ScalarModelAllInnerArrayOfMap2(ScalarModelAllInnerArrayOfMap2Type type) {
            Type = type;
        }
        public List<Dictionary<string, int>>? ArrayOfmapOfint32 { get; set; } 
        public List<Dictionary<string, string>>? ArrayOfmapOfstr { get; set; } 
        public object? Any { get; set; } 

        public ScalarModelAllInnerArrayOfMap2Type Type {get; set; }


        public static ScalarModelAllInnerArrayOfMap2 CreateArrayOfmapOfint32(List<Dictionary<string, int>> arrayOfmapOfint32) {
            ScalarModelAllInnerArrayOfMap2Type typ = ScalarModelAllInnerArrayOfMap2Type.ArrayOfmapOfint32;

            ScalarModelAllInnerArrayOfMap2 res = new ScalarModelAllInnerArrayOfMap2(typ);
            res.ArrayOfmapOfint32 = arrayOfmapOfint32;
            return res;
        }

        public static ScalarModelAllInnerArrayOfMap2 CreateArrayOfmapOfstr(List<Dictionary<string, string>> arrayOfmapOfstr) {
            ScalarModelAllInnerArrayOfMap2Type typ = ScalarModelAllInnerArrayOfMap2Type.ArrayOfmapOfstr;

            ScalarModelAllInnerArrayOfMap2 res = new ScalarModelAllInnerArrayOfMap2(typ);
            res.ArrayOfmapOfstr = arrayOfmapOfstr;
            return res;
        }

        public static ScalarModelAllInnerArrayOfMap2 CreateAny(object any) {
            ScalarModelAllInnerArrayOfMap2Type typ = ScalarModelAllInnerArrayOfMap2Type.Any;

            ScalarModelAllInnerArrayOfMap2 res = new ScalarModelAllInnerArrayOfMap2(typ);
            res.Any = any;
            return res;
        }

        public static ScalarModelAllInnerArrayOfMap2 CreateNull() {
            ScalarModelAllInnerArrayOfMap2Type typ = ScalarModelAllInnerArrayOfMap2Type.Null;
            return new ScalarModelAllInnerArrayOfMap2(typ);
        }

        public class ScalarModelAllInnerArrayOfMap2Converter : JsonConverter
        {

            public override bool CanConvert(System.Type objectType) => objectType == typeof(ScalarModelAllInnerArrayOfMap2);

            public override bool CanRead => true;

            public override object? ReadJson(JsonReader reader, System.Type objectType, object? existingValue, JsonSerializer serializer)
            { 
                var json = JRaw.Create(reader).ToString();

                if (json == "null") {
                    return null;
                }
                try
                {
                    List<Dictionary<string, int>>? arrayOfmapOfint32 = JsonConvert.DeserializeObject<List<Dictionary<string, int>>>(json, new JsonSerializerSettings(){ NullValueHandling = NullValueHandling.Ignore, MissingMemberHandling = MissingMemberHandling.Error, Converters = Utilities.GetJsonConverters(typeof(List<Dictionary<string, int>>), "string")});
                    return new ScalarModelAllInnerArrayOfMap2(ScalarModelAllInnerArrayOfMap2Type.ArrayOfmapOfint32) {
                        ArrayOfmapOfint32 = arrayOfmapOfint32
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
                    List<Dictionary<string, string>>? arrayOfmapOfstr = JsonConvert.DeserializeObject<List<Dictionary<string, string>>>(json, new JsonSerializerSettings(){ NullValueHandling = NullValueHandling.Ignore, MissingMemberHandling = MissingMemberHandling.Error, Converters = Utilities.GetJsonConverters(typeof(List<Dictionary<string, string>>), "string")});
                    return new ScalarModelAllInnerArrayOfMap2(ScalarModelAllInnerArrayOfMap2Type.ArrayOfmapOfstr) {
                        ArrayOfmapOfstr = arrayOfmapOfstr
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
                    object? any = JsonConvert.DeserializeObject<object>(json, new JsonSerializerSettings(){ NullValueHandling = NullValueHandling.Ignore, MissingMemberHandling = MissingMemberHandling.Error, Converters = Utilities.GetJsonConverters(typeof(object), "string")});
                    return new ScalarModelAllInnerArrayOfMap2(ScalarModelAllInnerArrayOfMap2Type.Any) {
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
                ScalarModelAllInnerArrayOfMap2 res = (ScalarModelAllInnerArrayOfMap2)value;
                if (ScalarModelAllInnerArrayOfMap2Type.FromString(res.Type).Equals(ScalarModelAllInnerArrayOfMap2Type.Null))
                {
                    writer.WriteRawValue("null");
                    return;
                }
                if (res.ArrayOfmapOfint32 != null)
                {
                    writer.WriteRawValue(Utilities.SerializeJSON(res.ArrayOfmapOfint32));
                    return;
                }
                if (res.ArrayOfmapOfstr != null)
                {
                    writer.WriteRawValue(Utilities.SerializeJSON(res.ArrayOfmapOfstr));
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