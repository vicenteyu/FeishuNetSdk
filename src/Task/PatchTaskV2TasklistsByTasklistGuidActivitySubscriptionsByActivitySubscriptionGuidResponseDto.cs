using Newtonsoft.Json;
namespace FeishuNetSdk.Task;
/// <summary>
/// 更新动态订阅 响应体
/// <para>提供一个清单的GUID和一个动态订阅的GUID，对其进行更新。更新时，将`update_fields`字段中填写所有要修改的字段名，同时在`activity_subscription`字段中填写要修改的字段的新值即可。</para>
/// <para>`update_fields`支持更新的字段包括：</para>
/// <para>* name：订阅的名称</para>
/// <para>* subscribers: 订阅者列表。如更新，会将旧的订阅者列表完全替换为新的订阅者列表。支持最大50个订阅者。并且订阅者必须是chat类型。</para>
/// <para>* include_keys ：订阅需要发送通知的key。如更新，会将旧的列表完全替换为新的include_keys列表。只能设置支持的event key (见字段描述）。</para>
/// <para>* disabled：修改订阅的开启/禁用状态。</para>
/// <para>接口ID：7288897051646967810</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/task-v2/tasklist-activity_subscription/patch</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2ftask-v2%2ftasklist-activity_subscription%2fpatch</para>
/// </summary>
public record PatchTaskV2TasklistsByTasklistGuidActivitySubscriptionsByActivitySubscriptionGuidResponseDto
{
    /// <summary>
    /// <para>更新后的订阅</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonProperty("activity_subscription")]
    public TasklistActivitySubscription? ActivitySubscription { get; set; }

    /// <summary>
    /// <para>更新后的订阅</para>
    /// </summary>
    public record TasklistActivitySubscription
    {
        /// <summary>
        /// <para>订阅guid</para>
        /// <para>必填：否</para>
        /// <para>示例值：d19e3a2a-edc0-4e4e-b7cc-950e162b53ae</para>
        /// </summary>
        [JsonProperty("guid")]
        public string? Guid { get; set; }

        /// <summary>
        /// <para>订阅名称</para>
        /// <para>必填：否</para>
        /// <para>示例值：Roadmap订阅</para>
        /// </summary>
        [JsonProperty("name")]
        public string? Name { get; set; }

        /// <summary>
        /// <para>订阅者</para>
        /// <para>必填：否</para>
        /// <para>最大长度：50</para>
        /// </summary>
        [JsonProperty("subscribers")]
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
            [JsonProperty("id")]
            public string? Id { get; set; }

            /// <summary>
            /// <para>成员的类型</para>
            /// <para>必填：否</para>
            /// <para>示例值：chat</para>
            /// <para>默认值：user</para>
            /// </summary>
            [JsonProperty("type")]
            public string? Type { get; set; }

            /// <summary>
            /// <para>成员角色</para>
            /// <para>必填：否</para>
            /// <para>示例值：editor</para>
            /// <para>最大长度：20</para>
            /// </summary>
            [JsonProperty("role")]
            public string? Role { get; set; }
        }

        /// <summary>
        /// <para>要订阅的清单动态类型</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonProperty("include_keys")]
        public int[]? IncludeKeys { get; set; }

        /// <summary>
        /// <para>该订阅是否为停用</para>
        /// <para>必填：否</para>
        /// <para>示例值：false</para>
        /// </summary>
        [JsonProperty("disabled")]
        public bool? Disabled { get; set; }
    }
}
