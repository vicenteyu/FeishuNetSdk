// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-06-24
// ************************************************************************
// <copyright file="GetHireV1ResumeSourcesResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>获取简历来源列表 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Hire;
/// <summary>
/// 获取简历来源列表 响应体
/// <para>获取简历来源列表。</para>
/// <para>接口ID：6964264269274578946</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/hire-v1/candidate-management/resume_source/list</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuMzM1YjLzMTN24yMzUjN%2fhire-v1%2fresume_source%2flist</para>
/// </summary>
public record GetHireV1ResumeSourcesResponseDto
{
    /// <summary>
    /// <para>数据</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("items")]
    public ResumeSource[]? Items { get; set; }

    /// <summary>
    /// <para>数据</para>
    /// </summary>
    public record ResumeSource
    {
        /// <summary>
        /// <para>简历来源 ID</para>
        /// <para>必填：否</para>
        /// <para>示例值：10000</para>
        /// </summary>
        [JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// <para>简历来源中文名称</para>
        /// <para>必填：否</para>
        /// <para>示例值：内推</para>
        /// </summary>
        [JsonPropertyName("zh_name")]
        public string? ZhName { get; set; }

        /// <summary>
        /// <para>简历来源英文名称</para>
        /// <para>必填：否</para>
        /// <para>示例值：referral</para>
        /// </summary>
        [JsonPropertyName("en_name")]
        public string? EnName { get; set; }

        /// <summary>
        /// <para>启用状态</para>
        /// <para>必填：否</para>
        /// <para>示例值：1</para>
        /// <para>可选值：<list type="bullet">
        /// <item>1：已启用</item>
        /// <item>2：已禁用</item>
        /// </list></para>
        /// </summary>
        [JsonPropertyName("active_status")]
        public int? ActiveStatus { get; set; }

        /// <summary>
        /// <para>来源类型</para>
        /// <para>必填：否</para>
        /// <para>示例值：10001</para>
        /// <para>可选值：<list type="bullet">
        /// <item>10000：内推</item>
        /// <item>10001：猎头</item>
        /// <item>10002：内部来源</item>
        /// <item>10003：第三方招聘网站</item>
        /// <item>10004：社交媒体</item>
        /// <item>10005：线下来源</item>
        /// <item>10006：其他</item>
        /// <item>10007：外部推荐</item>
        /// <item>10008：员工转岗</item>
        /// <item>10009：实习生转正</item>
        /// </list></para>
        /// </summary>
        [JsonPropertyName("resume_source_type")]
        public int? ResumeSourceType { get; set; }
    }

    /// <summary>
    /// <para>分页标记，当 has_more 为 true 时，会同时返回新的 page_token，否则不返回 page_token</para>
    /// <para>必填：否</para>
    /// <para>示例值：1</para>
    /// </summary>
    [JsonPropertyName("page_token")]
    public string? PageToken { get; set; }

    /// <summary>
    /// <para>是否还有更多项</para>
    /// <para>必填：否</para>
    /// <para>示例值：true</para>
    /// </summary>
    [JsonPropertyName("has_more")]
    public bool? HasMore { get; set; }
}
