// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-12-27
//
// Last Modified By : yxr
// Last Modified On : 2024-12-27
// ************************************************************************
// <copyright file="PostCorehrV2DepartmentsQueryOperationLogsBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>批量查询部门操作日志 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Corehr;
/// <summary>
/// 批量查询部门操作日志 请求体
/// <para>批量查询指定时间范围内的部门操作日志</para>
/// <para>接口ID：7439765965024165889</para>
/// <para>文档地址：https://open.feishu.cn/document/corehr-v1/organization-management/department/query_operation_logs</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fcorehr-v2%2fdepartment%2fquery_operation_logs</para>
/// </summary>
public record PostCorehrV2DepartmentsQueryOperationLogsBodyDto
{
    /// <summary>
    /// <para>部门ID列表，ID获取方式：</para>
    /// <para>- 调用[【创建部门】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/department/create)、[【搜索部门】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/corehr-v2/department/search)接口可以返回部门ID</para>
    /// <para>- 也可以通过[【事件】创建部门](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/department/events/created)、[【事件】更新部门](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/department/events/updated) 获取部门ID</para>
    /// <para>必填：是</para>
    /// <para>最大长度：100</para>
    /// <para>最小长度：1</para>
    /// </summary>
    [JsonPropertyName("department_ids")]
    public string[] DepartmentIds { get; set; } = Array.Empty<string>();

    /// <summary>
    /// <para>查询的起始操作日期，格式 "YYYY-MM-DD"，不带时分秒，包含start_date传入的时间，系统会以start_date的00:00:00为开始时间进行查询</para>
    /// <para>必填：是</para>
    /// <para>示例值：2023-01-01</para>
    /// </summary>
    [JsonPropertyName("start_date")]
    public string StartDate { get; set; } = string.Empty;

    /// <summary>
    /// <para>查询的截止操作日期，格式 "YYYY-MM-DD"，不带时分秒，包含end_date传入的时间，系统会以end_date的23:59:59为截止时间进行查询。查询截止日期应大于起始日期，起止日期跨度最大为366天</para>
    /// <para>必填：是</para>
    /// <para>示例值：2024-01-01</para>
    /// </summary>
    [JsonPropertyName("end_date")]
    public string EndDate { get; set; } = string.Empty;
}
