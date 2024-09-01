// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-09-01
//
// Last Modified By : yxr
// Last Modified On : 2024-09-01
// ************************************************************************
// <copyright file="VcRoomCreatedV1EventBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>创建会议室 事件体</summary>
// ************************************************************************
namespace FeishuNetSdk.Vc.Events;
/// <summary>
/// 创建会议室 事件体
/// <para>当创建会议室时，会触发该事件。{使用示例}(url=/api/tools/api_explore/api_explore_config?project=vc&amp;version=v1&amp;resource=room&amp;event=created)</para>
/// <para>接口ID：7160517357592100867</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/vc-v1/room/events/created</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fvc-v1%2froom%2fevents%2fcreated</para>
/// </summary>
public record VcRoomCreatedV1EventBodyDto() : EventBodyDto("vc.room.created_v1")
{
    /// <summary>
    /// <para>会议室信息</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("room")]
    public RoomEvent? Room { get; set; }

    /// <summary>
    /// 
    /// </summary>
    public record RoomEvent
    {
        /// <summary>
        /// <para>会议室ID</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("room_id")]
        public string? RoomId { get; set; }

        /// <summary>
        /// <para>会议室名称</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// <para>会议室能容纳的人数</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("capacity")]
        public int? Capacity { get; set; }

        /// <summary>
        /// <para>会议室的相关描述</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// <para>会议室的展示ID</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("display_id")]
        public string? DisplayId { get; set; }

        /// <summary>
        /// <para>自定义的会议室ID</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("custom_room_id")]
        public string? CustomRoomId { get; set; }

        /// <summary>
        /// <para>层级ID</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("room_level_id")]
        public string? RoomLevelId { get; set; }

        /// <summary>
        /// <para>层级路径</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("path")]
        public string[]? Path { get; set; }

        /// <summary>
        /// <para>会议室状态</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("room_status")]
        public RoomStatusEvent? RoomStatus { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public record RoomStatusEvent
        {
            /// <summary>
            /// <para>是否启用会议室</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("status")]
            public bool? Status { get; set; }

            /// <summary>
            /// <para>会议室未来状态为启用或禁用</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("schedule_status")]
            public bool? ScheduleStatus { get; set; }

            /// <summary>
            /// <para>禁用开始时间（unix时间，单位sec）</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("disable_start_time")]
            public string? DisableStartTime { get; set; }

            /// <summary>
            /// <para>禁用结束时间（unix时间，单位sec，数值0表示永久禁用）</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("disable_end_time")]
            public string? DisableEndTime { get; set; }

            /// <summary>
            /// <para>禁用原因</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("disable_reason")]
            public string? DisableReason { get; set; }

            /// <summary>
            /// <para>联系人列表</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("contact_ids")]
            public UserIdSuffix[]? ContactIds { get; set; }

            /// <summary>
            /// <para>是否在禁用时发送通知给预定了该会议室的员工</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("disable_notice")]
            public bool? DisableNotice { get; set; }

            /// <summary>
            /// <para>是否在恢复启用时发送通知给预定了该会议室的员工</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("resume_notice")]
            public bool? ResumeNotice { get; set; }
        }

        /// <summary>
        /// <para>设施信息列表</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("device")]
        public DeviceSuffix[]? Device { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public record DeviceSuffix
        {
            /// <summary>
            /// <para>设施名称</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("name")]
            public string? Name { get; set; }
        }
    }
}
