using Newtonsoft.Json;
namespace FeishuNetSdk.MeetingRoom.Spec;
/// <summary>
/// 创建会议室 请求体
/// <para>该接口用于创建会议室。</para>
/// <para>接口ID：6907569523177799681</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/historic-version/meeting_room-v1/api-reference/create-meeting-room</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuITNwYjLyUDM24iM1AjN</para>
/// </summary>
public record PostMeetingRoomRoomCreateBodyDto
{
    /// <summary>
    /// <para>会议室所在的建筑ID</para>
    /// <para>必填：是</para>
    /// </summary>
    [JsonProperty("building_id")]
    public string BuildingId { get; set; } = string.Empty;

    /// <summary>
    /// <para>会议室所在的建筑楼层</para>
    /// <para>必填：是</para>
    /// </summary>
    [JsonProperty("floor")]
    public string Floor { get; set; } = string.Empty;

    /// <summary>
    /// <para>会议室名称</para>
    /// <para>必填：是</para>
    /// </summary>
    [JsonProperty("name")]
    public string Name { get; set; } = string.Empty;

    /// <summary>
    /// <para>容量</para>
    /// <para>必填：是</para>
    /// </summary>
    [JsonProperty("capacity")]
    public int Capacity { get; set; }

    /// <summary>
    /// <para>是否禁用</para>
    /// <para>必填：是</para>
    /// </summary>
    [JsonProperty("is_disabled")]
    public bool IsDisabled { get; set; }

    /// <summary>
    /// <para>租户自定义会议室ID</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonProperty("custom_room_id")]
    public string? CustomRoomId { get; set; }
}
