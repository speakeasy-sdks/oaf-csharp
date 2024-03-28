
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
    

    public class NonScalarModelSingleInnerMapOfArrayType
    {
        private NonScalarModelSingleInnerMapOfArrayType(string value) { Value = value; }

        public string Value { get; private set; }
        public static NonScalarModelSingleInnerMapOfArrayType MapOfarrayOfAtom { get { return new NonScalarModelSingleInnerMapOfArrayType("mapOfarrayOfAtom"); } }
        
        public static NonScalarModelSingleInnerMapOfArrayType MapOfAtom { get { return new NonScalarModelSingleInnerMapOfArrayType("mapOfAtom"); } }
        
        public static NonScalarModelSingleInnerMapOfArrayType Null { get { return new NonScalarModelSingleInnerMapOfArrayType("null"); } }

        public override string ToString() { return Value; }
        public static implicit operator String(NonScalarModelSingleInnerMapOfArrayType v) { return v.Value; }
        public static NonScalarModelSingleInnerMapOfArrayType FromString(string v) {
            switch(v) {
                case "mapOfarrayOfAtom": return MapOfarrayOfAtom;
                case "mapOfAtom": return MapOfAtom;
                case "null": return Null;
                default: throw new ArgumentException("Invalid value for NonScalarModelSingleInnerMapOfArrayType");
            }
        }
        public override bool Equals(object? obj)
        {
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }
            return Value.Equals(((NonScalarModelSingleInnerMapOfArrayType)obj).Value);
        }

        public override int GetHashCode()
        {
            return Value.GetHashCode();
        }
    }
    

    [JsonConverter(typeof(NonScalarModelSingleInnerMapOfArray.NonScalarModelSingleInnerMapOfArrayConverter))]
    public class NonScalarModelSingleInnerMapOfArray {
        public NonScalarModelSingleInnerMapOfArray(NonScalarModelSingleInnerMapOfArrayType type) {
            Type = type;
        }
        public Dictionary<string, List<Atom>>? MapOfarrayOfAtom { get; set; } 
        public Dictionary<string, Atom>? MapOfAtom { get; set; } 

        public NonScalarModelSingleInnerMapOfArrayType Type { get; set; }


        public static NonScalarModelSingleInnerMapOfArray CreateMapOfarrayOfAtom(Dictionary<string, List<Atom>> mapOfarrayOfAtom) {
            NonScalarModelSingleInnerMapOfArrayType typ = NonScalarModelSingleInnerMapOfArrayType.MapOfarrayOfAtom;

            NonScalarModelSingleInnerMapOfArray res = new NonScalarModelSingleInnerMapOfArray(typ);
            res.MapOfarrayOfAtom = mapOfarrayOfAtom;
            return res;
        }

        public static NonScalarModelSingleInnerMapOfArray CreateMapOfAtom(Dictionary<string, Atom> mapOfAtom) {
            NonScalarModelSingleInnerMapOfArrayType typ = NonScalarModelSingleInnerMapOfArrayType.MapOfAtom;

            NonScalarModelSingleInnerMapOfArray res = new NonScalarModelSingleInnerMapOfArray(typ);
            res.MapOfAtom = mapOfAtom;
            return res;
        }

        public static NonScalarModelSingleInnerMapOfArray CreateNull() {
            NonScalarModelSingleInnerMapOfArrayType typ = NonScalarModelSingleInnerMapOfArrayType.Null;
            return new NonScalarModelSingleInnerMapOfArray(typ);
        }

        public class NonScalarModelSingleInnerMapOfArrayConverter : JsonConverter
        {

            public override bool CanConvert(System.Type objectType) => objectType == typeof(NonScalarModelSingleInnerMapOfArray);

            public override bool CanRead => true;

            public override object? ReadJson(JsonReader reader, System.Type objectType, object? existingValue, JsonSerializer serializer)
            { 
                var json = JRaw.Create(reader).ToString();

                if (json == "null") {
                    return null;
                }
                try
                {
                    Dictionary<string, List<Atom>>? mapOfarrayOfAtom = JsonConvert.DeserializeObject<Dictionary<string, List<Atom>>>(json, new JsonSerializerSettings(){ NullValueHandling = NullValueHandling.Ignore, MissingMemberHandling = MissingMemberHandling.Error, Converters = Utilities.GetJsonConverters(typeof(Dictionary<string, List<Atom>>))});
                    return new NonScalarModelSingleInnerMapOfArray(NonScalarModelSingleInnerMapOfArrayType.MapOfarrayOfAtom) {
                        MapOfarrayOfAtom = mapOfarrayOfAtom
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
                    Dictionary<string, Atom>? mapOfAtom = JsonConvert.DeserializeObject<Dictionary<string, Atom>>(json, new JsonSerializerSettings(){ NullValueHandling = NullValueHandling.Ignore, MissingMemberHandling = MissingMemberHandling.Error, Converters = Utilities.GetJsonConverters(typeof(Dictionary<string, Atom>))});
                    return new NonScalarModelSingleInnerMapOfArray(NonScalarModelSingleInnerMapOfArrayType.MapOfAtom) {
                        MapOfAtom = mapOfAtom
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
                NonScalarModelSingleInnerMapOfArray res = (NonScalarModelSingleInnerMapOfArray)value;
                if (NonScalarModelSingleInnerMapOfArrayType.FromString(res.Type).Equals(NonScalarModelSingleInnerMapOfArrayType.Null))
                {
                    writer.WriteRawValue("null");
                    return;
                }
                if (res.MapOfarrayOfAtom != null)
                {
                    writer.WriteRawValue(Utilities.SerializeJSON(res.MapOfarrayOfAtom));
                    return;
                }
                if (res.MapOfAtom != null)
                {
                    writer.WriteRawValue(Utilities.SerializeJSON(res.MapOfAtom));
                    return;
                }

            }
        }

    }

}