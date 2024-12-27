// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-10-25
// ************************************************************************
// <copyright file="PostCorehrV2EmployeesJobDatasQueryBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>获取任职信息列表 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Corehr;
/// <summary>
/// 获取任职信息列表 请求体
/// <para>获取任职信息列表。</para>
/// <para>接口ID：7262387840977207297</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/corehr-v2/employees-job_data/query</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fcorehr-v2%2femployees-job_data%2fquery</para>
/// </summary>
public record PostCorehrV2EmployeesJobDatasQueryBodyDto
{
    /// <summary>
    /// <para>是否获取所有版本的任职记录</para>
    /// <para>- true 为获取员工所有版本的任职记录</para>
    /// <para>- false 为仅获取当前生效的任职记录</para>
    /// <para>- 默认为 false</para>
    /// <para>必填：否</para>
    /// <para>示例值：false</para>
    /// </summary>
    [JsonPropertyName("get_all_version")]
    public bool? GetAllVersion { get; set; }

    /// <summary>
    /// <para>查看数据日期</para>
    /// <para>- 与时间范围筛选为 AND 关系</para>
    /// <para>- 默认为当天</para>
    /// <para>必填：否</para>
    /// <para>示例值：2020-01-01</para>
    /// </summary>
    [JsonPropertyName("data_date")]
    public string? DataDate { get; set; }

    /// <summary>
    /// <para>生效日期 - 搜索范围开始</para>
    /// <para>- 默认为空</para>
    /// <para>必填：否</para>
    /// <para>示例值：2020-01-01</para>
    /// </summary>
    [JsonPropertyName("effective_date_start")]
    public string? EffectiveDateStart { get; set; }

    /// <summary>
    /// <para>生效日期 - 搜索范围结束</para>
    /// <para>- 默认为空</para>
    /// <para>必填：否</para>
    /// <para>示例值：2020-01-01</para>
    /// </summary>
    [JsonPropertyName("effective_date_end")]
    public string? EffectiveDateEnd { get; set; }

    /// <summary>
    /// <para>员工当前所在的部门 ID</para>
    /// <para>- 类型应与 department_id_type 一致</para>
    /// <para>必填：否</para>
    /// <para>示例值：6891251722631890445</para>
    /// </summary>
    [JsonPropertyName("department_id")]
    public string? DepartmentId { get; set; }

    /// <summary>
    /// <para>员工雇佣 ID 列表</para>
    /// <para>- 类型应与 user_id_type 一致</para>
    /// <para>必填：否</para>
    /// <para>最大长度：100</para>
    /// <para>最小长度：0</para>
    /// </summary>
    [JsonPropertyName("employment_ids")]
    public string[]? EmploymentIds { get; set; }

    /// <summary>
    /// <para>是否仅查询主职</para>
    /// <para>- true：仅返回 primary_job_data 为 true 的任职记录</para>
    /// <para>- false：仅返回 primary_job_data 为 false 的任职记录</para>
    /// <para>- 不传：返回全部</para>
    /// <para>必填：否</para>
    /// <para>示例值：true</para>
    /// </summary>
    [JsonPropertyName("primary_job_data")]
    public bool? PrimaryJobData { get; set; }

    /// <summary>
    /// <para>业务类型（原：任职原因）</para>
    /// <para>- 可通过[【获取字段详情】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/custom_field/get_by_param)接口查询，查询参数如下：</para>
    /// <para>- object_api_name：job_data</para>
    /// <para>- custom_api_name：assignment_start_reason</para>
    /// <para>必填：否</para>
    /// <para>默认值：[]</para>
    /// </summary>
    [JsonPropertyName("assignment_start_reasons")]
    public string[]? AssignmentStartReasons { get; set; }
}
