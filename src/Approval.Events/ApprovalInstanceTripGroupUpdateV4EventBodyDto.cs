// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-09-07
//
// Last Modified By : yxr
// Last Modified On : 2025-05-25
// ************************************************************************
// <copyright file="ApprovalInstanceTripGroupUpdateV4EventBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>出差审批 事件体</summary>
// ************************************************************************
namespace FeishuNetSdk.Approval.Events;
/// <summary>
/// 出差审批 事件体
/// <para>审批定义的表单包含 **出差控件组** 时，该定义下的审批实例通过时，触发该事件。</para>
/// <para>接口ID：7013340088257462300</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/approval-v4/event/special-event/business-trip</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuIDO24iM4YjLygjN%2fevent%2fbusiness-trip</para>
/// </summary>
public record ApprovalInstanceTripGroupUpdateV4EventBodyDto() : EventBodyDto("approval.instance.trip_group_update_v4")
{
    /// <summary>
    /// <para>事件详细信息。</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("object")]
    public ObjectSuffix? Object { get; set; }

    /// <summary>
    /// 
    /// </summary>
    public record ObjectSuffix
    {
        /// <summary>
        /// <para>审批实例 Code。可调用[获取单个审批实例详情](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/approval-v4/instance/get)接口，根据 Code 查询实例详情。</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("instance_code")]
        public string? InstanceCode { get; set; }

        /// <summary>
        /// <para>审批开始时间，秒级时间戳。</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("start_time")]
        public int? StartTime { get; set; }

        /// <summary>
        /// <para>审批结束时间，秒级时间戳。</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("end_time")]
        public int? EndTime { get; set; }

        /// <summary>
        /// <para>出差详细信息。</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("schedules")]
        public Schedule[]? Schedules { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public record Schedule
        {
            /// <summary>
            /// <para>出发地。</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("departure")]
            public string? Departure { get; set; }

            /// <summary>
            /// <para>出发地 ID。</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("departure_id")]
            public string? DepartureId { get; set; }

            /// <summary>
            /// <para>目的地。</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("destination")]
            public string? Destination { get; set; }

            /// <summary>
            /// <para>目的地 ID。</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("destination_ids")]
            public string[]? DestinationIds { get; set; }

            /// <summary>
            /// <para>备注信息。</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("remark")]
            public string? Remark { get; set; }

            /// <summary>
            /// <para>交通工具。</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("transportation")]
            public string? Transportation { get; set; }

            /// <summary>
            /// <para>出差开始时间。示例格式：2022-08-25 12:00:00</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("trip_start_time")]
            public string? TripStartTime { get; set; }

            /// <summary>
            /// <para>出差结束时间。示例格式：2022-08-25 12:00:00</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("trip_end_time")]
            public string? TripEndTime { get; set; }

            /// <summary>
            /// <para>出差时长。单位：秒</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("trip_interval")]
            public string? TripInterval { get; set; }

            /// <summary>
            /// <para>出差类型。可能值：</para>
            /// <para>- 单程</para>
            /// <para>- 往返</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("trip_type")]
            public string? TripType { get; set; }
        }

        /// <summary>
        /// <para>审批提交人的信息。</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("start_user")]
        public StartUserSuffix? StartUser { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public record StartUserSuffix
        {
            /// <summary>
            /// <para>审批提交人的 ID。不同类型 ID 介绍参见[用户身份概述](https://open.feishu.cn/document/home/user-identity-introduction/introduction#9eb4f13c)。</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("id")]
            public UserIdSuffix? Id { get; set; }
        }

        /// <summary>
        /// <para>出差时长。单位：秒</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("trip_interval")]
        public string? TripInterval { get; set; }

        /// <summary>
        /// <para>出差原因。</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("trip_reason")]
        public string? TripReason { get; set; }

        /// <summary>
        /// <para>固定值 `APPROVED`</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("type")]
        public string? Type { get; set; }

        /// <summary>
        /// <para>出差同行人信息。</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("trip_peers")]
        public TripPeer[]? TripPeers { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public record TripPeer
        {
            /// <summary>
            /// <para>同行人 ID。不同类型 ID 介绍参见[用户身份概述](https://open.feishu.cn/document/home/user-identity-introduction/introduction#9eb4f13c)。</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("id")]
            public UserIdSuffix? Id { get; set; }
        }
    }
}
