// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-06-24
// ************************************************************************
// <copyright file="GetContactV3ScopesResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>获取通讯录授权范围 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Contact;
/// <summary>
/// 获取通讯录授权范围 响应体
/// <para>调用该接口获取当前应用被授权可访问的通讯录范围，包括可访问的部门列表、用户列表和用户组列表。</para>
/// <para>## 注意事项</para>
/// <para>- 当应用通讯录权限范围为全部成员时，该接口将返回根部门下的一级部门列表和直属用户列表，以及租户下所有用户组列表。</para>
/// <para>- 当应用通讯录权限范围不为全部成员时，则只返回在通讯录权限范围内的部门列表（不包含部门内的子部门以及用户）、用户列表或用户组列表。</para>
/// <para>接口ID：7026591401610543108</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/contact-v3/scope/list</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fcontact-v3%2fscope%2flist</para>
/// </summary>
public record GetContactV3ScopesResponseDto
{
    /// <summary>
    /// <para>已授权的部门列表。列表内的部门 ID 类型与查询参数 department_id_type 的取值一致。</para>
    /// <para>必填：否</para>
    /// <para>示例值：od-8756c536552a91988b1b64559356c5a4</para>
    /// </summary>
    [JsonPropertyName("department_ids")]
    public string[]? DepartmentIds { get; set; }

    /// <summary>
    /// <para>已授权的用户列表。列表内的用户 ID 类型与查询参数 user_id_type 的取值一致。</para>
    /// <para>应用申请以下权限后才会返回该值。</para>
    /// <para>- contact:user.employee_id:readonly : 获取用户 user ID</para>
    /// <para>必填：否</para>
    /// <para>示例值：ou_5f3e2df282bf5aaeeaa2ea71ab9f1229</para>
    /// </summary>
    [JsonPropertyName("user_ids")]
    public string[]? UserIds { get; set; }

    /// <summary>
    /// <para>已授权的用户组。</para>
    /// <para>必填：否</para>
    /// <para>示例值：["g193821"]</para>
    /// </summary>
    [JsonPropertyName("group_ids")]
    public string[]? GroupIds { get; set; }

    /// <summary>
    /// <para>是否还有更多项</para>
    /// <para>必填：否</para>
    /// <para>示例值：true</para>
    /// </summary>
    [JsonPropertyName("has_more")]
    public bool? HasMore { get; set; }

    /// <summary>
    /// <para>分页标记，当 has_more 为 true 时，会同时返回新的 page_token，否则不返回 page_token</para>
    /// <para>必填：否</para>
    /// <para>示例值：AQD9/Rn9eij9Pm39ED40/dk53s4Ebp882DYfFaPFbz00L4CMZJrqGdzNyc8BcZtDbwVUvRmQTvyMYicnGWrde9X56TgdBuS+JKiSIkdexPw=</para>
    /// </summary>
    [JsonPropertyName("page_token")]
    public string? PageToken { get; set; }
}
