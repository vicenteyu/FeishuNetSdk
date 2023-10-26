using Newtonsoft.Json;
namespace FeishuNetSdk.Authen.Spec;
/// <summary>
/// 获取登录用户信息 响应体
/// <para>通过 `user_access_token` 获取登录用户的信息。</para>
/// <para>接口ID：7180265937329537028</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/authentication-management/login-state-management/get</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fauthen-v1%2fuser_info%2fget</para>
/// </summary>
public record GetAuthenV1UserInfoResponseDto
{
    /// <summary>
    /// <para>用户姓名</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonProperty("name")]
    public string? Name { get; set; }

    /// <summary>
    /// <para>用户英文名称</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonProperty("en_name")]
    public string? EnName { get; set; }

    /// <summary>
    /// <para>用户头像</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonProperty("avatar_url")]
    public string? AvatarUrl { get; set; }

    /// <summary>
    /// <para>用户头像 72x72</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonProperty("avatar_thumb")]
    public string? AvatarThumb { get; set; }

    /// <summary>
    /// <para>用户头像 240x240</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonProperty("avatar_middle")]
    public string? AvatarMiddle { get; set; }

    /// <summary>
    /// <para>用户头像 640x640</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonProperty("avatar_big")]
    public string? AvatarBig { get; set; }

    /// <summary>
    /// <para>用户在应用内的唯一标识</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonProperty("open_id")]
    public string? OpenId { get; set; }

    /// <summary>
    /// <para>用户对ISV的唯一标识，对于同一个ISV，用户在其名下所有应用的union_id相同</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonProperty("union_id")]
    public string? UnionId { get; set; }

    /// <summary>
    /// <para>用户邮箱</para>
    /// <para>**字段权限要求**：</para>
    /// <para>&lt;md-perm name="contact:user.email:readonly" desc="获取用户邮箱信息" support_app_types="custom" tags=""&gt;获取用户邮箱信息&lt;/md-perm&gt;</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonProperty("email")]
    public string? Email { get; set; }

    /// <summary>
    /// <para>企业邮箱，请先确保已在管理后台启用飞书邮箱服务</para>
    /// <para>**字段权限要求**：</para>
    /// <para>&lt;md-perm name="contact:user.employee:readonly" desc="获取用户受雇信息" support_app_types="custom,isv" tags=""&gt;获取用户受雇信息&lt;/md-perm&gt;</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonProperty("enterprise_email")]
    public string? EnterpriseEmail { get; set; }

    /// <summary>
    /// <para>用户 user_id</para>
    /// <para>**字段权限要求**：</para>
    /// <para>&lt;md-perm name="contact:user.employee_id:readonly" desc="获取用户 user ID" support_app_types="custom" tags=""&gt;获取用户 user ID&lt;/md-perm&gt;</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonProperty("user_id")]
    public string? UserId { get; set; }

    /// <summary>
    /// <para>用户手机号</para>
    /// <para>**字段权限要求**：</para>
    /// <para>&lt;md-perm name="contact:user.phone:readonly" desc="获取用户手机号" support_app_types="custom" tags=""&gt;获取用户手机号&lt;/md-perm&gt;</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonProperty("mobile")]
    public string? Mobile { get; set; }

    /// <summary>
    /// <para>当前企业标识</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonProperty("tenant_key")]
    public string? TenantKey { get; set; }

    /// <summary>
    /// <para>用户工号</para>
    /// <para>**字段权限要求**：</para>
    /// <para>&lt;md-perm name="contact:user.employee:readonly" desc="获取用户受雇信息" support_app_types="custom,isv" tags=""&gt;获取用户受雇信息&lt;/md-perm&gt;</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonProperty("employee_no")]
    public string? EmployeeNo { get; set; }
}
