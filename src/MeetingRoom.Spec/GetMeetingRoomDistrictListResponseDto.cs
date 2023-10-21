using Newtonsoft.Json;
namespace FeishuNetSdk.MeetingRoom.Spec;
/// <summary>
/// 获取城市列表 响应体
/// <para>新建建筑时需要选择所处国家/地区，该接口用于获得系统预先提供的可供选择的城市列表。</para>
/// <para>接口ID：6907569523176947713</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/historic-version/meeting_room-v1/api-reference/obtain-city-list</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuUTNwYjL1UDM24SN1AjN</para>
/// </summary>
public record GetMeetingRoomDistrictListResponseDto
{
    /// <summary>
    /// <para>城市列表</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonProperty("districts")]
    public District[]? Districts { get; set; }

    public record District
    {
        /// <summary>
        /// <para>城市ID</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonProperty("district_id")]
        public string? DistrictId { get; set; }

        /// <summary>
        /// <para>城市名称</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonProperty("name")]
        public string? Name { get; set; }
    }
}
