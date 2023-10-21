using Newtonsoft.Json;
namespace FeishuNetSdk.Application;
/// <summary>
/// 更新应用可用范围 请求体
/// <para>该接口用于更新当前企业内自建应用或已安装的商店应用的可见范围，包括可用人员与禁用人员。更新后对线上立即生效。</para>
/// <para>接口ID：7278520881743740931</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/application-v6/application-visibility/patch</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fapplication-v6%2fapplication-visibility%2fpatch</para>
/// </summary>
public record PatchApplicationV6ApplicationsByAppIdVisibilityBodyDto
{
    /// <summary>
    /// <para>添加可用人员列表，如果参数is_visible_to_all不设置且当前已经是全员可见，或者参数is_visible_to_all设置为true，则该参数不生效</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonProperty("add_visible_list")]
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
        [JsonProperty("user_ids")]
        public string[]? UserIds { get; set; }

        /// <summary>
        /// <para>部门id列表 id类型根据department_id_type参数指定</para>
        /// <para>必填：否</para>
        /// <para>最大长度：100</para>
        /// </summary>
        [JsonProperty("department_ids")]
        public string[]? DepartmentIds { get; set; }

        /// <summary>
        /// <para>用户组id列表</para>
        /// <para>必填：否</para>
        /// <para>最大长度：100</para>
        /// </summary>
        [JsonProperty("group_ids")]
        public string[]? GroupIds { get; set; }
    }

    /// <summary>
    /// <para>删除可用人员列表，如果参数is_visible_to_all不设置且当前已经是全员可见，或者参数is_visible_to_all设置为true，则该参数不生效</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonProperty("del_visible_list")]
    public AppVisibilityIdList? DelVisibleList { get; set; }

    /// <summary>
    /// <para>添加禁用人员列表</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonProperty("add_invisible_list")]
    public AppVisibilityIdList? AddInvisibleList { get; set; }

    /// <summary>
    /// <para>删除禁用人员列表</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonProperty("del_invisible_list")]
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
    [JsonProperty("is_visible_to_all")]
    public bool? IsVisibleToAll { get; set; }
}
