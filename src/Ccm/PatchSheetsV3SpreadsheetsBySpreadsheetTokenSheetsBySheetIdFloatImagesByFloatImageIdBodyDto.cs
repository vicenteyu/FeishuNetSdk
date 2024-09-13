// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-08-01
// ************************************************************************
// <copyright file="PatchSheetsV3SpreadsheetsBySpreadsheetTokenSheetsBySheetIdFloatImagesByFloatImageIdBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>更新浮动图片 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Ccm;
/// <summary>
/// 更新浮动图片 请求体
/// <para>更新已有的浮动图片位置和宽高。</para>
/// <para>接口ID：6976178542817280003</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/docs/sheets-v3/spreadsheet-sheet-float_image/patch</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuUDN04SN0QjL1QDN%2fsheets-v3%2fspreadsheet-sheet-float_image%2fpatch</para>
/// </summary>
public record PatchSheetsV3SpreadsheetsBySpreadsheetTokenSheetsBySheetIdFloatImagesByFloatImageIdBodyDto
{
    /// <summary>
    /// <para>在本更新接口中，该参数无需传入。</para>
    /// <para>必填：否</para>
    /// <para>示例值：boxcnrHpsg1QDqXAAAyachabcef</para>
    /// </summary>
    [JsonPropertyName("float_image_token")]
    public string? FloatImageToken { get; set; }

    /// <summary>
    /// <para>浮动图片左上角所在单元格位置，只允许单个单元格的形式，如 "ahgsch!A1:A1"。了解更多，参考[浮动图片使用指南](https://open.feishu.cn/document/ukTMukTMukTM/uUDN04SN0QjL1QDN/sheets-v3/spreadsheet-sheet-float_image/float-image-user-guide)。</para>
    /// <para>必填：否</para>
    /// <para>示例值：ahgsch!A1:A1</para>
    /// </summary>
    [JsonPropertyName("range")]
    public string? Range { get; set; }

    /// <summary>
    /// <para>浮动图片的宽度，单位为像素。不传会默认采用图片实际宽度，如果传则需要大于等于 20 像素。了解更多，参考[浮动图片使用指南](https://open.feishu.cn/document/ukTMukTMukTM/uUDN04SN0QjL1QDN/sheets-v3/spreadsheet-sheet-float_image/float-image-user-guide)。</para>
    /// <para>必填：否</para>
    /// <para>示例值：100</para>
    /// </summary>
    [JsonPropertyName("width")]
    public float? Width { get; set; }

    /// <summary>
    /// <para>浮动图片的高度，单位为像素。不传会默认采用图片实际高度，如果传则需要大于等于 20 像素。了解更多，参考[浮动图片使用指南](https://open.feishu.cn/document/ukTMukTMukTM/uUDN04SN0QjL1QDN/sheets-v3/spreadsheet-sheet-float_image/float-image-user-guide)。</para>
    /// <para>必填：否</para>
    /// <para>示例值：100</para>
    /// </summary>
    [JsonPropertyName("height")]
    public float? Height { get; set; }

    /// <summary>
    /// <para>浮动图片左上角距离所在单元格左上角的横向偏移，单位为像素，默认为 0，设置的值需要大于等于 0、小于浮动图片左上角所在单元格的宽度。了解更多，参考[浮动图片使用指南](https://open.feishu.cn/document/ukTMukTMukTM/uUDN04SN0QjL1QDN/sheets-v3/spreadsheet-sheet-float_image/float-image-user-guide)。</para>
    /// <para>必填：否</para>
    /// <para>示例值：0</para>
    /// </summary>
    [JsonPropertyName("offset_x")]
    public float? OffsetX { get; set; }

    /// <summary>
    /// <para>浮动图片左上角距离所在单元格左上角的纵向偏移，单位为像素，默认为 0。设置的值需要大于等于 0、小于浮动图片左上角所在单元格的高度。了解更多，参考[浮动图片使用指南](https://open.feishu.cn/document/ukTMukTMukTM/uUDN04SN0QjL1QDN/sheets-v3/spreadsheet-sheet-float_image/float-image-user-guide)。</para>
    /// <para>必填：否</para>
    /// <para>示例值：0</para>
    /// </summary>
    [JsonPropertyName("offset_y")]
    public float? OffsetY { get; set; }
}
