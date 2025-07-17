// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-09-01
//
// Last Modified By : yxr
// Last Modified On : 2024-09-01
// ************************************************************************
// <copyright file="VcRoomLevelDeletedV1EventBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>删除会议室层级 事件体</summary>
// ************************************************************************
namespace FeishuNetSdk.Vc.Events;
/// <summary>
/// 删除会议室层级 事件体
/// <para>当删除会议室层级时，会触发该事件。{使用示例}(url=/api/tools/api_explore/api_explore_config?project=vc&amp;version=v1&amp;resource=room_level&amp;event=deleted)</para>
/// <para>接口ID：7194805625628082179</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/vc-v1/room_level/events/deleted</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fvc-v1%2froom_level%2fevents%2fdeleted</para>
/// </summary>
public record VcRoomLevelDeletedV1EventBodyDto() : EventBodyDto("vc.room_level.deleted_v1")
{
    /// <summary>
    /// <para>层级ID</para>
    /// <para>**数据校验规则**：</para>
    /// <para>- 长度范围：`1` ～ `100` 字符</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("room_level_id")]
    public string? RoomLevelId { get; set; }

    /// <summary>
    /// <para>是否删除所有子层级</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("delete_child")]
    public bool? DeleteChild { get; set; }
}
