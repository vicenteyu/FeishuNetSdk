// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-06-24
// ************************************************************************
// <copyright file="PostBitableV1AppsByAppTokenRolesByRoleIdMembersBatchCreateBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>批量新增协作者 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Base;
/// <summary>
/// 批量新增协作者 请求体
/// <para>批量新增多维表格高级权限中自定义角色的协作者。</para>
/// <para>## 前提条件</para>
/// <para>要调用协作者相关接口，你需确保多维表格已开启高级权限并设置了自定义角色。你可通过[更新多维表格元数据](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/bitable-v1/app/update)接口开启高级权限，通过[新增自定义角色](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/bitable-v1/app-role/create)接口设置自定义角色。</para>
/// <para>接口ID：7111246853309087747</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/docs/bitable-v1/advanced-permission/app-role-member/batch_create</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fbitable-v1%2fapp-role-member%2fbatch_create</para>
/// </summary>
public record PostBitableV1AppsByAppTokenRolesByRoleIdMembersBatchCreateBodyDto
{
    /// <summary>
    /// <para>协作者列表</para>
    /// <para>必填：是</para>
    /// <para>最大长度：100</para>
    /// </summary>
    [JsonPropertyName("member_list")]
    public AppRoleMemberId[] MemberLists { get; set; } = [];

    /// <summary>
    /// <para>协作者列表</para>
    /// </summary>
    public record AppRoleMemberId
    {
        /// <summary>
        /// <para>协作者 ID 的类型</para>
        /// <para>必填：否</para>
        /// <para>示例值：open_id</para>
        /// <para>可选值：<list type="bullet">
        /// <item>open_id：以 open_id 来识别协作者。获取方式参考[如何获取不同的用户 ID](https://open.feishu.cn/document/home/user-identity-introduction/open-id)。</item>
        /// <item>union_id：以 union_id 来识别协作者。获取方式参考[如何获取不同的用户 ID](https://open.feishu.cn/document/home/user-identity-introduction/open-id)</item>
        /// <item>user_id：以 user_id 来识别协作者。获取方式参考[如何获取不同的用户 ID](https://open.feishu.cn/document/home/user-identity-introduction/open-id)</item>
        /// <item>chat_id：以 chat_id 来识别协作者。获取方式参考[群 ID 说明](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/im-v1/chat-id-description)</item>
        /// <item>department_id：以 department_id 来识别协作者。调用前，请确保应用有部门的可见性，参考[配置应用可用范围](https://open.feishu.cn/document/home/introduction-to-scope-and-authorization/availability)。获取 department_id 方式参考[部门资源介绍](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/contact-v3/department/field-overview)</item>
        /// <item>open_department_id：以 open_department_id 来识别协作者。调用前，请确保应用有部门的可见性，参考[配置应用可用范围](https://open.feishu.cn/document/home/introduction-to-scope-and-authorization/availability)。获取 open_department_id 方式参考[部门资源介绍](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/contact-v3/department/field-overview)</item>
        /// </list></para>
        /// <para>默认值：open_id</para>
        /// </summary>
        [JsonPropertyName("type")]
        public string? Type { get; set; }

        /// <summary>
        /// <para>协作者的 ID，需与 type 的类型需一致。获取 ID 方式参考 type 参数描述。</para>
        /// <para>必填：是</para>
        /// <para>示例值：ou_35990a9d9052051a2fae9b2f1afabcef</para>
        /// </summary>
        [JsonPropertyName("id")]
        public string Id { get; set; } = string.Empty;
    }
}
