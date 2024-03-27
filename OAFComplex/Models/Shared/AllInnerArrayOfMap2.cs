
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
    

    public class AllInnerArrayOfMap2Type
    {
        private AllInnerArrayOfMap2Type(string value) { Value = value; }

        public string Value { get; private set; }
        public static AllInnerArrayOfMap2Type ArrayOfmapOfboolean { get { return new AllInnerArrayOfMap2Type("arrayOfmapOfboolean"); } }
        
        public static AllInnerArrayOfMap2Type ArrayOfmapOfVehicle { get { return new AllInnerArrayOfMap2Type("arrayOfmapOfVehicle"); } }
        
        public static AllInnerArrayOfMap2Type Any { get { return new AllInnerArrayOfMap2Type("any"); } }
        
        public static AllInnerArrayOfMap2Type Null { get { return new AllInnerArrayOfMap2Type("null"); } }

        public override string ToString() { return Value; }
        public static implicit operator String(AllInnerArrayOfMap2Type v) { return v.Value; }
        public static AllInnerArrayOfMap2Type FromString(string v) {
            switch(v) {
                case "arrayOfmapOfboolean": return ArrayOfmapOfboolean;
                case "arrayOfmapOfVehicle": return ArrayOfmapOfVehicle;
                case "any": return Any;
                case "null": return Null;
                default: throw new ArgumentException("Invalid value for AllInnerArrayOfMap2Type");
            }
        }
        public override bool Equals(object? obj)
        {
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }
            return Value.Equals(((AllInnerArrayOfMap2Type)obj).Value);
        }

        public override int GetHashCode()
        {
            return Value.GetHashCode();
        }
    }
    

    [JsonConverter(typeof(AllInnerArrayOfMap2.AllInnerArrayOfMap2Converter))]
    public class AllInnerArrayOfMap2 {
        public AllInnerArrayOfMap2(AllInnerArrayOfMap2Type type) {
            Type = type;
        }
        public List<Dictionary<string, bool>>? ArrayOfmapOfboolean { get; set; } 
        public List<Dictionary<string, Vehicle>>? ArrayOfmapOfVehicle { get; set; } 
        public object? Any { get; set; } 

        public AllInnerArrayOfMap2Type Type { get; set; }


        public static AllInnerArrayOfMap2 CreateArrayOfmapOfboolean(List<Dictionary<string, bool>> arrayOfmapOfboolean) {
            AllInnerArrayOfMap2Type typ = AllInnerArrayOfMap2Type.ArrayOfmapOfboolean;

            AllInnerArrayOfMap2 res = new AllInnerArrayOfMap2(typ);
            res.ArrayOfmapOfboolean = arrayOfmapOfboolean;
            return res;
        }

        public static AllInnerArrayOfMap2 CreateArrayOfmapOfVehicle(List<Dictionary<string, Vehicle>> arrayOfmapOfVehicle) {
            AllInnerArrayOfMap2Type typ = AllInnerArrayOfMap2Type.ArrayOfmapOfVehicle;

            AllInnerArrayOfMap2 res = new AllInnerArrayOfMap2(typ);
            res.ArrayOfmapOfVehicle = arrayOfmapOfVehicle;
            return res;
        }

        public static AllInnerArrayOfMap2 CreateAny(object any) {
            AllInnerArrayOfMap2Type typ = AllInnerArrayOfMap2Type.Any;

            AllInnerArrayOfMap2 res = new AllInnerArrayOfMap2(typ);
            res.Any = any;
            return res;
        }

        public static AllInnerArrayOfMap2 CreateNull() {
            AllInnerArrayOfMap2Type typ = AllInnerArrayOfMap2Type.Null;
            return new AllInnerArrayOfMap2(typ);
        }

        public class AllInnerArrayOfMap2Converter : JsonConverter
        {

            public override bool CanConvert(System.Type objectType) => objectType == typeof(AllInnerArrayOfMap2);

            public override bool CanRead => true;

            public override object? ReadJson(JsonReader reader, System.Type objectType, object? existingValue, JsonSerializer serializer)
            { 
                var json = JRaw.Create(reader).ToString();

                if (json == "null") {
                    return null;
                }
                try
                {
                    List<Dictionary<string, bool>>? arrayOfmapOfboolean = JsonConvert.DeserializeObject<List<Dictionary<string, bool>>>(json, new JsonSerializerSettings(){ NullValueHandling = NullValueHandling.Ignore, MissingMemberHandling = MissingMemberHandling.Error, Converters = Utilities.GetJsonConverters(typeof(List<Dictionary<string, bool>>))});
                    return new AllInnerArrayOfMap2(AllInnerArrayOfMap2Type.ArrayOfmapOfboolean) {
                        ArrayOfmapOfboolean = arrayOfmapOfboolean
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
                    List<Dictionary<string, Vehicle>>? arrayOfmapOfVehicle = JsonConvert.DeserializeObject<List<Dictionary<string, Vehicle>>>(json, new JsonSerializerSettings(){ NullValueHandling = NullValueHandling.Ignore, MissingMemberHandling = MissingMemberHandling.Error, Converters = Utilities.GetJsonConverters(typeof(List<Dictionary<string, Vehicle>>))});
                    return new AllInnerArrayOfMap2(AllInnerArrayOfMap2Type.ArrayOfmapOfVehicle) {
                        ArrayOfmapOfVehicle = arrayOfmapOfVehicle
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
                    object? any = JsonConvert.DeserializeObject<object>(json, new JsonSerializerSettings(){ NullValueHandling = NullValueHandling.Ignore, MissingMemberHandling = MissingMemberHandling.Error, Converters = Utilities.GetJsonConverters(typeof(object))});
                    return new AllInnerArrayOfMap2(AllInnerArrayOfMap2Type.Any) {
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
                AllInnerArrayOfMap2 res = (AllInnerArrayOfMap2)value;
                if (AllInnerArrayOfMap2Type.FromString(res.Type).Equals(AllInnerArrayOfMap2Type.Null))
                {
                    writer.WriteRawValue("null");
                    return;
                }
                if (res.ArrayOfmapOfboolean != null)
                {
                    writer.WriteRawValue(Utilities.SerializeJSON(res.ArrayOfmapOfboolean));
                    return;
                }
                if (res.ArrayOfmapOfVehicle != null)
                {
                    writer.WriteRawValue(Utilities.SerializeJSON(res.ArrayOfmapOfVehicle));
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