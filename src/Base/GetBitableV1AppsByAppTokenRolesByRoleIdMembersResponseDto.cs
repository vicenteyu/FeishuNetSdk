// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-06-24
// ************************************************************************
// <copyright file="GetBitableV1AppsByAppTokenRolesByRoleIdMembersResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>列出协作者 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Base;
/// <summary>
/// 列出协作者 响应体
/// <para>列出多维表格高级权限中自定义角色的协作者。</para>
/// <para>## 前提条件</para>
/// <para>要调用协作者相关接口，你需确保多维表格已开启高级权限并设置了自定义角色。你可通过[更新多维表格元数据](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/bitable-v1/app/update)接口开启高级权限，通过[新增自定义角色](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/bitable-v1/app-role/create)接口设置自定义角色。</para>
/// <para>接口ID：7101134500528668675</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/docs/bitable-v1/advanced-permission/app-role-member/list</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fbitable-v1%2fapp-role-member%2flist</para>
/// </summary>
public record GetBitableV1AppsByAppTokenRolesByRoleIdMembersResponseDto
{
    /// <summary>
    /// <para>协作者列表</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("items")]
    public AppRoleMember[]? Items { get; set; }

    /// <summary>
    /// <para>协作者列表</para>
    /// </summary>
    public record AppRoleMember
    {
        /// <summary>
        /// <para>协作者的 open_id</para>
        /// <para>必填：否</para>
        /// <para>示例值：ou_7dab8a3d3cdcc9da365777c7ad5abcef</para>
        /// </summary>
        [JsonPropertyName("open_id")]
        public string? OpenId { get; set; }

        /// <summary>
        /// <para>协作者的 union_id</para>
        /// <para>必填：否</para>
        /// <para>示例值：on_7dab8a3d3cdcc9da365777c7ad5abcef</para>
        /// </summary>
        [JsonPropertyName("union_id")]
        public string? UnionId { get; set; }

        /// <summary>
        /// <para>协作者的 user_id</para>
        /// <para>必填：否</para>
        /// <para>示例值：13e4beac</para>
        /// </summary>
        [JsonPropertyName("user_id")]
        public string? UserId { get; set; }

        /// <summary>
        /// <para>协作者为一个群聊，群聊的 chat_id</para>
        /// <para>必填：否</para>
        /// <para>示例值：oc_a0553eda9014c201e6969b478895c230</para>
        /// </summary>
        [JsonPropertyName("chat_id")]
        public string? ChatId { get; set; }

        /// <summary>
        /// <para>协作者为一个部门，部门的 department_id</para>
        /// <para>必填：否</para>
        /// <para>示例值：h121921</para>
        /// </summary>
        [JsonPropertyName("department_id")]
        public string? DepartmentId { get; set; }

        /// <summary>
        /// <para>协作者为一个部门，部门的 open_department_id</para>
        /// <para>必填：否</para>
        /// <para>示例值：od-4e6ac4d14bcd5071a37a39de902c7141</para>
        /// </summary>
        [JsonPropertyName("open_department_id")]
        public string? OpenDepartmentId { get; set; }

        /// <summary>
        /// <para>协作者的名称</para>
        /// <para>必填：否</para>
        /// <para>示例值：张敏</para>
        /// </summary>
        [JsonPropertyName("member_name")]
        public string? MemberName { get; set; }

        /// <summary>
        /// <para>协作者的英文名称</para>
        /// <para>必填：否</para>
        /// <para>示例值：Min Zhang</para>
        /// </summary>
        [JsonPropertyName("member_en_name")]
        public string? MemberEnName { get; set; }

        /// <summary>
        /// <para>协作者的类型</para>
        /// <para>必填：否</para>
        /// <para>示例值：user</para>
        /// <para>可选值：<list type="bullet">
        /// <item>user：用户</item>
        /// <item>chat：群组</item>
        /// <item>department：部门</item>
        /// </list></para>
        /// </summary>
        [JsonPropertyName("member_type")]
        public string? MemberType { get; set; }
    }

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
    /// <para>示例值：eVQrYzJBNDNONlk4VFZBZVlSdzlKdFJ4bVVHVExENDNKVHoxaVdiVnViQT0=</para>
    /// </summary>
    [JsonPropertyName("page_token")]
    public string? PageToken { get; set; }

    /// <summary>
    /// <para>总数</para>
    /// <para>必填：否</para>
    /// <para>示例值：10</para>
    /// </summary>
    [JsonPropertyName("total")]
    public int? Total { get; set; }
}
