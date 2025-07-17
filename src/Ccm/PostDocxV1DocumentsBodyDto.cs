// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-06-24
// ************************************************************************
// <copyright file="PostDocxV1DocumentsBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>创建文档 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Ccm;
/// <summary>
/// 创建文档 请求体
/// <para>创建文档类型为 docx 的文档。你可选择传入文档标题和文件夹。</para>
/// <para>接口ID：7068199542315204636</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/docs/docs/docx-v1/document/create</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuUDN04SN0QjL1QDN%2fdocument-docx%2fdocx-v1%2fdocument%2fcreate</para>
/// </summary>
public record PostDocxV1DocumentsBodyDto
{
    /// <summary>
    /// <para>指定文档所在文件夹 的 Token。不传或传空表示根目录。了解如何获取文件夹 Token，参考[如何获取云文档资源相关 Token](https://open.feishu.cn/document/ukTMukTMukTM/uczNzUjL3czM14yN3MTN#08bb5df6)。</para>
    /// <para>**提示**：</para>
    /// <para>若应用使用的是 `tenant_access_token` 权限，此处仅可指定应用创建的文件夹。</para>
    /// <para>必填：否</para>
    /// <para>示例值：fldcnqquW1svRIYVT2Np6Iabcef</para>
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
