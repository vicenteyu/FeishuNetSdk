// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-07-24
//
// Last Modified By : yxr
// Last Modified On : 2024-07-24
// ************************************************************************
// <copyright file="PostApplicationV6ApplicationsByAppIdAppUsageMessagePushOverviewBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>获取消息推送概览 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Application;
/// <summary>
/// 获取消息推送概览 请求体
/// <para>目标：查看应用在某一天/某一周/某一个月的机器人消息推送数据，可以根据部门做筛选</para>
/// <para>接口ID：7036626399368953884</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/application-v6/app-usage/message_push_overview</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fapplication-v6%2fapplication-app_usage%2fmessage_push_overview</para>
/// </summary>
public record PostApplicationV6ApplicationsByAppIdAppUsageMessagePushOverviewBodyDto
{
    /// <summary>
    /// <para>查询日期，若cycle_type为week，则输入的date必须为周一； 若cycle_type为month，则输入的date必须为每月1号</para>
    /// <para>必填：是</para>
    /// <para>示例值：2021-07-08</para>
    /// </summary>
    [JsonPropertyName("date")]
    public string Date { get; set; } = string.Empty;

    /// <summary>
    /// <para>枚举值：day，week，month；week指自然周，返回当前日期所在周的数据；不满一周则从周一到当前日期算。month指自然月，返回当前日期所在月的数据。</para>
    /// <para>必填：是</para>
    /// <para>示例值：1</para>
    /// <para>可选值：<list type="bullet">
    /// <item>1：日活，指自然日，返回当前日期所在日的数据</item>
    /// <item>2：周活，指自然周，返回当前日期所在周的数据。若到查询时当周还没结束，则返回周一到当前日期的数值。例如在2021/7/15 查询2021/7/5 这一周的数据，则代表的是2021/7/5 ~ 2021/7/11。但若是在2021/7/8 查询2021/7/5 这一周的数据，则返回的是2021/7/5 ~ 2021/7/7 的数据</item>
    /// <item>3：月活，指自然月，返回当前日期所在月的数据。若不满一个月则返回当月1日到截止日期前的数据。例如在2021/8/15 查询 7月的数据，则代表2021/7/1~2021/7/31。 若在2021/8/15 查询8月的数据，则代表2021/8/1~2021/8/14的数据</item>
    /// </list></para>
    /// </summary>
    [JsonPropertyName("cycle_type")]
    public int CycleType { get; set; }

    /// <summary>
    /// <para>需要查询的部门id，获取方法可参考[部门ID概述](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/contact-v3/department/field-overview)</para>
    /// <para>- 若部门id为空，则返回当前租户的使用数据；若填写部门id，则返回当前部门的使用数据（包含子部门的用户）；</para>
    /// <para>- 若路径参数中department_id_type为空或者为open_department_id，则此处应该填写部门的 open_department_id；若路径参数中department_id_type为department_id，则此处应该填写部门的 department_id。返回当前部门的使用数据； 若不填写，则返回当前租户的使用数据</para>
    /// <para>必填：否</para>
    /// <para>示例值：od-4e6ac4d14bcd5071a37a39de902c7141</para>
    /// </summary>
    [JsonPropertyName("department_id")]
    public string? DepartmentId { get; set; }
}
