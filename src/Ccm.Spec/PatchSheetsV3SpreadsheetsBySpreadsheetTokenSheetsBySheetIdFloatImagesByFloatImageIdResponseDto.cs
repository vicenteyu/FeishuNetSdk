using Newtonsoft.Json;
namespace FeishuNetSdk.Ccm.Spec;
/// <summary>
/// 更新浮动图片 响应体
/// <para>更新已有的浮动图片位置和宽高，包括 range、width、height、offset_x 和 offset_y，不包括 float_image_id 和 float_image_token。{尝试一下}(url=/api/tools/api_explore/api_explore_config?project=sheets&version=v3&resource=spreadsheet.sheet.float_image&method=patch)</para>
/// <para>接口ID：6976178542817280003</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/docs/sheets-v3/spreadsheet-sheet-float_image/patch</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuUDN04SN0QjL1QDN%2fsheets-v3%2fspreadsheet-sheet-float_image%2fpatch</para>
/// </summary>
public record PatchSheetsV3SpreadsheetsBySpreadsheetTokenSheetsBySheetIdFloatImagesByFloatImageIdResponseDto
{
    /// <summary>
    /// <para>浮动图片信息</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonProperty("float_image")]
    public FloatImageSuffix? FloatImage { get; set; }

    public record FloatImageSuffix
    {
        /// <summary>
        /// <para>浮动图片 id</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonProperty("float_image_id")]
        public string? FloatImageId { get; set; }

        /// <summary>
        /// <para>【更新时不用传，创建需要】浮动图片 token，需要先上传图片到表格获得此 token 之后再进行浮动图片的相关操作</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonProperty("float_image_token")]
        public string? FloatImageToken { get; set; }

        /// <summary>
        /// <para>浮动图片的左上角单元格定位，只支持一个单元格</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonProperty("range")]
        public string? Range { get; set; }

        /// <summary>
        /// <para>浮动图片的宽度，大于等于 20px</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonProperty("width")]
        public float? Width { get; set; }

        /// <summary>
        /// <para>浮动图片的高度，大于等于 20px</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonProperty("height")]
        public float? Height { get; set; }

        /// <summary>
        /// <para>浮动图片左上角所在位置相对于所在单元格左上角的横向偏移，大于等于0且小于所在单元格的宽度</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonProperty("offset_x")]
        public float? OffsetX { get; set; }

        /// <summary>
        /// <para>浮动图片左上角所在位置相对于所在单元格左上角的纵向偏移，大于等于0且小于所在单元格的高度</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonProperty("offset_y")]
        public float? OffsetY { get; set; }
    }
}
