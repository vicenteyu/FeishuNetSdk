// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-07-04
// ************************************************************************
// <copyright file="PostDriveV1PermissionsByTokenMembersBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>增加协作者权限 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Ccm;
/// <summary>
/// 增加协作者权限 请求体
/// <para>为指定云文档添加协作者，协作者可以是用户、群组、部门、用户组等。</para>
/// <para>## 前提条件</para>
/// <para>- 调用该接口需要调用身份有该云文档添加协作者的权限。添加协作者的权限可通过云文档设置中的 **谁可以查看、添加、移除协作者** 等选项进行控制。</para>
/// <para>- 调用该接口时，需要调用身份与被授权对象 **互相可见**，例如：</para>
/// <para>- **添加用户协作者**：需要调用身份与被授权对象为联系人或同组织内可搜索，且互相未屏蔽。</para>
/// <para>- **添加群协作者**：需要调用身份在群内。要使用 `tenant_access_token` 身份添加群协作者，则需要将该应用作为机器人添加至群组中，使应用对群可见。详细步骤参考[如何为应用开通云文档相关资源的权限](https://open.feishu.cn/document/uAjLw4CM/ugTN1YjL4UTN24CO1UjN/trouble-shooting/how-to-add-permissions-to-app)。</para>
/// <para>- **添加部门协作者**：需要调用身份对部门可见。由于应用对企业内的组织架构都不可见，所以暂不支持通过 `tenant_access_token` 添加部门协作者。</para>
/// <para>## 注意事项</para>
/// <para>不支持将应用直接添加到文件夹作为协作者（添加成功后实际仍然没有权限）。如果希望给应用授予文件夹的权限，请将应用作为群机器人添加到群组内，然后授予该群组可管理权限。详细步骤参考[如何为应用开通云文档相关资源的权限](https://open.feishu.cn/document/uAjLw4CM/ugTN1YjL4UTN24CO1UjN/trouble-shooting/how-to-add-permissions-to-app)。</para>
/// <para>接口ID：6987581166854635521</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/docs/permission/permission-member/create</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fdrive-v1%2fpermission-member%2fcreate</para>
/// </summary>
public record PostDriveV1PermissionsByTokenMembersBodyDto
{
    /// <summary>
    /// <para>协作者 ID 类型，与协作者 ID 需要对应</para>
    /// <para>必填：是</para>
    /// <para>示例值：openid</para>
    /// <para>可选值：<list type="bullet">
    /// <item>email：飞书邮箱</item>
    /// <item>openid：开放平台 Open ID - 获取应用 OpenID，参考[如何获取应用 open_id](https://open.feishu.cn/document/ukTMukTMukTM/uczNzUjL3czM14yN3MTN#6dbaa8df) - 获取用户 OpenID，参考[如何获取不同的用户 ID](https://open.feishu.cn/document/home/user-identity-introduction/open-id)</item>
    /// <item>unionid：开放平台 Union ID。获取方式参考[如何获取不同的用户 ID](https://open.feishu.cn/document/home/user-identity-introduction/open-id)</item>
    /// <item>openchat：开放平台群组 ID。获取方式参考[群 ID 说明](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/im-v1/chat-id-description)</item>
    /// <item>opendepartmentid：开放平台部门 ID。仅当使用 &lt;md-tag mode="inline" type="token-user"&gt;user_access_token&lt;/md-tag&gt; 调用时，该参数有效。获取方式参考[部门资源介绍](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/contact-v3/department/field-overview)</item>
    /// <item>userid：用户 ID。获取方式参考[如何获取不同的用户 ID](https://open.feishu.cn/document/home/user-identity-introduction/open-id)</item>
    /// <item>groupid：自定义用户组 ID。获取方式参考[用户组资源介绍](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/contact-v3/group/overview)</item>
    /// <item>wikispaceid：知识空间 ID。仅知识库文档支持该参数，当需要操作知识库文档里的「知识库成员」类型协作者时传该参数。获取方式参考[知识库概述](https://open.feishu.cn/document/ukTMukTMukTM/uUDN04SN0QjL1QDN/wiki-overview)</item>
    /// </list></para>
    /// </summary>
    [JsonPropertyName("member_type")]
    public string MemberType { get; set; } = string.Empty;

    /// <summary>
    /// <para>协作者 ID，该 ID 的类型与 member_type 指定的值需要保持一致。</para>
    /// <para>必填：是</para>
    /// <para>示例值：ou_1234567890abcdef1234567890abcdef</para>
    /// </summary>
    [JsonPropertyName("member_id")]
    public string MemberId { get; set; } = string.Empty;

    /// <summary>
    /// <para>协作者对应的权限角色。</para>
    /// <para>必填：是</para>
    /// <para>示例值：view</para>
    /// <para>可选值：<list type="bullet">
    /// <item>view：可阅读角色</item>
    /// <item>edit：可编辑角色</item>
    /// <item>full_access：可管理角色。暂不支持妙记。</item>
    /// </list></para>
    /// </summary>
    [JsonPropertyName("perm")]
    public string Perm { get; set; } = string.Empty;

    /// <summary>
    /// <para>协作者的权限角色类型。当云文档类型为 wiki 即知识库节点时，该参数有效。</para>
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
    /// <para>**注意**：当 `member_type` 参数为 `wikispaceid` 时，该参数必填，且必须在 `wiki_space_member`、`wiki_space_viewer`、`wiki_space_editor` 中选择。</para>
    /// <para>**默认值**：""</para>
    /// <para>必填：否</para>
    /// <para>示例值：user</para>
    /// <para>可选值：<list type="bullet">
    /// <item>user：用户</item>
    /// <item>chat：群组</item>
    /// <item>department：组织架构</item>
    /// <item>group：用户组</item>
    /// <item>wiki_space_member：知识库成员。即知识库 **成员设置** 中的成员角色。若在知识库 **成员设置** 页面中，成员分为了 **可编辑成员** 和 **可阅读成员**，则不再支持该参数。你需选择下方参数</item>
    /// <item>wiki_space_viewer：知识库可阅读成员组。仅当知识库成员分为 **可编辑成员** 和 **可阅读成员** 时，支持该参数。</item>
    /// <item>wiki_space_editor：知识库可编辑成员组。仅当知识库成员分为 **可编辑成员** 和 **可阅读成员** 时，支持该参数</item>
    /// </list></para>
    /// </summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}
