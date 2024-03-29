
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
    

    public class ScalarModelSchemas1Type
    {
        private ScalarModelSchemas1Type(string value) { Value = value; }

        public string Value { get; private set; }
        public static ScalarModelSchemas1Type Number { get { return new ScalarModelSchemas1Type("number"); } }
        
        public static ScalarModelSchemas1Type Int32 { get { return new ScalarModelSchemas1Type("int32"); } }
        
        public static ScalarModelSchemas1Type Null { get { return new ScalarModelSchemas1Type("null"); } }

        public override string ToString() { return Value; }
        public static implicit operator String(ScalarModelSchemas1Type v) { return v.Value; }
        public static ScalarModelSchemas1Type FromString(string v) {
            switch(v) {
                case "number": return Number;
                case "int32": return Int32;
                case "null": return Null;
                default: throw new ArgumentException("Invalid value for ScalarModelSchemas1Type");
            }
        }
        public override bool Equals(object? obj)
        {
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }
            return Value.Equals(((ScalarModelSchemas1Type)obj).Value);
        }

        public override int GetHashCode()
        {
            return Value.GetHashCode();
        }
    }
    

    [JsonConverter(typeof(ScalarModelSchemas1.ScalarModelSchemas1Converter))]
    public class ScalarModelSchemas1 {
        public ScalarModelSchemas1(ScalarModelSchemas1Type type) {
            Type = type;
        }
        public double? Number { get; set; } 
        public int? Int32 { get; set; } 

        public ScalarModelSchemas1Type Type { get; set; }


        public static ScalarModelSchemas1 CreateNumber(double number) {
            ScalarModelSchemas1Type typ = ScalarModelSchemas1Type.Number;

            ScalarModelSchemas1 res = new ScalarModelSchemas1(typ);
            res.Number = number;
            return res;
        }

        public static ScalarModelSchemas1 CreateInt32(int int32) {
            ScalarModelSchemas1Type typ = ScalarModelSchemas1Type.Int32;

            ScalarModelSchemas1 res = new ScalarModelSchemas1(typ);
            res.Int32 = int32;
            return res;
        }

        public static ScalarModelSchemas1 CreateNull() {
            ScalarModelSchemas1Type typ = ScalarModelSchemas1Type.Null;
            return new ScalarModelSchemas1(typ);
        }

        public class ScalarModelSchemas1Converter : JsonConverter
        {

            public override bool CanConvert(System.Type objectType) => objectType == typeof(ScalarModelSchemas1);

            public override bool CanRead => true;

            public override object? ReadJson(JsonReader reader, System.Type objectType, object? existingValue, JsonSerializer serializer)
            { 
                var json = JRaw.Create(reader).ToString();

                if (json == "null") {
                    return null;
                } 
                try {
                    var converted = Convert.ToDouble(json);
                    return new ScalarModelSchemas1(ScalarModelSchemas1Type.Number) {
                        Number = converted
                    };
                } catch (System.FormatException) {
                    // try next option
                } 
                try {
                    var converted = Convert.ToInt32(json);
                    return new ScalarModelSchemas1(ScalarModelSchemas1Type.Int32) {
                        Int32 = converted
                    };
                } catch (System.FormatException) {
                    // try next option
                }

                throw new InvalidOperationException("Could not deserialize into any supported types.");
            }

            public override void WriteJson(JsonWriter writer, object? value, JsonSerializer serializer)
            {
                if (value == null) {
                    writer.WriteRawValue("null");
                    return;
                }
                ScalarModelSchemas1 res = (ScalarModelSchemas1)value;
                if (ScalarModelSchemas1Type.FromString(res.Type).Equals(ScalarModelSchemas1Type.Null))
                {
                    writer.WriteRawValue("null");
                    return;
                }
                if (res.Number != null)
                {
                    writer.WriteRawValue(Utilities.SerializeJSON(res.Number));
                    return;
                }
                if (res.Int32 != null)
                {
                    writer.WriteRawValue(Utilities.SerializeJSON(res.Int32));
                    return;
                }

            }
        }

    }

}