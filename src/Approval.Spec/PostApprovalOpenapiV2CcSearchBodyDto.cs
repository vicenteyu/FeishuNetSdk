using Newtonsoft.Json;
namespace FeishuNetSdk.Approval.Spec;
/// <summary>
/// 抄送列表查询 请求体
/// <para>:::html为了更好地提升接口文档的的易理解性，我们对文档进行了升级，请尽快迁移至[新版本>>](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/approval-v4/instance/search_cc)该接口通过不同条件查询审批系统中符合条件的审批抄送列表。</para>
/// <para>接口ID：6907568073252700162</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/historic-version/approval/v2/approval-search/cc-list-query</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuUjMxYjL1ITM24SNyEjN</para>
/// </summary>
public record PostApprovalOpenapiV2CcSearchBodyDto
{
    /// <summary>
    /// <para>用户 id</para>
    /// <para>必填：是</para>
    /// </summary>
    [JsonProperty("user_id")]
    public string UserId { get; set; } = string.Empty;

    /// <summary>
    /// <para>审批定义 code</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonProperty("approval_code")]
    public string? ApprovalCode { get; set; }

    /// <summary>
    /// <para>审批实例 code</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonProperty("instance_code")]
    public string? InstanceCode { get; set; }

    /// <summary>
    /// <para>审批实例第三方 id<br>注：和 approval_code 取并集</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonProperty("instance_external_id")]
    public string? InstanceExternalId { get; set; }

    /// <summary>
    /// <para>审批定义分组第三方 id<br>注：和 instance_code 取并集</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonProperty("group_external_id")]
    public string? GroupExternalId { get; set; }

    /// <summary>
    /// <para>审批抄送标题（只有第三方审批有）</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonProperty("cc_title")]
    public string? CcTitle { get; set; }

    /// <summary>
    /// <para>审批抄送状态<br>READ:  已读<br>UNREAD: 未读<br>注：若不设置，查询全部状态<br>若不在集合中，报错</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonProperty("read_status")]
    public string? ReadStatus { get; set; }

    /// <summary>
    /// <para>抄送查询开始时间 (unix毫秒时间戳)</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonProperty("ccCreateTimeFrom")]
    public int? CcCreateTimeFrom { get; set; }

    /// <summary>
    /// <para>抄送查询结束时间 (unix毫秒时间戳)</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonProperty("ccCreateTimeTo")]
    public int? CcCreateTimeTo { get; set; }

    /// <summary>
    /// <para>地区 （zh-CN、en-US、ja-JP）</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonProperty("locale")]
    public string? Locale { get; set; }

    /// <summary>
    /// <para>查询偏移量<br>注：不得超过10000</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonProperty("offset")]
    public int? Offset { get; set; }

    /// <summary>
    /// <para>查询限制量<br>注：不得超过200<br>不设置默认查询10条数据</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonProperty("limit")]
    public int? Limit { get; set; }
}
