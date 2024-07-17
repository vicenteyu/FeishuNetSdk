// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-06-24
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
}
