namespace FeishuNetSdk.Application;
/// <summary>
/// 获取多部门应用使用概览 请求体
/// <para>查看应用在某一天/某一周/某一个月的使用数据，可以根据部门做多层子部门的筛选</para>
/// <para>接口ID：7036626399368937500</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/application-v6/app-usage/department_overview</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fapplication-v6%2fapplication-app_usage%2fdepartment_overview</para>
/// </summary>
public record PostApplicationV6ApplicationsByAppIdAppUsageDepartmentOverviewBodyDto
{
    /// <summary>
    /// <para>查询日期，格式为yyyy-mm-dd，若cycle_type为1，date可以为任何自然日；若cycle_type为2，则输入的date必须为周一； 若cycle_type为3，则输入的date必须为每月1号</para>
    /// <para>必填：是</para>
    /// <para>示例值：2021-07-08</para>
    /// </summary>
    [JsonPropertyName("date")]
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
    [JsonPropertyName("cycle_type")]
    public int CycleType { get; set; }

    /// <summary>
    /// <para>查询的部门id，获取方法可参考[部门ID概述](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/contact-v3/department/field-overview)</para>
    /// <para>- 若部门id为空，则返回当前租户的使用数据；若填写部门id，则返回当前部门的使用数据（包含子部门的用户） 以及多级子部门的使用数据。</para>
    /// <para>- 若路径参数中department_id_type为空或者为open_department_id，则此处应该填写部门的 open_department_id；若路径参数中department_id_type为department_id，则此处应该填写部门的 department_id。</para>
    /// <para>- 若不填写则返回整个租户的数据</para>
    /// <para>必填：否</para>
    /// <para>示例值：od-4e6ac4d14bcd5071a37a39de902c7141</para>
    /// </summary>
    [JsonPropertyName("department_id")]
    public string? DepartmentId { get; set; }

    /// <summary>
    /// <para>是否需要查询部门下多层子部门的数据。未设置或为0时，仅查询department_id对应的部门。设置为n时，查询department_id及其n级子部门的数据。仅在department_id参数传递时有效，最大值为4。</para>
    /// <para>必填：否</para>
    /// <para>示例值：0</para>
    /// <para>默认值：0</para>
    /// </summary>
    [JsonPropertyName("recursion")]
    public int? Recursion { get; set; }

    /// <summary>
    /// <para>分页大小，取值范围 1~20</para>
    /// <para>必填：否</para>
    /// <para>示例值：10</para>
    /// <para>默认值：10</para>
    /// </summary>
    [JsonPropertyName("page_size")]
    public int? PageSize { get; set; }

    /// <summary>
    /// <para>分页标记，第一次请求不填，表示从头开始遍历；分页查询结果还有更多项时会同时返回新的 page_token，下次遍历可采用该 page_token 获取查询结果</para>
    /// <para>必填：否</para>
    /// <para>示例值：new-1a8f509162ca3c95405838d05ccded09</para>
    /// </summary>
    [JsonPropertyName("page_token")]
    public string? PageToken { get; set; }
}
