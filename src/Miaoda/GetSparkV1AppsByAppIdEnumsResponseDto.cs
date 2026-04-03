// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2026-04-03
//
// Last Modified By : yxr
// Last Modified On : 2026-04-03
// ************************************************************************
// <copyright file="GetSparkV1AppsByAppIdEnumsResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>获取自定义枚举列表 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Miaoda;
/// <summary>
/// 获取自定义枚举列表 响应体
/// <para>获取应用下的自定义枚举列表，包括枚举名称、描述、枚举值列表等字段信息。</para>
/// <para>接口ID：7620858064161901775</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/spark-v1/app-enum/get_enum_list</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fspark-v1%2fapp-enum%2fget_enum_list</para>
/// </summary>
public record GetSparkV1AppsByAppIdEnumsResponseDto : IPageableResponse<GetSparkV1AppsByAppIdEnumsResponseDto.AppEnum>
{
    /// <summary>
    /// <para>是否还有更多项</para>
    /// <para>必填：是</para>
    /// <para>示例值：true</para>
    /// </summary>
    [JsonPropertyName("has_more")]
    public bool? HasMore { get; set; }

    /// <summary>
    /// <para>分页标记，当 has_more 为 true 时，会同时返回新的 page_token，否则不返回 page_token</para>
    /// <para>必填：是</para>
    /// <para>示例值：AQD9/Rn9eij9Pm39ED40/RD/cIFmu77WxpxPB/2oHfQLZ+G8JG6tK7+ZnHiT7COhD2hMSICh/eBl7cpzU6JEC3J7COKNe4jrQ8ExwBCR</para>
    /// </summary>
    [JsonPropertyName("page_token")]
    public string PageToken { get; set; } = string.Empty;

    /// <summary>
    /// <para>枚举列表</para>
    /// <para>必填：是</para>
    /// </summary>
    [JsonPropertyName("items")]
    public AppEnum[] Items { get; set; } = [];

    /// <summary>
    /// <para>枚举列表</para>
    /// </summary>
    public record AppEnum
    {
        /// <summary>
        /// <para>枚举名称</para>
        /// <para>必填：是</para>
        /// <para>示例值：enum_demo</para>
        /// <para>最大长度：9999</para>
        /// <para>最小长度：1</para>
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; } = string.Empty;

        /// <summary>
        /// <para>枚举描述</para>
        /// <para>必填：是</para>
        /// <para>示例值：enum_demo的描述</para>
        /// <para>最大长度：9999</para>
        /// <para>最小长度：1</para>
        /// </summary>
        [JsonPropertyName("description")]
        public string Description { get; set; } = string.Empty;

        /// <summary>
        /// <para>枚举值列表</para>
        /// <para>必填：是</para>
        /// </summary>
        [JsonPropertyName("options")]
        public string[] Options { get; set; } = [];

        /// <summary>
        /// <para>创建时间，毫秒时间戳</para>
        /// <para>必填：是</para>
        /// <para>示例值：1765524810744</para>
        /// <para>最大值：9765524810744</para>
        /// <para>最小值：1</para>
        /// </summary>
        [JsonPropertyName("created_at")]
        public long CreatedAt { get; set; }
    }
}
