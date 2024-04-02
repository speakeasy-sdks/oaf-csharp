
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
    

    public class ScalarModelOuterMapOfSingleInnerArrayType
    {
        private ScalarModelOuterMapOfSingleInnerArrayType(string value) { Value = value; }

        public string Value { get; private set; }
        public static ScalarModelOuterMapOfSingleInnerArrayType ArrayOfnumber { get { return new ScalarModelOuterMapOfSingleInnerArrayType("arrayOfnumber"); } }
        
        public static ScalarModelOuterMapOfSingleInnerArrayType Number { get { return new ScalarModelOuterMapOfSingleInnerArrayType("number"); } }
        
        public static ScalarModelOuterMapOfSingleInnerArrayType Null { get { return new ScalarModelOuterMapOfSingleInnerArrayType("null"); } }

        public override string ToString() { return Value; }
        public static implicit operator String(ScalarModelOuterMapOfSingleInnerArrayType v) { return v.Value; }
        public static ScalarModelOuterMapOfSingleInnerArrayType FromString(string v) {
            switch(v) {
                case "arrayOfnumber": return ArrayOfnumber;
                case "number": return Number;
                case "null": return Null;
                default: throw new ArgumentException("Invalid value for ScalarModelOuterMapOfSingleInnerArrayType");
            }
        }
        public override bool Equals(object? obj)
        {
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }
            return Value.Equals(((ScalarModelOuterMapOfSingleInnerArrayType)obj).Value);
        }

        public override int GetHashCode()
        {
            return Value.GetHashCode();
        }
    }
    

    [JsonConverter(typeof(ScalarModelOuterMapOfSingleInnerArray.ScalarModelOuterMapOfSingleInnerArrayConverter))]
    public class ScalarModelOuterMapOfSingleInnerArray {
        public ScalarModelOuterMapOfSingleInnerArray(ScalarModelOuterMapOfSingleInnerArrayType type) {
            Type = type;
        }
        public List<double>? ArrayOfnumber { get; set; } 
        public double? Number { get; set; } 

        public ScalarModelOuterMapOfSingleInnerArrayType Type { get; set; }


        public static ScalarModelOuterMapOfSingleInnerArray CreateArrayOfnumber(List<double> arrayOfnumber) {
            ScalarModelOuterMapOfSingleInnerArrayType typ = ScalarModelOuterMapOfSingleInnerArrayType.ArrayOfnumber;

            ScalarModelOuterMapOfSingleInnerArray res = new ScalarModelOuterMapOfSingleInnerArray(typ);
            res.ArrayOfnumber = arrayOfnumber;
            return res;
        }

        public static ScalarModelOuterMapOfSingleInnerArray CreateNumber(double number) {
            ScalarModelOuterMapOfSingleInnerArrayType typ = ScalarModelOuterMapOfSingleInnerArrayType.Number;

            ScalarModelOuterMapOfSingleInnerArray res = new ScalarModelOuterMapOfSingleInnerArray(typ);
            res.Number = number;
            return res;
        }

        public static ScalarModelOuterMapOfSingleInnerArray CreateNull() {
            ScalarModelOuterMapOfSingleInnerArrayType typ = ScalarModelOuterMapOfSingleInnerArrayType.Null;
            return new ScalarModelOuterMapOfSingleInnerArray(typ);
        }

        public class ScalarModelOuterMapOfSingleInnerArrayConverter : JsonConverter
        {

            public override bool CanConvert(System.Type objectType) => objectType == typeof(ScalarModelOuterMapOfSingleInnerArray);

            public override bool CanRead => true;

            public override object? ReadJson(JsonReader reader, System.Type objectType, object? existingValue, JsonSerializer serializer)
            { 
                var json = JRaw.Create(reader).ToString();

                if (json == "null") {
                    return null;
                }
                try
                {
                    List<double>? arrayOfnumber = ResponseBodyDeserializer.Deserialize<List<double>>(json, missingMemberHandling: MissingMemberHandling.Error);
                    return new ScalarModelOuterMapOfSingleInnerArray(ScalarModelOuterMapOfSingleInnerArrayType.ArrayOfnumber) {
                        ArrayOfnumber = arrayOfnumber
                    };
                }
                catch (Exception ex)
                {
                    if (!(ex is Newtonsoft.Json.JsonReaderException || ex is Newtonsoft.Json.JsonSerializationException)) {
                        throw ex;
                    }
                } 
                try {
                    var converted = Convert.ToDouble(json);
                    return new ScalarModelOuterMapOfSingleInnerArray(ScalarModelOuterMapOfSingleInnerArrayType.Number) {
                        Number = converted
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
                ScalarModelOuterMapOfSingleInnerArray res = (ScalarModelOuterMapOfSingleInnerArray)value;
                if (ScalarModelOuterMapOfSingleInnerArrayType.FromString(res.Type).Equals(ScalarModelOuterMapOfSingleInnerArrayType.Null))
                {
                    writer.WriteRawValue("null");
                    return;
                }
                if (res.ArrayOfnumber != null)
                {
                    writer.WriteRawValue(Utilities.SerializeJSON(res.ArrayOfnumber));
                    return;
                }
                if (res.Number != null)
                {
                    writer.WriteRawValue(Utilities.SerializeJSON(res.Number));
                    return;
                }

            }
        }

    }

}