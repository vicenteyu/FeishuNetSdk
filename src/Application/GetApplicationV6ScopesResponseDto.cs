// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-08-28
//
// Last Modified By : yxr
// Last Modified On : 2024-08-28
// ************************************************************************
// <copyright file="GetApplicationV6ScopesResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>查询租户授权状态 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Application;
/// <summary>
/// 查询租户授权状态 响应体
/// <para>调用该接口查询当前应用向租户申请授权的状态。</para>
/// <para>接口ID：7406972061036445700</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/application-v6/scope/list</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fapplication-v6%2fscope%2flist</para>
/// </summary>
public record GetApplicationV6ScopesResponseDto
{
    /// <summary>
    /// <para>租户对当前应用所需权限的授予情况。</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("scopes")]
    public Scope[]? Scopes { get; set; }

    /// <summary>
    /// <para>租户对当前应用所需权限的授予情况。</para>
    /// </summary>
    public record Scope
    {
        /// <summary>
        /// <para>权限名称。取值示例 `user.phone:readonly`。</para>
        /// <para>必填：是</para>
        /// <para>示例值：user.phone:readonly</para>
        /// </summary>
        [JsonPropertyName("scope_name")]
        public string ScopeName { get; set; } = string.Empty;

        /// <summary>
        /// <para>权限授予状态。</para>
        /// <para>必填：是</para>
        /// <para>示例值：1</para>
        /// <para>可选值：<list type="bullet">
        /// <item>1：已授权</item>
        /// <item>2：未授权</item>
        /// </list></para>
        /// </summary>
        [JsonPropertyName("grant_status")]
        public int GrantStatus { get; set; }
    }
}
