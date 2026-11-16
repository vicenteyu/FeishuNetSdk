// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2026-11-15
//
// Last Modified By : yxr
// Last Modified On : 2026-11-15
// ************************************************************************
// <copyright file="PostCorehrV2SeverancePaysSubmitBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>发起被动解除补偿金流程 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Corehr;
/// <summary>
/// 发起被动解除补偿金流程 请求体
/// <para>该接口用于为指定员工发起被动解除补偿金流程，并返回补偿金记录 ID、流程实例 ID 和当前状态。</para>
/// <para>接口ID：7667872540325743578</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/corehr-v2/severance_pay/submit</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fcorehr-v2%2fseverance_pay%2fsubmit</para>
/// </summary>
public record PostCorehrV2SeverancePaysSubmitBodyDto
{
    /// <summary>
    /// <para>被解除员工雇佣ID，可通过[搜索员工信息](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/corehr-v2/employee/search)获取。</para>
    /// <para>必填：是</para>
    /// <para>示例值：7659617611689510444</para>
    /// </summary>
    [JsonPropertyName("employment_id")]
    public string EmploymentId { get; set; } = string.Empty;

    /// <summary>
    /// <para>离职日期 YYYY-MM-DD</para>
    /// <para>必填：是</para>
    /// <para>示例值：2026-08-26</para>
    /// </summary>
    [JsonPropertyName("offboarding_date")]
    public string OffboardingDate { get; set; } = string.Empty;

    /// <summary>
    /// <para>离职原因唯一标识（被动解除原因），可通过[查询员工离职原因列表](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/offboarding/query)接口获取</para>
    /// <para>必填：是</para>
    /// <para>示例值：positive</para>
    /// </summary>
    [JsonPropertyName("offboarding_reason_unique_identifier")]
    public string OffboardingReasonUniqueIdentifier { get; set; } = string.Empty;

    /// <summary>
    /// <para>发起人雇佣ID（代发起），可通过[搜索员工信息](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/corehr-v2/employee/search)获取。</para>
    /// <para>必填：是</para>
    /// <para>示例值：7249355547343013420</para>
    /// </summary>
    [JsonPropertyName("initiator_id")]
    public string InitiatorId { get; set; } = string.Empty;

    /// <summary>
    /// <para>补偿金信息（被动解除核心）</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("severance_pay_info")]
    public SeverancePayInfoSuffix? SeverancePayInfo { get; set; }

    /// <summary>
    /// <para>补偿金信息（被动解除核心）</para>
    /// </summary>
    public record SeverancePayInfoSuffix
    {
        /// <summary>
        /// <para>补偿类型</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("severance_pay_type")]
        public Enum? SeverancePayType { get; set; }

        /// <summary>
        /// <para>补偿类型</para>
        /// </summary>
        public record Enum
        {
            /// <summary>
            /// <para>枚举值</para>
            /// <para>必填：是</para>
            /// <para>示例值：phone_type</para>
            /// </summary>
            [JsonPropertyName("enum_name")]
            public string EnumName { get; set; } = string.Empty;

            /// <summary>
            /// <para>枚举多语展示</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("display")]
            public I18n[]? Displies { get; set; }

            /// <summary>
            /// <para>枚举多语展示</para>
            /// </summary>
            public record I18n
            {
                /// <summary>
                /// <para>语言编码（IETF BCP 47）</para>
                /// <para>必填：是</para>
                /// <para>示例值：zh-CN</para>
                /// </summary>
                [JsonPropertyName("lang")]
                public string Lang { get; set; } = string.Empty;

                /// <summary>
                /// <para>文本内容</para>
                /// <para>必填：是</para>
                /// <para>示例值：中文示例</para>
                /// </summary>
                [JsonPropertyName("value")]
                public string Value { get; set; } = string.Empty;
            }
        }

        /// <summary>
        /// <para>标准补偿金额（字符串避免精度问题）</para>
        /// <para>必填：否</para>
        /// <para>示例值：77654.00</para>
        /// </summary>
        [JsonPropertyName("standard_severance_pay_amount")]
        public string? StandardSeverancePayAmount { get; set; }

        /// <summary>
        /// <para>超额补偿金额</para>
        /// <para>必填：否</para>
        /// <para>示例值：776.00</para>
        /// </summary>
        [JsonPropertyName("exceeding_severance_pay_amount")]
        public string? ExceedingSeverancePayAmount { get; set; }

        /// <summary>
        /// <para>币种</para>
        /// <para>必填：否</para>
        /// <para>示例值：THB</para>
        /// </summary>
        [JsonPropertyName("currency")]
        public string? Currency { get; set; }

        /// <summary>
        /// <para>补偿说明</para>
        /// <para>必填：否</para>
        /// <para>示例值：补偿说明</para>
        /// </summary>
        [JsonPropertyName("reason_explanation")]
        public string? ReasonExplanation { get; set; }

        /// <summary>
        /// <para>经济补偿金基数起始月 YYYY-MM</para>
        /// <para>必填：否</para>
        /// <para>示例值：2026-12</para>
        /// </summary>
        [JsonPropertyName("standard_compensation_start_month")]
        public string? StandardCompensationStartMonth { get; set; }

        /// <summary>
        /// <para>经济补偿金基数结束月 YYYY-MM</para>
        /// <para>必填：否</para>
        /// <para>示例值：2026-12</para>
        /// </summary>
        [JsonPropertyName("standard_compensation_end_month")]
        public string? StandardCompensationEndMonth { get; set; }

        /// <summary>
        /// <para>经济补偿金基数</para>
        /// <para>必填：否</para>
        /// <para>示例值：567.00</para>
        /// </summary>
        [JsonPropertyName("standard_compensation_base")]
        public string? StandardCompensationBase { get; set; }

        /// <summary>
        /// <para>经济补偿系数</para>
        /// <para>必填：否</para>
        /// <para>示例值：776.00</para>
        /// </summary>
        [JsonPropertyName("standard_compensation_coefficient")]
        public string? StandardCompensationCoefficient { get; set; }

        /// <summary>
        /// <para>经济补偿金实际金额</para>
        /// <para>必填：否</para>
        /// <para>示例值：65445.00</para>
        /// </summary>
        [JsonPropertyName("actual_standard_amount")]
        public string? ActualStandardAmount { get; set; }

        /// <summary>
        /// <para>代通知金基数起始月 YYYY-MM</para>
        /// <para>必填：否</para>
        /// <para>示例值：2026-12</para>
        /// </summary>
        [JsonPropertyName("other_compensation_start_month")]
        public string? OtherCompensationStartMonth { get; set; }

        /// <summary>
        /// <para>代通知金基数结束月 YYYY-MM</para>
        /// <para>必填：否</para>
        /// <para>示例值：2026-10</para>
        /// </summary>
        [JsonPropertyName("other_compensation_end_month")]
        public string? OtherCompensationEndMonth { get; set; }

        /// <summary>
        /// <para>代通知金基数</para>
        /// <para>必填：否</para>
        /// <para>示例值：7665.00</para>
        /// </summary>
        [JsonPropertyName("other_compensation_base")]
        public string? OtherCompensationBase { get; set; }

        /// <summary>
        /// <para>代通知金系数</para>
        /// <para>必填：否</para>
        /// <para>示例值：8766.00</para>
        /// </summary>
        [JsonPropertyName("other_compensation_coefficient")]
        public string? OtherCompensationCoefficient { get; set; }

        /// <summary>
        /// <para>代通知金测算金额</para>
        /// <para>必填：否</para>
        /// <para>示例值：7665.00</para>
        /// </summary>
        [JsonPropertyName("other_compensation_amount")]
        public string? OtherCompensationAmount { get; set; }

        /// <summary>
        /// <para>代通知金实际金额</para>
        /// <para>必填：否</para>
        /// <para>示例值：7665.00</para>
        /// </summary>
        [JsonPropertyName("actual_notice_payment_amount")]
        public string? ActualNoticePaymentAmount { get; set; }

        /// <summary>
        /// <para>超额补偿基数起始月 YYYY-MM</para>
        /// <para>必填：否</para>
        /// <para>示例值：2026-12</para>
        /// </summary>
        [JsonPropertyName("exceeding_base_start_month")]
        public string? ExceedingBaseStartMonth { get; set; }

        /// <summary>
        /// <para>超额补偿基数结束月 YYYY-MM</para>
        /// <para>必填：否</para>
        /// <para>示例值：2026-11</para>
        /// </summary>
        [JsonPropertyName("exceeding_base_end_month")]
        public string? ExceedingBaseEndMonth { get; set; }

        /// <summary>
        /// <para>超额补偿基数</para>
        /// <para>必填：否</para>
        /// <para>示例值：7655.00</para>
        /// </summary>
        [JsonPropertyName("exceeding_compensation_base")]
        public string? ExceedingCompensationBase { get; set; }

        /// <summary>
        /// <para>超额补偿月数</para>
        /// <para>必填：否</para>
        /// <para>示例值：7655.00</para>
        /// </summary>
        [JsonPropertyName("exceeding_compensation_coefficient")]
        public string? ExceedingCompensationCoefficient { get; set; }

        /// <summary>
        /// <para>超额补偿实际金额</para>
        /// <para>必填：否</para>
        /// <para>示例值：54433.00</para>
        /// </summary>
        [JsonPropertyName("actual_excess_amount")]
        public string? ActualExcessAmount { get; set; }

        /// <summary>
        /// <para>其他浮动基数起始月 YYYY-MM</para>
        /// <para>必填：否</para>
        /// <para>示例值：2026-12</para>
        /// </summary>
        [JsonPropertyName("other_floating_base_start_month")]
        public string? OtherFloatingBaseStartMonth { get; set; }

        /// <summary>
        /// <para>其他浮动基数结束月 YYYY-MM</para>
        /// <para>必填：否</para>
        /// <para>示例值：2026-12</para>
        /// </summary>
        [JsonPropertyName("other_floating_base_end_month")]
        public string? OtherFloatingBaseEndMonth { get; set; }

        /// <summary>
        /// <para>其他浮动基数</para>
        /// <para>必填：否</para>
        /// <para>示例值：7666.00</para>
        /// </summary>
        [JsonPropertyName("other_floating_base")]
        public string? OtherFloatingBase { get; set; }

        /// <summary>
        /// <para>其他浮动系数</para>
        /// <para>必填：否</para>
        /// <para>示例值：1.00</para>
        /// </summary>
        [JsonPropertyName("other_floating_coefficient")]
        public string? OtherFloatingCoefficient { get; set; }

        /// <summary>
        /// <para>其他浮动测算金额</para>
        /// <para>必填：否</para>
        /// <para>示例值：655.00</para>
        /// </summary>
        [JsonPropertyName("other_floating_amount")]
        public string? OtherFloatingAmount { get; set; }

        /// <summary>
        /// <para>其他浮动实际金额</para>
        /// <para>必填：否</para>
        /// <para>示例值：655.00</para>
        /// </summary>
        [JsonPropertyName("actual_other_floating_amount")]
        public string? ActualOtherFloatingAmount { get; set; }

        /// <summary>
        /// <para>补偿金测算总额</para>
        /// <para>必填：否</para>
        /// <para>示例值：665.00</para>
        /// </summary>
        [JsonPropertyName("expect_severance_pay_amount")]
        public string? ExpectSeverancePayAmount { get; set; }

        /// <summary>
        /// <para>实际补偿总额</para>
        /// <para>必填：否</para>
        /// <para>示例值：6545.00</para>
        /// </summary>
        [JsonPropertyName("severance_pay_amount")]
        public string? SeverancePayAmount { get; set; }

        /// <summary>
        /// <para>补偿金金额上限</para>
        /// <para>必填：否</para>
        /// <para>示例值：665545.00</para>
        /// </summary>
        [JsonPropertyName("severance_pay_upper_limit")]
        public string? SeverancePayUpperLimit { get; set; }

        /// <summary>
        /// <para>补偿金信息说明</para>
        /// <para>必填：否</para>
        /// <para>示例值：补偿金信息说明</para>
        /// </summary>
        [JsonPropertyName("severance_pay_calculate_explanation")]
        public string? SeverancePayCalculateExplanation { get; set; }
    }

    /// <summary>
    /// <para>自定义字段。不同元数据类型按对应的数据结构传入，最多 1000 个</para>
    /// <para>必填：否</para>
    /// <para>最大长度：1000</para>
    /// <para>最小长度：0</para>
    /// </summary>
    [JsonPropertyName("custom_fields")]
    public ObjectFieldData[]? CustomFields { get; set; }

    /// <summary>
    /// <para>自定义字段。不同元数据类型按对应的数据结构传入，最多 1000 个</para>
    /// </summary>
    public record ObjectFieldData
    {
        /// <summary>
        /// <para>自定义字段 apiname，即自定义字段的唯一标识</para>
        /// <para>必填：是</para>
        /// <para>示例值：name</para>
        /// </summary>
        [JsonPropertyName("field_name")]
        public string FieldName { get; set; } = string.Empty;

        /// <summary>
        /// <para>是 json 转义后的字符串，根据元数据定义不同，字段格式不同（如 123, 123.23, "true", ["id1","id2"], "2006-01-02 15:04:05"）</para>
        /// <para>必填：是</para>
        /// <para>示例值：Sandy</para>
        /// </summary>
        [JsonPropertyName("value")]
        public string Value { get; set; } = string.Empty;
    }
}
