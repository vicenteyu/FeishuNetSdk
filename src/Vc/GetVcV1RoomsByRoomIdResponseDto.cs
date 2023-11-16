namespace FeishuNetSdk.Vc;
/// <summary>
/// 查询会议室详情 响应体
/// <para>该接口可以使用会议室 ID 查询会议室详情。</para>
/// <para>接口ID：7160517357592068099</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/vc-v1/room/get</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fvc-v1%2froom%2fget</para>
/// </summary>
public record GetVcV1RoomsByRoomIdResponseDto
{
    /// <summary>
    /// <para>会议室详情</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("room")]
    public GetVcV1RoomsByRoomIdResponseDtoRoom? Room { get; set; }

    /// <summary>
    /// <para>会议室详情</para>
    /// </summary>
    public record GetVcV1RoomsByRoomIdResponseDtoRoom
    {
        /// <summary>
        /// <para>会议室ID</para>
        /// <para>必填：否</para>
        /// <para>示例值：omm_4de32cf10a4358788ff4e09e37ebbf9b</para>
        /// </summary>
        [JsonPropertyName("room_id")]
        public string? RoomId { get; set; }

        /// <summary>
        /// <para>会议室名称</para>
        /// <para>必填：否</para>
        /// <para>示例值：测试会议室</para>
        /// </summary>
        [JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// <para>会议室能容纳的人数</para>
        /// <para>必填：否</para>
        /// <para>示例值：10</para>
        /// </summary>
        [JsonPropertyName("capacity")]
        public int? Capacity { get; set; }

        /// <summary>
        /// <para>会议室的相关描述</para>
        /// <para>必填：否</para>
        /// <para>示例值：测试会议室描述</para>
        /// </summary>
        [JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// <para>会议室的展示ID</para>
        /// <para>必填：否</para>
        /// <para>示例值：LM134742334</para>
        /// </summary>
        [JsonPropertyName("display_id")]
        public string? DisplayId { get; set; }

        /// <summary>
        /// <para>自定义的会议室ID</para>
        /// <para>必填：否</para>
        /// <para>示例值：1234</para>
        /// </summary>
        [JsonPropertyName("custom_room_id")]
        public string? CustomRoomId { get; set; }

        /// <summary>
        /// <para>层级ID</para>
        /// <para>必填：否</para>
        /// <para>示例值：omb_4ad1a2c7a2fbc5fc9570f38456931293</para>
        /// </summary>
        [JsonPropertyName("room_level_id")]
        public string? RoomLevelId { get; set; }

        /// <summary>
        /// <para>层级路径</para>
        /// <para>必填：否</para>
        /// <para>示例值：[omb_8d020b12fe49e82847c2af3c193d5754,omb_8d020b12fe49e82847c2af3c193d5754]</para>
        /// </summary>
        [JsonPropertyName("path")]
        public string[]? Path { get; set; }

        /// <summary>
        /// <para>会议室状态</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("room_status")]
        public GetVcV1RoomsByRoomIdResponseDtoRoomRoomStatus? RoomStatus { get; set; }

        /// <summary>
        /// <para>会议室状态</para>
        /// </summary>
        public record GetVcV1RoomsByRoomIdResponseDtoRoomRoomStatus
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

        /// <summary>
        /// <para>设施信息列表</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("device")]
        public Device[]? Devices { get; set; }

        /// <summary>
        /// <para>设施信息列表</para>
        /// </summary>
        public record Device
        {
            /// <summary>
            /// <para>设施名称</para>
            /// <para>必填：是</para>
            /// <para>示例值：电话</para>
            /// </summary>
            [JsonPropertyName("name")]
            public string Name { get; set; } = string.Empty;
        }
    }
}
