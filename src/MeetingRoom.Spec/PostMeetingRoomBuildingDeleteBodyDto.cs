namespace FeishuNetSdk.MeetingRoom.Spec;
/// <summary>
/// 删除建筑物 请求体
/// <para>该接口用于删除建筑物（办公大楼）。</para>
/// <para>接口ID：6907569742384005122</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/historic-version/meeting_room-v1/api-reference/delete-building</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuMzMxYjLzMTM24yMzEjN</para>
/// </summary>
public record PostMeetingRoomBuildingDeleteBodyDto
{
    /// <summary>
    /// <para>要删除的建筑ID</para>
    /// <para>必填：是</para>
    /// </summary>
    [JsonPropertyName("building_id")]
    public string BuildingId { get; set; } = string.Empty;
}
