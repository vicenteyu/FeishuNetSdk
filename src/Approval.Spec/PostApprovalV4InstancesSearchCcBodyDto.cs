using Newtonsoft.Json;
namespace FeishuNetSdk.Approval.Spec;
/// <summary>
/// 查询抄送列表 请求体
/// <para>该接口通过不同条件查询审批系统中符合条件的审批抄送列表。</para>
/// <para>接口ID：7117964632137187331</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/approval-v4/approval-search/search_cc</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fapproval-v4%2finstance%2fsearch_cc</para>
/// </summary>
public record PostApprovalV4InstancesSearchCcBodyDto
{
    /// <summary>
    /// <para>根据x_user_type填写用户 id</para>
    /// <para>**示例值**："lwiu098wj"</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonProperty("user_id")]
    public string? UserId { get; set; }

    /// <summary>
    /// <para>审批定义 code</para>
    /// <para>**示例值**："EB828003-9FFE-4B3F-AA50-2E199E2ED942"</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonProperty("approval_code")]
    public string? ApprovalCode { get; set; }

    /// <summary>
    /// <para>审批实例 code</para>
    /// <para>**示例值**："EB828003-9FFE-4B3F-AA50-2E199E2ED943"</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonProperty("instance_code")]
    public string? InstanceCode { get; set; }

    /// <summary>
    /// <para>审批实例第三方 id 注：和 approval_code 取并集</para>
    /// <para>**示例值**："EB828003-9FFE-4B3F-AA50-2E199E2ED976"</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonProperty("instance_external_id")]
    public string? InstanceExternalId { get; set; }

    /// <summary>
    /// <para>审批定义分组第三方 id 注：和 instance_code 取并集</para>
    /// <para>**示例值**："1234567"</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonProperty("group_external_id")]
    public string? GroupExternalId { get; set; }

    /// <summary>
    /// <para>审批抄送标题（只有第三方审批有）</para>
    /// <para>**示例值**："test"</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonProperty("cc_title")]
    public string? CcTitle { get; set; }

    /// <summary>
    /// <para>审批抄送状态，注：若不设置，查询全部状态 若不在集合中，报错</para>
    /// <para>**示例值**："read"</para>
    /// <para>**可选值有**：</para>
    /// <para>READ:已读,UNREAD:未读,ALL:所有状态</para>
    /// <para>必填：否</para>
    /// <para>可选值：<list type="bullet">
    /// <item>READ：已读</item>
    /// <item>UNREAD：未读</item>
    /// <item>ALL：所有状态</item>
    /// </list></para>
    /// </summary>
    [JsonProperty("read_status")]
    public string? ReadStatus { get; set; }

    /// <summary>
    /// <para>抄送查询开始时间（unix毫秒时间戳）</para>
    /// <para>**示例值**："1547654251506"</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonProperty("cc_create_time_from")]
    public string? CcCreateTimeFrom { get; set; }

    /// <summary>
    /// <para>抄送查询结束时间 (unix毫秒时间戳)</para>
    /// <para>**示例值**："1547654251506"</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonProperty("cc_create_time_to")]
    public string? CcCreateTimeTo { get; set; }

    /// <summary>
    /// <para>地区</para>
    /// <para>**示例值**："zh-CN"</para>
    /// <para>**可选值有**：</para>
    /// <para>zh-CN:中文,en-US:英文,ja-JP:日文</para>
    /// <para>必填：否</para>
    /// <para>可选值：<list type="bullet">
    /// <item>zh-CN：中文</item>
    /// <item>en-US：英文</item>
    /// <item>ja-JP：日文</item>
    /// </list></para>
    /// </summary>
    [JsonProperty("locale")]
    public string? Locale { get; set; }
}
