// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-06-24
// ************************************************************************
// <copyright file="GetAuthenV1UserInfoResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>获取用户信息 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Auth;
/// <summary>
/// 获取用户信息 响应体
/// <para>通过 `user_access_token` 获取相关用户信息。</para>
/// <para>接口ID：7180265937329537028</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/authentication-management/login-state-management/get</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fauthen-v1%2fuser_info%2fget</para>
/// </summary>
public record GetAuthenV1UserInfoResponseDto
{
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
    /// <para>示例值：zhangsan</para>
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
    /// <para>用户对ISV的唯一标识，对于同一个ISV，用户在其名下所有应用的union_id相同</para>
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
    /// <para>用户工号</para>
    /// <para>必填：否</para>
    /// <para>示例值：111222333</para>
    /// </summary>
    [JsonPropertyName("employee_no")]
    public string? EmployeeNo { get; set; }
}
