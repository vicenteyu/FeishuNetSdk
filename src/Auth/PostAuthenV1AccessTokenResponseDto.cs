// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-06-24
// ************************************************************************
// <copyright file="PostAuthenV1AccessTokenResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>获取 user_access_token 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Auth;
/// <summary>
/// 获取 user_access_token 响应体
/// <para>根据[登录预授权码](https://open.feishu.cn/document/ukTMukTMukTM/ukzN4UjL5cDO14SO3gTN) code 获取 `user_access_token`。</para>
/// <para>接口ID：7180265937329553412</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/authentication-management/access-token/create-2</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fauthen-v1%2faccess_token%2fcreate</para>
/// </summary>
public record PostAuthenV1AccessTokenResponseDto
{
    /// <summary>
    /// <para>user_access_token，用于获取用户资源</para>
    /// <para>必填：否</para>
    /// <para>示例值：u-Q7JWnaIM_kRChuLfreHmpArjOEayt.5XUBJcZr.V0Gst4FdQCtvrd9sAViLXQnQgkpL19brGOjKZQTxb</para>
    /// </summary>
    [JsonPropertyName("access_token")]
    public string? AccessToken { get; set; }

    /// <summary>
    /// <para>token 类型</para>
    /// <para>必填：否</para>
    /// <para>示例值：Bearer</para>
    /// </summary>
    [JsonPropertyName("token_type")]
    public string? TokenType { get; set; }

    /// <summary>
    /// <para>`access_token` 的有效期，单位: 秒</para>
    /// <para>必填：否</para>
    /// <para>示例值：7140</para>
    /// </summary>
    [JsonPropertyName("expires_in")]
    public int? ExpiresIn { get; set; }

    /// <summary>
    /// <para>用户姓名</para>
    /// <para>必填：否</para>
    /// <para>示例值：zhangsan</para>
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// <para>用户英文名称</para>
    /// <para>必填：否</para>
    /// <para>示例值：Three Zhang</para>
    /// </summary>
    [JsonPropertyName("en_name")]
    public string? EnName { get; set; }

    /// <summary>
    /// <para>用户头像</para>
    /// <para>必填：否</para>
    /// <para>示例值：www.feishu.cn/avatar/icon</para>
    /// </summary>
    [JsonPropertyName("avatar_url")]
    public string? AvatarUrl { get; set; }

    /// <summary>
    /// <para>用户头像 72x72</para>
    /// <para>必填：否</para>
    /// <para>示例值：www.feishu.cn/avatar/icon_thumb</para>
    /// </summary>
    [JsonPropertyName("avatar_thumb")]
    public string? AvatarThumb { get; set; }

    /// <summary>
    /// <para>用户头像 240x240</para>
    /// <para>必填：否</para>
    /// <para>示例值：www.feishu.cn/avatar/icon_middle</para>
    /// </summary>
    [JsonPropertyName("avatar_middle")]
    public string? AvatarMiddle { get; set; }

    /// <summary>
    /// <para>用户头像 640x640</para>
    /// <para>必填：否</para>
    /// <para>示例值：www.feishu.cn/avatar/icon_big</para>
    /// </summary>
    [JsonPropertyName("avatar_big")]
    public string? AvatarBig { get; set; }

    /// <summary>
    /// <para>用户在应用内的唯一标识</para>
    /// <para>必填：否</para>
    /// <para>示例值：ou_caecc734c2e3328a62489fe0648c4b98779515d3</para>
    /// </summary>
    [JsonPropertyName("open_id")]
    public string? OpenId { get; set; }

    /// <summary>
    /// <para>用户统一ID</para>
    /// <para>必填：否</para>
    /// <para>示例值：on_d89jhsdhjsajkda7828enjdj328ydhhw3u43yjhdj</para>
    /// </summary>
    [JsonPropertyName("union_id")]
    public string? UnionId { get; set; }

    /// <summary>
    /// <para>用户邮箱</para>
    /// <para>必填：否</para>
    /// <para>示例值：zhangsan@feishu.cn</para>
    /// </summary>
    [JsonPropertyName("email")]
    public string? Email { get; set; }

    /// <summary>
    /// <para>企业邮箱，请先确保已在管理后台启用飞书邮箱服务</para>
    /// <para>必填：否</para>
    /// <para>示例值：demo@mail.com</para>
    /// </summary>
    [JsonPropertyName("enterprise_email")]
    public string? EnterpriseEmail { get; set; }

    /// <summary>
    /// <para>用户 user_id</para>
    /// <para>必填：否</para>
    /// <para>示例值：5d9bdxxx</para>
    /// </summary>
    [JsonPropertyName("user_id")]
    public string? UserId { get; set; }

    /// <summary>
    /// <para>用户手机号</para>
    /// <para>必填：否</para>
    /// <para>示例值：+86130002883xx</para>
    /// </summary>
    [JsonPropertyName("mobile")]
    public string? Mobile { get; set; }

    /// <summary>
    /// <para>当前企业标识</para>
    /// <para>必填：否</para>
    /// <para>示例值：736588c92lxf175d</para>
    /// </summary>
    [JsonPropertyName("tenant_key")]
    public string? TenantKey { get; set; }

    /// <summary>
    /// <para>`refresh_token` 的有效期，单位: 秒</para>
    /// <para>必填：否</para>
    /// <para>示例值：2591940</para>
    /// </summary>
    [JsonPropertyName("refresh_expires_in")]
    public int? RefreshExpiresIn { get; set; }

    /// <summary>
    /// <para>刷新用户 `access_token` 时使用的 token</para>
    /// <para>必填：否</para>
    /// <para>示例值：ur-oQ0mMq6MCcueAv0pwx2fQQhxqv__CbLu6G8ySFwafeKww2Def2BJdOkW3.9gCFM.LBQgFri901QaqeuL</para>
    /// </summary>
    [JsonPropertyName("refresh_token")]
    public string? RefreshToken { get; set; }

    /// <summary>
    /// <para>用户当前登录态session的唯一标识，为空则不返回</para>
    /// <para>必填：否</para>
    /// <para>示例值：AAAAAAAAAANjgHsqKEAAEw==</para>
    /// </summary>
    [JsonPropertyName("sid")]
    public string? Sid { get; set; }
}
