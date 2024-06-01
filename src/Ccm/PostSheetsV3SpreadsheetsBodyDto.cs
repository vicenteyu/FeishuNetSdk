namespace FeishuNetSdk.Ccm;
/// <summary>
/// 创建电子表格 请求体
/// <para>在云空间指定目录下创建电子表格。可自定义表格标题。不支持带内容创建表格。</para>
/// <para>接口ID：6969763153149476865</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/docs/sheets-v3/spreadsheet/create</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuUDN04SN0QjL1QDN%2fsheets-v3%2fspreadsheet%2fcreate</para>
/// </summary>
public record PostSheetsV3SpreadsheetsBodyDto
{
    /// <summary>
    /// <para>表格标题</para>
    /// <para>必填：否</para>
    /// <para>示例值：Sales sheet</para>
    /// <para>最大长度：255</para>
    /// <para>最小长度：0</para>
    /// </summary>
    [JsonPropertyName("title")]
    public string? Title { get; set; }

    /// <summary>
    /// <para>文件夹 token。你可通过以下两种方式获取文件夹的 token：</para>
    /// <para>- 文件夹的 URL：https://sample.feishu.cn/drive/folder/==fldbcO1UuPz8VwnpPx5a92abcef==</para>
    /// <para>- 调用开放平台接口获取：</para>
    /// <para>- 调用[获取我的空间（root folder）元数据](https://open.feishu.cn/document/ukTMukTMukTM/ugTNzUjL4UzM14CO1MTN/get-root-folder-meta)接口获取根目录（即根文件夹）的 token。</para>
    /// <para>- 继续调用[获取文件夹中的文件清单](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/drive-v1/file/list)接口，获取根目录下文件夹的 token。</para>
    /// <para>必填：否</para>
    /// <para>示例值：fldbcO1UuPz8VwnpPx5a92abcef</para>
    /// </summary>
    [JsonPropertyName("folder_token")]
    public string? FolderToken { get; set; }
}
