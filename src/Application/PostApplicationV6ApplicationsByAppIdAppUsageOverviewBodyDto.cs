using Newtonsoft.Json;
namespace FeishuNetSdk.Application;
/// <summary>
/// 获取应用使用概览 请求体
/// <para>查看应用在某一天/某一周/某一个月的使用数据，可以查看租户整体对应用的使用情况，也可以分部门查看。</para>
/// <para>接口ID：6995148762798178332</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/application-v6/app-usage/overview</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fapplication-v6%2fapplication-app_usage%2foverview</para>
/// </summary>
public record PostApplicationV6ApplicationsByAppIdAppUsageOverviewBodyDto
{
    /// <summary>
    /// <para>查询日期，格式为yyyy-mm-dd，若cycle_type为1，date可以为任何自然日；若cycle_type为2，则输入的date必须为周一； 若cycle_type为3，则输入的date必须为每月1号</para>
    /// <para>必填：是</para>
    /// <para>示例值：2021-07-08</para>
    /// </summary>
    [JsonProperty("date")]
    public string Date { get; set; } = string.Empty;

    /// <summary>
    /// <para>活跃周期的统计类型</para>
    /// <para>必填：是</para>
    /// <para>示例值：1</para>
    /// <para>可选值：<list type="bullet">
    /// <item>1：日活，指自然日，返回当前日期所在日的数据</item>
    /// <item>2：周活，指自然周，返回当前日期所在周的数据。若到查询时当周还没结束，则返回周一到当前日期的数值。例如在2021/7/15查询2021/7/5这一周的数据，则代表的是2021/7/5~2021/7/11。但若是在2021/7/8查询2021/7/5这一周的数据，则返回的是2021/7/5~2021/7/7的数据</item>
    /// <item>3：月活，指自然月，返回当前日期所在月的数据。若不满一个月则返回当月1日到截止日期前的数据。例如在2021/8/15查询7月的数据，则代表2021/7/1~2021/7/31。若在2021/8/15查询8月的数据，则代表2021/8/1~2021/8/14的数据</item>
    /// </list></para>
    /// </summary>
    [JsonProperty("cycle_type")]
    public int CycleType { get; set; }

    /// <summary>
    /// <para>查询的部门id，获取方法可参考[部门ID概述](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/contact-v3/department/field-overview)</para>
    /// <para>-  若部门id为空，则返回当前租户的使用数据；若填写部门id，则返回当前部门的使用数据（包含子部门的用户）；</para>
    /// <para>-  若路径参数中department_id_type为空或者为open_department_id，则此处应该填写部门的 open_department_id；若路径参数中department_id_type为department_id，则此处应该填写部门的 department_id。</para>
    /// <para>必填：否</para>
    /// <para>示例值：od-4e6ac4d14bcd5071a37a39de902c7141</para>
    /// </summary>
    [JsonProperty("department_id")]
    public string? DepartmentId { get; set; }

    /// <summary>
    /// <para>能力类型，按能力类型进行筛选，返回对应能力的活跃数据</para>
    /// <para>必填：是</para>
    /// <para>示例值：app</para>
    /// <para>可选值：<list type="bullet">
    /// <item>app：返回应用整体的数据，指标值包括：uv：活跃用户数，total_users：累计用户数，new_users：新增用户数，pv：在应用（小程序或网页）中访问的页面数，lifecycle：打开应用（小程序或网页）的次数</item>
    /// <item>mp：返回小程序能力的数据，指标值包括：uv（小程序活跃用户数）、pv（用户在小程序中的访问页面数）、lifecycle（小程序的打开次数）</item>
    /// <item>h5：返回网页能力的数据，指标值包括：uv（网页应用活跃用户数）、pv（用户在网页应用中的访问页面数）、lifecycle（网页应用的打开次数）</item>
    /// <item>bot：返回机器人能力的数据，指标值包括：uv（机器人的活跃用户数）</item>
    /// </list></para>
    /// </summary>
    [JsonProperty("ability")]
    public string Ability { get; set; } = string.Empty;
}
