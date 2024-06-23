// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-06-24
// ************************************************************************
// <copyright file="GetMeetingRoomBuildingListResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>获取建筑物列表 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.MeetingRoom.Spec;
/// <summary>
/// 获取建筑物列表 响应体
/// <para>该接口用于获取本企业下的建筑物（办公大楼）。</para>
/// <para>接口ID：6907569523176636417</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/historic-version/meeting_room-v1/api-reference/obtain-building-list</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fugzNyUjL4cjM14CO3ITN</para>
/// </summary>
public record GetMeetingRoomBuildingListResponseDto
{
    /// <summary>
    /// <para>分页标记，存在下一页时返回</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("page_token")]
    public string? PageToken { get; set; }

    /// <summary>
    /// <para>存在下一页时，该值为 true，否则为 false</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("has_more")]
    public bool? HasMore { get; set; }

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
        /// <para>建筑物 ID</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("building_id")]
        public string? BuildingId { get; set; }

        /// <summary>
        /// <para>建筑物的相关描述</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// <para>属于当前建筑物的所有楼层列表</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("floors")]
        public string[]? Floors { get; set; }

        /// <summary>
        /// <para>建筑物名称</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// <para>所属国家 ID</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("country_id")]
        public string? CountryId { get; set; }

        /// <summary>
        /// <para>所属城市 ID</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("district_id")]
        public string? DistrictId { get; set; }
    }
}
