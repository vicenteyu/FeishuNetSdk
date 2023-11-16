namespace FeishuNetSdk.Task;
/// <summary>
/// 创建动态订阅 响应体
/// <para>为一个清单创建一个订阅。每个订阅可以包含1个或多个订阅者（目前只支持普通群组）。订阅创建后，如清单发生相应的事件，则会向订阅里的订阅者发送通知消息。一个清单最多可以创建50个订阅。每个订阅最大支持50个订阅者。订阅者目前仅支持"chat"类型。</para>
/// <para>每个订阅可以通过设置`include_keys`可以针对哪些事件(event_key)做通知。如果`include_keys`为空，则不对任何事件进行通知。</para>
/// <para>如有需要，创建时也可以直接将`disabled`设为true，创建一个禁止发送订阅通知的订阅。</para>
/// <para>接口ID：7288897051647000578</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/task-v2/tasklist-activity_subscription/create</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2ftask-v2%2ftasklist-activity_subscription%2fcreate</para>
/// </summary>
public record PostTaskV2TasklistsByTasklistGuidActivitySubscriptionsResponseDto
{
    /// <summary>
    /// <para>清单动态订阅</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("activity_subscription")]
    public TasklistActivitySubscription? ActivitySubscription { get; set; }

    /// <summary>
    /// <para>清单动态订阅</para>
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
        /// <para>订阅者</para>
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
            /// <para>成员的类型</para>
            /// <para>必填：否</para>
            /// <para>示例值：user</para>
            /// <para>默认值：user</para>
            /// </summary>
            [JsonPropertyName("type")]
            public string? Type { get; set; }

            /// <summary>
            /// <para>成员角色</para>
            /// <para>必填：否</para>
            /// <para>示例值：editor</para>
            /// <para>最大长度：20</para>
            /// </summary>
            [JsonPropertyName("role")]
            public string? Role { get; set; }
        }

        /// <summary>
        /// <para>要订阅的清单动态类型</para>
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
}
