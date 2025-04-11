// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-04-11
//
// Last Modified By : yxr
// Last Modified On : 2025-04-11
// ************************************************************************
// <copyright file="PatchMailV1UserMailboxesByUserMailboxIdFoldersByFolderIdBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>修改邮箱文件夹 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Mail;
/// <summary>
/// 修改邮箱文件夹 请求体
/// <para>修改邮箱文件夹</para>
/// <para>接口ID：7275929163676205059</para>
/// <para>文档地址：https://open.feishu.cn/document/mail-v1/user_mailbox-folder/patch</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fmail-v1%2fuser_mailbox-folder%2fpatch</para>
/// </summary>
public record PatchMailV1UserMailboxesByUserMailboxIdFoldersByFolderIdBodyDto
{
    /// <summary>
    /// <para>文件夹名称</para>
    /// <para>必填：否</para>
    /// <para>示例值：newsletter 相关</para>
    /// <para>最大长度：250</para>
    /// <para>最小长度：1</para>
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// <para>父文件夹 id，该值为 0 表示根文件夹</para>
    /// <para>必填：否</para>
    /// <para>示例值：725627422334644</para>
    /// </summary>
    [JsonPropertyName("parent_folder_id")]
    public string? ParentFolderId { get; set; }
}
