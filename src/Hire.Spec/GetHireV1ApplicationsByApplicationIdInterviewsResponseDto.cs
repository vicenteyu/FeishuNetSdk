using Newtonsoft.Json;
namespace FeishuNetSdk.Hire.Spec;
/// <summary>
/// 获取面试记录列表 响应体
/// <para>根据投递 ID 获取面试记录列表{尝试一下}(url=/api/tools/api_explore/api_explore_config?project=hire&version=v1&resource=application.interview&method=list)</para>
/// <para>接口ID：6964286393804931100</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/historic-version/hire_internal/application-interview/list</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuMzM1YjLzMTN24yMzUjN%2fhire-v1%2fapplication-interview%2flist</para>
/// </summary>
public record GetHireV1ApplicationsByApplicationIdInterviewsResponseDto
{
    /// <summary>
    /// <para>分页标志</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonProperty("page_token")]
    public string? PageToken { get; set; }

    /// <summary>
    /// <para>是否有更多</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonProperty("has_more")]
    public bool? HasMore { get; set; }

    /// <summary>
    /// <para>面试列表</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonProperty("items")]
    public Interview[]? Items { get; set; }

    public record Interview
    {
        /// <summary>
        /// <para>面试id</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonProperty("id")]
        public string? Id { get; set; }

        /// <summary>
        /// <para>面试开始时间（ms）</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonProperty("begin_time")]
        public int? BeginTime { get; set; }

        /// <summary>
        /// <para>面试结束时间（ms）</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonProperty("end_time")]
        public int? EndTime { get; set; }

        /// <summary>
        /// <para>面试轮次（从0开始计数）</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonProperty("round")]
        public int? Round { get; set; }

        /// <summary>
        /// <para>面试关联的投递阶段</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonProperty("stage_id")]
        public string? StageId { get; set; }

        /// <summary>
        /// <para>面试官记录列表</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonProperty("interview_record_list")]
        public InterviewRecord[]? InterviewRecordList { get; set; }

        public record InterviewRecord
        {
            /// <summary>
            /// <para>面试记录 ID</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonProperty("id")]
            public string? Id { get; set; }

            /// <summary>
            /// <para>面试官用户 ID</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonProperty("user_id")]
            public string? UserId { get; set; }

            /// <summary>
            /// <para>系统预设「记录」题目内容</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonProperty("content")]
            public string? Content { get; set; }

            /// <summary>
            /// <para>建议定级下限的职级 ID</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonProperty("min_job_level_id")]
            public string? MinJobLevelId { get; set; }

            /// <summary>
            /// <para>建议定级上限的职级 ID</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonProperty("max_job_level_id")]
            public string? MaxJobLevelId { get; set; }

            /// <summary>
            /// <para>提交状态</para>
            /// <para>**可选值有**：</para>
            /// <para>- `1`：已提交</para>
            /// <para>- `2`：未提交</para>
            /// <para>必填：否</para>
            /// <para>可选值：<list type="bullet">
            /// <item>- `1`：已提交</item>
            /// </list></para>
            /// </summary>
            [JsonProperty("commit_status")]
            public int? CommitStatus { get; set; }

            /// <summary>
            /// <para>面试结论</para>
            /// <para>**可选值有**：</para>
            /// <para>- `1`：通过</para>
            /// <para>- `2`：未通过</para>
            /// <para>- `3`：未开始</para>
            /// <para>- `4`：未提交</para>
            /// <para>- `5`：未到场</para>
            /// <para>必填：否</para>
            /// <para>可选值：<list type="bullet">
            /// <item>- `1`：通过</item>
            /// </list></para>
            /// </summary>
            [JsonProperty("conclusion")]
            public int? Conclusion { get; set; }

            /// <summary>
            /// <para>面试评分</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonProperty("interview_score")]
            public InterviewScoreSuffix? InterviewScore { get; set; }

            public record InterviewScoreSuffix
            {
                /// <summary>
                /// <para>面试评分 ID</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonProperty("id")]
                public string? Id { get; set; }

                /// <summary>
                /// <para>分数级别</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonProperty("level")]
                public int? Level { get; set; }

                /// <summary>
                /// <para>中文名称</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonProperty("zh_name")]
                public string? ZhName { get; set; }

                /// <summary>
                /// <para>中文描述</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonProperty("zh_description")]
                public string? ZhDescription { get; set; }

                /// <summary>
                /// <para>英文名称</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonProperty("en_name")]
                public string? EnName { get; set; }

                /// <summary>
                /// <para>英文描述</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonProperty("en_description")]
                public string? EnDescription { get; set; }
            }
        }
    }
}
