namespace FeishuNetSdk.Corehr;
/// <summary>
/// 查询指定生效日期的部门基本信息 请求体
/// <para>查询指定生效的部门基本信息，含部门名称、上级、编码、负责人、是否启用、描述等信息</para>
/// <para>接口ID：7351676067814096900</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/corehr-v2/department/query_timeline</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fcorehr-v2%2fdepartment%2fquery_timeline</para>
/// </summary>
public record PostCorehrV2DepartmentsQueryTimelineBodyDto
{
    /// <summary>
    /// <para>部门 ID 列表，可请求[搜索部门信息](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/corehr-v2/department/search)获取。</para>
    /// <para>必填：是</para>
    /// <para>最大长度：100</para>
    /// <para>最小长度：0</para>
    /// </summary>
    [JsonPropertyName("department_ids")]
    public string[] DepartmentIds { get; set; } = Array.Empty<string>();

    /// <summary>
    /// <para>生效日期</para>
    /// <para>必填：是</para>
    /// <para>示例值：2020-01-01</para>
    /// <para>最大长度：10</para>
    /// <para>最小长度：10</para>
    /// </summary>
    [JsonPropertyName("effective_date")]
    public string EffectiveDate { get; set; } = string.Empty;

    /// <summary>
    /// <para>返回数据的字段列表，可选["department_name", "code", "active", "parent_department_id", "manager", "description", "effective_date"]</para>
    /// <para>必填：否</para>
    /// <para>最大长度：100</para>
    /// <para>最小长度：0</para>
    /// </summary>
    [JsonPropertyName("fields")]
    public string[]? Fields { get; set; }
}
