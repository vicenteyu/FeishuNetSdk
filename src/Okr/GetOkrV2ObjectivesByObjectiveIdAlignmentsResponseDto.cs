// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2026-06-06
//
// Last Modified By : yxr
// Last Modified On : 2026-06-06
// ************************************************************************
// <copyright file="GetOkrV2ObjectivesByObjectiveIdAlignmentsResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>获取目标的对齐信息 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Okr;
/// <summary>
/// 获取目标的对齐信息 响应体
/// <para>分页获取指定目标的对齐关系列表，包含被其他目标对齐（被对齐）和对齐到其他目标（对齐）两种类型的对齐信息，以及发起方和被对齐方的负责人与实体详情。</para>
/// <para>接口ID：7644764969658223564</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/okr-v2/okr-objective-alignment/list</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fokr-v2%2fokr-objective-alignment%2flist</para>
/// </summary>
public record GetOkrV2ObjectivesByObjectiveIdAlignmentsResponseDto : IPageableResponse<GetOkrV2ObjectivesByObjectiveIdAlignmentsResponseDto.Alignment>
{
    /// <summary>
    /// <para>是否还有更多项</para>
    /// <para>必填：否</para>
    /// <para>示例值：true</para>
    /// </summary>
    [JsonPropertyName("has_more")]
    public bool? HasMore { get; set; }

    /// <summary>
    /// <para>分页标记，当 has_more 为 true 时，会同时返回新的 page_token，否则不返回 page_token</para>
    /// <para>必填：否</para>
    /// <para>示例值：eVQrYzJBNDNONlk4VFZBZVlSdzlKdFJ4bVVHVExENDNKVHoxaVdiVnViQT0=</para>
    /// </summary>
    [JsonPropertyName("page_token")]
    public string? PageToken { get; set; }

    /// <summary>
    /// <para>对齐列表</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("items")]
    public Alignment[]? Items { get; set; }

    /// <summary>
    /// <para>对齐列表</para>
    /// </summary>
    public record Alignment
    {
        /// <summary>
        /// <para>对齐的 ID</para>
        /// <para>必填：是</para>
        /// <para>示例值：7342342398472398471</para>
        /// <para>最大长度：20</para>
        /// <para>最小长度：1</para>
        /// </summary>
        [JsonPropertyName("id")]
        public string Id { get; set; } = string.Empty;

        /// <summary>
        /// <para>对齐的创建时间，毫秒级时间戳</para>
        /// <para>必填：是</para>
        /// <para>示例值：1760604634563</para>
        /// <para>最大长度：20</para>
        /// <para>最小长度：1</para>
        /// </summary>
        [JsonPropertyName("create_time")]
        public string CreateTime { get; set; } = string.Empty;

        /// <summary>
        /// <para>对齐的更新时间，毫秒级时间戳</para>
        /// <para>必填：是</para>
        /// <para>示例值：1760604634563</para>
        /// <para>最大长度：20</para>
        /// <para>最小长度：1</para>
        /// </summary>
        [JsonPropertyName("update_time")]
        public string UpdateTime { get; set; } = string.Empty;

        /// <summary>
        /// <para>发起对齐的所有者</para>
        /// <para>必填：是</para>
        /// </summary>
        [JsonPropertyName("from_owner")]
        public Owner FromOwner { get; set; } = new();

        /// <summary>
        /// <para>发起对齐的所有者</para>
        /// </summary>
        public record Owner
        {
            /// <summary>
            /// <para>所有者类型</para>
            /// <para>必填：是</para>
            /// <para>示例值：user</para>
            /// <para>可选值：<list type="bullet">
            /// <item>user：员工</item>
            /// </list></para>
            /// </summary>
            [JsonPropertyName("owner_type")]
            public string OwnerType { get; set; } = string.Empty;

            /// <summary>
            /// <para>员工 ID</para>
            /// <para>必填：否</para>
            /// <para>示例值：ou_3bbe8a09c20e89cce9bff989ed840674</para>
            /// </summary>
            [JsonPropertyName("user_id")]
            public string? UserId { get; set; }
        }

        /// <summary>
        /// <para>被对齐的所有者</para>
        /// <para>必填：是</para>
        /// </summary>
        [JsonPropertyName("to_owner")]
        public Owner ToOwner { get; set; } = new();

        /// <summary>
        /// <para>发起对齐的实体类型</para>
        /// <para>必填：是</para>
        /// <para>示例值：2</para>
        /// <para>可选值：<list type="bullet">
        /// <item>2：目标</item>
        /// </list></para>
        /// </summary>
        [JsonPropertyName("from_entity_type")]
        public int FromEntityType { get; set; }

        /// <summary>
        /// <para>发起对齐的实体 ID</para>
        /// <para>必填：是</para>
        /// <para>示例值：7342342398472398472</para>
        /// <para>最大长度：20</para>
        /// <para>最小长度：1</para>
        /// </summary>
        [JsonPropertyName("from_entity_id")]
        public string FromEntityId { get; set; } = string.Empty;

        /// <summary>
        /// <para>被对齐的实体类型</para>
        /// <para>必填：是</para>
        /// <para>示例值：2</para>
        /// <para>可选值：<list type="bullet">
        /// <item>2：目标</item>
        /// </list></para>
        /// </summary>
        [JsonPropertyName("to_entity_type")]
        public int ToEntityType { get; set; }

        /// <summary>
        /// <para>被对齐的实体 ID</para>
        /// <para>必填：是</para>
        /// <para>示例值：7342342398472398473</para>
        /// <para>最大长度：20</para>
        /// <para>最小长度：1</para>
        /// </summary>
        [JsonPropertyName("to_entity_id")]
        public string ToEntityId { get; set; } = string.Empty;
    }
}
