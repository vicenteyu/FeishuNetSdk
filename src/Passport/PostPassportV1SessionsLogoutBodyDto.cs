// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-11-03
//
// Last Modified By : yxr
// Last Modified On : 2024-11-03
// ************************************************************************
// <copyright file="PostPassportV1SessionsLogoutBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>退出登录 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Passport;
/// <summary>
/// 退出登录 请求体
/// <para>该接口用于退出用户的登录态</para>
/// <para>接口ID：7419242474898472963</para>
/// <para>文档地址：https://open.feishu.cn/document/authentication-management/login-state-management/logout</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fpassport-v1%2fsession%2flogout</para>
/// </summary>
public record PostPassportV1SessionsLogoutBodyDto
{
    /// <summary>
    /// <para>idp 侧的唯一标识，logout_type = 2 时必填</para>
    /// <para>必填：否</para>
    /// <para>示例值：user@xxx.xx</para>
    /// </summary>
    [JsonPropertyName("idp_credential_id")]
    public string? IdpCredentialId { get; set; }

    /// <summary>
    /// <para>登出的方式</para>
    /// <para>必填：是</para>
    /// <para>示例值：1</para>
    /// <para>可选值：<list type="bullet">
    /// <item>1：UserID，使用开放平台的维度登出</item>
    /// <item>2：IdpCredentialID，使用 idp 侧的唯一标识登出</item>
    /// <item>3：Session 标识符，基于session uuid 登出</item>
    /// </list></para>
    /// </summary>
    [JsonPropertyName("logout_type")]
    public int LogoutType { get; set; }

    /// <summary>
    /// <para>登出的客户端类型，默认全部登出。可选值：</para>
    /// <para>- 1：PC 端</para>
    /// <para>- 2：Web 端</para>
    /// <para>- 3：Android 端</para>
    /// <para>- 4：iOS 端</para>
    /// <para>- 5：服务端</para>
    /// <para>- 6：旧版小程序端</para>
    /// <para>- 8：其他移动端</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("terminal_type")]
    public int[]? TerminalType { get; set; }

    /// <summary>
    /// <para>开放平台的数据标识，用户 ID 类型与查询参数 user_id_type 一致，logout_type = 1 时必填</para>
    /// <para>必填：否</para>
    /// <para>示例值：ou_7dab8a3d3cdcc9da365777c7ad535d62</para>
    /// </summary>
    [JsonPropertyName("user_id")]
    public string? UserId { get; set; }

    /// <summary>
    /// <para>登出提示语，非必填，不传时默认提示：你已在其他客户端上退出了当前设备，请重新登录。</para>
    /// <para>可选值：</para>
    /// <para>- 34：您已修改登录密码，请重新登录</para>
    /// <para>- 35：您的登录态已失效，请重新登录</para>
    /// <para>- 36：您的密码已过期，请在登录页面通过忘记密码功能修改密码后重新登录</para>
    /// <para>必填：否</para>
    /// <para>示例值：34</para>
    /// </summary>
    [JsonPropertyName("logout_reason")]
    public int? LogoutReason { get; set; }

    /// <summary>
    /// <para>需要精确登出的 session 标识符，logout_type = 3 时必填</para>
    /// <para>必填：否</para>
    /// <para>示例值：AAAAAAAAAANll6nQoIAAFA==</para>
    /// </summary>
    [JsonPropertyName("sid")]
    public string? Sid { get; set; }
}
