namespace FeishuNetSdk.Contact;
/// <summary>
/// 获取通讯录授权范围 响应体
/// <para>该接口用于获取应用被授权可访问的通讯录范围，包括可访问的部门列表、用户列表和用户组列表。</para>
/// <para>授权范围为全员时，返回的部门列表为该企业所有的一级部门；否则返回的部门为管理员在设置授权范围时勾选的部门（不包含勾选部门的子部门）。</para>
/// <para>接口ID：7026591401610543108</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/contact-v3/scope/list</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fcontact-v3%2fscope%2flist</para>
/// </summary>
public record GetContactV3ScopesResponseDto
{
    /// <summary>
    /// <para>已授权部门列表，授权范围为全员可见时返回的是当前企业的所有一级部门列表</para>
    /// <para>必填：否</para>
    /// <para>示例值：od-8756c536552a91988b1b64559356c5a4</para>
    /// </summary>
    [JsonPropertyName("department_ids")]
    public string[]? DepartmentIds { get; set; }

    /// <summary>
    /// <para>已授权用户列表，应用申请了获取用户user_id 权限时返回；当授权范围为全员可见时返回的是当前企业所有顶级部门用户列表</para>
    /// <para>必填：否</para>
    /// <para>示例值：ou_5f3e2df282bf5aaeeaa2ea71ab9f1229</para>
    /// </summary>
    [JsonPropertyName("user_ids")]
    public string[]? UserIds { get; set; }

    /// <summary>
    /// <para>已授权的用户组，授权范围为全员可见时返回的是当前企业所有用户组</para>
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
