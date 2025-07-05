// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-07-04
// ************************************************************************
// <copyright file="PutDriveV1PermissionsByTokenMembersByMemberIdResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>更新协作者权限 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Ccm;
/// <summary>
/// 更新协作者权限 响应体
/// <para>更新指定云文档中指定协作者的权限，包括可阅读、可编辑、可管理权限。</para>
/// <para>## 前提条件</para>
/// <para>- 该接口要求文档协作者已存在（可通过[获取协作者列表](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/drive-v1/permission-member/list)确认）。如还未对文档协作者授权请先调用[「增加协作者权限」 ](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/drive-v1/permission-member/create)接口进行授权。</para>
/// <para>调用该接口需要调用身份有该云文档管理权限。</para>
/// <para>- 调用该接口时，需要调用身份与被授权对象 **互相可见**，例如：</para>
/// <para>- **为用户更新权限**：需要调用身份与被授权对象为联系人或同组织内可搜索，且互相未屏蔽。</para>
/// <para>- **为群更新权限**：需要调用身份在群内。要使用 `tenant_access_token` 身份添加群协作者，则需要将该应用作为机器人添加至群组中，使应用对群可见。详细步骤参考[如何为应用开通云文档相关资源的权限](https://open.feishu.cn/document/uAjLw4CM/ugTN1YjL4UTN24CO1UjN/trouble-shooting/how-to-add-permissions-to-app)。</para>
/// <para>- **为部门更新权限**：需要调用身份对部门可见。由于应用对企业内的组织架构都不可见，所以暂不支持通过 `tenant_access_token` 添加部门协作者。</para>
/// <para>接口ID：6998069547745230876</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/docs/permission/permission-member/update</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fdrive-v1%2fpermission-member%2fupdate</para>
/// </summary>
public record PutDriveV1PermissionsByTokenMembersByMemberIdResponseDto
{
    /// <summary>
    /// <para>本次更新权限的用户信息</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("member")]
    public BaseMember? Member { get; set; }

    /// <summary>
    /// <para>本次更新权限的用户信息</para>
    /// </summary>
    public record BaseMember
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
        /// <item>wikispaceid：知识空间 ID</item>
        /// </list></para>
        /// </summary>
        [JsonPropertyName("member_type")]
        public string MemberType { get; set; } = string.Empty;

        /// <summary>
        /// <para>协作者 ID，该 ID 的类型与 member_type 指定的值需要保持一致</para>
        /// <para>必填：是</para>
        /// <para>示例值：ou_1234567890abcdef1234567890abcdef</para>
        /// </summary>
        [JsonPropertyName("member_id")]
        public string MemberId { get; set; } = string.Empty;

        /// <summary>
        /// <para>协作者对应的权限角色</para>
        /// <para>**注意：** 妙记还不支持可管理角色。</para>
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
        /// <para>协作者的权限角色类型。当云文档类型为 wiki 即知识库节点时，该参数有效</para>
        /// <para>必填：否</para>
        /// <para>示例值：container</para>
        /// <para>可选值：<list type="bullet">
        /// <item>container：当前页面及子页面</item>
        /// <item>single_page：仅当前页面，当且仅当在知识库文档中该参数有效</item>
        /// </list></para>
        /// <para>默认值：container</para>
        /// </summary>
        [JsonPropertyName("perm_type")]
        public string? PermType { get; set; }

        /// <summary>
        /// <para>协作者类型。</para>
        /// <para>**注意**：当 `member_type` 参数为 `wikispaceid` 时，该参数必填。</para>
        /// <para>**默认值**：""</para>
        /// <para>必填：否</para>
        /// <para>示例值：user</para>
        /// <para>可选值：<list type="bullet">
        /// <item>user：用户</item>
        /// <item>chat：群组</item>
        /// <item>department：组织架构</item>
        /// <item>group：用户组</item>
        /// <item>wiki_space_member：知识库成员。在知识库启用了成员分组功能后不支持该参数</item>
        /// <item>wiki_space_viewer：知识库可阅读成员。仅在知识库启用了成员分组功能后才支持该参数</item>
        /// <item>wiki_space_editor：知识库可编辑成员。仅在知识库启用了成员分组功能后才支持该参数</item>
        /// </list></para>
        /// </summary>
        [JsonPropertyName("type")]
        public string? Type { get; set; }
    }
}
