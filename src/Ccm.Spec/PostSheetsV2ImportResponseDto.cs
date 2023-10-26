using Newtonsoft.Json;
namespace FeishuNetSdk.Ccm.Spec;
/// <summary>
/// 导入表格 响应体
/// <para>&gt; 为了更好地提升该接口的安全性，我们对其进行了升级，请尽快迁移至[新版本](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/drive-v1/import_task/import-user-guide)</para>
/// <para>该接口用于将本地表格导入到云空间上。</para>
/// <para>接口ID：6907568031544229890</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/historic-version/docs/sheets/sheet-operation/import-spreadsheet</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuATO2YjLwkjN24CM5YjN</para>
/// </summary>
public record PostSheetsV2ImportResponseDto
{
    /// <summary>
    /// <para>与导入文件一一对应的凭证，用于查询文件导入的进度，详见[查询导入结果的接口](https://open.feishu.cn/document/ukTMukTMukTM/uETO2YjLxkjN24SM5YjN)</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonProperty("ticket")]
    public string? Ticket { get; set; }
}
