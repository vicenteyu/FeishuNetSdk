// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-06-24
// ************************************************************************
// <copyright file="PatchTaskV2TasklistsByTasklistGuidActivitySubscriptionsByActivitySubscriptionGuidBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>更新动态订阅 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Task;
/// <summary>
/// 更新动态订阅 请求体
/// <para>提供一个清单的GUID和一个动态订阅的GUID，对其进行更新。更新时，将`update_fields`字段中填写所有要修改的字段名，同时在`activity_subscription`字段中填写要修改的字段的新值即可。</para>
/// <para>`update_fields`支持更新的字段包括：</para>
/// <para>* name：订阅的名称</para>
/// <para>* subscribers: 订阅者列表。如更新，会将旧的订阅者列表完全替换为新的订阅者列表。支持最大50个订阅者。并且订阅者必须是chat类型。</para>
/// <para>* include_keys ：订阅需要发送通知的key。如更新，会将旧的列表完全替换为新的include_keys列表。只能设置支持的event key (见字段描述）。</para>
/// <para>* disabled：修改订阅的开启/禁用状态。</para>
/// <para>接口ID：7288897051646967810</para>
/// <para>文档地址：https://open.feishu.cn/document/task-v2/tasklist-activity_subscription/patch</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2ftask-v2%2ftasklist-activity_subscription%2fpatch</para>
/// </summary>
public record PatchTaskV2TasklistsByTasklistGuidActivitySubscriptionsByActivitySubscriptionGuidBodyDto
{
    /// <summary>
    /// <para>要更新的订阅数据</para>
    /// <para>必填：是</para>
    /// </summary>
    [JsonPropertyName("activity_subscription")]
    public TasklistActivitySubscription ActivitySubscription { get; set; } = new();

    /// <summary>
    /// <para>要更新的订阅数据</para>
    /// </summary>
    public record TasklistActivitySubscription
    {
        /// <summary>
        /// <para>订阅名称，如更新，不能为空，最大支持50个字符。</para>
        /// <para>必填：否</para>
        /// <para>示例值：Roadmap订阅</para>
        /// </summary>
        [JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// <para>订阅者列表。如更新，最大支持50个订阅者。</para>
        /// <para>必填：否</para>
        /// <para>最大长度：50</para>
        /// </summary>
        [JsonPropertyName("subscribers")]
        public Member[]? Subscribers { get; set; }

        /// <summary>
        /// <para>订阅者列表。如更新，最大支持50个订阅者。</para>
        /// </summary>
        public record Member
        {
            /// <summary>
            /// <para>表示member的id</para>
            /// <para>必填：否</para>
            /// <para>示例值：oc_2cefb2f014f8d0c6c2d2eb7bafb0e54f</para>
            /// <para>最大长度：100</para>
            /// </summary>
            [JsonPropertyName("id")]
            public string? Id { get; set; }

            /// <summary>
            /// <para>成员的类型。目前只支持群组。</para>
            /// <para>必填：否</para>
            /// <para>示例值：chat</para>
            /// <para>默认值：user</para>
            /// </summary>
            [JsonPropertyName("type")]
            public string? Type { get; set; }
        }

        /// <summary>
        /// <para>要订阅的清单动态event key列表。每个event key用一个数字表示。目前支持下列event key：</para>
        /// <para>- 100: 任务添加入清单</para>
        /// <para>- 101: 任务从清单被移除</para>
        /// <para>- 103: 任务被完成</para>
        /// <para>- 104: 任务恢复为未完成</para>
        /// <para>- 109: 任务添加了负责人</para>
        /// <para>- 110: 任务更新了负责人</para>
        /// <para>- 111: 任务移除了负责人</para>
        /// <para>- 119: 任务添加了附件</para>
        /// <para>- 121: 任务中添加了新评论</para>
        /// <para>- 122: 任务中对评论进行回复</para>
        /// <para>- 129: 任务设置了新的开始时间</para>
        /// <para>- 130: 任务设置了新的截止时间</para>
        /// <para>- 131: 任务同时设置了新的开始/截止时间</para>
        /// <para>- 132: 任务同时移除了开始/截止时间</para>
        /// <para>该字段可以设置为空数组（即不对任何event进行通知）；输入的`include_keys`的元素不能重复。</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("include_keys")]
        public int[]? IncludeKeys { get; set; }

        /// <summary>
        /// <para>该订阅是否为停用</para>
        /// <para>必填：否</para>
        /// <para>示例值：false</para>
        /// </summary>
        [JsonPropertyName("disabled")]
        public bool? Disabled { get; set; }
    }

    /// <summary>
    /// <para>要更新的字段列表。</para>
    /// <para>必填：是</para>
    /// <para>最大长度：20</para>
    /// <para>最小长度：1</para>
    /// <para>可选值：<list type="bullet">
    /// <item>name：订阅名称</item>
    /// <item>include_keys：订阅的事件类型列表</item>
    /// <item>subscribers：订阅成员列表</item>
    /// <item>disabled：是否禁用该订阅</item>
    /// </list></para>
    /// </summary>
    [JsonPropertyName("update_fields")]
    public string[] UpdateFields { get; set; } = [];
}
