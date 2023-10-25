using Newtonsoft.Json;
namespace FeishuNetSdk.Ccm.Spec;
/// <summary>
/// 删除下拉列表设置 响应体
/// <para>该接口根据 spreadsheetToken 、range 移除选定数据范围单元格的下拉列表设置，但保留选项文本。单个删除范围不超过5000单元格。单次请求range最大数量100个。</para>
/// <para>接口ID：6943917246700257282</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/docs/sheets-v3/datavalidation/delete-datavalidation</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuATMzUjLwEzM14CMxMTN%2fdatavalidation%2fdelete-datavalidation</para>
/// </summary>
public record DeleteSheetsV2SpreadsheetsBySpreadsheetTokenDataValidationResponseDto
{
    /// <summary>
    /// <para>状态码，0代表成功</para>
    /// <para>必填：是</para>
    /// </summary>
    [JsonProperty("code")]
    public int Code { get; set; }

    /// <summary>
    /// <para>状态信息</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonProperty("msg")]
    public string? Msg { get; set; }

    /// <summary>
    /// <para>array</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonProperty("rangeResults")]
    public string? RangeResults { get; set; }

    /// <summary>
    /// <para>执行的range,与请求入参中的range 对应</para>
    /// <para>必填：是</para>
    /// </summary>
    [JsonProperty("range")]
    public string Range { get; set; } = string.Empty;

    /// <summary>
    /// <para>结果信息</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonProperty("msg")]
    public string? Msg { get; set; }

    /// <summary>
    /// <para>执行结果</para>
    /// <para>必填：是</para>
    /// </summary>
    [JsonProperty("success")]
    public bool Success { get; set; }

    /// <summary>
    /// <para>影响的单元格数量</para>
    /// <para>必填：是</para>
    /// </summary>
    [JsonProperty("updatedCells")]
    public int UpdatedCells { get; set; }
}
