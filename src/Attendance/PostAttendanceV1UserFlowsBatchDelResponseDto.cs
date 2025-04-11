// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-02-21
//
// Last Modified By : yxr
// Last Modified On : 2025-02-21
// ************************************************************************
// <copyright file="PostAttendanceV1UserFlowsBatchDelResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>删除打卡流水 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Attendance;
/// <summary>
/// 删除打卡流水 响应体
/// <para>删除员工从开放平台导入的打卡记录。删除后会重新计算打卡记录对应考勤任务结果。</para>
/// <para>接口ID：7473096091899805715</para>
/// <para>文档地址：https://open.feishu.cn/document/attendance-v1/user_task/batch_del</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fattendance-v1%2fuser_flow%2fbatch_del</para>
/// </summary>
public record PostAttendanceV1UserFlowsBatchDelResponseDto
{
    /// <summary>
    /// <para>删除成功的流水记录ID列表</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("success_record_ids")]
    public string[]? SuccessRecordIds { get; set; }

    /// <summary>
    /// <para>删除失败的流水记录ID列表</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("fail_record_ids")]
    public string[]? FailRecordIds { get; set; }
}
