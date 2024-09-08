// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-08-31
//
// Last Modified By : yxr
// Last Modified On : 2024-08-31
// ************************************************************************
// <copyright file="EventBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>事件体</summary>
// ************************************************************************
namespace FeishuNetSdk.Services
{
    /// <summary>
    /// 事件 V2.0
    /// </summary>
    public record EventV2Dto<T> : EventDto<T> where T : EventBodyDto
    {
        /// <summary>
        /// 事件唯一Id
        /// </summary>
        [JsonPropertyName("event_id")]
        public override string EventId => Header.EventId;

        /// <summary>
        /// 事件 Token，即Verification Token。用于验证来自于同一个应用
        /// </summary>
        [JsonPropertyName("token")]
        public override string Token => Header.Token;

        /// <summary>
        /// 事件模式
        /// </summary>
        [JsonPropertyName("schema")]
        public string Schema { get; set; } = string.Empty;

        /// <summary>
        /// 事件头
        /// </summary>
        [JsonPropertyName("header")]
        public HeaderSuffix Header { get; set; } = new();

        /// <summary>
        /// 事件头
        /// </summary>
        public record HeaderSuffix
        {
            /// <summary>
            /// 事件 ID
            /// </summary>
            [JsonPropertyName("event_id")]
            public string EventId { get; set; } = string.Empty;

            /// <summary>
            /// 事件类型
            /// </summary>
            [JsonPropertyName("event_type")]
            public string EventType { get; set; } = string.Empty;

            /// <summary>
            /// 事件创建时间戳（单位：毫秒）
            /// </summary>
            [JsonPropertyName("create_time")]
            public string CreateTime { get; set; } = string.Empty;

            /// <summary>
            /// 事件 Token，验证来自于同一个应用
            /// </summary>
            [JsonPropertyName("token")]
            public string Token { get; set; } = string.Empty;

            /// <summary>
            /// 应用 ID
            /// </summary>
            [JsonPropertyName("app_id")]
            public string AppId { get; set; } = string.Empty;

            /// <summary>
            /// 租户 Key
            /// </summary>
            [JsonPropertyName("tenant_key")]
            public string TenantKey { get; set; } = string.Empty;
        }
    }
}
