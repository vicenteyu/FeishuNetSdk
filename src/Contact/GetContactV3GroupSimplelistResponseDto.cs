// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-06-24
// ************************************************************************
// <copyright file="GetContactV3GroupSimplelistResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>查询用户组列表 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Contact;
/// <summary>
/// 查询用户组列表 响应体
/// <para>调用该接口查询当前租户下的用户组列表，列表内包含用户组的 ID、名字、成员数量和类型等信息。</para>
/// <para>接口ID：7008085931593039875</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/contact-v3/group/simplelist</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fcontact-v3%2fgroup%2fsimplelist</para>
/// </summary>
public record GetContactV3GroupSimplelistResponseDto
{
    /// <summary>
    /// <para>用户组列表信息。</para>
    /// <para>必填：是</para>
    /// </summary>
    [JsonPropertyName("grouplist")]
    public Group[] Grouplists { get; set; } = Array.Empty<Group>();

    /// <summary>
    /// <para>用户组列表信息。</para>
    /// </summary>
    public record Group
    {
        /// <summary>
        /// <para>用户组 ID，该 ID 可用于删除、更新、查询用户组。</para>
        /// <para>必填：是</para>
        /// <para>示例值：g193821</para>
        /// </summary>
        [JsonPropertyName("id")]
        public string Id { get; set; } = string.Empty;

        /// <summary>
        /// <para>用户组名字。</para>
        /// <para>必填：是</para>
        /// <para>示例值：IT 外包组</para>
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; } = string.Empty;

        /// <summary>
        /// <para>用户组描述。</para>
        /// <para>必填：否</para>
        /// <para>示例值：IT 外包组，需要对该组人群进行细颗粒度权限管控。</para>
        /// </summary>
        [JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// <para>用户组成员中的用户数量。</para>
        /// <para>必填：否</para>
        /// <para>示例值：2</para>
        /// </summary>
        [JsonPropertyName("member_user_count")]
        public int? MemberUserCount { get; set; }

        /// <summary>
        /// <para>普通用户组成员中的部门数量。</para>
        /// <para>**说明**：动态用户组成员中没有部门。</para>
        /// <para>必填：否</para>
        /// <para>示例值：0</para>
        /// </summary>
        [JsonPropertyName("member_department_count")]
        public int? MemberDepartmentCount { get; set; }

        /// <summary>
        /// <para>用户组的类型。</para>
        /// <para>必填：否</para>
        /// <para>示例值：1</para>
        /// <para>可选值：<list type="bullet">
        /// <item>1：普通用户组</item>
        /// <item>2：动态用户组</item>
        /// </list></para>
        /// </summary>
        [JsonPropertyName("type")]
        public int? Type { get; set; }

        /// <summary>
        /// <para>部门范围，以部门 ID 列表形式展示。</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("department_scope_list")]
        public string[]? DepartmentScopeList { get; set; }

        /// <summary>
        /// <para>自定义用户组 ID。</para>
        /// <para>必填：否</para>
        /// <para>示例值：4ba51ab38648f9cd</para>
        /// </summary>
        [JsonPropertyName("group_id")]
        public string? GroupId { get; set; }
    }

    /// <summary>
    /// <para>分页标记，当 has_more 为 true 时，会同时返回新的 page_token，否则不返回 page_token</para>
    /// <para>必填：是</para>
    /// <para>示例值：AQD9/Rn9556539ED40/dk53s4Ebp882DYfFaPFbz00L4CMZJrqGdzNyc8BcZtDbwVUvRmQTvyMYicnGWrde9X56TgdBuS+JDTJJDDPw=</para>
    /// </summary>
    [JsonPropertyName("page_token")]
    public string PageToken { get; set; } = string.Empty;

    /// <summary>
    /// <para>是否还有更多项</para>
    /// <para>必填：是</para>
    /// <para>示例值：true</para>
    /// </summary>
    [JsonPropertyName("has_more")]
    public bool HasMore { get; set; }
}
