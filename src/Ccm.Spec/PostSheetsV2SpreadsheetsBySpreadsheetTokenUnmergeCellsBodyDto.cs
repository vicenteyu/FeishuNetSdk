using Newtonsoft.Json;
namespace FeishuNetSdk.Ccm.Spec;
/// <summary>
/// 拆分单元格 请求体
/// <para>该接口用于根据 spreadsheetToken 和维度信息拆分单元格；单次操作不超过5000行，100列。</para>
/// <para>接口ID：6907569524100055041</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/docs/sheets-v3/data-operation/split-cells</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuATNzUjLwUzM14CM1MTN</para>
/// </summary>
public record PostSheetsV2SpreadsheetsBySpreadsheetTokenUnmergeCellsBodyDto
{
    /// <summary>
    /// <para>查询范围，包含 sheetId 与单元格范围两部分，目前支持四种索引方式，详见[在线表格开发指南](https://open.feishu.cn/document/ukTMukTMukTM/uATMzUjLwEzM14CMxMTN/overview)</para>
    /// <para>必填：是</para>
    /// </summary>
    [JsonProperty("range")]
    public string Range { get; set; } = string.Empty;
}
