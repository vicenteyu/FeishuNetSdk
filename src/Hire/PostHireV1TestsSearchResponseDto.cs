// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-07-22
//
// Last Modified By : yxr
// Last Modified On : 2024-07-22
// ************************************************************************
// <copyright file="PostHireV1TestsSearchResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>获取笔试列表 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Hire;
/// <summary>
/// 获取笔试列表 响应体
/// <para>批量获取人才在投递流程中的笔试信息。如作答状态、笔试得分等。</para>
/// <para>接口ID：7127207246887796740</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/hire-v1/candidate-management/delivery-process-management/exam/search</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuMzM1YjLzMTN24yMzUjN%2fhire-v1%2ftest%2fsearch</para>
/// </summary>
public record PostHireV1TestsSearchResponseDto
{
    /// <summary>
    /// <para>笔试列表</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("items")]
    public Test[]? Items { get; set; }

    /// <summary>
    /// <para>笔试列表</para>
    /// </summary>
    public record Test
    {
        /// <summary>
        /// <para>笔试 ID</para>
        /// <para>必填：否</para>
        /// <para>示例值：6963784391454918956</para>
        /// </summary>
        [JsonPropertyName("test_id")]
        public string? TestId { get; set; }

        /// <summary>
        /// <para>投递 ID，详情请参考[获取投递信息](https://open.feishu.cn/document/ukTMukTMukTM/uMzM1YjLzMTN24yMzUjN/hire-v1/application/get)</para>
        /// <para>必填：否</para>
        /// <para>示例值：6920544531948800269</para>
        /// </summary>
        [JsonPropertyName("application_id")]
        public string? ApplicationId { get; set; }

        /// <summary>
        /// <para>试卷 ID</para>
        /// <para>必填：否</para>
        /// <para>示例值：6963549885526346028</para>
        /// </summary>
        [JsonPropertyName("test_paper_id")]
        public string? TestPaperId { get; set; }

        /// <summary>
        /// <para>试卷名称</para>
        /// <para>必填：否</para>
        /// <para>示例值：数据结构测验</para>
        /// </summary>
        [JsonPropertyName("test_paper_name")]
        public string? TestPaperName { get; set; }

        /// <summary>
        /// <para>试卷来源 ID</para>
        /// <para>必填：否</para>
        /// <para>示例值：5</para>
        /// </summary>
        [JsonPropertyName("test_paper_source_id")]
        public string? TestPaperSourceId { get; set; }

        /// <summary>
        /// <para>试卷来源名称</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("test_paper_source_name")]
        public I18n? TestPaperSourceName { get; set; }

        /// <summary>
        /// <para>试卷来源名称</para>
        /// </summary>
        public record I18n
        {
            /// <summary>
            /// <para>试卷来源中文名称</para>
            /// <para>必填：否</para>
            /// <para>示例值：高考全国卷（一）</para>
            /// </summary>
            [JsonPropertyName("zh_cn")]
            public string? ZhCn { get; set; }

            /// <summary>
            /// <para>试卷来源英文名称</para>
            /// <para>必填：否</para>
            /// <para>示例值：National Exam 1</para>
            /// </summary>
            [JsonPropertyName("en_us")]
            public string? EnUs { get; set; }
        }

        /// <summary>
        /// <para>笔试答复状态</para>
        /// <para>必填：否</para>
        /// <para>示例值：1</para>
        /// <para>可选值：<list type="bullet">
        /// <item>1：已接受</item>
        /// <item>2：已拒绝</item>
        /// <item>3：未反馈</item>
        /// </list></para>
        /// </summary>
        [JsonPropertyName("reply_status")]
        public int? ReplyStatus { get; set; }

        /// <summary>
        /// <para>笔试状态</para>
        /// <para>必填：否</para>
        /// <para>示例值：1</para>
        /// <para>可选值：<list type="bullet">
        /// <item>1：未安排</item>
        /// <item>2：未作答</item>
        /// <item>3：已作答</item>
        /// <item>4：待阅卷</item>
        /// <item>5：通过</item>
        /// <item>6：不通过</item>
        /// <item>7：安排失败</item>
        /// </list></para>
        /// </summary>
        [JsonPropertyName("test_status")]
        public int? TestStatus { get; set; }

        /// <summary>
        /// <para>笔试时间（单位：毫秒）</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("test_schedule")]
        public TestTestSchedule? TestSchedule { get; set; }

        /// <summary>
        /// <para>笔试时间（单位：毫秒）</para>
        /// </summary>
        public record TestTestSchedule
        {
            /// <summary>
            /// <para>开始时间（单位：毫秒）</para>
            /// <para>必填：否</para>
            /// <para>示例值：1621390695000</para>
            /// </summary>
            [JsonPropertyName("start_time")]
            public string? StartTime { get; set; }

            /// <summary>
            /// <para>结束时间（单位：毫秒）</para>
            /// <para>必填：否</para>
            /// <para>示例值：1632839400000</para>
            /// </summary>
            [JsonPropertyName("end_time")]
            public string? EndTime { get; set; }
        }

        /// <summary>
        /// <para>笔试作答完成时间（单位：毫秒）</para>
        /// <para>必填：否</para>
        /// <para>示例值：1608725989000</para>
        /// </summary>
        [JsonPropertyName("test_complete_time")]
        public string? TestCompleteTime { get; set; }

        /// <summary>
        /// <para>笔试报告链接列表</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("report_url_list")]
        public string[]? ReportUrlList { get; set; }

        /// <summary>
        /// <para>笔试详细成绩</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("result_detail_list")]
        public TestResultDetail[]? ResultDetailLists { get; set; }

        /// <summary>
        /// <para>笔试详细成绩</para>
        /// </summary>
        public record TestResultDetail
        {
            /// <summary>
            /// <para>笔试科目</para>
            /// <para>必填：否</para>
            /// <para>示例值：定制化报告测验</para>
            /// </summary>
            [JsonPropertyName("subject")]
            public string? Subject { get; set; }

            /// <summary>
            /// <para>笔试科目结论</para>
            /// <para>必填：否</para>
            /// <para>示例值：合格</para>
            /// </summary>
            [JsonPropertyName("result")]
            public string? Result { get; set; }
        }

        /// <summary>
        /// <para>笔试结果上传时间（单位：毫秒）</para>
        /// <para>**注意**：</para>
        /// <para>只有手动录入的笔试成绩才有</para>
        /// <para>必填：否</para>
        /// <para>示例值：1608725989000</para>
        /// </summary>
        [JsonPropertyName("result_upload_time")]
        public string? ResultUploadTime { get; set; }

        /// <summary>
        /// <para>阅卷得分</para>
        /// <para>必填：否</para>
        /// <para>示例值：60</para>
        /// </summary>
        [JsonPropertyName("score")]
        public string? Score { get; set; }

        /// <summary>
        /// <para>阅卷结果最新提交时间（单位：毫秒）</para>
        /// <para>必填：否</para>
        /// <para>示例值：1608725989000</para>
        /// </summary>
        [JsonPropertyName("score_submit_time")]
        public string? ScoreSubmitTime { get; set; }

        /// <summary>
        /// <para>阅卷人用户 ID，与入参 `user_id_type` 类型一致</para>
        /// <para>必填：否</para>
        /// <para>示例值：ou_266ed047ed37f24554e5a0afdbb15556</para>
        /// </summary>
        [JsonPropertyName("reviewer")]
        public string? Reviewer { get; set; }

        /// <summary>
        /// <para>笔试创建时间（单位：毫秒）</para>
        /// <para>必填：否</para>
        /// <para>示例值：1608725989000</para>
        /// </summary>
        [JsonPropertyName("created_at")]
        public string? CreatedAt { get; set; }
    }

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
    /// <para>示例值：eyJvZmZzZXQiOjEwLCJ0aW1lc3RhbXAiOjE2Mjc1NTUyMjM2NzIsImlkIjpudWxsfQ==</para>
    /// </summary>
    [JsonPropertyName("page_token")]
    public string? PageToken { get; set; }
}
