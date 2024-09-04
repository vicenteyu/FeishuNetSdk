// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-06-24
// ************************************************************************
// <copyright file="PostReportV1TasksQueryResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>查询任务 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Report;
/// <summary>
/// 查询任务 响应体
/// <para>查询任务。</para>
/// <para>接口ID：6969187588792369180</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/report-v1/task/query</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2freport%2freport-v1%2ftask%2fquery</para>
/// </summary>
public record PostReportV1TasksQueryResponseDto
{
    /// <summary>
    /// <para>任务列表</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("items")]
    public Task[]? Items { get; set; }

    /// <summary>
    /// <para>任务列表</para>
    /// </summary>
    public record Task
    {
        /// <summary>
        /// <para>汇报任务ID</para>
        /// <para>必填：否</para>
        /// <para>示例值：6968793659214921747</para>
        /// </summary>
        [JsonPropertyName("task_id")]
        public string? TaskId { get; set; }

        /// <summary>
        /// <para>规则名称</para>
        /// <para>必填：否</para>
        /// <para>示例值：工作月报</para>
        /// </summary>
        [JsonPropertyName("rule_name")]
        public string? RuleName { get; set; }

        /// <summary>
        /// <para>汇报用户ID</para>
        /// <para>必填：否</para>
        /// <para>示例值：ou_c04cebc780341ab22bd311ba6902ffeb</para>
        /// </summary>
        [JsonPropertyName("from_user_id")]
        public string? FromUserId { get; set; }

        /// <summary>
        /// <para>汇报用户名称</para>
        /// <para>必填：否</para>
        /// <para>示例值：张三</para>
        /// </summary>
        [JsonPropertyName("from_user_name")]
        public string? FromUserName { get; set; }

        /// <summary>
        /// <para>汇报用户部门名称</para>
        /// <para>必填：否</para>
        /// <para>示例值：部门A</para>
        /// </summary>
        [JsonPropertyName("department_name")]
        public string? DepartmentName { get; set; }

        /// <summary>
        /// <para>提交时间时间戳</para>
        /// <para>必填：否</para>
        /// <para>示例值：1622548713</para>
        /// </summary>
        [JsonPropertyName("commit_time")]
        public int? CommitTime { get; set; }

        /// <summary>
        /// <para>汇报表单内容</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("form_contents")]
        public FormContent[]? FormContents { get; set; }

        /// <summary>
        /// <para>汇报表单内容</para>
        /// </summary>
        public record FormContent
        {
            /// <summary>
            /// <para>表单字段ID</para>
            /// <para>必填：否</para>
            /// <para>示例值：6968626905868156948</para>
            /// </summary>
            [JsonPropertyName("field_id")]
            public string? FieldId { get; set; }

            /// <summary>
            /// <para>表单字段名称</para>
            /// <para>必填：否</para>
            /// <para>示例值：表单测试</para>
            /// </summary>
            [JsonPropertyName("field_name")]
            public string? FieldName { get; set; }

            /// <summary>
            /// <para>表单字段值</para>
            /// <para>**注意**：附件或图片该值为空，只返回 ID 与名称</para>
            /// <para>必填：否</para>
            /// <para>示例值：测试数据</para>
            /// </summary>
            [JsonPropertyName("field_value")]
            public string? FieldValue { get; set; }
        }
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
    /// <para>示例值：6943911827436174445</para>
    /// </summary>
    [JsonPropertyName("page_token")]
    public string? PageToken { get; set; }
}
