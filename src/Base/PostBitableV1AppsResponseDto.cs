// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-06-24
// ************************************************************************
// <copyright file="PostBitableV1AppsResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>创建多维表格 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Base;
/// <summary>
/// 创建多维表格 响应体
/// <para>在指定文件夹中创建一个多维表格，包含一个空白的数据表。</para>
/// <para>接口ID：7047733935745007620</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/docs/bitable-v1/app/create</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fbitable-v1%2fapp%2fcreate</para>
/// </summary>
public record PostBitableV1AppsResponseDto
{
    /// <summary>
    /// <para>返回响应体</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("app")]
    public PostBitableV1AppsResponseDtoApp? App { get; set; }

    /// <summary>
    /// <para>返回响应体</para>
    /// </summary>
    public record PostBitableV1AppsResponseDtoApp
    {
        /// <summary>
        /// <para>多维表格的唯一标识 app_token</para>
        /// <para>必填：否</para>
        /// <para>示例值：\-</para>
        /// </summary>
        [JsonPropertyName("app_token")]
        public string? AppToken { get; set; }

        /// <summary>
        /// <para>多维表格的名称</para>
        /// <para>必填：否</para>
        /// <para>示例值：\-</para>
        /// </summary>
        [JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// <para>多维表格 App 归属文件夹</para>
        /// <para>必填：否</para>
        /// <para>示例值：\-</para>
        /// </summary>
        [JsonPropertyName("folder_token")]
        public string? FolderToken { get; set; }

        /// <summary>
        /// <para>多维表格 App 的 URL 链接</para>
        /// <para>必填：否</para>
        /// <para>示例值：\-</para>
        /// </summary>
        [JsonPropertyName("url")]
        public string? Url { get; set; }

        /// <summary>
        /// <para>默认创建的数据表 ID</para>
        /// <para>必填：否</para>
        /// <para>示例值：tblEtaUgtZIabcef</para>
        /// </summary>
        [JsonPropertyName("default_table_id")]
        public string? DefaultTableId { get; set; }

        /// <summary>
        /// <para>文档时区</para>
        /// <para>必填：否</para>
        /// <para>示例值：Asia/Beijing</para>
        /// </summary>
        [JsonPropertyName("time_zone")]
        public string? TimeZone { get; set; }
    }
}
