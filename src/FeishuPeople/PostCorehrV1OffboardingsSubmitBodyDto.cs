using Newtonsoft.Json;
namespace FeishuNetSdk.FeishuPeople;
/// <summary>
/// 操作员工离职 请求体
/// <para>操作员工直接离职。</para>
/// <para>接口ID：7097044451155214340</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/corehr-v1/offboarding/submit</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fcorehr-v1%2foffboarding%2fsubmit</para>
/// </summary>
public record PostCorehrV1OffboardingsSubmitBodyDto
{
    /// <summary>
    /// <para>离职方式</para>
    /// <para>必填：是</para>
    /// <para>示例值：1</para>
    /// <para>可选值：<list type="bullet">
    /// <item>1：直接离职</item>
    /// </list></para>
    /// </summary>
    [JsonProperty("offboarding_mode")]
    public int OffboardingMode { get; set; }

    /// <summary>
    /// <para>雇员 id</para>
    /// <para>必填：是</para>
    /// <para>示例值：6982509313466189342</para>
    /// </summary>
    [JsonProperty("employment_id")]
    public string EmploymentId { get; set; } = string.Empty;

    /// <summary>
    /// <para>离职日期</para>
    /// <para>必填：是</para>
    /// <para>示例值：2022-05-18</para>
    /// </summary>
    [JsonProperty("offboarding_date")]
    public string OffboardingDate { get; set; } = string.Empty;

    /// <summary>
    /// <para>离职原因，可通过接口</para>
    /// <para>[【查询员工离职原因列表】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/offboarding/query)获取</para>
    /// <para>必填：是</para>
    /// <para>示例值：reason_for_offboarding_option8</para>
    /// </summary>
    [JsonProperty("offboarding_reason_unique_identifier")]
    public string OffboardingReasonUniqueIdentifier { get; set; } = string.Empty;

    /// <summary>
    /// <para>离职原因说明，长度限制6000</para>
    /// <para>必填：否</para>
    /// <para>示例值：离职原因说明</para>
    /// </summary>
    [JsonProperty("offboarding_reason_explanation")]
    public string? OffboardingReasonExplanation { get; set; }

    /// <summary>
    /// <para>操作发起人 ID（employment_id），为空默认为系统发起。注意：只有操作发起人可以撤销流程</para>
    /// <para>必填：否</para>
    /// <para>示例值：6982509313466189341</para>
    /// </summary>
    [JsonProperty("initiator_id")]
    public string? InitiatorId { get; set; }

    /// <summary>
    /// <para>是否加入离职屏蔽名单</para>
    /// <para>必填：否</para>
    /// <para>示例值：false</para>
    /// </summary>
    [JsonProperty("add_block_list")]
    public bool? AddBlockList { get; set; }

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
    /// <para>自定义字段</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonProperty("custom_fields")]
    public ObjectFieldData[]? CustomFields { get; set; }

    /// <summary>
    /// <para>自定义字段</para>
    /// </summary>
    public record ObjectFieldData
    {
        /// <summary>
        /// <para>字段名</para>
        /// <para>必填：是</para>
        /// <para>示例值：name</para>
        /// </summary>
        [JsonProperty("field_name")]
        public string FieldName { get; set; } = string.Empty;

        /// <summary>
        /// <para>字段值，是json转义后的字符串，根据元数据定义不同，字段格式不同(如123, 123.23, "true", [\"id1\",\"id2\"], "2006-01-02 15:04:05")</para>
        /// <para>必填：是</para>
        /// <para>示例值：\"Sandy\"</para>
        /// </summary>
        [JsonProperty("value")]
        public string Value { get; set; } = string.Empty;
    }
}
