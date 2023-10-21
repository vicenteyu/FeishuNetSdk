using Newtonsoft.Json;
namespace FeishuNetSdk.Application;
/// <summary>
/// 查询用户或部门是否在应用的可用或禁用名单 响应体
/// <para>该接口用于查询用户、部门、用户组是否在应用的可用或禁用名单中</para>
/// <para>接口ID：7218093640928149508</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/application-v6/admin/check_white_black_list</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fapplication-v6%2fapplication-visibility%2fcheck_white_black_list</para>
/// </summary>
public record PostApplicationV6ApplicationsByAppIdVisibilityCheckWhiteBlackListResponseDto
{
    /// <summary>
    /// <para>查询的用户可见性结果列表，如果用户在白名单或付费白名单，且不在黑名单中，则可见该应用</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonProperty("user_visibility_list")]
    public ApplicationVisibilityUserWhiteBlackInfo[]? UserVisibilityLists { get; set; }

    /// <summary>
    /// <para>查询的用户可见性结果列表，如果用户在白名单或付费白名单，且不在黑名单中，则可见该应用</para>
    /// </summary>
    public record ApplicationVisibilityUserWhiteBlackInfo
    {
        /// <summary>
        /// <para>查询的用户ID，ID类型和user_id_type传参类型一致</para>
        /// <para>必填：否</para>
        /// <para>示例值：ou_d317f090b7258ad0372aa53963cda70d</para>
        /// </summary>
        [JsonProperty("user_id")]
        public string? UserId { get; set; }

        /// <summary>
        /// <para>是否在白名单。</para>
        /// <para>**可选值**：</para>
        /// <para>- **true**：在白名单</para>
        /// <para>- **false**：不在白名单</para>
        /// <para>必填：否</para>
        /// <para>示例值：false</para>
        /// </summary>
        [JsonProperty("in_white_list")]
        public bool? InWhiteList { get; set; }

        /// <summary>
        /// <para>是否在黑名单。</para>
        /// <para>**可选值**：</para>
        /// <para>- **true**：在黑名单</para>
        /// <para>- **false**：不在黑名单</para>
        /// <para>必填：否</para>
        /// <para>示例值：false</para>
        /// </summary>
        [JsonProperty("in_black_list")]
        public bool? InBlackList { get; set; }

        /// <summary>
        /// <para>是否在付费名单。</para>
        /// <para>**可选值**：</para>
        /// <para>- **true**：在付费名单</para>
        /// <para>- **false**：不在付费名单</para>
        /// <para>必填：否</para>
        /// <para>示例值：false</para>
        /// </summary>
        [JsonProperty("in_paid_list")]
        public bool? InPaidList { get; set; }
    }

    /// <summary>
    /// <para>查询的部门可见性结果列表，如果部门在白名单，且不在黑名单，则该部门下的用户可见该应用</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonProperty("department_visibility_list")]
    public ApplicationVisibilityDepartmentWhiteBlackInfo[]? DepartmentVisibilityLists { get; set; }

    /// <summary>
    /// <para>查询的部门可见性结果列表，如果部门在白名单，且不在黑名单，则该部门下的用户可见该应用</para>
    /// </summary>
    public record ApplicationVisibilityDepartmentWhiteBlackInfo
    {
        /// <summary>
        /// <para>查询的部门ID</para>
        /// <para>必填：否</para>
        /// <para>示例值：od-aa2c50a04769feefededb7a05b7525a8</para>
        /// </summary>
        [JsonProperty("department_id")]
        public string? DepartmentId { get; set; }

        /// <summary>
        /// <para>是否在白名单。</para>
        /// <para>**可选值**：</para>
        /// <para>- **true**：在白名单</para>
        /// <para>- **false**：不在白名单</para>
        /// <para>必填：否</para>
        /// <para>示例值：false</para>
        /// </summary>
        [JsonProperty("in_white_list")]
        public bool? InWhiteList { get; set; }

        /// <summary>
        /// <para>是否在黑名单。</para>
        /// <para>**可选值**：</para>
        /// <para>- **true**：在黑名单</para>
        /// <para>- **false**：不在黑名单</para>
        /// <para>必填：否</para>
        /// <para>示例值：false</para>
        /// </summary>
        [JsonProperty("in_black_list")]
        public bool? InBlackList { get; set; }
    }

    /// <summary>
    /// <para>查询的用户组可见性结果列表，如果用户组在白名单，且不在黑名单，则该用户组下的用户可见该应用</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonProperty("group_visibility_list")]
    public ApplicationVisibilityGroupWhiteBlackInfo[]? GroupVisibilityLists { get; set; }

    /// <summary>
    /// <para>查询的用户组可见性结果列表，如果用户组在白名单，且不在黑名单，则该用户组下的用户可见该应用</para>
    /// </summary>
    public record ApplicationVisibilityGroupWhiteBlackInfo
    {
        /// <summary>
        /// <para>查询的用户组ID</para>
        /// <para>必填：否</para>
        /// <para>示例值：96815a9cd9beg8g4</para>
        /// </summary>
        [JsonProperty("group_id")]
        public string? GroupId { get; set; }

        /// <summary>
        /// <para>是否在白名单。</para>
        /// <para>**可选值**：</para>
        /// <para>- **true**：在白名单</para>
        /// <para>- **false**：不在白名单</para>
        /// <para>必填：否</para>
        /// <para>示例值：false</para>
        /// </summary>
        [JsonProperty("in_white_list")]
        public bool? InWhiteList { get; set; }

        /// <summary>
        /// <para>是否在黑名单。</para>
        /// <para>**可选值**：</para>
        /// <para>- **true**：在黑名单</para>
        /// <para>- **false**：不在黑名单</para>
        /// <para>必填：否</para>
        /// <para>示例值：false</para>
        /// </summary>
        [JsonProperty("in_black_list")]
        public bool? InBlackList { get; set; }
    }
}
