// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-10-24
//
// Last Modified By : yxr
// Last Modified On : 2025-10-24
// ************************************************************************
// <copyright file="SecurityAndComplianceDeviceRecordDeviceChangeEventV2EventBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>设备信息变更事件 事件体</summary>
// ************************************************************************
namespace FeishuNetSdk.SecurityAndCompliance.Events;
/// <summary>
/// 设备信息变更事件 事件体
/// <para>使用该接口，可以订阅接收设备管理变更记录通知，包含设备新增、设备删除、设备归属变更、可信状态变更、设备特征如生产序列号、硬盘序列号等相关信息发生变化时事件通知{使用示例}(url=/api/tools/api_explore/api_explore_config?project=security_and_compliance&amp;version=v2&amp;resource=device_record&amp;event=device_change_event)</para>
/// <para>接口ID：7563551656446246914</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/security_and_compliance-v2/device_record/events/device_change_event</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fsecurity_and_compliance-v2%2fdevice_record%2fevents%2fdevice_change_event</para>
/// </summary>
public record SecurityAndComplianceDeviceRecordDeviceChangeEventV2EventBodyDto() : EventBodyDto("security_and_compliance.device_record.device_change_event_v2")
{
    /// <summary>
    /// <para>设备认证编码</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("device_record_id")]
    public string? DeviceRecordId { get; set; }

    /// <summary>
    /// <para>版本号</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}
