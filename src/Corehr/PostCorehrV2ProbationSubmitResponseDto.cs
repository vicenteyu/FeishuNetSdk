// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-07-18
//
// Last Modified By : yxr
// Last Modified On : 2024-07-18
// ************************************************************************
// <copyright file="PostCorehrV2ProbationSubmitResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>发起转正 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Corehr;
/// <summary>
/// 发起转正 响应体
/// <para>通过本接口可以为员工发起转正</para>
/// <para>接口ID：7254814386694635522</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/corehr-v2/probation/submit</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fcorehr-v2%2fprobation%2fsubmit</para>
/// </summary>
public record PostCorehrV2ProbationSubmitResponseDto
{
    /// <summary>
    /// <para>试用期信息</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("probation_info")]
    public ProbationInfoForSubmit? ProbationInfo { get; set; }

    /// <summary>
    /// <para>试用期信息</para>
    /// </summary>
    public record ProbationInfoForSubmit
    {
        /// <summary>
        /// <para>雇佣 ID</para>
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
        /// <para>试用期开始日期</para>
        /// <para>必填：否</para>
        /// <para>示例值：2022-05-20</para>
        /// </summary>
        [JsonPropertyName("probation_start_date")]
        public string? ProbationStartDate { get; set; }

        /// <summary>
        /// <para>试用期预计结束日期</para>
        /// <para>必填：否</para>
        /// <para>示例值：2022-05-28</para>
        /// </summary>
        [JsonPropertyName("probation_expected_end_date")]
        public string? ProbationExpectedEndDate { get; set; }

        /// <summary>
        /// <para>试用期实际结束日期</para>
        /// <para>必填：否</para>
        /// <para>示例值：2022-06-28</para>
        /// </summary>
        [JsonPropertyName("actual_probation_end_date")]
        public string? ActualProbationEndDate { get; set; }

        /// <summary>
        /// <para>转正发起日期</para>
        /// <para>必填：否</para>
        /// <para>示例值：2022-07-28</para>
        /// </summary>
        [JsonPropertyName("initiating_time")]
        public string? InitiatingTime { get; set; }

        /// <summary>
        /// <para>发起方</para>
        /// <para>必填：否</para>
        /// <para>示例值：hr_submission</para>
        /// </summary>
        [JsonPropertyName("submission_type")]
        public Enum? SubmissionType { get; set; }

        /// <summary>
        /// <para>发起方</para>
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
                /// <para>语言</para>
                /// <para>必填：是</para>
                /// <para>示例值：zh-CN</para>
                /// </summary>
                [JsonPropertyName("lang")]
                public string Lang { get; set; } = string.Empty;

                /// <summary>
                /// <para>内容</para>
                /// <para>必填：是</para>
                /// <para>示例值：张三</para>
                /// </summary>
                [JsonPropertyName("value")]
                public string Value { get; set; } = string.Empty;
            }
        }

        /// <summary>
        /// <para>转正发起人的雇佣 ID，当系统发起转正时该字段为空</para>
        /// <para>必填：否</para>
        /// <para>示例值：6893014062142061135</para>
        /// </summary>
        [JsonPropertyName("initiator_id")]
        public string? InitiatorId { get; set; }

        /// <summary>
        /// <para>试用期状态</para>
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
            /// <para>字段值，是 json 转义后的字符串，根据元数据定义不同，字段格式不同，不同类型字段传值格式如下</para>
            /// <para>- 文本，示例："你好"</para>
            /// <para>- 超链接，示例："https://www.baidu.com/"</para>
            /// <para>- 数字，示例："123"</para>
            /// <para>- 布尔，示例："true"</para>
            /// <para>- 单选，示例："option1"</para>
            /// <para>- 多选，示例："[\"option1\", \"option2\"]"</para>
            /// <para>- 人员（单选），示例："7140964208476371111"</para>
            /// <para>- 人员（多选），示例："[\"7140964208476371111\", \"7140964208476371112\"]"</para>
            /// <para>- 日期，示例："2025-01-01"</para>
            /// <para>必填：是</para>
            /// <para>示例值：231</para>
            /// </summary>
            [JsonPropertyName("value")]
            public string Value { get; set; } = string.Empty;
        }

        /// <summary>
        /// <para>试用期考核最终状态</para>
        /// <para>必填：否</para>
        /// <para>示例值：completed</para>
        /// </summary>
        [JsonPropertyName("final_assessment_status")]
        public Enum? FinalAssessmentStatus { get; set; }

        /// <summary>
        /// <para>试用期考核最终结果</para>
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
        /// <para>试用期考核最终等级</para>
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
        /// <para>示例值：暂无示例</para>
        /// </summary>
        [JsonPropertyName("final_assessment_detail")]
        public string? FinalAssessmentDetail { get; set; }
    }
}
