using Newtonsoft.Json;
namespace FeishuNetSdk.Ccm.Spec;
/// <summary>
/// 删除Sheet 响应体
/// <para>为了更好地提升该接口的安全性，我们对其进行了升级，请尽快迁移至 [新版本&gt;&gt;](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/drive-v1/file/delete)</para>
/// <para>该接口用于根据 spreadsheetToken 删除对应的 sheet 文档。</para>
/// <para>文档只能被文档所有者删除，文档被删除后将会放到回收站里</para>
/// <para>该接口不支持并发调用，且调用频率上限为5QPS</para>
/// <para>接口ID：6979502797244153859</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/historic-version/docs/drive/file/delete-sheet</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuUTNzUjL1UzM14SN1MTN%2fdelete-sheet</para>
/// </summary>
public record DeleteDriveExplorerV2FileSpreadsheetsBySpreadsheetTokenResponseDto
{
    /// <summary>
    /// <para>sheet 的 id 「字符串类型」</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonProperty("id")]
    public string? Id { get; set; }

    /// <summary>
    /// <para>删除结果</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonProperty("result")]
    public bool? Result { get; set; }
}
