using Newtonsoft.Json;
namespace FeishuNetSdk.FeishuPeople;
/// <summary>
/// 搜索离职信息 请求体
/// <para>搜索离职信息，该接口会按照应用拥有的「员工数据」的权限范围返回数据，请确定在「开发者后台 - 权限管理 - 数据权限」中有申请「员工资源」权限范围</para>
/// <para>接口ID：7211423970042183684</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/corehr-v1/offboarding/search</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fcorehr-v1%2foffboarding%2fsearch</para>
/// </summary>
public record PostCorehrV1OffboardingsSearchBodyDto
{
    /// <summary>
    /// <para>雇佣 ID 列表，为空默认查询所有离职人员</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonProperty("employment_ids")]
    public string[]? EmploymentIds { get; set; }

    /// <summary>
    /// <para>离职审批发起时间 - 搜索范围开始，需要与搜索范围结束一同使用，请按照时间戳格式传入</para>
    /// <para>必填：否</para>
    /// <para>示例值：1672578336</para>
    /// </summary>
    [JsonProperty("apply_initiating_time_start")]
    public string? ApplyInitiatingTimeStart { get; set; }

    /// <summary>
    /// <para>离职审批发起时间 - 搜索范围结束，请按照时间戳格式传入</para>
    /// <para>必填：否</para>
    /// <para>示例值：1674133537</para>
    /// </summary>
    [JsonProperty("apply_initiating_time_end")]
    public string? ApplyInitiatingTimeEnd { get; set; }

    /// <summary>
    /// <para>期望离职日期 - 搜索范围开始，需要与搜索范围结束一同使用</para>
    /// <para>必填：否</para>
    /// <para>示例值：2022-01-01</para>
    /// </summary>
    [JsonProperty("expected_offboarding_date_start")]
    public string? ExpectedOffboardingDateStart { get; set; }

    /// <summary>
    /// <para>期望离职日期 - 搜索范围结束</para>
    /// <para>必填：否</para>
    /// <para>示例值：2022-01-01</para>
    /// </summary>
    [JsonProperty("expected_offboarding_date_end")]
    public string? ExpectedOffboardingDateEnd { get; set; }

    /// <summary>
    /// <para>离职日期 - 搜索范围开始，需要与搜索范围结束一同使用</para>
    /// <para>必填：否</para>
    /// <para>示例值：2022-01-01</para>
    /// </summary>
    [JsonProperty("offboarding_date_start")]
    public string? OffboardingDateStart { get; set; }

    /// <summary>
    /// <para>离职日期 - 搜索范围结束</para>
    /// <para>必填：否</para>
    /// <para>示例值：2022-01-01</para>
    /// </summary>
    [JsonProperty("offboarding_date_end")]
    public string? OffboardingDateEnd { get; set; }

    /// <summary>
    /// <para>离职状态，多个状态之间为「或」的关系</para>
    /// <para>必填：否</para>
    /// <para>最大长度：10</para>
    /// </summary>
    [JsonProperty("statuses")]
    public string[]? Statuses { get; set; }

    /// <summary>
    /// <para>离职原因列表 , 可以通过【查询员工离职原因列表】接口获取 ，查询时不返回下级原因相关的离职信息</para>
    /// <para>字段权限要求：</para>
    /// <para>按照离职原因搜索(corehr:employment.offboarding_reason.search:read)</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonProperty("reasons")]
    public string[]? Reasons { get; set; }

    /// <summary>
    /// <para>离职原因（员工）列表 , 可以通过【查询员工离职原因列表】接口获取，查询时不返回下级原因相关的离职信息</para>
    /// <para>字段权限要求：</para>
    /// <para>按照离职原因搜索(corehr:employment.offboarding_reason.search:read)</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonProperty("employee_reasons")]
    public string[]? EmployeeReasons { get; set; }
}
