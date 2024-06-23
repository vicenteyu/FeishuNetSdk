// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-06-24
// ************************************************************************
// <copyright file="PostVcV1RoomsSearchBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>搜索会议室 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Vc;
/// <summary>
/// 搜索会议室 请求体
/// <para>该接口可以用来搜索会议室，支持使用关键词进行搜索，也支持使用自定义会议室 ID 进行查询。该接口只会返回用户有预定权限的会议室列表。</para>
/// <para>接口ID：7160517357591937027</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/vc-v1/room/search</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fvc-v1%2froom%2fsearch</para>
/// </summary>
public record PostVcV1RoomsSearchBodyDto
{
    /// <summary>
    /// <para>用于查询指定会议室的租户自定义会议室ID列表，优先使用该字段进行查询</para>
    /// <para>必填：否</para>
    /// <para>示例值：["10001"]</para>
    /// </summary>
    [JsonPropertyName("custom_room_ids")]
    public string[]? CustomRoomIds { get; set; }

    /// <summary>
    /// <para>会议室搜索关键词（当custom_room_ids为空时，使用该字段进行查询）</para>
    /// <para>必填：否</para>
    /// <para>示例值：测试会议室</para>
    /// </summary>
    [JsonPropertyName("keyword")]
    public string? Keyword { get; set; }

    /// <summary>
    /// <para>在该会议室层级下进行搜索（当custom_room_ids为空时，使用该字段进行查询）</para>
    /// <para>必填：否</para>
    /// <para>示例值：omb_4ad1a2c7a2fbc5fc9570f38456931293</para>
    /// </summary>
    [JsonPropertyName("room_level_id")]
    public string? RoomLevelId { get; set; }

    /// <summary>
    /// <para>搜索会议室是否可以包括层级名称（当custom_room_ids为空时，使用 keyword 字段查询）</para>
    /// <para>必填：否</para>
    /// <para>示例值：true</para>
    /// </summary>
    [JsonPropertyName("search_level_name")]
    public bool? SearchLevelName { get; set; }

    /// <summary>
    /// <para>分页大小，该值默认为10，最大为100（当custom_room_ids为空时，使用该字段进行查询）</para>
    /// <para>必填：否</para>
    /// <para>示例值：10</para>
    /// <para>最大值：100</para>
    /// <para>最小值：1</para>
    /// <para>默认值：10</para>
    /// </summary>
    [JsonPropertyName("page_size")]
    public int? PageSize { get; set; }

    /// <summary>
    /// <para>分页标记，第一次请求不填，表示从头开始遍历；分页查询结果还有更多项时会同时返回新的 page_token，下次遍历可采用该 page_token 获取查询结果</para>
    /// <para>必填：否</para>
    /// <para>示例值：0</para>
    /// </summary>
    [JsonPropertyName("page_token")]
    public string? PageToken { get; set; }
}
