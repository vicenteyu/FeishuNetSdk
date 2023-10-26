using Newtonsoft.Json;
namespace FeishuNetSdk.MeetingRoom.Spec;
/// <summary>
/// 获取国家地区列表 响应体
/// <para>新建建筑时需要标明所处国家/地区，该接口用于获得系统预先提供的可供选择的国家 /地区列表。</para>
/// <para>接口ID：6907569524100808705</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/historic-version/meeting_room-v1/api-reference/obtain-country/region-list</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuQTNwYjL0UDM24CN1AjN</para>
/// </summary>
public record GetMeetingRoomCountryListResponseDto
{
    /// <summary>
    /// <para>国家地区列表</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonProperty("countries")]
    public Country[]? Countries { get; set; }

    /// <summary></summary>
    public record Country
    {
        /// <summary>
        /// <para>国家地区ID</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonProperty("country_id")]
        public string? CountryId { get; set; }

        /// <summary>
        /// <para>国家地区名称</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonProperty("name")]
        public string? Name { get; set; }
    }
}
