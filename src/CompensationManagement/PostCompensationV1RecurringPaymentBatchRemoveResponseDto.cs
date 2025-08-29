// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-08-30
//
// Last Modified By : yxr
// Last Modified On : 2025-08-30
// ************************************************************************
// <copyright file="PostCompensationV1RecurringPaymentBatchRemoveResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>批量删除经常性支付记录 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.CompensationManagement;
/// <summary>
/// 批量删除经常性支付记录 响应体
/// <para>指定经常性支付记录ID，删除ID对应的经常性支付记录</para>
/// <para>接口ID：7441804833880260612</para>
/// <para>文档地址：https://open.feishu.cn/document/corehr-v1/basic-compensation/recurring_payment/batch_remove</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fcompensation-v1%2frecurring_payment%2fbatch_remove</para>
/// </summary>
public record PostCompensationV1RecurringPaymentBatchRemoveResponseDto
{
    /// <summary>
    /// <para>每条记录的操作结果</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("operate_results")]
    public RecurringPaymentOperateResult[]? OperateResults { get; set; }

    /// <summary>
    /// <para>每条记录的操作结果</para>
    /// </summary>
    public record RecurringPaymentOperateResult
    {
        /// <summary>
        /// <para>操作记录的id</para>
        /// <para>必填：否</para>
        /// <para>示例值：7390583861280556588</para>
        /// <para>最大长度：255</para>
        /// <para>最小长度：0</para>
        /// </summary>
        [JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// <para>操作的记录的 unique_id</para>
        /// <para>必填：否</para>
        /// <para>示例值：7390583861280556588</para>
        /// <para>最大长度：255</para>
        /// <para>最小长度：0</para>
        /// </summary>
        [JsonPropertyName("unique_id")]
        public string? UniqueId { get; set; }

        /// <summary>
        /// <para>操作结果状态码</para>
        /// <para>必填：否</para>
        /// <para>示例值：21270202</para>
        /// <para>最大值：2147483648</para>
        /// <para>最小值：0</para>
        /// <para>可选值：<list type="bullet">
        /// <item>0："Success" 操作成功</item>
        /// <item>21280001："The format of the single payment amount is incorrect" 单次发放金额格式不正确</item>
        /// <item>21280002："The format of the distribution start time is incorrect" 发放开始时间格式不正确</item>
        /// <item>21280003："The format of the issuance end time is incorrect" 发放结束时间格式不正确</item>
        /// <item>21270304："No permission for recurring payment record" 没有该经常性支付记录权限</item>
        /// <item>21270305："The recurring payment type salary item does not exist" 经常性支付类型薪酬项不存在</item>
        /// <item>21270306："The currency does not exist" 币种不存在</item>
        /// <item>21270307："The distribution method does not exist" 发放方式不存在</item>
        /// <item>21270308："The distribution start time is greater than the distribution end time" 发放开始时间大于发放结束时间</item>
        /// <item>21270309："Employees are not covered by the remuneration rules" 员工不在薪酬项规则适用范围之内</item>
        /// <item>21270310："The payment method does not match the salary item rules" 发放方式不匹配薪酬项规则</item>
        /// <item>21270311："Currency mismatch compensation item rules" 币种不匹配薪酬项规则</item>
        /// <item>21270312："The distribution start date is earlier than the current date and cannot be deleted" 发放开始日期早于当前日期不可删除</item>
        /// <item>21270313："The recurring payment record does not exist" 该经常性支付记录不存在</item>
        /// <item>21270314："Payment frequency does not match the salary item" 发放频率不匹配薪酬项</item>
        /// </list></para>
        /// </summary>
        [JsonPropertyName("code")]
        public int? Code { get; set; }

        /// <summary>
        /// <para>操作结果描述</para>
        /// <para>必填：否</para>
        /// <para>示例值：unique id conflict</para>
        /// <para>最大长度：255</para>
        /// <para>最小长度：0</para>
        /// </summary>
        [JsonPropertyName("message")]
        public string? Message { get; set; }
    }
}
