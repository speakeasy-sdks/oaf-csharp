
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
    

    public class BodyNonScalarType
    {
        private BodyNonScalarType(string value) { Value = value; }

        public string Value { get; private set; }
        public static BodyNonScalarType ArrayOfAtom { get { return new BodyNonScalarType("arrayOfAtom"); } }
        
        public static BodyNonScalarType Atom { get { return new BodyNonScalarType("Atom"); } }
        
        public static BodyNonScalarType Null { get { return new BodyNonScalarType("null"); } }

        public override string ToString() { return Value; }
        public static implicit operator String(BodyNonScalarType v) { return v.Value; }
        public static BodyNonScalarType FromString(string v) {
            switch(v) {
                case "arrayOfAtom": return ArrayOfAtom;
                case "Atom": return Atom;
                case "null": return Null;
                default: throw new ArgumentException("Invalid value for BodyNonScalarType");
            }
        }
        public override bool Equals(object? obj)
        {
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }
            return Value.Equals(((BodyNonScalarType)obj).Value);
        }

        public override int GetHashCode()
        {
            return Value.GetHashCode();
        }
    }
    

    [JsonConverter(typeof(BodyNonScalar.BodyNonScalarConverter))]
    public class BodyNonScalar {
        public BodyNonScalar(BodyNonScalarType type) {
            Type = type;
        }
        public List<Atom>? ArrayOfAtom { get; set; } 
        public Atom? Atom { get; set; } 

        public BodyNonScalarType Type { get; set; }


        public static BodyNonScalar CreateArrayOfAtom(List<Atom> arrayOfAtom) {
            BodyNonScalarType typ = BodyNonScalarType.ArrayOfAtom;

            BodyNonScalar res = new BodyNonScalar(typ);
            res.ArrayOfAtom = arrayOfAtom;
            return res;
        }

        public static BodyNonScalar CreateAtom(Atom atom) {
            BodyNonScalarType typ = BodyNonScalarType.Atom;

            BodyNonScalar res = new BodyNonScalar(typ);
            res.Atom = atom;
            return res;
        }

        public static BodyNonScalar CreateNull() {
            BodyNonScalarType typ = BodyNonScalarType.Null;
            return new BodyNonScalar(typ);
        }

        public class BodyNonScalarConverter : JsonConverter
        {

            public override bool CanConvert(System.Type objectType) => objectType == typeof(BodyNonScalar);

            public override bool CanRead => true;

            public override object? ReadJson(JsonReader reader, System.Type objectType, object? existingValue, JsonSerializer serializer)
            { 
                var json = JRaw.Create(reader).ToString();

                if (json == "null") {
                    return null;
                }
                try
                {
                    Atom? atom = JsonConvert.DeserializeObject<Atom>(json, new JsonSerializerSettings(){ NullValueHandling = NullValueHandling.Ignore, MissingMemberHandling = MissingMemberHandling.Error, Converters = Utilities.GetJsonConverters(typeof(Atom))});
                    return new BodyNonScalar(BodyNonScalarType.Atom) {
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
                    List<Atom>? arrayOfAtom = JsonConvert.DeserializeObject<List<Atom>>(json, new JsonSerializerSettings(){ NullValueHandling = NullValueHandling.Ignore, MissingMemberHandling = MissingMemberHandling.Error, Converters = Utilities.GetJsonConverters(typeof(List<Atom>))});
                    return new BodyNonScalar(BodyNonScalarType.ArrayOfAtom) {
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
                BodyNonScalar res = (BodyNonScalar)value;
                if (BodyNonScalarType.FromString(res.Type).Equals(BodyNonScalarType.Null))
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