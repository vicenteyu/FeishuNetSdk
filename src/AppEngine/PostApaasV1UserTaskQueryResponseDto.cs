// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-12-21
//
// Last Modified By : yxr
// Last Modified On : 2024-12-21
// ************************************************************************
// <copyright file="PostApaasV1UserTaskQueryResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>查询人工任务 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.AppEngine;
/// <summary>
/// 查询人工任务 响应体
/// <para>查询人工任务列表</para>
/// <para>接口ID：7446337145820315652</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/apaas-v1/user_task/query</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fapaas-v1%2fuser_task%2fquery</para>
/// </summary>
public record PostApaasV1UserTaskQueryResponseDto
{
    /// <summary>
    /// <para>总任务条数</para>
    /// <para>必填：否</para>
    /// <para>示例值：10</para>
    /// </summary>
    [JsonPropertyName("count")]
    public string? Count { get; set; }

    /// <summary>
    /// <para>任务信息</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("tasks")]
    public UserTask[]? Tasks { get; set; }

    /// <summary>
    /// <para>任务信息</para>
    /// </summary>
    public record UserTask
    {
        /// <summary>
        /// <para>任务ID</para>
        /// <para>必填：否</para>
        /// <para>示例值：1234</para>
        /// </summary>
        [JsonPropertyName("task_id")]
        public string? TaskId { get; set; }

        /// <summary>
        /// <para>任务开始时间</para>
        /// <para>必填：否</para>
        /// <para>示例值：1234</para>
        /// </summary>
        [JsonPropertyName("task_start_time")]
        public string? TaskStartTime { get; set; }

        /// <summary>
        /// <para>流程实例</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("workflow_instance")]
        public UserTaskWfInstanceType? WorkflowInstance { get; set; }

        /// <summary>
        /// <para>流程实例</para>
        /// </summary>
        public record UserTaskWfInstanceType
        {
            /// <summary>
            /// <para>流程实例ID</para>
            /// <para>必填：否</para>
            /// <para>示例值：1234</para>
            /// </summary>
            [JsonPropertyName("id")]
            public string? Id { get; set; }

            /// <summary>
            /// <para>流程对应的任务名称</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("label")]
            public I18n[]? Labels { get; set; }

            /// <summary>
            /// <para>流程对应的任务名称</para>
            /// </summary>
            public record I18n
            {
                /// <summary>
                /// <para>多语Code</para>
                /// <para>必填：否</para>
                /// <para>示例值：2052</para>
                /// </summary>
                [JsonPropertyName("language_code")]
                public string? LanguageCode { get; set; }

                /// <summary>
                /// <para>多语对应的任务名称</para>
                /// <para>必填：否</para>
                /// <para>示例值：任务名称</para>
                /// </summary>
                [JsonPropertyName("text")]
                public string? Text { get; set; }
            }

            /// <summary>
            /// <para>流程状态</para>
            /// <para>必填：否</para>
            /// <para>示例值：in_process</para>
            /// <para>最大长度：100</para>
            /// <para>最小长度：0</para>
            /// </summary>
            [JsonPropertyName("status")]
            public string? Status { get; set; }
        }

        /// <summary>
        /// <para>发起人</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("initiator")]
        public User? Initiator { get; set; }

        /// <summary>
        /// <para>发起人</para>
        /// </summary>
        public record User
        {
            /// <summary>
            /// <para>用户KunlunID</para>
            /// <para>必填：否</para>
            /// <para>示例值：1234</para>
            /// </summary>
            [JsonPropertyName("user_id")]
            public string? UserId { get; set; }

            /// <summary>
            /// <para>用户名称</para>
            /// <para>必填：否</para>
            /// <para>示例值：发起人名称</para>
            /// </summary>
            [JsonPropertyName("name")]
            public string? Name { get; set; }
        }

        /// <summary>
        /// <para>摘要信息</para>
        /// <para>必填：否</para>
        /// <para>最大长度：20</para>
        /// <para>最小长度：0</para>
        /// </summary>
        [JsonPropertyName("summarys")]
        public UserTaskSummaryType[]? Summarys { get; set; }

        /// <summary>
        /// <para>摘要信息</para>
        /// </summary>
        public record UserTaskSummaryType
        {
            /// <summary>
            /// <para>摘要名称（多语）</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("file_key")]
            public I18n? FileKey { get; set; }

            /// <summary>
            /// <para>摘要名称（多语）</para>
            /// </summary>
            public record I18n
            {
                /// <summary>
                /// <para>多语Code</para>
                /// <para>必填：否</para>
                /// <para>示例值：2052</para>
                /// </summary>
                [JsonPropertyName("language_code")]
                public string? LanguageCode { get; set; }

                /// <summary>
                /// <para>多语Code对应的文本内容</para>
                /// <para>必填：否</para>
                /// <para>示例值：摘要名称</para>
                /// </summary>
                [JsonPropertyName("text")]
                public string? Text { get; set; }
            }

            /// <summary>
            /// <para>摘要值（多语）</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("file_value")]
            public I18n[]? FileValues { get; set; }
        }
    }
}
