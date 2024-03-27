
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
    using System.Numerics;
    using System;
    

    public class ScalarModelOuterMapOfArrayType
    {
        private ScalarModelOuterMapOfArrayType(string value) { Value = value; }

        public string Value { get; private set; }
        public static ScalarModelOuterMapOfArrayType Int32 { get { return new ScalarModelOuterMapOfArrayType("int32"); } }
        
        public static ScalarModelOuterMapOfArrayType Boolean { get { return new ScalarModelOuterMapOfArrayType("boolean"); } }
        
        public static ScalarModelOuterMapOfArrayType Any { get { return new ScalarModelOuterMapOfArrayType("any"); } }
        
        public static ScalarModelOuterMapOfArrayType Null { get { return new ScalarModelOuterMapOfArrayType("null"); } }

        public override string ToString() { return Value; }
        public static implicit operator String(ScalarModelOuterMapOfArrayType v) { return v.Value; }
        public static ScalarModelOuterMapOfArrayType FromString(string v) {
            switch(v) {
                case "int32": return Int32;
                case "boolean": return Boolean;
                case "any": return Any;
                case "null": return Null;
                default: throw new ArgumentException("Invalid value for ScalarModelOuterMapOfArrayType");
            }
        }
        public override bool Equals(object? obj)
        {
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }
            return Value.Equals(((ScalarModelOuterMapOfArrayType)obj).Value);
        }

        public override int GetHashCode()
        {
            return Value.GetHashCode();
        }
    }
    

    [JsonConverter(typeof(ScalarModelOuterMapOfArray.ScalarModelOuterMapOfArrayConverter))]
    public class ScalarModelOuterMapOfArray {
        public ScalarModelOuterMapOfArray(ScalarModelOuterMapOfArrayType type) {
            Type = type;
        }
        public int? Int32 { get; set; } 
        public bool? Boolean { get; set; } 
        public object? Any { get; set; } 

        public ScalarModelOuterMapOfArrayType Type { get; set; }


        public static ScalarModelOuterMapOfArray CreateInt32(int int32) {
            ScalarModelOuterMapOfArrayType typ = ScalarModelOuterMapOfArrayType.Int32;

            ScalarModelOuterMapOfArray res = new ScalarModelOuterMapOfArray(typ);
            res.Int32 = int32;
            return res;
        }

        public static ScalarModelOuterMapOfArray CreateBoolean(bool boolean) {
            ScalarModelOuterMapOfArrayType typ = ScalarModelOuterMapOfArrayType.Boolean;

            ScalarModelOuterMapOfArray res = new ScalarModelOuterMapOfArray(typ);
            res.Boolean = boolean;
            return res;
        }

        public static ScalarModelOuterMapOfArray CreateAny(object any) {
            ScalarModelOuterMapOfArrayType typ = ScalarModelOuterMapOfArrayType.Any;

            ScalarModelOuterMapOfArray res = new ScalarModelOuterMapOfArray(typ);
            res.Any = any;
            return res;
        }

        public static ScalarModelOuterMapOfArray CreateNull() {
            ScalarModelOuterMapOfArrayType typ = ScalarModelOuterMapOfArrayType.Null;
            return new ScalarModelOuterMapOfArray(typ);
        }

        public class ScalarModelOuterMapOfArrayConverter : JsonConverter
        {

            public override bool CanConvert(System.Type objectType) => objectType == typeof(ScalarModelOuterMapOfArray);

            public override bool CanRead => true;

            public override object? ReadJson(JsonReader reader, System.Type objectType, object? existingValue, JsonSerializer serializer)
            { 
                var json = JRaw.Create(reader).ToString();

                if (json == "null") {
                    return null;
                } 
                try {
                    var converted = Convert.ToInt32(json);
                    return new ScalarModelOuterMapOfArray(ScalarModelOuterMapOfArrayType.Int32) {
                        Int32 = converted
                    };
                } catch (System.FormatException) {
                    // try next option
                } 
                try {
                    var converted = Convert.ToBoolean(json);
                    return new ScalarModelOuterMapOfArray(ScalarModelOuterMapOfArrayType.Boolean) {
                        Boolean = converted
                    };
                } catch (System.FormatException) {
                    // try next option
                }
                try
                {
                    object? any = JsonConvert.DeserializeObject<object>(json, new JsonSerializerSettings(){ NullValueHandling = NullValueHandling.Ignore, MissingMemberHandling = MissingMemberHandling.Error, Converters = Utilities.GetJsonConverters(typeof(object))});
                    return new ScalarModelOuterMapOfArray(ScalarModelOuterMapOfArrayType.Any) {
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
                ScalarModelOuterMapOfArray res = (ScalarModelOuterMapOfArray)value;
                if (ScalarModelOuterMapOfArrayType.FromString(res.Type).Equals(ScalarModelOuterMapOfArrayType.Null))
                {
                    writer.WriteRawValue("null");
                    return;
                }
                if (res.Int32 != null)
                {
                    writer.WriteRawValue(Utilities.SerializeJSON(res.Int32));
                    return;
                }
                if (res.Boolean != null)
                {
                    writer.WriteRawValue(Utilities.SerializeJSON(res.Boolean));
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