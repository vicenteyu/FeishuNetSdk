namespace FeishuNetSdk.Ccm.Spec;
/// <summary>
/// 创建旧版文档 请求体
/// <para>此接口已废弃。要创建文档，使用[创建文档](https://open.feishu.cn/document/ukTMukTMukTM/uUDN04SN0QjL1QDN/document-docx/docx-v1/document/create)接口。</para>
/// <para>接口ID：6908984614439829506</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/docs/docs/docs/apiRef/create-document</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fugDM2YjL4AjN24COwYjN</para>
/// </summary>
public record PostDocV2CreateBodyDto
{
    /// <summary>
    /// <para>文件夹 token，获取方式见[如何获取云文档资源相关 token](https://open.feishu.cn/document/ukTMukTMukTM/uczNzUjL3czM14yN3MTN#08bb5df6)；空表示根目录，tenant_access_token应用权限仅允许操作应用创建的目录</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("FolderToken")]
    public string? FolderToken { get; set; }

    /// <summary>
    /// <para>传入符合[文档数据结构](https://open.feishu.cn/document/ukTMukTMukTM/uAzM5YjLwMTO24CMzkjN)的字符串，若为空表示创建空文档</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("Content")]
    public string? Content { get; set; }
}
