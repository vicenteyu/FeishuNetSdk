// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-02-09
//
// Last Modified By : yxr
// Last Modified On : 2025-02-09
// ************************************************************************
// <copyright file="PutApplicationV6ApplicationsByAppIdOwnerBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>转移应用所有者 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Application;
/// <summary>
/// 转移应用所有者 请求体
/// <para>将某个自建应用的所有者转移给另外一个人。</para>
/// <para>接口ID：7320225176225185795</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/application-v6/application-owner/update</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fapplication-v6%2fapplication-owner%2fupdate</para>
/// </summary>
public record PutApplicationV6ApplicationsByAppIdOwnerBodyDto
{
    /// <summary>
    /// <para>新的拥有者用户ID，类型由查询参数中的user_id_type确定</para>
    /// <para>必填：是</para>
    /// <para>示例值：ou_84aad35d084aa403a838cf73ee184670</para>
    /// </summary>
    [JsonPropertyName("owner_id")]
    public string OwnerId { get; set; } = string.Empty;
}
