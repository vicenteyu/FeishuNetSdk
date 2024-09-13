// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-08-01
// ************************************************************************
// <copyright file="PostSheetsV3SpreadsheetsBySpreadsheetTokenSheetsBySheetIdFloatImagesBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>创建浮动图片 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Ccm;
/// <summary>
/// 创建浮动图片 请求体
/// <para>在电子表格工作表的指定位置创建一张浮动图片。</para>
/// <para>## 前提条件</para>
/// <para>你已调用[上传素材](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/drive-v1/media/upload_all)或[分片上传素材](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/drive-v1/media/upload_prepare)上传图片至表格并获取了图片的 `file_token`，作为本接口中图片的 `float_image_token`。</para>
/// <para>## 使用限制</para>
/// <para>单个电子表格最多支持放置 4,000 张不同 token 的图片，即表格内不重复的图片（包括浮动图片和单元格图片）总数不超过 4,000 张。将相同 token 的图片多次放置在表格的不同位置，数量上仅算一张图片。</para>
/// <para>接口ID：6976178542817230851</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/docs/sheets-v3/spreadsheet-sheet-float_image/create</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuUDN04SN0QjL1QDN%2fsheets-v3%2fspreadsheet-sheet-float_image%2fcreate</para>
/// </summary>
public record PostSheetsV3SpreadsheetsBySpreadsheetTokenSheetsBySheetIdFloatImagesBodyDto
{
    /// <summary>
    /// <para>工作表内浮动图片的唯一标识。可不传由系统自动生成，也可选择自定义。</para>
    /// <para>**数据校验规则**：</para>
    /// <para>长度为 10，由 0-9、a-z、A-Z 组合而成。</para>
    /// <para>必填：否</para>
    /// <para>示例值：ye06SS14ph</para>
    /// </summary>
    [JsonPropertyName("float_image_id")]
    public string? FloatImageId { get; set; }

    /// <summary>
    /// <para>浮动图片的 token。通过[上传素材](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/drive-v1/media/upload_all)或[分片上传素材](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/drive-v1/media/upload_prepare)上传图片至表格，获得素材的 `file_token`，即为 float_image_token。</para>
    /// <para>**注意**：</para>
    /// <para>该参数必填，请忽略左侧必填列的”否”。</para>
    /// <para>必填：否</para>
    /// <para>示例值：boxcnrHpsg1QDqXAAAyachabcef</para>
    /// </summary>
    [JsonPropertyName("float_image_token")]
    public string? FloatImageToken { get; set; }

    /// <summary>
    /// <para>浮动图片左上角所在单元格位置，只允许单个单元格的形式，如 "ahgsch!A1:A1"。了解更多，参考[浮动图片使用指南](https://open.feishu.cn/document/ukTMukTMukTM/uUDN04SN0QjL1QDN/sheets-v3/spreadsheet-sheet-float_image/float-image-user-guide)。</para>
    /// <para>**注意**：</para>
    /// <para>该参数必填，请忽略左侧必填列的”否”。</para>
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
