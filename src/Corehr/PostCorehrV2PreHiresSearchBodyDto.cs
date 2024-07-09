// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-07-01
// ************************************************************************
// <copyright file="PostCorehrV2PreHiresSearchBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>搜索待入职人员信息 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Corehr;
/// <summary>
/// 搜索待入职人员信息 请求体
/// <para>该接口用于根据工号/待入职人员 ID /入职地点等查询条件搜索待入职人员信息。查询的待入职数量及字段越多，耗时越久，使用时建议细化指定需要的字段</para>
/// <para>接口ID：7263303427627270148</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/corehr-v2/pre_hire/search</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fcorehr-v2%2fpre_hire%2fsearch</para>
/// </summary>
public record PostCorehrV2PreHiresSearchBodyDto
{
    /// <summary>
    /// <para>待入职人员工号列表，如果不填写，则不根据工号过滤待入职数据。</para>
    /// <para>必填：否</para>
    /// <para>最大长度：100</para>
    /// </summary>
    [JsonPropertyName("worker_ids")]
    public string[]? WorkerIds { get; set; }

    /// <summary>
    /// <para>待入职人员 ID 列表，如果不填写，则搜索全部待入职。</para>
    /// <para>必填：否</para>
    /// <para>最大长度：100</para>
    /// </summary>
    [JsonPropertyName("pre_hire_ids")]
    public string[]? PreHireIds { get; set; }

    /// <summary>
    /// <para>入职日期（搜索的起始时间），需要与入职日期（onboarding_date_end）一同使用，不填写则不根据入职日期过滤。</para>
    /// <para>必填：否</para>
    /// <para>示例值：2006-01-02</para>
    /// </summary>
    [JsonPropertyName("onboarding_date_start")]
    public string? OnboardingDateStart { get; set; }

    /// <summary>
    /// <para>入职日期（搜索的结束时间），需要与入职日期（onboarding_date_start）一同使用，不填写则不根据入职日期过滤。</para>
    /// <para>必填：否</para>
    /// <para>示例值：2006-01-02</para>
    /// </summary>
    [JsonPropertyName("onboarding_date_end")]
    public string? OnboardingDateEnd { get; set; }

    /// <summary>
    /// <para>待入职数据更新时间（搜索的起始时间），需要与更新时间（updated_date_end）一同使用，不填写则不根据数据更新时间过滤。</para>
    /// <para>必填：否</para>
    /// <para>示例值：2006-01-02</para>
    /// </summary>
    [JsonPropertyName("updated_date_start")]
    public string? UpdatedDateStart { get; set; }

    /// <summary>
    /// <para>待入职数据更新时间（搜索的结束时间），需要与更新时间（updated_date_start）一同使用，不填写则不根据数据更新时间过滤。</para>
    /// <para>必填：否</para>
    /// <para>示例值：2006-01-02</para>
    /// </summary>
    [JsonPropertyName("updated_date_end")]
    public string? UpdatedDateEnd { get; set; }

    /// <summary>
    /// <para>入职地点 ID 列表，可通过[批量查询地点](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/location/list)接口获取</para>
    /// <para>必填：否</para>
    /// <para>最大长度：100</para>
    /// </summary>
    [JsonPropertyName("onboarding_location_ids")]
    public string[]? OnboardingLocationIds { get; set; }

    /// <summary>
    /// <para>入职状态，不填写则搜索全部入职状态的数据。</para>
    /// <para>必填：否</para>
    /// <para>示例值：preboarding</para>
    /// <para>可选值：<list type="bullet">
    /// <item>preboarding：待入职</item>
    /// <item>deleted：已删除</item>
    /// <item>day_one：准备就绪</item>
    /// <item>withdrawn：已撤销</item>
    /// <item>completed：已完成</item>
    /// </list></para>
    /// </summary>
    [JsonPropertyName("onboarding_status")]
    public string? OnboardingStatus { get; set; }

    /// <summary>
    /// <para>部门 ID 列表，ID类型与查询参数 department_id_type的取值保持一致，ID值可以通过[搜索部门信息](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/corehr-v2/department/search)接口获取</para>
    /// <para>必填：否</para>
    /// <para>最大长度：100</para>
    /// </summary>
    [JsonPropertyName("department_ids")]
    public string[]? DepartmentIds { get; set; }

    /// <summary>
    /// <para>直接上级的雇佣 ID 列表，ID类型与查询参数user_id_type的取值保持一致，可以通过[批量查询员工信息](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/corehr-v2/employee/batch_get)接口获取</para>
    /// <para>必填：否</para>
    /// <para>最大长度：100</para>
    /// </summary>
    [JsonPropertyName("direct_manager_ids")]
    public string[]? DirectManagerIds { get; set; }

    /// <summary>
    /// <para>人员类型 ID 列表，可以通过接口[批量查询人员类型](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/employee_type/list)获取</para>
    /// <para>必填：否</para>
    /// <para>最大长度：100</para>
    /// </summary>
    [JsonPropertyName("employee_type_ids")]
    public string[]? EmployeeTypeIds { get; set; }

    /// <summary>
    /// <para>序列 ID 列表，可以通过[批量查询序列](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/job_family/list)接口获取</para>
    /// <para>必填：否</para>
    /// <para>最大长度：100</para>
    /// </summary>
    [JsonPropertyName("job_family_ids")]
    public string[]? JobFamilyIds { get; set; }

    /// <summary>
    /// <para>搜索关键字，支持对常用名模糊搜索 + 工号精确搜索，不填写则搜索全部数据。</para>
    /// <para>必填：否</para>
    /// <para>示例值：张三</para>
    /// </summary>
    [JsonPropertyName("key_word")]
    public string? KeyWord { get; set; }

    /// <summary>
    /// <para>是否离职重聘，不填写则搜索全部数据。</para>
    /// <para>必填：否</para>
    /// <para>示例值：to_be_confirmed</para>
    /// <para>可选值：<list type="bullet">
    /// <item>to_be_confirmed：待确认</item>
    /// <item>no：否</item>
    /// <item>yes：是</item>
    /// </list></para>
    /// </summary>
    [JsonPropertyName("rehire")]
    public string? Rehire { get; set; }

    /// <summary>
    /// <para>返回数据的字段列表，填写方式：</para>
    /// <para>- 为空时只返回 pre_hire_id</para>
    /// <para>- 不为空时按照传入的字段返回数据，格式如下：</para>
    /// <para>- person_info 字段：person_info.gender，person_info.age</para>
    /// <para>- employment_info 字段：employment_info.department</para>
    /// <para>- onboarding_info 字段：onboarding_info.onboarding_date</para>
    /// <para>- probation_info 字段：probation_info.probation_period</para>
    /// <para>- contract_info 字段：contract_info.contract_type</para>
    /// <para>- 如果要返回所有下级，只用传上级结构体名称，例如 person_info</para>
    /// <para>- 返回数据越多，查询接口性能越慢，请按需填写返回字段</para>
    /// <para>必填：否</para>
    /// <para>示例值：\["person_info","employment_info.department","probation_info.probation_period"\]</para>
    /// <para>最大长度：100</para>
    /// </summary>
    [JsonPropertyName("fields")]
    public string[]? Fields { get; set; }
}
