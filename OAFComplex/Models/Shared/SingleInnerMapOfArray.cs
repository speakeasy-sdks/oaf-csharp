
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
    

    public class SingleInnerMapOfArrayType
    {
        private SingleInnerMapOfArrayType(string value) { Value = value; }

        public string Value { get; private set; }
        public static SingleInnerMapOfArrayType MapOfarrayOfint32 { get { return new SingleInnerMapOfArrayType("mapOfarrayOfint32"); } }
        
        public static SingleInnerMapOfArrayType MapOfOrbit { get { return new SingleInnerMapOfArrayType("mapOfOrbit"); } }
        
        public static SingleInnerMapOfArrayType Null { get { return new SingleInnerMapOfArrayType("null"); } } 

        public override string ToString() { return Value; }
        public static implicit operator String(SingleInnerMapOfArrayType v) { return v.Value; }
        public static SingleInnerMapOfArrayType FromString(string v) {
            switch(v) {
                case "mapOfarrayOfint32": return MapOfarrayOfint32;
                case "mapOfOrbit": return MapOfOrbit;
                case "null": return Null;
                default: throw new ArgumentException("Invalid value for SingleInnerMapOfArrayType");
            }
        }
        public override bool Equals(object? obj)
        {
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }
            return Value.Equals(((SingleInnerMapOfArrayType)obj).Value);
        }

        public override int GetHashCode()
        {
            return Value.GetHashCode();
        }
    }
    

    [JsonConverter(typeof(SingleInnerMapOfArray.SingleInnerMapOfArrayConverter))]
    public class SingleInnerMapOfArray {
        public SingleInnerMapOfArray(SingleInnerMapOfArrayType type) {
            Type = type;
        }
        public Dictionary<string, List<int>>? MapOfarrayOfint32 { get; set; } 
        public Dictionary<string, Orbit>? MapOfOrbit { get; set; } 

        public SingleInnerMapOfArrayType Type {get; set; }


        public static SingleInnerMapOfArray CreateMapOfarrayOfint32(Dictionary<string, List<int>> mapOfarrayOfint32) {
            SingleInnerMapOfArrayType typ = SingleInnerMapOfArrayType.MapOfarrayOfint32;

            SingleInnerMapOfArray res = new SingleInnerMapOfArray(typ);
            res.MapOfarrayOfint32 = mapOfarrayOfint32;
            return res;
        }

        public static SingleInnerMapOfArray CreateMapOfOrbit(Dictionary<string, Orbit> mapOfOrbit) {
            SingleInnerMapOfArrayType typ = SingleInnerMapOfArrayType.MapOfOrbit;

            SingleInnerMapOfArray res = new SingleInnerMapOfArray(typ);
            res.MapOfOrbit = mapOfOrbit;
            return res;
        }

        public static SingleInnerMapOfArray CreateNull() {
            SingleInnerMapOfArrayType typ = SingleInnerMapOfArrayType.Null;
            return new SingleInnerMapOfArray(typ);
        }

        public class SingleInnerMapOfArrayConverter : JsonConverter
        {

            public override bool CanConvert(System.Type objectType) => objectType == typeof(SingleInnerMapOfArray);

            public override bool CanRead => true;

            public override object? ReadJson(JsonReader reader, System.Type objectType, object? existingValue, JsonSerializer serializer)
            { 
                var json = JRaw.Create(reader).ToString();

                if (json == "null") {
                    return null;
                }
                try
                {
                    Dictionary<string, List<int>>? mapOfarrayOfint32 = JsonConvert.DeserializeObject<Dictionary<string, List<int>>>(json, new JsonSerializerSettings(){ NullValueHandling = NullValueHandling.Ignore, MissingMemberHandling = MissingMemberHandling.Error, Converters = Utilities.GetJsonConverters(typeof(Dictionary<string, List<int>>), "string")});
                    return new SingleInnerMapOfArray(SingleInnerMapOfArrayType.MapOfarrayOfint32) {
                        MapOfarrayOfint32 = mapOfarrayOfint32
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
                    Dictionary<string, Orbit>? mapOfOrbit = JsonConvert.DeserializeObject<Dictionary<string, Orbit>>(json, new JsonSerializerSettings(){ NullValueHandling = NullValueHandling.Ignore, MissingMemberHandling = MissingMemberHandling.Error, Converters = Utilities.GetJsonConverters(typeof(Dictionary<string, Orbit>), "string")});
                    return new SingleInnerMapOfArray(SingleInnerMapOfArrayType.MapOfOrbit) {
                        MapOfOrbit = mapOfOrbit
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
                SingleInnerMapOfArray res = (SingleInnerMapOfArray)value;
                if (SingleInnerMapOfArrayType.FromString(res.Type).Equals(SingleInnerMapOfArrayType.Null))
                {
                    writer.WriteRawValue("null");
                    return;
                }
                if (res.MapOfarrayOfint32 != null)
                {
                    writer.WriteRawValue(Utilities.SerializeJSON(res.MapOfarrayOfint32));
                    return;
                }
                if (res.MapOfOrbit != null)
                {
                    writer.WriteRawValue(Utilities.SerializeJSON(res.MapOfOrbit));
                    return;
                }

            }
        }

    }


}