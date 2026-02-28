// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2026-03-01
//
// Last Modified By : yxr
// Last Modified On : 2026-03-01
// ************************************************************************
// <copyright file="AuthUserAccessTokenRevokedV4EventBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>撤销用户授权事件 事件体</summary>
// ************************************************************************
namespace FeishuNetSdk.Auth.Events;
/// <summary>
/// 撤销用户授权事件 事件体
/// <para>当用户 user_access_token 或 refresh_token 被撤销后，会触发此事件。{使用示例}(url=/api/tools/api_explore/api_explore_config?project=auth&amp;version=v4&amp;resource=user_access_token&amp;event=revoked)</para>
/// <para>接口ID：7384406199519510532</para>
/// <para>文档地址：https://open.feishu.cn/document/authentication-management/auth-v4/revoked</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fauthentication-management%2fauth-v4%2fuser_access_token%2fevents%2frevoked</para>
/// </summary>
public record AuthUserAccessTokenRevokedV4EventBodyDto() : EventBodyDto("auth.user_access_token.revoked_v4")
{
    /// <summary>
    /// <para>撤销 token 的类型。可能值有：</para>
    /// <para>- `user_access_token `：仅撤销 user_access_token</para>
    /// <para>- `refresh_token `：仅撤销 refresh_token</para>
    /// <para>- `user_access_token refresh_token`：user_access_token 和 refresh_token 都被撤销</para>
    /// <para>**数据校验规则**：</para>
    /// <para>- 长度范围：`0` ～ `10000` 字符</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("revoke_token_type")]
    public string? RevokeTokenType { get; set; }

    /// <summary>
    /// <para>撤销 token 的原因。可能值有：</para>
    /// <para>- `Revoked by unknown action.`：未知动作，缺省值</para>
    /// <para>- `Revoked by user action.`：被用户撤销</para>
    /// <para>- `Revoked by administrator action.`：被管理员撤销</para>
    /// <para>- `Revoked by security and risk control action.`：因风控和安全被撤销</para>
    /// <para>- `Revoked by restriction action.`：因限制动作被撤销，包括用户账号冻结、离职、应用不可用、用户对应用无权限等</para>
    /// <para>**数据校验规则**：</para>
    /// <para>- 长度范围：`0` ～ `10000` 字符</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("revoke_reason")]
    public string? RevokeReason { get; set; }

    /// <summary>
    /// <para>用户 open_id</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("open_id")]
    public string? OpenId { get; set; }

    /// <summary>
    /// <para>用户 union_id</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("union_id")]
    public string? UnionId { get; set; }

    /// <summary>
    /// <para>租户内用户的唯一标识</para>
    /// <para>**字段权限要求**：</para>
    /// <para>- contact:user.employee_id:readonly : 获取用户 user ID</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("user_id")]
    public string? UserId { get; set; }
}
