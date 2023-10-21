using Newtonsoft.Json;
namespace FeishuNetSdk.FeishuPeople;
/// <summary>
/// 操作员工离职 响应体
/// <para>操作员工直接离职。</para>
/// <para>接口ID：7097044451155214340</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/corehr-v1/offboarding/submit</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fcorehr-v1%2foffboarding%2fsubmit</para>
/// </summary>
public record PostCorehrV1OffboardingsSubmitResponseDto
{
    /// <summary>
    /// <para>离职记录 id</para>
    /// <para>必填：否</para>
    /// <para>示例值：7095671727698478604</para>
    /// </summary>
    [JsonProperty("offboarding_id")]
    public string? OffboardingId { get; set; }

    /// <summary>
    /// <para>雇员 id</para>
    /// <para>必填：否</para>
    /// <para>示例值：6982509313466189342</para>
    /// </summary>
    [JsonProperty("employment_id")]
    public string? EmploymentId { get; set; }

    /// <summary>
    /// <para>离职原因</para>
    /// <para>必填：否</para>
    /// <para>示例值：reason_for_offboarding_option8</para>
    /// </summary>
    [JsonProperty("offboarding_reason_unique_identifier")]
    public string? OffboardingReasonUniqueIdentifier { get; set; }

    /// <summary>
    /// <para>离职日期</para>
    /// <para>必填：否</para>
    /// <para>示例值：2022-05-18</para>
    /// </summary>
    [JsonProperty("offboarding_date")]
    public string? OffboardingDate { get; set; }

    /// <summary>
    /// <para>离职原因说明</para>
    /// <para>必填：否</para>
    /// <para>示例值：离职原因说明</para>
    /// </summary>
    [JsonProperty("offboarding_reason_explanation")]
    public string? OffboardingReasonExplanation { get; set; }

    /// <summary>
    /// <para>是否加入离职屏蔽名单</para>
    /// <para>必填：否</para>
    /// <para>示例值：false</para>
    /// </summary>
    [JsonProperty("add_block_list")]
    public string? AddBlockList { get; set; }

    /// <summary>
    /// <para>屏蔽原因</para>
    /// <para>必填：否</para>
    /// <para>示例值：红线</para>
    /// </summary>
    [JsonProperty("block_reason")]
    public string? BlockReason { get; set; }

    /// <summary>
    /// <para>屏蔽原因说明</para>
    /// <para>必填：否</para>
    /// <para>示例值：xx年xx月xx日因xx原因红线</para>
    /// </summary>
    [JsonProperty("block_reason_explanation")]
    public string? BlockReasonExplanation { get; set; }

    /// <summary>
    /// <para>创建时间</para>
    /// <para>必填：否</para>
    /// <para>示例值：2022-05-0917:50:17</para>
    /// </summary>
    [JsonProperty("created_time")]
    public string? CreatedTime { get; set; }
}
