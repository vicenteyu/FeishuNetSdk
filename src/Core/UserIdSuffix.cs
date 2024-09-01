// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-09-01
//
// Last Modified By : yxr
// Last Modified On : 2024-09-01
// ************************************************************************
// <copyright file="UserIdSuffix.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>用户 ID</summary>
// ************************************************************************
global using FeishuNetSdk.Core;
namespace FeishuNetSdk.Core
{
    /// <summary>
    /// 用户 ID
    /// </summary>
    public record UserIdSuffix
    {
        /// <summary>
        /// <para>用户的 union id</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("union_id")]
        public string? UnionId { get; set; }

        /// <summary>
        /// <para>用户的 user id</para>
        /// <para>**字段权限要求**：</para>
        /// <para>- contact:user.employee_id:readonly : 获取用户 user ID</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("user_id")]
        public string? UserId { get; set; }

        /// <summary>
        /// <para>用户的 open id</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("open_id")]
        public string? OpenId { get; set; }
    }
}
