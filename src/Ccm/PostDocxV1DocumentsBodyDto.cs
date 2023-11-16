namespace FeishuNetSdk.Ccm;
/// <summary>
/// 创建文档 请求体
/// <para>创建新版文档，文档标题和目录可选。</para>
/// <para>接口ID：7068199542315204636</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/docs/docs/docx-v1/document/create</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuUDN04SN0QjL1QDN%2fdocument-docx%2fdocx-v1%2fdocument%2fcreate</para>
/// </summary>
public record PostDocxV1DocumentsBodyDto
{
    /// <summary>
    /// <para>文件夹 Token，获取方式可参考[如何获取云文档资源相关 Token](https://open.feishu.cn/document/ukTMukTMukTM/uczNzUjL3czM14yN3MTN#08bb5df6)，</para>
    /// <para>不传或传空表示根目录。</para>
    /// <para>必填：否</para>
    /// <para>示例值：fldcnqquW1svRIYVT2Np6IuLCKd</para>
    /// </summary>
    [JsonPropertyName("folder_token")]
    public string? FolderToken { get; set; }

    /// <summary>
    /// <para>文档标题，只支持纯文本</para>
    /// <para>必填：否</para>
    /// <para>示例值：一篇新的文档</para>
    /// <para>最大长度：800</para>
    /// <para>最小长度：1</para>
    /// </summary>
    [JsonPropertyName("title")]
    public string? Title { get; set; }
}
