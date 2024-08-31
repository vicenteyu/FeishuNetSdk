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
