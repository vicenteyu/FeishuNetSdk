// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-08-01
// ************************************************************************
// <copyright file="PostSheetsV3SpreadsheetsBySpreadsheetTokenSheetsBySheetIdFloatImagesResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>创建浮动图片 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Ccm;
/// <summary>
/// 创建浮动图片 响应体
/// <para>根据传入的参数创建一张浮动图片。Float_image_token （[上传图片至表格后得到](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/drive-v1/media/upload_all)）和range（只支持一个单元格） 必填。Float_image_id 可选，不填的话会默认生成，长度为10，由 0-9、a-z、A-Z 组合生成。表格内不重复的图片（浮动图片+单元格图片）总数不超过4000。width 和 height 为图片展示的宽高，可选，不填的话会使用图片的真实宽高。offset_x 和 offset_y 为图片左上角距离所在单元格左上角的偏移，可选，默认为 0。</para>
/// <para>接口ID：6976178542817230851</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/docs/sheets-v3/spreadsheet-sheet-float_image/create</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuUDN04SN0QjL1QDN%2fsheets-v3%2fspreadsheet-sheet-float_image%2fcreate</para>
/// </summary>
public record PostSheetsV3SpreadsheetsBySpreadsheetTokenSheetsBySheetIdFloatImagesResponseDto
{
    /// <summary>
    /// <para>浮动图片返回值</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("float_image")]
    public FloatImageSuffix? FloatImage { get; set; }

    /// <summary></summary>
    public record FloatImageSuffix
    {
        /// <summary>
        /// <para>浮动图片 id</para>
        /// <para>必填：否</para>
        /// <para>示例值：ye06SS14ph</para>
        /// </summary>
        [JsonPropertyName("float_image_id")]
        public string? FloatImageId { get; set; }

        /// <summary>
        /// <para>【更新时不用传，创建需要】浮动图片 token，需要先上传图片到表格获得此 token 之后再进行浮动图片的相关操作</para>
        /// <para>必填：否</para>
        /// <para>示例值：boxbcbQsaSqIXsxxxxx1HCPJFbh</para>
        /// </summary>
        [JsonPropertyName("float_image_token")]
        public string? FloatImageToken { get; set; }

        /// <summary>
        /// <para>浮动图片的左上角单元格定位，只支持一个单元格</para>
        /// <para>必填：否</para>
        /// <para>示例值：0b**12!A1:A1</para>
        /// </summary>
        [JsonPropertyName("range")]
        public string? Range { get; set; }

        /// <summary>
        /// <para>浮动图片的宽度，大于等于 20px</para>
        /// <para>必填：否</para>
        /// <para>示例值：100</para>
        /// </summary>
        [JsonPropertyName("width")]
        public float? Width { get; set; }

        /// <summary>
        /// <para>浮动图片的高度，大于等于 20px</para>
        /// <para>必填：否</para>
        /// <para>示例值：100</para>
        /// </summary>
        [JsonPropertyName("height")]
        public float? Height { get; set; }

        /// <summary>
        /// <para>浮动图片左上角所在位置相对于所在单元格左上角的横向偏移，大于等于0且小于所在单元格的宽度</para>
        /// <para>必填：否</para>
        /// <para>示例值：0</para>
        /// </summary>
        [JsonPropertyName("offset_x")]
        public float? OffsetX { get; set; }

        /// <summary>
        /// <para>浮动图片左上角所在位置相对于所在单元格左上角的纵向偏移，大于等于0且小于所在单元格的高度</para>
        /// <para>必填：否</para>
        /// <para>示例值：0</para>
        /// </summary>
        [JsonPropertyName("offset_y")]
        public float? OffsetY { get; set; }
    }
}
