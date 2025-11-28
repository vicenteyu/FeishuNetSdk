// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-06-24
// ************************************************************************
// <copyright file="PostTaskV2TasklistsByTasklistGuidActivitySubscriptionsBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>创建动态订阅 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Task;
/// <summary>
/// 创建动态订阅 请求体
/// <para>为一个清单创建一个订阅。每个订阅可以包含1个或多个订阅者（目前只支持普通群组）。订阅创建后，如清单发生相应的事件，则会向订阅里的订阅者发送通知消息。一个清单最多可以创建50个订阅。每个订阅最大支持50个订阅者。订阅者目前仅支持"chat"类型。</para>
/// <para>每个订阅可以通过设置`include_keys`可以针对哪些事件(event_key)做通知。如果`include_keys`为空，则不对任何事件进行通知。</para>
/// <para>如有需要，创建时也可以直接将`disabled`设为true，创建一个禁止发送订阅通知的订阅。</para>
/// <para>接口ID：7288897051647000578</para>
/// <para>文档地址：https://open.feishu.cn/document/task-v2/tasklist-activity_subscription/create</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2ftask-v2%2ftasklist-activity_subscription%2fcreate</para>
/// </summary>
public record PostTaskV2TasklistsByTasklistGuidActivitySubscriptionsBodyDto
{
    /// <summary>
    /// <para>订阅名称，不能为空，最大50个字符。</para>
    /// <para>必填：是</para>
    /// <para>示例值：我的订阅</para>
    /// </summary>
    [JsonPropertyName("name")]
    public string Name { get; set; } = string.Empty;

    /// <summary>
    /// <para>订阅者列表</para>
    /// <para>必填：是</para>
    /// <para>最大长度：50</para>
    /// </summary>
    [JsonPropertyName("subscribers")]
    public Member[] Subscribers { get; set; } = [];

    /// <summary>
    /// <para>订阅者列表</para>
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
        /// <para>成员的类型 （目前仅支持chat）</para>
        /// <para>必填：否</para>
        /// <para>示例值：chat</para>
        /// <para>默认值：user</para>
        /// </summary>
        [JsonPropertyName("type")]
        public string? Type { get; set; }
    }

    /// <summary>
    /// <para>订阅的event key列表。每个event key用一个数字表示。目前支持下列event key：</para>
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
    /// <para>必填：是</para>
    /// </summary>
    [JsonPropertyName("include_keys")]
    public int[] IncludeKeys { get; set; } = [];

    /// <summary>
    /// <para>该订阅是否为停用</para>
    /// <para>必填：否</para>
    /// <para>示例值：false</para>
    /// </summary>
    [JsonPropertyName("disabled")]
    public bool? Disabled { get; set; }
}
