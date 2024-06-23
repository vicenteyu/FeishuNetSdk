// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-06-24
// ************************************************************************
// <copyright file="PatchApplicationV6ApplicationsByAppIdContactsRangeBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>更新应用通讯录权限范围配置 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Application;
/// <summary>
/// 更新应用通讯录权限范围配置 请求体
/// <para>该接口用于更新当前企业内自建应用或已安装的商店应用的通讯录权限范围配置。更新后线上立即生效。</para>
/// <para>接口ID：7278520881743724547</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/application-v6/application-contacts_range/patch</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fapplication-v6%2fapplication-contacts_range%2fpatch</para>
/// </summary>
public record PatchApplicationV6ApplicationsByAppIdContactsRangeBodyDto
{
    /// <summary>
    /// <para>更新范围方式</para>
    /// <para>必填：是</para>
    /// <para>示例值：some</para>
    /// <para>可选值：<list type="bullet">
    /// <item>equal_to_availability：与应用可用性始终保持一致</item>
    /// <item>some：部分成员</item>
    /// <item>all：全部成员范围</item>
    /// </list></para>
    /// </summary>
    [JsonPropertyName("contacts_range_type")]
    public string ContactsRangeType { get; set; } = string.Empty;

    /// <summary>
    /// <para>通讯录权限范围新增列表</para>
    /// <para>仅contacts_range_type为some 时生效并进行增量更新</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("add_visible_list")]
    public AppContactsRangeIdList? AddVisibleList { get; set; }

    /// <summary>
    /// <para>通讯录权限范围新增列表</para>
    /// <para>仅contacts_range_type为some 时生效并进行增量更新</para>
    /// </summary>
    public record AppContactsRangeIdList
    {
        /// <summary>
        /// <para>成员id列表 id类型根据user_id_type参数指定</para>
        /// <para>必填：否</para>
        /// <para>最大长度：100</para>
        /// </summary>
        [JsonPropertyName("user_ids")]
        public string[]? UserIds { get; set; }

        /// <summary>
        /// <para>部门id列表 id类型根据department_id_type参数指定</para>
        /// <para>必填：否</para>
        /// <para>最大长度：100</para>
        /// </summary>
        [JsonPropertyName("department_ids")]
        public string[]? DepartmentIds { get; set; }

        /// <summary>
        /// <para>用户组列表</para>
        /// <para>必填：否</para>
        /// <para>最大长度：100</para>
        /// </summary>
        [JsonPropertyName("group_ids")]
        public string[]? GroupIds { get; set; }
    }

    /// <summary>
    /// <para>从通讯录权限范围删除的列表</para>
    /// <para>仅contacts_range_type为some 时生效并进行增量更新</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("del_visible_list")]
    public AppContactsRangeIdList? DelVisibleList { get; set; }
}
