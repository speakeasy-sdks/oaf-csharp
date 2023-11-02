
//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by Speakeasy (https://speakeasyapi.dev). DO NOT EDIT.
//
// Changes to this file may cause incorrect behavior and will be lost when
// the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
#nullable enable
namespace OAFComplex
{
    using OAFComplex.Utils;
    using System.Collections.Generic;
    using System.Net.Http;
    using System.Threading.Tasks;
    using System;

    /// <summary>
    /// TypeCombinator Complex: Testing all the complex cases such as:<br/>
    /// 
    /// <remarks>
    /// - Scalar (inner/outer arrayOfMaps/mapofArrays)<br/>
    /// - Non-Scalar (inner/outer arrayOfMaps/mapofArrays)<br/>
    /// - Mix of Both<br/>
    /// - MultiLevel oneOf/anyOf<br/>
    /// IN following:<br/>
    /// - Model Properties (optional, required, nullable, optional-nullable)<br/>
    /// - Endpoint Params (Query, Form, Body(WrapBodyInObject (true,false)), Template)(CollectParameters(true,false))<br/>
    /// - Endpoint&apos;s response
    /// </remarks>
    /// </summary>
    public interface IOAFComplexSDK
    {
        public IReceiverSDK Receiver { get; }
        public ISenderSDK Sender { get; }
    }
    
    public class SDKConfig
    {
    }

    /// <summary>
    /// TypeCombinator Complex: Testing all the complex cases such as:<br/>
    /// 
    /// <remarks>
    /// - Scalar (inner/outer arrayOfMaps/mapofArrays)<br/>
    /// - Non-Scalar (inner/outer arrayOfMaps/mapofArrays)<br/>
    /// - Mix of Both<br/>
    /// - MultiLevel oneOf/anyOf<br/>
    /// IN following:<br/>
    /// - Model Properties (optional, required, nullable, optional-nullable)<br/>
    /// - Endpoint Params (Query, Form, Body(WrapBodyInObject (true,false)), Template)(CollectParameters(true,false))<br/>
    /// - Endpoint&apos;s response
    /// </remarks>
    /// </summary>
    public class OAFComplexSDK: IOAFComplexSDK
    {
        public SDKConfig Config { get; private set; }
        public static List<string> ServerList = new List<string>()
        {
            "https://enehkteyzt55p.x.pipedream.net/{subUrl}",
            "http://localhost:3000/{subUrl}",
        };

        private const string _language = "csharp";
        private const string _sdkVersion = "0.1.0";
        private const string _sdkGenVersion = "2.173.0";
        private const string _openapiDocVersion = "1.0.0";
        private const string _userAgent = "speakeasy-sdk/csharp 0.1.0 2.173.0 1.0.0 OAF-Complex";
        private string _serverUrl = "";
        private ISpeakeasyHttpClient _defaultClient;
        private ISpeakeasyHttpClient _securityClient;
        public IReceiverSDK Receiver { get; private set; }
        public ISenderSDK Sender { get; private set; }

        public OAFComplexSDK(string? serverUrl = null, ISpeakeasyHttpClient? client = null)
        {
            _serverUrl = serverUrl ?? OAFComplexSDK.ServerList[0];

            _defaultClient = new SpeakeasyHttpClient(client);
            _securityClient = _defaultClient;
            
            Config = new SDKConfig()
            {
            };

            Receiver = new ReceiverSDK(_defaultClient, _securityClient, _serverUrl, Config);
            Sender = new SenderSDK(_defaultClient, _securityClient, _serverUrl, Config);
        }
    }
}