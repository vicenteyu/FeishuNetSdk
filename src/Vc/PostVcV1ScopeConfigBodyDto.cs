using Newtonsoft.Json;
namespace FeishuNetSdk.Vc;
/// <summary>
/// 设置会议室配置 请求体
/// <para>该接口可以用来设置某个会议层级范围下或者某个会议室的配置。</para>
/// <para>接口ID：7160517357591920643</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/vc-v1/scope_config/create</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fvc-v1%2fscope_config%2fcreate</para>
/// </summary>
public record PostVcV1ScopeConfigBodyDto
{
    /// <summary>
    /// <para>查询节点范围</para>
    /// <para>必填：是</para>
    /// <para>示例值：1</para>
    /// <para>可选值：<list type="bullet">
    /// <item>1：会议室层级</item>
    /// <item>2：会议室</item>
    /// </list></para>
    /// </summary>
    [JsonProperty("scope_type")]
    public int ScopeType { get; set; }

    /// <summary>
    /// <para>查询节点ID：如果scope_type为1，则为层级ID，如果scope_type为2，则为会议室ID</para>
    /// <para>必填：是</para>
    /// <para>示例值：omm_608d34d82d531b27fa993902d350a307</para>
    /// </summary>
    [JsonProperty("scope_id")]
    public string ScopeId { get; set; } = string.Empty;

    /// <summary>
    /// <para>节点配置</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonProperty("scope_config")]
    public RoomConfig? ScopeConfig { get; set; }

    /// <summary>
    /// <para>节点配置</para>
    /// </summary>
    public record RoomConfig
    {
        /// <summary>
        /// <para>飞书会议室背景图</para>
        /// <para>必填：否</para>
        /// <para>示例值：https://lf1-ttcdn-tos.pstatp.com/obj/xxx</para>
        /// </summary>
        [JsonProperty("room_background")]
        public string? RoomBackground { get; set; }

        /// <summary>
        /// <para>飞书签到板背景图</para>
        /// <para>必填：否</para>
        /// <para>示例值：https://lf1-ttcdn-tos.pstatp.com/obj/xxx</para>
        /// </summary>
        [JsonProperty("display_background")]
        public string? DisplayBackground { get; set; }

        /// <summary>
        /// <para>飞书会议室数字标牌</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonProperty("digital_signage")]
        public RoomDigitalSignage? DigitalSignage { get; set; }

        /// <summary>
        /// <para>飞书会议室数字标牌</para>
        /// </summary>
        public record RoomDigitalSignage
        {
            /// <summary>
            /// <para>是否覆盖子层级及会议室</para>
            /// <para>必填：否</para>
            /// <para>示例值：true</para>
            /// </summary>
            [JsonProperty("if_cover_child_scope")]
            public bool? IfCoverChildScope { get; set; }

            /// <summary>
            /// <para>是否开启数字标牌功能</para>
            /// <para>必填：否</para>
            /// <para>示例值：true</para>
            /// </summary>
            [JsonProperty("enable")]
            public bool? Enable { get; set; }

            /// <summary>
            /// <para>是否静音播放</para>
            /// <para>必填：否</para>
            /// <para>示例值：true</para>
            /// </summary>
            [JsonProperty("mute")]
            public bool? Mute { get; set; }

            /// <summary>
            /// <para>在会议结束n分钟后开始播放，取值1~720（仅对飞书会议室数字标牌生效）</para>
            /// <para>必填：否</para>
            /// <para>示例值：3</para>
            /// </summary>
            [JsonProperty("start_display")]
            public int? StartDisplay { get; set; }

            /// <summary>
            /// <para>在日程会议开始前n分钟停止播放，取值1~720（仅对飞书会议室数字标牌生效）</para>
            /// <para>必填：否</para>
            /// <para>示例值：3</para>
            /// </summary>
            [JsonProperty("stop_display")]
            public int? StopDisplay { get; set; }

            /// <summary>
            /// <para>素材列表</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonProperty("materials")]
            public RoomDigitalSignageMaterial[]? Materials { get; set; }

            /// <summary>
            /// <para>素材列表</para>
            /// </summary>
            public record RoomDigitalSignageMaterial
            {
                /// <summary>
                /// <para>素材ID，当设置新素材时，无需传递该字段</para>
                /// <para>必填：否</para>
                /// <para>示例值：7847784676276</para>
                /// </summary>
                [JsonProperty("id")]
                public string? Id { get; set; }

                /// <summary>
                /// <para>素材名称</para>
                /// <para>必填：否</para>
                /// <para>示例值：name</para>
                /// </summary>
                [JsonProperty("name")]
                public string? Name { get; set; }

                /// <summary>
                /// <para>素材类型</para>
                /// <para>必填：否</para>
                /// <para>示例值：0</para>
                /// <para>可选值：<list type="bullet">
                /// <item>1：图片</item>
                /// <item>2：视频</item>
                /// <item>3：GIF</item>
                /// </list></para>
                /// </summary>
                [JsonProperty("material_type")]
                public int? MaterialType { get; set; }

                /// <summary>
                /// <para>素材url</para>
                /// <para>必填：否</para>
                /// <para>示例值：url</para>
                /// </summary>
                [JsonProperty("url")]
                public string? Url { get; set; }

                /// <summary>
                /// <para>播放时长（单位sec），取值1~43200</para>
                /// <para>必填：否</para>
                /// <para>示例值：15</para>
                /// </summary>
                [JsonProperty("duration")]
                public int? Duration { get; set; }

                /// <summary>
                /// <para>素材封面url</para>
                /// <para>必填：否</para>
                /// <para>示例值：url</para>
                /// </summary>
                [JsonProperty("cover")]
                public string? Cover { get; set; }

                /// <summary>
                /// <para>素材文件md5</para>
                /// <para>必填：否</para>
                /// <para>示例值：md5</para>
                /// </summary>
                [JsonProperty("md5")]
                public string? Md5 { get; set; }

                /// <summary>
                /// <para>素材文件vid</para>
                /// <para>必填：否</para>
                /// <para>示例值：vid</para>
                /// </summary>
                [JsonProperty("vid")]
                public string? Vid { get; set; }

                /// <summary>
                /// <para>素材文件大小（单位byte）</para>
                /// <para>必填：否</para>
                /// <para>示例值：100</para>
                /// </summary>
                [JsonProperty("size")]
                public string? Size { get; set; }
            }
        }

        /// <summary>
        /// <para>飞书投屏盒子数字标牌</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonProperty("room_box_digital_signage")]
        public RoomDigitalSignage? RoomBoxDigitalSignage { get; set; }

        /// <summary>
        /// <para>会议室状态</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonProperty("room_status")]
        public RoomConfigRoomStatus? RoomStatus { get; set; }

        /// <summary>
        /// <para>会议室状态</para>
        /// </summary>
        public record RoomConfigRoomStatus
        {
            /// <summary>
            /// <para>是否启用会议室</para>
            /// <para>必填：是</para>
            /// <para>示例值：true</para>
            /// </summary>
            [JsonProperty("status")]
            public bool Status { get; set; }

            /// <summary>
            /// <para>会议室未来状态为启用或禁用</para>
            /// <para>必填：否</para>
            /// <para>示例值：true</para>
            /// </summary>
            [JsonProperty("schedule_status")]
            public bool? ScheduleStatus { get; set; }

            /// <summary>
            /// <para>禁用开始时间（unix时间，单位sec）</para>
            /// <para>必填：否</para>
            /// <para>示例值：1652356050</para>
            /// </summary>
            [JsonProperty("disable_start_time")]
            public string? DisableStartTime { get; set; }

            /// <summary>
            /// <para>禁用结束时间（unix时间，单位sec，数值0表示永久禁用）</para>
            /// <para>必填：否</para>
            /// <para>示例值：1652442450</para>
            /// </summary>
            [JsonProperty("disable_end_time")]
            public string? DisableEndTime { get; set; }

            /// <summary>
            /// <para>禁用原因</para>
            /// <para>必填：否</para>
            /// <para>示例值：测试占用</para>
            /// </summary>
            [JsonProperty("disable_reason")]
            public string? DisableReason { get; set; }

            /// <summary>
            /// <para>联系人列表，id类型由user_id_type参数决定</para>
            /// <para>必填：否</para>
            /// <para>示例值：["ou_3ec3f6a28a0d08c45d895276e8e5e19b"]</para>
            /// </summary>
            [JsonProperty("contact_ids")]
            public string[]? ContactIds { get; set; }

            /// <summary>
            /// <para>是否在禁用时发送通知给预定了该会议室的员工</para>
            /// <para>必填：否</para>
            /// <para>示例值：true</para>
            /// </summary>
            [JsonProperty("disable_notice")]
            public bool? DisableNotice { get; set; }

            /// <summary>
            /// <para>是否在恢复启用时发送通知给联系人</para>
            /// <para>必填：否</para>
            /// <para>示例值：true</para>
            /// </summary>
            [JsonProperty("resume_notice")]
            public bool? ResumeNotice { get; set; }
        }
    }
}
