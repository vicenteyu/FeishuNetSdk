namespace FeishuNetSdk.MeetingRoom.Spec;
/// <summary>
/// 查询建筑物ID 响应体
/// <para>该接口用于根据租户自定义建筑 ID 查询建筑 ID。</para>
/// <para>接口ID：6907569745299374082</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/historic-version/meeting_room-v1/api-reference/obtain-building-id</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuQzMxYjL0MTM24CNzEjN</para>
/// </summary>
public record GetMeetingRoomBuildingBatchGetIdResponseDto
{
    /// <summary>
    /// <para>建筑列表</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("buildings")]
    public Building[]? Buildings { get; set; }

    /// <summary></summary>
    public record Building
    {
        /// <summary>
        /// <para>建筑物ID</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("building_id")]
        public string? BuildingId { get; set; }

        /// <summary>
        /// <para>租户自定义建筑物ID</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("custom_building_id")]
        public string? CustomBuildingId { get; set; }
    }
}
