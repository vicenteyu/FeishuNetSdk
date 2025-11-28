// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-08-30
//
// Last Modified By : yxr
// Last Modified On : 2025-08-30
// ************************************************************************
// <copyright file="PostCompensationV1RecurringPaymentBatchRemoveBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>批量删除经常性支付记录 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.CompensationManagement;
/// <summary>
/// 批量删除经常性支付记录 请求体
/// <para>指定经常性支付记录ID，删除ID对应的经常性支付记录</para>
/// <para>接口ID：7441804833880260612</para>
/// <para>文档地址：https://open.feishu.cn/document/corehr-v1/basic-compensation/recurring_payment/batch_remove</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fcompensation-v1%2frecurring_payment%2fbatch_remove</para>
/// </summary>
public record PostCompensationV1RecurringPaymentBatchRemoveBodyDto
{
    /// <summary>
    /// <para>需要删除的记录ID（通过[【查询经常性支付记录】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/compensation-v1/recurring_payment/query) 接口进行查询）</para>
    /// <para>必填：是</para>
    /// <para>最大长度：500</para>
    /// <para>最小长度：0</para>
    /// </summary>
    [JsonPropertyName("record_ids")]
    public string[] RecordIds { get; set; } = [];

    /// <summary>
    /// <para>原因</para>
    /// <para>必填：否</para>
    /// <para>示例值：删除错误创建的数据</para>
    /// </summary>
    [JsonPropertyName("reason")]
    public string? Reason { get; set; }
}
