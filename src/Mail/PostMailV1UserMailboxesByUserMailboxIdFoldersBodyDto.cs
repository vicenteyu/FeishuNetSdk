// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-04-11
//
// Last Modified By : yxr
// Last Modified On : 2025-04-11
// ************************************************************************
// <copyright file="PostMailV1UserMailboxesByUserMailboxIdFoldersBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>创建邮箱文件夹 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Mail;
/// <summary>
/// 创建邮箱文件夹 请求体
/// <para>创建邮箱文件夹</para>
/// <para>接口ID：7275929163676090371</para>
/// <para>文档地址：https://open.feishu.cn/document/mail-v1/user_mailbox-folder/create</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fmail-v1%2fuser_mailbox-folder%2fcreate</para>
/// </summary>
public record PostMailV1UserMailboxesByUserMailboxIdFoldersBodyDto
{
    /// <summary>
    /// <para>文件夹名称</para>
    /// <para>必填：是</para>
    /// <para>示例值：newsletter 相关</para>
    /// <para>最大长度：250</para>
    /// <para>最小长度：1</para>
    /// </summary>
    [JsonPropertyName("name")]
    public string Name { get; set; } = string.Empty;

    /// <summary>
    /// <para>父文件夹 id，该值为 0 表示根文件夹，id 获取方式见 [列出文邮箱文件夹](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/mail-v1/user_mailbox-folder/list)</para>
    /// <para>必填：是</para>
    /// <para>示例值：725627422334644</para>
    /// </summary>
    [JsonPropertyName("parent_folder_id")]
    public string ParentFolderId { get; set; } = string.Empty;
}
