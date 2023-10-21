using Newtonsoft.Json;
namespace FeishuNetSdk.Corehr;
/// <summary>
/// 搜索员工异动信息 请求体
/// <para>搜索异动信息，该接口会按照应用拥有的「员工数据」的权限范围返回数据，请确定在「开发者后台 - 权限管理 - 数据权限」中有申请「员工资源」权限范围</para>
/// <para>接口ID：7211423970042150916</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/corehr-v1/job_change/search</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fcorehr-v2%2fjob_change%2fsearch</para>
/// </summary>
public record PostCorehrV2JobChangesSearchBodyDto
{
    /// <summary>
    /// <para>雇员 ID 列表</para>
    /// <para>必填：否</para>
    /// <para>最大长度：10</para>
    /// </summary>
    [JsonProperty("employment_ids")]
    public string[]? EmploymentIds { get; set; }

    /// <summary>
    /// <para>异动记录 ID 列表</para>
    /// <para>必填：否</para>
    /// <para>最大长度：10</para>
    /// </summary>
    [JsonProperty("job_change_ids")]
    public string[]? JobChangeIds { get; set; }

    /// <summary>
    /// <para>异动状态，多个状态之间为「或」的关系</para>
    /// <para>必填：否</para>
    /// <para>示例值：Approved</para>
    /// <para>最大长度：10</para>
    /// </summary>
    [JsonProperty("statuses")]
    public string[]? Statuses { get; set; }
}
