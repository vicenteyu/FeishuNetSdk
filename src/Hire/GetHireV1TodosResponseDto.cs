// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-07-22
//
// Last Modified By : yxr
// Last Modified On : 2024-07-22
// ************************************************************************
// <copyright file="GetHireV1TodosResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>批量获取待办事项 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Hire;
/// <summary>
/// 批量获取待办事项 响应体
/// <para>批量获取当前用户的待办事项信息，包含评估待办事项、面试待办事项、笔试待办事项和 Offer 待办事项。</para>
/// <para>接口ID：7096463887449325596</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/hire-v1/candidate-management/recruitment-process-follow-up/list</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuMzM1YjLzMTN24yMzUjN%2fhire-v1%2ftodo%2flist</para>
/// </summary>
public record GetHireV1TodosResponseDto : IPageableResponse<GetHireV1TodosResponseDto.Todo>
{
    /// <summary>
    /// <para>待办事项列表</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("items")]
    public Todo[]? Items { get; set; }

    /// <summary>
    /// <para>待办事项列表</para>
    /// </summary>
    public record Todo
    {
        /// <summary>
        /// <para>简历评估待办事项，仅当待办类型为 `evaluation` 时返回</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("evaluation")]
        public TodoCommon? Evaluation { get; set; }

        /// <summary>
        /// <para>简历评估待办事项，仅当待办类型为 `evaluation` 时返回</para>
        /// </summary>
        public record TodoCommon
        {
            /// <summary>
            /// <para>人才 ID，详情可查看：[获取人才信息](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/hire-v2/talent/get)</para>
            /// <para>必填：否</para>
            /// <para>示例值：6891524011667228941</para>
            /// </summary>
            [JsonPropertyName("talent_id")]
            public string? TalentId { get; set; }

            /// <summary>
            /// <para>职位 ID，详情可查看：[获取职位信息](https://open.feishu.cn/document/ukTMukTMukTM/uMzM1YjLzMTN24yMzUjN/hire-v1/job/get)</para>
            /// <para>必填：否</para>
            /// <para>示例值：6891113155221522701</para>
            /// </summary>
            [JsonPropertyName("job_id")]
            public string? JobId { get; set; }

            /// <summary>
            /// <para>投递 ID，详情可查看：[获取投递信息](https://open.feishu.cn/document/ukTMukTMukTM/uMzM1YjLzMTN24yMzUjN/hire-v1/application/get)</para>
            /// <para>必填：否</para>
            /// <para>示例值：6945436033023625516</para>
            /// </summary>
            [JsonPropertyName("application_id")]
            public string? ApplicationId { get; set; }

            /// <summary>
            /// <para>评估 ID，详情可查看：[批量获取简历评估信息](https://open.feishu.cn/document/ukTMukTMukTM/uMzM1YjLzMTN24yMzUjN/hire-v1/evaluation/list)</para>
            /// <para>必填：否</para>
            /// <para>示例值：6914542162822695181</para>
            /// </summary>
            [JsonPropertyName("id")]
            public string? Id { get; set; }
        }

        /// <summary>
        /// <para>Offer 待办事项，仅当待办类型为 `offer` 时返回</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("offer")]
        public TodoCommon? Offer { get; set; }

        /// <summary>
        /// <para>笔试待办事项，仅当类型为 `exam` 时返回</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("exam")]
        public TodoCommon? Exam { get; set; }

        /// <summary>
        /// <para>面试待办事项，仅当类型为 `interview` 时返回</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("interview")]
        public TodoCommon? Interview { get; set; }
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
