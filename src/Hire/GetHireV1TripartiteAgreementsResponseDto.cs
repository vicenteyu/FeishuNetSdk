// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-07-22
//
// Last Modified By : yxr
// Last Modified On : 2024-07-22
// ************************************************************************
// <copyright file="GetHireV1TripartiteAgreementsResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>获取三方协议 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Hire;
/// <summary>
/// 获取三方协议 响应体
/// <para>根据三方协议 ID 或 投递 ID 获取三方协议信息</para>
/// <para>默认按照 id 排序</para>
/// <para>接口ID：7307160083569672195</para>
/// <para>文档地址：https://open.feishu.cn/document/ukTMukTMukTM/uMzM1YjLzMTN24yMzUjN/hire-v1/tripartite_agreement/list</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuMzM1YjLzMTN24yMzUjN%2fhire-v1%2ftripartite_agreement%2flist</para>
/// </summary>
public record GetHireV1TripartiteAgreementsResponseDto
{
    /// <summary>
    /// <para>三方协议信息</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("items")]
    public TripartiteAgreementInfo[]? Items { get; set; }

    /// <summary>
    /// <para>三方协议信息</para>
    /// </summary>
    public record TripartiteAgreementInfo
    {
        /// <summary>
        /// <para>三方协议 ID</para>
        /// <para>必填：否</para>
        /// <para>示例值：6930815272790114324</para>
        /// </summary>
        [JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// <para>投递ID</para>
        /// <para>必填：否</para>
        /// <para>示例值：6930815272790114325</para>
        /// </summary>
        [JsonPropertyName("application_id")]
        public string? ApplicationId { get; set; }

        /// <summary>
        /// <para>三方协议状态</para>
        /// <para>必填：否</para>
        /// <para>示例值：1</para>
        /// <para>可选值：<list type="bullet">
        /// <item>1：未开始</item>
        /// <item>2：已申请</item>
        /// <item>3：学生处理中</item>
        /// <item>4：公司处理中</item>
        /// <item>5：学校处理中</item>
        /// <item>6：已终止</item>
        /// <item>7：已完成</item>
        /// <item>8：解约处理中</item>
        /// <item>9：已解约</item>
        /// </list></para>
        /// </summary>
        [JsonPropertyName("state")]
        public int? State { get; set; }

        /// <summary>
        /// <para>三方协议创建时间，毫秒时间戳</para>
        /// <para>必填：否</para>
        /// <para>示例值：1698292282660</para>
        /// </summary>
        [JsonPropertyName("create_time")]
        public string? CreateTime { get; set; }

        /// <summary>
        /// <para>三方协议修改时间，毫秒时间戳</para>
        /// <para>必填：否</para>
        /// <para>示例值：1698292282661</para>
        /// </summary>
        [JsonPropertyName("modify_time")]
        public string? ModifyTime { get; set; }
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
