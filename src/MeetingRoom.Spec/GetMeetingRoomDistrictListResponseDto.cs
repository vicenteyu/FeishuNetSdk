// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-06-24
// ************************************************************************
// <copyright file="GetMeetingRoomDistrictListResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>获取城市列表 响应体</summary>
// ************************************************************************
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
    [JsonPropertyName("districts")]
    public District[]? Districts { get; set; }

    /// <summary></summary>
    public record District
    {
        /// <summary>
        /// <para>城市ID</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("district_id")]
        public string? DistrictId { get; set; }

        /// <summary>
        /// <para>城市名称</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("name")]
        public string? Name { get; set; }
    }
}
