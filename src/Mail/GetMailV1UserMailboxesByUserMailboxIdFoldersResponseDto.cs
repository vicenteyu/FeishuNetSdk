// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-04-11
//
// Last Modified By : yxr
// Last Modified On : 2025-04-11
// ************************************************************************
// <copyright file="GetMailV1UserMailboxesByUserMailboxIdFoldersResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>列出邮箱文件夹 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Mail;
/// <summary>
/// 列出邮箱文件夹 响应体
/// <para>列出邮箱文件夹</para>
/// <para>接口ID：7275929163676123139</para>
/// <para>文档地址：https://open.feishu.cn/document/mail-v1/user_mailbox-folder/list</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fmail-v1%2fuser_mailbox-folder%2flist</para>
/// </summary>
public record GetMailV1UserMailboxesByUserMailboxIdFoldersResponseDto
{
    /// <summary>
    /// <para>文件夹列表</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("items")]
    public Folder[]? Items { get; set; }

    /// <summary>
    /// <para>文件夹列表</para>
    /// </summary>
    public record Folder
    {
        /// <summary>
        /// <para>folder id</para>
        /// <para>必填：否</para>
        /// <para>示例值：12314123123123123</para>
        /// </summary>
        [JsonPropertyName("id")]
        public string? Id { get; set; }

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
        /// <para>父文件夹 id，该值为 0 表示根文件夹</para>
        /// <para>必填：是</para>
        /// <para>示例值：725627422334644</para>
        /// </summary>
        [JsonPropertyName("parent_folder_id")]
        public string ParentFolderId { get; set; } = string.Empty;

        /// <summary>
        /// <para>文件夹类型</para>
        /// <para>必填：否</para>
        /// <para>示例值：1</para>
        /// <para>最大值：2</para>
        /// <para>最小值：1</para>
        /// <para>可选值：<list type="bullet">
        /// <item>1：系统文件夹</item>
        /// <item>2：用户文件夹</item>
        /// </list></para>
        /// </summary>
        [JsonPropertyName("folder_type")]
        public int? FolderType { get; set; }

        /// <summary>
        /// <para>未读邮件数量</para>
        /// <para>必填：否</para>
        /// <para>示例值：3</para>
        /// </summary>
        [JsonPropertyName("unread_message_count")]
        public int? UnreadMessageCount { get; set; }

        /// <summary>
        /// <para>未读会话数量</para>
        /// <para>必填：否</para>
        /// <para>示例值：4</para>
        /// </summary>
        [JsonPropertyName("unread_thread_count")]
        public int? UnreadThreadCount { get; set; }
    }
}
