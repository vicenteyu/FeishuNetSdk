// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-07-04
// ************************************************************************
// <copyright file="GetDriveV1PermissionsByTokenMembersResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>获取协作者列表（新版本） 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Ccm;
/// <summary>
/// 获取协作者列表 响应体
/// <para>该接口用于根据文件的 token 查询协作者。</para>
/// <para>接口ID：7121656165336367106</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/docs/permission/permission-member/list</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fdrive-v1%2fpermission-member%2flist</para>
/// </summary>
public record GetDriveV1PermissionsByTokenMembersResponseDto
{
    /// <summary>
    /// <para>返回的列表数据</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("items")]
    public Member[]? Items { get; set; }

    /// <summary>
    /// <para>返回的列表数据</para>
    /// </summary>
    public record Member
    {
        /// <summary>
        /// <para>协作者 ID 类型，与协作者 ID 需要对应</para>
        /// <para>必填：是</para>
        /// <para>示例值：openid</para>
        /// <para>可选值：<list type="bullet">
        /// <item>email：飞书邮箱</item>
        /// <item>openid：开放平台 ID</item>
        /// <item>unionid：开放平台 UnionID</item>
        /// <item>openchat：开放平台群组 ID</item>
        /// <item>opendepartmentid：开放平台部门 ID</item>
        /// <item>userid：用户自定义 ID</item>
        /// <item>groupid：自定义用户组 ID</item>
        /// <item>wikispaceid：知识空间 ID - **注意**：仅知识库文档支持该参数，代表知识库文档里的「知识库成员」类型协作者的 ID</item>
        /// </list></para>
        /// </summary>
        [JsonPropertyName("member_type")]
        public string MemberType { get; set; } = string.Empty;

        /// <summary>
        /// <para>协作者 ID，与协作者 ID 类型需要对应</para>
        /// <para>必填：是</para>
        /// <para>示例值：ou_7dab8a3d3cdcc9da365777c7ad535d62</para>
        /// </summary>
        [JsonPropertyName("member_id")]
        public string MemberId { get; set; } = string.Empty;

        /// <summary>
        /// <para>协作者对应的权限角色</para>
        /// <para>必填：是</para>
        /// <para>示例值：view</para>
        /// <para>可选值：<list type="bullet">
        /// <item>view：可阅读角色</item>
        /// <item>edit：可编辑角色</item>
        /// <item>full_access：可管理角色</item>
        /// </list></para>
        /// </summary>
        [JsonPropertyName("perm")]
        public string Perm { get; set; } = string.Empty;

        /// <summary>
        /// <para>协作者的权限角色类型</para>
        /// <para>必填：否</para>
        /// <para>示例值：container</para>
        /// <para>可选值：<list type="bullet">
        /// <item>container：当前页面及子页面</item>
        /// <item>single_page：仅当前页面，当且仅当在知识库文档中该参数有效</item>
        /// </list></para>
        /// </summary>
        [JsonPropertyName("perm_type")]
        public string? PermType { get; set; }

        /// <summary>
        /// <para>协作者的类型</para>
        /// <para>必填：否</para>
        /// <para>示例值：user</para>
        /// <para>可选值：<list type="bullet">
        /// <item>user：用户</item>
        /// <item>chat：群组</item>
        /// <item>department：组织架构</item>
        /// <item>group：用户组</item>
        /// <item>wiki_space_member：知识库成员 - **注意**：在知识库启用了成员分组功能后不支持该参数</item>
        /// <item>wiki_space_viewer：知识库可阅读成员 - **注意**：仅在知识库启用了成员分组功能后才支持该参数</item>
        /// <item>wiki_space_editor：知识库可编辑成员 - **注意**：仅在知识库启用了成员分组功能后才支持该参数</item>
        /// </list></para>
        /// </summary>
        [JsonPropertyName("type")]
        public string? Type { get; set; }

        /// <summary>
        /// <para>协作者的名字</para>
        /// <para>必填：否</para>
        /// <para>示例值：zhangsan</para>
        /// </summary>
        [JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// <para>协作者的头像</para>
        /// <para>必填：否</para>
        /// <para>示例值：https://foo.icon.com/xxxx</para>
        /// </summary>
        [JsonPropertyName("avatar")]
        public string? Avatar { get; set; }

        /// <summary>
        /// <para>协作者的外部标签</para>
        /// <para>必填：否</para>
        /// <para>示例值：true</para>
        /// </summary>
        [JsonPropertyName("external_label")]
        public bool? ExternalLabel { get; set; }
    }
}
