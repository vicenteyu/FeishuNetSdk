// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-09-01
//
// Last Modified By : yxr
// Last Modified On : 2024-09-01
// ************************************************************************
// <copyright file="VcRoomLevelCreatedV1EventBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>创建会议室层级 事件体</summary>
// ************************************************************************
namespace FeishuNetSdk.Vc.Events;
/// <summary>
/// 创建会议室层级 事件体
/// <para>当创建会议室层级时，会触发该事件。{使用示例}(url=/api/tools/api_explore/api_explore_config?project=vc&amp;version=v1&amp;resource=room_level&amp;event=created)</para>
/// <para>接口ID：7194805625628098563</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/vc-v1/room_level/events/created</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fvc-v1%2froom_level%2fevents%2fcreated</para>
/// </summary>
public record VcRoomLevelCreatedV1EventBodyDto() : EventBodyDto("vc.room_level.created_v1")
{
    /// <summary>
    /// <para>层级信息</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("room_level")]
    public RoomLevelSuffix? RoomLevel { get; set; }

    /// <summary>
    /// 
    /// </summary>
    public record RoomLevelSuffix
    {
        /// <summary>
        /// <para>层级ID</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("room_level_id")]
        public string? RoomLevelId { get; set; }

        /// <summary>
        /// <para>层级名称</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// <para>父层级ID</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("parent_id")]
        public string? ParentId { get; set; }

        /// <summary>
        /// <para>层级路径</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("path")]
        public string[]? Path { get; set; }

        /// <summary>
        /// <para>是否有子层级</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("has_child")]
        public bool? HasChild { get; set; }

        /// <summary>
        /// <para>自定义层级ID</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("custom_group_id")]
        public string? CustomGroupId { get; set; }
    }
}
