using Newtonsoft.Json;
namespace FeishuNetSdk.FeishuPeople;
/// <summary>
/// 获取组织类角色授权列表 响应体
/// <para>查询组织类角色的授权信息。</para>
/// <para>接口ID：7141207412454998019</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/corehr-v1/authorization/search</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fcorehr-v1%2fassigned_user%2fsearch</para>
/// </summary>
public record PostCorehrV1AssignedUsersSearchResponseDto
{
    /// <summary>
    /// <para>用户授权信息</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonProperty("items")]
    public RoleAuthorization[]? Items { get; set; }

    /// <summary>
    /// <para>用户授权信息</para>
    /// </summary>
    public record RoleAuthorization
    {
        /// <summary>
        /// <para>员工 ID</para>
        /// <para>必填：是</para>
        /// <para>示例值：6967639606963471902</para>
        /// </summary>
        [JsonProperty("employment_id")]
        public string EmploymentId { get; set; } = string.Empty;

        /// <summary>
        /// <para>实际授权管理范围</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonProperty("management_scope_list")]
        public ManagementScope[]? ManagementScopeLists { get; set; }

        /// <summary>
        /// <para>实际授权管理范围</para>
        /// </summary>
        public record ManagementScope
        {
            /// <summary>
            /// <para>管理维度</para>
            /// <para>可选值有：</para>
            /// <para>- department：部门</para>
            /// <para>- work_location：工作地点</para>
            /// <para>- company：公司</para>
            /// <para>- social_security_location：社保城市</para>
            /// <para>必填：是</para>
            /// <para>示例值：department</para>
            /// </summary>
            [JsonProperty("management_dimension")]
            public string ManagementDimension { get; set; } = string.Empty;

            /// <summary>
            /// <para>被授权部门/工作地点/公司/社保城市 ID</para>
            /// <para>必填：是</para>
            /// <para>示例值：7023318326176777742</para>
            /// </summary>
            [JsonProperty("obj_id")]
            public string ObjId { get; set; } = string.Empty;
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
    /// <para>示例值：eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9</para>
    /// </summary>
    [JsonProperty("page_token")]
    public string? PageToken { get; set; }
}
