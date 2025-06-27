// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-06-28
// ************************************************************************
// <copyright file="PostCorehrV2ProbationSearchResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>搜索试用期信息 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Corehr;
/// <summary>
/// 搜索试用期信息 响应体
/// <para>搜索试用期信息，创建试用期后立刻搜索，可能会存在 5s 左右延迟</para>
/// <para>接口ID：7254814386694553602</para>
/// <para>文档地址：https://open.feishu.cn/document/corehr-v1/probation/search</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fcorehr-v2%2fprobation%2fsearch</para>
/// </summary>
public record PostCorehrV2ProbationSearchResponseDto : IPageableResponse<PostCorehrV2ProbationSearchResponseDto.ProbationInfo>
{
    /// <summary>
    /// <para>查询的试用期信息</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("items")]
    public ProbationInfo[]? Items { get; set; }

    /// <summary>
    /// <para>查询的试用期信息</para>
    /// </summary>
    public record ProbationInfo
    {
        /// <summary>
        /// <para>雇佣 ID，可通过[【搜索员工信息】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/corehr-v2/employee/search)接口获取</para>
        /// <para>必填：否</para>
        /// <para>示例值：6893014062142064135</para>
        /// </summary>
        [JsonPropertyName("employment_id")]
        public string? EmploymentId { get; set; }

        /// <summary>
        /// <para>试用期信息 ID</para>
        /// <para>必填：否</para>
        /// <para>示例值：6893014062142064132</para>
        /// </summary>
        [JsonPropertyName("probation_id")]
        public string? ProbationId { get; set; }

        /// <summary>
        /// <para>试用期开始日期，格式："YYYY-MM-DD"</para>
        /// <para>必填：否</para>
        /// <para>示例值：2022-05-20</para>
        /// </summary>
        [JsonPropertyName("probation_start_date")]
        public string? ProbationStartDate { get; set; }

        /// <summary>
        /// <para>试用期预计结束日期，格式："YYYY-MM-DD"</para>
        /// <para>必填：否</para>
        /// <para>示例值：2022-05-28</para>
        /// </summary>
        [JsonPropertyName("probation_expected_end_date")]
        public string? ProbationExpectedEndDate { get; set; }

        /// <summary>
        /// <para>试用期实际结束日期，格式："YYYY-MM-DD"</para>
        /// <para>必填：否</para>
        /// <para>示例值：2022-06-28</para>
        /// </summary>
        [JsonPropertyName("actual_probation_end_date")]
        public string? ActualProbationEndDate { get; set; }

        /// <summary>
        /// <para>转正发起日期，格式："YYYY-MM-DD"</para>
        /// <para>必填：否</para>
        /// <para>示例值：2022-07-28</para>
        /// </summary>
        [JsonPropertyName("initiating_time")]
        public string? InitiatingTime { get; set; }

        /// <summary>
        /// <para>发起方</para>
        /// <para>- hr_submission：HR 发起</para>
        /// <para>- self_submission：员工发起</para>
        /// <para>- system ：系统发起</para>
        /// <para>必填：否</para>
        /// <para>示例值：hr_submission</para>
        /// </summary>
        [JsonPropertyName("submission_type")]
        public Enum? SubmissionType { get; set; }

        /// <summary>
        /// <para>发起方</para>
        /// <para>- hr_submission：HR 发起</para>
        /// <para>- self_submission：员工发起</para>
        /// <para>- system ：系统发起</para>
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
        /// <para>转正发起人的雇佣 ID，当系统发起转正时该字段为空，可通过[【搜索员工信息】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/corehr-v2/employee/search)接口获取</para>
        /// <para>必填：否</para>
        /// <para>示例值：6893014062142061135</para>
        /// </summary>
        [JsonPropertyName("initiator_id")]
        public string? InitiatorId { get; set; }

        /// <summary>
        /// <para>试用期状态：</para>
        /// <para>- pending：审批中</para>
        /// <para>- rejected：已拒绝</para>
        /// <para>- waiting：待发起转正</para>
        /// <para>- approved：审批通过</para>
        /// <para>- converted：已转正</para>
        /// <para>- offboarded：已离职</para>
        /// <para>必填：否</para>
        /// <para>示例值：converted</para>
        /// </summary>
        [JsonPropertyName("probation_status")]
        public Enum? ProbationStatus { get; set; }

        /// <summary>
        /// <para>员工自评</para>
        /// <para>必填：否</para>
        /// <para>示例值：符合预期</para>
        /// </summary>
        [JsonPropertyName("self_review")]
        public string? SelfReview { get; set; }

        /// <summary>
        /// <para>备注</para>
        /// <para>必填：否</para>
        /// <para>示例值：高潜</para>
        /// </summary>
        [JsonPropertyName("notes")]
        public string? Notes { get; set; }

        /// <summary>
        /// <para>流程实例 ID</para>
        /// <para>必填：否</para>
        /// <para>示例值：6893014062142164135</para>
        /// </summary>
        [JsonPropertyName("process_id")]
        public string? ProcessId { get; set; }

        /// <summary>
        /// <para>是否通过 BPM 转正</para>
        /// <para>必填：否</para>
        /// <para>示例值：false</para>
        /// </summary>
        [JsonPropertyName("converted_via_bpm")]
        public bool? ConvertedViaBpm { get; set; }

        /// <summary>
        /// <para>自定义字段</para>
        /// <para>必填：否</para>
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
            /// <para>自定义字段类型</para>
            /// <para>必填：否</para>
            /// <para>示例值：1</para>
            /// </summary>
            [JsonPropertyName("type")]
            public int? Type { get; set; }

            /// <summary>
            /// <para>字段值，是 json 转义后的字符串，根据元数据定义不同，字段格式不同（如 123, 123.23, "true", ["id1","id2"], "2006-01-02 15:04:05"）</para>
            /// <para>必填：是</para>
            /// <para>示例值：\"231\"</para>
            /// </summary>
            [JsonPropertyName("value")]
            public string Value { get; set; } = string.Empty;
        }

        /// <summary>
        /// <para>试用期考核最终状态：</para>
        /// <para>- not_started：未开始</para>
        /// <para>- in_process：进行中</para>
        /// <para>- completed：已完成</para>
        /// <para>- no_need：无需考核</para>
        /// <para>必填：否</para>
        /// <para>示例值：completed</para>
        /// </summary>
        [JsonPropertyName("final_assessment_status")]
        public Enum? FinalAssessmentStatus { get; set; }

        /// <summary>
        /// <para>试用期考核最终结果：</para>
        /// <para>- approved：通过</para>
        /// <para>- rejected：不通过</para>
        /// <para>必填：否</para>
        /// <para>示例值：approved</para>
        /// </summary>
        [JsonPropertyName("final_assessment_result")]
        public Enum? FinalAssessmentResult { get; set; }

        /// <summary>
        /// <para>试用期考核最终得分</para>
        /// <para>必填：否</para>
        /// <para>示例值：99.9</para>
        /// </summary>
        [JsonPropertyName("final_assessment_score")]
        public float? FinalAssessmentScore { get; set; }

        /// <summary>
        /// <para>试用期考核最终等级，枚举值 api_name 可通过[【获取字段详情】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/custom_field/get_by_param)接口查询，查询参数如下：</para>
        /// <para>- object_api_name = "probation_management"</para>
        /// <para>- custom_api_name = "final_assessment_grade"</para>
        /// <para>必填：否</para>
        /// <para>示例值：grade_a</para>
        /// </summary>
        [JsonPropertyName("final_assessment_grade")]
        public Enum? FinalAssessmentGrade { get; set; }

        /// <summary>
        /// <para>试用期考核最终评语</para>
        /// <para>必填：否</para>
        /// <para>示例值：超出预期</para>
        /// </summary>
        [JsonPropertyName("final_assessment_comment")]
        public string? FinalAssessmentComment { get; set; }

        /// <summary>
        /// <para>最终考核结果页面超链接</para>
        /// <para>必填：否</para>
        /// <para>示例值：https://qwe112233.feishuapp.bytedance.net/ae/ui/apps//122265873393330/recordPages/1/records/1767139312?objectId=17661180522543&amp;recordPageId=173330728118312</para>
        /// </summary>
        [JsonPropertyName("final_assessment_detail")]
        public string? FinalAssessmentDetail { get; set; }

        /// <summary>
        /// <para>试用期考核结果列表</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("assessments")]
        public Assessment[]? Assessments { get; set; }

        /// <summary>
        /// <para>试用期考核结果列表</para>
        /// </summary>
        public record Assessment
        {
            /// <summary>
            /// <para>考核结果 ID</para>
            /// <para>必填：否</para>
            /// <para>示例值：6893014061142064135</para>
            /// </summary>
            [JsonPropertyName("assessment_id")]
            public string? AssessmentId { get; set; }

            /// <summary>
            /// <para>考核状态</para>
            /// <para>- not_started：未开始</para>
            /// <para>- in_process：进行中</para>
            /// <para>- completed：已完成</para>
            /// <para>- no_need：无需考核</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("assessment_status")]
            public Enum? AssessmentStatus { get; set; }

            /// <summary>
            /// <para>考核状态</para>
            /// <para>- not_started：未开始</para>
            /// <para>- in_process：进行中</para>
            /// <para>- completed：已完成</para>
            /// <para>- no_need：无需考核</para>
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
            /// <para>试用期考核结果</para>
            /// <para>- approved：通过</para>
            /// <para>- rejected：不通过</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("assessment_result")]
            public Enum? AssessmentResult { get; set; }

            /// <summary>
            /// <para>考核得分</para>
            /// <para>必填：否</para>
            /// <para>示例值：99.9</para>
            /// </summary>
            [JsonPropertyName("assessment_score")]
            public float? AssessmentScore { get; set; }

            /// <summary>
            /// <para>试用期考核等级，枚举值 api_name 可通过[【获取字段详情】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/custom_field/get_by_param)接口查询，查询参数如下：</para>
            /// <para>- object_api_name = "probation_management"</para>
            /// <para>- custom_api_name = "final_assessment_grade"</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("assessment_grade")]
            public Enum? AssessmentGrade { get; set; }

            /// <summary>
            /// <para>考核评语</para>
            /// <para>必填：否</para>
            /// <para>示例值：超出预期</para>
            /// </summary>
            [JsonPropertyName("assessment_comment")]
            public string? AssessmentComment { get; set; }

            /// <summary>
            /// <para>考核结果页面超链接</para>
            /// <para>必填：否</para>
            /// <para>示例值：https://qwe1123433.feishuapp.bytedance.net/ae/ui/apps//122265871113330/recordPages/2/records/17611111112?objectId=17663333322543&amp;recordPageId=171128122312</para>
            /// </summary>
            [JsonPropertyName("assessment_detail")]
            public string? AssessmentDetail { get; set; }

            /// <summary>
            /// <para>是否为最终考核结果</para>
            /// <para>必填：否</para>
            /// <para>示例值：false</para>
            /// </summary>
            [JsonPropertyName("is_final_asssessment")]
            public bool? IsFinalAsssessment { get; set; }
        }

        /// <summary>
        /// <para>试用期延长后的预计结束日期</para>
        /// <para>必填：否</para>
        /// <para>示例值：2022-05-20</para>
        /// </summary>
        [JsonPropertyName("probation_extend_expected_end_date")]
        public string? ProbationExtendExpectedEndDate { get; set; }

        /// <summary>
        /// <para>试用期延长时间</para>
        /// <para>必填：否</para>
        /// <para>示例值：1</para>
        /// </summary>
        [JsonPropertyName("extended_probation_period_duration")]
        public int? ExtendedProbationPeriodDuration { get; set; }

        /// <summary>
        /// <para>试用期延长时间单位</para>
        /// <para>必填：否</para>
        /// <para>示例值：month</para>
        /// </summary>
        [JsonPropertyName("extended_probation_period_unit")]
        public Enum? ExtendedProbationPeriodUnit { get; set; }

        /// <summary>
        /// <para>试用期结果</para>
        /// <para>必填：否</para>
        /// <para>示例值：passed</para>
        /// </summary>
        [JsonPropertyName("probation_outcome")]
        public Enum? ProbationOutcome { get; set; }
    }

    /// <summary>
    /// <para>分页标记，当 has_more 为 true 时，会同时返回新的 page_token，否则不返回 page_token</para>
    /// <para>必填：否</para>
    /// <para>示例值：eVQrYzJBNDNONlk4VFZBZVlSdzlKdFJ4bVVHVExENDNKVHoxaVdiVnViQT0=</para>
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
}
