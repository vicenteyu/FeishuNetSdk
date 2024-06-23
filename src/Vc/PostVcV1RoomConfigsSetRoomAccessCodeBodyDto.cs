// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-06-24
// ************************************************************************
// <copyright file="PostVcV1RoomConfigsSetRoomAccessCodeBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>创建会议室部署码 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Vc;
/// <summary>
/// 创建会议室部署码 请求体
/// <para>创建一个范围内的会议室部署码</para>
/// <para>接口ID：7070073879629447172</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/historic-version/meeting_room-v1/room_config/set_room_access_code</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fvc-v1%2froom_config%2fset_room_access_code</para>
/// </summary>
public record PostVcV1RoomConfigsSetRoomAccessCodeBodyDto
{
    /// <summary>
    /// <para>设置节点范围</para>
    /// <para>必填：是</para>
    /// <para>示例值：5</para>
    /// <para>可选值：<list type="bullet">
    /// <item>1：租户</item>
    /// <item>2：国家/地区</item>
    /// <item>3：城市</item>
    /// <item>4：建筑</item>
    /// <item>5：楼层</item>
    /// <item>6：会议室</item>
    /// </list></para>
    /// </summary>
    [JsonPropertyName("scope")]
    public int Scope { get; set; }

    /// <summary>
    /// <para>国家/地区ID scope为2，3时需要此参数</para>
    /// <para>必填：否</para>
    /// <para>示例值：1</para>
    /// </summary>
    [JsonPropertyName("country_id")]
    public string? CountryId { get; set; }

    /// <summary>
    /// <para>城市ID scope为3时需要此参数</para>
    /// <para>必填：否</para>
    /// <para>示例值：2</para>
    /// </summary>
    [JsonPropertyName("district_id")]
    public string? DistrictId { get; set; }

    /// <summary>
    /// <para>建筑ID scope为4，5时需要此参数</para>
    /// <para>必填：否</para>
    /// <para>示例值：3</para>
    /// </summary>
    [JsonPropertyName("building_id")]
    public string? BuildingId { get; set; }

    /// <summary>
    /// <para>楼层 scope为5时需要此参数</para>
    /// <para>必填：否</para>
    /// <para>示例值：4</para>
    /// </summary>
    [JsonPropertyName("floor_name")]
    public string? FloorName { get; set; }

    /// <summary>
    /// <para>会议室ID scope为6时需要此参数</para>
    /// <para>必填：否</para>
    /// <para>示例值：67687262867363</para>
    /// </summary>
    [JsonPropertyName("room_id")]
    public string? RoomId { get; set; }

    /// <summary>
    /// <para>有效天数</para>
    /// <para>必填：是</para>
    /// <para>示例值：1</para>
    /// <para>可选值：<list type="bullet">
    /// <item>1：1天</item>
    /// <item>7：7天</item>
    /// <item>30：30天</item>
    /// </list></para>
    /// </summary>
    [JsonPropertyName("valid_day")]
    public int ValidDay { get; set; }
}
