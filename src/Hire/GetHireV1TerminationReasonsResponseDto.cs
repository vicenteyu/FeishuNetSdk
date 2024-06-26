// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-26
//
// Last Modified By : yxr
// Last Modified On : 2024-06-26
// ************************************************************************
// <copyright file="GetHireV1TerminationReasonsResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>获取终止投递原因 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Hire;
/// <summary>
/// 获取终止投递原因 响应体
/// <para>获取系统中默认的投递终止原因以及用户配置的自定义投递终止原因。</para>
/// <para>接口ID：7036934321795039234</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/hire-v1/candidate-management/delivery-process-management/application/list-2</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuMzM1YjLzMTN24yMzUjN%2fhire-v1%2ftermination_reason%2flist</para>
/// </summary>
public record GetHireV1TerminationReasonsResponseDto
{
    /// <summary>
    /// <para>列表</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("items")]
    public TerminationReason[]? Items { get; set; }

    /// <summary>
    /// <para>列表</para>
    /// </summary>
    public record TerminationReason
    {
        /// <summary>
        /// <para>终止原因 ID</para>
        /// <para>必填：否</para>
        /// <para>示例值：10002</para>
        /// </summary>
        [JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// <para>终止原因名称</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("name")]
        public I18n? Name { get; set; }

        /// <summary>
        /// <para>终止原因名称</para>
        /// </summary>
        public record I18n
        {
            /// <summary>
            /// <para>中文</para>
            /// <para>必填：否</para>
            /// <para>示例值：测试</para>
            /// </summary>
            [JsonPropertyName("zh_cn")]
            public string? ZhCn { get; set; }

            /// <summary>
            /// <para>英文</para>
            /// <para>必填：否</para>
            /// <para>示例值：test</para>
            /// </summary>
            [JsonPropertyName("en_us")]
            public string? EnUs { get; set; }
        }

        /// <summary>
        /// <para>内推渠道展示文案</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("referral_name")]
        public I18n? ReferralName { get; set; }

        /// <summary>
        /// <para>终止原因类型</para>
        /// <para>必填：否</para>
        /// <para>示例值：22</para>
        /// <para>可选值：<list type="bullet">
        /// <item>1：我们拒绝了候选人</item>
        /// <item>22：候选人拒绝了我们</item>
        /// <item>27：其他</item>
        /// </list></para>
        /// </summary>
        [JsonPropertyName("termination_type")]
        public int? TerminationType { get; set; }

        /// <summary>
        /// <para>是否用于评估</para>
        /// <para>必填：否</para>
        /// <para>示例值：false</para>
        /// </summary>
        [JsonPropertyName("is_used_as_evaluation")]
        public bool? IsUsedAsEvaluation { get; set; }

        /// <summary>
        /// <para>状态</para>
        /// <para>必填：否</para>
        /// <para>示例值：1</para>
        /// <para>可选值：<list type="bullet">
        /// <item>1：已启用</item>
        /// <item>2：已停用</item>
        /// </list></para>
        /// </summary>
        [JsonPropertyName("active_status")]
        public int? ActiveStatus { get; set; }
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
    /// <para>示例值：eyJvZmZzZXQiOjEwLCJ0aW1lc3RhbXAiOjE2Mjc1NTUyMjM2NzIsImlkIjpudWxsfQ==</para>
    /// </summary>
    [JsonPropertyName("page_token")]
    public string? PageToken { get; set; }
}
