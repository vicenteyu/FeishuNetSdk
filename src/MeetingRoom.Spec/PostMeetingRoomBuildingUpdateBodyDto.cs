namespace FeishuNetSdk.MeetingRoom.Spec;
/// <summary>
/// 更新建筑物 请求体
/// <para>该接口用于编辑建筑信息，添加楼层，删除楼层，编辑楼层信息。</para>
/// <para>接口ID：6907569744330932225</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/historic-version/meeting_room-v1/api-reference/update-building</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuETNwYjLxUDM24SM1AjN</para>
/// </summary>
public record PostMeetingRoomBuildingUpdateBodyDto
{
    /// <summary>
    /// <para>要更新的建筑ID</para>
    /// <para>必填：是</para>
    /// </summary>
    [JsonPropertyName("building_id")]
    public string BuildingId { get; set; } = string.Empty;

    /// <summary>
    /// <para>建筑名称</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// <para>楼层列表</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("floors")]
    public string[]? Floors { get; set; }

    /// <summary>
    /// <para>国家/地区ID</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("country_id")]
    public string? CountryId { get; set; }

    /// <summary>
    /// <para>城市ID</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("district_id")]
    public string? DistrictId { get; set; }

    /// <summary>
    /// <para>租户自定义建筑ID</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("custom_building_id")]
    public string? CustomBuildingId { get; set; }
}
