// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2026-04-18
//
// Last Modified By : yxr
// Last Modified On : 2026-04-18
// ************************************************************************
// <copyright file="GetMailV1UserMailboxesByUserMailboxIdFoldersByFolderIdResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>获取邮箱文件信息 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Mail;
/// <summary>
/// 获取邮箱文件信息 响应体
/// <para>通过指定文件夹ID，获取文件夹信息，包括名称、类型等</para>
/// <para>接口ID：7620478754624375740</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/mail-v1/user_mailbox-folder/get</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fmail-v1%2fuser_mailbox-folder%2fget</para>
/// </summary>
public record GetMailV1UserMailboxesByUserMailboxIdFoldersByFolderIdResponseDto
{
    /// <summary>
    /// <para>邮件文件夹的完整信息，包含文件夹ID、名称、归属层级、类型及未读统计数据。</para>
    /// <para>必填：否</para>
    /// <para>示例值：{"id":"fld_1234567890abcdef","name":"收件箱","parent_folder_id":"0","folder_type":1,"unread_message_count":12,"unread_thread_count":8}</para>
    /// </summary>
    [JsonPropertyName("folder")]
    public FolderSuffix? Folder { get; set; }

    /// <summary>
    /// <para>邮件文件夹的完整信息，包含文件夹ID、名称、归属层级、类型及未读统计数据。</para>
    /// </summary>
    public record FolderSuffix
    {
        /// <summary>
        /// <para>folder id</para>
        /// <para>必填：否</para>
        /// <para>示例值：7620095646711680541</para>
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
