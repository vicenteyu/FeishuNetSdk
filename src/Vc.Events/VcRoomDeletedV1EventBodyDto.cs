// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-09-01
//
// Last Modified By : yxr
// Last Modified On : 2024-09-01
// ************************************************************************
// <copyright file="VcRoomDeletedV1EventBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>删除会议室 事件体</summary>
// ************************************************************************
namespace FeishuNetSdk.Vc.Events;
/// <summary>
/// 删除会议室 事件体
/// <para>当删除会议室时，会触发该事件。{使用示例}(url=/api/tools/api_explore/api_explore_config?project=vc&amp;version=v1&amp;resource=room&amp;event=deleted)</para>
/// <para>接口ID：7160517357591953411</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/vc-v1/room/events/deleted</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fvc-v1%2froom%2fevents%2fdeleted</para>
/// </summary>
public record VcRoomDeletedV1EventBodyDto() : EventBodyDto("vc.room.deleted_v1")
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
    }
}
