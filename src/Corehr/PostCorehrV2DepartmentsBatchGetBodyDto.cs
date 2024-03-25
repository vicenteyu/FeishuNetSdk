namespace FeishuNetSdk.Corehr;
/// <summary>
/// 批量查询部门（ V2） 请求体
/// <para>批量查询部门信息。</para>
/// <para>对比历史版本[批量查询部门](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/department/list)</para>
/// <para>接口，V2 版本增加了敏感字段权限要求，并使用了 POST HTTP 请求</para>
/// <para>接口ID：7280432392631549953</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/corehr-v2/department/batch_get</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fcorehr-v2%2fdepartment%2fbatch_get</para>
/// </summary>
public record PostCorehrV2DepartmentsBatchGetBodyDto
{
    /// <summary>
    /// <para>部门 ID 列表</para>
    /// <para>必填：否</para>
    /// <para>最大长度：100</para>
    /// <para>最小长度：0</para>
    /// </summary>
    [JsonPropertyName("department_id_list")]
    public string[]? DepartmentIdList { get; set; }

    /// <summary>
    /// <para>返回数据的字段列表</para>
    /// <para>必填：否</para>
    /// <para>最大长度：100</para>
    /// <para>最小长度：0</para>
    /// </summary>
    [JsonPropertyName("fields")]
    public string[]? Fields { get; set; }

    /// <summary>
    /// <para>部门名称精确匹配，最多传100个</para>
    /// <para>必填：否</para>
    /// <para>最大长度：100</para>
    /// <para>最小长度：0</para>
    /// </summary>
    [JsonPropertyName("department_name_list")]
    public string[]? DepartmentNameList { get; set; }
}
