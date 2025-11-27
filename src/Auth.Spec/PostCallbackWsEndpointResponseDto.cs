// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-08-31
//
// Last Modified By : yxr
// Last Modified On : 2024-08-31
// ************************************************************************
// <copyright file="PostCallbackWsEndpointResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>获取长连接地址 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Auth.Spec
{
    /// <summary>
    /// 获取长连接地址 响应体
    /// </summary>
    public record PostCallbackWsEndpointResponseDto
    {

        /// <summary>
        /// 长连接地址
        /// </summary>
        [JsonPropertyName("URL")]
        public string Url { get; set; } = string.Empty;

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("ClientConfig")]
        public ClientconfigSuffix ClientConfig { get; set; } = new();

        /// <summary>
        /// 
        /// </summary>
        public record ClientconfigSuffix
        {
            /// <summary>
            /// 
            /// </summary>
            [JsonPropertyName("ReconnectCount")]
            public int ReconnectCount { get; set; }

            /// <summary>
            /// 
            /// </summary>
            [JsonPropertyName("ReconnectInterval")]
            public int ReconnectInterval { get; set; }

            /// <summary>
            /// 
            /// </summary>
            [JsonPropertyName("ReconnectNonce")]
            public int ReconnectNonce { get; set; }

            /// <summary>
            /// 
            /// </summary>
            [JsonPropertyName("PingInterval")]
            public int PingInterval { get; set; }
        }
    }
}
