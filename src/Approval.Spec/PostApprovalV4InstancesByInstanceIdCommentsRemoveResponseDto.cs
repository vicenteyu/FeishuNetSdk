using Newtonsoft.Json;
namespace FeishuNetSdk.Approval.Spec;
/// <summary>
/// 清空评论 响应体
/// <para>删除某审批实例下的全部评论与评论回复。</para>
/// <para>接口ID：7117964632137252867</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/approval-v4/instance-comment/remove</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fapproval-v4%2finstance-comment%2fremove</para>
/// </summary>
public record PostApprovalV4InstancesByInstanceIdCommentsRemoveResponseDto
{
    /// <summary>
    /// <para>审批实例code</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonProperty("instance_id")]
    public string? InstanceId { get; set; }

    /// <summary>
    /// <para>租户自定义审批实例ID</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonProperty("external_id")]
    public string? ExternalId { get; set; }
}
