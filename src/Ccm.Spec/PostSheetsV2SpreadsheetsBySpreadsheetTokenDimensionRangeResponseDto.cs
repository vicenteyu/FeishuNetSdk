using Newtonsoft.Json;
namespace FeishuNetSdk.Ccm.Spec;
/// <summary>
/// 增加行列 响应体
/// <para>该接口用于根据 spreadsheetToken 和长度，在末尾增加空行/列；单次操作不超过5000行或列。</para>
/// <para>接口ID：6907569744333864961</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/docs/sheets-v3/sheet-rowcol/add-rows-or-columns</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuUjMzUjL1IzM14SNyMTN</para>
/// </summary>
public record PostSheetsV2SpreadsheetsBySpreadsheetTokenDimensionRangeResponseDto
{
    /// <summary>
    /// <para>增加的行/列数</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonProperty("addCount")]
    public int? AddCount { get; set; }

    /// <summary>
    /// <para>插入维度</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonProperty("majorDimension")]
    public string? MajorDimension { get; set; }
}
