using Newtonsoft.Json;
namespace FeishuNetSdk.MeetingRoom.Spec;
/// <summary>
/// 查询建筑物详情 响应体
/// <para>该接口用于获取指定建筑物的详细信息。</para>
/// <para>接口ID：6907569523177635841</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/historic-version/meeting_room-v1/api-reference/query-building-details</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fukzNyUjL5cjM14SO3ITN</para>
/// </summary>
public record GetMeetingRoomBuildingBatchGetResponseDto
{
    /// <summary>
    /// <para>建筑列表</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonProperty("buildings")]
    public Building[]? Buildings { get; set; }

    public record Building
    {
        /// <summary>
        /// <para>建筑物 ID</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonProperty("building_id")]
        public string? BuildingId { get; set; }

        /// <summary>
        /// <para>建筑物的相关描述</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonProperty("description")]
        public string? Description { get; set; }

        /// <summary>
        /// <para>属于当前建筑物的所有楼层列表</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonProperty("floors")]
        public string[]? Floors { get; set; }

        /// <summary>
        /// <para>建筑物名称</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonProperty("name")]
        public string? Name { get; set; }

        /// <summary>
        /// <para>所属国家 ID</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonProperty("country_id")]
        public string? CountryId { get; set; }

        /// <summary>
        /// <para>所属城市 ID</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonProperty("district_id")]
        public string? DistrictId { get; set; }
    }
}
