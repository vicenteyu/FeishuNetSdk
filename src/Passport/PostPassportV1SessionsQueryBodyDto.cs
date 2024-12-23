// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-06-24
// ************************************************************************
// <copyright file="PostPassportV1SessionsQueryBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>批量获取脱敏的用户登录信息 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Passport;
/// <summary>
/// 批量获取脱敏的用户登录信息 请求体
/// <para>该接口用于查询用户的登录信息。</para>
/// <para>接口ID：7096084771490578433</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/authentication-management/login-state-management/query</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fpassport-v1%2fsession%2fquery</para>
/// </summary>
public record PostPassportV1SessionsQueryBodyDto
{
    /// <summary>
    /// <para>用户 ID</para>
    /// <para>必填：否</para>
    /// <para>示例值：["47f621ff"]</para>
    /// <para>最大长度：100</para>
    /// </summary>
    [JsonPropertyName("user_ids")]
    public string[]? UserIds { get; set; }
}
