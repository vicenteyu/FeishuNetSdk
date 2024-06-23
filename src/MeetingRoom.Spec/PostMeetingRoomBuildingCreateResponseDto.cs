// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-06-24
// ************************************************************************
// <copyright file="PostMeetingRoomBuildingCreateResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>创建建筑物 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.MeetingRoom.Spec;
/// <summary>
/// 创建建筑物 响应体
/// <para>该接口对应管理后台的添加建筑，添加楼层的功能，可用于创建建筑物和建筑物的楼层信息。</para>
/// <para>接口ID：6907569524099760129</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/historic-version/meeting_room-v1/api-reference/create-building</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuATNwYjLwUDM24CM1AjN</para>
/// </summary>
public record PostMeetingRoomBuildingCreateResponseDto
{
    /// <summary>
    /// <para>成功创建的建筑ID</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("building_id")]
    public string? BuildingId { get; set; }
}
