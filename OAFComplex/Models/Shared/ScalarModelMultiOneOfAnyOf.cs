
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
    

    public class ScalarModelMultiOneOfAnyOfType
    {
        private ScalarModelMultiOneOfAnyOfType(string value) { Value = value; }

        public string Value { get; private set; }
        public static ScalarModelMultiOneOfAnyOfType ScalarModelSchemas1 { get { return new ScalarModelMultiOneOfAnyOfType("ScalarModel_Schemas_1"); } }
        
        public static ScalarModelMultiOneOfAnyOfType Str { get { return new ScalarModelMultiOneOfAnyOfType("str"); } }
        
        public static ScalarModelMultiOneOfAnyOfType Null { get { return new ScalarModelMultiOneOfAnyOfType("null"); } }

        public override string ToString() { return Value; }
        public static implicit operator String(ScalarModelMultiOneOfAnyOfType v) { return v.Value; }
        public static ScalarModelMultiOneOfAnyOfType FromString(string v) {
            switch(v) {
                case "ScalarModel_Schemas_1": return ScalarModelSchemas1;
                case "str": return Str;
                case "null": return Null;
                default: throw new ArgumentException("Invalid value for ScalarModelMultiOneOfAnyOfType");
            }
        }
        public override bool Equals(object? obj)
        {
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }
            return Value.Equals(((ScalarModelMultiOneOfAnyOfType)obj).Value);
        }

        public override int GetHashCode()
        {
            return Value.GetHashCode();
        }
    }
    

    [JsonConverter(typeof(ScalarModelMultiOneOfAnyOf.ScalarModelMultiOneOfAnyOfConverter))]
    public class ScalarModelMultiOneOfAnyOf {
        public ScalarModelMultiOneOfAnyOf(ScalarModelMultiOneOfAnyOfType type) {
            Type = type;
        }
        public ScalarModelSchemas1? ScalarModelSchemas1 { get; set; } 
        public string? Str { get; set; } 

        public ScalarModelMultiOneOfAnyOfType Type { get; set; }


        public static ScalarModelMultiOneOfAnyOf CreateScalarModelSchemas1(ScalarModelSchemas1 scalarModelSchemas1) {
            ScalarModelMultiOneOfAnyOfType typ = ScalarModelMultiOneOfAnyOfType.ScalarModelSchemas1;

            ScalarModelMultiOneOfAnyOf res = new ScalarModelMultiOneOfAnyOf(typ);
            res.ScalarModelSchemas1 = scalarModelSchemas1;
            return res;
        }

        public static ScalarModelMultiOneOfAnyOf CreateStr(string str) {
            ScalarModelMultiOneOfAnyOfType typ = ScalarModelMultiOneOfAnyOfType.Str;

            ScalarModelMultiOneOfAnyOf res = new ScalarModelMultiOneOfAnyOf(typ);
            res.Str = str;
            return res;
        }

        public static ScalarModelMultiOneOfAnyOf CreateNull() {
            ScalarModelMultiOneOfAnyOfType typ = ScalarModelMultiOneOfAnyOfType.Null;
            return new ScalarModelMultiOneOfAnyOf(typ);
        }

        public class ScalarModelMultiOneOfAnyOfConverter : JsonConverter
        {

            public override bool CanConvert(System.Type objectType) => objectType == typeof(ScalarModelMultiOneOfAnyOf);

            public override bool CanRead => true;

            public override object? ReadJson(JsonReader reader, System.Type objectType, object? existingValue, JsonSerializer serializer)
            { 
                var json = JRaw.Create(reader).ToString();

                if (json == "null") {
                    return null;
                }
                try
                {
                    ScalarModelSchemas1? scalarModelSchemas1 = JsonConvert.DeserializeObject<ScalarModelSchemas1>(json, new JsonSerializerSettings(){ NullValueHandling = NullValueHandling.Ignore, MissingMemberHandling = MissingMemberHandling.Error, Converters = Utilities.GetJsonConverters(typeof(ScalarModelSchemas1))});
                    return new ScalarModelMultiOneOfAnyOf(ScalarModelMultiOneOfAnyOfType.ScalarModelSchemas1) {
                        ScalarModelSchemas1 = scalarModelSchemas1
                    };
                }
                catch (Exception ex)
                {
                    if (!(ex is Newtonsoft.Json.JsonReaderException || ex is Newtonsoft.Json.JsonSerializationException)) {
                        throw ex;
                    }
                }
                if (json[0] == '"' && json[^1] == '"'){
                    return new ScalarModelMultiOneOfAnyOf(ScalarModelMultiOneOfAnyOfType.Str) {
                        Str = json[1..^1]
                    };
                }

                throw new InvalidOperationException("Could not deserialize into any supported types.");
            }

            public override void WriteJson(JsonWriter writer, object? value, JsonSerializer serializer)
            {
                if (value == null) {
                    writer.WriteRawValue("null");
                    return;
                }
                ScalarModelMultiOneOfAnyOf res = (ScalarModelMultiOneOfAnyOf)value;
                if (ScalarModelMultiOneOfAnyOfType.FromString(res.Type).Equals(ScalarModelMultiOneOfAnyOfType.Null))
                {
                    writer.WriteRawValue("null");
                    return;
                }
                if (res.ScalarModelSchemas1 != null)
                {
                    writer.WriteRawValue(Utilities.SerializeJSON(res.ScalarModelSchemas1));
                    return;
                }
                if (res.Str != null)
                {
                    writer.WriteRawValue(Utilities.SerializeJSON(res.Str));
                    return;
                }

            }
        }

    }

}