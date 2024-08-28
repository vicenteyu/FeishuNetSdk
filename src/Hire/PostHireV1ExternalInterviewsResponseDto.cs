// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-07-09
// ************************************************************************
// <copyright file="PostHireV1ExternalInterviewsResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>创建外部面试 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Hire;
/// <summary>
/// 创建外部面试 响应体
/// <para>创建外部面试，可用于导入来自其他系统的面试信息。</para>
/// <para>接口ID：6992822583076339715</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/hire-v1/get-candidates/import-external-system-information/create-3</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuMzM1YjLzMTN24yMzUjN%2fhire-v1%2fexternal_interview%2fcreate</para>
/// </summary>
public record PostHireV1ExternalInterviewsResponseDto
{
    /// <summary>
    /// <para>外部面试信息</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("external_interview")]
    public PostHireV1ExternalInterviewsResponseDtoExternalInterview? ExternalInterview { get; set; }

    /// <summary>
    /// <para>外部面试信息</para>
    /// </summary>
    public record PostHireV1ExternalInterviewsResponseDtoExternalInterview
    {
        /// <summary>
        /// <para>外部投递 ID</para>
        /// <para>必填：是</para>
        /// <para>示例值：6960663240925956437</para>
        /// </summary>
        [JsonPropertyName("external_application_id")]
        public string ExternalApplicationId { get; set; } = string.Empty;

        /// <summary>
        /// <para>外部面试 ID</para>
        /// <para>必填：否</para>
        /// <para>示例值：6960663240925956436</para>
        /// </summary>
        [JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// <para>参与状态</para>
        /// <para>必填：否</para>
        /// <para>示例值：1</para>
        /// <para>可选值：<list type="bullet">
        /// <item>1：未参与</item>
        /// <item>2：参与</item>
        /// <item>3：爽约</item>
        /// </list></para>
        /// </summary>
        [JsonPropertyName("participate_status")]
        public int? ParticipateStatus { get; set; }

        /// <summary>
        /// <para>开始时间，毫秒时间戳（字段类型为：int64）</para>
        /// <para>必填：否</para>
        /// <para>示例值：1618500278638</para>
        /// </summary>
        [JsonPropertyName("begin_time")]
        public long? BeginTime { get; set; }

        /// <summary>
        /// <para>结束时间，毫秒时间戳（字段类型为：int64）</para>
        /// <para>必填：否</para>
        /// <para>示例值：1618500278639</para>
        /// </summary>
        [JsonPropertyName("end_time")]
        public long? EndTime { get; set; }

        /// <summary>
        /// <para>面试评价列表</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("interview_assessments")]
        public ExternalInterviewAssessment[]? InterviewAssessments { get; set; }

        /// <summary>
        /// <para>面试评价列表</para>
        /// </summary>
        public record ExternalInterviewAssessment
        {
            /// <summary>
            /// <para>外部面评 ID</para>
            /// <para>必填：否</para>
            /// <para>示例值：6989181065243969836</para>
            /// </summary>
            [JsonPropertyName("id")]
            public string? Id { get; set; }

            /// <summary>
            /// <para>面试官姓名</para>
            /// <para>必填：否</para>
            /// <para>示例值：张三</para>
            /// </summary>
            [JsonPropertyName("username")]
            public string? Username { get; set; }

            /// <summary>
            /// <para>面试结果</para>
            /// <para>必填：否</para>
            /// <para>示例值：1</para>
            /// <para>可选值：<list type="bullet">
            /// <item>1：不通过</item>
            /// <item>2：通过</item>
            /// <item>3：待定</item>
            /// </list></para>
            /// </summary>
            [JsonPropertyName("conclusion")]
            public int? Conclusion { get; set; }

            /// <summary>
            /// <para>评价维度列表</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("assessment_dimension_list")]
            public ExternalInterviewAssessmentDimension[]? AssessmentDimensionLists { get; set; }

            /// <summary>
            /// <para>评价维度列表</para>
            /// </summary>
            public record ExternalInterviewAssessmentDimension
            {
                /// <summary>
                /// <para>打分题分数（当维度类型为「打分题」时使用）</para>
                /// <para>必填：否</para>
                /// <para>示例值：99</para>
                /// </summary>
                [JsonPropertyName("score")]
                public int? Score { get; set; }

                /// <summary>
                /// <para>单选选项（当维度类型为「单选题」时使用）</para>
                /// <para>必填：否</para>
                /// <para>示例值：选项1</para>
                /// </summary>
                [JsonPropertyName("option")]
                public string? Option { get; set; }

                /// <summary>
                /// <para>多选选项（当维度类型为「多选题」时使用）</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonPropertyName("options")]
                public string[]? Options { get; set; }

                /// <summary>
                /// <para>描述内容（当维度类型为「描述题」时使用）</para>
                /// <para>必填：否</para>
                /// <para>示例值：第一次面试记录</para>
                /// </summary>
                [JsonPropertyName("content")]
                public string? Content { get; set; }

                /// <summary>
                /// <para>维度类型</para>
                /// <para>必填：否</para>
                /// <para>示例值：1</para>
                /// <para>可选值：<list type="bullet">
                /// <item>1：打分题</item>
                /// <item>2：单选题</item>
                /// <item>3：描述题</item>
                /// <item>4：多选题</item>
                /// </list></para>
                /// </summary>
                [JsonPropertyName("assessment_type")]
                public int? AssessmentType { get; set; }

                /// <summary>
                /// <para>维度标题</para>
                /// <para>必填：否</para>
                /// <para>示例值：性格测试</para>
                /// </summary>
                [JsonPropertyName("title")]
                public string? Title { get; set; }

                /// <summary>
                /// <para>维度描述</para>
                /// <para>必填：否</para>
                /// <para>示例值：这是性格测试相关的</para>
                /// </summary>
                [JsonPropertyName("description")]
                public string? Description { get; set; }
            }

            /// <summary>
            /// <para>综合评价</para>
            /// <para>必填：否</para>
            /// <para>示例值：内容输出</para>
            /// </summary>
            [JsonPropertyName("content")]
            public string? Content { get; set; }
        }
    }
}
