// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-04-27
// ************************************************************************
// <copyright file="GetApprovalV4InstancesByInstanceIdCommentsResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>获取评论 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Approval;
/// <summary>
/// 获取评论 响应体
/// <para>根据审批实例 Code 获取某个审批实例下，全部评论与评论回复（不包含审批同意、拒绝、转交等附加的理由或意见）。</para>
/// <para>接口ID：7117964632137236483</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/approval-v4/instance-comment/list</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fapproval-v4%2finstance-comment%2flist</para>
/// </summary>
public record GetApprovalV4InstancesByInstanceIdCommentsResponseDto
{
    /// <summary>
    /// <para>评论数据列表</para>
    /// <para>必填：是</para>
    /// </summary>
    [JsonPropertyName("comments")]
    public Comment[] Comments { get; set; } = Array.Empty<Comment>();

    /// <summary>
    /// <para>评论数据列表</para>
    /// </summary>
    public record Comment
    {
        /// <summary>
        /// <para>评论 ID</para>
        /// <para>必填：是</para>
        /// <para>示例值：7081516627711524883</para>
        /// </summary>
        [JsonPropertyName("id")]
        public string Id { get; set; } = string.Empty;

        /// <summary>
        /// <para>评论内容</para>
        /// <para>必填：是</para>
        /// <para>示例值：{\"text\":\"x@某某来自小程序的评论，这是一条回复\"}</para>
        /// </summary>
        [JsonPropertyName("content")]
        public string Content { get; set; } = string.Empty;

        /// <summary>
        /// <para>评论创建时间，毫秒时间戳。</para>
        /// <para>必填：是</para>
        /// <para>示例值：1648801211000</para>
        /// </summary>
        [JsonPropertyName("create_time")]
        public string CreateTime { get; set; } = string.Empty;

        /// <summary>
        /// <para>评论更新时间，毫秒时间戳。</para>
        /// <para>必填：是</para>
        /// <para>示例值：1648801211000</para>
        /// </summary>
        [JsonPropertyName("update_time")]
        public string UpdateTime { get; set; } = string.Empty;

        /// <summary>
        /// <para>是否删除。可能值有：</para>
        /// <para>- 0：未删除</para>
        /// <para>- 1：已删除</para>
        /// <para>必填：是</para>
        /// <para>示例值：1</para>
        /// </summary>
        [JsonPropertyName("is_delete")]
        public int IsDelete { get; set; }

        /// <summary>
        /// <para>评论的回复数据</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("replies")]
        public CommentReply[]? Replies { get; set; }

        /// <summary>
        /// <para>评论的回复数据</para>
        /// </summary>
        public record CommentReply
        {
            /// <summary>
            /// <para>评论 ID</para>
            /// <para>必填：是</para>
            /// <para>示例值：7081516611634741268</para>
            /// </summary>
            [JsonPropertyName("id")]
            public string Id { get; set; } = string.Empty;

            /// <summary>
            /// <para>评论内容</para>
            /// <para>必填：是</para>
            /// <para>示例值：{\"text\":\"x@某某来自小程序的评论，这是一条回复\"}</para>
            /// </summary>
            [JsonPropertyName("content")]
            public string Content { get; set; } = string.Empty;

            /// <summary>
            /// <para>评论创建时间，毫秒时间戳。</para>
            /// <para>必填：否</para>
            /// <para>示例值：1648803677000</para>
            /// </summary>
            [JsonPropertyName("create_time")]
            public string? CreateTime { get; set; }

            /// <summary>
            /// <para>评论更新时间，毫秒时间戳。</para>
            /// <para>必填：否</para>
            /// <para>示例值：1648803677000</para>
            /// </summary>
            [JsonPropertyName("update_time")]
            public string? UpdateTime { get; set; }

            /// <summary>
            /// <para>是否删除。可能值有：</para>
            /// <para>- 0：未删除</para>
            /// <para>- 1：已删除</para>
            /// <para>必填：是</para>
            /// <para>示例值：0</para>
            /// </summary>
            [JsonPropertyName("is_delete")]
            public int IsDelete { get; set; }

            /// <summary>
            /// <para>评论中艾特人信息</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("at_info_list")]
            public CommentAtInfo[]? AtInfoLists { get; set; }

            /// <summary>
            /// <para>评论创建人</para>
            /// <para>必填：是</para>
            /// <para>示例值：893g4c45</para>
            /// </summary>
            [JsonPropertyName("commentator")]
            public string Commentator { get; set; } = string.Empty;

            /// <summary>
            /// <para>附加字段</para>
            /// <para>必填：否</para>
            /// <para>示例值：{\"a\":\"a\"}</para>
            /// </summary>
            [JsonPropertyName("extra")]
            public string? Extra { get; set; }
        }

        /// <summary>
        /// <para>评论中艾特人信息</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("at_info_list")]
        public CommentAtInfo[]? AtInfoLists { get; set; }

        /// <summary>
        /// <para>评论中艾特人信息</para>
        /// </summary>
        public record CommentAtInfo
        {
            /// <summary>
            /// <para>被艾特人的 ID，ID 类型与查询参数 user_id_type 取值一致。</para>
            /// <para>必填：是</para>
            /// <para>示例值：579fd9c4</para>
            /// </summary>
            [JsonPropertyName("user_id")]
            public string UserId { get; set; } = string.Empty;

            /// <summary>
            /// <para>被艾特人的姓名</para>
            /// <para>必填：是</para>
            /// <para>示例值：张某</para>
            /// </summary>
            [JsonPropertyName("name")]
            public string Name { get; set; } = string.Empty;

            /// <summary>
            /// <para>被艾特人在评论中的位置，从 0 开始。例如：</para>
            /// <para>- 取值为 0 时的效果：@username 示例文本</para>
            /// <para>- 取值为 2 时的效果：示例 @username 文本</para>
            /// <para>必填：是</para>
            /// <para>示例值：1</para>
            /// </summary>
            [JsonPropertyName("offset")]
            public string Offset { get; set; } = string.Empty;
        }

        /// <summary>
        /// <para>评论创建人</para>
        /// <para>必填：是</para>
        /// <para>示例值：893g4c45</para>
        /// </summary>
        [JsonPropertyName("commentator")]
        public string Commentator { get; set; } = string.Empty;

        /// <summary>
        /// <para>附加字段</para>
        /// <para>必填：否</para>
        /// <para>示例值：{\"a\":\"a\"}</para>
        /// </summary>
        [JsonPropertyName("extra")]
        public string? Extra { get; set; }
    }
}
