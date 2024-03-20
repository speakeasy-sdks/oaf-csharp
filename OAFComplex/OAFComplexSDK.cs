
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
    using Newtonsoft.Json;
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
        public IReceiver Receiver { get; }
        public ISender Sender { get; }
    }

    public class SDKConfig
    {
        /// <summary>
        /// List of server URLs available to the SDK.
        /// </summary>
        public static readonly string[] ServerList = {
            "https://enehkteyzt55p.x.pipedream.net/{subUrl}",
            "http://localhost:3000/{subUrl}",
        };

        public string serverUrl = "";
        public int serverIndex = 0;
        public List<Dictionary<string, string>> ServerDefaults = new List<Dictionary<string, string>>();

        public string GetTemplatedServerDetails()
        {
            if (!String.IsNullOrEmpty(this.serverUrl))
            {
                return Utilities.TemplateUrl(Utilities.RemoveSuffix(this.serverUrl, "/"), new Dictionary<string, string>());
            }
            return Utilities.TemplateUrl(SDKConfig.ServerList[this.serverIndex], this.ServerDefaults[this.serverIndex]);
        }
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
        public SDKConfig SDKConfiguration { get; private set; }

        private const string _language = "csharp";
        private const string _sdkVersion = "0.6.0";
        private const string _sdkGenVersion = "2.283.1";
        private const string _openapiDocVersion = "1.0.0";
        private const string _userAgent = "speakeasy-sdk/csharp 0.6.0 2.283.1 1.0.0 OAF-Complex";
        private string _serverUrl = "";
        private int _serverIndex = 0;
        private ISpeakeasyHttpClient _defaultClient;
        public IReceiver Receiver { get; private set; }
        public ISender Sender { get; private set; }

        public OAFComplexSDK(int? serverIndex = null, string?  subUrl = null, string? serverUrl = null, Dictionary<string, string>? urlParams = null, ISpeakeasyHttpClient? client = null)
        {
            if (serverIndex != null)
            {
                if (serverIndex.Value < 0 || serverIndex.Value >= SDKConfig.ServerList.Length)
                {
                    throw new Exception($"Invalid server index {serverIndex.Value}");
                }
                _serverIndex = serverIndex.Value;
            }

            if (serverUrl != null)
            {
                if (urlParams != null)
                {
                    serverUrl = Utilities.TemplateUrl(serverUrl, urlParams);
                }
                _serverUrl = serverUrl;
            }
            List<Dictionary<string, string>> serverDefaults = new List<Dictionary<string, string>>()
            {
                new Dictionary<string, string>()
                {
                    {"subUrl", subUrl == null ? "multitype/complex" : subUrl},
                },
                new Dictionary<string, string>()
                {
                    {"subUrl", subUrl == null ? "multitype/complex" : subUrl},
                },
            };

            _defaultClient = new SpeakeasyHttpClient(client);

            SDKConfiguration = new SDKConfig()
            {
                ServerDefaults = serverDefaults,
                serverIndex = _serverIndex,
                serverUrl = _serverUrl
            };

            Receiver = new Receiver(_defaultClient, _serverUrl, SDKConfiguration);
            Sender = new Sender(_defaultClient, _serverUrl, SDKConfiguration);
        }
    }
}
