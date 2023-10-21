using Newtonsoft.Json;
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
    /// <para>是否获取所有任职记录，true 为获取员工所有版本的任职记录，false 为仅获取当前生效的任职记录，默认为 false</para>
    /// <para>必填：否</para>
    /// <para>示例值：false</para>
    /// </summary>
    [JsonProperty("get_all_version")]
    public bool? GetAllVersion { get; set; }

    /// <summary>
    /// <para>查看数据日期</para>
    /// <para>必填：否</para>
    /// <para>示例值：2020-01-01</para>
    /// </summary>
    [JsonProperty("data_date")]
    public string? DataDate { get; set; }

    /// <summary>
    /// <para>生效日期 - 搜索范围开始</para>
    /// <para>必填：否</para>
    /// <para>示例值：2020-01-01</para>
    /// </summary>
    [JsonProperty("effective_date_start")]
    public string? EffectiveDateStart { get; set; }

    /// <summary>
    /// <para>生效日期 - 搜索范围结束</para>
    /// <para>必填：否</para>
    /// <para>示例值：2020-01-01</para>
    /// </summary>
    [JsonProperty("effective_date_end")]
    public string? EffectiveDateEnd { get; set; }
}
