// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-06-24
// ************************************************************************
// <copyright file="PostVcV1RoomLevelsMgetBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>批量查询会议室层级详情 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Vc;
/// <summary>
/// 批量查询会议室层级详情 请求体
/// <para>该接口可以使用会议室层级 ID 批量查询会议室层级详情。</para>
/// <para>接口ID：7160517356095897604</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/vc-v1/room_level/mget</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fvc-v1%2froom_level%2fmget</para>
/// </summary>
public record PostVcV1RoomLevelsMgetBodyDto
{
    /// <summary>
    /// <para>层级ID列表</para>
    /// <para>必填：是</para>
    /// <para>示例值：["omb_4ad1a2c7a2fbc5fc9570f38456931293"]</para>
    /// </summary>
    [JsonPropertyName("level_ids")]
    public string[] LevelIds { get; set; } = Array.Empty<string>();
}
