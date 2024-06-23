// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-06-24
// ************************************************************************
// <copyright file="GetVcV1RoomConfigsQueryResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>查询会议室配置 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Vc;
/// <summary>
/// 查询会议室配置 响应体
/// <para>查询一个范围内的会议室配置。</para>
/// <para>接口ID：6921909217674739739</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/historic-version/meeting_room-v1/room_config/query</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fvc-v1%2froom_config%2fquery</para>
/// </summary>
public record GetVcV1RoomConfigsQueryResponseDto
{
    /// <summary>
    /// <para>飞书会议室背景图</para>
    /// <para>必填：否</para>
    /// <para>示例值：https://lf1-ttcdn-tos.pstatp.com/obj/xxx</para>
    /// </summary>
    [JsonPropertyName("room_background")]
    public string? RoomBackground { get; set; }

    /// <summary>
    /// <para>飞书签到板背景图</para>
    /// <para>必填：否</para>
    /// <para>示例值：https://lf1-ttcdn-tos.pstatp.com/obj/xxx</para>
    /// </summary>
    [JsonPropertyName("display_background")]
    public string? DisplayBackground { get; set; }

    /// <summary>
    /// <para>飞书会议室数字标牌</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("digital_signage")]
    public RoomDigitalSignage? DigitalSignage { get; set; }

    /// <summary>
    /// <para>飞书会议室数字标牌</para>
    /// </summary>
    public record RoomDigitalSignage
    {
        /// <summary>
        /// <para>是否开启数字标牌功能</para>
        /// <para>必填：否</para>
        /// <para>示例值：true</para>
        /// </summary>
        [JsonPropertyName("enable")]
        public bool? Enable { get; set; }

        /// <summary>
        /// <para>是否静音播放</para>
        /// <para>必填：否</para>
        /// <para>示例值：true</para>
        /// </summary>
        [JsonPropertyName("mute")]
        public bool? Mute { get; set; }

        /// <summary>
        /// <para>在会议结束n分钟后开始播放，取值1~720（仅对飞书会议室数字标牌生效）</para>
        /// <para>必填：否</para>
        /// <para>示例值：3</para>
        /// </summary>
        [JsonPropertyName("start_display")]
        public int? StartDisplay { get; set; }

        /// <summary>
        /// <para>在日程会议开始前n分钟停止播放，取值1~720（仅对飞书会议室数字标牌生效）</para>
        /// <para>必填：否</para>
        /// <para>示例值：3</para>
        /// </summary>
        [JsonPropertyName("stop_display")]
        public int? StopDisplay { get; set; }

        /// <summary>
        /// <para>素材列表</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("materials")]
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
            [JsonPropertyName("id")]
            public string? Id { get; set; }

            /// <summary>
            /// <para>素材名称</para>
            /// <para>必填：否</para>
            /// <para>示例值：name</para>
            /// </summary>
            [JsonPropertyName("name")]
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
            [JsonPropertyName("material_type")]
            public int? MaterialType { get; set; }

            /// <summary>
            /// <para>素材url</para>
            /// <para>必填：否</para>
            /// <para>示例值：url</para>
            /// </summary>
            [JsonPropertyName("url")]
            public string? Url { get; set; }

            /// <summary>
            /// <para>播放时长（单位sec），取值1~43200</para>
            /// <para>必填：否</para>
            /// <para>示例值：15</para>
            /// </summary>
            [JsonPropertyName("duration")]
            public int? Duration { get; set; }

            /// <summary>
            /// <para>素材封面url</para>
            /// <para>必填：否</para>
            /// <para>示例值：url</para>
            /// </summary>
            [JsonPropertyName("cover")]
            public string? Cover { get; set; }

            /// <summary>
            /// <para>素材文件md5</para>
            /// <para>必填：否</para>
            /// <para>示例值：md5</para>
            /// </summary>
            [JsonPropertyName("md5")]
            public string? Md5 { get; set; }

            /// <summary>
            /// <para>素材文件vid</para>
            /// <para>必填：否</para>
            /// <para>示例值：vid</para>
            /// </summary>
            [JsonPropertyName("vid")]
            public string? Vid { get; set; }

            /// <summary>
            /// <para>素材文件大小（单位byte）</para>
            /// <para>必填：否</para>
            /// <para>示例值：100</para>
            /// </summary>
            [JsonPropertyName("size")]
            public string? Size { get; set; }
        }
    }

    /// <summary>
    /// <para>飞书投屏盒子数字标牌</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("room_box_digital_signage")]
    public RoomDigitalSignage? RoomBoxDigitalSignage { get; set; }

    /// <summary>
    /// <para>会议室状态</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("room_status")]
    public GetVcV1RoomConfigsQueryResponseDtoRoomStatus? RoomStatus { get; set; }

    /// <summary>
    /// <para>会议室状态</para>
    /// </summary>
    public record GetVcV1RoomConfigsQueryResponseDtoRoomStatus
    {
        /// <summary>
        /// <para>是否启用会议室</para>
        /// <para>必填：是</para>
        /// <para>示例值：true</para>
        /// </summary>
        [JsonPropertyName("status")]
        public bool Status { get; set; }

        /// <summary>
        /// <para>会议室未来状态为启用或禁用</para>
        /// <para>必填：否</para>
        /// <para>示例值：true</para>
        /// </summary>
        [JsonPropertyName("schedule_status")]
        public bool? ScheduleStatus { get; set; }

        /// <summary>
        /// <para>禁用开始时间（unix时间，单位sec）</para>
        /// <para>必填：否</para>
        /// <para>示例值：1652356050</para>
        /// </summary>
        [JsonPropertyName("disable_start_time")]
        public string? DisableStartTime { get; set; }

        /// <summary>
        /// <para>禁用结束时间（unix时间，单位sec，数值0表示永久禁用）</para>
        /// <para>必填：否</para>
        /// <para>示例值：1652442450</para>
        /// </summary>
        [JsonPropertyName("disable_end_time")]
        public string? DisableEndTime { get; set; }

        /// <summary>
        /// <para>禁用原因</para>
        /// <para>必填：否</para>
        /// <para>示例值：测试占用</para>
        /// </summary>
        [JsonPropertyName("disable_reason")]
        public string? DisableReason { get; set; }

        /// <summary>
        /// <para>联系人列表，id类型由user_id_type参数决定</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("contact_ids")]
        public string[]? ContactIds { get; set; }

        /// <summary>
        /// <para>是否在禁用时发送通知给预定了该会议室的员工</para>
        /// <para>必填：否</para>
        /// <para>示例值：true</para>
        /// </summary>
        [JsonPropertyName("disable_notice")]
        public bool? DisableNotice { get; set; }

        /// <summary>
        /// <para>是否在恢复启用时发送通知给联系人</para>
        /// <para>必填：否</para>
        /// <para>示例值：true</para>
        /// </summary>
        [JsonPropertyName("resume_notice")]
        public bool? ResumeNotice { get; set; }
    }
}
