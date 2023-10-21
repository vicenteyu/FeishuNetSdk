using Newtonsoft.Json;
namespace FeishuNetSdk.Approval.Spec;
/// <summary>
/// 查询审批 ID（专用） 请求体
/// <para>用于灰度租户内的 userID 相互转换。</para>
/// <para>接口ID：6907568031544737794</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/approval-v4/approval-search/search-approval-id-(dedicated)</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuEDN5UjLxQTO14SM0kTN</para>
/// </summary>
public record PostApprovalOpenapiV1IdGetBodyDto
{
    /// <summary>
    /// <para>企业标识（user_id_list 不为空时必须）</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonProperty("tenant_key")]
    public string? TenantKey { get; set; }

    /// <summary>
    /// <para>Employee ID 数组（最大100个）</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonProperty("user_id_list")]
    public string[]? UserIdList { get; set; }

    /// <summary>
    /// <para>Lark User ID 数组（最大100个）</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonProperty("lark_id_list")]
    public long[]? LarkIdList { get; set; }
}
