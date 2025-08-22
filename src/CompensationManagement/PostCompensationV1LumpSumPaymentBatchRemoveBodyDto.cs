// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-08-22
//
// Last Modified By : yxr
// Last Modified On : 2025-08-22
// ************************************************************************
// <copyright file="PostCompensationV1LumpSumPaymentBatchRemoveBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>批量删除一次性支付记录 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.CompensationManagement;
/// <summary>
/// 批量删除一次性支付记录 请求体
/// <para>传入一次性支付记录ID，删除ID对应的一次性支付记录</para>
/// <para>接口ID：7430824932635197444</para>
/// <para>文档地址：https://open.feishu.cn/document/corehr-v1/basic-compensation/lump_sum_payment/batch_remove</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fcompensation-v1%2flump_sum_payment%2fbatch_remove</para>
/// </summary>
public record PostCompensationV1LumpSumPaymentBatchRemoveBodyDto
{
    /// <summary>
    /// <para>要删除的一次性支付记录id（通过[【查询一次性支付记录】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/compensation-v1/lump_sum_payment/query) 接口进行查询）</para>
    /// <para>必填：否</para>
    /// <para>最大长度：500</para>
    /// <para>最小长度：0</para>
    /// </summary>
    [JsonPropertyName("record_ids")]
    public string[]? RecordIds { get; set; }

    /// <summary>
    /// <para>因重复提交删除</para>
    /// <para>必填：否</para>
    /// <para>示例值：删除原因实例</para>
    /// </summary>
    [JsonPropertyName("reason")]
    public string? Reason { get; set; }
}
