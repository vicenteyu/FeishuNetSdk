// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-06-24
// ************************************************************************
// <copyright file="PostVcV1RoomLevelsResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>创建会议室层级 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Vc;
/// <summary>
/// 创建会议室层级 响应体
/// <para>该接口用于创建会议室层级。</para>
/// <para>接口ID：7160517357591986179</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/vc-v1/room_level/create</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fvc-v1%2froom_level%2fcreate</para>
/// </summary>
public record PostVcV1RoomLevelsResponseDto
{
    /// <summary>
    /// <para>层级详情</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("room_level")]
    public PostVcV1RoomLevelsResponseDtoRoomLevel? RoomLevel { get; set; }

    /// <summary>
    /// <para>层级详情</para>
    /// </summary>
    public record PostVcV1RoomLevelsResponseDtoRoomLevel
    {
        /// <summary>
        /// <para>层级ID</para>
        /// <para>必填：否</para>
        /// <para>示例值：层级ID</para>
        /// </summary>
        [JsonPropertyName("room_level_id")]
        public string? RoomLevelId { get; set; }

        /// <summary>
        /// <para>层级名称</para>
        /// <para>必填：否</para>
        /// <para>示例值：测试层级</para>
        /// </summary>
        [JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// <para>父层级ID</para>
        /// <para>必填：否</para>
        /// <para>示例值：omb_4ad1a2c7a2fbc5fc9570f38456931293</para>
        /// </summary>
        [JsonPropertyName("parent_id")]
        public string? ParentId { get; set; }

        /// <summary>
        /// <para>层级路径</para>
        /// <para>必填：否</para>
        /// <para>示例值：[omb_8d020b12fe49e82847c2af3c193d5754,omb_8d020b12fe49e82847c2af3c193d5754]</para>
        /// </summary>
        [JsonPropertyName("path")]
        public string[]? Path { get; set; }

        /// <summary>
        /// <para>是否有子层级</para>
        /// <para>必填：否</para>
        /// <para>示例值：false</para>
        /// </summary>
        [JsonPropertyName("has_child")]
        public bool? HasChild { get; set; }

        /// <summary>
        /// <para>自定义层级ID</para>
        /// <para>必填：否</para>
        /// <para>示例值：10000</para>
        /// </summary>
        [JsonPropertyName("custom_group_id")]
        public string? CustomGroupId { get; set; }
    }
}
