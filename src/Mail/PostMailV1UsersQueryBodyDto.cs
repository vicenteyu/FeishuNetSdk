// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-06-24
// ************************************************************************
// <copyright file="PostMailV1UsersQueryBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>查询邮箱地址状态 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Mail;
/// <summary>
/// 查询邮箱地址状态 请求体
/// <para>使用邮箱状态查询接口，可以输入邮箱地址，查询出该邮箱地址对应的类型以及状态。</para>
/// <para>接口ID：7055500003323379713</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/mail-v1/user/query</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fmail-v1%2fuser%2fquery</para>
/// </summary>
public record PostMailV1UsersQueryBodyDto
{
    /// <summary>
    /// <para>需要查询的邮箱地址列表</para>
    /// <para>必填：是</para>
    /// <para>示例值：["aaa@lark.com","bbb@lark.com"]</para>
    /// </summary>
    [JsonPropertyName("email_list")]
    public string[] EmailList { get; set; } = [];
}
