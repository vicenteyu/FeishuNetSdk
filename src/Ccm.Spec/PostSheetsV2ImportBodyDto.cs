using Newtonsoft.Json;
namespace FeishuNetSdk.Ccm.Spec;
/// <summary>
/// 导入表格 请求体
/// <para>>  为了更好地提升该接口的安全性，我们对其进行了升级，请尽快迁移至[新版本](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/drive-v1/import_task/import-user-guide)</para>
/// <para>该接口用于将本地表格导入到云空间上。</para>
/// <para>接口ID：6907568031544229890</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/historic-version/docs/sheets/sheet-operation/import-spreadsheet</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuATO2YjLwkjN24CM5YjN</para>
/// </summary>
public record PostSheetsV2ImportBodyDto
{
    /// <summary>
    /// <para>需要导入的文件数据，转换成字节数组的形式，支持"xlsx","csv"格式，最大不超过20M</para>
    /// <para>必填：是</para>
    /// </summary>
    [JsonProperty("file")]
    public byte[] File { get; set; } = Array.Empty<byte>();

    /// <summary>
    /// <para>文件名，带上文件拓展名，如"hello.csv"、"hello.xlsx"。导入后sheet的标题将去除文件拓展名，如"hello.xlsx"导入后标题为"hello"。</para>
    /// <para>必填：是</para>
    /// </summary>
    [JsonProperty("name")]
    public string Name { get; set; } = string.Empty;

    /// <summary>
    /// <para>导入的文件夹token，默认导入到根目录下</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonProperty("folderToken")]
    public string? FolderToken { get; set; }
}
