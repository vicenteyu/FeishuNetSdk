using Newtonsoft.Json;
namespace FeishuNetSdk.Ccm.Spec;
/// <summary>
/// 查询导入结果 响应体
/// <para>该接口用于查询文件导入结果。查询30分钟无结果为导入失败。</para>
/// <para>接口ID：6907568073252683778</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/historic-version/docs/sheets/sheet-operation/query-import-results</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuETO2YjLxkjN24SM5YjN</para>
/// </summary>
public record GetSheetsV2ImportResultResponseDto
{
    /// <summary>
    /// <para>导入时获取的凭证</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonProperty("ticket")]
    public string? Ticket { get; set; }

    /// <summary>
    /// <para>导入文档的链接</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonProperty("url")]
    public string? Url { get; set; }

    /// <summary>
    /// <para>导入的文档的状态码</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonProperty("warningCode")]
    public int? WarningCode { get; set; }
}
