// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-02-21
//
// Last Modified By : yxr
// Last Modified On : 2025-02-21
// ************************************************************************
// <copyright file="PostAttendanceV1UserFlowsBatchDelBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>删除打卡流水 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Attendance;
/// <summary>
/// 删除打卡流水 请求体
/// <para>删除员工从开放平台导入的打卡记录。删除后会重新计算打卡记录对应考勤任务结果。</para>
/// <para>接口ID：7473096091899805715</para>
/// <para>文档地址：https://open.feishu.cn/document/attendance-v1/user_task/batch_del</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fattendance-v1%2fuser_flow%2fbatch_del</para>
/// </summary>
public record PostAttendanceV1UserFlowsBatchDelBodyDto
{
    /// <summary>
    /// <para>打卡流水记录 ID，获取方式：1）[批量查询打卡流水记录](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/attendance-v1/user_flow/query) 2）[获取打卡结果](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/attendance-v1/user_task/query) 3）[导入打卡流水记录](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/attendance-v1/user_flow/batch_create)</para>
    /// <para>必填：是</para>
    /// <para>最大长度：10</para>
    /// <para>最小长度：1</para>
    /// </summary>
    [JsonPropertyName("record_ids")]
    public string[] RecordIds { get; set; } = [];
}
