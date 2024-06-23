// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-06-24
// ************************************************************************
// <copyright file="GetCorehrV1SubregionsBySubregionIdResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>查询单条城市/区域信息 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.FeishuPeople;
/// <summary>
/// 查询单条城市/区域信息 响应体
/// <para>查询单条城市/区域信息。</para>
/// <para>接口ID：7072978219503550465</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/corehr-v1/basic-infomation/location_data/get-3</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fcorehr-v1%2fsubregion%2fget</para>
/// </summary>
public record GetCorehrV1SubregionsBySubregionIdResponseDto
{
    /// <summary>
    /// <para>城市/区域信息</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("subregion")]
    public GetCorehrV1SubregionsBySubregionIdResponseDtoSubregion? Subregion { get; set; }

    /// <summary>
    /// <para>城市/区域信息</para>
    /// </summary>
    public record GetCorehrV1SubregionsBySubregionIdResponseDtoSubregion
    {
        /// <summary>
        /// <para>城市/区域id</para>
        /// <para>必填：是</para>
        /// <para>示例值：12</para>
        /// </summary>
        [JsonPropertyName("id")]
        public string Id { get; set; } = string.Empty;

        /// <summary>
        /// <para>城市/区域名称</para>
        /// <para>必填：是</para>
        /// </summary>
        [JsonPropertyName("name")]
        public I18n[] Names { get; set; } = Array.Empty<I18n>();

        /// <summary>
        /// <para>城市/区域名称</para>
        /// </summary>
        public record I18n
        {
            /// <summary>
            /// <para>名称信息的语言</para>
            /// <para>必填：是</para>
            /// <para>示例值：zh-CN</para>
            /// </summary>
            [JsonPropertyName("lang")]
            public string Lang { get; set; } = string.Empty;

            /// <summary>
            /// <para>名称信息的内容</para>
            /// <para>必填：是</para>
            /// <para>示例值：张三</para>
            /// </summary>
            [JsonPropertyName("value")]
            public string Value { get; set; } = string.Empty;
        }

        /// <summary>
        /// <para>所属省份/行政区id，详细信息可通过【查询省份/行政区信息】接口查询获得</para>
        /// <para>必填：是</para>
        /// <para>示例值：12</para>
        /// </summary>
        [JsonPropertyName("subdivision_id")]
        public string SubdivisionId { get; set; } = string.Empty;

        /// <summary>
        /// <para>上级城市/区域区id</para>
        /// <para>必填：否</para>
        /// <para>示例值：12</para>
        /// </summary>
        [JsonPropertyName("superior_subregion_id")]
        public string? SuperiorSubregionId { get; set; }
    }
}
