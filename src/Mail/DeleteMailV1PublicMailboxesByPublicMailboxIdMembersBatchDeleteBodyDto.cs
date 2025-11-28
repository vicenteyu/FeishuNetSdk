// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-06-24
// ************************************************************************
// <copyright file="DeleteMailV1PublicMailboxesByPublicMailboxIdMembersBatchDeleteBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>批量删除公共邮箱成员 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Mail;
/// <summary>
/// 批量删除公共邮箱成员 请求体
/// <para>一次请求可以删除一个公共邮箱中的多个成员。</para>
/// <para>接口ID：7187647376462938116</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/mail-v1/public-mailbox/public_mailbox-member/batch_delete</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fmail-v1%2fpublic_mailbox-member%2fbatch_delete</para>
/// </summary>
public record DeleteMailV1PublicMailboxesByPublicMailboxIdMembersBatchDeleteBodyDto
{
    /// <summary>
    /// <para>本次调用删除的公共邮箱成员ID列表</para>
    /// <para>必填：是</para>
    /// <para>示例值：["xxxxxxx","yyyyyyy"]</para>
    /// <para>最大长度：200</para>
    /// </summary>
    [JsonPropertyName("member_id_list")]
    public string[] MemberIdList { get; set; } = [];
}
