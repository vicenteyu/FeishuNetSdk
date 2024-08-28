// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-06-24
// ************************************************************************
// <copyright file="GetHireV1QuestionnairesResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>获取面试满意度问卷列表 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Hire;
/// <summary>
/// 获取面试满意度问卷列表 响应体
/// <para>批量获取面试满意度问卷信息，包含问卷完成情况、问卷题目及问卷题目作答内容等信息。</para>
/// <para>接口ID：7039624673445920771</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/hire-v1/candidate-management/delivery-process-management/interview/list-2</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuMzM1YjLzMTN24yMzUjN%2fhire-v1%2fquestionnaire%2flist</para>
/// </summary>
public record GetHireV1QuestionnairesResponseDto
{
    /// <summary>
    /// <para>是否还有更多项</para>
    /// <para>必填：否</para>
    /// <para>示例值：true</para>
    /// </summary>
    [JsonPropertyName("has_more")]
    public bool? HasMore { get; set; }

    /// <summary>
    /// <para>分页标记，当 has_more 为 true 时，会同时返回新的 page_token，否则不返回 page_token</para>
    /// <para>必填：否</para>
    /// <para>示例值：eyJvZmZzZXQiOjEsInRpbWVzdGFtcCI6MTcyMzU1OTE4OTg1NCwiaWQiOm51bGx9</para>
    /// </summary>
    [JsonPropertyName("page_token")]
    public string? PageToken { get; set; }

    /// <summary>
    /// <para>满意度问卷列表</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("items")]
    public Questionnaire[]? Items { get; set; }

    /// <summary>
    /// <para>满意度问卷列表</para>
    /// </summary>
    public record Questionnaire
    {
        /// <summary>
        /// <para>满意度问卷 ID</para>
        /// <para>必填：否</para>
        /// <para>示例值：7037986982531778860</para>
        /// </summary>
        [JsonPropertyName("questionnaire_id")]
        public string? QuestionnaireId { get; set; }

        /// <summary>
        /// <para>投递 ID，详情可查看：[获取投递信息](https://open.feishu.cn/document/ukTMukTMukTM/uMzM1YjLzMTN24yMzUjN/hire-v1/application/get)</para>
        /// <para>必填：否</para>
        /// <para>示例值：6985833807195212076</para>
        /// </summary>
        [JsonPropertyName("application_id")]
        public string? ApplicationId { get; set; }

        /// <summary>
        /// <para>面试 ID，详情可查看：[获取面试信息](https://open.feishu.cn/document/ukTMukTMukTM/uMzM1YjLzMTN24yMzUjN/hire-v1/interview/list)</para>
        /// <para>必填：否</para>
        /// <para>示例值：7038435261598763308</para>
        /// </summary>
        [JsonPropertyName("interview_id")]
        public string? InterviewId { get; set; }

        /// <summary>
        /// <para>满意度问卷版本</para>
        /// <para>必填：否</para>
        /// <para>示例值：59</para>
        /// </summary>
        [JsonPropertyName("version")]
        public int? Version { get; set; }

        /// <summary>
        /// <para>题目列表</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("questions")]
        public Question[]? Questions { get; set; }

        /// <summary>
        /// <para>题目列表</para>
        /// </summary>
        public record Question
        {
            /// <summary>
            /// <para>题目 ID</para>
            /// <para>必填：否</para>
            /// <para>示例值：6950930570311829804</para>
            /// </summary>
            [JsonPropertyName("question_id")]
            public string? QuestionId { get; set; }

            /// <summary>
            /// <para>题目中文名称</para>
            /// <para>必填：否</para>
            /// <para>示例值：你的总体评价如何？</para>
            /// </summary>
            [JsonPropertyName("question_name")]
            public string? QuestionName { get; set; }

            /// <summary>
            /// <para>题目英文名称</para>
            /// <para>必填：否</para>
            /// <para>示例值：How would you describe your overall experience?</para>
            /// </summary>
            [JsonPropertyName("question_en_name")]
            public string? QuestionEnName { get; set; }

            /// <summary>
            /// <para>题目中文描述</para>
            /// <para>必填：否</para>
            /// <para>示例值：测试描述内容</para>
            /// </summary>
            [JsonPropertyName("question_desc")]
            public string? QuestionDesc { get; set; }

            /// <summary>
            /// <para>题目英文描述</para>
            /// <para>必填：否</para>
            /// <para>示例值：Test Text</para>
            /// </summary>
            [JsonPropertyName("question_en_desc")]
            public string? QuestionEnDesc { get; set; }

            /// <summary>
            /// <para>题目类型</para>
            /// <para>必填：否</para>
            /// <para>示例值：4</para>
            /// <para>可选值：<list type="bullet">
            /// <item>1：单选题</item>
            /// <item>2：多选题</item>
            /// <item>3：描述题</item>
            /// <item>4：评分题</item>
            /// </list></para>
            /// </summary>
            [JsonPropertyName("question_type")]
            public int? QuestionType { get; set; }

            /// <summary>
            /// <para>题目是否必填</para>
            /// <para>必填：否</para>
            /// <para>示例值：true</para>
            /// </summary>
            [JsonPropertyName("is_required")]
            public bool? IsRequired { get; set; }

            /// <summary>
            /// <para>选项题回答列表</para>
            /// <para>**说明**：</para>
            /// <para>当题目类型为 `单选题` 或者 `多选题` 时该字段有值</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("select_option_result_list")]
            public SelectOptionResult[]? SelectOptionResultLists { get; set; }

            /// <summary>
            /// <para>选项题回答列表</para>
            /// <para>**说明**：</para>
            /// <para>当题目类型为 `单选题` 或者 `多选题` 时该字段有值</para>
            /// </summary>
            public record SelectOptionResult
            {
                /// <summary>
                /// <para>选项 ID</para>
                /// <para>必填：否</para>
                /// <para>示例值：6950930570311993644</para>
                /// </summary>
                [JsonPropertyName("option_id")]
                public string? OptionId { get; set; }

                /// <summary>
                /// <para>选项中文名称</para>
                /// <para>必填：否</para>
                /// <para>示例值：选项一</para>
                /// </summary>
                [JsonPropertyName("option_name")]
                public string? OptionName { get; set; }

                /// <summary>
                /// <para>选项英文名称</para>
                /// <para>必填：否</para>
                /// <para>示例值：Option 1</para>
                /// </summary>
                [JsonPropertyName("option_en_name")]
                public string? OptionEnName { get; set; }

                /// <summary>
                /// <para>选项中文描述</para>
                /// <para>必填：否</para>
                /// <para>示例值：测试选项描述</para>
                /// </summary>
                [JsonPropertyName("option_desc")]
                public string? OptionDesc { get; set; }

                /// <summary>
                /// <para>选项英文描述</para>
                /// <para>必填：否</para>
                /// <para>示例值：Test Option Desc</para>
                /// </summary>
                [JsonPropertyName("option_en_desc")]
                public string? OptionEnDesc { get; set; }

                /// <summary>
                /// <para>是否选中</para>
                /// <para>必填：否</para>
                /// <para>示例值：true</para>
                /// </summary>
                [JsonPropertyName("is_selected")]
                public bool? IsSelected { get; set; }
            }

            /// <summary>
            /// <para>评分题回答</para>
            /// <para>**说明**：</para>
            /// <para>当题目类型为 `评分题` 时该字段有值</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("five_start_scoring_result")]
            public QuestionFiveStartScoringResult? FiveStartScoringResult { get; set; }

            /// <summary>
            /// <para>评分题回答</para>
            /// <para>**说明**：</para>
            /// <para>当题目类型为 `评分题` 时该字段有值</para>
            /// </summary>
            public record QuestionFiveStartScoringResult
            {
                /// <summary>
                /// <para>最高分中文描述</para>
                /// <para>必填：否</para>
                /// <para>示例值：非常好</para>
                /// </summary>
                [JsonPropertyName("highest_score_desc")]
                public string? HighestScoreDesc { get; set; }

                /// <summary>
                /// <para>最高分英文描述</para>
                /// <para>必填：否</para>
                /// <para>示例值：Very Good</para>
                /// </summary>
                [JsonPropertyName("highest_score_en_desc")]
                public string? HighestScoreEnDesc { get; set; }

                /// <summary>
                /// <para>最低分中文描述</para>
                /// <para>必填：否</para>
                /// <para>示例值：非常差</para>
                /// </summary>
                [JsonPropertyName("lowest_score_desc")]
                public string? LowestScoreDesc { get; set; }

                /// <summary>
                /// <para>最低分英文描述</para>
                /// <para>必填：否</para>
                /// <para>示例值：Very Bad</para>
                /// </summary>
                [JsonPropertyName("lowest_score_en_desc")]
                public string? LowestScoreEnDesc { get; set; }

                /// <summary>
                /// <para>评分分数（整数）</para>
                /// <para>必填：否</para>
                /// <para>示例值：4</para>
                /// </summary>
                [JsonPropertyName("score_result")]
                public int? ScoreResult { get; set; }
            }

            /// <summary>
            /// <para>描述题回答</para>
            /// <para>**说明**：</para>
            /// <para>当题目类型为 `描述题` 时该字段有值</para>
            /// <para>必填：否</para>
            /// <para>示例值：测试描述内容</para>
            /// </summary>
            [JsonPropertyName("description_result")]
            public string? DescriptionResult { get; set; }
        }

        /// <summary>
        /// <para>是否完成作答</para>
        /// <para>必填：否</para>
        /// <para>示例值：true</para>
        /// </summary>
        [JsonPropertyName("has_answers")]
        public bool? HasAnswers { get; set; }

        /// <summary>
        /// <para>满意度问卷更新时间，毫秒时间戳</para>
        /// <para>必填：否</para>
        /// <para>示例值：1644412504000</para>
        /// </summary>
        [JsonPropertyName("update_time")]
        public string? UpdateTime { get; set; }
    }
}
