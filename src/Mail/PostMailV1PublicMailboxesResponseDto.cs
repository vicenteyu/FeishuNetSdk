// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-06-24
// ************************************************************************
// <copyright file="PostMailV1PublicMailboxesResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>创建公共邮箱 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Mail;
/// <summary>
/// 创建公共邮箱 响应体
/// <para>创建一个公共邮箱。</para>
/// <para>接口ID：6954915601882677251</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/mail-v1/public-mailbox/public_mailbox/create</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fmail-v1%2fpublic_mailbox%2fcreate</para>
/// </summary>
public record PostMailV1PublicMailboxesResponseDto
{
    /// <summary>
    /// <para>公共邮箱唯一标识</para>
    /// <para>必填：否</para>
    /// <para>示例值：xxxxxxxxxxxxxxx</para>
    /// </summary>
    [JsonPropertyName("public_mailbox_id")]
    public string? PublicMailboxId { get; set; }

    /// <summary>
    /// <para>公共邮箱地址</para>
    /// <para>必填：否</para>
    /// <para>示例值：test_public_mailbox@xxx.xx</para>
    /// </summary>
    [JsonPropertyName("email")]
    public string? Email { get; set; }

    /// <summary>
    /// <para>公共邮箱名称</para>
    /// <para>必填：否</para>
    /// <para>示例值：test public mailbox</para>
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// <para>数据驻留地</para>
    /// <para>必填：否</para>
    /// <para>示例值：cn</para>
    /// </summary>
    [JsonPropertyName("geo")]
    public string? Geo { get; set; }
}
