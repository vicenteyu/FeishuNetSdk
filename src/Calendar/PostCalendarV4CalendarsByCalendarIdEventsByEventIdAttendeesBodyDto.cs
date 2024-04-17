namespace FeishuNetSdk.Calendar;
/// <summary>
/// 添加日程参与人 请求体
/// <para>调用该接口以当前身份（应用或用户）为指定日程添加一个或多个参与人，参与人类型包括用户、群组、会议室以及邮箱。</para>
/// <para>接口ID：6952888507003125787</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/calendar-v4/calendar-event-attendee/create</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fcalendar-v4%2fcalendar-event-attendee%2fcreate</para>
/// </summary>
public record PostCalendarV4CalendarsByCalendarIdEventsByEventIdAttendeesBodyDto
{
    /// <summary>
    /// <para>新增参与人列表。</para>
    /// <para>**注意**：</para>
    /// <para>- 单次请求可设置的参与人数量（含会议室）上限为 1000。</para>
    /// <para>- 单次请求可设置的会议室数量上限为 100。</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("attendees")]
    public CalendarEventAttendee[]? Attendees { get; set; }

    /// <summary>
    /// <para>新增参与人列表。</para>
    /// <para>**注意**：</para>
    /// <para>- 单次请求可设置的参与人数量（含会议室）上限为 1000。</para>
    /// <para>- 单次请求可设置的会议室数量上限为 100。</para>
    /// </summary>
    public record CalendarEventAttendee
    {
        /// <summary>
        /// <para>参与人类型。</para>
        /// <para>必填：否</para>
        /// <para>示例值：user</para>
        /// <para>可选值：<list type="bullet">
        /// <item>user：用户</item>
        /// <item>chat：群组</item>
        /// <item>resource：会议室</item>
        /// <item>third_party：外部邮箱</item>
        /// </list></para>
        /// </summary>
        [JsonPropertyName("type")]
        public string? Type { get; set; }

        /// <summary>
        /// <para>参与人是否为可选参加。</para>
        /// <para>**可选值有**：</para>
        /// <para>- true：是</para>
        /// <para>- false：否</para>
        /// <para>**注意**：无法编辑群参与人的此字段。</para>
        /// <para>必填：否</para>
        /// <para>示例值：true</para>
        /// <para>默认值：false</para>
        /// </summary>
        [JsonPropertyName("is_optional")]
        public bool? IsOptional { get; set; }

        /// <summary>
        /// <para>用户 ID。当选择用户类型参与人（type 取值为 user）时，需要传入该参数。传入的用户 ID 类型需要和 user_id_type 的值保持一致。关于用户 ID 可参见[用户相关的 ID 概念](https://open.feishu.cn/document/home/user-identity-introduction/introduction)。</para>
        /// <para>必填：否</para>
        /// <para>示例值：ou_xxxxxxxx</para>
        /// </summary>
        [JsonPropertyName("user_id")]
        public string? UserId { get; set; }

        /// <summary>
        /// <para>群组 ID。当选择群组类型参与人（type 取值为 chat）时，需要传入该参数。关于群组 ID 可参见[群 ID 说明](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/im-v1/chat-id-description)。</para>
        /// <para>必填：否</para>
        /// <para>示例值：oc_xxxxxxxxx</para>
        /// </summary>
        [JsonPropertyName("chat_id")]
        public string? ChatId { get; set; }

        /// <summary>
        /// <para>会议室 ID。当选择会议室类型参与人（type 取值为 resource）时，需要传入该参数。</para>
        /// <para>你可以通过以下接口获取指定会议室 ID：</para>
        /// <para>- [查询会议室列表](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/vc-v1/room/list)</para>
        /// <para>- [搜索会议室](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/vc-v1/room/search)</para>
        /// <para>必填：否</para>
        /// <para>示例值：omm_xxxxxxxx</para>
        /// </summary>
        [JsonPropertyName("room_id")]
        public string? RoomId { get; set; }

        /// <summary>
        /// <para>邮箱地址。当选择外部邮箱类型参与人（type 取值为 third_party）时，需要传入该参数。</para>
        /// <para>必填：否</para>
        /// <para>示例值：wangwu@email.com</para>
        /// </summary>
        [JsonPropertyName("third_party_email")]
        public string? ThirdPartyEmail { get; set; }

        /// <summary>
        /// <para>会议室联系人 ID。传入的用户 ID 类型需要和 user_id_type 的值保持一致。关于用户 ID 可参见[用户相关的 ID 概念](https://open.feishu.cn/document/home/user-identity-introduction/introduction)。</para>
        /// <para>**说明**：如果当前日程是基于应用身份创建的，则在添加会议室类型参与人时，需要通过该参数指定会议室的联系人，该联系人会在日程会议室信息中展示。</para>
        /// <para>**默认值**：空</para>
        /// <para>必填：否</para>
        /// <para>示例值：ou_xxxxxxxx</para>
        /// </summary>
        [JsonPropertyName("operate_id")]
        public string? OperateId { get; set; }

        /// <summary>
        /// <para>会议室的个性化配置。</para>
        /// <para>- 在选择会议室类型参与人时，如果会议室有预定表单，则可以通过该参数配置表单信息。</para>
        /// <para>- 当前添加的参与人不涉及会议室个性化配置时，无需设置该参数。</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("resource_customization")]
        public CalendarAttendeeResourceCustomization[]? ResourceCustomizations { get; set; }

        /// <summary>
        /// <para>会议室的个性化配置。</para>
        /// <para>- 在选择会议室类型参与人时，如果会议室有预定表单，则可以通过该参数配置表单信息。</para>
        /// <para>- 当前添加的参与人不涉及会议室个性化配置时，无需设置该参数。</para>
        /// </summary>
        public record CalendarAttendeeResourceCustomization
        {
            /// <summary>
            /// <para>表单内配置的唯一 ID。</para>
            /// <para>必填：是</para>
            /// <para>示例值：16281481596100</para>
            /// </summary>
            [JsonPropertyName("index_key")]
            public string IndexKey { get; set; } = string.Empty;

            /// <summary>
            /// <para>当配置类型为填空时，需要填入该参数。</para>
            /// <para>必填：否</para>
            /// <para>示例值：xxx</para>
            /// </summary>
            [JsonPropertyName("input_content")]
            public string? InputContent { get; set; }

            /// <summary>
            /// <para>每个配置的选项。</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("options")]
            public CustomizationOption[]? Options { get; set; }

            /// <summary>
            /// <para>每个配置的选项。</para>
            /// </summary>
            public record CustomizationOption
            {
                /// <summary>
                /// <para>选项的唯一 ID。</para>
                /// <para>必填：否</para>
                /// <para>示例值：16281481596185</para>
                /// </summary>
                [JsonPropertyName("option_key")]
                public string? OptionKey { get; set; }

                /// <summary>
                /// <para>当选项类型为其它选项时，需要填入该参数。</para>
                /// <para>必填：否</para>
                /// <para>示例值：xxx</para>
                /// </summary>
                [JsonPropertyName("others_content")]
                public string? OthersContent { get; set; }
            }
        }

        /// <summary>
        /// <para>申请预定审批会议室的原因。参数配置说明：</para>
        /// <para>- 仅使用用户身份（user_access_token）预定审批会议室时，该字段生效。</para>
        /// <para>- 对于申请预定审批会议室的场景，不传该值会直接预约失败。</para>
        /// <para>- 如果使用应用身份（tenant_access_token）预定审批会议室，会直接失败。</para>
        /// <para>**默认值**：空</para>
        /// <para>必填：否</para>
        /// <para>示例值：申请原因</para>
        /// <para>最大长度：200</para>
        /// </summary>
        [JsonPropertyName("approval_reason")]
        public string? ApprovalReason { get; set; }
    }

    /// <summary>
    /// <para>是否给参与人发送 Bot 通知。</para>
    /// <para>**可选值有**：</para>
    /// <para>- true（默认值）：发送</para>
    /// <para>- false：不发送</para>
    /// <para>必填：否</para>
    /// <para>示例值：false</para>
    /// </summary>
    [JsonPropertyName("need_notification")]
    public bool? NeedNotification { get; set; }

    /// <summary>
    /// <para>使用管理员身份访问时，要修改的日程实例。</para>
    /// <para>**注意**：</para>
    /// <para>- 该参数仅用于修改重复日程中的某一日程实例，非重复日程无需填此字段。</para>
    /// <para>- 你可以调用[获取重复日程实例](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/calendar-v4/calendar-event/instances)接口，获取重复日程中某一日程实例的 event_id。该参数取值为 event_id 的时间戳后缀。例如查询到的日程实例 ID 为 `2cf525f0-1e67-4b04-ad4d-30b7f003903c_1713168000`，则当前的 `instance_start_time_admin` 取值为 `1713168000`。</para>
    /// <para>**默认值**：空</para>
    /// <para>必填：否</para>
    /// <para>示例值：1647320400</para>
    /// </summary>
    [JsonPropertyName("instance_start_time_admin")]
    public string? InstanceStartTimeAdmin { get; set; }

    /// <summary>
    /// <para>是否启用会议室管理员身份（需先在管理后台设置某成员为会议室管理员)。</para>
    /// <para>**可选值有**：</para>
    /// <para>- true：启用</para>
    /// <para>- false（默认值）：不启用</para>
    /// <para>**说明**：开启后，本次请求只处理会议室数据，其他参与人操作不会生效。</para>
    /// <para>必填：否</para>
    /// <para>示例值：false</para>
    /// </summary>
    [JsonPropertyName("is_enable_admin")]
    public bool? IsEnableAdmin { get; set; }

    /// <summary>
    /// <para>是否添加会议室联系人（operate_id）到日程参与人。</para>
    /// <para>**可选值有**：</para>
    /// <para>- true（默认值）：启用</para>
    /// <para>- false：不启用</para>
    /// <para>必填：否</para>
    /// <para>示例值：false</para>
    /// </summary>
    [JsonPropertyName("add_operator_to_attendee")]
    public bool? AddOperatorToAttendee { get; set; }
}
