using Newtonsoft.Json;
namespace FeishuNetSdk.Authen;
/// <summary>
/// 刷新 user_access_token 响应体
/// <para>`user_access_token` 的最大有效期是 6900 秒。当 `user_access_token` 过期时，可以调用本接口获取新的 `user_access_token`。</para>
/// <para>接口ID：7180265937329520644</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/authentication-management/access-token/create</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fauthen-v1%2frefresh_access_token%2fcreate</para>
/// </summary>
public record PostAuthenV1RefreshAccessTokenResponseDto
{
    /// <summary>
    /// <para>user_access_token，用于获取用户资源</para>
    /// <para>必填：否</para>
    /// <para>示例值：u-Q7JWnaIM_kRChuLfreHmpArjOEayt.5XUBJcZr.V0Gst4FdQCtvrd9sAViLXQnQgkpL19brGOjKZQTxb</para>
    /// </summary>
    [JsonProperty("access_token")]
    public string? AccessToken { get; set; }

    /// <summary>
    /// <para>token 类型</para>
    /// <para>必填：否</para>
    /// <para>示例值：Bearer</para>
    /// </summary>
    [JsonProperty("token_type")]
    public string? TokenType { get; set; }

    /// <summary>
    /// <para>`access_token` 的有效期，单位: 秒</para>
    /// <para>必填：否</para>
    /// <para>示例值：7140</para>
    /// </summary>
    [JsonProperty("expires_in")]
    public int? ExpiresIn { get; set; }

    /// <summary>
    /// <para>用户姓名</para>
    /// <para>必填：否</para>
    /// <para>示例值：zhangsan</para>
    /// </summary>
    [JsonProperty("name")]
    public string? Name { get; set; }

    /// <summary>
    /// <para>用户英文名称</para>
    /// <para>必填：否</para>
    /// <para>示例值：ThreeZhang</para>
    /// </summary>
    [JsonProperty("en_name")]
    public string? EnName { get; set; }

    /// <summary>
    /// <para>用户头像</para>
    /// <para>必填：否</para>
    /// <para>示例值：www.feishu.cn/avatar/icon</para>
    /// </summary>
    [JsonProperty("avatar_url")]
    public string? AvatarUrl { get; set; }

    /// <summary>
    /// <para>用户头像 72x72</para>
    /// <para>必填：否</para>
    /// <para>示例值：www.feishu.cn/avatar/icon_thumb</para>
    /// </summary>
    [JsonProperty("avatar_thumb")]
    public string? AvatarThumb { get; set; }

    /// <summary>
    /// <para>用户头像 240x240</para>
    /// <para>必填：否</para>
    /// <para>示例值：thwww.feishu.cn/avatar/icon_middle</para>
    /// </summary>
    [JsonProperty("avatar_middle")]
    public string? AvatarMiddle { get; set; }

    /// <summary>
    /// <para>用户头像 640x640</para>
    /// <para>必填：否</para>
    /// <para>示例值：www.feishu.cn/avatar/icon_big</para>
    /// </summary>
    [JsonProperty("avatar_big")]
    public string? AvatarBig { get; set; }

    /// <summary>
    /// <para>用户在应用内的唯一标识</para>
    /// <para>必填：否</para>
    /// <para>示例值：ou_caecc734c2e3328a62489fe0648c4b98779515d3</para>
    /// </summary>
    [JsonProperty("open_id")]
    public string? OpenId { get; set; }

    /// <summary>
    /// <para>用户统一ID</para>
    /// <para>必填：否</para>
    /// <para>示例值：on_d89jhsdhjsajkda7828enjdj328ydhhw3u43yjhdj</para>
    /// </summary>
    [JsonProperty("union_id")]
    public string? UnionId { get; set; }

    /// <summary>
    /// <para>用户邮箱</para>
    /// <para>必填：否</para>
    /// <para>示例值：zhangsan@feishu.cn</para>
    /// </summary>
    [JsonProperty("email")]
    public string? Email { get; set; }

    /// <summary>
    /// <para>企业邮箱，请先确保已在管理后台启用飞书邮箱服务</para>
    /// <para>必填：否</para>
    /// <para>示例值：demo@mail.com</para>
    /// </summary>
    [JsonProperty("enterprise_email")]
    public string? EnterpriseEmail { get; set; }

    /// <summary>
    /// <para>用户 user_id</para>
    /// <para>必填：否</para>
    /// <para>示例值：5d9bdxxx</para>
    /// </summary>
    [JsonProperty("user_id")]
    public string? UserId { get; set; }

    /// <summary>
    /// <para>用户手机号</para>
    /// <para>必填：否</para>
    /// <para>示例值：+86130002883xx</para>
    /// </summary>
    [JsonProperty("mobile")]
    public string? Mobile { get; set; }

    /// <summary>
    /// <para>当前企业标识</para>
    /// <para>必填：否</para>
    /// <para>示例值：736588c92lxf175d</para>
    /// </summary>
    [JsonProperty("tenant_key")]
    public string? TenantKey { get; set; }

    /// <summary>
    /// <para>`refresh_token` 的有效期，单位: 秒</para>
    /// <para>必填：否</para>
    /// <para>示例值：2591940</para>
    /// </summary>
    [JsonProperty("refresh_expires_in")]
    public int? RefreshExpiresIn { get; set; }

    /// <summary>
    /// <para>刷新用户 `access_token` 时使用的 token</para>
    /// <para>必填：否</para>
    /// <para>示例值：ur-oQ0mMq6MCcueAv0pwx2fQQhxqv__CbLu6G8ySFwafeKww2Def2BJdOkW3.9gCFM.LBQgFri901QaqeuL</para>
    /// </summary>
    [JsonProperty("refresh_token")]
    public string? RefreshToken { get; set; }

    /// <summary>
    /// <para>用户当前登录态session的唯一标识，为空则不返回</para>
    /// <para>必填：否</para>
    /// <para>示例值：AAAAAAAAAANjgHsqKEAAEw==</para>
    /// </summary>
    [JsonProperty("sid")]
    public string? Sid { get; set; }
}
