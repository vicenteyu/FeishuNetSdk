// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-06-24
// ************************************************************************
// <copyright file="GetApplicationV6ApplicationsByAppIdAppVersionsByVersionIdContactsRangeSuggestResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>获取应用版本中开发者申请的通讯录权限范围 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Application;
/// <summary>
/// 获取应用版本中开发者申请的通讯录权限范围 响应体
/// <para>该接口用于根据应用的 App ID 和版本 ID 获取企业自建应用某个版本的通讯录权限范围。</para>
/// <para>接口ID：7218093640928165892</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/application-v6/application/contacts_range_suggest</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fapplication-v6%2fapplication-app_version%2fcontacts_range_suggest</para>
/// </summary>
public record GetApplicationV6ApplicationsByAppIdAppVersionsByVersionIdContactsRangeSuggestResponseDto
{
    /// <summary>
    /// <para>应用版本通讯录权限范围建议信息。开发者在提交该版本时如果修改了通讯录权限范围则返回申请的通讯录权限范围。不代表最终应用生效的通讯录权限范围。如果没有修改,则为空。【如果通讯录权限范围与应用可用范围保持一致，上次的配置也是如此，则认为没变化。】</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("contacts_range")]
    public ApplicationAppContactsRange? ContactsRange { get; set; }

    /// <summary>
    /// <para>应用版本通讯录权限范围建议信息。开发者在提交该版本时如果修改了通讯录权限范围则返回申请的通讯录权限范围。不代表最终应用生效的通讯录权限范围。如果没有修改,则为空。【如果通讯录权限范围与应用可用范围保持一致，上次的配置也是如此，则认为没变化。】</para>
    /// </summary>
    public record ApplicationAppContactsRange
    {
        /// <summary>
        /// <para>通讯录可见性类型</para>
        /// <para>必填：否</para>
        /// <para>示例值：some</para>
        /// <para>可选值：<list type="bullet">
        /// <item>equal_to_availability：与应用可用范围一致，可通过[获取应用在企业内的可用范围](https://open.feishu.cn/document/ukTMukTMukTM/uIjM3UjLyIzN14iMycTN)接口查询具体人员</item>
        /// <item>some：部分成员，具体人员参见visible_list</item>
        /// <item>all：全部成员</item>
        /// </list></para>
        /// </summary>
        [JsonPropertyName("contacts_scope_type")]
        public string? ContactsScopeType { get; set; }

        /// <summary>
        /// <para>通讯录权限范围的可用名单</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("visible_list")]
        public AppVisibleList? VisibleList { get; set; }

        /// <summary>
        /// <para>通讯录权限范围的可用名单</para>
        /// </summary>
        public record AppVisibleList
        {
            /// <summary>
            /// <para>通讯录权限范围的可用成员id列表，按照user_id_type返回</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("open_ids")]
            public string[]? OpenIds { get; set; }

            /// <summary>
            /// <para>通讯录权限范围的可用部门的 id 列表</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("department_ids")]
            public string[]? DepartmentIds { get; set; }

            /// <summary>
            /// <para>通讯录权限范围的可用用户组 id 列表</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("group_ids")]
            public string[]? GroupIds { get; set; }
        }
    }
}
