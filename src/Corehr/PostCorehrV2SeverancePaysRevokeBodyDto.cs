// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2026-11-20
//
// Last Modified By : yxr
// Last Modified On : 2026-11-20
// ************************************************************************
// <copyright file="PostCorehrV2SeverancePaysRevokeBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>撤销被动解除补偿金业务单 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Corehr;
/// <summary>
/// 撤销被动解除补偿金业务单 请求体
/// <para>撤销指定的被动解除补偿金业务单，将单据状态更新为已撤销（`withdrawn`）。每次调用处理一张单据。</para>
/// <para>## 业务限制</para>
/// <para>仅审批中（`approving`）和审批通过（`approved`）的单据支持撤销。审批中，同一审批流程关联多张补偿金单据时，不支持单独撤销其中一张；审批通过后，可逐张撤销。已拒绝（`rejected`）或其他不允许撤销的状态返回 `1163402`。</para>
/// <para>调用前后均可通过[搜索被动解除补偿金信息](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/corehr-v2/severance_pay/query)确认单据 ID 和状态。</para>
/// <para>接口ID：7709381754305826087</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/corehr-v2/severance_pay/revoke</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fcorehr-v2%2fseverance_pay%2frevoke</para>
/// </summary>
public record PostCorehrV2SeverancePaysRevokeBodyDto
{
    /// <summary>
    /// <para>当前租户下待撤销的被动解除补偿金业务单 ID，可通过搜索被动解除补偿金信息接口获取。不能为空，长度为 1～64 个字符。</para>
    /// <para>必填：是</para>
    /// <para>示例值：1000000000000000001</para>
    /// <para>最大长度：64</para>
    /// <para>最小长度：1</para>
    /// </summary>
    [JsonPropertyName("severance_pay_id")]
    public string SeverancePayId { get; set; } = string.Empty;

    /// <summary>
    /// <para>当前租户内的操作人 ID，类型由查询参数 `user_id_type` 指定，默认使用飞书人事雇佣 ID（`people_corehr_id`）。未传时由系统操作；传入时须为能够识别为本租户用户的有效 ID，不能传空字符串，长度为 1～64 个字符。</para>
    /// <para>必填：否</para>
    /// <para>示例值：1000000000000000002</para>
    /// <para>最大长度：64</para>
    /// <para>最小长度：1</para>
    /// </summary>
    [JsonPropertyName("operator_id")]
    public string? OperatorId { get; set; }

    /// <summary>
    /// <para>撤销原因，最多 255 个 Unicode 字符。未传或传空字符串时保留单据已有的撤销原因；传入非空值时覆盖原原因。</para>
    /// <para>必填：否</para>
    /// <para>示例值：补偿金方案调整</para>
    /// <para>最大长度：255</para>
    /// <para>最小长度：0</para>
    /// </summary>
    [JsonPropertyName("withdrawn_reason")]
    public string? WithdrawnReason { get; set; }
}
