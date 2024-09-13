// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-08-01
// ************************************************************************
// <copyright file="PatchSheetsV3SpreadsheetsBySpreadsheetTokenSheetsBySheetIdFloatImagesByFloatImageIdResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>更新浮动图片 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Ccm;
/// <summary>
/// 更新浮动图片 响应体
/// <para>更新已有的浮动图片位置和宽高。</para>
/// <para>接口ID：6976178542817280003</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/docs/sheets-v3/spreadsheet-sheet-float_image/patch</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuUDN04SN0QjL1QDN%2fsheets-v3%2fspreadsheet-sheet-float_image%2fpatch</para>
/// </summary>
public record PatchSheetsV3SpreadsheetsBySpreadsheetTokenSheetsBySheetIdFloatImagesByFloatImageIdResponseDto
{
    /// <summary>
    /// <para>浮动图片的相关参数</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("float_image")]
    public FloatImageSuffix? FloatImage { get; set; }

    /// <summary>
    /// <para>浮动图片的相关参数</para>
    /// </summary>
    public record FloatImageSuffix
    {
        /// <summary>
        /// <para>浮动图片的唯一标识。用于对图片进行增删改查操作。</para>
        /// <para>必填：否</para>
        /// <para>示例值：ye06SS14ph</para>
        /// </summary>
        [JsonPropertyName("float_image_id")]
        public string? FloatImageId { get; set; }

        /// <summary>
        /// <para>浮动图片的 token，用于图片的上传和下载操作。你可通过该 token，调用[下载素材](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/drive-v1/media/download)接口下载图片。</para>
        /// <para>必填：否</para>
        /// <para>示例值：boxbcbQsaSqIXsxxxxx1HCPJFbh</para>
        /// </summary>
        [JsonPropertyName("float_image_token")]
        public string? FloatImageToken { get; set; }

        /// <summary>
        /// <para>浮动图片左上角所在单元格位置</para>
        /// <para>必填：否</para>
        /// <para>示例值：ahgsch!A1:A1</para>
        /// </summary>
        [JsonPropertyName("range")]
        public string? Range { get; set; }

        /// <summary>
        /// <para>浮动图片的宽度，单位为像素。</para>
        /// <para>必填：否</para>
        /// <para>示例值：100</para>
        /// </summary>
        [JsonPropertyName("width")]
        public float? Width { get; set; }

        /// <summary>
        /// <para>浮动图片的高度，单位为像素。</para>
        /// <para>必填：否</para>
        /// <para>示例值：100</para>
        /// </summary>
        [JsonPropertyName("height")]
        public float? Height { get; set; }

        /// <summary>
        /// <para>浮动图片左上角距离所在单元格左上角的横向偏移，单位为像素。</para>
        /// <para>必填：否</para>
        /// <para>示例值：0</para>
        /// </summary>
        [JsonPropertyName("offset_x")]
        public float? OffsetX { get; set; }

        /// <summary>
        /// <para>浮动图片左上角距离所在单元格左上角的纵向偏移，单位为像素。</para>
        /// <para>必填：否</para>
        /// <para>示例值：0</para>
        /// </summary>
        [JsonPropertyName("offset_y")]
        public float? OffsetY { get; set; }
    }
}
