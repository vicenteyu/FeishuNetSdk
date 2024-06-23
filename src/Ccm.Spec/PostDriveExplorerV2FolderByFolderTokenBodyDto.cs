// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-06-24
// ************************************************************************
// <copyright file="PostDriveExplorerV2FolderByFolderTokenBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>新建文件夹 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Ccm.Spec;
/// <summary>
/// 新建文件夹 请求体
/// <para>为了更好地提升该接口的安全性，我们对其进行了升级，请尽快迁移至 [新版本&gt;&gt;](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/drive-v1/file/create_folder)</para>
/// <para>该接口用于根据 folderToken 在该 folder 下创建文件夹。</para>
/// <para>该接口不支持并发创建，且调用频率上限为 5QPS 以及 10000次/天</para>
/// <para>接口ID：6907569745299750914</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/historic-version/docs/drive/folder/create-a-new-folder</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fukTNzUjL5UzM14SO1MTN</para>
/// </summary>
public record PostDriveExplorerV2FolderByFolderTokenBodyDto
{
    /// <summary>
    /// <para>文件夹标题</para>
    /// <para>必填：是</para>
    /// </summary>
    [JsonPropertyName("title")]
    public string Title { get; set; } = string.Empty;
}
