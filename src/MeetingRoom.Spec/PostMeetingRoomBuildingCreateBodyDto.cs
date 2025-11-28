// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-06-24
// ************************************************************************
// <copyright file="PostMeetingRoomBuildingCreateBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>创建建筑物 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.MeetingRoom.Spec;
/// <summary>
/// 创建建筑物 请求体
/// <para>该接口对应管理后台的添加建筑，添加楼层的功能，可用于创建建筑物和建筑物的楼层信息。</para>
/// <para>接口ID：6907569524099760129</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/historic-version/meeting_room-v1/api-reference/create-building</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuATNwYjLwUDM24CM1AjN</para>
/// </summary>
public record PostMeetingRoomBuildingCreateBodyDto
{
    /// <summary>
    /// <para>建筑名称</para>
    /// <para>必填：是</para>
    /// </summary>
    [JsonPropertyName("name")]
    public string Name { get; set; } = string.Empty;

    /// <summary>
    /// <para>楼层列表</para>
    /// <para>必填：是</para>
    /// </summary>
    [JsonPropertyName("floors")]
    public string[] Floors { get; set; } = [];

    /// <summary>
    /// <para>国家/地区ID</para>
    /// <para>必填：是</para>
    /// </summary>
    [JsonPropertyName("country_id")]
    public string CountryId { get; set; } = string.Empty;

    /// <summary>
    /// <para>城市ID</para>
    /// <para>必填：是</para>
    /// </summary>
    [JsonPropertyName("district_id")]
    public string DistrictId { get; set; } = string.Empty;

    /// <summary>
    /// <para>租户自定义建筑ID</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("custom_building_id")]
    public string? CustomBuildingId { get; set; }
}
