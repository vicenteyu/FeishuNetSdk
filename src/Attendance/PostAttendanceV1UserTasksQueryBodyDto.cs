// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-06-24
// ************************************************************************
// <copyright file="PostAttendanceV1UserTasksQueryBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>查询打卡结果 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Attendance;
/// <summary>
/// 查询打卡结果 请求体
/// <para>获取企业内员工的实际打卡结果，包括：</para>
/// <para>* 打卡任务列表</para>
/// <para>* 打卡记录id</para>
/// <para>* 用户信息</para>
/// <para>* 考勤组id</para>
/// <para>* 班次id</para>
/// <para>* 考勤记录</para>
/// <para>* 上班记录</para>
/// <para>* 下班记录</para>
/// <para>* 上班打卡结果</para>
/// <para>* 下班打卡结果</para>
/// <para>* 上班打卡结果补充</para>
/// <para>* 下班打卡结果补充</para>
/// <para>* 上班打卡时间</para>
/// <para>* 下班打卡时间</para>
/// <para>* 无效用户id列表</para>
/// <para>* 没有权限用户ID列表</para>
/// <para>接口ID：7044467124773421057</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/attendance-v1/user_task/query</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fattendance-v1%2fuser_task%2fquery</para>
/// </summary>
public record PostAttendanceV1UserTasksQueryBodyDto
{
    /// <summary>
    /// <para>employee_no 或 employee_id 列表，对应employee_type，长度不超过 50</para>
    /// <para>必填：是</para>
    /// <para>示例值：abd754f7</para>
    /// </summary>
    [JsonPropertyName("user_ids")]
    public string[] UserIds { get; set; } = Array.Empty<string>();

    /// <summary>
    /// <para>查询的起始工作日，格式为yyyyMMdd</para>
    /// <para>必填：是</para>
    /// <para>示例值：20190817</para>
    /// </summary>
    [JsonPropertyName("check_date_from")]
    public int CheckDateFrom { get; set; }

    /// <summary>
    /// <para>查询的结束工作日，格式为yyyyMMdd</para>
    /// <para>必填：是</para>
    /// <para>示例值：20190820</para>
    /// </summary>
    [JsonPropertyName("check_date_to")]
    public int CheckDateTo { get; set; }

    /// <summary>
    /// <para>是否需要加班班段打卡结果；当need_overtime_result=true时，会返回加班班段，加班班段通过task_shift_type=1标识，加班班段上下班与正常班段相连时会出现共用record_id情况。例如：9-18为正常班次，18-19为加班班次，打卡结果中records 会出现两段，分别为9-18，18-19 且两段上下班record_id相同（check_in_record_id和check_out_record_id相同）。非相连加班班次正常分段返回。当need_overtime_result=false时，仅返回正常班段且task_shift_type=0。</para>
    /// <para>必填：否</para>
    /// <para>示例值：true</para>
    /// </summary>
    [JsonPropertyName("need_overtime_result")]
    public bool? NeedOvertimeResult { get; set; }
}
