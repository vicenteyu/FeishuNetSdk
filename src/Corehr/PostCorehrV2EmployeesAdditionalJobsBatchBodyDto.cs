// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-11-15
//
// Last Modified By : yxr
// Last Modified On : 2024-11-15
// ************************************************************************
// <copyright file="PostCorehrV2EmployeesAdditionalJobsBatchBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>批量查询兼职信息 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Corehr;
/// <summary>
/// 批量查询兼职信息 请求体
/// <para>批量查询兼职信息，包括开始日期、职务、序列、上级、薪资类型等信息。</para>
/// <para>支持全量遍历和筛选查询。</para>
/// <para>接口ID：7387981900317589506</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/corehr-v2/employees-additional_job/batch</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fcorehr-v2%2femployees-additional_job%2fbatch</para>
/// </summary>
public record PostCorehrV2EmployeesAdditionalJobsBatchBodyDto
{
    /// <summary>
    /// <para>雇佣 ID，可通过[【批量查询员工信息】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/corehr-v2/employee/batch_get)获取详细信息</para>
    /// <para>- 类型与 user_id_type 一致</para>
    /// <para>必填：否</para>
    /// <para>最大长度：100</para>
    /// <para>最小长度：0</para>
    /// </summary>
    [JsonPropertyName("employment_ids")]
    public string[]? EmploymentIds { get; set; }

    /// <summary>
    /// <para>兼职 ID</para>
    /// <para>- 指定兼职记录 ID 查询时，请将 page_size 设为最大值，不返回 has_more 参数</para>
    /// <para>必填：否</para>
    /// <para>最大长度：100</para>
    /// <para>最小长度：0</para>
    /// </summary>
    [JsonPropertyName("additional_job_ids")]
    public string[]? AdditionalJobIds { get; set; }

    /// <summary>
    /// <para>开始日期</para>
    /// <para>- 无默认值</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("start_date")]
    public EmployeesAdditionalJobBatchReqDate? StartDate { get; set; }

    /// <summary>
    /// <para>开始日期</para>
    /// <para>- 无默认值</para>
    /// </summary>
    public record EmployeesAdditionalJobBatchReqDate
    {
        /// <summary>
        /// <para>开始</para>
        /// <para>必填：是</para>
        /// <para>示例值：2024-01-01</para>
        /// </summary>
        [JsonPropertyName("start")]
        public string Start { get; set; } = string.Empty;

        /// <summary>
        /// <para>结束</para>
        /// <para>必填：是</para>
        /// <para>示例值：2024-01-01</para>
        /// </summary>
        [JsonPropertyName("end")]
        public string End { get; set; } = string.Empty;
    }

    /// <summary>
    /// <para>结束日期</para>
    /// <para>- 无默认值</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("end_date")]
    public EmployeesAdditionalJobBatchReqDate? EndDate { get; set; }

    /// <summary>
    /// <para>查看数据日期，默认当天</para>
    /// <para>- 与时间范围筛选为 AND 关系</para>
    /// <para>必填：否</para>
    /// <para>示例值：2024-01-02</para>
    /// </summary>
    [JsonPropertyName("data_date")]
    public string? DataDate { get; set; }

    /// <summary>
    /// <para>仅查询在【data_date】当天为生效中的兼职</para>
    /// <para>- 默认为 false，即 【data_date】不生效</para>
    /// <para>必填：否</para>
    /// <para>示例值：true</para>
    /// </summary>
    [JsonPropertyName("is_effective")]
    public bool? IsEffective { get; set; }
}
