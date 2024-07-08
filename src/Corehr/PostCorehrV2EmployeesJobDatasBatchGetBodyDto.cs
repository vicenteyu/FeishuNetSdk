// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-06-24
// ************************************************************************
// <copyright file="PostCorehrV2EmployeesJobDatasBatchGetBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>批量查询员工任职信息 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Corehr;
/// <summary>
/// 批量查询员工任职信息 请求体
/// <para>通过员工雇佣 ID 批量查询任职信息。</para>
/// <para>接口ID：7262387840977223681</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/corehr-v2/employees-job_data/batch_get</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fcorehr-v2%2femployees-job_data%2fbatch_get</para>
/// </summary>
public record PostCorehrV2EmployeesJobDatasBatchGetBodyDto
{
    /// <summary>
    /// <para>员工雇佣 ID 列表，可通过[【搜索员工信息】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/corehr-v2/employee/search)获取</para>
    /// <para>应与 user_id_type 类型一致</para>
    /// <para>必填：是</para>
    /// <para>最大长度：100</para>
    /// <para>最小长度：1</para>
    /// </summary>
    [JsonPropertyName("employment_ids")]
    public string[] EmploymentIds { get; set; } = Array.Empty<string>();

    /// <summary>
    /// <para>是否获取所有任职记录，true 为获取员工所有版本的任职记录，false 为仅获取当前生效的任职记录，默认为 false</para>
    /// <para>必填：否</para>
    /// <para>示例值：false</para>
    /// </summary>
    [JsonPropertyName("get_all_version")]
    public bool? GetAllVersion { get; set; }

    /// <summary>
    /// <para>生效日期 - 搜索范围开始</para>
    /// <para>必填：否</para>
    /// <para>示例值：2020-01-01</para>
    /// </summary>
    [JsonPropertyName("effective_date_start")]
    public string? EffectiveDateStart { get; set; }

    /// <summary>
    /// <para>生效日期 - 搜索范围结束</para>
    /// <para>必填：否</para>
    /// <para>示例值：2020-01-01</para>
    /// </summary>
    [JsonPropertyName("effective_date_end")]
    public string? EffectiveDateEnd { get; set; }

    /// <summary>
    /// <para>查看数据日期，默认为今天</para>
    /// <para>必填：否</para>
    /// <para>示例值：2020-01-01</para>
    /// </summary>
    [JsonPropertyName("data_date")]
    public string? DataDate { get; set; }
}
