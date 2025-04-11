// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-06-24
// ************************************************************************
// <copyright file="PatchApplicationV6ApplicationsByAppIdVisibilityBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>更新应用可用范围 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Application;
/// <summary>
/// 更新应用可用范围 请求体
/// <para>调用该接口更新指定应用的可用范围，支持更新当前企业内自建应用的可用范围，或者已安装的商店应用的可用范围，包括可用人员与禁用人员。更新可用范围后对线上立即生效。</para>
/// <para>## 注意事项</para>
/// <para>- 该接口仅支持被企业自建应用调用，但传入的路径参数 app_id 可以是企业自建应用的 app_id，也可以是商店应用的 app_id。</para>
/// <para>- 当通过接口新增用户或部门时，提前判断对应用户或部门是否已在禁用名单中，如果已在禁用名单中，则即便将用户或部门添加到可用名单，该用户或部门也无法看到该应用，即禁用名单优先级高于可用名单。</para>
/// <para>- 同一个成员(user_id) 在30s内不能重复添加到禁用名单，否则会导致调用失败。</para>
/// <para>接口ID：7278520881743740931</para>
/// <para>文档地址：https://open.feishu.cn/document/application-v6/admin/patch-5</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fapplication-v6%2fapplication-visibility%2fpatch</para>
/// </summary>
public record PatchApplicationV6ApplicationsByAppIdVisibilityBodyDto
{
    /// <summary>
    /// <para>添加可用人员列表，如果参数is_visible_to_all不设置且当前已经是全员可见，或者参数is_visible_to_all设置为true，则该参数不生效</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("add_visible_list")]
    public AppVisibilityIdList? AddVisibleList { get; set; }

    /// <summary>
    /// <para>添加可用人员列表，如果参数is_visible_to_all不设置且当前已经是全员可见，或者参数is_visible_to_all设置为true，则该参数不生效</para>
    /// </summary>
    public record AppVisibilityIdList
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
        /// <para>用户组id列表</para>
        /// <para>必填：否</para>
        /// <para>最大长度：100</para>
        /// </summary>
        [JsonPropertyName("group_ids")]
        public string[]? GroupIds { get; set; }
    }

    /// <summary>
    /// <para>删除可用人员列表，如果参数is_visible_to_all不设置且当前已经是全员可见，或者参数is_visible_to_all设置为true，则该参数不生效</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("del_visible_list")]
    public AppVisibilityIdList? DelVisibleList { get; set; }

    /// <summary>
    /// <para>添加禁用人员列表</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("add_invisible_list")]
    public AppVisibilityIdList? AddInvisibleList { get; set; }

    /// <summary>
    /// <para>删除禁用人员列表</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("del_invisible_list")]
    public AppVisibilityIdList? DelInvisibleList { get; set; }

    /// <summary>
    /// <para>是否全员可见</para>
    /// <para>false：否</para>
    /// <para>true：是</para>
    /// <para>不设置：继续保持当前状态不改变</para>
    /// <para>如果参数不设置且当前已经是全员可见，或者设置为true，则add_visible_list/del_visible_list不生效</para>
    /// <para>必填：否</para>
    /// <para>示例值：false</para>
    /// </summary>
    [JsonPropertyName("is_visible_to_all")]
    public bool? IsVisibleToAll { get; set; }
}
