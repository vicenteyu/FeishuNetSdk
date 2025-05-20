// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-06-24
// ************************************************************************
// <copyright file="GetContactV3UnitResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>获取单位列表 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Contact;
/// <summary>
/// 获取单位列表 响应体
/// <para>调用该接口获取当前租户内的单位列表。列表内主要包含各单位的 ID、名字、类型信息。</para>
/// <para>接口ID：7023995901275308035</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/contact-v3/unit/list</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fcontact-v3%2funit%2flist</para>
/// </summary>
public record GetContactV3UnitResponseDto : IPageableResponse<GetContactV3UnitResponseDto.Unit>
{
    /// <inheritdoc/>
    [JsonIgnore]
    public Unit[]? Items => Unitlists;

    /// <summary>
    /// <para>单位列表。</para>
    /// <para>必填：是</para>
    /// </summary>
    [JsonPropertyName("unitlist")]
    public Unit[] Unitlists { get; set; } = Array.Empty<Unit>();

    /// <summary>
    /// <para>单位列表。</para>
    /// </summary>
    public record Unit
    {
        /// <summary>
        /// <para>单位 ID。</para>
        /// <para>必填：是</para>
        /// <para>示例值：BU121</para>
        /// </summary>
        [JsonPropertyName("unit_id")]
        public string UnitId { get; set; } = string.Empty;

        /// <summary>
        /// <para>单位名字。</para>
        /// <para>必填：是</para>
        /// <para>示例值：消费者事业部</para>
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; } = string.Empty;

        /// <summary>
        /// <para>单位类型。</para>
        /// <para>必填：是</para>
        /// <para>示例值：事业部</para>
        /// </summary>
        [JsonPropertyName("unit_type")]
        public string UnitType { get; set; } = string.Empty;
    }

    /// <summary>
    /// <para>是否还有更多项</para>
    /// <para>必填：是</para>
    /// <para>示例值：true</para>
    /// </summary>
    [JsonPropertyName("has_more")]
    public bool? HasMore { get; set; }

    /// <summary>
    /// <para>分页标记，当 has_more 为 true 时，会同时返回新的 page_token，否则不返回 page_token</para>
    /// <para>必填：是</para>
    /// <para>示例值：AQD9/Rn9eij9Pm39ED40/dk53s4Ebp882DYfFaPFbz00L4CMZJrqGdzNyc8BcZtDbwVUvRmQTvyMYicnGWrde9X56TgdBudfdagatagdd=</para>
    /// </summary>
    [JsonPropertyName("page_token")]
    public string? PageToken { get; set; }
}
