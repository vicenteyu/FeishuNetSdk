namespace FeishuNetSdk.FeishuPeople;
/// <summary>
/// 获取组织类角色授权列表 请求体
/// <para>查询组织类角色的授权信息。</para>
/// <para>接口ID：7141207412454998019</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/corehr-v1/authorization/search</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fcorehr-v1%2fassigned_user%2fsearch</para>
/// </summary>
public record PostCorehrV1AssignedUsersSearchBodyDto
{
    /// <summary>
    /// <para>角色 ID，仅支持组织类角色， 角色 ID 可通过【批量获取角色列表】接口获取</para>
    /// <para>必填：是</para>
    /// <para>示例值：100</para>
    /// </summary>
    [JsonPropertyName("role_id")]
    public string RoleId { get; set; } = string.Empty;

    /// <summary>
    /// <para>管理范围信息</para>
    /// <para>必填：是</para>
    /// </summary>
    [JsonPropertyName("management_scope_list")]
    public ManagementScope[] ManagementScopeLists { get; set; } = Array.Empty<ManagementScope>();

    /// <summary>
    /// <para>管理范围信息</para>
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
        [JsonPropertyName("management_dimension")]
        public string ManagementDimension { get; set; } = string.Empty;

        /// <summary>
        /// <para>被授权部门/工作地点/公司/社保城市 ID</para>
        /// <para>必填：是</para>
        /// <para>示例值：7023318326176777742</para>
        /// </summary>
        [JsonPropertyName("obj_id")]
        public string ObjId { get; set; } = string.Empty;
    }

    /// <summary>
    /// <para>查找方式</para>
    /// <para>可选值有：</para>
    /// <para>- 1：只查找指定 部门/工作地点/公司/社保城市，如无授权信息则返回为空</para>
    /// <para>- 2：当指定的 部门/工作地点/公司/社保城市 无授权信息，向上查找第一个授权记录并直接返回</para>
    /// <para>必填：是</para>
    /// <para>示例值：1</para>
    /// </summary>
    [JsonPropertyName("search_method")]
    public string SearchMethod { get; set; } = string.Empty;

    /// <summary>
    /// <para>分页标记，第一次请求不填，表示从头开始遍历；分页查询结果还有更多项时会同时返回新的 page_token，下次遍历可采用该 page_token 获取查询结果</para>
    /// <para>必填：否</para>
    /// <para>示例值：eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9</para>
    /// </summary>
    [JsonPropertyName("page_token")]
    public string? PageToken { get; set; }

    /// <summary>
    /// <para>分页大小</para>
    /// <para>必填：是</para>
    /// <para>示例值：100</para>
    /// </summary>
    [JsonPropertyName("page_size")]
    public string PageSize { get; set; } = string.Empty;
}
