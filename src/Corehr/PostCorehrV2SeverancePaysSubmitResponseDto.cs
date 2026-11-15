// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2026-11-15
//
// Last Modified By : yxr
// Last Modified On : 2026-11-15
// ************************************************************************
// <copyright file="PostCorehrV2SeverancePaysSubmitResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>发起被动解除补偿金流程 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Corehr;
/// <summary>
/// 发起被动解除补偿金流程 响应体
/// <para>该接口用于为指定员工发起被动解除补偿金流程，并返回补偿金记录 ID、流程实例 ID 和当前状态。</para>
/// <para>接口ID：7667872540325743578</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/corehr-v2/severance_pay/submit</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fcorehr-v2%2fseverance_pay%2fsubmit</para>
/// </summary>
public record PostCorehrV2SeverancePaysSubmitResponseDto
{
    /// <summary>
    /// <para>补偿金/被动解除业务单 ID</para>
    /// <para>必填：否</para>
    /// <para>示例值：7660423757252773420</para>
    /// </summary>
    [JsonPropertyName("severance_pay_id")]
    public string? SeverancePayId { get; set; }

    /// <summary>
    /// <para>员工雇佣ID</para>
    /// <para>必填：否</para>
    /// <para>示例值：7659617611689510444</para>
    /// </summary>
    [JsonPropertyName("employment_id")]
    public string? EmploymentId { get; set; }

    /// <summary>
    /// <para>补偿金状态（枚举）：</para>
    /// <para>- approving：审批中</para>
    /// <para>- approved：审批通过</para>
    /// <para>- rejected：已拒绝</para>
    /// <para>- withdrawn：已撤销</para>
    /// <para>必填：否</para>
    /// <para>示例值：withdrawn</para>
    /// </summary>
    [JsonPropertyName("status")]
    public Enum? Status { get; set; }

    /// <summary>
    /// <para>补偿金状态（枚举）：</para>
    /// <para>- approving：审批中</para>
    /// <para>- approved：审批通过</para>
    /// <para>- rejected：已拒绝</para>
    /// <para>- withdrawn：已撤销</para>
    /// </summary>
    public record Enum
    {
        /// <summary>
        /// <para>枚举值</para>
        /// <para>必填：是</para>
        /// <para>示例值：phone_type</para>
        /// </summary>
        [JsonPropertyName("enum_name")]
        public string EnumName { get; set; } = string.Empty;

        /// <summary>
        /// <para>枚举多语展示</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("display")]
        public I18n[]? Displies { get; set; }

        /// <summary>
        /// <para>枚举多语展示</para>
        /// </summary>
        public record I18n
        {
            /// <summary>
            /// <para>语言编码（IETF BCP 47）</para>
            /// <para>必填：是</para>
            /// <para>示例值：zh-CN</para>
            /// </summary>
            [JsonPropertyName("lang")]
            public string Lang { get; set; } = string.Empty;

            /// <summary>
            /// <para>文本内容</para>
            /// <para>必填：是</para>
            /// <para>示例值：中文示例</para>
            /// </summary>
            [JsonPropertyName("value")]
            public string Value { get; set; } = string.Empty;
        }
    }

    /// <summary>
    /// <para>BPM 流程 ID</para>
    /// <para>必填：否</para>
    /// <para>示例值：7660486572667979308</para>
    /// </summary>
    [JsonPropertyName("process_id")]
    public string? ProcessId { get; set; }

    /// <summary>
    /// <para>创建时间，Unix 秒级时间戳</para>
    /// <para>必填：否</para>
    /// <para>示例值：1783994400000</para>
    /// <para>最大长度：19</para>
    /// <para>最小长度：1</para>
    /// </summary>
    [JsonPropertyName("created_time")]
    public string? CreatedTime { get; set; }
}
