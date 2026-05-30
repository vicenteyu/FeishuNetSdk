// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2026-05-29
// ************************************************************************
// <copyright file="GetTaskV2TasklistsByTasklistGuidActivitySubscriptionsResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>列取动态订阅 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Task;
/// <summary>
/// 列取动态订阅 响应体
/// <para>给定一个清单的GUID，获取其所有的订阅信息。结果按照订阅的创建时间排序。</para>
/// <para>接口ID：7288897051646951426</para>
/// <para>文档地址：https://open.feishu.cn/document/task-v2/tasklist-activity_subscription/list</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2ftask-v2%2ftasklist-activity_subscription%2flist</para>
/// </summary>
public record GetTaskV2TasklistsByTasklistGuidActivitySubscriptionsResponseDto
{
    /// <summary>
    /// <para>清单的动态订阅数据</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("items")]
    public TasklistActivitySubscription[]? Items { get; set; }

    /// <summary>
    /// <para>清单的动态订阅数据</para>
    /// </summary>
    public record TasklistActivitySubscription
    {
        /// <summary>
        /// <para>订阅guid</para>
        /// <para>必填：否</para>
        /// <para>示例值：d19e3a2a-edc0-4e4e-b7cc-950e162b53ae</para>
        /// </summary>
        [JsonPropertyName("guid")]
        public string? Guid { get; set; }

        /// <summary>
        /// <para>订阅名称</para>
        /// <para>必填：否</para>
        /// <para>示例值：Roadmap订阅</para>
        /// </summary>
        [JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// <para>订阅者</para>
        /// <para>必填：否</para>
        /// <para>最大长度：50</para>
        /// </summary>
        [JsonPropertyName("subscribers")]
        public Member[]? Subscribers { get; set; }

        /// <summary>
        /// <para>要订阅的清单动态类型</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("include_keys")]
        public int[]? IncludeKeys { get; set; }

        /// <summary>
        /// <para>该订阅是否停用</para>
        /// <para>必填：否</para>
        /// <para>示例值：false</para>
        /// </summary>
        [JsonPropertyName("disabled")]
        public bool? Disabled { get; set; }
    }
}
