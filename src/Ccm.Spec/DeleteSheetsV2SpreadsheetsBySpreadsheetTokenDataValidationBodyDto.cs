using Newtonsoft.Json;
namespace FeishuNetSdk.Ccm.Spec;
/// <summary>
/// 删除下拉列表设置 请求体
/// <para>该接口根据 spreadsheetToken 、range 移除选定数据范围单元格的下拉列表设置，但保留选项文本。单个删除范围不超过5000单元格。单次请求range最大数量100个。</para>
/// <para>接口ID：6943917246700257282</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/docs/sheets-v3/datavalidation/delete-datavalidation</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuATMzUjLwEzM14CMxMTN%2fdatavalidation%2fdelete-datavalidation</para>
/// </summary>
public record DeleteSheetsV2SpreadsheetsBySpreadsheetTokenDataValidationBodyDto
{
    /// <summary>
    /// <para>范围数组，每个range 最大单元格数量5000，每个range独立执行，一个range的失败不影响其他range的执行。返回结果会返回每个range的执行结果</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonProperty("dataValidationRanges")]
    public DataValidationRange[]? DataValidationRanges { get; set; }

    /// <summary></summary>
    public record DataValidationRange
    {
        /// <summary>
        /// <para>查询范围，包含 sheetId 与单元格范围两部分，目前支持四种索引方式，详见[在线表格开发指南](https://open.feishu.cn/document/ukTMukTMukTM/uATMzUjLwEzM14CMxMTN/overview)</para>
        /// <para>必填：是</para>
        /// </summary>
        [JsonProperty("range")]
        public string Range { get; set; } = string.Empty;

        /// <summary>
        /// <para>指定需要删除的dataValidationIds</para>
        /// <para>必填：是</para>
        /// </summary>
        [JsonProperty("dataValidationIds")]
        public int[] DataValidationIds { get; set; } = Array.Empty<int>();
    }
}
