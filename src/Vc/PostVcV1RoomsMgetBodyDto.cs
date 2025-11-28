// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-06-24
// ************************************************************************
// <copyright file="PostVcV1RoomsMgetBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>批量查询会议室详情 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Vc;
/// <summary>
/// 批量查询会议室详情 请求体
/// <para>该接口可以使用会议室 ID 批量查询会议室详情。</para>
/// <para>接口ID：7160517356095946756</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/vc-v1/room/mget</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fvc-v1%2froom%2fmget</para>
/// </summary>
public record PostVcV1RoomsMgetBodyDto
{
    /// <summary>
    /// <para>会议室id列表</para>
    /// <para>必填：是</para>
    /// <para>示例值：["omm_4de32cf10a4358788ff4e09e37ebbf9b","omm_3c5dd7e09bac0c1758fcf9511bd1a771"]</para>
    /// </summary>
    [JsonPropertyName("room_ids")]
    public string[] RoomIds { get; set; } = [];
}
