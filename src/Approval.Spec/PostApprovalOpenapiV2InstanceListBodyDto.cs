using Newtonsoft.Json;
namespace FeishuNetSdk.Approval.Spec;
/// <summary>
/// 批量获取审批实例ID 请求体
/// <para>为了更好地提升接口文档的的易理解性，我们对文档进行了升级，请尽快迁移至[新版本>>](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/approval-v4/instance/list)根据 approval_code 批量获取审批实例的 instance_code，用于拉取租户下某个审批定义的全部审批实例。</para>
/// <para>默认以审批创建时间排序。</para>
/// <para>接口ID：6907569745299046402</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/historic-version/approval/v2/feishu-native-approval/batch-obtain-approval-instance-ids</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuQDOyUjL0gjM14CN4ITN</para>
/// </summary>
public record PostApprovalOpenapiV2InstanceListBodyDto
{
    /// <summary>
    /// <para>审批定义唯一标识</para>
    /// <para>必填：是</para>
    /// </summary>
    [JsonProperty("approval_code")]
    public string ApprovalCode { get; set; } = string.Empty;

    /// <summary>
    /// <para>审批实例创建时间区间（毫秒）</para>
    /// <para>必填：是</para>
    /// </summary>
    [JsonProperty("start_time")]
    public long StartTime { get; set; }

    /// <summary>
    /// <para>审批实例创建时间区间（毫秒）</para>
    /// <para>必填：是</para>
    /// </summary>
    [JsonProperty("end_time")]
    public long EndTime { get; set; }

    /// <summary>
    /// <para>查询偏移量</para>
    /// <para>必填：是</para>
    /// </summary>
    [JsonProperty("offset")]
    public int Offset { get; set; }

    /// <summary>
    /// <para>查询限制量 注:不得大于100</para>
    /// <para>必填：是</para>
    /// </summary>
    [JsonProperty("limit")]
    public int Limit { get; set; }
}
