// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-06-24
// ************************************************************************
// <copyright file="PostCorehrV2DepartmentsQueryMultiTimelineBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>批量查询部门版本信息 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Corehr;
/// <summary>
/// 批量查询部门版本信息 请求体
/// <para>根据部门ID列表，批量查询开始结束时间内的所有部门版本信息，含部门名称、部门类型、上级、编码、负责人、是否启用、描述等信息</para>
/// <para>接口ID：7372158581884911618</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/corehr-v2/department/query_multi_timeline</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fcorehr-v2%2fdepartment%2fquery_multi_timeline</para>
/// </summary>
public record PostCorehrV2DepartmentsQueryMultiTimelineBodyDto
{
    /// <summary>
    /// <para>部门 ID 列表，可请求[搜索部门信息](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/corehr-v2/department/search)获取。</para>
    /// <para>必填：是</para>
    /// <para>最大长度：10</para>
    /// <para>最小长度：1</para>
    /// </summary>
    [JsonPropertyName("department_ids")]
    public string[] DepartmentIds { get; set; } = Array.Empty<string>();

    /// <summary>
    /// <para>生效日期开始(包含)</para>
    /// <para>必填：否</para>
    /// <para>示例值：2024-01-01</para>
    /// <para>最大长度：10</para>
    /// <para>最小长度：10</para>
    /// </summary>
    [JsonPropertyName("effective_date_start")]
    public string? EffectiveDateStart { get; set; }

    /// <summary>
    /// <para>生效日期结束(包含)</para>
    /// <para>必填：否</para>
    /// <para>示例值：2024-12-31</para>
    /// <para>最大长度：10</para>
    /// <para>最小长度：10</para>
    /// </summary>
    [JsonPropertyName("effective_date_end")]
    public string? EffectiveDateEnd { get; set; }

    /// <summary>
    /// <para>返回数据的字段列表，可选["department_name", "sub_type", "code", "active", "parent_department_id", "manager", "description", "effective_date"], 以及自定义字段field_name</para>
    /// <para>必填：否</para>
    /// <para>最大长度：100</para>
    /// <para>最小长度：0</para>
    /// </summary>
    [JsonPropertyName("fields")]
    public string[]? Fields { get; set; }
}
