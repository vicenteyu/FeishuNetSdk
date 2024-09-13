// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-09-12
//
// Last Modified By : yxr
// Last Modified On : 2024-09-12
// ************************************************************************
// <copyright file="ResourceEventV2Dto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>订阅云文档事件头</summary>
// ************************************************************************
namespace FeishuNetSdk.Services
{
    /// <summary>
    /// 订阅云文档事件头
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public record ResourceEventV2Dto<T> : EventV2Dto<T> where T : EventBodyDto
    {
        /// <summary>
        /// 订阅的云文档 token
        /// </summary>
        [JsonPropertyName("resource_id")]
        public string? ResourceId { get; set; }

        /// <summary>
        /// 订阅的云文档 token
        /// </summary>
        [JsonPropertyName("user_list")]
        public UserIdSuffix[]? UserList { get; set; }
    }
}
