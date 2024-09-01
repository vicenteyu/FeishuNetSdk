// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-09-01
//
// Last Modified By : yxr
// Last Modified On : 2024-09-01
// ************************************************************************
// <copyright file="AcsAccessRecordCreatedV1EventBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>新增门禁访问记录 事件体</summary>
// ************************************************************************
namespace FeishuNetSdk.Acs.Events;
/// <summary>
/// 新增门禁访问记录 事件体
/// <para>门禁设备识别用户成功后发送该事件给订阅应用。{使用示例}(url=/api/tools/api_explore/api_explore_config?project=acs&amp;version=v1&amp;resource=access_record&amp;event=created)</para>
/// <para>接口ID：6979790924692013058</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/acs-v1/access_record/events/created</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2facs-v1%2faccess_record%2fevents%2fcreated</para>
/// </summary>
public record AcsAccessRecordCreatedV1EventBodyDto() : EventBodyDto("acs.access_record.created_v1")
{
    /// <summary>
    /// <para>门禁记录 ID</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("access_record_id")]
    public string? AccessRecordId { get; set; }

    /// <summary>
    /// <para>用户 ID</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("user_id")]
    public UserIdSuffix? UserId { get; set; }

    /// <summary>
    /// <para>设备 ID</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("device_id")]
    public string? DeviceId { get; set; }

    /// <summary>
    /// <para>是否打卡</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("is_clock_in")]
    public bool? IsClockIn { get; set; }

    /// <summary>
    /// <para>是否开门</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("is_door_open")]
    public bool? IsDoorOpen { get; set; }

    /// <summary>
    /// <para>识别时间 （单位：秒）</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("access_time")]
    public string? AccessTime { get; set; }
}
