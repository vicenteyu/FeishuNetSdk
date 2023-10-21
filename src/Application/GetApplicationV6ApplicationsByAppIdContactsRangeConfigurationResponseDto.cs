using Newtonsoft.Json;
namespace FeishuNetSdk.Application;
/// <summary>
/// 获取应用通讯录权限范围配置 响应体
/// <para>获取当前企业内某个自建应用线上实际生效的通讯录权限范围配置。</para>
/// <para>接口ID：7218093640928133124</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/application-v6/admin/contacts_range_configuration</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fapplication-v6%2fapplication%2fcontacts_range_configuration</para>
/// </summary>
public record GetApplicationV6ApplicationsByAppIdContactsRangeConfigurationResponseDto
{
    /// <summary>
    /// <para>获取线上已生效的通讯录权限范围配置</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonProperty("contacts_range")]
    public ApplicationAppContactsRange? ContactsRange { get; set; }

    /// <summary>
    /// <para>获取线上已生效的通讯录权限范围配置</para>
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
        [JsonProperty("contacts_scope_type")]
        public string? ContactsScopeType { get; set; }

        /// <summary>
        /// <para>通讯录权限范围的可用名单</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonProperty("visible_list")]
        public AppVisibleList? VisibleList { get; set; }

        /// <summary>
        /// <para>通讯录权限范围的可用名单</para>
        /// </summary>
        public record AppVisibleList
        {
            /// <summary>
            /// <para>通讯录权限范围的可用成员 id 列表，按照user_id_type返回</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonProperty("open_ids")]
            public string[]? OpenIds { get; set; }

            /// <summary>
            /// <para>通讯录权限范围的可用部门的 id 列表</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonProperty("department_ids")]
            public string[]? DepartmentIds { get; set; }

            /// <summary>
            /// <para>通讯录权限范围的可用用户组 id 列表</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonProperty("group_ids")]
            public string[]? GroupIds { get; set; }
        }
    }

    /// <summary>
    /// <para>是否还有更多项</para>
    /// <para>必填：否</para>
    /// <para>示例值：true</para>
    /// </summary>
    [JsonProperty("has_more")]
    public bool? HasMore { get; set; }

    /// <summary>
    /// <para>分页标记，当 has_more 为 true 时，会同时返回新的 page_token，否则不返回 page_token</para>
    /// <para>必填：否</para>
    /// <para>示例值：new-e3c5a0627cdf0c2e057da7257b90376a</para>
    /// </summary>
    [JsonProperty("page_token")]
    public string? PageToken { get; set; }
}
