
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
    using System.Numerics;
    using System;
    

    public class NonScalarModelMultiOneOfAnyOfType
    {
        private NonScalarModelMultiOneOfAnyOfType(string value) { Value = value; }

        public string Value { get; private set; }
        public static NonScalarModelMultiOneOfAnyOfType NonScalarModelSchemas1 { get { return new NonScalarModelMultiOneOfAnyOfType("NonScalarModel_Schemas_1"); } }
        
        public static NonScalarModelMultiOneOfAnyOfType Morning { get { return new NonScalarModelMultiOneOfAnyOfType("Morning"); } }
        
        public static NonScalarModelMultiOneOfAnyOfType Null { get { return new NonScalarModelMultiOneOfAnyOfType("null"); } }

        public override string ToString() { return Value; }
        public static implicit operator String(NonScalarModelMultiOneOfAnyOfType v) { return v.Value; }
        public static NonScalarModelMultiOneOfAnyOfType FromString(string v) {
            switch(v) {
                case "NonScalarModel_Schemas_1": return NonScalarModelSchemas1;
                case "Morning": return Morning;
                case "null": return Null;
                default: throw new ArgumentException("Invalid value for NonScalarModelMultiOneOfAnyOfType");
            }
        }
        public override bool Equals(object? obj)
        {
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }
            return Value.Equals(((NonScalarModelMultiOneOfAnyOfType)obj).Value);
        }

        public override int GetHashCode()
        {
            return Value.GetHashCode();
        }
    }
    

    [JsonConverter(typeof(NonScalarModelMultiOneOfAnyOf.NonScalarModelMultiOneOfAnyOfConverter))]
    public class NonScalarModelMultiOneOfAnyOf {
        public NonScalarModelMultiOneOfAnyOf(NonScalarModelMultiOneOfAnyOfType type) {
            Type = type;
        }
        public NonScalarModelSchemas1? NonScalarModelSchemas1 { get; set; } 
        public Morning? Morning { get; set; } 

        public NonScalarModelMultiOneOfAnyOfType Type { get; set; }


        public static NonScalarModelMultiOneOfAnyOf CreateNonScalarModelSchemas1(NonScalarModelSchemas1 nonScalarModelSchemas1) {
            NonScalarModelMultiOneOfAnyOfType typ = NonScalarModelMultiOneOfAnyOfType.NonScalarModelSchemas1;

            NonScalarModelMultiOneOfAnyOf res = new NonScalarModelMultiOneOfAnyOf(typ);
            res.NonScalarModelSchemas1 = nonScalarModelSchemas1;
            return res;
        }

        public static NonScalarModelMultiOneOfAnyOf CreateMorning(Morning morning) {
            NonScalarModelMultiOneOfAnyOfType typ = NonScalarModelMultiOneOfAnyOfType.Morning;

            NonScalarModelMultiOneOfAnyOf res = new NonScalarModelMultiOneOfAnyOf(typ);
            res.Morning = morning;
            return res;
        }

        public static NonScalarModelMultiOneOfAnyOf CreateNull() {
            NonScalarModelMultiOneOfAnyOfType typ = NonScalarModelMultiOneOfAnyOfType.Null;
            return new NonScalarModelMultiOneOfAnyOf(typ);
        }

        public class NonScalarModelMultiOneOfAnyOfConverter : JsonConverter
        {

            public override bool CanConvert(System.Type objectType) => objectType == typeof(NonScalarModelMultiOneOfAnyOf);

            public override bool CanRead => true;

            public override object? ReadJson(JsonReader reader, System.Type objectType, object? existingValue, JsonSerializer serializer)
            { 
                var json = JRaw.Create(reader).ToString();

                if (json == "null") {
                    return null;
                }
                try
                {
                    Morning? morning = ResponseBodyDeserializer.Deserialize<Morning>(json, missingMemberHandling: MissingMemberHandling.Error);
                    return new NonScalarModelMultiOneOfAnyOf(NonScalarModelMultiOneOfAnyOfType.Morning) {
                        Morning = morning
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
                    NonScalarModelSchemas1? nonScalarModelSchemas1 = ResponseBodyDeserializer.Deserialize<NonScalarModelSchemas1>(json, missingMemberHandling: MissingMemberHandling.Error);
                    return new NonScalarModelMultiOneOfAnyOf(NonScalarModelMultiOneOfAnyOfType.NonScalarModelSchemas1) {
                        NonScalarModelSchemas1 = nonScalarModelSchemas1
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
                NonScalarModelMultiOneOfAnyOf res = (NonScalarModelMultiOneOfAnyOf)value;
                if (NonScalarModelMultiOneOfAnyOfType.FromString(res.Type).Equals(NonScalarModelMultiOneOfAnyOfType.Null))
                {
                    writer.WriteRawValue("null");
                    return;
                }
                if (res.NonScalarModelSchemas1 != null)
                {
                    writer.WriteRawValue(Utilities.SerializeJSON(res.NonScalarModelSchemas1));
                    return;
                }
                if (res.Morning != null)
                {
                    writer.WriteRawValue(Utilities.SerializeJSON(res.Morning));
                    return;
                }

            }
        }

    }

}