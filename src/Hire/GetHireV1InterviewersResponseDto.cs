// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-08-28
//
// Last Modified By : yxr
// Last Modified On : 2024-08-28
// ************************************************************************
// <copyright file="GetHireV1InterviewersResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>查询面试官信息列表 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Hire;
/// <summary>
/// 查询面试官信息列表 响应体
/// <para>分页查询面试官列表，接口只会返回执行过「更新面试官信息」用户的数据，通过接口查询不到的数据则默认为「未认证」面试官。接口默认按更新时间、user_id顺序进行顺序拉取。</para>
/// <para>接口ID：7372229724359835649</para>
/// <para>文档地址：https://open.feishu.cn/document/ukTMukTMukTM/uMzM1YjLzMTN24yMzUjN/hire-v1/interviewer/list</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuMzM1YjLzMTN24yMzUjN%2fhire-v1%2finterviewer%2flist</para>
/// </summary>
public record GetHireV1InterviewersResponseDto
{
    /// <summary>
    /// <para>面试官信息</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("items")]
    public Interviewer[]? Items { get; set; }

    /// <summary>
    /// <para>面试官信息</para>
    /// </summary>
    public record Interviewer
    {
        /// <summary>
        /// <para>面试官userID</para>
        /// <para>必填：否</para>
        /// <para>示例值：ou_7dab8a3d3cdcc9da365777c7ad535d62</para>
        /// </summary>
        [JsonPropertyName("user_id")]
        public string? UserId { get; set; }

        /// <summary>
        /// <para>认证状态</para>
        /// <para>必填：否</para>
        /// <para>示例值：1</para>
        /// <para>可选值：<list type="bullet">
        /// <item>1：未认证</item>
        /// <item>2：已认证</item>
        /// </list></para>
        /// </summary>
        [JsonPropertyName("verify_status")]
        public int? VerifyStatus { get; set; }
    }

    /// <summary>
    /// <para>分页标记，当 has_more 为 true 时，会同时返回新的 page_token，否则不返回 page_token</para>
    /// <para>必填：否</para>
    /// <para>示例值：eVQrYzJBNDNONlk4VFZBZVlSdzlKdFJ4bVVHVExENDNKVHoxaVdiVnViQT0=</para>
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
