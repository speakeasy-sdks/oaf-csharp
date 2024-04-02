
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
    

    public class SendCombinedRequestBodyBodyNonScalarType
    {
        private SendCombinedRequestBodyBodyNonScalarType(string value) { Value = value; }

        public string Value { get; private set; }
        public static SendCombinedRequestBodyBodyNonScalarType ArrayOfAtom { get { return new SendCombinedRequestBodyBodyNonScalarType("arrayOfAtom"); } }
        
        public static SendCombinedRequestBodyBodyNonScalarType Atom { get { return new SendCombinedRequestBodyBodyNonScalarType("Atom"); } }
        
        public static SendCombinedRequestBodyBodyNonScalarType Null { get { return new SendCombinedRequestBodyBodyNonScalarType("null"); } }

        public override string ToString() { return Value; }
        public static implicit operator String(SendCombinedRequestBodyBodyNonScalarType v) { return v.Value; }
        public static SendCombinedRequestBodyBodyNonScalarType FromString(string v) {
            switch(v) {
                case "arrayOfAtom": return ArrayOfAtom;
                case "Atom": return Atom;
                case "null": return Null;
                default: throw new ArgumentException("Invalid value for SendCombinedRequestBodyBodyNonScalarType");
            }
        }
        public override bool Equals(object? obj)
        {
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }
            return Value.Equals(((SendCombinedRequestBodyBodyNonScalarType)obj).Value);
        }

        public override int GetHashCode()
        {
            return Value.GetHashCode();
        }
    }
    

    [JsonConverter(typeof(SendCombinedRequestBodyBodyNonScalar.SendCombinedRequestBodyBodyNonScalarConverter))]
    public class SendCombinedRequestBodyBodyNonScalar {
        public SendCombinedRequestBodyBodyNonScalar(SendCombinedRequestBodyBodyNonScalarType type) {
            Type = type;
        }
        public List<Atom>? ArrayOfAtom { get; set; } 
        public Atom? Atom { get; set; } 

        public SendCombinedRequestBodyBodyNonScalarType Type { get; set; }


        public static SendCombinedRequestBodyBodyNonScalar CreateArrayOfAtom(List<Atom> arrayOfAtom) {
            SendCombinedRequestBodyBodyNonScalarType typ = SendCombinedRequestBodyBodyNonScalarType.ArrayOfAtom;

            SendCombinedRequestBodyBodyNonScalar res = new SendCombinedRequestBodyBodyNonScalar(typ);
            res.ArrayOfAtom = arrayOfAtom;
            return res;
        }

        public static SendCombinedRequestBodyBodyNonScalar CreateAtom(Atom atom) {
            SendCombinedRequestBodyBodyNonScalarType typ = SendCombinedRequestBodyBodyNonScalarType.Atom;

            SendCombinedRequestBodyBodyNonScalar res = new SendCombinedRequestBodyBodyNonScalar(typ);
            res.Atom = atom;
            return res;
        }

        public static SendCombinedRequestBodyBodyNonScalar CreateNull() {
            SendCombinedRequestBodyBodyNonScalarType typ = SendCombinedRequestBodyBodyNonScalarType.Null;
            return new SendCombinedRequestBodyBodyNonScalar(typ);
        }

        public class SendCombinedRequestBodyBodyNonScalarConverter : JsonConverter
        {

            public override bool CanConvert(System.Type objectType) => objectType == typeof(SendCombinedRequestBodyBodyNonScalar);

            public override bool CanRead => true;

            public override object? ReadJson(JsonReader reader, System.Type objectType, object? existingValue, JsonSerializer serializer)
            { 
                var json = JRaw.Create(reader).ToString();

                if (json == "null") {
                    return null;
                }
                try
                {
                    Atom? atom = ResponseBodyDeserializer.Deserialize<Atom>(json, missingMemberHandling: MissingMemberHandling.Error);
                    return new SendCombinedRequestBodyBodyNonScalar(SendCombinedRequestBodyBodyNonScalarType.Atom) {
                        Atom = atom
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
                    List<Atom>? arrayOfAtom = ResponseBodyDeserializer.Deserialize<List<Atom>>(json, missingMemberHandling: MissingMemberHandling.Error);
                    return new SendCombinedRequestBodyBodyNonScalar(SendCombinedRequestBodyBodyNonScalarType.ArrayOfAtom) {
                        ArrayOfAtom = arrayOfAtom
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
                SendCombinedRequestBodyBodyNonScalar res = (SendCombinedRequestBodyBodyNonScalar)value;
                if (SendCombinedRequestBodyBodyNonScalarType.FromString(res.Type).Equals(SendCombinedRequestBodyBodyNonScalarType.Null))
                {
                    writer.WriteRawValue("null");
                    return;
                }
                if (res.ArrayOfAtom != null)
                {
                    writer.WriteRawValue(Utilities.SerializeJSON(res.ArrayOfAtom));
                    return;
                }
                if (res.Atom != null)
                {
                    writer.WriteRawValue(Utilities.SerializeJSON(res.Atom));
                    return;
                }

            }
        }

    }

}