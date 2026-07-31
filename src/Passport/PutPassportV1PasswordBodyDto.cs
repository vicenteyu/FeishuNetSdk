// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2026-07-31
//
// Last Modified By : yxr
// Last Modified On : 2026-07-31
// ************************************************************************
// <copyright file="PutPassportV1PasswordBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>重置登录密码 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Passport;
/// <summary>
/// 重置登录密码 请求体
/// <para>当用户忘记密码、密码已过期或账号存在安全风险时，管理员可以为用户重置密码。</para>
/// <para>接口ID：7537665430859382787</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/passport-v1/password/update</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fpassport-v1%2fpassword%2fupdate</para>
/// </summary>
public record PutPassportV1PasswordBodyDto
{
    /// <summary>
    /// <para>待修改密码的用户ID。用户 ID 的类型需与查询参数 user_id_type 的取值保持一致</para>
    /// <para>必填：是</para>
    /// <para>示例值：abcd1234ou_7dab8a3d3cdcc9da365777c7ad535d62</para>
    /// </summary>
    [JsonPropertyName("user_id")]
    public string UserId { get; set; } = string.Empty;

    /// <summary>
    /// <para>需要重置的密码参数，不少于8个字符，字母、数字和符号，至少三选二</para>
    /// <para>必填：否</para>
    /// <para>示例值：1234abcd</para>
    /// <para>最小长度：8</para>
    /// </summary>
    [JsonPropertyName("password")]
    public string? Password { get; set; }

    /// <summary>
    /// <para>是否要求用户在下次登录时重新设置密码。如果同时为用户进行了密码重置，建议此处传true，用户可重新设置自己的密码。</para>
    /// <para>必填：否</para>
    /// <para>示例值：false</para>
    /// </summary>
    [JsonPropertyName("require_reset")]
    public bool? RequireReset { get; set; }
}
