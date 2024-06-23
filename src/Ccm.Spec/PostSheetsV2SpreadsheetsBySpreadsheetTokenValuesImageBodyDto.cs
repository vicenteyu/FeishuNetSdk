// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-06-24
// ************************************************************************
// <copyright file="PostSheetsV2SpreadsheetsBySpreadsheetTokenValuesImageBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>写入图片 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Ccm.Spec;
/// <summary>
/// 写入图片 请求体
/// <para>向电子表格某个工作表的单个指定单元格写入图片，支持传入图片的二进制流，支持多种图片格式。</para>
/// <para>接口ID：6907568073252585474</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/docs/sheets-v3/data-operation/write-images</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuUDNxYjL1QTM24SN0EjN</para>
/// </summary>
public record PostSheetsV2SpreadsheetsBySpreadsheetTokenValuesImageBodyDto
{
    /// <summary>
    /// <para>指定写入图片的单元格。格式为`&lt;sheetId&gt;!&lt;开始单元格&gt;:&lt;结束单元格&gt;`。其中：</para>
    /// <para>- `sheetId` 为工作表 ID，通过[获取工作表](https://open.feishu.cn/document/ukTMukTMukTM/uUDN04SN0QjL1QDN/sheets-v3/spreadsheet-sheet/query) 获取</para>
    /// <para>- `&lt;开始单元格&gt;:&lt;结束单元格&gt;` 用于指定单元格，开始单元格与结束单元格需保持一致，如：`A1:A1`。其中，数字表示行索引，字母表示列索引。如 `A1:A1` 表示该工作表第 1 行 A 列的单元格。了解更多，参考[电子表格概述](https://open.feishu.cn/document/ukTMukTMukTM/uATMzUjLwEzM14CMxMTN/overview)</para>
    /// <para>必填：是</para>
    /// </summary>
    [JsonPropertyName("range")]
    public string Range { get; set; } = string.Empty;

    /// <summary>
    /// <para>需要写入的图片的二进制流，支持 "PNG"、"JPEG"、"JPG"、"GIF"、"BMP"、"JFIF"、"EXIF"、 "TIFF"、"BPG"、"HEIC" 等图片格式。</para>
    /// <para>必填：是</para>
    /// </summary>
    [JsonPropertyName("image")]
    public byte[] Image { get; set; } = Array.Empty<byte>();

    /// <summary>
    /// <para>写入的图片名称，需加后缀名。</para>
    /// <para>必填：是</para>
    /// </summary>
    [JsonPropertyName("name")]
    public string Name { get; set; } = string.Empty;
}
