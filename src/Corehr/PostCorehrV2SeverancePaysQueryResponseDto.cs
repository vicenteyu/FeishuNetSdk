// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2026-11-15
//
// Last Modified By : yxr
// Last Modified On : 2026-11-15
// ************************************************************************
// <copyright file="PostCorehrV2SeverancePaysQueryResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>搜索被动解除补偿金信息 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Corehr;
/// <summary>
/// 搜索被动解除补偿金信息 响应体
/// <para>该接口用于按员工、补偿金记录 ID、状态、测算状态、时间范围和返回字段搜索被动解除补偿金记录。</para>
/// <para>接口ID：7667872540325727194</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/corehr-v2/severance_pay/query</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fcorehr-v2%2fseverance_pay%2fquery</para>
/// </summary>
public record PostCorehrV2SeverancePaysQueryResponseDto : IPageableResponse<PostCorehrV2SeverancePaysQueryResponseDto.SeverancePay>
{
    /// <summary>
    /// <para>补偿金明细列表</para>
    /// <para>必填：否</para>
    /// <para>最大长度：100</para>
    /// <para>最小长度：0</para>
    /// </summary>
    [JsonPropertyName("items")]
    public SeverancePay[]? Items { get; set; }

    /// <summary>
    /// <para>补偿金明细列表</para>
    /// </summary>
    public record SeverancePay
    {
        /// <summary>
        /// <para>补偿金/被动解除业务单 ID</para>
        /// <para>必填：否</para>
        /// <para>示例值：7660423757252773420</para>
        /// </summary>
        [JsonPropertyName("severance_pay_id")]
        public string? SeverancePayId { get; set; }

        /// <summary>
        /// <para>关联离职单 ID</para>
        /// <para>必填：否</para>
        /// <para>示例值：7660486572667979308</para>
        /// </summary>
        [JsonPropertyName("offboarding_id")]
        public string? OffboardingId { get; set; }

        /// <summary>
        /// <para>员工雇佣ID</para>
        /// <para>必填：否</para>
        /// <para>示例值：7659617611689510444</para>
        /// </summary>
        [JsonPropertyName("employment_id")]
        public string? EmploymentId { get; set; }

        /// <summary>
        /// <para>补偿金状态</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("status")]
        public Enum? Status { get; set; }

        /// <summary>
        /// <para>补偿金状态</para>
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
        /// <para>测算状态</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("calculate_status")]
        public Enum? CalculateStatus { get; set; }

        /// <summary>
        /// <para>离职日期</para>
        /// <para>必填：否</para>
        /// <para>示例值：2026-08-26</para>
        /// </summary>
        [JsonPropertyName("offboarding_date")]
        public string? OffboardingDate { get; set; }

        /// <summary>
        /// <para>补偿金信息</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("severance_pay_info")]
        public SeverancePayInfoSuffix? SeverancePayInfo { get; set; }

        /// <summary>
        /// <para>补偿金信息</para>
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
            /// <para>示例值：2026-12-01</para>
            /// </summary>
            [JsonPropertyName("standard_compensation_start_month")]
            public string? StandardCompensationStartMonth { get; set; }

            /// <summary>
            /// <para>经济补偿金基数结束月 YYYY-MM</para>
            /// <para>必填：否</para>
            /// <para>示例值：2026-12-01</para>
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
            /// <para>示例值：2026-12-01</para>
            /// </summary>
            [JsonPropertyName("other_compensation_start_month")]
            public string? OtherCompensationStartMonth { get; set; }

            /// <summary>
            /// <para>代通知金基数结束月 YYYY-MM</para>
            /// <para>必填：否</para>
            /// <para>示例值：2026-10-01</para>
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
            /// <para>示例值：2026-12-01</para>
            /// </summary>
            [JsonPropertyName("exceeding_base_start_month")]
            public string? ExceedingBaseStartMonth { get; set; }

            /// <summary>
            /// <para>超额补偿基数结束月 YYYY-MM</para>
            /// <para>必填：否</para>
            /// <para>示例值：2026-11-01</para>
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
            /// <para>示例值：2026-12-01</para>
            /// </summary>
            [JsonPropertyName("other_floating_base_start_month")]
            public string? OtherFloatingBaseStartMonth { get; set; }

            /// <summary>
            /// <para>其他浮动基数结束月 YYYY-MM</para>
            /// <para>必填：否</para>
            /// <para>示例值：2026-12-01</para>
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

            /// <summary>
            /// <para>经济补偿系数单位</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("standard_compensation_unit")]
            public Enum? StandardCompensationUnit { get; set; }

            /// <summary>
            /// <para>代通知金系数单位</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("other_compensation_unit")]
            public Enum? OtherCompensationUnit { get; set; }

            /// <summary>
            /// <para>超额补偿系数单位</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("exceeding_compensation_unit")]
            public Enum? ExceedingCompensationUnit { get; set; }

            /// <summary>
            /// <para>其他浮动系数单位</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("other_floating_unit")]
            public Enum? OtherFloatingUnit { get; set; }
        }

        /// <summary>
        /// <para>申请发起时间，Unix 秒级时间戳</para>
        /// <para>必填：否</para>
        /// <para>示例值：1783994400000</para>
        /// <para>最大长度：19</para>
        /// <para>最小长度：1</para>
        /// </summary>
        [JsonPropertyName("apply_initiating_time")]
        public string? ApplyInitiatingTime { get; set; }

        /// <summary>
        /// <para>BPM流程ID</para>
        /// <para>必填：否</para>
        /// <para>示例值：7660486572667979308</para>
        /// </summary>
        [JsonPropertyName("process_id")]
        public string? ProcessId { get; set; }

        /// <summary>
        /// <para>离职原因（枚举）</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("reason")]
        public Enum? Reason { get; set; }

        /// <summary>
        /// <para>离职说明</para>
        /// <para>必填：否</para>
        /// <para>示例值：离职说明</para>
        /// </summary>
        [JsonPropertyName("reason_explanation")]
        public string? ReasonExplanation { get; set; }

        /// <summary>
        /// <para>发起人雇佣ID</para>
        /// <para>必填：否</para>
        /// <para>示例值：7249355547343013420</para>
        /// </summary>
        [JsonPropertyName("initiator_id")]
        public string? InitiatorId { get; set; }

        /// <summary>
        /// <para>解除申请结束时间，Unix 秒级时间戳</para>
        /// <para>必填：否</para>
        /// <para>示例值：1783994400000</para>
        /// <para>最大长度：19</para>
        /// <para>最小长度：1</para>
        /// </summary>
        [JsonPropertyName("apply_finish_time")]
        public string? ApplyFinishTime { get; set; }

        /// <summary>
        /// <para>签署方式（枚举）</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("sign_type")]
        public Enum? SignType { get; set; }

        /// <summary>
        /// <para>社保公积金最后缴纳月份</para>
        /// <para>必填：否</para>
        /// <para>示例值：2026-08-01</para>
        /// </summary>
        [JsonPropertyName("social_insurance_end_date")]
        public string? SocialInsuranceEndDate { get; set; }

        /// <summary>
        /// <para>公积金截止月</para>
        /// <para>必填：否</para>
        /// <para>示例值：2026-08-01</para>
        /// </summary>
        [JsonPropertyName("provident_fund_end_date")]
        public string? ProvidentFundEndDate { get; set; }

        /// <summary>
        /// <para>审批结果</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("evaluation_result")]
        public Enum? EvaluationResult { get; set; }

        /// <summary>
        /// <para>撤销原因</para>
        /// <para>必填：否</para>
        /// <para>示例值：撤销原因</para>
        /// </summary>
        [JsonPropertyName("withdrawn_reason")]
        public string? WithdrawnReason { get; set; }

        /// <summary>
        /// <para>跟进人雇佣ID列表</para>
        /// <para>必填：否</para>
        /// <para>最大长度：100</para>
        /// <para>最小长度：0</para>
        /// </summary>
        [JsonPropertyName("followers")]
        public string[]? Followers { get; set; }

        /// <summary>
        /// <para>补偿金申请开始时间，Unix 秒级时间戳</para>
        /// <para>必填：否</para>
        /// <para>示例值：1783994400000</para>
        /// <para>最大长度：19</para>
        /// <para>最小长度：1</para>
        /// </summary>
        [JsonPropertyName("created_time")]
        public string? CreatedTime { get; set; }

        /// <summary>
        /// <para>更新时间，Unix 秒级时间戳</para>
        /// <para>必填：否</para>
        /// <para>示例值：1783994400000</para>
        /// <para>最大长度：19</para>
        /// <para>最小长度：1</para>
        /// </summary>
        [JsonPropertyName("updated_time")]
        public string? UpdatedTime { get; set; }

        /// <summary>
        /// <para>自定义字段</para>
        /// <para>必填：否</para>
        /// <para>最大长度：1000</para>
        /// <para>最小长度：0</para>
        /// </summary>
        [JsonPropertyName("custom_fields")]
        public CustomFieldData[]? CustomFields { get; set; }

        /// <summary>
        /// <para>自定义字段</para>
        /// </summary>
        public record CustomFieldData
        {
            /// <summary>
            /// <para>自定义字段 apiname，即自定义字段的唯一标识</para>
            /// <para>必填：是</para>
            /// <para>示例值：name</para>
            /// </summary>
            [JsonPropertyName("custom_api_name")]
            public string CustomApiName { get; set; } = string.Empty;

            /// <summary>
            /// <para>自定义字段名称</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("name")]
            public CustomName? Name { get; set; }

            /// <summary>
            /// <para>自定义字段名称</para>
            /// </summary>
            public record CustomName
            {
                /// <summary>
                /// <para>中文</para>
                /// <para>必填：否</para>
                /// <para>示例值：自定义姓名</para>
                /// </summary>
                [JsonPropertyName("zh_cn")]
                public string? ZhCn { get; set; }

                /// <summary>
                /// <para>英文</para>
                /// <para>必填：否</para>
                /// <para>示例值：Custom Name</para>
                /// </summary>
                [JsonPropertyName("en_us")]
                public string? EnUs { get; set; }
            }

            /// <summary>
            /// <para>自定义字段类型。可选值有：</para>
            /// <para>-1：文本类型，包括超链接字段</para>
            /// <para>-2：布尔类型</para>
            /// <para>-3：数字类型</para>
            /// <para>-4：枚举类型</para>
            /// <para>-5：Lookup类型，如人员等</para>
            /// <para>-8：时间类型</para>
            /// <para>-9：附件类型</para>
            /// <para>注意：不支持的字段类型未给出说明。</para>
            /// <para>必填：否</para>
            /// <para>示例值：1</para>
            /// </summary>
            [JsonPropertyName("type")]
            public int? Type { get; set; }

            /// <summary>
            /// <para>是 json 转义后的字符串，根据元数据定义不同，字段格式不同（如 123, 123.23, "true", ["id1","id2"], "2006-01-02 15:04:05"）</para>
            /// <para>必填：是</para>
            /// <para>示例值：\"231\"</para>
            /// </summary>
            [JsonPropertyName("value")]
            public string Value { get; set; } = string.Empty;
        }

        /// <summary>
        /// <para>签署文件 ID 列表，重签场景可能包含多个文件 ID</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("signature_file_ids")]
        public string[]? SignatureFileIds { get; set; }

        /// <summary>
        /// <para>从一级离职原因到当前 reason 末级的 APIName 列表</para>
        /// <para>必填：否</para>
        /// <para>最大长度：100</para>
        /// <para>最小长度：0</para>
        /// </summary>
        [JsonPropertyName("reason_chain")]
        public string[]? ReasonChain { get; set; }
    }

    /// <summary>
    /// <para>分页标记，当 has_more 为 true 时，会同时返回新的 page_token，否则不返回 page_token</para>
    /// <para>必填：否</para>
    /// <para>示例值：page_token_xxx</para>
    /// </summary>
    [JsonPropertyName("page_token")]
    public string? PageToken { get; set; }

    /// <summary>
    /// <para>是否还有更多项</para>
    /// <para>必填：否</para>
    /// <para>示例值：true</para>
    /// </summary>
    [JsonPropertyName("has_more")]
    public bool? HasMore { get; set; }

    /// <summary>
    /// <para>符合条件的总数</para>
    /// <para>必填：否</para>
    /// <para>示例值：1</para>
    /// </summary>
    [JsonPropertyName("total")]
    public string? Total { get; set; }
}
