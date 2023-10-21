using Newtonsoft.Json;
namespace FeishuNetSdk.Vc;
/// <summary>
/// 创建签到板部署码 请求体
/// <para>创建一个范围内的签到板部署码</para>
/// <para>接口ID：7070073879629430788</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/historic-version/meeting_room-v1/room_config/set_checkboard_access_code</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fvc-v1%2froom_config%2fset_checkboard_access_code</para>
/// </summary>
public record PostVcV1RoomConfigsSetCheckboardAccessCodeBodyDto
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
    [JsonProperty("scope")]
    public int Scope { get; set; }

    /// <summary>
    /// <para>国家/地区ID scope为2，3时需要此参数</para>
    /// <para>必填：否</para>
    /// <para>示例值：1</para>
    /// </summary>
    [JsonProperty("country_id")]
    public string? CountryId { get; set; }

    /// <summary>
    /// <para>城市ID scope为3时需要此参数</para>
    /// <para>必填：否</para>
    /// <para>示例值：2</para>
    /// </summary>
    [JsonProperty("district_id")]
    public string? DistrictId { get; set; }

    /// <summary>
    /// <para>建筑ID scope为4，5时需要此参数</para>
    /// <para>必填：否</para>
    /// <para>示例值：3</para>
    /// </summary>
    [JsonProperty("building_id")]
    public string? BuildingId { get; set; }

    /// <summary>
    /// <para>楼层 scope为5时需要此参数</para>
    /// <para>必填：否</para>
    /// <para>示例值：4</para>
    /// </summary>
    [JsonProperty("floor_name")]
    public string? FloorName { get; set; }

    /// <summary>
    /// <para>会议室ID scope为6时需要此参数</para>
    /// <para>必填：否</para>
    /// <para>示例值：67687262867363</para>
    /// </summary>
    [JsonProperty("room_id")]
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
    [JsonProperty("valid_day")]
    public int ValidDay { get; set; }
}
