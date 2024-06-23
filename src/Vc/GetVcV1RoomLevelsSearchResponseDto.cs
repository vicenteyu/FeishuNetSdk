// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-06-24
// ************************************************************************
// <copyright file="GetVcV1RoomLevelsSearchResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>搜索会议室层级 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Vc;
/// <summary>
/// 搜索会议室层级 响应体
/// <para>该接口可以用来搜索会议室层级，支持使用自定义会议室层级 ID 进行查询。</para>
/// <para>接口ID：7160517356095913988</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/vc-v1/room_level/search</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fvc-v1%2froom_level%2fsearch</para>
/// </summary>
public record GetVcV1RoomLevelsSearchResponseDto
{
    /// <summary>
    /// <para>层级ID列表</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("level_ids")]
    public string[]? LevelIds { get; set; }
}
