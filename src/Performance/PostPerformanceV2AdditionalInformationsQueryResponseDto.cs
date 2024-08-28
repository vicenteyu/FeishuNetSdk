// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-07-09
//
// Last Modified By : yxr
// Last Modified On : 2024-07-09
// ************************************************************************
// <copyright file="PostPerformanceV2AdditionalInformationsQueryResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>批量查询补充信息 响应体/summary>
namespace FeishuNetSdk.Performance;
/// <summary>
/// 批量查询补充信息 响应体
/// <para>批量查询被评估人的补充信息，如补充信息的事项、时间以及具体描述等。</para>
/// <para>接口ID：7371009404255617028</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/performance-v2/additional_information/query</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fperformance-v2%2fadditional_information%2fquery</para>
/// </summary>
public record PostPerformanceV2AdditionalInformationsQueryResponseDto
{
    /// <summary>
    /// <para>补充信息列表</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("additional_informations")]
    public AdditionalInformation[]? AdditionalInformations { get; set; }

    /// <summary>
    /// <para>补充信息列表</para>
    /// </summary>
    public record AdditionalInformation
    {
        /// <summary>
        /// <para>补充信息 ID</para>
        /// <para>必填：否</para>
        /// <para>示例值：7350195758357807123</para>
        /// <para>最大长度：100</para>
        /// <para>最小长度：1</para>
        /// </summary>
        [JsonPropertyName("item_id")]
        public string? ItemId { get; set; }

        /// <summary>
        /// <para>外部系统补充信息 ID</para>
        /// <para>**说明**：若导入时没有提供，则返回为空</para>
        /// <para>必填：否</para>
        /// <para>示例值：6789523104723558912</para>
        /// <para>最大长度：100</para>
        /// <para>最小长度：0</para>
        /// </summary>
        [JsonPropertyName("external_id")]
        public string? ExternalId { get; set; }

        /// <summary>
        /// <para>被评估人 ID，与入参 `user_id_type` 类型一致</para>
        /// <para>必填：是</para>
        /// <para>示例值：ou_3245842393d09e9428ad4655da6e30b3</para>
        /// <para>最大长度：9999</para>
        /// <para>最小长度：1</para>
        /// </summary>
        [JsonPropertyName("reviewee_user_id")]
        public string RevieweeUserId { get; set; } = string.Empty;

        /// <summary>
        /// <para>事项</para>
        /// <para>必填：是</para>
        /// <para>示例值：业绩补充说明</para>
        /// <para>最大长度：1000</para>
        /// <para>最小长度：1</para>
        /// </summary>
        [JsonPropertyName("item")]
        public string Item { get; set; } = string.Empty;

        /// <summary>
        /// <para>时间</para>
        /// <para>**说明**：文本内容，无格式校验</para>
        /// <para>必填：是</para>
        /// <para>示例值：2024-03-12</para>
        /// <para>最大长度：100</para>
        /// <para>最小长度：1</para>
        /// </summary>
        [JsonPropertyName("time")]
        public string Time { get; set; } = string.Empty;

        /// <summary>
        /// <para>具体描述</para>
        /// <para>必填：是</para>
        /// <para>示例值：销售额增长目标超额完成</para>
        /// <para>最大长度：1000</para>
        /// <para>最小长度：1</para>
        /// </summary>
        [JsonPropertyName("detailed_description")]
        public string DetailedDescription { get; set; } = string.Empty;
    }

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
}
