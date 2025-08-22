// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-08-22
//
// Last Modified By : yxr
// Last Modified On : 2025-08-22
// ************************************************************************
// <copyright file="PostCompensationV1LumpSumPaymentBatchCreateResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>批量创建一次性支付记录 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.CompensationManagement;
/// <summary>
/// 批量创建一次性支付记录 响应体
/// <para>通过传入的一次性支付记录数据，校验并创建一次性支付记录，并返回创建失败原因或创建成功数据的ID</para>
/// <para>接口ID：7429528484932812828</para>
/// <para>文档地址：https://open.feishu.cn/document/corehr-v1/basic-compensation/lump_sum_payment/batch_create</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fcompensation-v1%2flump_sum_payment%2fbatch_create</para>
/// </summary>
public record PostCompensationV1LumpSumPaymentBatchCreateResponseDto
{
    /// <summary>
    /// <para>每条记录的操作结果。对于创建成功的记录，会返回创建后的一次性支付记录id</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("operate_results")]
    public LumpSumPaymentOperateResult[]? OperateResults { get; set; }

    /// <summary>
    /// <para>每条记录的操作结果。对于创建成功的记录，会返回创建后的一次性支付记录id</para>
    /// </summary>
    public record LumpSumPaymentOperateResult
    {
        /// <summary>
        /// <para>操作的记录的 id</para>
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
        /// <item>21270201："The bonus to be changed does not exist" 要更改的奖金不存在</item>
        /// <item>21270202："Idempotent ID conflict" 幂等id冲突</item>
        /// <item>21270203："The total amount format is incorrect" 总金额格式不正确</item>
        /// <item>21270205："Only use the number of decimal places specified in the bonus item rules" 仅限使用奖金项规则中规定的小数位数</item>
        /// <item>21270206："The sum of the bonus details does not equal the total amount" 奖金明细金额之和不等于总金额</item>
        /// <item>21270207："issuance frequency not equal to size of details" 奖金明细总数不等于发放次数</item>
        /// <item>21270208："The number of issuances is less than or equal to 0" 发放次数小于等于0</item>
        /// <item>21270209："The currency is empty or does not exist" 币种为空或不存在</item>
        /// <item>21270210："Notes are too long" 备注超长</item>
        /// <item>21270211："The bonus details amount format is incorrect" 奖金明细金额格式不正确</item>
        /// <item>21270213："The bonus details payment time format is incorrect" 奖金明细的发放时间格式不正确</item>
        /// <item>21270214："The bonus details are issued in an illegal manner" 奖金明细的发放方式不合法</item>
        /// <item>21270215："The bonus details are not in a valid payment status" 奖金明细的发放状态不合法</item>
        /// <item>21270217："Employees are not covered by the bonus rules" 员工不在奖金项规则适用范围之内</item>
        /// <item>21270218："The method of awarding bonus details is not covered by the bonus item rules" 奖金明细的发放方式不在奖金项规则适用范围之内</item>
        /// <item>21270219："Bonus item rules do not support configuration of binding period" 奖金项规则不支持配置绑定期</item>
        /// <item>21270220："The bonus details payment status is "paid", and cannot be modified" 奖金明细发放状态为「已发放」，不支持修改</item>
        /// <item>21270221："The bonus item rules already include the currency, and other currencies cannot be specified" 奖金项规则已包含币种，不支持指定其他币种</item>
        /// <item>21270222："The salary item does not exist" 薪酬项不存在</item>
        /// <item>21270223："Employee does not exist" 员工不存在</item>
        /// <item>21270224："The bonus details payment status is "paid", and deletion is not supported" 奖金明细发放状态为「已发放」，不支持删除</item>
        /// <item>21270225："Bonus rules do not allow multiple awards" 奖金项规则不允许多次发放</item>
        /// <item>21270226："No data permission" 无数据权限</item>
        /// <item>21270227："Only positive integers are allowed for the binding period" 绑定期只允许正整数</item>
        /// <item>21270228："This bonus does not currently support custom binding periods. Please configure and write according to the rules for the binding period of the salary item" 该奖金暂不支持自定义绑定期，请按照薪酬项绑定期规则配置写入</item>
        /// <item>21270229："The application issuance date must not be later than the issuance date" 申请发放日期不得晚于发放日期</item>
        /// <item>21270230："The application payment date format of the bonus details is incorrect" 奖金明细的申请发放日期格式不正确</item>
        /// </list></para>
        /// </summary>
        [JsonPropertyName("code")]
        public int? Code { get; set; }

        /// <summary>
        /// <para>操作结果描述</para>
        /// <para>必填：否</para>
        /// <para>示例值：uqniue id conflict</para>
        /// <para>最大长度：255</para>
        /// <para>最小长度：0</para>
        /// </summary>
        [JsonPropertyName("message")]
        public string? Message { get; set; }
    }
}
